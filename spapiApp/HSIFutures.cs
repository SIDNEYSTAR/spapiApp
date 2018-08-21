using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spapiApp
{
    public class HSIFutures
    {
        private String symbol;          //期货名字
        private DateTime date ;          //交易时间
        private double open;			//开盘价格
        private double high;			//最高价格
        private double low;				//最低价格
        private double close;			//关盘价格
        private long createdate;        //毫秒

        public long GetCreatedate()
        {
            return createdate;
        }
        public void SetCreatedate(long createdate)
        {
            this.createdate = createdate;
        }

        public String GetSymbol()
        {
            return symbol;
        }
        public void SetSymbol(String symbol)
        {
            this.symbol = symbol;
        }
        public DateTime GetDate()
        {
            return date;
        }
        public void SetDate(DateTime date)
        {
            this.date = date;
        }
        public double GetOpen()
        {
            return open;
        }
        public void SetOpen(double open)
        {
            this.open = open;
        }
        public double GetHigh()
        {
            return high;
        }
        public void SetHigh(double high)
        {
            this.high = high;
        }
        public double GetLow()
        {
            return low;
        }
        public void SetLow(double low)
        {
            this.low = low;
        }
        public double GetClose()
        {
            return close;
        }
        public void SetClose(double close)
        {
            this.close = close;
        }
    }
}
