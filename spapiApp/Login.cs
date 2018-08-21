using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spapiApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            if (Spcommon.main == null)
            {
                Spcommon.Init();
                Spcommon.APIDLL.DllShowLoginText += PrintStatus;

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 登陆点击事件的登陆方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            int prot = 80;    //提供  80 81 83 88这几个接口
            string license = "5B4D4BAE54479";  //5B4D4BAE54479
            string app_id = "SPDEMO";  //都是demo的特征
            //Spcommon.acc_no = txtaccid.Text;
            string sUserid = textBox2.Text;
            string sPassword = textBox3.Text;
            string sServer = textBox1.Text;

            PrintStatus("Login...", 0);
            if (Spcommon.APIDLL.InitFlag == 0)
            {
                int rc;
                Spcommon.APIDLL.R_SPAPI_SetBackgroundPoll(true);
                Spcommon.APIDLL.R_SPAPI_SetLoginInfo(sServer, prot, license, app_id, sUserid, sPassword);
                rc = Spcommon.APIDLL.R_SPAPI_Logine();
                if (rc == 0)
                {
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



    }
}
