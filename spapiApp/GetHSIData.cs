using spapiApp;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace spapiApp
{

        
   

    class GetHSIData
    {
        static List<HSIFutures> listStatic;

        public List<HSIFutures> GetHSIDataList()
        {
            List<HSIFutures> dataList = new List<HSIFutures>();
            try
            {
                //int slowLine = 30;
                string connStr = "Driver= {MySQL ODBC 3.51 Driver};Server=127.0.0.1;Database=realtimedata;User=root; Password=root; Option=3;";
                //string sql = "SELECT * FROM (SELECT * FROM hsiindh_1min t ORDER BY id DESC)realtimedata LIMIT 0," + slowLine;
                //string sql = "SELECT * FROM (SELECT * FROM hsiindh_1min t WHERE '" + startTime + "' <= t.DATE AND t.DATE <= '" + endTime + "'ORDER BY id DESC) tt LIMIT 0," + slowLine;
                //string sql = "SELECT * FROM hsiindh_1min t WHERE '" + startTime + "' <= t.DATE AND t.DATE <= '" + endTime + "'";
                string sql = "SELECT * FROM hsiindh_1min t  ORDER BY id DESC LIMIT 200";

               // string sql = "SELECT * FROM (SELECT * FROM (SELECT * FROM hsiindh_1min t ORDER BY id DESC)realtimedata LIMIT 0,990)realtimedata2 ORDER BY id";
                OdbcConnection myConnection = new OdbcConnection(connStr);  //创建数据库连接
                OdbcCommand myCommand = new OdbcCommand(sql, myConnection);  //创建sql和连接实例化的对象

                myConnection.Open();
                Console.WriteLine(myCommand.ExecuteNonQuery().ToString());
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
            }
            catch (Exception ex)
            {
                Console.WriteLine("数据库连接失败" + " " + ex.Message);
            }
            return dataList;
        }


        public void SARThread()
        {
            GetHSIData getHSIData = new GetHSIData();
            Thread thread = new Thread(new ThreadStart(getHSIData.Run));
            thread.Start();
        }

        public void Run()
        {
            
            try
           {
                string connStr = "Driver= {MySQL ODBC 3.51 Driver};Server=127.0.0.1;Database=realtimedata;User=root; Password=root; Option=3;";
                OdbcConnection myConnection = new OdbcConnection(connStr);  //创建数据库连接
                 
                while (true)
                {   
                    List<HSIFutures> dataList = GetRealTime(myConnection);
                    Thread.Sleep(1000);
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("数据库连接失败" + "或者线程出现问题 " + ex.Message);
               
            }

          
        }


        public List<HSIFutures> GetRealTime(OdbcConnection myConnection)
        {
            List<HSIFutures> dataList = new List<HSIFutures>();
            string sql = "SELECT * FROM hsiindh_1min t  ORDER BY id DESC LIMIT 2";
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
            Console.WriteLine(dataList.Count+ "**********" );
            return dataList;
        }
    }
}
