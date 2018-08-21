using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace spapiApp
{
    public partial class frmLogin : Form
    {
        //frmMain main;
        public frmLogin()
        {
            InitializeComponent();
            if (Spcommon.main == null)
            {
                Spcommon.Init();
                Spcommon.APIDLL.DllShowLoginText += PrintStatus;     
                
            } 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            int prot = Convert.ToInt32(txtPort.Text);
            string license = txtLicense.Text;  //9A9CC2D13C7A3615
            string app_id  = txtAppId.Text;
            //Spcommon.acc_no = txtaccid.Text;
            string sUserid = txtUserid.Text;
            string sPassword = txtPassword.Text;
            string sServer = txtServer.Text;

            PrintStatus("Login...", 0);
            if (Spcommon.APIDLL.InitFlag == 0)
            {
                int rc;

                 //tmrPoll.Enabled = true;
                 Spcommon.APIDLL.R_SPAPI_SetBackgroundPoll(true);
                 //Spcommon.APIDLL.R_SPAPI_Poll();
                 Spcommon.APIDLL.R_SPAPI_SetLoginInfo(sServer, prot, license, app_id, sUserid, sPassword);
                 rc = Spcommon.APIDLL.R_SPAPI_Login();
                 if (rc == 0)
                 {
                     //tmrPoll.Enabled = true;
                     tmrLogin.Enabled = true;
                     Spcommon.S_Server = sServer;
                     Spcommon.S_Prot = prot;
                     Spcommon.S_License = license;
                     Spcommon.S_App_id = app_id;
                     Spcommon.S_Userid = sUserid;
                     Spcommon.S_Password = sPassword;
                 }
                 else if (rc == -9)
                 {
                     PrintStatus("The DLL has been accessed", 0);
                 }
                 else
                 {
                     PrintStatus("DLL Req Failed", 0);
                 }
            }
            else
            {
                MessageBox.Show("DLL Initialization Failed！");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void PrintStatus(string text, int ret_code)
        {
            tssStatus.Text = text;
        }

        
        private void tmrLogin_Tick(object sender, EventArgs e)
        {
            //Spcommon.APIDLL.R_SPAPI_Poll();
            if (Spcommon.login_status == 5)
            {
                
                this.tmrLogin.Enabled = false;
                if (Spcommon.main == null)
                {
                    this.Hide();
                    Spcommon.main = new frmMain();
                    Spcommon.main.ShowDialog();
                }
            }
        }

        private void tmrPoll_Tick(object sender, EventArgs e)
        {
            tmrPoll.Enabled = false;
            Spcommon.APIDLL.R_SPAPI_Poll();
            tmrPoll.Enabled = true;
        }

        private void lblNewWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IEXPLORE.EXE", "http://www.sharppoint.com.hk"); 
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUserid_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
