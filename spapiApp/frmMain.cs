using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
//using System.Threading.Tasks;
using System.Windows.Forms;


namespace spapiApp
{

    public partial class frmMain : Form
    {

        int Sar = 2;//定义一个全局线程变量
        static int number = 0;

        //Thread thread = new Thread((Run));

        delegate void SetTextCallback(string str);   //定义委托
        public frmMain()
        {
            InitializeComponent();
            Spcommon.APIDLL.RegisterShowTextEvent(PrintMainData);


            if (Spcommon.S_Prot == 8080)
            {
                btnAcc.Visible = false;
                btnRelease.Visible = false;
                this.Text = "SP API Trader [Client:" + Spcommon.S_Userid + "]";
            }
            else
            {
                this.Text = "SP API Trader [AE:" + Spcommon.S_Userid + "]";
            }

            PrintMainData("Business Date: " + Spcommon.APIDLL.unixTimeToStandTime(Spcommon.Business_Date, 2) + "[" + Spcommon.Business_Date.ToString() + "]");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string login_info;
            login_info = "User Id:" + Spcommon.acc_no + " max_bal：" + Spcommon.max_bal.ToString() + " max_pos:" + Spcommon.max_pos.ToString() + " max_order:" + Spcommon.max_order.ToString();
            //this.lbxMainData.Items.Add(login_info);           
        }

        public void PrintMainData(string text)
        {
            if (lbxMainData.InvokeRequired)  //控件是否跨线程？如果是，则执行括号里代码
            {
                SetTextCallback setListCallback = new SetTextCallback(PrintMainData);   //实例化委托对象
                lbxMainData.Invoke(setListCallback, text);   //重新调用SetListBox函数
            }
            else  //否则，即是本线程的控件，控件直接操作
            {
                lbxMainData.Items.Add(text);
                lbxMainData.SelectedIndex = lbxMainData.Items.Count - 1;
            }
        }

        private void btnOrderCount_Click(object sender, EventArgs e)
        {
            //LoadInput(16);
            if (Spcommon.S_Prot == 8080)
                Spcommon.APIDLL.R_SPAPI_GetOrderCount();
            else
                LoadInput(19);
        }

        private void btnOrderAdd_Click(object sender, EventArgs e)
        {
            LoadInput(1);

        }

        private void btnOrderAll_Click(object sender, EventArgs e)
        {
            Spcommon.APIDLL.R_SPAPI_GetOrder();

        }

        private void btnOrderDel_Click(object sender, EventArgs e)
        {
            LoadInput(2);
        }

        private void btnPosByProd_Click(object sender, EventArgs e)
        {
            LoadInput(4);
        }

        private void btnOrderChange_Click(object sender, EventArgs e)
        {
            LoadInput(3);
        }

        private void btnTradeByProd_Click(object sender, EventArgs e)
        {
            LoadInput(5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadInput(6);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LoadInput(7);
        }

        public void LoadInput(int idx)
        {
            frmInput Input = new frmInput(idx);
            Input.Width = 306;
            Input.Height = 225;
            Input.ShowDialog();
        }

        private void btnPosCount_Click(object sender, EventArgs e)
        {
            Spcommon.APIDLL.R_SPAPI_GetPosCount();
        }

        private void btnPosAll_Click(object sender, EventArgs e)
        {
            Spcommon.APIDLL.R_SPAPI_GetPos();
        }

        private void btnTradeCount_Click(object sender, EventArgs e)
        {
            Spcommon.APIDLL.R_SPAPI_GetTradeCount();
        }

        private void btnTradeAll_Click(object sender, EventArgs e)
        {
            Spcommon.APIDLL.R_SPAPI_GetTrade();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Spcommon.APIDLL.R_SPAPI_GetPriceCount();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Spcommon.APIDLL.R_SPAPI_GetPrice();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Confirm to Exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int rc;
                rc = Spcommon.APIDLL.R_SPAPI_Logout();
                if (rc == 0)
                {
                    //Spcommon.APIDLL.R_SPAPI_Uninitialize();
                    Application.ExitThread();
                }
            }
            else
                e.Cancel = true;
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            LoadInput(8);
        }

        private void btnSubTicker_Click(object sender, EventArgs e)
        {
            LoadInput(9);
        }

        private void btnUniTicker_Click(object sender, EventArgs e)
        {
            LoadInput(10);
        }

        private void btnAccInfo_Click(object sender, EventArgs e)
        {
            Spcommon.APIDLL.R_SPAPI_GetAccInfo();
        }

        private void btnBalCount_Click(object sender, EventArgs e)
        {
            Spcommon.APIDLL.R_SPAPI_GetAccBalCount();
        }

        private void btnBalAll_Click(object sender, EventArgs e)
        {
            Spcommon.APIDLL.R_SPAPI_GetAccBal();
        }

        private void btnBalByCcy_Click(object sender, EventArgs e)
        {
            LoadInput(11);
        }

        private void btnVersion_Click(object sender, EventArgs e)
        {
            Spcommon.APIDLL.R_SPAPI_GetDllVersion();
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            LoadInput(12);
        }

        private void btnOrderInactive_Click(object sender, EventArgs e)
        {
            LoadInput(13);
        }

        private void btnInstInfoCount_Click(object sender, EventArgs e)
        {
            Spcommon.APIDLL.R_SPAPI_GetInstrumentAndCount();
        }

        private void btnProdInfoCount_Click(object sender, EventArgs e)
        {
            Spcommon.APIDLL.R_SPAPI_GetProductAndCount();
        }

        private void btnInstByCode_Click(object sender, EventArgs e)
        {
            LoadInput(14);
        }

        private void btnProdByCode_Click(object sender, EventArgs e)
        {
            LoadInput(15);
        }

        private void btnTradeReport_Click(object sender, EventArgs e)
        {
            //LoadInput(17);
            Spcommon.APIDLL.R_SPAPI_LoadTradeReport();
        }

        private void btnDllVers_Click(object sender, EventArgs e)
        {
            Spcommon.APIDLL.R_SPAPI_GetDllVersionDouble();
        }

        private void btnOrderReport_Click(object sender, EventArgs e)
        {
            Spcommon.APIDLL.R_SPAPI_LoadOrderReport();
        }

        private void btnchangepsw_Click(object sender, EventArgs e)
        {
            LoadInput(16);
        }

        private void btnLoadinst_Click(object sender, EventArgs e)
        {
            Spcommon.APIDLL.R_SPAPI_LoadInstrumentList();
        }

        private void btnLoadprod_Click(object sender, EventArgs e)
        {
            //Spcommon.APIDLL.R_SPAPI_LoadProductInfoList();
            //load all product hide
        }

        private void btnLoadInstByCode_Click(object sender, EventArgs e)
        {
            LoadInput(17);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            LoadInput(18);
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            Spcommon.APIDLL.R_SPAPI_AccountLogout();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Spcommon.login_status == 0)
            {
                //frmLogin login = new frmLogin();
                //login.ShowDialog();
                Spcommon.APIDLL.R_SPAPI_SetBackgroundPoll(true);
                Spcommon.APIDLL.R_SPAPI_SetLoginInfo(Spcommon.S_Server, Spcommon.S_Prot, Spcommon.S_License, Spcommon.S_App_id, Spcommon.S_Userid, Spcommon.S_Password);
                Spcommon.APIDLL.R_SPAPI_Login();
            }
            else
            {
                Spcommon.APIDLL.LoginStatusBack(Spcommon.login_status);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            int rc;
            rc = Spcommon.APIDLL.R_SPAPI_Logout();
            Console.WriteLine("Logout:" + rc.ToString());
        }

        private void btnSetLogPath_Click(object sender, EventArgs e)
        {
            LoadInput(20);
        }

        private void btnCtrlLevel_Click(object sender, EventArgs e)
        {
            LoadInput(21);
        }

        private void btnccyrcount_Click(object sender, EventArgs e)
        {
            Spcommon.APIDLL.R_SPAPI_GetCcyRateCount();
        }

        private void btnccyrate_Click(object sender, EventArgs e)
        {
            Spcommon.APIDLL.R_SPAPI_GetCcyRate();
        }

        private void btnbyccy_Click(object sender, EventArgs e)
        {
            LoadInput(22);
        }

        private void HSIFdata_Click(object sender, EventArgs e)
        {
            LoadInput(23);  //我自己写的一个方法
        }


        //SAR指标的计算方法
        private void HSIData(object sender, EventArgs e)
        {
            LoadInput(24);
        }

        /// <summary>
        /// 开启SAR线程方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //if (Sar % 2 == 1)
            //{
            //    thread.Abort();
            //    ++Sar;
            //}
            //else
            //{
            //    //Console.WriteLine(thread.ThreadState + "************************************");获取当前id
            //    ++Sar;
            //    thread = new Thread((Run));
            //    thread.Start();
            //}
            Thread thread = new Thread((Run));
            thread.Start();


        }
        /// <summary>
        /// 不停查询数据库方法
        /// </summary>
        private static void Run()
        {

            try
            {
                string connStr = "Driver= {MySQL ODBC 3.51 Driver};Server=127.0.0.1;Database=realtimedata;User=root; Password=root; Option=3;";
                OdbcConnection myConnection = new OdbcConnection(connStr);  //创建数据库连接
                while (true)
                {
                    List<HSIFutures> dataList = new List<HSIFutures>(); //历史数据数组
                    SAR sar = new SAR();
                    List<double> sarList = new List<double>();          //sar值数组
                    List<HSIFutures> buy = new List<HSIFutures>();                    //买信号数组
                    List<HSIFutures> sell = new List<HSIFutures>();                   //卖信号数组
                    string sql = "SELECT * FROM hsiindh_1min t  ORDER BY id DESC LIMIT 100";
                    OdbcCommand myCommand = new OdbcCommand(sql, myConnection);  //创建sql和连接实例化的对象
                    myConnection.Open();
                    //           Console.WriteLine(myCommand.ExecuteNonQuery().ToString());
                    OdbcDataReader myReader = myCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        HSIFutures hSIFutures = new HSIFutures();
                        hSIFutures.SetSymbol(myReader[1].ToString());
                        hSIFutures.SetDate((DateTime)myReader[2]);
                        hSIFutures.SetOpen(double.Parse(myReader[3].ToString()));
                        hSIFutures.SetHigh(double.Parse(myReader[4].ToString()));
                        hSIFutures.SetLow(double.Parse(myReader[5].ToString()));
                        hSIFutures.SetClose(double.Parse(myReader[6].ToString()));
                        //hSIFutures.SetCreatedate(long.Parse(myReader[10].ToString()));
                        dataList.Add(hSIFutures);
                    }
                    myConnection.Close();
                    List<HSIFutures> positiveData = new List<HSIFutures>(); //排序后的数组
                    for (int i = dataList.Count - 1; i >= 0; i--)  //此方法为排序方法
                    {
                        positiveData.Add(dataList[i]);
                    }

                    sarList = sar.getSARLineDatas(positiveData, float.Parse("0.02"), float.Parse("0.2"));    //获取SAR的值

                   
                        if (positiveData[98].GetClose() <= sarList[98])
                        {
                            if (positiveData[99].GetClose() > sarList[99] && number % 2 == 0)
                            {
                                HSIFutures hSIFutures = new HSIFutures();
                                hSIFutures.SetSymbol(positiveData[99].GetSymbol());
                                hSIFutures.SetDate(positiveData[99].GetDate());
                                hSIFutures.SetOpen(positiveData[99].GetOpen());
                                hSIFutures.SetHigh(positiveData[99].GetHigh());
                                hSIFutures.SetLow(positiveData[99].GetLow());
                                hSIFutures.SetClose(positiveData[99].GetClose());
                                buy.Add(hSIFutures);
                                number++;
                            DialogResult result = MessageBox.Show("可以买入了！！！买入信号时间为" + buy[99].GetDate(), "买卖信号提示", MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Information);
                            String data3 = "######################" + "买入时间" + buy[99].GetDate();
                            Spcommon.APIDLL.output(data3);
                            }
                        }

                        if (positiveData[98].GetClose() >= sarList[98])
                        {
                            if (positiveData[99].GetClose() < sarList[99] && number % 2 != 0)
                            {
                                HSIFutures hSIFutures = new HSIFutures();
                                hSIFutures.SetSymbol(positiveData[99].GetSymbol());
                                hSIFutures.SetDate(positiveData[99].GetDate());
                                hSIFutures.SetOpen(positiveData[99].GetOpen());
                                hSIFutures.SetHigh(positiveData[99].GetHigh());
                                hSIFutures.SetLow(positiveData[99].GetLow());
                                hSIFutures.SetClose(positiveData[99].GetClose());
                                sell.Add(hSIFutures);
                                number++;
                            DialogResult result = MessageBox.Show("可以卖出了！！！卖出信号时间为" + sell[99].GetDate(), "买卖信号提示", MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Information);
                            String data2 =  "######################" +"卖出时间"+ sell[99].GetDate();
                                Spcommon.APIDLL.output(data2);
                            }
                        }
                     
                    
                    String data1 = "上一秒的SAR值"+ sarList[98]+"现在的SAR值"+sarList[99] + "######################" +"上一秒的底价" + positiveData[98].GetClose()+"现在的底价"+ positiveData[99].GetClose();
                    Spcommon.APIDLL.output(data1);

                    Thread.Sleep(1000);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("数据库连接失败" + "或者线程出现问题 " + ex.Message);

            }
        }



        private void Popout(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("可以买入了！！！", "买卖信号提示", MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExportExcel ee = new ExportExcel();
            ee.ExportToExcelWithTemplateByList();
        }
    }
}
