namespace spapiApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.HSIFdata = new System.Windows.Forms.Button();
            this.btnRelease = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnAcc = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnbyccy = new System.Windows.Forms.Button();
            this.btnccyrate = new System.Windows.Forms.Button();
            this.btnccyrcount = new System.Windows.Forms.Button();
            this.btnCtrlLevel = new System.Windows.Forms.Button();
            this.btnchangepsw = new System.Windows.Forms.Button();
            this.btnVersion = new System.Windows.Forms.Button();
            this.btnConn = new System.Windows.Forms.Button();
            this.btnAccInfo = new System.Windows.Forms.Button();
            this.btnBalByCcy = new System.Windows.Forms.Button();
            this.btnBalAll = new System.Windows.Forms.Button();
            this.btnBalCount = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSetLogPath = new System.Windows.Forms.Button();
            this.btnDllVers = new System.Windows.Forms.Button();
            this.btnUniTicker = new System.Windows.Forms.Button();
            this.btnSubTicker = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnLoadInstByCode = new System.Windows.Forms.Button();
            this.btnLoadinst = new System.Windows.Forms.Button();
            this.btnProdByCode = new System.Windows.Forms.Button();
            this.btnProdInfoCount = new System.Windows.Forms.Button();
            this.btnInstByCode = new System.Windows.Forms.Button();
            this.btnInstInfoCount = new System.Windows.Forms.Button();
            this.btnPrice = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTradeReport = new System.Windows.Forms.Button();
            this.btnTradeByProd = new System.Windows.Forms.Button();
            this.btnTradeAll = new System.Windows.Forms.Button();
            this.btnTradeCount = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPosByProd = new System.Windows.Forms.Button();
            this.btnPosAll = new System.Windows.Forms.Button();
            this.btnPosCount = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOrderReport = new System.Windows.Forms.Button();
            this.btnOrderInactive = new System.Windows.Forms.Button();
            this.btnOrderAll = new System.Windows.Forms.Button();
            this.btnOrderChange = new System.Windows.Forms.Button();
            this.btnOrderDel = new System.Windows.Forms.Button();
            this.btnOrderAdd = new System.Windows.Forms.Button();
            this.btnOrderCount = new System.Windows.Forms.Button();
            this.lbxMainData = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.HSIFdata);
            this.panel1.Controls.Add(this.btnRelease);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.btnAcc);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1330, 123);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1212, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "生成excel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1212, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "开始实时监控SAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Popout);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1212, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "历史SAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.HSIData);
            // 
            // HSIFdata
            // 
            this.HSIFdata.Location = new System.Drawing.Point(1212, 16);
            this.HSIFdata.Name = "HSIFdata";
            this.HSIFdata.Size = new System.Drawing.Size(106, 23);
            this.HSIFdata.TabIndex = 11;
            this.HSIFdata.Text = "获取恒生期货";
            this.HSIFdata.UseVisualStyleBackColor = true;
            this.HSIFdata.Click += new System.EventHandler(this.HSIFdata_Click);
            // 
            // btnRelease
            // 
            this.btnRelease.Location = new System.Drawing.Point(1122, 92);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(79, 23);
            this.btnRelease.TabIndex = 10;
            this.btnRelease.Text = "Acc Release";
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Visible = false;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(1122, 14);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(79, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "登陆";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnAcc
            // 
            this.btnAcc.Location = new System.Drawing.Point(1122, 65);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Size = new System.Drawing.Size(79, 23);
            this.btnAcc.TabIndex = 9;
            this.btnAcc.Text = "Acc Access";
            this.btnAcc.UseVisualStyleBackColor = true;
            this.btnAcc.Visible = false;
            this.btnAcc.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1122, 39);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(79, 23);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "注销";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnbyccy);
            this.groupBox6.Controls.Add(this.btnccyrate);
            this.groupBox6.Controls.Add(this.btnccyrcount);
            this.groupBox6.Controls.Add(this.btnCtrlLevel);
            this.groupBox6.Controls.Add(this.btnchangepsw);
            this.groupBox6.Controls.Add(this.btnVersion);
            this.groupBox6.Controls.Add(this.btnConn);
            this.groupBox6.Controls.Add(this.btnAccInfo);
            this.groupBox6.Controls.Add(this.btnBalByCcy);
            this.groupBox6.Controls.Add(this.btnBalAll);
            this.groupBox6.Controls.Add(this.btnBalCount);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox6.Location = new System.Drawing.Point(807, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(309, 123);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Account Info";
            // 
            // btnbyccy
            // 
            this.btnbyccy.Location = new System.Drawing.Point(212, 67);
            this.btnbyccy.Name = "btnbyccy";
            this.btnbyccy.Size = new System.Drawing.Size(91, 23);
            this.btnbyccy.TabIndex = 12;
            this.btnbyccy.Text = "CcyR by Ccy";
            this.btnbyccy.UseVisualStyleBackColor = true;
            this.btnbyccy.Visible = false;
            this.btnbyccy.Click += new System.EventHandler(this.btnbyccy_Click);
            // 
            // btnccyrate
            // 
            this.btnccyrate.Location = new System.Drawing.Point(212, 41);
            this.btnccyrate.Name = "btnccyrate";
            this.btnccyrate.Size = new System.Drawing.Size(91, 23);
            this.btnccyrate.TabIndex = 11;
            this.btnccyrate.Text = "AE模式情况下需先AccounLogin一个用户才能获取所有兑换率。 ";
            this.btnccyrate.UseVisualStyleBackColor = true;
            this.btnccyrate.Click += new System.EventHandler(this.btnccyrate_Click);
            // 
            // btnccyrcount
            // 
            this.btnccyrcount.Location = new System.Drawing.Point(212, 16);
            this.btnccyrcount.Name = "btnccyrcount";
            this.btnccyrcount.Size = new System.Drawing.Size(91, 23);
            this.btnccyrcount.TabIndex = 10;
            this.btnccyrcount.Text = "获取参考兑换率的数量";
            this.btnccyrcount.UseVisualStyleBackColor = true;
            this.btnccyrcount.Click += new System.EventHandler(this.btnccyrcount_Click);
            // 
            // btnCtrlLevel
            // 
            this.btnCtrlLevel.Location = new System.Drawing.Point(120, 91);
            this.btnCtrlLevel.Name = "btnCtrlLevel";
            this.btnCtrlLevel.Size = new System.Drawing.Size(91, 23);
            this.btnCtrlLevel.TabIndex = 9;
            this.btnCtrlLevel.Text = "Ctrl Level";
            this.btnCtrlLevel.UseVisualStyleBackColor = true;
            this.btnCtrlLevel.Visible = false;
            this.btnCtrlLevel.Click += new System.EventHandler(this.btnCtrlLevel_Click);
            // 
            // btnchangepsw
            // 
            this.btnchangepsw.Location = new System.Drawing.Point(6, 90);
            this.btnchangepsw.Name = "btnchangepsw";
            this.btnchangepsw.Size = new System.Drawing.Size(115, 23);
            this.btnchangepsw.TabIndex = 8;
            this.btnchangepsw.Text = "Change psw";
            this.btnchangepsw.UseVisualStyleBackColor = true;
            this.btnchangepsw.Visible = false;
            this.btnchangepsw.Click += new System.EventHandler(this.btnchangepsw_Click);
            // 
            // btnVersion
            // 
            this.btnVersion.Location = new System.Drawing.Point(121, 67);
            this.btnVersion.Name = "btnVersion";
            this.btnVersion.Size = new System.Drawing.Size(91, 23);
            this.btnVersion.TabIndex = 5;
            this.btnVersion.Text = "查询DLL的更新版本与时间";
            this.btnVersion.UseVisualStyleBackColor = true;
            this.btnVersion.Click += new System.EventHandler(this.btnVersion_Click);
            // 
            // btnConn
            // 
            this.btnConn.Location = new System.Drawing.Point(6, 65);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(115, 23);
            this.btnConn.TabIndex = 7;
            this.btnConn.Text = "Connection Status ";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Visible = false;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // btnAccInfo
            // 
            this.btnAccInfo.Location = new System.Drawing.Point(6, 16);
            this.btnAccInfo.Name = "btnAccInfo";
            this.btnAccInfo.Size = new System.Drawing.Size(115, 23);
            this.btnAccInfo.TabIndex = 6;
            this.btnAccInfo.Text = "账户资料";
            this.btnAccInfo.UseVisualStyleBackColor = true;
            this.btnAccInfo.Click += new System.EventHandler(this.btnAccInfo_Click);
            // 
            // btnBalByCcy
            // 
            this.btnBalByCcy.Location = new System.Drawing.Point(6, 41);
            this.btnBalByCcy.Name = "btnBalByCcy";
            this.btnBalByCcy.Size = new System.Drawing.Size(115, 23);
            this.btnBalByCcy.TabIndex = 3;
            this.btnBalByCcy.Text = "Bal By Currency";
            this.btnBalByCcy.UseVisualStyleBackColor = true;
            this.btnBalByCcy.Visible = false;
            this.btnBalByCcy.Click += new System.EventHandler(this.btnBalByCcy_Click);
            // 
            // btnBalAll
            // 
            this.btnBalAll.Location = new System.Drawing.Point(121, 41);
            this.btnBalAll.Name = "btnBalAll";
            this.btnBalAll.Size = new System.Drawing.Size(91, 23);
            this.btnBalAll.TabIndex = 2;
            this.btnBalAll.Text = "查询所有的现金结余";
            this.btnBalAll.UseVisualStyleBackColor = true;
            this.btnBalAll.Click += new System.EventHandler(this.btnBalAll_Click);
            // 
            // btnBalCount
            // 
            this.btnBalCount.Location = new System.Drawing.Point(121, 16);
            this.btnBalCount.Name = "btnBalCount";
            this.btnBalCount.Size = new System.Drawing.Size(91, 23);
            this.btnBalCount.TabIndex = 1;
            this.btnBalCount.Text = "查询现金结余数量";
            this.btnBalCount.UseVisualStyleBackColor = true;
            this.btnBalCount.Click += new System.EventHandler(this.btnBalCount_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSetLogPath);
            this.groupBox5.Controls.Add(this.btnDllVers);
            this.groupBox5.Controls.Add(this.btnUniTicker);
            this.groupBox5.Controls.Add(this.btnSubTicker);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox5.Location = new System.Drawing.Point(706, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(101, 123);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ticker";
            // 
            // btnSetLogPath
            // 
            this.btnSetLogPath.Location = new System.Drawing.Point(6, 90);
            this.btnSetLogPath.Name = "btnSetLogPath";
            this.btnSetLogPath.Size = new System.Drawing.Size(91, 23);
            this.btnSetLogPath.TabIndex = 7;
            this.btnSetLogPath.Text = "Set Log Path";
            this.btnSetLogPath.UseVisualStyleBackColor = true;
            this.btnSetLogPath.Visible = false;
            this.btnSetLogPath.Click += new System.EventHandler(this.btnSetLogPath_Click);
            // 
            // btnDllVers
            // 
            this.btnDllVers.Location = new System.Drawing.Point(6, 65);
            this.btnDllVers.Name = "btnDllVers";
            this.btnDllVers.Size = new System.Drawing.Size(91, 23);
            this.btnDllVers.TabIndex = 6;
            this.btnDllVers.Text = "查询DLL版本号";
            this.btnDllVers.UseVisualStyleBackColor = true;
            this.btnDllVers.Click += new System.EventHandler(this.btnDllVers_Click);
            // 
            // btnUniTicker
            // 
            this.btnUniTicker.Location = new System.Drawing.Point(6, 41);
            this.btnUniTicker.Name = "btnUniTicker";
            this.btnUniTicker.Size = new System.Drawing.Size(91, 23);
            this.btnUniTicker.TabIndex = 1;
            this.btnUniTicker.Text = "Remove Ticker";
            this.btnUniTicker.UseVisualStyleBackColor = true;
            this.btnUniTicker.Visible = false;
            this.btnUniTicker.Click += new System.EventHandler(this.btnUniTicker_Click);
            // 
            // btnSubTicker
            // 
            this.btnSubTicker.Location = new System.Drawing.Point(6, 16);
            this.btnSubTicker.Name = "btnSubTicker";
            this.btnSubTicker.Size = new System.Drawing.Size(91, 23);
            this.btnSubTicker.TabIndex = 0;
            this.btnSubTicker.Text = "Sub Ticker";
            this.btnSubTicker.UseVisualStyleBackColor = true;
            this.btnSubTicker.Visible = false;
            this.btnSubTicker.Click += new System.EventHandler(this.btnSubTicker_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnLoadInstByCode);
            this.groupBox4.Controls.Add(this.btnLoadinst);
            this.groupBox4.Controls.Add(this.btnProdByCode);
            this.groupBox4.Controls.Add(this.btnProdInfoCount);
            this.groupBox4.Controls.Add(this.btnInstByCode);
            this.groupBox4.Controls.Add(this.btnInstInfoCount);
            this.groupBox4.Controls.Add(this.btnPrice);
            this.groupBox4.Controls.Add(this.button10);
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(423, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(283, 123);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Market Price";
            // 
            // btnLoadInstByCode
            // 
            this.btnLoadInstByCode.Location = new System.Drawing.Point(6, 90);
            this.btnLoadInstByCode.Name = "btnLoadInstByCode";
            this.btnLoadInstByCode.Size = new System.Drawing.Size(90, 23);
            this.btnLoadInstByCode.TabIndex = 11;
            this.btnLoadInstByCode.Text = "Load Product";
            this.btnLoadInstByCode.UseVisualStyleBackColor = true;
            this.btnLoadInstByCode.Visible = false;
            this.btnLoadInstByCode.Click += new System.EventHandler(this.btnLoadInstByCode_Click);
            // 
            // btnLoadinst
            // 
            this.btnLoadinst.Location = new System.Drawing.Point(6, 65);
            this.btnLoadinst.Name = "btnLoadinst";
            this.btnLoadinst.Size = new System.Drawing.Size(90, 23);
            this.btnLoadinst.TabIndex = 9;
            this.btnLoadinst.Text = "加载所有合约系列信息";
            this.btnLoadinst.UseVisualStyleBackColor = true;
            this.btnLoadinst.Click += new System.EventHandler(this.btnLoadinst_Click);
            // 
            // btnProdByCode
            // 
            this.btnProdByCode.Location = new System.Drawing.Point(96, 90);
            this.btnProdByCode.Name = "btnProdByCode";
            this.btnProdByCode.Size = new System.Drawing.Size(85, 23);
            this.btnProdByCode.TabIndex = 8;
            this.btnProdByCode.Text = "Prod By Code";
            this.btnProdByCode.UseVisualStyleBackColor = true;
            this.btnProdByCode.Visible = false;
            this.btnProdByCode.Click += new System.EventHandler(this.btnProdByCode_Click);
            // 
            // btnProdInfoCount
            // 
            this.btnProdInfoCount.Location = new System.Drawing.Point(181, 90);
            this.btnProdInfoCount.Name = "btnProdInfoCount";
            this.btnProdInfoCount.Size = new System.Drawing.Size(97, 23);
            this.btnProdInfoCount.TabIndex = 7;
            this.btnProdInfoCount.Text = "查询所有产品信息与数量";
            this.btnProdInfoCount.UseVisualStyleBackColor = true;
            this.btnProdInfoCount.Click += new System.EventHandler(this.btnProdInfoCount_Click);
            // 
            // btnInstByCode
            // 
            this.btnInstByCode.Location = new System.Drawing.Point(96, 65);
            this.btnInstByCode.Name = "btnInstByCode";
            this.btnInstByCode.Size = new System.Drawing.Size(85, 23);
            this.btnInstByCode.TabIndex = 6;
            this.btnInstByCode.Text = "Inst By Code";
            this.btnInstByCode.UseVisualStyleBackColor = true;
            this.btnInstByCode.Visible = false;
            this.btnInstByCode.Click += new System.EventHandler(this.btnInstByCode_Click);
            // 
            // btnInstInfoCount
            // 
            this.btnInstInfoCount.Location = new System.Drawing.Point(181, 65);
            this.btnInstInfoCount.Name = "btnInstInfoCount";
            this.btnInstInfoCount.Size = new System.Drawing.Size(97, 23);
            this.btnInstInfoCount.TabIndex = 5;
            this.btnInstInfoCount.Text = "查询所有产品系列与数量";
            this.btnInstInfoCount.UseVisualStyleBackColor = true;
            this.btnInstInfoCount.Click += new System.EventHandler(this.btnInstInfoCount_Click);
            // 
            // btnPrice
            // 
            this.btnPrice.Location = new System.Drawing.Point(96, 16);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(85, 23);
            this.btnPrice.TabIndex = 4;
            this.btnPrice.Text = "Remove Price";
            this.btnPrice.UseVisualStyleBackColor = true;
            this.btnPrice.Visible = false;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(6, 41);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(90, 23);
            this.button10.TabIndex = 3;
            this.button10.Text = "获取所有合约";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(181, 16);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(97, 23);
            this.button9.TabIndex = 2;
            this.button9.Text = "Price By Code";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(96, 41);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(85, 23);
            this.button8.TabIndex = 1;
            this.button8.Text = "订阅的合约数量";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 16);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 23);
            this.button7.TabIndex = 0;
            this.button7.Text = "Insert Price";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTradeReport);
            this.groupBox3.Controls.Add(this.btnTradeByProd);
            this.groupBox3.Controls.Add(this.btnTradeAll);
            this.groupBox3.Controls.Add(this.btnTradeCount);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(301, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(122, 123);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clear Trade";
            // 
            // btnTradeReport
            // 
            this.btnTradeReport.Location = new System.Drawing.Point(6, 90);
            this.btnTradeReport.Name = "btnTradeReport";
            this.btnTradeReport.Size = new System.Drawing.Size(109, 23);
            this.btnTradeReport.TabIndex = 3;
            this.btnTradeReport.Text = "根据请求类型加载成交回调方法";
            this.btnTradeReport.UseVisualStyleBackColor = true;
            this.btnTradeReport.Click += new System.EventHandler(this.btnTradeReport_Click);
            // 
            // btnTradeByProd
            // 
            this.btnTradeByProd.Location = new System.Drawing.Point(6, 65);
            this.btnTradeByProd.Name = "btnTradeByProd";
            this.btnTradeByProd.Size = new System.Drawing.Size(109, 23);
            this.btnTradeByProd.TabIndex = 2;
            this.btnTradeByProd.Text = "Trade By TradeNo";
            this.btnTradeByProd.UseVisualStyleBackColor = true;
            this.btnTradeByProd.Visible = false;
            this.btnTradeByProd.Click += new System.EventHandler(this.btnTradeByProd_Click);
            // 
            // btnTradeAll
            // 
            this.btnTradeAll.Location = new System.Drawing.Point(6, 41);
            this.btnTradeAll.Name = "btnTradeAll";
            this.btnTradeAll.Size = new System.Drawing.Size(109, 23);
            this.btnTradeAll.TabIndex = 1;
            this.btnTradeAll.Text = "查询所有成交记录";
            this.btnTradeAll.UseVisualStyleBackColor = true;
            this.btnTradeAll.Click += new System.EventHandler(this.btnTradeAll_Click);
            // 
            // btnTradeCount
            // 
            this.btnTradeCount.Location = new System.Drawing.Point(6, 16);
            this.btnTradeCount.Name = "btnTradeCount";
            this.btnTradeCount.Size = new System.Drawing.Size(109, 23);
            this.btnTradeCount.TabIndex = 0;
            this.btnTradeCount.Text = "查询成交数量";
            this.btnTradeCount.UseVisualStyleBackColor = true;
            this.btnTradeCount.Click += new System.EventHandler(this.btnTradeCount_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPosByProd);
            this.groupBox2.Controls.Add(this.btnPosAll);
            this.groupBox2.Controls.Add(this.btnPosCount);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(193, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(108, 123);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pos";
            // 
            // btnPosByProd
            // 
            this.btnPosByProd.Location = new System.Drawing.Point(4, 65);
            this.btnPosByProd.Name = "btnPosByProd";
            this.btnPosByProd.Size = new System.Drawing.Size(97, 23);
            this.btnPosByProd.TabIndex = 2;
            this.btnPosByProd.Text = "Pos By Product";
            this.btnPosByProd.UseVisualStyleBackColor = true;
            this.btnPosByProd.Visible = false;
            this.btnPosByProd.Click += new System.EventHandler(this.btnPosByProd_Click);
            // 
            // btnPosAll
            // 
            this.btnPosAll.Location = new System.Drawing.Point(4, 41);
            this.btnPosAll.Name = "btnPosAll";
            this.btnPosAll.Size = new System.Drawing.Size(97, 23);
            this.btnPosAll.TabIndex = 1;
            this.btnPosAll.Text = "获取所有持仓信息";
            this.btnPosAll.UseVisualStyleBackColor = true;
            this.btnPosAll.Click += new System.EventHandler(this.btnPosAll_Click);
            // 
            // btnPosCount
            // 
            this.btnPosCount.Location = new System.Drawing.Point(4, 16);
            this.btnPosCount.Name = "btnPosCount";
            this.btnPosCount.Size = new System.Drawing.Size(97, 23);
            this.btnPosCount.TabIndex = 0;
            this.btnPosCount.Text = "获取持仓数量";
            this.btnPosCount.UseVisualStyleBackColor = true;
            this.btnPosCount.Click += new System.EventHandler(this.btnPosCount_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOrderReport);
            this.groupBox1.Controls.Add(this.btnOrderInactive);
            this.groupBox1.Controls.Add(this.btnOrderAll);
            this.groupBox1.Controls.Add(this.btnOrderChange);
            this.groupBox1.Controls.Add(this.btnOrderDel);
            this.groupBox1.Controls.Add(this.btnOrderAdd);
            this.groupBox1.Controls.Add(this.btnOrderCount);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order";
            // 
            // btnOrderReport
            // 
            this.btnOrderReport.Location = new System.Drawing.Point(6, 90);
            this.btnOrderReport.Name = "btnOrderReport";
            this.btnOrderReport.Size = new System.Drawing.Size(85, 23);
            this.btnOrderReport.TabIndex = 6;
            this.btnOrderReport.Text = "根据请求类型与订单状态加载订单回调方法";
            this.btnOrderReport.UseVisualStyleBackColor = true;
            this.btnOrderReport.Click += new System.EventHandler(this.btnOrderReport_Click);
            // 
            // btnOrderInactive
            // 
            this.btnOrderInactive.Location = new System.Drawing.Point(91, 65);
            this.btnOrderInactive.Name = "btnOrderInactive";
            this.btnOrderInactive.Size = new System.Drawing.Size(99, 23);
            this.btnOrderInactive.TabIndex = 5;
            this.btnOrderInactive.Text = "Order Inactive";
            this.btnOrderInactive.UseVisualStyleBackColor = true;
            this.btnOrderInactive.Visible = false;
            this.btnOrderInactive.Click += new System.EventHandler(this.btnOrderInactive_Click);
            // 
            // btnOrderAll
            // 
            this.btnOrderAll.Location = new System.Drawing.Point(6, 65);
            this.btnOrderAll.Name = "btnOrderAll";
            this.btnOrderAll.Size = new System.Drawing.Size(85, 23);
            this.btnOrderAll.TabIndex = 4;
            this.btnOrderAll.Text = "取消所有订单";
            this.btnOrderAll.UseVisualStyleBackColor = true;
            this.btnOrderAll.Click += new System.EventHandler(this.btnOrderAll_Click);
            // 
            // btnOrderChange
            // 
            this.btnOrderChange.Location = new System.Drawing.Point(91, 41);
            this.btnOrderChange.Name = "btnOrderChange";
            this.btnOrderChange.Size = new System.Drawing.Size(99, 23);
            this.btnOrderChange.TabIndex = 3;
            this.btnOrderChange.Text = "Change Order";
            this.btnOrderChange.UseVisualStyleBackColor = true;
            this.btnOrderChange.Visible = false;
            this.btnOrderChange.Click += new System.EventHandler(this.btnOrderChange_Click);
            // 
            // btnOrderDel
            // 
            this.btnOrderDel.Location = new System.Drawing.Point(6, 41);
            this.btnOrderDel.Name = "btnOrderDel";
            this.btnOrderDel.Size = new System.Drawing.Size(85, 23);
            this.btnOrderDel.TabIndex = 2;
            this.btnOrderDel.Text = "Del Order";
            this.btnOrderDel.UseVisualStyleBackColor = true;
            this.btnOrderDel.Visible = false;
            this.btnOrderDel.Click += new System.EventHandler(this.btnOrderDel_Click);
            // 
            // btnOrderAdd
            // 
            this.btnOrderAdd.Location = new System.Drawing.Point(91, 16);
            this.btnOrderAdd.Name = "btnOrderAdd";
            this.btnOrderAdd.Size = new System.Drawing.Size(99, 23);
            this.btnOrderAdd.TabIndex = 1;
            this.btnOrderAdd.Text = "Add Order";
            this.btnOrderAdd.UseVisualStyleBackColor = true;
            this.btnOrderAdd.Visible = false;
            this.btnOrderAdd.Click += new System.EventHandler(this.btnOrderAdd_Click);
            // 
            // btnOrderCount
            // 
            this.btnOrderCount.Location = new System.Drawing.Point(6, 16);
            this.btnOrderCount.Name = "btnOrderCount";
            this.btnOrderCount.Size = new System.Drawing.Size(85, 23);
            this.btnOrderCount.TabIndex = 0;
            this.btnOrderCount.Text = "获取订单数量";
            this.btnOrderCount.UseVisualStyleBackColor = true;
            this.btnOrderCount.Click += new System.EventHandler(this.btnOrderCount_Click);
            // 
            // lbxMainData
            // 
            this.lbxMainData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxMainData.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbxMainData.FormattingEnabled = true;
            this.lbxMainData.HorizontalScrollbar = true;
            this.lbxMainData.ItemHeight = 16;
            this.lbxMainData.Location = new System.Drawing.Point(0, 123);
            this.lbxMainData.Name = "lbxMainData";
            this.lbxMainData.Size = new System.Drawing.Size(1330, 303);
            this.lbxMainData.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 426);
            this.Controls.Add(this.lbxMainData);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "SP API Trader";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbxMainData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOrderCount;
        private System.Windows.Forms.Button btnOrderAdd;
        private System.Windows.Forms.Button btnOrderAll;
        private System.Windows.Forms.Button btnOrderChange;
        private System.Windows.Forms.Button btnOrderDel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTradeByProd;
        private System.Windows.Forms.Button btnTradeAll;
        private System.Windows.Forms.Button btnTradeCount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPosByProd;
        private System.Windows.Forms.Button btnPosAll;
        private System.Windows.Forms.Button btnPosCount;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnUniTicker;
        private System.Windows.Forms.Button btnSubTicker;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnAccInfo;
        private System.Windows.Forms.Button btnBalByCcy;
        private System.Windows.Forms.Button btnBalAll;
        private System.Windows.Forms.Button btnBalCount;
        private System.Windows.Forms.Button btnVersion;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.Button btnOrderInactive;
        private System.Windows.Forms.Button btnProdByCode;
        private System.Windows.Forms.Button btnProdInfoCount;
        private System.Windows.Forms.Button btnInstByCode;
        private System.Windows.Forms.Button btnInstInfoCount;
        private System.Windows.Forms.Button btnTradeReport;
        private System.Windows.Forms.Button btnDllVers;
        private System.Windows.Forms.Button btnOrderReport;
        private System.Windows.Forms.Button btnchangepsw;
        private System.Windows.Forms.Button btnLoadinst;
        private System.Windows.Forms.Button btnLoadInstByCode;
        private System.Windows.Forms.Button btnAcc;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSetLogPath;
        private System.Windows.Forms.Button btnCtrlLevel;
        private System.Windows.Forms.Button btnbyccy;
        private System.Windows.Forms.Button btnccyrate;
        private System.Windows.Forms.Button btnccyrcount;
        private System.Windows.Forms.Button HSIFdata;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

