using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;


namespace spapiApp
{
    public class Spcommon
    {
        public static Spapidll APIDLL;
        public static int login_status = 0;         //登录标记
        public static string acc_no = "";                //登录成功后记录账户
        public static int max_bal;                  //登录成功后记录最大现金结余数量
        public static int max_pos;                  //登录成功后记录最大持仓数量
        public static int max_order;                //登录成功后记录最大订单数量

        public static int Add_Order_Time;
        public static int Order_Reply_Time;

        public static frmMain main = null; 

        public static string S_Server;
        public static int S_Prot;
        public static string S_License;
        public static string S_App_id;
        public static string S_Userid;
        public static string S_Password;

        public static string ord_acc_no;

        public static int Business_Date;

        public const long AO_PRC      = ((long)0x7fffffff);
        public const byte ORD_LIMIT   =     0;
        public const byte ORD_AUCTION =     2;
        public const byte ORD_MARKET = 6;
        

        public static void Init()
        {
            APIDLL = new Spapidll();
            APIDLL.init();
        }

    }
}
