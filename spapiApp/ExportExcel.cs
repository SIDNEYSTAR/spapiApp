using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using spapiApp.Properties;
using System.Web;
using System.Collections;
using System.Windows.Forms;
using System.Diagnostics;
using ExcelUtility.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Odbc;

namespace spapiApp
{
    class ExportExcel
    {
        public void ExportToExcelWithTemplateByList()
        {
            List<Student> studentList = GetStudentList();//获取数据
            string templateFilePath = AppDomain.CurrentDomain.BaseDirectory + "/cc2.xlt"; //获得EXCEL模板路径
            SheetFormatterContainer formatterContainers = new SheetFormatterContainer(); //实例化一个模板数据格式化容器

            PartFormatterBuilder partFormatterBuilder = new PartFormatterBuilder();//实例化一个局部元素格式化器
            partFormatterBuilder.AddFormatter("Title", "股票数据");//将模板表格中Title的值设置为股票数据
            formatterContainers.AppendFormatterBuilder(partFormatterBuilder);//添加到工作薄格式容器中，注意只有添加进去了才会生效

            CellFormatterBuilder cellFormatterBuilder = new CellFormatterBuilder();//实例化一个单元格格式化器
            cellFormatterBuilder.AddFormatter("rptdate", "GUDCUB");//将模板表格中rptdate的值设置为GUDCUB
            formatterContainers.AppendFormatterBuilder(cellFormatterBuilder);//添加到工作薄格式容器中，注意只有添加进去了才会生效

            //实例化一个表格格式化器，studentList本身就是可枚举的无需转换，name表示的模板表格中第一行第一个单元格要填充的数据参数名
            TableFormatterBuilder<Student> tableFormatterBuilder = new TableFormatterBuilder<Student>(studentList, "date");
            tableFormatterBuilder.AddFormatters(new Dictionary<string, Func<Student, object>>{
                {"date",r=>r.Date.ToString()},//将模板表格中date对应Student对象中的属性Name
                {"open",r=>r.Open},//将模板表格中open对应Student对象中的属性Sex
                {"high",r=>r.High},//将模板表格中high对应Student对象中的属性KM
                {"low",r=>r.Low},//将模板表格中low对应Student对象中的属性Score
                {"close",r=>r.Close}//将模板表格中close对应Student对象中的属性Result
            });
            formatterContainers.AppendFormatterBuilder(tableFormatterBuilder);

            string excelPath = ExcelUtility.Export.ToExcelWithTemplate(templateFilePath, "table", formatterContainers);
            Assert.IsTrue(File.Exists(excelPath));

        }

        class Student
        {
            public DateTime Date { get; set; }

            public double Open { get; set; }

            public double High { get; set; }

            public double Low { get; set; }

            public double Close { get; set; }
        }



        private List<Student> GetStudentList()
        {
            //买卖信号版本内容
            int number = 0;
            List<HSIFutures> buy = new List<HSIFutures>();                    //买信号数组
            List<HSIFutures> sell = new List<HSIFutures>();                   //卖信号数组
            SAR sar = new SAR();
            List<double> sarList = new List<double>();          //sar值数组


            //历史数据版本内容
            List<HSIFutures> dataList = new List<HSIFutures>(); //历史数据数组
            string connStr = "Driver= {MySQL ODBC 3.51 Driver};Server=127.0.0.1;Database=realtimedata;User=root; Password=root; Option=3;";
            OdbcConnection myConnection = new OdbcConnection(connStr);  //创建数据库连接
            string sql = "SELECT * FROM hsiindh_1min t  ORDER BY id DESC LIMIT 200";
            OdbcCommand myCommand = new OdbcCommand(sql, myConnection);  //创建sql和连接实例化的对象
            myConnection.Open();
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



            //买卖信号版本内容
        //    List<HSIFutures> positiveData = new List<HSIFutures>(); //排序后的数组
        //    for (int i = dataList.Count - 1; i >= 0; i--)  //此方法为排序方法
        //    {
        //        positiveData.Add(dataList[i]);
        //    }
        //    sarList = sar.getSARLineDatas(positiveData, float.Parse("0.02"), float.Parse("0.2"));    //获取SAR的值

        //for (int i = 1; i < positiveData.Count(); i++)
        //{
        //        if (positiveData[i - 1].GetClose() <= sarList[i - 1])
        //        {
        //            if (positiveData[i].GetClose() > sarList[i] && number % 2 == 0)
        //            {
        //                HSIFutures hSIFutures = new HSIFutures();
        //            hSIFutures.SetSymbol(positiveData[i].GetSymbol());
        //            hSIFutures.SetDate(positiveData[i].GetDate());
        //            hSIFutures.SetOpen(positiveData[i].GetOpen());
        //            hSIFutures.SetHigh(positiveData[i].GetHigh());
        //            hSIFutures.SetLow(positiveData[i].GetLow());
        //            hSIFutures.SetClose(positiveData[i].GetClose());
        //            buy.Add(hSIFutures);
        //            number++;
        //        }
        //    }
        //        if (positiveData[i - 1].GetClose() >= sarList[i - 1])
        //        {
        //            if (positiveData[i].GetClose() < sarList[i] && number % 2 != 0)
        //            {
        //               HSIFutures hSIFutures = new HSIFutures();
        //            hSIFutures.SetSymbol(positiveData[i].GetSymbol());
        //            hSIFutures.SetDate(positiveData[i].GetDate());
        //            hSIFutures.SetOpen(positiveData[i].GetOpen());
        //            hSIFutures.SetHigh(positiveData[i].GetHigh());
        //            hSIFutures.SetLow(positiveData[i].GetLow());
        //            hSIFutures.SetClose(positiveData[i].GetClose());
        //            sell.Add(hSIFutures);
        //            number++;
        //        }
        //    }
        // }

            List<Student> studentList = new List<Student>();

            //历史数据版本内容
            for (int i = 0; i < dataList.Count; i++)
            {
                studentList.Add(new Student
                {
                    Date = dataList[i].GetDate(),
                    Open = dataList[i].GetOpen(),
                    High = dataList[i].GetHigh(),
                    Low = dataList[i].GetLow(),
                    Close = dataList[i].GetClose()
                });
            }


            //买卖信号版本内容
            //for (int i = 0; i < sell.Count; i++)
            //{
            //    studentList.Add(new Student
            //    {
            //        Date = buy[i].GetDate(),
            //        Open = buy[i].GetOpen(),
            //        High = buy[i].GetHigh(),
            //        Low = buy[i].GetLow(),
            //        Close = buy[i].GetClose()
            //    });

            //    studentList.Add(new Student
            //    {
            //        Date = sell[i].GetDate(),
            //        Open = sell[i].GetOpen(),
            //        High = sell[i].GetHigh(),
            //        Low = sell[i].GetLow(),
            //        Close = sell[i].GetClose()
            //    });

            //}
            return studentList;
        }
    }
}
