namespace DDMAgent
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuTelescopeConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuTelescopeDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.submenuServerConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuServerDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.submenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuParameter = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuParamNet = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.groupTime = new System.Windows.Forms.GroupBox();
            this.lblUT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblST = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAzi = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAlt = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRA = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDEC = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grpPoint = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSlew = new System.Windows.Forms.Button();
            this.cmbEpoch = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.txtDEC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnPark = new System.Windows.Forms.Button();
            this.btnFindHome = new System.Windows.Forms.Button();
            this.tmrNetwork = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupTime.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpPoint.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSystem,
            this.menuParameter});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(539, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuSystem
            // 
            this.menuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuTelescopeConnect,
            this.submenuTelescopeDisconnect,
            this.toolStripMenuItem1,
            this.submenuServerConnect,
            this.submenuServerDisconnect,
            this.toolStripMenuItem2,
            this.submenuExit});
            this.menuSystem.Name = "menuSystem";
            this.menuSystem.Size = new System.Drawing.Size(59, 21);
            this.menuSystem.Text = "系统(&S)";
            // 
            // submenuTelescopeConnect
            // 
            this.submenuTelescopeConnect.Name = "submenuTelescopeConnect";
            this.submenuTelescopeConnect.Size = new System.Drawing.Size(152, 22);
            this.submenuTelescopeConnect.Text = "连接望远镜";
            this.submenuTelescopeConnect.ToolTipText = "建立与望远镜的连接";
            this.submenuTelescopeConnect.Click += new System.EventHandler(this.submenuTelescopeConnect_Click);
            // 
            // submenuTelescopeDisconnect
            // 
            this.submenuTelescopeDisconnect.Enabled = false;
            this.submenuTelescopeDisconnect.Name = "submenuTelescopeDisconnect";
            this.submenuTelescopeDisconnect.Size = new System.Drawing.Size(152, 22);
            this.submenuTelescopeDisconnect.Text = "断开望远镜";
            this.submenuTelescopeDisconnect.ToolTipText = "断开与望远镜的连接";
            this.submenuTelescopeDisconnect.Click += new System.EventHandler(this.submenuTelescopeDisconnect_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // submenuServerConnect
            // 
            this.submenuServerConnect.Name = "submenuServerConnect";
            this.submenuServerConnect.Size = new System.Drawing.Size(152, 22);
            this.submenuServerConnect.Text = "连接服务器";
            this.submenuServerConnect.ToolTipText = "建立与服务器的网络连接";
            this.submenuServerConnect.Click += new System.EventHandler(this.submenuServerConnect_Click);
            // 
            // submenuServerDisconnect
            // 
            this.submenuServerDisconnect.Enabled = false;
            this.submenuServerDisconnect.Name = "submenuServerDisconnect";
            this.submenuServerDisconnect.Size = new System.Drawing.Size(152, 22);
            this.submenuServerDisconnect.Text = "断开服务器";
            this.submenuServerDisconnect.ToolTipText = "断开与服务器的网络连接";
            this.submenuServerDisconnect.Click += new System.EventHandler(this.submenuServerDisconnect_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // submenuExit
            // 
            this.submenuExit.Name = "submenuExit";
            this.submenuExit.Size = new System.Drawing.Size(152, 22);
            this.submenuExit.Text = "退出";
            this.submenuExit.ToolTipText = "释放资源并退出程序";
            this.submenuExit.Click += new System.EventHandler(this.submenuExit_Click);
            // 
            // menuParameter
            // 
            this.menuParameter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuParamNet});
            this.menuParameter.Name = "menuParameter";
            this.menuParameter.Size = new System.Drawing.Size(59, 21);
            this.menuParameter.Text = "参数(&P)";
            // 
            // submenuParamNet
            // 
            this.submenuParamNet.Name = "submenuParamNet";
            this.submenuParamNet.Size = new System.Drawing.Size(152, 22);
            this.submenuParamNet.Text = "服务器...";
            this.submenuParamNet.Click += new System.EventHandler(this.submenuParamNet_Click);
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // groupTime
            // 
            this.groupTime.Controls.Add(this.lblUT);
            this.groupTime.Controls.Add(this.label3);
            this.groupTime.Controls.Add(this.lblST);
            this.groupTime.Controls.Add(this.label4);
            this.groupTime.Controls.Add(this.lblDate);
            this.groupTime.Controls.Add(this.label1);
            this.groupTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupTime.ForeColor = System.Drawing.Color.Blue;
            this.groupTime.Location = new System.Drawing.Point(10, 30);
            this.groupTime.Name = "groupTime";
            this.groupTime.Size = new System.Drawing.Size(180, 105);
            this.groupTime.TabIndex = 1;
            this.groupTime.TabStop = false;
            this.groupTime.Text = "时间信息";
            // 
            // lblUT
            // 
            this.lblUT.BackColor = System.Drawing.Color.Black;
            this.lblUT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUT.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUT.ForeColor = System.Drawing.Color.Lime;
            this.lblUT.Location = new System.Drawing.Point(80, 50);
            this.lblUT.Name = "lblUT";
            this.lblUT.Size = new System.Drawing.Size(90, 18);
            this.lblUT.TabIndex = 1;
            this.lblUT.Text = "00:00:00.0";
            this.lblUT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "世界时:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblST
            // 
            this.lblST.BackColor = System.Drawing.Color.Black;
            this.lblST.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblST.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblST.ForeColor = System.Drawing.Color.Lime;
            this.lblST.Location = new System.Drawing.Point(80, 75);
            this.lblST.Name = "lblST";
            this.lblST.Size = new System.Drawing.Size(90, 18);
            this.lblST.TabIndex = 2;
            this.lblST.Text = "00:00:00.0";
            this.lblST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(10, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "恒星时:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Black;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDate.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDate.ForeColor = System.Drawing.Color.Lime;
            this.lblDate.Location = new System.Drawing.Point(80, 25);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(90, 18);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "2011-01-01";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "日  期:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAzi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblAlt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblState);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblRA);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblDEC);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(195, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 105);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "望远镜信息";
            // 
            // lblAzi
            // 
            this.lblAzi.BackColor = System.Drawing.Color.Black;
            this.lblAzi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAzi.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAzi.ForeColor = System.Drawing.Color.Lime;
            this.lblAzi.Location = new System.Drawing.Point(70, 75);
            this.lblAzi.Name = "lblAzi";
            this.lblAzi.Size = new System.Drawing.Size(95, 18);
            this.lblAzi.TabIndex = 5;
            this.lblAzi.Text = "000:00:00.0";
            this.lblAzi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(10, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "方位:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAlt
            // 
            this.lblAlt.BackColor = System.Drawing.Color.Black;
            this.lblAlt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAlt.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAlt.ForeColor = System.Drawing.Color.Lime;
            this.lblAlt.Location = new System.Drawing.Point(225, 75);
            this.lblAlt.Name = "lblAlt";
            this.lblAlt.Size = new System.Drawing.Size(95, 18);
            this.lblAlt.TabIndex = 7;
            this.lblAlt.Text = "00:00:00.0";
            this.lblAlt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(165, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "俯仰:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblState
            // 
            this.lblState.BackColor = System.Drawing.Color.Black;
            this.lblState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblState.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblState.ForeColor = System.Drawing.Color.Lime;
            this.lblState.Location = new System.Drawing.Point(70, 25);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(95, 18);
            this.lblState.TabIndex = 3;
            this.lblState.Text = "Freeze";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(10, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "状态:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRA
            // 
            this.lblRA.BackColor = System.Drawing.Color.Black;
            this.lblRA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRA.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRA.ForeColor = System.Drawing.Color.Lime;
            this.lblRA.Location = new System.Drawing.Point(70, 50);
            this.lblRA.Name = "lblRA";
            this.lblRA.Size = new System.Drawing.Size(95, 18);
            this.lblRA.TabIndex = 4;
            this.lblRA.Text = "00:00:00.00";
            this.lblRA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(10, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "赤经:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDEC
            // 
            this.lblDEC.BackColor = System.Drawing.Color.Black;
            this.lblDEC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDEC.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDEC.ForeColor = System.Drawing.Color.Lime;
            this.lblDEC.Location = new System.Drawing.Point(225, 50);
            this.lblDEC.Name = "lblDEC";
            this.lblDEC.Size = new System.Drawing.Size(95, 18);
            this.lblDEC.TabIndex = 6;
            this.lblDEC.Text = "+00:00:00.0";
            this.lblDEC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(165, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "赤纬:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpPoint
            // 
            this.grpPoint.Controls.Add(this.btnStop);
            this.grpPoint.Controls.Add(this.btnSlew);
            this.grpPoint.Controls.Add(this.cmbEpoch);
            this.grpPoint.Controls.Add(this.label5);
            this.grpPoint.Controls.Add(this.txtRA);
            this.grpPoint.Controls.Add(this.txtDEC);
            this.grpPoint.Controls.Add(this.label2);
            this.grpPoint.Controls.Add(this.label13);
            this.grpPoint.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpPoint.ForeColor = System.Drawing.Color.Blue;
            this.grpPoint.Location = new System.Drawing.Point(170, 160);
            this.grpPoint.Name = "grpPoint";
            this.grpPoint.Size = new System.Drawing.Size(310, 115);
            this.grpPoint.TabIndex = 3;
            this.grpPoint.TabStop = false;
            this.grpPoint.Text = "指    向";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Yellow;
            this.btnStop.ForeColor = System.Drawing.Color.Black;
            this.btnStop.Location = new System.Drawing.Point(210, 65);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(90, 28);
            this.btnStop.TabIndex = 14;
            this.btnStop.Text = "停  止";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnSlew
            // 
            this.btnSlew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSlew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSlew.Location = new System.Drawing.Point(210, 20);
            this.btnSlew.Name = "btnSlew";
            this.btnSlew.Size = new System.Drawing.Size(90, 28);
            this.btnSlew.TabIndex = 13;
            this.btnSlew.Text = "指  向";
            this.btnSlew.UseVisualStyleBackColor = false;
            this.btnSlew.Click += new System.EventHandler(this.btnSlew_Click);
            // 
            // cmbEpoch
            // 
            this.cmbEpoch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbEpoch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEpoch.ForeColor = System.Drawing.Color.Red;
            this.cmbEpoch.FormattingEnabled = true;
            this.cmbEpoch.Items.AddRange(new object[] {
            "J2000",
            "B1950",
            "Real"});
            this.cmbEpoch.Location = new System.Drawing.Point(70, 81);
            this.cmbEpoch.Name = "cmbEpoch";
            this.cmbEpoch.Size = new System.Drawing.Size(120, 24);
            this.cmbEpoch.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(10, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "历元:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRA
            // 
            this.txtRA.BackColor = System.Drawing.Color.Khaki;
            this.txtRA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtRA.Location = new System.Drawing.Point(70, 20);
            this.txtRA.MaxLength = 15;
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(120, 26);
            this.txtRA.TabIndex = 2;
            this.txtRA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDEC
            // 
            this.txtDEC.BackColor = System.Drawing.Color.Khaki;
            this.txtDEC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtDEC.Location = new System.Drawing.Point(70, 50);
            this.txtDEC.MaxLength = 15;
            this.txtDEC.Name = "txtDEC";
            this.txtDEC.Size = new System.Drawing.Size(120, 26);
            this.txtDEC.TabIndex = 2;
            this.txtDEC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "赤纬:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(10, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 18);
            this.label13.TabIndex = 1;
            this.label13.Text = "赤经:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPark
            // 
            this.btnPark.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPark.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPark.ForeColor = System.Drawing.Color.Red;
            this.btnPark.Location = new System.Drawing.Point(10, 220);
            this.btnPark.Name = "btnPark";
            this.btnPark.Size = new System.Drawing.Size(125, 38);
            this.btnPark.TabIndex = 9;
            this.btnPark.Text = "复  位";
            this.btnPark.UseVisualStyleBackColor = false;
            this.btnPark.Click += new System.EventHandler(this.btnPark_Click);
            // 
            // btnFindHome
            // 
            this.btnFindHome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFindHome.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFindHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFindHome.Location = new System.Drawing.Point(10, 160);
            this.btnFindHome.Name = "btnFindHome";
            this.btnFindHome.Size = new System.Drawing.Size(125, 38);
            this.btnFindHome.TabIndex = 8;
            this.btnFindHome.Text = "搜索零点";
            this.btnFindHome.UseVisualStyleBackColor = false;
            this.btnFindHome.Click += new System.EventHandler(this.btnFindHome_Click);
            // 
            // tmrNetwork
            // 
            this.tmrNetwork.Tick += new System.EventHandler(this.tmrNetwork_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 293);
            this.Controls.Add(this.btnFindHome);
            this.Controls.Add(this.btnPark);
            this.Controls.Add(this.grpPoint);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupTime);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "DDM60转台控制代理器";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupTime.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grpPoint.ResumeLayout(false);
            this.grpPoint.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSystem;
        private System.Windows.Forms.ToolStripMenuItem submenuTelescopeConnect;
        private System.Windows.Forms.ToolStripMenuItem submenuTelescopeDisconnect;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem submenuServerConnect;
        private System.Windows.Forms.ToolStripMenuItem submenuServerDisconnect;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem submenuExit;
		private System.Windows.Forms.ToolStripMenuItem menuParameter;
        private System.Windows.Forms.Timer tmrRefresh;
		private System.Windows.Forms.GroupBox groupTime;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.Label lblUT;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblST;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblAzi;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblAlt;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lblRA;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblDEC;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox grpPoint;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox cmbEpoch;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtDEC;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Button btnSlew;
		private System.Windows.Forms.Button btnPark;
		private System.Windows.Forms.Button btnFindHome;
		private System.Windows.Forms.Label lblState;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ToolStripMenuItem submenuParamNet;
		private System.Windows.Forms.TextBox txtRA;
        private System.Windows.Forms.Timer tmrNetwork;
    }
}
