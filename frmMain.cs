using System;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ASCOM.DriverAccess;
using XMLConfig;

namespace DDMAgent
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, Pack=4)]
    public struct order_telescope_slew
    {
        public uint   wSize;    // 信息体长度+4字节
        public ushort wType;    // 消息类型 == 5
        public ushort wCoorSys; // 坐标系. 1: 当前历元赤道系; 2: J2000赤道系; 3: 地平系; 4: 其它
        public double alpha;    // 赤道: 赤经; 地平: 方位, 量纲: 角度
        public double delta;    // 赤道: 赤纬; 地平: 俯仰, 量纲: 角度
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential, Pack=4)]
    public struct desc_telescope_position
    {
        public uint wSize;      // 信息体长度+4字节
        public ushort wType;    // 消息类型 == 2
        public double vLongitude;   // 地理经度
        public double vLatitude;		// 地理纬度, 量纲: 角度. 北纬为正
        public double vAltitude;		// 海拔高度, 量纲: 米
        // 时间. UTC
        public ushort wYear;			// 年
        public ushort wMonth;			// 月
        public ushort wDay;			// 天
        public ushort wHour;			// 时
        public ushort wMinute;		// 分
        public ushort wSecond;		// 秒
        public ushort wMilliSecond;	// 毫秒
        // 恒星时
        public double vST;			// 恒星时, 量纲: 小时
        /*! 望远镜工作状态
         * 0 : Error
         * 1 : Freeze
         * 2 : Homing
         * 3 : Homed
         * 4 : Parking
         * 5 : Parked
         * 6 : TrackFollow
         * 7 : TrackPosition
         * 8 : Pointing
         * 9 : JogSpeed
         * 10 : JogPosition
         * 11: TrackOrbit
         * 12: WaitingDome
         **/
        public ushort wState;
        // 实时位置
        public double vRealRA;		// 赤经, 当前历元. 量纲: 角度
        public double vRealDEC;		// 赤纬, 当前历元. 量纲: 角度
        public double vRealAzi;		// 方位, 量纲: 角度. 北零点
        public double vRealAlt;		// 俯仰, 量纲: 角度. 水平零点
        // 目标位置
        public double vTargetRA;		// 赤经, 当前历元. 量纲: 角度
        public double vTargetDEC;		// 赤纬, 当前历元. 量纲: 角度
        public double vTargetAzi;		// 方位, 量纲: 角度. 北零点
        public double vTargetAlt;		// 俯仰, 量纲: 角度. 水平零点
    }

	public partial class frmMain : Form
	{
		// 望远镜控制接口
		private Telescope IScope = null;
		// 调焦器控制接口
		private Focuser IFocus = null;
		// 自定义望远镜状态字
		/** 望远镜状态字
		 * 0  : 初始状态, 断开连接
		 * 1  : 静止
		 * 2  : 搜索零点中
		 * 3  : 搜索零点成功
		 * 4  : 指向中
		 * 5  : 跟踪中
		 * 6  : 轴控制中
		 * 7  : 复位中
		 * 8  : 复位
		 **/
		private const int TS_NONE = 0;
		private const int TS_Freeze = 1;
		private const int TS_Homing = 2;
		private const int TS_Homed = 3;
		private const int TS_Slewing = 4;
		private const int TS_Tracking = 5;
		private const int TS_Moving = 6;
		private const int TS_Parking = 7;
		private const int TS_Parked = 8;

		private AstroArith m_astro = null;
		// 自定义与望远镜的连接性
		/* 备注: Nov 18, 2011
		 * DDM60转台基于Autoslew实现控制. 经测试, 实例化对象后
		 * connected属性即为true
		 * 需要使用其它方法判断与转台的连接有效性
		 **/
		private bool m_bScopeConnect = false;
		// 自定义与调焦器的连接性
		private bool m_bFocusConnect = false;
		// 自定义望远镜状态字集
		private int m_iScopeState = TS_NONE;
        // 定位望远镜时, 会出现Autoslew提示到位, 但赤经仍有小幅度滑动现象
        // 通过记录判断赤经、赤纬连续变化阈值是否小于1角秒变更望远镜状态
        private double m_vOldRA = 0;    // 量纲: 角秒
        private double m_vOldDEC = 0;   // 量纲: 角秒
        private int m_nTrackRepeat = 0;
		// 错误描述
		private string m_strError = "";
/*--------------------------------------------------------------------------*/
		// 望远镜工作参数
		private double m_siteLongitude = 0;	// 地理经度
		private double m_siteLatitude = 0;  // 地理纬度
		private double m_siteElevation = 0; // 海拔高度

		private double m_horizonLimit = 20 * AstroArith.GtoR;
/*--------------------------------------------------------------------------*/
		// 网络通信
		public string m_serverIP = "127.0.0.1";
		public int m_serverPort = 6004;
        TcpClient m_sckClient = null;
        NetworkStream m_nsClient = null;
/*--------------------------------------------------------------------------*/
		// XML配置文件管理接口
		ManageConfig m_config = null;

        public object order_slew_bytes2struct(byte[] bytes, Type type)
        {// 指令信息: 序列化到结构体
            int size = Marshal.SizeOf(type);
            if (size > bytes.Length)
                return null;
            IntPtr structPtr = Marshal.AllocHGlobal(size);
            Marshal.Copy(bytes, 0, structPtr, size);
            object obj = Marshal.PtrToStructure(structPtr, type);
            Marshal.FreeHGlobal(structPtr);
            return obj;
        }

        public byte[] desc_position_struct2bytes(object obj)
        {// 位置信息: 结构体序列化
            int size = Marshal.SizeOf(obj);
            byte[] bytes = new byte[size];
            IntPtr structPtr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(obj, structPtr, false);
            Marshal.Copy(structPtr, bytes, 0, size);
            Marshal.FreeHGlobal(structPtr);
            return bytes;
        }

		public frmMain()
		{
			InitializeComponent();
            
			m_config = new ManageConfig(Environment.CurrentDirectory + "\\" + "DDMAgent.xml");
			m_astro = new AstroArith();
			tmrRefresh.Interval = 100;
			tmrRefresh.Enabled = false;
            tmrNetwork.Interval = 100;
            tmrNetwork.Enabled = false;

			m_serverIP = m_config.GetParamValue("Server", "IP", "127.0.0.1");
			m_serverPort = Convert.ToInt32(m_config.GetParamValue("Server", "Port", "0"));

			lblState.Text = "Unconnected";
			//cmbEpoch.SelectedIndex = 0;
			txtRA.Text = "00:00:00.00";
			txtDEC.Text = "+00:00:00.0";
		}
		
		// 退出应用程序
		private void submenuExit_Click(object sender, EventArgs e)
		{
			m_config.SetParamValue("Server", "IP", m_serverIP);
			m_config.SetParamValue("Server", "Port", Convert.ToString(m_serverPort));

            //断开望远镜
            if (null != IScope)
            {
                IScope.Connected = false;
            }
            
            ////断开调焦器
            //if (null != IFocus && IFocus.Connected == true)
            //{
            //    IFocus.Connected = false;
            //}

			// 关闭线程
			if (tmrRefresh.Enabled == true) tmrRefresh.Enabled = false;
            if (tmrNetwork.Enabled == true) tmrNetwork.Enabled = false;
            if (timerFocusStatus.Enabled == true) timerFocusStatus.Enabled = false;
			// 恢复望远镜至安全位置
			if (IScope != null) IScope.Dispose();
			if (IFocus != null) IFocus.Dispose();
			// 断开网络连接
            if (m_sckClient != null)
            {
                m_sckClient.Close();
                m_sckClient = null;
            }

			// 退出程序
			this.Close();
		}

        //尝试与调焦器建立连接，如果失败返回false
        //private bool Conn

		// 尝试与望远镜建立一次连接. 如果失败返回false
		private bool ConnectTelescope()
		{
			bool bSuccess = true;

			try
			{
				string progID = null;	// 设备驱动标志
				if (IScope == null)
				{
					progID = m_config.GetParamValue("Instrument", "Telescope Prog ID", "");
					if (progID == "")
					{
                        progID = Telescope.Choose("AstrooptikServer.Telescope");
						if (progID == null || progID == "")
						{
                            MessageBox.Show("Cound not find \'Astrooptik Server Telescope\'");
							return false;
						}
						else m_config.SetParamValue("Instrument", "Telescope Prog ID", progID); // 保存望远镜名称
					}
                    else
					    IScope = new Telescope(progID);
				}
                if (IScope != null)
                {
                    IScope.Connected = true;
                    m_bScopeConnect = true;
                }
				m_siteLongitude = IScope.SiteLongitude;
				m_siteLatitude = IScope.SiteLatitude;
				m_siteElevation = IScope.SiteElevation;
				m_astro.SetGeoSite(m_siteLongitude * AstroArith.GtoR, m_siteLatitude * AstroArith.GtoR, m_siteElevation);

				m_iScopeState = TS_Freeze;
				lblState.Text = "Stopped";
				submenuTelescopeConnect.Enabled = false;
				submenuTelescopeDisconnect.Enabled = true;
				if (tmrRefresh.Enabled == false) tmrRefresh.Enabled = true;
			}
			catch(COMException ex)
			{
				m_strError = ex.Message;
				bSuccess = false;
			}
			return bSuccess;
		}

		// 尝试与调焦机构建立一次连接, 如果失败返回false
		private bool ConnectFocus()
		{
			bool bSuccess = true;

			try
			{
				string progID = "";
				if (IFocus == null || IFocus.Link == false)
				{
					if (IFocus == null)
					{
						progID = m_config.GetParamValue("Instrument", "Focuser Prog ID", "");
						if (progID == null || progID == "")
						{
                            progID = Focuser.Choose("ACCServer.Focuser");//ACCServer.Focuser  AstrooptikServer.Focuser
							if (progID == null || progID == "")
                                MessageBox.Show("Could not find \'ACCServer.Focuser\'");
							else m_config.SetParamValue("Instrument", "Focuser Prog ID", progID);//保存调焦器名称
						}
                        else
                            IFocus = new Focuser(progID); 
					}
                    if (IFocus != null)
                    {
                        IFocus.Link = true;
                        m_bFocusConnect = IFocus.Link;
                    }
				}
                if (timerFocusStatus.Enabled == false)
                {
                    timerFocusStatus.Enabled = true;
                }
			}
			catch(COMException ex)
			{
				bSuccess = false;
				m_strError = ex.Message;
			}

			return bSuccess;
		}

		// 建立与望远镜的连接, 并变更菜单栏可用状态
		private void submenuTelescopeConnect_Click(object sender, EventArgs e)
		{
			if (!ConnectTelescope()) {// 尝试连接
				MessageBox.Show("连接望远镜失败!\r\n" + m_strError);
				return;
			}

            //连接调焦器
            if (!ConnectFocus())
            {
                MessageBox.Show("连接调焦器失败!\r\n" + m_strError);
                return;
            }

		}

		/*! 断开与望远镜的连接, 并变更菜单栏可用状态
		 *  经测试, 通过驱动并不能真正断开与望远镜(DDM60)的连接
		 *  标注: 卢晓猛, 2011-11-14
		 **/
		private void submenuTelescopeDisconnect_Click(object sender, EventArgs e)
		{
			// 仅停止定时器, 并非实际断开与望远镜的连接
			// 需望远镜的实际断开, 需要退出Autoslew
			// 与望远镜断开前, 需复位并等待复位完成
			tmrRefresh.Enabled = false;
            timerFocusStatus.Enabled = false;
			m_bScopeConnect = false;
            IScope.Connected = false;
            //if(IFocus != null && IFocus.Connected == true) IFocus.Connected = false;
			submenuTelescopeConnect.Enabled = true;
			submenuTelescopeDisconnect.Enabled = false;
		}

		// 建立与服务器的网络连接, 并变更菜单栏可用状态
		private void submenuServerConnect_Click(object sender, EventArgs e)
		{
			// 建立与服务器的网络连接
            m_sckClient = new TcpClient();
            m_sckClient.Connect(m_serverIP, m_serverPort);
            if (m_sckClient.Connected)
            {
                m_nsClient = m_sckClient.GetStream();
                // 检查是否已经建立与服务器的网络连接, 并改变菜单状态
                submenuServerConnect.Enabled = false;
                submenuServerDisconnect.Enabled = true;

                tmrNetwork.Enabled = true;
            }
		}

		// 断开与服务器的网络连接, 并变更菜单栏可用状态
		private void submenuServerDisconnect_Click(object sender, EventArgs e)
		{
            tmrNetwork.Enabled = false;
			// 断开与服务器的网络连接
            m_sckClient.Close();
            m_sckClient = null;
			// 检查是否已经断开与服务器的网络连接, 并改变菜单状态
			submenuServerConnect.Enabled = true;
			submenuServerDisconnect.Enabled = false;
		}

		// 使用定时器代替线程, 定时查询转台工作状态
		private void tmrRefresh_Tick(object sender, EventArgs e)
		{
			try
			{
				DateTime utc = DateTime.Now.ToUniversalTime();
				double st = IScope.SiderealTime;
				int hour = 0;
				int minute = 0;
				double second = 0;
                //从系统获取当前时间
				lblDate.Text = string.Format("{0}-{1:00}-{2:00}", utc.Year, utc.Month, utc.Day);
				lblUT.Text = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", utc.Hour, utc.Minute, utc.Second, utc.Millisecond / 10);
				m_astro.HH2HMS(st, ref hour, ref minute, ref second);
				lblST.Text = string.Format("{0:00}:{1:00}:{2:00.00}", hour, minute, second);
                //从转台获取赤经、赤纬、方位、俯仰
                double ra = IScope.RightAscension * 15 * 3600;
                double dec = IScope.Declination * 3600;
                double azi = IScope.Azimuth;
				double alt = IScope.Altitude;
				int degree = 0;
				string sign = "";
                //显示到界面
                m_astro.HH2HMS(IScope.RightAscension, ref hour, ref minute, ref second);
				lblRA.Text = string.Format("{0:00}:{1:00}:{2:00.00}", hour, minute, second);
                m_astro.DD2DMS(IScope.Declination, ref degree, ref minute, ref second, ref sign);
				lblDEC.Text = sign + string.Format("{0:00}:{1:00}:{2:00.0}", degree, minute, second);
				m_astro.DD2DMS(azi, ref degree, ref minute, ref second, ref sign);
				lblAzi.Text = sign + string.Format("{0:00}:{1:00}:{2:00.0}", degree, minute, second);
				m_astro.DD2DMS(alt, ref degree, ref minute, ref second, ref sign);
				lblAlt.Text = sign + string.Format("{0:00}:{1:00}:{2:00.0}", degree, minute, second);

                desc_telescope_position desc = new desc_telescope_position();

				switch (m_iScopeState)
				{
					case TS_Freeze:
						if (IScope.Slewing)
						{
							m_iScopeState = TS_Slewing;
							lblState.Text = "Slew...";
						}
						else if (IScope.Tracking)
						{
                            if (Math.Abs(ra - m_vOldRA) < 1 && Math.Abs(dec - m_vOldDEC) < 1)
                                m_nTrackRepeat++;
                            else
                            {
                                m_vOldRA = ra;
                                m_vOldDEC = dec;
                                m_nTrackRepeat = 0;
                            }
                            if (m_nTrackRepeat > 5)
                            {
                                m_iScopeState = TS_Tracking;
                                lblState.Text = "Tracking...";
                            }
						}
						else if (IScope.AtHome)
						{
							m_iScopeState = TS_Homed;
							lblState.Text = "Homed";
						}
						else if (IScope.AtPark)
						{
							m_iScopeState = TS_Parked;
							lblState.Text = "Parked";
						}
						break;
					case TS_Homing:
						if (IScope.AtHome)
						{
							m_iScopeState = TS_Homed;
							lblState.Text = "Homed";
						}
						break;
					case TS_Parking:
						if (IScope.AtPark)
						{
							m_iScopeState = TS_Parked;
							lblState.Text = "Parked";
						}
						break;
					case TS_Slewing:
                        if (!IScope.Slewing)
                        {
                            if (Math.Abs(ra - m_vOldRA) < 1 && Math.Abs(dec - m_vOldDEC) < 1)
                                m_nTrackRepeat++;
                            else
                            {
                                m_vOldRA = ra;
                                m_vOldDEC = dec;
                                m_nTrackRepeat = 0;
                            }
                            if (m_nTrackRepeat > 10)
                            {
                                m_iScopeState = TS_Tracking;
                                lblState.Text = "Tracking...";
                            }
                        }
						break;
					default:
						break;
				}

                if (m_sckClient != null && m_sckClient.Connected == true)
                {// 定时发送望远镜位置
                    desc.wSize = (uint) (Marshal.SizeOf(desc) - 4);
                    desc.wType = 2;
                    desc.vLongitude = m_siteLongitude;
                    desc.vLatitude = m_siteLatitude;
                    desc.vAltitude = m_siteElevation;
                    desc.wYear = (ushort) utc.Year;
                    desc.wMonth = (ushort) utc.Month;
                    desc.wDay = (ushort) utc.Day;
                    desc.wHour = (ushort) utc.Hour;
                    desc.wMinute = (ushort) utc.Minute;
                    desc.wSecond = (ushort) utc.Second;
                    desc.wMilliSecond = (ushort) utc.Millisecond;
                    desc.vST = st;
                    desc.wState = (ushort) m_iScopeState;
                    desc.vRealRA = ra / 3600;
                    desc.vRealDEC = dec / 3600;
                    desc.vRealAzi = azi;
                    desc.vRealAlt = alt;
                    desc.vTargetRA = 0;
                    desc.vTargetDEC = 0;
                    desc.vTargetAzi = 0;
                    desc.vTargetAlt = 0;

                    var buffer = desc_position_struct2bytes(desc);
                    m_nsClient.Write(buffer, 0, buffer.Length);
                }
			}
			catch(COMException COMexp)
			{
				m_strError = COMexp.ToString();
				m_bScopeConnect = false;
				tmrRefresh.Enabled = false;
				IScope.Dispose();
				IScope = null;

				submenuTelescopeConnect.Enabled = true;
				submenuTelescopeDisconnect.Enabled = false;
			}
		}

		private void btnFindHome_Click(object sender, EventArgs e)
		{
			if (!m_bScopeConnect) return;
			if (!IScope.CanFindHome) return;
			if (IScope.AtPark == true) IScope.Unpark();
			m_iScopeState = TS_Homing;
			lblState.Text = "Homing...";
			IScope.FindHome();
		}

		private void btnPark_Click(object sender, EventArgs e)
		{
			if (!m_bScopeConnect) return;
			if (!IScope.CanPark) return;
			if (IScope.AtPark) IScope.Unpark();
			m_iScopeState = TS_Parking;
			lblState.Text = "Parking...";
			IScope.Park();
		}

		private void btnSlew_Click(object sender, EventArgs e)
		{
			if (!m_bScopeConnect) return;
			string strRA = txtRA.Text;
			string strDE = txtDEC.Text;
			//string strEP = cmbEpoch.Text;
			double inRA = 0;
			double inDE = 0;
			double inEP = 0;

			// 格式判断
			if (!m_astro.StringHour2Double(strRA, ref inRA))
			{
				MessageBox.Show("赤经输入格式错误!");
				return;
			}
			if (!m_astro.StringDegree2Double(strDE, ref inDE))
			{
				MessageBox.Show("赤纬输入格式错误!");
				return;
			}
			// 历元转换
            //if (strEP != "Real")
            //{
            //    DateTime utc = DateTime.Now.ToUniversalTime();
            //    double realEP = m_astro.GetEpoch(utc.Year, utc.Month, utc.Day, utc.Hour + utc.Minute / 60.0 + utc.Second / 3600.0);
            //    double realRA = 0;
            //    double realDE = 0;

            //    if (strEP == "B1950") inEP = 1950;
            //    else inEP = 2000;
            //    inEP = m_astro.Epoch2JD(inEP);
            //    realEP = m_astro.Epoch2JD(realEP);
            //    m_astro.Epoch2Actual(inEP, inRA * 15 * AstroArith.GtoR, inDE * AstroArith.GtoR, realEP, ref realRA, ref realDE);
            //    inRA = realRA * AstroArith.RtoG / 15;	// 弧度->小时
            //    inDE = realDE * AstroArith.RtoG;		// 弧度->角度
            //}
			// 水平限位判断, 默认必须高于20度
			if (!m_astro.IsAboveLimit((IScope.SiderealTime - inRA) * 15 * AstroArith.GtoR, inDE * AstroArith.GtoR, m_horizonLimit)) {
				MessageBox.Show("超出水平限位范围!");
				return;
			}
            
			IScope.TargetRightAscension = inRA;
			IScope.TargetDeclination = inDE;

			if (IScope.AtPark) IScope.Unpark();
			if (IScope.Tracking == false) IScope.Tracking = true;

			m_iScopeState = TS_Slewing;
			lblState.Text = "Slew...";
			if (IScope.CanSlewAsync) IScope.SlewToTargetAsync();
			else IScope.SlewToTarget();
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			if (!m_bScopeConnect) return;
			if (IScope.AtPark) IScope.Unpark();
			IScope.AbortSlew();
		}

		// 配置网络参数
		private void submenuParamNet_Click(object sender, EventArgs e)
		{
			frmParamNet OTServer = new frmParamNet(this);
			OTServer.StartPosition = FormStartPosition.CenterParent;
			OTServer.Show();
		}

        // 定时检查网络消息
        private void tmrNetwork_Tick(object sender, EventArgs e)
        {
            if (m_sckClient != null && m_sckClient.Connected == true && m_sckClient.Available > 0)
            {
                order_telescope_slew order = new order_telescope_slew();
                byte[] bytes = new byte[1024];
                int numRead = m_nsClient.Read(bytes, 0, bytes.Length);
                order = (order_telescope_slew)order_slew_bytes2struct(bytes, typeof(order_telescope_slew));
                txtRA.Text = Convert.ToString(order.alpha / 15);
                txtDEC.Text = Convert.ToString(order.delta);
                //cmbEpoch.Text = "Real";

                if (!m_bScopeConnect) return;
                string strRA = txtRA.Text;
                string strDE = txtDEC.Text;
                //string strEP = cmbEpoch.Text;
                double inRA = 0;
                double inDE = 0;
                double inEP = 0;

                // 格式判断
                if (!m_astro.StringHour2Double(strRA, ref inRA))
                {
//                    MessageBox.Show("赤经输入格式错误!");
                    return;
                }
                if (!m_astro.StringDegree2Double(strDE, ref inDE))
                {
//                    MessageBox.Show("赤纬输入格式错误!");
                    return;
                }
                // 历元转换
                //if (strEP != "Real")
                //{
                //    DateTime utc = DateTime.Now.ToUniversalTime();
                //    double realEP = m_astro.GetEpoch(utc.Year, utc.Month, utc.Day, utc.Hour + utc.Minute / 60.0 + utc.Second / 3600.0);
                //    double realRA = 0;
                //    double realDE = 0;

                //    if (strEP == "B1950") inEP = 1950;
                //    else inEP = 2000;
                //    inEP = m_astro.Epoch2JD(inEP);
                //    realEP = m_astro.Epoch2JD(realEP);
                //    m_astro.Epoch2Actual(inEP, inRA * 15 * AstroArith.GtoR, inDE * AstroArith.GtoR, realEP, ref realRA, ref realDE);
                //    inRA = realRA * AstroArith.RtoG / 15;	// 弧度->小时
                //    inDE = realDE * AstroArith.RtoG;		// 弧度->角度
                //}
                // 水平限位判断, 默认必须高于20度
                if (!m_astro.IsAboveLimit((IScope.SiderealTime - inRA) * 15 * AstroArith.GtoR, inDE * AstroArith.GtoR, m_horizonLimit))
                {
//                    MessageBox.Show("超出水平限位范围!");
                    return;
                }

                IScope.TargetRightAscension = inRA;
                IScope.TargetDeclination = inDE;

                if (IScope.AtPark) IScope.Unpark();
                if (IScope.Tracking == false) IScope.Tracking = true;

                m_iScopeState = TS_Slewing;
                lblState.Text = "Slew...";
                if (IScope.CanSlewAsync) IScope.SlewToTargetAsync();
                else IScope.SlewToTarget();
            }
        }

        private void timerFocusStatus_Tick(object sender, EventArgs e)
        {
            
            try
            {
                if (null != IFocus)
                {
                    //定时刷新当前位置
                    labelFocusCurPos.Text = (IFocus.Position / 1000.0).ToString("f3");

                        //string.Format("{0}", IFocus.Position / 1000.0);

                    //定时刷新当前移动状态
                    if (IFocus.IsMoving == true)
                    {
                        labelFocusCurStatus.Text = "Moving...";
                    }
                    else
                        labelFocusCurStatus.Text = "Stopped";

                    //定时刷新当前温度
                    labelFocusCurTemp.Text = IFocus.Temperature.ToString("f1");

                    //刷新进度条位置
                    progressBarFocus.Value = (int)(IFocus.Position / 30000.0 * 100);

                    //刷新转台信息
                    textBoxTeleInfo.Text = "AlignmentMode: " + IScope.AlignmentMode.ToString();
                    textBoxTeleInfo.Text += "Altitude: " + IScope.Altitude.ToString();
                    textBoxTeleInfo.Text += "ApertureArea" + IScope.ApertureArea.ToString();
                    textBoxTeleInfo.Text += "ApertureDiameter" + IScope.ApertureDiameter.ToString();
                    textBoxTeleInfo.Text += "AtHome" + IScope.AtHome.ToString();
                    textBoxTeleInfo.Text += "AtPark" + IScope.AtPark.ToString();
                    textBoxTeleInfo.Text += "Azimuth" + IScope.Azimuth.ToString();
                    textBoxTeleInfo.Text += "CanFindHome" + IScope.CanFindHome.ToString();
                    textBoxTeleInfo.Text += "CanPark" + IScope.CanPark.ToString();
                    textBoxTeleInfo.Text += "CanPulseGuide" + IScope.CanPulseGuide.ToString();
                    textBoxTeleInfo.Text += "CanSetDeclinationRate" + IScope.CanSetDeclinationRate.ToString();
                    textBoxTeleInfo.Text += "CanSetGuideRates" + IScope.CanSetGuideRates.ToString();
                    textBoxTeleInfo.Text += "CanSetPark" + IScope.CanSetPark.ToString();
                    textBoxTeleInfo.Text += "CanSetPierSide" + IScope.CanSetPierSide.ToString();
                    textBoxTeleInfo.Text += "CanSetRightAscensionRate" + IScope.CanSetRightAscensionRate.ToString();
                    //textBoxTeleInfo.Text+=""+IScope.
   
                }
                
            }
            catch (System.Exception ex)
            {
                m_strError = ex.Message;
            }
        }

        private void buttonFocusStartMove_Click(object sender, EventArgs e)
        {
            try
            {
                //获取位置
                double pos = 0;
                pos = Convert.ToDouble(textBoxFocusPos.Text) * 1000;
                pos = System.Math.Round(pos);
                if (IFocus != null && IFocus.Connected == true)
                {
                    IFocus.Move((int)pos);
                }
            }
            catch (System.Exception ex)
            {
                m_strError = ex.Message;
            }
        }

        private void buttonFocusStepMoveInc_Click(object sender, EventArgs e)
        {
            try
            {
                //从界面获取步长
                double step = 0;
                int pos = 0;
                step = Convert.ToDouble(textBoxFocusStep.Text) * 1000;
                //移动
                if (IFocus != null && IFocus.Connected == true)
                {
                    pos = IFocus.Position;
                    IFocus.Move(pos + (int)step);
                }
            }
            catch (System.Exception ex)
            {
                m_strError = ex.Message;
            }
        }

        private void buttonFocusStepMoveDec_Click(object sender, EventArgs e)
        {
            try
            {
                //从界面获取步长
                double step = 0;
                int pos = 0;
                step = Convert.ToDouble(textBoxFocusStep.Text) * 1000;
                //移动
                if (IFocus != null && IFocus.Connected == true)
                {
                    pos = IFocus.Position;
                    IFocus.Move(pos - (int)step);
                }
            }
            catch (System.Exception ex)
            {
                m_strError = ex.Message;
            }
        }

        private void buttonFocusStopMove_Click(object sender, EventArgs e)
        {
            try
            {
                if (IFocus != null && IFocus.Connected == true)
                {
                    IFocus.Halt();
                }
            }
            catch (System.Exception ex)
            {
                m_strError = ex.Message;
            }
        }

        private void buttonTeleSlewN_Click(object sender, EventArgs e)
        {
            //textBoxTeleInfo.Text = IScope.AlignmentMode.ToString();
            textBoxTeleInfo.Text = IScope.AtPark.ToString();
        }
	}
}
