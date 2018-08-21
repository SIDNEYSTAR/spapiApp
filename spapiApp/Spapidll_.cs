using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using System.Security; 

/// <summary>
/// 定义订单 持仓 成交 价格的结构体
/// 注: MarshalAs 中的SizeConst的大小要与API中的一样
/// </summary>
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
public struct SPApiOrder
{
    public double Price;            //价格 //基 
    public double StopLevel;        //止损价格 //ゎ穕基 
    public double UpLevel;          //上限水平 //キ 
    public double UpPrice;          //上限价格 //基 
    public double DownLevel;        //下限水平 //キ 
    public double DownPrice;        //下限价格 //基 
    public Int64 ExtOrderNo;        //外部指示 //场ボ 
    public int IntOrderNo;          //用户订单编号 //ノめ璹虫絪腹 
    public int Qty;                 //剩下數量 //逞计秖
    public int TradedQty;           //已成交数量 //Θユ计秖 
    public int TotalQty;            //订单总数量//璹虫羆计秖 2012-12-27 xiaolin add
    public int ValidTime;           //有效时间 //Τ丁 
    public int SchedTime;           //预订发送时间 //箇璹祇癳丁 
    public int TimeStamp;           //服务器接收订单时间 //狝叭竟钡Μ璹虫丁 
    public int OrderOptions;       //合约价格有买0与卖0时可设置为T+1 //基Τ禦0籔芥0砞竚T+1 
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string AccNo;            //用户帐号 //ノめ眀腹 
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string ProdCode;         //合约代号 //腹 
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string Initiator;        //下单用户 //虫ノめ  
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string Ref;              //参考 //把σ 
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string Ref2;             //参考2 //把σ2 
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string GatewayCode;      //网关 //呼闽 
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
    public string ClOrderId;        //用户自定订单参考//ノめ﹚璹虫把σ 2012-12-27 xiaolin
    public byte BuySell;            //买卖方向 //禦芥よ 
    public byte StopType;           //止损类型 //ゎ穕摸
    public byte OpenClose;          //开平仓 //秨キ  
    public byte CondType;           //订单条件类型 //璹虫兵ン摸 
    public byte OrderType;          //订单类型 //璹虫摸      
    public byte ValidType;          //订单有效类型 //璹虫Τ摸 
    public byte Status;             //状态 //篈 
    public byte DecInPrice;         //合约小数位 //计 
};

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
public struct SPApiPos
{
    public int Qty;                     //上日仓位 //ら 
    public int DepQty;                  //存储仓位 //纗  
    public int LongQty;                 //今日长仓 //さら 
    public int ShortQty;                //今日短仓 //さら祏 
    public double TotalAmt;             //上日成交 //らΘユ 
    public double DepTotalAmt;          //上日持仓总数(数量*价格) //ら羆计(计秖*基) 
    public double LongTotalAmt;         //今日长仓总数(数量*价格) //さら羆计(计秖*基) 
    public double ShortTotalAmt;        //今日短仓总数(数量*价格) //さら祏羆计(计秖*基) 
    public double PLBaseCcy;            //盈亏(基本货币)
    public double PL;                   //盈亏
    public double ExchangeRate;         //汇率
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string AccNo;                //用户//ノめ 
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string ProdCode;             //合约代码 //絏 
    public byte LongShort;              //上日持仓买卖方向 //ら禦芥よ 
    public byte DecInPrice;             //合约小数位 //计 
};

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
public struct SPApiTrade
{
    public int RecNo;				   //成交记录
    public double Price;                //成交价格 //Θユ基
    public Int64 TradeNo;               //成交编号 //Θユ絪腹
    public Int64 ExtOrderNo;            //外部指示 //场ボ
    public int IntOrderNo;              //用户订单编号 //ノめ璹虫絪腹
    public int Qty;                     //成交数量 //Θユ计秖
    public int TradeDate;               //成交日期 //Θユら戳
    public int TradeTime;               //成交时间 //Θユ丁
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string AccNo;                //用户 //ノめ
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string ProdCode;             //合约代码 //絏
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string Initiator;            //下单用户 //虫ノめ
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string Ref;                  //参考 //把σ
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string Ref2;                 //参考2 //把σ2
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string GatewayCode;          //网关 //呼闽
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
    public string ClOrderId;            //用户自定订单参考//ノめ﹚璹虫把σ 2012-12-27 xiaolin
    public char BuySell;                //买卖方向 //禦芥よ
    public char OpenClose;              //开平仓 //秨キ
    public byte Status;                 //状态 //篈
    public byte DecInPrice;             //合约小数位 //计 
};

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
public struct SPApiPrice
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public double[] Bid;                    //买入价 //禦基
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public int[] BidQty;                    //买入量 //禦秖
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public int[] BidTicket;                 //买指令数量 //禦计秖
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public double[] Ask;                    //卖出价 //芥基
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public int[] AskQty;                    //卖出量 //芥秖
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public int[] AskTicket;                 //卖指令数量 //芥计秖
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public double[] Last;                   //成交价 //Θユ基
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public int[] LastQty;                   //成交数量 //Θユ计秖
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public int[] LastTime;                  //成交时间 //Θユ丁
    public double Equil;                    //平衡价 //キ颗基
    public double Open;                     //开盘价 //秨絃基
    public double High;                     //最高价 //程蔼基
    public double Low;                      //最低价 //程基
    public double Close;                    //收盘价 //Μ絃基
    public int CloseDate;                   //收市日期 //Μカら戳
    public double TurnoverVol;              //总成交量 //羆Θユ秖
    public double TurnoverAmt;              //总成交额 //羆Θユ肂
    public int OpenInt;                     //未平仓 //ゼキ
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string ProdCode;                 //合约代码 //絏
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
    public string ProdName;                 //合约名称 //嘿
    public byte DecInPrice;                 //合约小数位 //计
};

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
public struct SPApiTicker
{
    public double Price;            //价格 //基
    public int Qty;                 //成交量 //Θユ秖
    public int TickerTime;          //时间 //丁
    public int DealSrc;             //来源 //ㄓ方
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string ProdCode;         //合约代码 //絏
    public byte DecInPrice;         //小数位 //计
};

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
public struct SPApiAccInfo
{
    public double NAV;               // 资产净值				//add xiaolin 2013-03-19
    public double BuyingPower;       // 购买力					//add xiaolin 2013-03-19
    public double CashBal;           // 现金结余				//add xiaolin 2013-03-19
    public double MarginCall;        //追收金额
    public double CommodityPL;       //商品盈亏
    public double LockupAmt;         //冻结金额
    public double CreditLimit;      //信贷限额 // 獺禪肂
    public double MaxMargin;        //最高保证金 // 程蔼玂谍//modif xiaolin 2012-12-20 TradeLimit
    public double MaxLoanLimit;     //最高借贷上限 // 程蔼禪
    public double TradingLimit;     //信用交易額 // 獺ノユ肂
    public double RawMargin;        //原始保證金 // ﹍玂靡
    public double IMargin;          //基本保証金 //  膀セ玂谍
    public double MMargin;          //維持保証金 // 蝴玂谍
    public double TodayTrans;       //交易金額 // ユ肂
    public double LoanLimit;        //證券可按總值 // 靡ㄩ羆
    public double TotalFee;         //費用總額 //  禣ノ羆肂
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string AccName;                                  //戶口名稱 //  め嘿
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public string BaseCcy;                                  //基本貨幣 // 膀セ砯刽
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string MarginClass;                              //保証金類別 // 玂谍摸
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string TradeClass;                               //交易類別 // ユ摸
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string ClientId;                                 //客戶 // め
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string AEId;                                     //經紀 //  竒
    public byte AccType;                                    //戶口類別 // め摸
    public byte CtrlLevel;                                  //控制級數 //  北计
    public byte Active;                                     //生效 //  ネ
    public byte MarginPeriod;                               //時段 // 琿
};

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
public struct SPApiAccBal
{
    public double CashBf;		                            //上日结余 //ら挡緇
    public double TodayCash;		                        //今日存取 //さら
    public double NotYetValue;		                        //未交收 //ゼユΜ
    public double Unpresented;		                        //未兑现 //ゼ瞷
    public double TodayOut;		                            //提取要求 //矗璶―
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public string Ccy;			 	                        //货币 //砯刽
};

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
public struct SPApiInstrument
{
    public double Margin;           //保证金//玂靡
    public int ContractSize;        //合约价值//基
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string MarketCode;   //市场代码 //カ初絏
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string InstCode;     //产品系列代码 //玻珇╰絏
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
    public string InstName;     //英文名称 //璣ゅ嘿    
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
    public string InstName1;   //繁体名称 //羉砰嘿
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
    public string InstName2;   //简体名称 //虏砰嘿
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public string Ccy;         //产品系列的交易币种 //玻珇╰ユ刽贺
    public char DecInPrice;    //产品系列的小数位 //玻珇╰计
    public char InstType;      //产品系列的类型 //玻珇╰摸
};

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
public struct SPApiProduct
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string ProdCode;             //产品代码 //玻珇絏
    public char ProdType;               //产品类型 //玻珇摸
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
    public string ProdName;             //产品英文名称 //玻珇璣ゅ嘿
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string Underlying;           //关联的期货合约//闽羛戳砯
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string InstCode;             //产品系列名称 //玻珇╰嘿
    public int ExpiryDate;              //产品到期时间 //玻珇戳丁
    public char CallPut;                //期权方向认购与认沽 //戳舦よ粄潦籔粄猣
    public int Strike;                  //期权行使价//戳舦︽ㄏ基
    public int LotSize;                 //手数//も计
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
    public string ProdName1;            //产品繁体名称 //玻珇羉砰嘿
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
    public string ProdName2;            //产品简体名称 //玻珇虏砰嘿
    public char OptStyle;               //期权的类型//戳舦摸
    public int TickSize;                //产品价格最小变化位数//玻珇基程跑て计
};

namespace spapiApp
{
    //[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.StdCall)]
    //定义回调函数的方法
    public delegate void LoginReply(int ret_code, string ret_msg);                              //登录回复 //祅魁確          
    public delegate void LoginStatusUpdate(int ret_status);                                     //登录状态回复 //祅魁篈確
    public delegate void AccInfoReply(string acc_no, int max_bal, int max_pos, int max_order);  //登录成功回复用户信息 //祅魁Θ確ノめ獺
    public delegate void ApiOrderRequestFailed(byte action, ref SPApiOrder order, int err_code, string err_msg);//请求订单错误回调 //叫―璹虫岿粇秸 //xiaolin 2012-12-27 add
    public delegate void ApiPriceUpdate(ref SPApiPrice price);                                  //API价格更新回复 //基穝確
    public delegate void ApiOrderReport(int rec_no, ref SPApiOrder order);                      //订单报告回调//璹虫厨秸 //xiaolin 2012-12-27 add
    //public delegate void ProductListReady(int inst_cnt, int prod_cnt);                          //产品系列数量与所有产品数量回复 //玻珇╰计秖籔┮Τ玻珇计秖確
    public delegate void ApiTradeReport(int rec_no, ref SPApiTrade trade);                      //成交报告回调//Θユ厨秸//xiaolin 2012-12-27 add
    public delegate void LogoutReply(int ret_code, string ret_msg);                             //登出回复 //祅確
    public delegate void TickerUpdate(ref SPApiTicker ticker);                                  //市场成交记录回复 //カ初Θユ癘魁確
    public delegate void PServerLinkStatusUpdate(short host_id, int con_status);				//价格资讯连接状态回复 //基戈癟硈钡篈確
    public delegate void ConnectionErrorUpdate(short host_id, int link_err);				    //连接发生错误回复 //硈钡祇ネ岿粇確
    public delegate void PswChangeReply(int ret_code, string ret_msg);
    public delegate void InstrumentListReply(bool is_ready, string ret_msg);
    public delegate void ProductListReply(bool is_ready, string ret_msg);
    public delegate void ProductInfoListByCodeReply(string inst_code ,bool is_ready, string ret_msg);

    public class Spapidll
    {
        public static LoginReply MyLoginReply;
        public static LoginStatusUpdate MyLoginStatusUpdate;
        public static AccInfoReply MyAccInfoReply;
        public static ApiOrderRequestFailed MyApiOrderRequestFailed;
        public static ApiOrderReport MyApiOrderReport;
        public static ApiPriceUpdate MyApiPriceUpdate;
        //public static ProductListReady MyProductListReady;
        public static ApiTradeReport MyTradeUpate;
        public static LogoutReply MyLogoutReply;
        public static TickerUpdate MyTickerUpdate;
        public static PServerLinkStatusUpdate MyPServerLinkStatusUpdate;
        public static ConnectionErrorUpdate MyConnectionErrorUpdate;
        public static PswChangeReply MyPswChangeReply;
        public static InstrumentListReply MyInstrumentListReply;
        public static ProductListReply MyProductListReply;
        public static ProductInfoListByCodeReply MyProductInfoListByCodeReply;
        public delegate void ShowTextData(string info);
        public event ShowTextData DllShowTextData;
        public delegate void ShowLoginStatusText(string text, int ret_code);
        public event ShowLoginStatusText DllShowLoginText;


        //定义公共变量
        public const String SPAPIDLL = "spapidll64.dll";   //调用的DLL文件名//秸ノDLLゅン
        public int InitFlag;                              //初始化标志//﹍て夹粁
        public int ord_req_no = 1;                        //请求编号//叫―絪腹 
        public double Chg_Price;                          //订单修改价格 //璹虫э基
        public bool Inactive_Flag;                        //订单有效与无效设置//璹虫Τ籔礚砞竚

        
        /// <summary>
        /// 加载DLL中的方法
        /// 更DLLいよ猭
        /// </summary>
        //﹍て,poll,祅魁祅 ﹚竡
        //初始化,poll,登录登出 定义
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_Initialize", CharSet = CharSet.Ansi)]
        private static extern int SPAPI_Initialize();                    //初始化 //﹍て
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_Poll", CharSet = CharSet.Ansi)]
        public static extern void SPAPI_Poll();                         //建立一条通信连接，注:初始化后登录前无限循环请求 //ミ兵硄獺硈钡猔:﹍て祅魁玡礚碻吏叫―
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_SetBackgroundPoll", CharSet = CharSet.Ansi)]
        public static extern void SPAPI_SetBackgroundPoll(bool onoff);  //建立一条新的线程连接，只需请求一次，建议用 SPAPI_Poll. //ミ兵穝絬祘硈钡惠叫―Ω某ノ SPAPI_Poll.
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_SetLoginInfo", CharSet = CharSet.Ansi)]
        public static extern void SPAPI_SetLoginInfo(string host, int port, string license, string app_id, string user_id, string password);//发送登录信息，主机 端口 用户名 密码等 //祇癳祅魁獺诀 狠 ノめ 盞絏单
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_Login", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_Login();                         //登录 //祅魁        
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_Logout", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_Logout();                        //登出 //祅
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_GetLoginStatus", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_GetLoginStatus(short host_id);   //查询当前登录状态 //琩高讽玡祅魁篈
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_Uninitialize", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_Uninitialize(); 


        //调用DLL中订单的方法
        //秸ノDLLい璹虫よ猭
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_AddOrder", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_AddOrder(ref SPApiOrder order);   //下单 //虫 //modif xiaolin 2012-12-27
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_DeleteOrder", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_DeleteOrder(ref SPApiOrder order);               //撤单 //篗虫 //modif xiaolin 2012-12-27
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_ChangeOrder", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_ChangeOrder(ref SPApiOrder order, double org_price, int org_qty);//改单 //э虫 //modif xiaolin 2012-12-27
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_ActivateOrder", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_ActivateOrder(ref SPApiOrder order);           //设置订单有效与无效 //砞竚璹虫Τ籔礚//modif xiaoin 2012-12-27
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_InactivateOrder", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_InactivateOrder(ref SPApiOrder order);           //设置订单有效与无效 //砞竚璹虫Τ籔礚//add xiaolin 2012-12-27
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_GetOrderCount", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_GetOrderCount();                                             //查询买卖指示数量 //琩高禦芥ボ计秖
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_GetOrder", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_GetOrder(int idx, ref SPApiOrder order);                     //查询买卖指示 //琩高禦芥ボ 
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_GetOrderByOrderNo", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_GetOrderByOrderNo(string acc_no, int int_order_no, ref SPApiOrder order);   //根据买卖指示ID查询相应信息 //沮禦芥ボID琩高莱獺
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_ChangePassword", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_ChangePassword(string old_psw, string new_psw);


        //调用DLL中持仓的方法
        //秸ノDLLいよ猭
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_GetPosCount", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_GetPosCount();                                               //查询持仓数量 //琩高计秖       
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_GetPos", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_GetPos(int idx, ref SPApiPos pos);                           //查询持仓信息 //琩高獺
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_GetPosByProduct", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_GetPosByProduct(string prod_code, ref SPApiPos pos);         //根据合约查询持仓信息 //沮琩高獺

        //调用DLL中成交记录的方法
        //秸ノDLLいΘユ癘魁よ猭
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_GetTradeCount", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_GetTradeCount();                                             //查询成交数量 //琩高Θユ计秖
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_GetTrade", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_GetTrade(int idx, ref SPApiTrade trade);                     //查询成交记录信息 //琩高Θユ癘魁獺
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_GetTradeByTradeNo", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_GetTradeByTradeNo(int int_order_no, Int64 trade_no, ref SPApiTrade trade);//根据买卖指示ID与成交ID查询成交信息 //沮禦芥ボID籔ΘユID琩高Θユ獺

        //调用DLL中价格资讯的方法
        //秸ノDLLい基戈癟よ猭
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_SubscribePrice", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_SubscribePrice(string prod_code, int mode);              //定义合约价格 //﹚竡基
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_GetPriceByCode", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_GetPriceByCode(string prod_code, ref SPApiPrice price);  //根据合约查询合约信息 //沮琩高獺
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_GetPriceCount", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_GetPriceCount();                                         //取当定定义了的合约数量 //讽﹚﹚竡计秖
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_GetPrice", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_GetPrice(int idx, ref SPApiPrice price);                 //查询合约信息 //琩高獺

        //产品系列
        //玻珇╰
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_GetInstrumentCount", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_GetInstrumentCount();                                    //查询产品系列数量 //琩高玻珇╰计秖
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_GetInstrument", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_GetInstrument(int idx, ref SPApiInstrument inst);        //根据排序查询所有产品系列信息 //沮逼琩高┮Τ玻珇╰獺
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_GetInstrumentByCode", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_GetInstrumentByCode(string inst_code, ref SPApiInstrument inst);//根据产品系列代码查询产品系列的信息 //沮玻珇╰絏琩高玻珇╰獺

        //产品信息
        //玻珇獺
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_GetProductCount", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_GetProductCount();                                       //查询所有产品的数量 //琩高┮Τ玻珇计秖
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_GetProduct", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_GetProduct(int idx, ref SPApiProduct prod);              //根据排序查询所有产品的信息 //沮逼琩高┮Τ玻珇獺
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_GetProductByCode", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_GetProductByCode(string prod_code, ref SPApiProduct prod);//根据产品的合约代码查询产品的信息 //沮玻珇絏琩高玻珇獺


        //调用DLL中市场成交的方法
        //秸ノDLLいカ初Θユよ猭
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_SubscribeTicker", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_SubscribeTicker(string prod_code, int mode);             //市场成交记录 //カ初Θユ癘魁

        //调用DLL中户口资料的方法
        //秸ノDLLいめ戈よ猭
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_GetAccInfo", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_GetAccInfo(ref SPApiAccInfo acc_Info);                   //查询户口资料 // 琩高め戈
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_GetAccBalCount", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_GetAccBalCount();                                        //查询现金结余的个数 // 琩高瞷挡緇计
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_GetAccBal", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_GetAccBal(int idx, ref SPApiAccBal acc_Bal);             //查询现金结余信息 // 琩高瞷挡緇獺
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_GetAccBalByCurrency", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_GetAccBalByCurrency(string ccy, ref SPApiAccBal acc_Bal);//根据货币查询现金结余 // 沮砯刽琩高瞷挡緇

        //调用DLL中查看版本的方法
        //秸ノDLLい琩セよ猭
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_GetDLLVersion", CharSet = CharSet.Ansi)]
        public static extern double SPAPI_GetDLLVersion();//查询DLL版本 // 琩高DLLセ
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_GetDllVersion", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_GetDllVersion(StringBuilder dll_ver_no, StringBuilder dll_rel_no, StringBuilder dll_suffix);//查询DLL信息 //琩高DLL獺 
       

        //根据订单与成交记录的请求类型加载回调方法
        //沮璹虫籔Θユ癘魁叫―摸更秸よ猭
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_LoadOrderReport", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_LoadOrderReport(string acc_no);
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_LoadTradeReport", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_LoadTradeReport(string acc_no);

        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_LoadInstrumentList", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_LoadInstrumentList();
       
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_LoadProductInfoListByCode", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_LoadProductInfoListByCode(string inst_code);
        /// <summary>
        /// 注册DLL中的回调方法
        /// 更DLLいよ猭
        /// </summary>
        //登录信息回调函数
        //祅魁獺秸ㄧ计
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_RegisterLoginReply", CharSet = CharSet.Ansi)]
        public static extern void SPAPI_RegisterLoginReply(LoginReply pLoginReply);
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_RegisterLoginStatusUpdate", CharSet = CharSet.Ansi)]
        public static extern void SPAPI_RegisterLoginStatusUpdate(LoginStatusUpdate pLoginStatusUpdate);
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_RegisterLoginAccInfo", CharSet = CharSet.Ansi)]
        public static extern void SPAPI_RegisterLoginAccInfo(AccInfoReply pAccInfoReply);
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_RegisterLogoutReply", CharSet = CharSet.Ansi)]
        public static extern void SPAPI_RegisterLogoutReply(LogoutReply pLogoutReply);
        //线路连接状态回调函数
        //絬隔硈钡篈秸ㄧ计
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_RegisterPServerLinkStatusUpdate", CharSet = CharSet.Ansi)]
        public static extern void SPAPI_RegisterPServerLinkStatusUpdate(PServerLinkStatusUpdate pPServerLinkStatusUpdate);
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_RegisterConnectionErrorUpdate", CharSet = CharSet.Ansi)]
        public static extern void SPAPI_RegisterConnectionErrorUpdate(ConnectionErrorUpdate pConnectionErrorUpdate);
        //错误订单回调函数
        //岿粇璹虫秸ㄧ计
        //modif xiaolin 2012-12-27
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_RegisterOrderRequestFailed", CharSet = CharSet.Ansi)]
        public static extern void SPAPI_RegisterOrderRequestFailed(ApiOrderRequestFailed pOrderUpate);
        //有成交回调方法
        //ΤΘユ秸よ猭
        // modif xiaolin 2012-12-27
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_RegisterTradeReport", CharSet = CharSet.Ansi)]
        public static extern void SPAPI_RegisterTradeReport(ApiTradeReport pTradeUpate);
        //价格更新回调方法
        //基穝秸よ猭
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_RegisterApiPriceUpdate", CharSet = CharSet.Ansi)]
        public static extern void SPAPI_RegisterApiPriceUpdate(ApiPriceUpdate pApiPriceUpdate);

        //订单回调方法
        //璹虫秸よ猭
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_RegisterOrderReport", CharSet = CharSet.Ansi)] //add xiaolin 2012-12-27
        public static extern void SPAPI_RegisterOrderReport(ApiOrderReport pPriceUpdate);
        //产品系列数量与产数量回调方法
        //玻珇╰计秖籔玻计秖秸よ猭
        //[DllImport(SPAPIDLL, EntryPoint = "SPAPI_RegisterProductListReady", CharSet = CharSet.Ansi)]
        //public static extern void SPAPI_RegisterProductListReady(ProductListReady pProductListReady);
        
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_RegisterInstrumentListReply", CharSet = CharSet.Ansi)]
        public static extern void SPAPI_RegisterInstrumentListReply(InstrumentListReply pInstrumentListReply);
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_RegisterProductListReply", CharSet = CharSet.Ansi)]
        public static extern void SPAPI_RegisterProductListReply(ProductListReply pProductListReply);
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_RegisterProductListByCodeReply", CharSet = CharSet.Ansi)]
        public static extern void SPAPI_RegisterProductListByCodeReply(ProductInfoListByCodeReply pProductInfoListByCodeReply);

        //市场成交记录回调方法
        //カ初Θユ癘魁秸よ猭
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_RegisterTickerUpdate", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_RegisterTickerUpdate(TickerUpdate pTickerUpdate);

        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_RegisterPswChangeReply", CharSet = CharSet.Ansi)]
        public static extern void SPAPI_RegisterPswChangeReply(PswChangeReply pPswChangeReply);

        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_AccountLogin", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_AccountLogin(string acc_no);
        [DllImport(SPAPIDLL, EntryPoint = "SPAPI_AccountLogout", CharSet = CharSet.Ansi)]
        public static extern int SPAPI_AccountLogout(string acc_no);
         


        //初始化注册回调函数
        //﹍て爹秸ㄧ计
        public void init()
        { 
            InitFlag = R_SPAPI_Initialize();        //DLL初始化//DLL﹍て
            if (InitFlag == 0)                      //是否初始化 0：成功//琌﹍て 0Θ
            {
                /// <summary>
                /// 回调函数调用的方法
                /// 秸ㄧ计秸ノよ猭
                /// </summary>
                //登录触发的方法
                //祅魁牟祇よ猭

                MyLoginReply = new LoginReply(LoginCallBack);
                SPAPI_RegisterLoginReply(MyLoginReply);

                //登录状态回调方法
                //祅魁篈秸よ猭
                MyLoginStatusUpdate = new LoginStatusUpdate(LoginStatusBack);
                SPAPI_RegisterLoginStatusUpdate(MyLoginStatusUpdate);

                //登录成功后触发的个人信息方法
                //祅魁Θ牟祇獺よ猭
                MyAccInfoReply = new AccInfoReply(AccInfoReplyBack);
                SPAPI_RegisterLoginAccInfo(MyAccInfoReply);

                //订单有更新触发的方法
                //璹虫Τ穝牟祇よ猭
                MyApiOrderRequestFailed = new ApiOrderRequestFailed(ApiOrderRequestFailedBack);
                SPAPI_RegisterOrderRequestFailed(MyApiOrderRequestFailed);


                MyApiPriceUpdate = new ApiPriceUpdate(ApiPriceUpdateBack);
                SPAPI_RegisterApiPriceUpdate(MyApiPriceUpdate);

                MyApiOrderReport = new ApiOrderReport(ApiOrderReportBack); //add xiaoin 2012-12-27
                SPAPI_RegisterOrderReport(MyApiOrderReport);

                //MyProductListReady = new ProductListReady(ProductListBack);
                //SPAPI_RegisterProductListReady(MyProductListReady);
                MyInstrumentListReply = new InstrumentListReply(InstrumentListReplyBack);
                SPAPI_RegisterInstrumentListReply(MyInstrumentListReply);
                //MyProductListReply = new ProductListReply(ProductListReplyBack);
                //SPAPI_RegisterProductListReply(MyProductListReply);

                //有成交记录触发的方法
                //ΤΘユ癘魁牟祇よ猭
                MyTradeUpate = new ApiTradeReport(ApiTradeReportBack);
                SPAPI_RegisterTradeReport(MyTradeUpate);

                //登出触发的方法
                //祅牟祇よ猭
                MyLogoutReply = new LogoutReply(LogoutBack);
                SPAPI_RegisterLogoutReply(MyLogoutReply);

                //市场有成交触发的方法
                //カ初ΤΘユ牟祇よ猭
                MyTickerUpdate = new TickerUpdate(TickerCallBack);
                SPAPI_RegisterTickerUpdate(MyTickerUpdate);

                //价格资讯83 87 88三条线路的连接状态发生改变触发方法
                //基戈癟83 87 88兵絬隔硈钡篈祇ネэ跑牟祇よ猭
                MyPServerLinkStatusUpdate = new PServerLinkStatusUpdate(PServerLinkStatusUpdateBack);
                SPAPI_RegisterPServerLinkStatusUpdate(MyPServerLinkStatusUpdate);

                //连接线路发生连接错误触发方法
                //硈钡絬隔祇ネ硈钡岿粇牟祇よ猭
                MyConnectionErrorUpdate = new ConnectionErrorUpdate(ConnectionErrorUpdateBack);
                SPAPI_RegisterConnectionErrorUpdate(MyConnectionErrorUpdate);

                MyPswChangeReply = new PswChangeReply(PswChangeReplyBack);
                SPAPI_RegisterPswChangeReply(MyPswChangeReply);

                MyProductInfoListByCodeReply = new ProductInfoListByCodeReply(ProductInfoListByCodeReplyBack);
                SPAPI_RegisterProductListByCodeReply(MyProductInfoListByCodeReply);

            }
        }

        /// <summary> DLL初始化
        /// 初始化DLL方法
        /// </summary>
        /// <returns>0：成功</returns>
        /// <summary> DLL﹍て
        /// ﹍てDLLよ猭
        /// </summary>
        /// <returns>0Θ</returns>
        public int R_SPAPI_Initialize()
        {
            return SPAPI_Initialize();
        }

        public int R_SPAPI_Uninitialize()
        {
            return SPAPI_Uninitialize();
        }

        /// <summary> 通信连接
        /// 建立一条通信连接，注:初始化后登录前无限循环请求
        /// </summary>
        /// <summary> 硄獺硈钡
        /// ミ兵硄獺硈钡猔:﹍て祅魁玡礚碻吏叫―
        /// </summary>
        public void R_SPAPI_Poll()
        {
            SPAPI_Poll();     
        }

        /// <summary> 新的线程连接
        /// 建立一条新的线程连接，只需请求一次，建议用 SPAPI_Poll.
        /// </summary>
        /// <param name="onoff">True:启动线程，False：线程挂起</param>
        /// <summary> 穝絬祘硈钡
        /// ミ兵穝絬祘硈钡惠叫―Ω某ノ SPAPI_Poll.
        /// </summary>
        /// <param name="onoff">True:币笆絬祘False絬祘本癬</param>
        public void R_SPAPI_SetBackgroundPoll(bool onoff)
        {
            SPAPI_SetBackgroundPoll(onoff);
        }

        /// <summary>设置登录信息
        /// 发送登录信息，主机 端口 用户名 密码等
        /// </summary>
        /// <param name="host">主机名</param>
        /// <param name="port">端口</param>
        /// <param name="license">许可证</param>
        /// <param name="app_id">应用名</param>
        /// <param name="user_id">用户名</param>
        /// <param name="password">密码</param>
        /// <summary>砞竚祅魁獺
        /// 祇癳祅魁獺诀 狠 ノめ 盞絏单
        /// </summary>
        /// <param name="host">诀</param>
        /// <param name="port">狠</param>
        /// <param name="license">砛靡</param>
        /// <param name="app_id">莱ノ</param>
        /// <param name="user_id">ノめ</param>
        /// <param name="password">盞絏</param>
        public void R_SPAPI_SetLoginInfo(string host, int port, string license, string app_id, string user_id, string password)
        {

            SPAPI_SetLoginInfo(host, port, license, app_id, user_id, password);
        }

        /// <summary>登录请求
        /// 发送登录请求，发送前要设置登录信息
        /// </summary>
        /// <returns>0：发送登录成功</returns>
        /// <summary>祅魁叫―
        /// 祇癳祅魁叫―祇癳玡璶砞竚祅魁獺
        /// </summary>
        /// <returns>0祇癳祅魁Θ</returns>
        public int R_SPAPI_Login()
        {
            return SPAPI_Login();
        }

        /// <summary>登录回复
        /// 登录回复
        /// </summary>
        /// <param name="ret_code">登录回复代码</param>
        /// <param name="ret_msg">登录回复信息</param>
        /// <summary>祅魁確
        /// 祅魁確
        /// </summary>
        /// <param name="ret_code">祅魁確絏</param>
        /// <param name="ret_msg">祅魁滦獺</param>
        public void LoginCallBack(int ret_code, string ret_msg)
        {
            if (DllShowLoginText != null && ret_code != 0) DllShowLoginText(ret_msg.ToString(), ret_code);
        }

        /// <summary>登录状态回复
        /// 登录状态:0 ~ 11种状态.有登出 连接 连接中 登录中 已登录......
        /// </summary>
        /// <param name="ret_status">0~11</param>
        /// <summary>祅魁篈確
        /// 祅魁篈:0 ~ 11贺篈.Τ祅 硈钡 硈钡い 祅魁い 祅魁......
        /// </summary>
        /// <param name="ret_status">0~11</param>
        public void LoginStatusBack(int ret_status)
        {
            string msg = "";
            switch (ret_status)
            {
                case 0:
                    msg = "Closed";        Spcommon.login_status = 0; break;
                case 1:
                    msg = "Connecting";    Spcommon.login_status = 1; break;
                case 2:
                    msg = "Connected";     Spcommon.login_status = 2; break;
                case 3:
                    msg = "Connect_Error"; Spcommon.login_status = 3; break;
                case 4:
                    msg = "Logging_In";    Spcommon.login_status = 4; break;
                case 5:
                    msg = "Logged_In";     Spcommon.login_status = 5; break;
                case 6:
                    msg = "Logging_Out";   Spcommon.login_status = 6; break;
                case 7:
                    msg = "Logged_Out";    Spcommon.login_status = 7; break;
                case 8:
                    msg = "Login_Failed";  Spcommon.login_status = 8; break;
                case 9:
                    msg = "Connection_Lost"; Spcommon.login_status = 9;  break;
                case 10:
                    msg = "Closing";         Spcommon.login_status = 10; break;
                case 11:
                    msg = "Host_Req";        Spcommon.login_status = 11; break;
            }
            if (DllShowLoginText != null) DllShowLoginText(msg, ret_status);
            if (DllShowTextData != null) DllShowTextData("User Login Status: " + ret_status.ToString() + ", msg:" + msg);
        }

        /// <summary>登录成功
        /// 登录成功后触发的方法
        /// </summary>
        /// <param name="acc_no">用户名</param>
        /// <param name="max_bal"></param>
        /// <param name="max_pos">最多持仓</param>
        /// <param name="max_order">最多订单</param>
        /// <summary>祅魁Θ
        /// 祅魁Θ牟祇よ猭
        /// </summary>
        /// <param name="acc_no">ノめ</param>
        /// <param name="max_bal"></param>
        /// <param name="max_pos">程</param>
        /// <param name="max_order">程璹虫</param>
        public void AccInfoReplyBack(string acc_no, int max_bal, int max_pos, int max_order)
        {
            Spcommon.acc_no    = acc_no.ToString();
            Spcommon.max_bal   = max_bal;
            Spcommon.max_pos   = max_pos;
            Spcommon.max_order = max_order;
            if (DllShowTextData != null) DllShowTextData("Acc_no:" + Spcommon.acc_no + ",max_bal:" + max_bal.ToString() + ",max_pos:" + max_pos.ToString() + ",max_order:" + max_order.ToString());
        }

        /// <summary>登出回复
        /// 登出回复，登录成功 代码为0 信息为空,如果失败就有相当的代码与信息
        /// </summary>
        /// <param name="ret_code">代码</param>
        /// <param name="ret_msg">信息</param>
        /// <summary>祅確
        /// 祅確祅魁Θ 絏0 獺,狦ア毖碞Τ讽絏籔獺
        /// </summary>
        /// <param name="ret_code">絏</param>
        /// <param name="ret_msg">獺</param>
        public void LogoutBack(int ret_code, string ret_msg)
        {
            int rc;
            if (DllShowTextData != null) DllShowTextData("Logout Code:" + ret_code.ToString() + ", Msg:" + ret_msg);
            if (ret_code == 0)
            {
        
               // rc = R_SPAPI_Uninitialize();
            }
        }

        /// <summary>登出
        /// 发送登出请求
        /// </summary>
        /// <returns>0:发送登出成功</returns>
        /// <summary>祅
        /// 祇癳祅叫―
        /// </summary>
        /// <returns>0:祇癳祅Θ</returns>
        public int R_SPAPI_Logout()
        {
            return SPAPI_Logout();
        }

        /// <summary>账户资料
        /// 账户资料
        /// </summary>
        /// <summary>姐め戈
        /// 姐め戈
        /// </summary>
        public void R_SPAPI_GetAccInfo()
        {
            int rc;
            SPApiAccInfo acc_info = new SPApiAccInfo();

            rc = SPAPI_GetAccInfo(ref acc_info);
            if (rc == 0)
            {
                if (DllShowTextData != null)
                {
                    DllShowTextData("Acc Info, User Id:" + acc_info.ClientId + ", AE:" + acc_info.AEId + " Ccy:" + acc_info.BaseCcy + " Margin Class:" + acc_info.MarginClass + " NAV:" + acc_info.NAV.ToString() + " BuyingPower:" + acc_info.BuyingPower.ToString());
                    DllShowTextData(" CashBal:" + acc_info.CashBal.ToString() + " MarginCall:" + acc_info.MarginCall.ToString() + " CommodityPL:" + acc_info.CommodityPL.ToString() + " LockupAmt:" + acc_info.LockupAmt.ToString());
                }
            }
        }

        /// <summary>添加订单
        /// 添加订单
        /// </summary>
        /// <param name="buy_sell">B：买入,S:沽出</param>
        /// <param name="pirce">下单价格</param>
        /// <param name="prodCode">订单合约名</param>
        /// <param name="qty">下单数量</param>
        /// <summary>睰璹虫
        /// 睰璹虫
        /// </summary>
        /// <param name="buy_sell">B禦,S:猣</param>
        /// <param name="pirce">虫基</param>
        /// <param name="prodCode">璹虫</param>
        /// <param name="qty">虫计秖</param>
        public void R_SPAPI_AddOrder(char buy_sell, string pirce, string prodCode, string qty, string clorderid)
        {
            int rc;
            SPApiOrder order = new SPApiOrder();
            string acc;


            if (Spcommon.S_Prot == 8081) acc = Spcommon.ord_acc_no;
            else acc = Spcommon.acc_no;

            order.AccNo = acc;
            order.Initiator = Spcommon.S_Userid;
            order.BuySell = Convert.ToByte(buy_sell);
            order.Price = Convert.ToDouble(pirce);
            order.Qty = Convert.ToInt32(qty);
            order.ProdCode = prodCode;

            order.Ref = "@TRADERAPI";      //参考
            order.Ref2 = "0";
            order.GatewayCode = "";
            order.DecInPrice = 0;          //合约小数位
            order.CondType = 0;

            order.ClOrderId = clorderid;

            rc = SPAPI_AddOrder(ref order);  //rc:0 成功 //modif xiaolin 2012-12-27

            if (rc == 0) { if (DllShowTextData != null) DllShowTextData("Add Order Success!"); }
            else { if (DllShowTextData != null) DllShowTextData("Add Order Failure! " + rc.ToString()); }

        }

        /// <summary>删除订单
        /// 根据订单编号删除订单
        /// </summary>
        /// <param name="order_id">要删除的订单编号</param>
        /// <summary>埃璹虫
        /// 沮璹虫絪腹埃璹虫
        /// </summary>
        /// <param name="order_id">璶埃璹虫絪腹</param>
        public void R_SPAPI_DeleteOrder(string order_id, string prod_code)//modif xiaolin 2012-12-27
        {
            int rc, int_order_no;
            SPApiOrder order = new SPApiOrder();
            string acc;

            if (Spcommon.S_Prot == 8081) acc = Spcommon.ord_acc_no;
            else acc = Spcommon.acc_no;

            int_order_no = Convert.ToInt32(order_id);
            order.IntOrderNo = int_order_no;
            order.ProdCode = prod_code;
            order.AccNo = acc;


            rc = SPAPI_DeleteOrder(ref order);
            if (rc == 0) { if (DllShowTextData != null) DllShowTextData("Del Order Success!"); }
            else { if (DllShowTextData != null) DllShowTextData("Del Order Failure! " + rc.ToString()); } 
        }

        /// <summary>订单数量
        /// 获取订单数量
        /// </summary>
        /// <summary>璹虫计秖
        /// 莉璹虫计秖
        /// </summary>
        public void R_SPAPI_GetOrderCount()
        {
            int count = 0;
            string ord_info;
            string acc;
            int cnt, rc;
            SPApiOrder order = new SPApiOrder();

            if (Spcommon.S_Prot == 8080)
            {
                acc = Spcommon.acc_no;
                count = SPAPI_GetOrderCount();
            }
            else
            {
                acc = Spcommon.ord_acc_no;
                cnt = SPAPI_GetOrderCount();
                if (acc == "***")
                    count = cnt;
                else
                {
                    for (int i = 0; i < cnt; i++)
                    {
                        rc = SPAPI_GetOrder(i, ref order);
                        if (rc == 0)
                        {
                            if (order.AccNo == acc) count++;
                        }
                    }
                }
            }
            ord_info = "User Id:" + acc + " Order Count:" + count.ToString();
            if (DllShowTextData != null) DllShowTextData(ord_info);

        }


        /// <summary>取所有工作中订单
        /// 取所有工作中订单
        /// </summary>
        /// <summary>┮Τい璹虫
        ///┮Τい璹虫
        /// </summary>
        public void R_SPAPI_GetOrder()
        {
            int i, rc, count;
            string order_info;
            SPApiOrder order = new SPApiOrder();

            count = SPAPI_GetOrderCount();  //订单数量
            if (count == 0) if (DllShowTextData != null) DllShowTextData("No Order!");
            for (i = 0; i < count; i++)
            {
                rc = SPAPI_GetOrder(i, ref order); //从第一个开始取
                if (rc == 0)
                {
                    order_info = "[Acc No:"+ order.AccNo +"] Order#=" + order.IntOrderNo.ToString() + " Status:" + order.Status.ToString() + " B/S=" + Convert.ToChar(order.BuySell) + " ProdCode=" + order.ProdCode + " Price=" + order.Price.ToString() + " Qty=" + order.Qty.ToString() + ",ClOrderId=" + order.ClOrderId;
                    if (DllShowTextData != null) DllShowTextData("[Order: " + (i + 1).ToString() + "] " + order_info);
                    order_info = "";
                }
                else
                    if (DllShowTextData != null) DllShowTextData("[Order: " + (i + 1).ToString() + "] " + "Read Failure!");
            }
        }

        /// <summary>修改订单
        /// 修改订单,只能修改订单价格
        /// </summary>
        /// <param name="intOrderNo">订单ID</param>
        /// <param name="chg_price">要修改的价格</param>
        /// <summary>э璹虫
        /// э璹虫,э璹虫基
        /// </summary>
        /// <param name="intOrderNo">璹虫ID</param>
        /// <param name="chg_price">璶э基</param>
        public void R_SPAPI_ChangeOrder(string intOrderNo, string chg_price, string chg_clorderid)
        {
            int rc;
            SPApiOrder order = new SPApiOrder();
            string acc;

            if (Spcommon.S_Prot == 8081) acc = Spcommon.ord_acc_no;
            else acc = Spcommon.acc_no;

            int int_order_no = Convert.ToInt32(intOrderNo);
            SPAPI_GetOrderByOrderNo(acc, int_order_no, ref order);
            

            double org_price = order.Price;
            order.Price = Convert.ToDouble(chg_price);
            order.ClOrderId = chg_clorderid;


            rc = SPAPI_ChangeOrder(ref order, org_price, order.Qty);
            if (rc == 0) { if (DllShowTextData != null) DllShowTextData("Change Order..."); }
            else { if (DllShowTextData != null) DllShowTextData("Change Order Failure! " + rc.ToString()); }


        }

        /// <summary> 订单请求出错回调信息
        /// 订单请求出错回调信息
        /// </summary>
        /// <param name="action"></param>
        /// <param name="order">订单信息</param>
        /// <param name="err_code">错误编号</param>
        /// <param name="err_msg">错误信息</param>
        /// <summary> 璹虫叫―岿秸獺
        /// 璹虫叫―岿秸獺
        /// </summary>
        /// <param name="action"></param>
        /// <param name="order">璹虫獺</param>
        /// <param name="err_code">岿粇絪腹</param>
        /// <param name="err_msg">岿粇獺</param>
        public void ApiOrderRequestFailedBack(byte action, ref SPApiOrder order, int err_code, string err_msg) //modif xiaolin 2012-12-27
        {
            if (DllShowTextData != null) DllShowTextData("Order Request Failed:Order#:" + order.IntOrderNo.ToString() + " [" + err_code.ToString() + " (" + err_msg + ")], Action=" + action.ToString());
        }

        /// <summary>持仓数量
        /// 获取持仓的数量
        /// </summary>
        /// <summary>计秖
        /// 莉计秖
        /// </summary>
        public void R_SPAPI_GetPosCount()
        {
            int count;
            string pos_info;

            count = SPAPI_GetPosCount();
            pos_info = "User Id:" + Spcommon.acc_no + "  Pos Count:" + count.ToString();
            if (DllShowTextData != null) DllShowTextData(pos_info);

        }

        /// <summary>所有持仓信息
        /// 获取所有持仓信息
        /// </summary>
        /// <summary>┮Τ獺
        /// 莉┮Τ獺
        /// </summary>
        public void R_SPAPI_GetPos()
        {
            int i, rc, count;
            string pos_info;
            string prev;

            SPApiPos pos = new SPApiPos();

            count = SPAPI_GetPosCount();  //持仓数量
            if (count == 0) if (DllShowTextData != null) DllShowTextData("No Pos!");
            for (i = 0; i < count; i++)
            {
                rc = SPAPI_GetPos(i, ref pos);   //从0开始开持仓信息
                if (rc == 0)
                {
                    prev =(pos.LongShort == 'B')?pos.Qty.ToString():(-1*pos.Qty).ToString();
                    pos_info = "User Id:" + pos.AccNo + " Product:" + pos.ProdCode + " ,Prev.：" + prev + "@" + pos.TotalAmt + " ,Day Long:" + pos.LongQty + "@" + pos.LongTotalAmt + " ,Day Short" + pos.ShortQty + "@"  + pos.ShortTotalAmt +  " PLBaseCcy:"+ pos.PLBaseCcy.ToString()+ " PL:"+pos.PL.ToString() + " ExcRate:"+pos.ExchangeRate.ToString();
                    if (DllShowTextData != null) DllShowTextData("[Pos: " + (i+1).ToString() + "] " + pos_info);
                    pos_info = prev = "";
                }
                else
                    if (DllShowTextData != null) DllShowTextData("[Pos: " + (i + 1).ToString() + "] " + "Read Failure!");
            }
            if (count == 0)
                if (DllShowTextData != null) DllShowTextData("No Pos!");
        }

        /// <summary>指定合约的持仓信息
        /// 根据合约代码查询指定合约的持仓信息
        /// </summary>
        /// <param name="prod_code">合约代码</param>
        /// <summary>﹚獺
        /// 沮絏琩高﹚獺
        /// </summary>
        /// <param name="prod_code">絏</param>
        public void R_SPAPI_GetPosByProduct(string prod_code)
        {
            int rc;
            string pos_info;
            string prev;
            SPApiPos pos = new SPApiPos();

            rc = SPAPI_GetPosByProduct(prod_code, ref pos);
            if (rc == 0)
            {
                prev = (pos.LongShort == 'B') ? pos.Qty.ToString() : (-1 * pos.Qty).ToString();
                pos_info = "User Id:" + pos.AccNo + " Product:" + pos.ProdCode + " ,Prev.：" + prev + "@" + pos.TotalAmt + " ,Day Long:" + pos.LongQty + "@" + pos.LongTotalAmt + " ,Day Short" + pos.ShortQty + "@" + pos.ShortTotalAmt;
                if (DllShowTextData != null) DllShowTextData(pos_info);
                pos_info = prev = "";
            }
            else
                if (DllShowTextData != null) DllShowTextData("No:"+prod_code+" Pos Info!");
        }

        /// <summary>成交数量
        /// 查询成交数量
        /// </summary>
        /// <summary>Θユ计秖
        /// 琩高Θユ计秖
        /// </summary>
        public void R_SPAPI_GetTradeCount()
        {
            int count;
            string trade_info;

            count = SPAPI_GetTradeCount();
            trade_info = "User Id:" + Spcommon.acc_no + "  Clear Trade Count:" + count.ToString();
            if (DllShowTextData != null) DllShowTextData(trade_info);
        }

        /// <summary>所有成交
        /// 查询所有成交记录
        /// </summary>
        /// <summary>┮ΤΘユ
        /// 琩高┮ΤΘユ癘魁
        /// </summary>
        public void R_SPAPI_GetTrade()
        { 
            int i, rc, count;
            string trade_info;
            SPApiTrade trade = new SPApiTrade();

            count = SPAPI_GetTradeCount();   //成交数量 
            if (count == 0) if (DllShowTextData != null) DllShowTextData("No Clear Trade!");
            for (i = 0; i < count; i++)
            {
                rc = SPAPI_GetTrade(i, ref trade);  //从0开始取所有成交记录
                if (rc == 0)
                {
                    trade_info = "Order Id:"+trade.IntOrderNo.ToString()+" Trade Id:"+trade.TradeNo.ToString()+" Product:" + trade.ProdCode + " B/S:" + Convert.ToChar(trade.BuySell) + " Trade Count:" + trade.Qty.ToString() + " Trade Price:" + trade.Price.ToString();
                    if (DllShowTextData != null) DllShowTextData("[Trade Log: " + (i+1).ToString() + "] " + trade_info);
                    trade_info =  "";
                }
                else
                    if (DllShowTextData != null) DllShowTextData("[Trade Log: " + (i + 1).ToString() + "] " + "Read Failure!");
            }
            if (count == 0)
                if (DllShowTextData != null) DllShowTextData("No Trade!");
        }

        /// <summary>查询指定成交
        /// 根据订单编号与成交编号查询指定成交记录
        /// </summary>
        /// <param name="order_no">订单编号</param>
        /// <param name="trade_no">成交编号</param>
        /// <summary>琩高﹚Θユ
        /// 沮璹虫絪腹籔Θユ絪腹琩高﹚Θユ癘魁
        /// </summary>
        /// <param name="order_no">璹虫絪腹</param>
        /// <param name="trade_no">Θユ絪腹</param>
        public void R_SPAPI_GetTradeByTradeNo(string order_no, string trade_no)
        {
            int rc;
            string trade_info;
            int by_order_no = Convert.ToInt32(order_no);
            Int64 by_trade_no = Convert.ToInt64(trade_no);
            SPApiTrade trade =new SPApiTrade();

            rc = SPAPI_GetTradeByTradeNo(by_order_no, by_trade_no, ref trade);
            if (rc == 0)
            {
                trade_info = "Order Id:" + trade.IntOrderNo.ToString() + " Trade Id:" + trade.TradeNo.ToString() + " Product:" + trade.ProdCode + " B/S:" + Convert.ToChar(trade.BuySell) + " Trade Count:" + trade.Qty.ToString() + " Trade Price:" + trade.Price.ToString();
                if (DllShowTextData != null) DllShowTextData(trade_info);
                trade_info = "";
            }
            else
                if (DllShowTextData != null) DllShowTextData("[No Log] Order Id:" + order_no+", Trade Id:"+trade_no);
            

        }

        /// <summary>成交记录回复
        /// 有成交记录回复
        /// </summary>
        /// <param name="acc_no">回复用户名</param>
        /// <param name="int_order_no">回复订单编号</param>
        /// <param name="trade_no">回复的成交编号</param>
        /// <summary>Θユ癘魁確
        /// ΤΘユ癘魁確
        /// </summary>
        /// <param name="acc_no">確ノめ</param>
        /// <param name="int_order_no">確璹虫絪腹</param>
        /// <param name="trade_no">確Θユ絪腹</param>
        public void ApiTradeReportBack(int rec_no, ref SPApiTrade trade)//modif xiaolin 2012-12-27
        {
            string trade_info;
            trade_info = "Trade Report(" + trade.AccNo + "):Req No:" + rec_no.ToString() + ", Status:" + trade.Status.ToString() + ", Order#" + trade.IntOrderNo.ToString() + " , trade_no=" + trade.TradeNo.ToString() + ", trade_price=" + trade.Price.ToString() + ", trade_qty=" + trade.Qty.ToString() + " TimeStamp:" + unixTimeToStandTime(trade.TradeTime, 3);
            if (DllShowTextData != null) DllShowTextData(trade_info);
        }

        /// <summary>订阅合约
        /// 订阅合约
        /// </summary>
        /// <param name="prod_code">要订阅的合约名</param>
        /// <param name="mode">订阅合约mode为1，取消合约更新:0</param>
        /// <summary>璹綷
        /// 璹綷
        /// </summary>
        /// <param name="prod_code">璶璹綷</param>
        /// <param name="mode">璹綷mode1穝:0</param>
        public void R_SPAPI_SubscribePrice(string prod_code, int mode)
        {
            int rc;

            rc = SPAPI_SubscribePrice(prod_code, mode);

            if (rc == 0)
            {
                if (DllShowTextData != null) DllShowTextData((mode == 1 ? "Insert Price:" : "Remove Price：") + prod_code + " ...!");
            }
            else
            {
                if (DllShowTextData != null) DllShowTextData((mode == 1 ? "Insert Price:" : "Remove Price：") + prod_code + "Failure!");
            }
        }

        /// <summary>订单回调
        /// 订单回调
        /// </summary>
        /// <param name="rec_no">请求编号</param>
        /// <param name="order">订单信息</param>
        /// <summary>璹虫秸
        /// 璹虫秸
        /// </summary>
        /// <param name="rec_no">叫―絪腹</param>
        /// <param name="order">璹虫獺</param>
        public void ApiOrderReportBack(int rec_no, ref SPApiOrder order)//add xiaolin 2012-12-27
        {
            string prc_info;
            prc_info = "OrderReport(" + order.AccNo + ":" + Convert.ToChar(order.BuySell) + "):ReqNo:" + rec_no.ToString() + ", Status:" + order.Status.ToString() + " , Order#" + order.IntOrderNo.ToString() + ", ProdCode=" + order.ProdCode + ", Price=" + order.Price.ToString() + ", Qty=" + order.Qty.ToString() + ",TradeQty=" + order.TradedQty.ToString() + ",TotalQty=" + order.TotalQty.ToString() + ",ClOrderId=" + order.ClOrderId + " TimeStamp:" + unixTimeToStandTime(order.TimeStamp, 3);
            if (DllShowTextData != null) DllShowTextData(prc_info);
        }

        /// <summary>价格更新
        /// 价格更新回复
        /// </summary>
        /// <param name="prc">回复有更新的结构wsg</param>
        /// <summary>基穝
        /// 基穝確
        /// </summary>
        /// <param name="prc">確Τ穝挡篶wsg</param>
        public void ApiPriceUpdateBack(ref SPApiPrice prc)
        {
            string prc_info;
            prc_info = "API PriceUpdate: ProdCode=" + prc.ProdCode + ", Bid=" + prc.Bid[0] + ", BQty=" + prc.BidQty[0] + ", Ask=" + prc.Ask[0] + ", AQty=" + prc.AskQty[0];
            if (DllShowTextData != null) DllShowTextData(prc_info);
        }

        /// <summary>产品信息回复
        /// 产品系列与所胡产品信息回复
        /// </summary>
        /// <param name="inst_cnt">产品系列的数量</param>
        /// <param name="prod_cnt">所有产品的数量</param>
        /// <summary>玻珇獺確
        /// 玻珇╰籔┮璊玻珇獺確
        /// </summary>
        /// <param name="inst_cnt">玻珇╰计秖</param>
        /// <param name="prod_cnt">┮Τ玻珇计秖</param>
        /*public void ProductListBack(int inst_cnt, int prod_cnt)
        {
            if (DllShowTextData != null) DllShowTextData("Instrument Count:" + inst_cnt.ToString() + ", All Instrument:" + prod_cnt.ToString());
        }*/
        public void R_SPAPI_LoadInstrumentList()
        {
            int rc;

            rc = SPAPI_LoadInstrumentList();
        }

        public void R_SPAPI_LoadProductInfoList()
        {
            int rc;

            //rc = SPAPI_LoadProductInfoList();
        }

        public void InstrumentListReplyBack(bool is_ready, string ret_msg)
        {
            if (DllShowTextData != null) DllShowTextData("Instrument Ready:"+(is_ready?"ok":"no")+". Ret Msg:"+ret_msg);
        }

        public void ProductListReplyBack(bool is_ready, string ret_msg)
        {
            if (DllShowTextData != null) DllShowTextData("Product Ready:" + (is_ready ? "ok" : "no") + ". Ret Msg:" + ret_msg);
        }

        /// <summary>查询所有产品系列与数量
        /// 查询所有产品系列与数量
        /// </summary>
        /// <summary>琩高┮Τ玻珇╰籔计秖
        /// 琩高┮Τ玻珇╰籔计秖
        /// </summary>
        public void R_SPAPI_GetInstrumentAndCount()
        {
            int i, rc, count;
            string inst_info;
            SPApiInstrument inst = new SPApiInstrument();

            count = SPAPI_GetInstrumentCount();
            for (i = 0; i < count; i++)
            {
                rc = SPAPI_GetInstrument(i, ref inst);
                if (rc == 0)
                {
                    inst_info = "Instrument Code:" + inst.InstCode + ",Instrument Name:" + inst.InstName2 + ",Instrument Ccy:" + inst.Ccy;
                    if (DllShowTextData != null) DllShowTextData("[ID: " + (i+1).ToString() + "] " + inst_info);
                    inst_info = "";
                }
            }
            if (DllShowTextData != null) DllShowTextData("Instrument Count: " + count.ToString());
        }

        /// <summary>查询指定产品系列
        /// 查询指定产品系列
        /// </summary>
        /// <param name="inst_code">要查询的系列代码</param>
        /// <summary>琩高﹚玻珇╰
        /// 琩高﹚玻珇╰
        /// </summary>
        /// <param name="inst_code">璶琩高╰絏</param>
        public void R_SPAPI_GetInstrumentByCode(string inst_code)
        {
            int rc;
            SPApiInstrument inst = new SPApiInstrument();

            rc = SPAPI_GetInstrumentByCode(inst_code, ref inst);
            if (rc == 0)
            {
                if (DllShowTextData != null) DllShowTextData("Product Code:" + inst.InstCode + ",Product Name:" + inst.InstName2 + ",Product Ccy:" + inst.Ccy);
            }
            else
                if (DllShowTextData != null) DllShowTextData("No : " + inst_code + " Product.");

        }

        /// <summary>查询所有产品信息与数量
        /// 查询所有产品信息与数量
        /// </summary>
        /// <summary>琩高┮Τ玻珇獺籔计秖
        /// 琩高┮Τ玻珇獺籔计秖
        /// </summary>
        public void R_SPAPI_GetProductAndCount()
        {
            int i, rc, count;
            string prod_info;
            SPApiProduct prod = new SPApiProduct();

            count = SPAPI_GetProductCount();
            for (i = 0; i < count; i++)
            {
                rc = SPAPI_GetProduct(i, ref prod);
                if (rc == 0)
                {
                    string expdate = unixTimeToStandTime(prod.ExpiryDate, 2);
                    prod_info = "Instrument:" + prod.InstCode + ",Product Code:" + prod.ProdCode + ",Product Name:" + prod.ProdName2 + ",Product Date:" + expdate;
                    if (DllShowTextData != null) DllShowTextData("[ID: " + (i + 1).ToString() + "] " + prod_info);
                    prod_info = "";
                }
            }
            if (DllShowTextData != null) DllShowTextData("Product Count: " + count.ToString());
        }

        /// <summary> 查询指定产品信息
        /// 查询指定产品信息
        /// </summary>
        /// <param name="prod_code">要查询的合约代码</param>
        /// <summary> 琩高﹚玻珇獺
        /// 琩高﹚玻珇獺
        /// </summary>
        /// <param name="prod_code">璶琩高絏</param>
        public void R_SPAPI_GetProductByCode(string prod_code)
        {
            int rc;
            SPApiProduct prod = new SPApiProduct();

            rc = SPAPI_GetProductByCode(prod_code, ref prod);
            if (rc == 0)
            {
                string expdate = unixTimeToStandTime(prod.ExpiryDate, 2);
                if (DllShowTextData != null) DllShowTextData("Instrument:" + prod.InstCode + ",Product Code:" + prod.ProdCode + ",Product Name:" + prod.ProdName2 + ",Product Date:" + expdate);
            }
            else
                if (DllShowTextData != null) DllShowTextData("No:" +prod_code);
        }

        /// <summary>订阅的合约数量
        /// 订阅的合约数量
        /// </summary>
        /// <summary>璹綷计秖
        /// 璹綷计秖
        /// </summary>
        public void R_SPAPI_GetPriceCount()
        {
            int count;
            string prc_info;

            count = SPAPI_GetPriceCount();
            prc_info = "User Id:" + Spcommon.acc_no + "  Sub Price Count:" + count.ToString();
            if (DllShowTextData != null) DllShowTextData(prc_info);
        }

        /// <summary>获取所有合约
        /// 获取所有合约
        /// </summary>
        /// <summary>莉┮Τ
        /// 莉┮Τ
        /// </summary>
        public void R_SPAPI_GetPrice()
        {
            int i, rc, count;
            string prc_info;
            SPApiPrice prc = new SPApiPrice();

            count = SPAPI_GetPriceCount();  //取合约数量
            if (count == 0) if (DllShowTextData != null) DllShowTextData("No Price!");
            for (i = 0; i < count; i++)
            {
                rc = SPAPI_GetPrice(i, ref prc);    //从开始取所有合约
                if (rc == 0)
                {
                    prc_info = "Product:"+(i+1).ToString() +", Product Code:" + prc.ProdCode;
                    if (DllShowTextData != null) DllShowTextData(prc_info); 
                    prc_info = "";
                }
                else
                    if (DllShowTextData != null) DllShowTextData("Product:" + (i + 1).ToString() + ", Read Failure!:"); 
            }
        }

        /// <summary>查询指定合约
        /// 根据给出的合约名查询指定合约
        /// </summary>
        /// <param name="prod_code">合约名</param>
        /// <summary>琩高﹚
        /// 沮倒琩高﹚
        /// </summary>
        /// <param name="prod_code"></param>
        public void R_SPAPI_GetPriceByCode(string prod_code)
        {
            int rc;
            string prc_info;
            SPApiPrice prc = new SPApiPrice();

            rc = SPAPI_GetPriceByCode(prod_code, ref prc);
            if (rc == 0)
            {
                prc_info = "Product Update: ProdCode=" + prc.ProdCode + ", Bid=" + prc.Bid[0] + ", BQty=" + prc.BidQty[0] + ", Ask=" + prc.Ask[0] + ", AQty=" + prc.AskQty[0];
                if (DllShowTextData != null) DllShowTextData(prc_info);
            }
            else
                if (DllShowTextData != null) DllShowTextData("No: " + prod_code);       
        }

        /// <summary>市场成交回复
        /// 市场成交回复
        /// </summary>
        /// <param name="ticker">ticker 市场成交记录回复</param>
        /// <summary>カ初Θユ確
        /// カ初Θユ確
        /// </summary>
        /// <param name="ticker">ticker カ初Θユ癘魁確</param>
        public void TickerCallBack(ref SPApiTicker ticker)
        {
            string ticker_info;
            string ticker_time;

            //市场成交记录时间为unix时间 转成HH:mm:ss
            DateTime tBase = new DateTime(1970, 1, 1, 8, 0, 0);   
            tBase = tBase.AddSeconds(ticker.TickerTime);
            ticker_time = tBase.ToString("HH:mm:ss");
            ticker_info = "Ticker Code:" + ticker.ProdCode + " Trade Price:" + ticker.Price.ToString() + " Count:" + ticker.Qty.ToString() + " Time:" + ticker_time;
            if (DllShowTextData != null) DllShowTextData(ticker_info);
        }

        public string unixTimeToStandTime(int time, int type)//type:1,年/月/日 时:分:秒. 2,年/月/日. 3,时:分:秒
        {
            DateTime tBase = new DateTime(1970, 1, 1, 8, 0, 0);
            tBase = tBase.AddSeconds(time);
            if (type == 1)
            {
                return tBase.ToString();
            }
            else if (type == 2)
            {
                return tBase.ToString("yyyy/MM/dd");
            }
            else if (type == 3)
            {
                return tBase.ToString("HH:mm:ss");
            }
            return "";
        }

        /// <summary>查询市场成交记录
        /// 根据给出的合约查询市场成交的记录
        /// </summary>
        /// <param name="prod_code">合约</param>
        /// <param name="mode">0: 取消查看成交记录， 1：查看成交记录</param>
        /// <summary>琩高カ初Θユ癘魁
        /// 沮倒琩高カ初Θユ癘魁
        /// </summary>
        /// <param name="prod_code"></param>
        /// <param name="mode">0: 琩Θユ癘魁 1琩Θユ癘魁</param>
        public void R_SPAPI_SubscribeTicker(string prod_code, int mode)
        {
            int rc;

            rc = SPAPI_SubscribeTicker(prod_code, mode);

            if (rc == 0)
            {
                if (DllShowTextData != null) DllShowTextData((mode == 1 ? "Sub Ticker Trade Log: " : "Remove Ticker Trade Log: ") + prod_code + " ...!");
            }
            else
            {
                if (DllShowTextData != null) DllShowTextData((mode == 1 ? "Sub Ticker Trade Log: " : "Remove Ticker Trade Log: ") + prod_code + " Failure!");
            }
        }

        /// <summary>查询现金结余数量
        /// 查询现金结余数量
        /// </summary>
        /// <summary>琩高瞷挡緇计秖
        /// 琩高瞷挡緇计秖
        /// </summary>
        public void R_SPAPI_GetAccBalCount()
        {
            int count;
            string bal_info;

            count = SPAPI_GetAccBalCount();
            bal_info = "User Id:" + Spcommon.acc_no + "  Acc Bal Count:" + count.ToString() + ".";
            if (DllShowTextData != null) DllShowTextData(bal_info);
        }

        /// <summary>查询现金结余
        /// 查询所有的现金结余
        /// </summary>
        /// <summary>琩高瞷挡緇
        /// 琩高┮Τ瞷挡緇
        /// </summary>
        public void R_SPAPI_GetAccBal()
        {
            int i, rc, count;
            string bal_info;
            SPApiAccBal bal = new SPApiAccBal();

            count = SPAPI_GetAccBalCount();
            if (count == 0) if (DllShowTextData != null) DllShowTextData("No Bal!");
            for (i = 0; i < count; i++)
            {
                rc = SPAPI_GetAccBal(i, ref bal);    
                if (rc == 0)
                {
                    bal_info = "Bal:" + (i + 1).ToString() + ", Ccy:" + bal.Ccy + ", CashBf:" + bal.CashBf + ", TodayCash:" + bal.TodayCash;
                    if (DllShowTextData != null) DllShowTextData(bal_info);
                    bal_info = "";
                }
                else
                    if (DllShowTextData != null) DllShowTextData("Bal:" + (i + 1).ToString() + ", Read Failure!");
            }
        }

        /// <summary>查询指定货币的现金结余
        /// 查询指定货币的现金结余信息
        /// </summary>
        /// <param name="ccy">货币类型</param>
        /// <summary>琩高﹚砯刽瞷挡緇
        /// 琩高﹚砯刽瞷挡緇獺
        /// </summary>
        /// <param name="ccy">砯刽摸</param>
        public void R_SPAPI_GetAccBalByCurrency(string ccy)
        {
            int rc;
            string bal_info;
            SPApiAccBal bal = new SPApiAccBal();

            rc = SPAPI_GetAccBalByCurrency(ccy, ref bal);
            if (rc == 0)
            {
                bal_info = "Ccy:" + bal.Ccy + ", CashBf:" + bal.CashBf + ", TodayCash:" + bal.TodayCash;
                if (DllShowTextData != null) DllShowTextData(bal_info);
            }
            else
                if (DllShowTextData != null) DllShowTextData("No Acc Bal By Currency!");
        }

        /// <summary>查询DLL信息
        /// 查询DLL的更新版本与时间
        /// </summary>
        /// <summary>琩高DLL獺
        /// 琩高DLL穝セ籔丁
        /// </summary>
        public void R_SPAPI_GetDllVersion()
        {
            int rc;
            StringBuilder rel_no = new StringBuilder("",100);
            StringBuilder suffix = new StringBuilder("",100);
            StringBuilder ver_no = new StringBuilder("",100);

            rc = SPAPI_GetDllVersion(ver_no, rel_no, suffix);
            if (DllShowTextData != null) DllShowTextData("DLL Version: " + ver_no.ToString() + ",Publish Version: " + rel_no.ToString() + ", DLL Date: " + suffix.ToString());
        }

        /// <summary>查询DLL版本号
        /// 查询DLL版本号
        /// </summary>
        public void R_SPAPI_GetDllVersionDouble()
        {
            double vers;

            vers = SPAPI_GetDLLVersion();
           if (DllShowTextData != null) DllShowTextData("DLL Version: " + vers.ToString());
        }

        /// <summary>价格连接状态回复
        /// </summary>
        /// <param name="host_id">连接代码</param>
        /// <param name="con_status">连接的状态</param>
        /// <summary>基硈钡篈確
        /// </summary>
        /// <param name="host_id">硈钡絏</param>
        /// <param name="con_status">硈钡篈</param>
        public void PServerLinkStatusUpdateBack(short host_id, int con_status)
        {
            string host_name = "";
            string msg = "";

            switch (host_id)
            {
                case 80:
                    host_name = "Transaction Link"; break;
                case 83:
                    host_name = "Price Link"; break;
                case 87:
                    host_name = "Long Depth Link"; break;
                case 88:
                    host_name = "Information Link"; break;
            }

            switch (con_status)
            {
                case 0:
                    msg = "Closed";  break;
                case 1:
                    msg = "Connecting"; break;
                case 2:
                    msg = "Connected";  break;
                case 3:
                    msg = "Connect_Error";  break;
                case 4:
                    msg = "Logging_In";  break;
                case 5:
                    msg = "Logged_In";  break;
                case 6:
                    msg = "Logging_Out";  break;
                case 7:
                    msg = "Logged_Out"; break;
                case 8:
                    msg = "Login_Failed";  break;
                case 9:
                    msg = "Connection_Lost";  break;
                case 10:
                    msg = "Closing";  break;
                case 11:
                    msg = "Host_Req";  break;
            }
            if (DllShowTextData != null) DllShowTextData("User Connection Status: " + host_id.ToString()+", "+host_name+", "+msg);
        }

        /// <summary>连接错误回复
        /// </summary>
        /// <param name="host_id">错误的连接代码</param>
        /// <param name="link_err">错误原因代码</param>
        /// <summary>硈钡岿粇確
        /// </summary>
        /// <param name="host_id">岿粇硈钡絏</param>
        /// <param name="link_err">岿粇絏</param>
        public void ConnectionErrorUpdateBack(short host_id, int link_err)
        {
            string host_name = "";
            switch (host_id)
            {
                case 80:
                    host_name = "Transaction Link"; break;
                case 83:
                    host_name = "Price Link"; break;
                case 87:
                    host_name = "Long Depth Link"; break;
                case 88:
                    host_name = "Information Link"; break;
            }
            if (DllShowTextData != null) DllShowTextData("Cannot Connect  To The Server: Error Code: " +host_id.ToString()+","+ host_name + "," + link_err.ToString());
        }

        /// <summary>查询指定连接的状态
        /// </summary>
        /// <param name="host_id">要查找的连接代码</param>
        ///  <summary>琩高﹚硈钡篈
        /// </summary>
        /// <param name="host_id">璶琩т硈钡絏</param>
        public void GetLoginStatus(short host_id)
        {
            int rc;
            string msg = "";

            rc = SPAPI_GetLoginStatus(host_id);  // 返回连接的当前状态代码
            switch (rc)
            {
                case 0:
                    msg = "Closed"; break;
                case 1:
                    msg = "Connecting"; break;
                case 2:
                    msg = "Connected"; break;
                case 3:
                    msg = "Connect_Error"; break;
                case 4:
                    msg = "Logging_In"; break;
                case 5:
                    msg = "Logged_In"; break;
                case 6:
                    msg = "Logging_Out"; break;
                case 7:
                    msg = "Logged_Out"; break;
                case 8:
                    msg = "Login_Failed"; break;
                case 9:
                    msg = "Connection_Lost"; break;
                case 10:
                    msg = "Closing"; break;
                case 11:
                    msg = "Host_Req"; break;
            }

            if (DllShowTextData != null) DllShowTextData("User Connection Status: " + rc.ToString() + ", msg:" + msg);
       

        }

        /// <summary>设置订单有效与无效
        /// </summary>
        /// <param name="order_id">要设置的订编号</param>
        /// <param name="inactive">false:将订单设置为有效，true:将订单设置成无效订单</param>
        /// <summary>砞竚璹虫Τ籔礚
        /// </summary>
        /// <param name="order_id">璶砞竚璹絪腹</param>
        /// <param name="inactive">false:盢璹虫砞竚Τtrue:盢璹虫砞竚Θ礚璹虫</param>
        public void SetOrderInactive(string order_id, bool inactive)
        {
            int rc, oc;
            SPApiOrder order = new SPApiOrder();
            string acc;

            if (Spcommon.S_Prot == 8081) acc = Spcommon.ord_acc_no;
            else acc = Spcommon.acc_no;
            int int_order_no = Convert.ToInt32(order_id);
            oc = SPAPI_GetOrderByOrderNo(acc, int_order_no, ref order);
            if (oc != 0) 
            {
                if (DllShowTextData != null) DllShowTextData("No Order");
                return;
            }
            if (inactive)
                rc = SPAPI_InactivateOrder(ref order);
            else
                rc = SPAPI_ActivateOrder(ref order);

            if (rc == 0) { if (DllShowTextData != null) DllShowTextData("Change Order ....!"); }
            else { if (DllShowTextData != null) DllShowTextData("Change Order Failure! " + rc.ToString()); }

        }

        public void RegisterShowTextEvent(ShowTextData e_showtext)
        {
            DllShowTextData += new ShowTextData(e_showtext);
        }

        /// <summary>根据请求类型与订单状态加载订单回调方法
        /// 加载订单信息
        /// </summary>
        /// <param name="req_type">请求加载订单的类型</param>
        /// <param name="status_mode">请求加载订单的状态</param>
        /// <summary>
        /// 沮叫―摸籔璹虫篈更璹虫秸よ猭
        /// </summary>
        /// <param name="req_type">叫―更璹虫摸</param>
        /// <param name="status_mode">叫―更璹虫篈</param>
        public void R_SPAPI_LoadOrderReport()
        {
            int rc;

            rc = SPAPI_LoadOrderReport(Spcommon.acc_no);
            //if (rc < 0)
                if (DllShowTextData != null) DllShowTextData("Load Order Report Reply:"+rc.ToString());

        }

        /// <summary>根据请求类型加载成交回调方法
        /// 请求加载成交记录信息
        /// </summary>
        /// <param name="req_type">成交记录的类型</param>
        public void R_SPAPI_LoadTradeReport()
        { 
            int rc;

            rc = SPAPI_LoadTradeReport(Spcommon.acc_no);
            //if (rc < 0)
                if (DllShowTextData != null) DllShowTextData("Load Trade Report Reply:" + rc.ToString());
        }

        public void PswChangeReplyBack(int ret_code, string ret_msg)
        {
            if (ret_code == 0)
            { if (DllShowTextData != null) DllShowTextData("User Change PassWord Succeed:"); }
            else
            { if (DllShowTextData != null) DllShowTextData("User Change PassWord: code:" + ret_code.ToString() + " msg:" + ret_msg); }
        }

        public void R_SPAPI_ChangePassword(string old_psw, string new_psw)
        {
            int rc;

            rc = SPAPI_ChangePassword(old_psw, new_psw);
            if (rc != 0)
                if (DllShowTextData != null) DllShowTextData("Change Password Reply:" + rc.ToString());
        }

        public void R_SPAPI_LoadProductInfoListByCode(string product)
        {
            int rc;

            rc = SPAPI_LoadProductInfoListByCode(product);
            if (DllShowTextData != null) DllShowTextData("Load Product Info List By Code Reply:" + rc.ToString());
        }

        public void ProductInfoListByCodeReplyBack(string inst_code, bool is_ready, string ret_msg)
        {
            if (DllShowTextData != null) DllShowTextData("Product Ready:" + (is_ready ? "ok" : "no") + ". Ret Msg:" + ret_msg + ". Inst Code:"+inst_code);
        }

        public void R_SPAPI_AccountLogin(string acc_no)
        {
            int rc;

            rc = SPAPI_AccountLogin(acc_no);
            if (DllShowTextData != null) DllShowTextData("[" + acc_no + "]Account Login Report Reply:" + rc.ToString());
            
        }

        public void R_SPAPI_AccountLogout()
        {
            int rc;

            rc = SPAPI_AccountLogout(Spcommon.acc_no);
            if (DllShowTextData != null) DllShowTextData("[" + Spcommon.acc_no + "]Account Logout Report Reply:" + rc.ToString());
            if (rc == 0) Spcommon.acc_no = "";
        }
    }
}
