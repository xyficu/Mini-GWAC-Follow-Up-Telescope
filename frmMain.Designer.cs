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
            this.menuFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuParamNetOT = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuOTList = new System.Windows.Forms.ToolStripMenuItem();
            this.服务AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.lblUT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblST = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxTeleInfo = new System.Windows.Forms.TextBox();
            this.buttonTeleSlewSW = new System.Windows.Forms.Button();
            this.buttonTeleSlewNW = new System.Windows.Forms.Button();
            this.buttonTeleSlewSE = new System.Windows.Forms.Button();
            this.buttonTeleSlewNE = new System.Windows.Forms.Button();
            this.buttonTeleSlewW = new System.Windows.Forms.Button();
            this.buttonTeleSlewE = new System.Windows.Forms.Button();
            this.buttonTeleSlewN = new System.Windows.Forms.Button();
            this.buttonTeleSlewS = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnFindHome = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPark = new System.Windows.Forms.Button();
            this.txtDEC = new System.Windows.Forms.TextBox();
            this.btnSlew = new System.Windows.Forms.Button();
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
            this.tmrNetwork = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.timerFocusStatus = new System.Windows.Forms.Timer(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labelFocusCurTemp = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelFocusCurStatus = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.progressBarFocus = new System.Windows.Forms.ProgressBar();
            this.buttonFocusStopMove = new System.Windows.Forms.Button();
            this.buttonFocusStartMove = new System.Windows.Forms.Button();
            this.textBoxFocusPos = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBoxFocusStep = new System.Windows.Forms.TextBox();
            this.buttonFocusStepMoveInc = new System.Windows.Forms.Button();
            this.buttonFocusStepMoveDec = new System.Windows.Forms.Button();
            this.labelFocusCurPos = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.timerLog = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSystem,
            this.menuFunction,
            this.服务AToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(745, 25);
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
            this.submenuTelescopeConnect.Size = new System.Drawing.Size(153, 22);
            this.submenuTelescopeConnect.Text = "连接望远镜";
            this.submenuTelescopeConnect.ToolTipText = "建立与望远镜的连接";
            this.submenuTelescopeConnect.Click += new System.EventHandler(this.submenuTelescopeConnect_Click);
            // 
            // submenuTelescopeDisconnect
            // 
            this.submenuTelescopeDisconnect.Enabled = false;
            this.submenuTelescopeDisconnect.Name = "submenuTelescopeDisconnect";
            this.submenuTelescopeDisconnect.Size = new System.Drawing.Size(153, 22);
            this.submenuTelescopeDisconnect.Text = "断开望远镜";
            this.submenuTelescopeDisconnect.ToolTipText = "断开与望远镜的连接";
            this.submenuTelescopeDisconnect.Click += new System.EventHandler(this.submenuTelescopeDisconnect_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 6);
            // 
            // submenuServerConnect
            // 
            this.submenuServerConnect.Name = "submenuServerConnect";
            this.submenuServerConnect.Size = new System.Drawing.Size(153, 22);
            this.submenuServerConnect.Text = "连接OT服务器";
            this.submenuServerConnect.ToolTipText = "建立与服务器的网络连接";
            this.submenuServerConnect.Click += new System.EventHandler(this.submenuServerConnect_Click);
            // 
            // submenuServerDisconnect
            // 
            this.submenuServerDisconnect.Enabled = false;
            this.submenuServerDisconnect.Name = "submenuServerDisconnect";
            this.submenuServerDisconnect.Size = new System.Drawing.Size(153, 22);
            this.submenuServerDisconnect.Text = "断开OT服务器";
            this.submenuServerDisconnect.ToolTipText = "断开与服务器的网络连接";
            this.submenuServerDisconnect.Click += new System.EventHandler(this.submenuServerDisconnect_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(150, 6);
            // 
            // submenuExit
            // 
            this.submenuExit.Name = "submenuExit";
            this.submenuExit.Size = new System.Drawing.Size(153, 22);
            this.submenuExit.Text = "退出";
            this.submenuExit.ToolTipText = "释放资源并退出程序";
            this.submenuExit.Click += new System.EventHandler(this.submenuExit_Click);
            // 
            // menuFunction
            // 
            this.menuFunction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuParamNetOT,
            this.submenuOTList});
            this.menuFunction.Name = "menuFunction";
            this.menuFunction.Size = new System.Drawing.Size(58, 21);
            this.menuFunction.Text = "功能(&F)";
            // 
            // submenuParamNetOT
            // 
            this.submenuParamNetOT.Name = "submenuParamNetOT";
            this.submenuParamNetOT.Size = new System.Drawing.Size(138, 22);
            this.submenuParamNetOT.Text = "OT服务器...";
            this.submenuParamNetOT.Click += new System.EventHandler(this.submenuParamNet_Click);
            // 
            // submenuOTList
            // 
            this.submenuOTList.Name = "submenuOTList";
            this.submenuOTList.Size = new System.Drawing.Size(138, 22);
            this.submenuOTList.Text = "OT列表";
            this.submenuOTList.Click += new System.EventHandler(this.submenuOTList_Click);
            // 
            // 服务AToolStripMenuItem
            // 
            this.服务AToolStripMenuItem.Name = "服务AToolStripMenuItem";
            this.服务AToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.服务AToolStripMenuItem.Text = "关于(&A)";
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // lblUT
            // 
            this.lblUT.BackColor = System.Drawing.SystemColors.Control;
            this.lblUT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUT.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUT.ForeColor = System.Drawing.Color.Black;
            this.lblUT.Location = new System.Drawing.Point(408, 50);
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
            this.label3.Location = new System.Drawing.Point(338, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "世界时:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblST
            // 
            this.lblST.BackColor = System.Drawing.SystemColors.Control;
            this.lblST.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblST.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblST.ForeColor = System.Drawing.Color.Black;
            this.lblST.Location = new System.Drawing.Point(408, 75);
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
            this.label4.Location = new System.Drawing.Point(338, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "恒星时:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.SystemColors.Control;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDate.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(408, 25);
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
            this.label1.Location = new System.Drawing.Point(338, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "日  期:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.lblUT);
            this.groupBox1.Controls.Add(this.lblAzi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblAlt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblST);
            this.groupBox1.Controls.Add(this.lblState);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblRA);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblDEC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(10, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 376);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "赤道仪";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxTeleInfo);
            this.groupBox4.Controls.Add(this.buttonTeleSlewSW);
            this.groupBox4.Controls.Add(this.buttonTeleSlewNW);
            this.groupBox4.Controls.Add(this.buttonTeleSlewSE);
            this.groupBox4.Controls.Add(this.buttonTeleSlewNE);
            this.groupBox4.Controls.Add(this.buttonTeleSlewW);
            this.groupBox4.Controls.Add(this.buttonTeleSlewE);
            this.groupBox4.Controls.Add(this.buttonTeleSlewN);
            this.groupBox4.Controls.Add(this.buttonTeleSlewS);
            this.groupBox4.Controls.Add(this.btnStop);
            this.groupBox4.Controls.Add(this.txtRA);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.btnFindHome);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.btnPark);
            this.groupBox4.Controls.Add(this.txtDEC);
            this.groupBox4.Controls.Add(this.btnSlew);
            this.groupBox4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(6, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(492, 252);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "指向目标位置";
            // 
            // textBoxTeleInfo
            // 
            this.textBoxTeleInfo.Location = new System.Drawing.Point(7, 108);
            this.textBoxTeleInfo.Multiline = true;
            this.textBoxTeleInfo.Name = "textBoxTeleInfo";
            this.textBoxTeleInfo.Size = new System.Drawing.Size(214, 138);
            this.textBoxTeleInfo.TabIndex = 17;
            // 
            // buttonTeleSlewSW
            // 
            this.buttonTeleSlewSW.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTeleSlewSW.ForeColor = System.Drawing.Color.Black;
            this.buttonTeleSlewSW.Location = new System.Drawing.Point(401, 206);
            this.buttonTeleSlewSW.Name = "buttonTeleSlewSW";
            this.buttonTeleSlewSW.Size = new System.Drawing.Size(75, 23);
            this.buttonTeleSlewSW.TabIndex = 16;
            this.buttonTeleSlewSW.Text = "SW";
            this.buttonTeleSlewSW.UseVisualStyleBackColor = false;
            // 
            // buttonTeleSlewNW
            // 
            this.buttonTeleSlewNW.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTeleSlewNW.ForeColor = System.Drawing.Color.Black;
            this.buttonTeleSlewNW.Location = new System.Drawing.Point(401, 130);
            this.buttonTeleSlewNW.Name = "buttonTeleSlewNW";
            this.buttonTeleSlewNW.Size = new System.Drawing.Size(75, 23);
            this.buttonTeleSlewNW.TabIndex = 16;
            this.buttonTeleSlewNW.Text = "NW";
            this.buttonTeleSlewNW.UseVisualStyleBackColor = false;
            // 
            // buttonTeleSlewSE
            // 
            this.buttonTeleSlewSE.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTeleSlewSE.ForeColor = System.Drawing.Color.Black;
            this.buttonTeleSlewSE.Location = new System.Drawing.Point(227, 206);
            this.buttonTeleSlewSE.Name = "buttonTeleSlewSE";
            this.buttonTeleSlewSE.Size = new System.Drawing.Size(75, 23);
            this.buttonTeleSlewSE.TabIndex = 16;
            this.buttonTeleSlewSE.Text = "SE";
            this.buttonTeleSlewSE.UseVisualStyleBackColor = false;
            // 
            // buttonTeleSlewNE
            // 
            this.buttonTeleSlewNE.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTeleSlewNE.ForeColor = System.Drawing.Color.Black;
            this.buttonTeleSlewNE.Location = new System.Drawing.Point(227, 130);
            this.buttonTeleSlewNE.Name = "buttonTeleSlewNE";
            this.buttonTeleSlewNE.Size = new System.Drawing.Size(75, 23);
            this.buttonTeleSlewNE.TabIndex = 16;
            this.buttonTeleSlewNE.Text = "NE";
            this.buttonTeleSlewNE.UseVisualStyleBackColor = false;
            // 
            // buttonTeleSlewW
            // 
            this.buttonTeleSlewW.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTeleSlewW.ForeColor = System.Drawing.Color.Black;
            this.buttonTeleSlewW.Location = new System.Drawing.Point(401, 168);
            this.buttonTeleSlewW.Name = "buttonTeleSlewW";
            this.buttonTeleSlewW.Size = new System.Drawing.Size(75, 23);
            this.buttonTeleSlewW.TabIndex = 16;
            this.buttonTeleSlewW.Text = "W";
            this.buttonTeleSlewW.UseVisualStyleBackColor = false;
            // 
            // buttonTeleSlewE
            // 
            this.buttonTeleSlewE.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTeleSlewE.ForeColor = System.Drawing.Color.Black;
            this.buttonTeleSlewE.Location = new System.Drawing.Point(227, 168);
            this.buttonTeleSlewE.Name = "buttonTeleSlewE";
            this.buttonTeleSlewE.Size = new System.Drawing.Size(75, 23);
            this.buttonTeleSlewE.TabIndex = 16;
            this.buttonTeleSlewE.Text = "E";
            this.buttonTeleSlewE.UseVisualStyleBackColor = false;
            // 
            // buttonTeleSlewN
            // 
            this.buttonTeleSlewN.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTeleSlewN.ForeColor = System.Drawing.Color.Black;
            this.buttonTeleSlewN.Location = new System.Drawing.Point(314, 130);
            this.buttonTeleSlewN.Name = "buttonTeleSlewN";
            this.buttonTeleSlewN.Size = new System.Drawing.Size(75, 23);
            this.buttonTeleSlewN.TabIndex = 16;
            this.buttonTeleSlewN.Text = "N";
            this.buttonTeleSlewN.UseVisualStyleBackColor = false;
            this.buttonTeleSlewN.Click += new System.EventHandler(this.buttonTeleSlewN_Click);
            // 
            // buttonTeleSlewS
            // 
            this.buttonTeleSlewS.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTeleSlewS.ForeColor = System.Drawing.Color.Black;
            this.buttonTeleSlewS.Location = new System.Drawing.Point(314, 207);
            this.buttonTeleSlewS.Name = "buttonTeleSlewS";
            this.buttonTeleSlewS.Size = new System.Drawing.Size(75, 23);
            this.buttonTeleSlewS.TabIndex = 16;
            this.buttonTeleSlewS.Text = "S";
            this.buttonTeleSlewS.UseVisualStyleBackColor = false;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStop.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStop.ForeColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(212, 50);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(90, 28);
            this.btnStop.TabIndex = 14;
            this.btnStop.Text = "停  止";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtRA
            // 
            this.txtRA.BackColor = System.Drawing.SystemColors.Window;
            this.txtRA.ForeColor = System.Drawing.Color.Black;
            this.txtRA.Location = new System.Drawing.Point(72, 20);
            this.txtRA.MaxLength = 15;
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(120, 23);
            this.txtRA.TabIndex = 2;
            this.txtRA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(12, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 18);
            this.label13.TabIndex = 1;
            this.label13.Text = "赤经:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFindHome
            // 
            this.btnFindHome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFindHome.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFindHome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnFindHome.Location = new System.Drawing.Point(314, 16);
            this.btnFindHome.Name = "btnFindHome";
            this.btnFindHome.Size = new System.Drawing.Size(90, 28);
            this.btnFindHome.TabIndex = 8;
            this.btnFindHome.Text = "Home";
            this.btnFindHome.UseVisualStyleBackColor = false;
            this.btnFindHome.Click += new System.EventHandler(this.btnFindHome_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "赤纬:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPark
            // 
            this.btnPark.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPark.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPark.ForeColor = System.Drawing.Color.Black;
            this.btnPark.Location = new System.Drawing.Point(314, 50);
            this.btnPark.Name = "btnPark";
            this.btnPark.Size = new System.Drawing.Size(90, 28);
            this.btnPark.TabIndex = 9;
            this.btnPark.Text = "Park";
            this.btnPark.UseVisualStyleBackColor = false;
            this.btnPark.Click += new System.EventHandler(this.btnPark_Click);
            // 
            // txtDEC
            // 
            this.txtDEC.BackColor = System.Drawing.SystemColors.Window;
            this.txtDEC.ForeColor = System.Drawing.Color.Black;
            this.txtDEC.Location = new System.Drawing.Point(72, 50);
            this.txtDEC.MaxLength = 15;
            this.txtDEC.Name = "txtDEC";
            this.txtDEC.Size = new System.Drawing.Size(120, 23);
            this.txtDEC.TabIndex = 2;
            this.txtDEC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSlew
            // 
            this.btnSlew.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSlew.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSlew.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnSlew.Location = new System.Drawing.Point(212, 15);
            this.btnSlew.Name = "btnSlew";
            this.btnSlew.Size = new System.Drawing.Size(90, 28);
            this.btnSlew.TabIndex = 13;
            this.btnSlew.Text = "指  向";
            this.btnSlew.UseVisualStyleBackColor = false;
            this.btnSlew.Click += new System.EventHandler(this.btnSlew_Click);
            // 
            // lblAzi
            // 
            this.lblAzi.BackColor = System.Drawing.SystemColors.Control;
            this.lblAzi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAzi.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAzi.ForeColor = System.Drawing.Color.Black;
            this.lblAzi.Location = new System.Drawing.Point(235, 50);
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
            this.label7.Location = new System.Drawing.Point(175, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "方位:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAlt
            // 
            this.lblAlt.BackColor = System.Drawing.SystemColors.Control;
            this.lblAlt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAlt.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAlt.ForeColor = System.Drawing.Color.Black;
            this.lblAlt.Location = new System.Drawing.Point(235, 75);
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
            this.label10.Location = new System.Drawing.Point(175, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "俯仰:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblState
            // 
            this.lblState.BackColor = System.Drawing.SystemColors.Control;
            this.lblState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblState.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblState.ForeColor = System.Drawing.Color.Black;
            this.lblState.Location = new System.Drawing.Point(70, 25);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(95, 18);
            this.lblState.TabIndex = 3;
            this.lblState.Text = "Stopped";
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
            this.lblRA.BackColor = System.Drawing.SystemColors.Control;
            this.lblRA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRA.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRA.ForeColor = System.Drawing.Color.Black;
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
            this.lblDEC.BackColor = System.Drawing.SystemColors.Control;
            this.lblDEC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDEC.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDEC.ForeColor = System.Drawing.Color.Black;
            this.lblDEC.Location = new System.Drawing.Point(70, 77);
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
            this.label8.Location = new System.Drawing.Point(10, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "赤纬:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmrNetwork
            // 
            this.tmrNetwork.Tick += new System.EventHandler(this.tmrNetwork_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Location = new System.Drawing.Point(526, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 376);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "调焦器";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(15, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 14);
            this.label14.TabIndex = 10;
            this.label14.Text = "当前温度（℃）：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(14, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 14);
            this.label12.TabIndex = 8;
            this.label12.Text = "当前状态：";
            // 
            // groupBox5
            // 
            this.groupBox5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(12, 109);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(182, 115);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "移动到指定位置(0~30mm):";
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(12, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 83);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "步进移动(mm):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(15, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 14);
            this.label11.TabIndex = 0;
            this.label11.Text = "当前位置(mm)：";
            // 
            // timerFocusStatus
            // 
            this.timerFocusStatus.Tick += new System.EventHandler(this.timerFocusStatus_Tick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.labelFocusCurTemp);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.labelFocusCurStatus);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.groupBox8);
            this.groupBox6.Controls.Add(this.labelFocusCurPos);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox6.Location = new System.Drawing.Point(526, 28);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(207, 376);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "调焦器";
            // 
            // labelFocusCurTemp
            // 
            this.labelFocusCurTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFocusCurTemp.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFocusCurTemp.ForeColor = System.Drawing.Color.Black;
            this.labelFocusCurTemp.Location = new System.Drawing.Point(107, 77);
            this.labelFocusCurTemp.Name = "labelFocusCurTemp";
            this.labelFocusCurTemp.Size = new System.Drawing.Size(87, 18);
            this.labelFocusCurTemp.TabIndex = 11;
            this.labelFocusCurTemp.Text = "0";
            this.labelFocusCurTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(15, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 14);
            this.label15.TabIndex = 10;
            this.label15.Text = "温度（℃）：";
            // 
            // labelFocusCurStatus
            // 
            this.labelFocusCurStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFocusCurStatus.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFocusCurStatus.ForeColor = System.Drawing.Color.Black;
            this.labelFocusCurStatus.Location = new System.Drawing.Point(107, 52);
            this.labelFocusCurStatus.Name = "labelFocusCurStatus";
            this.labelFocusCurStatus.Size = new System.Drawing.Size(87, 18);
            this.labelFocusCurStatus.TabIndex = 9;
            this.labelFocusCurStatus.Text = "Stopped";
            this.labelFocusCurStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(15, 54);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 14);
            this.label17.TabIndex = 8;
            this.label17.Text = "状态：";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.progressBarFocus);
            this.groupBox7.Controls.Add(this.buttonFocusStopMove);
            this.groupBox7.Controls.Add(this.buttonFocusStartMove);
            this.groupBox7.Controls.Add(this.textBoxFocusPos);
            this.groupBox7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox7.ForeColor = System.Drawing.Color.Black;
            this.groupBox7.Location = new System.Drawing.Point(12, 109);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(182, 115);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "移动到指定位置(0~30mm):";
            // 
            // progressBarFocus
            // 
            this.progressBarFocus.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBarFocus.ForeColor = System.Drawing.Color.Black;
            this.progressBarFocus.Location = new System.Drawing.Point(9, 82);
            this.progressBarFocus.Name = "progressBarFocus";
            this.progressBarFocus.Size = new System.Drawing.Size(144, 23);
            this.progressBarFocus.Step = 100;
            this.progressBarFocus.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarFocus.TabIndex = 12;
            this.progressBarFocus.Value = 50;
            // 
            // buttonFocusStopMove
            // 
            this.buttonFocusStopMove.ForeColor = System.Drawing.Color.Red;
            this.buttonFocusStopMove.Location = new System.Drawing.Point(90, 53);
            this.buttonFocusStopMove.Name = "buttonFocusStopMove";
            this.buttonFocusStopMove.Size = new System.Drawing.Size(75, 23);
            this.buttonFocusStopMove.TabIndex = 2;
            this.buttonFocusStopMove.Text = "停止";
            this.buttonFocusStopMove.UseVisualStyleBackColor = false;
            this.buttonFocusStopMove.Click += new System.EventHandler(this.buttonFocusStopMove_Click);
            // 
            // buttonFocusStartMove
            // 
            this.buttonFocusStartMove.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonFocusStartMove.Location = new System.Drawing.Point(90, 24);
            this.buttonFocusStartMove.Name = "buttonFocusStartMove";
            this.buttonFocusStartMove.Size = new System.Drawing.Size(75, 23);
            this.buttonFocusStartMove.TabIndex = 1;
            this.buttonFocusStartMove.Text = "移动";
            this.buttonFocusStartMove.UseVisualStyleBackColor = false;
            this.buttonFocusStartMove.Click += new System.EventHandler(this.buttonFocusStartMove_Click);
            // 
            // textBoxFocusPos
            // 
            this.textBoxFocusPos.Location = new System.Drawing.Point(7, 39);
            this.textBoxFocusPos.Name = "textBoxFocusPos";
            this.textBoxFocusPos.Size = new System.Drawing.Size(75, 23);
            this.textBoxFocusPos.TabIndex = 0;
            this.textBoxFocusPos.Text = "0";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textBoxFocusStep);
            this.groupBox8.Controls.Add(this.buttonFocusStepMoveInc);
            this.groupBox8.Controls.Add(this.buttonFocusStepMoveDec);
            this.groupBox8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox8.ForeColor = System.Drawing.Color.Black;
            this.groupBox8.Location = new System.Drawing.Point(12, 236);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(182, 83);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "步进移动(mm):";
            // 
            // textBoxFocusStep
            // 
            this.textBoxFocusStep.Location = new System.Drawing.Point(9, 40);
            this.textBoxFocusStep.Name = "textBoxFocusStep";
            this.textBoxFocusStep.Size = new System.Drawing.Size(75, 23);
            this.textBoxFocusStep.TabIndex = 4;
            this.textBoxFocusStep.Text = "0.1";
            // 
            // buttonFocusStepMoveInc
            // 
            this.buttonFocusStepMoveInc.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonFocusStepMoveInc.ForeColor = System.Drawing.Color.Black;
            this.buttonFocusStepMoveInc.Location = new System.Drawing.Point(90, 22);
            this.buttonFocusStepMoveInc.Name = "buttonFocusStepMoveInc";
            this.buttonFocusStepMoveInc.Size = new System.Drawing.Size(75, 23);
            this.buttonFocusStepMoveInc.TabIndex = 2;
            this.buttonFocusStepMoveInc.Text = "+";
            this.buttonFocusStepMoveInc.UseVisualStyleBackColor = false;
            this.buttonFocusStepMoveInc.Click += new System.EventHandler(this.buttonFocusStepMoveInc_Click);
            // 
            // buttonFocusStepMoveDec
            // 
            this.buttonFocusStepMoveDec.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonFocusStepMoveDec.ForeColor = System.Drawing.Color.Black;
            this.buttonFocusStepMoveDec.Location = new System.Drawing.Point(90, 51);
            this.buttonFocusStepMoveDec.Name = "buttonFocusStepMoveDec";
            this.buttonFocusStepMoveDec.Size = new System.Drawing.Size(75, 23);
            this.buttonFocusStepMoveDec.TabIndex = 3;
            this.buttonFocusStepMoveDec.Text = "-";
            this.buttonFocusStepMoveDec.UseVisualStyleBackColor = false;
            this.buttonFocusStepMoveDec.Click += new System.EventHandler(this.buttonFocusStepMoveDec_Click);
            // 
            // labelFocusCurPos
            // 
            this.labelFocusCurPos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFocusCurPos.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFocusCurPos.ForeColor = System.Drawing.Color.Black;
            this.labelFocusCurPos.Location = new System.Drawing.Point(107, 27);
            this.labelFocusCurPos.Name = "labelFocusCurPos";
            this.labelFocusCurPos.Size = new System.Drawing.Size(87, 18);
            this.labelFocusCurPos.TabIndex = 1;
            this.labelFocusCurPos.Text = "0";
            this.labelFocusCurPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(15, 29);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 14);
            this.label19.TabIndex = 0;
            this.label19.Text = "位置(mm)：";
            // 
            // timerLog
            // 
            this.timerLog.Interval = 1000;
            this.timerLog.Tick += new System.EventHandler(this.timerLog_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 430);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Mini-GWAC Follow Up Telescope";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
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
		private System.Windows.Forms.ToolStripMenuItem menuFunction;
        private System.Windows.Forms.Timer tmrRefresh;
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
		private System.Windows.Forms.Button btnPark;
		private System.Windows.Forms.Button btnFindHome;
		private System.Windows.Forms.Label lblState;
		private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem submenuParamNetOT;
        private System.Windows.Forms.Timer tmrNetwork;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDEC;
        private System.Windows.Forms.TextBox txtRA;
        private System.Windows.Forms.Button btnSlew;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonTeleSlewSW;
        private System.Windows.Forms.Button buttonTeleSlewNW;
        private System.Windows.Forms.Button buttonTeleSlewSE;
        private System.Windows.Forms.Button buttonTeleSlewNE;
        private System.Windows.Forms.Button buttonTeleSlewW;
        private System.Windows.Forms.Button buttonTeleSlewE;
        private System.Windows.Forms.Button buttonTeleSlewN;
        private System.Windows.Forms.Button buttonTeleSlewS;
        private System.Windows.Forms.TextBox textBoxTeleInfo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Timer timerFocusStatus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStripMenuItem 服务AToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label labelFocusCurTemp;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelFocusCurStatus;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ProgressBar progressBarFocus;
        private System.Windows.Forms.Button buttonFocusStopMove;
        private System.Windows.Forms.Button buttonFocusStartMove;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox textBoxFocusStep;
        private System.Windows.Forms.Button buttonFocusStepMoveInc;
        private System.Windows.Forms.Button buttonFocusStepMoveDec;
        private System.Windows.Forms.Label labelFocusCurPos;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxFocusPos;
        private System.Windows.Forms.ToolStripMenuItem submenuOTList;
        private System.Windows.Forms.Timer timerLog;
    }
}
