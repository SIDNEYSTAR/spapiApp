namespace spapiApp
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserid = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrLogin = new System.Windows.Forms.Timer(this.components);
            this.tmrPoll = new System.Windows.Forms.Timer(this.components);
            this.lblNewWeb = new System.Windows.Forms.LinkLabel();
            this.txtAppId = new System.Windows.Forms.TextBox();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtaccid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(51, 244);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Tag = "";
            this.btnLogin.Text = "登陆";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(141, 244);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Tag = "";
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "User ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "PassWord:";
            // 
            // txtUserid
            // 
            this.txtUserid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUserid.Location = new System.Drawing.Point(105, 75);
            this.txtUserid.Name = "txtUserid";
            this.txtUserid.Size = new System.Drawing.Size(134, 21);
            this.txtUserid.TabIndex = 3;
            this.txtUserid.Tag = "";
            this.txtUserid.Text = "DEMO201807219";
            this.txtUserid.TextChanged += new System.EventHandler(this.txtUserid_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(105, 131);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(134, 21);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Tag = "";
            this.txtPassword.Text = "123";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Server:";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(105, 21);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(134, 21);
            this.txtServer.TabIndex = 1;
            this.txtServer.Tag = "";
            this.txtServer.Text = "demo.spsystem.info";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 291);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(266, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "123";
            // 
            // tssStatus
            // 
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // tmrLogin
            // 
            this.tmrLogin.Interval = 1;
            this.tmrLogin.Tick += new System.EventHandler(this.tmrLogin_Tick);
            // 
            // tmrPoll
            // 
            this.tmrPoll.Interval = 1;
            this.tmrPoll.Tick += new System.EventHandler(this.tmrPoll_Tick);
            // 
            // lblNewWeb
            // 
            this.lblNewWeb.AutoSize = true;
            this.lblNewWeb.LinkColor = System.Drawing.SystemColors.ControlDark;
            this.lblNewWeb.Location = new System.Drawing.Point(49, 220);
            this.lblNewWeb.Name = "lblNewWeb";
            this.lblNewWeb.Size = new System.Drawing.Size(167, 12);
            this.lblNewWeb.TabIndex = 9;
            this.lblNewWeb.TabStop = true;
            this.lblNewWeb.Tag = "";
            this.lblNewWeb.Text = "Powered by Sharp Point Ltd.";
            this.lblNewWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblNewWeb_LinkClicked);
            // 
            // txtAppId
            // 
            this.txtAppId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAppId.Location = new System.Drawing.Point(105, 185);
            this.txtAppId.Name = "txtAppId";
            this.txtAppId.Size = new System.Drawing.Size(134, 21);
            this.txtAppId.TabIndex = 6;
            this.txtAppId.Tag = "";
            this.txtAppId.Text = "SPDEMO";
            // 
            // txtLicense
            // 
            this.txtLicense.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLicense.Location = new System.Drawing.Point(105, 158);
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.Size = new System.Drawing.Size(134, 21);
            this.txtLicense.TabIndex = 5;
            this.txtLicense.Tag = "";
            this.txtLicense.Text = "5B4D4BAE54479";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "App ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "License:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(105, 48);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(134, 21);
            this.txtPort.TabIndex = 2;
            this.txtPort.Tag = "";
            this.txtPort.Text = "80";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "Port:";
            // 
            // txtaccid
            // 
            this.txtaccid.Enabled = false;
            this.txtaccid.Location = new System.Drawing.Point(105, 102);
            this.txtaccid.Name = "txtaccid";
            this.txtaccid.Size = new System.Drawing.Size(134, 21);
            this.txtaccid.TabIndex = 16;
            this.txtaccid.Tag = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "Acc ID:";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 313);
            this.Controls.Add(this.txtaccid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAppId);
            this.Controls.Add(this.txtLicense);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNewWeb);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserid;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.Timer tmrLogin;
        private System.Windows.Forms.Timer tmrPoll;
        private System.Windows.Forms.LinkLabel lblNewWeb;
        private System.Windows.Forms.TextBox txtAppId;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtaccid;
        private System.Windows.Forms.Label label7;
    }
}