using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spapiApp
{
    class HSIFuturesEa : HSIFutures
    {
        private String eaName;                  //ea公式的名称
        private double eaValue;                 //对应ea的值
        private DateTime buySellTime;           //对应的买卖信号时间
        private Object[] eaParams;              //对应ea需要的参数
        private int status;                     //买卖状态码 1:买  2:卖

        public int GetStatus()
        {
            return status;
        }

        public void SetStatus(int status)
        {
            this.status = status;
        }

        public Object[] GetParams()
        {
            return eaParams;
        }

        public void SetParams(Object[] eaParams)
        {
            this.eaParams = eaParams;
        }

        public String GetEaName()
        {
            return eaName;
        }

        public void SetEaName(String eaName)
        {
            this.eaName = eaName;
        }

        public double GetEaValue()
        {
            return eaValue;
        }

        public void SetEaValue(double eaValue)
        {
            this.eaValue = eaValue;
        }

        public DateTime GetBuySellTime()
        {
            return buySellTime;
        }

        public void SetBuySellTime(DateTime buySellTime)
        {
            this.buySellTime = buySellTime;
        }

    }
}

