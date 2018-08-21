using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spapiApp
{
    class SAR
    {
        public List<Double> getSARLineDatas(List<HSIFutures> list, float step, float maxStep)
        {
            List<Double> sarList = new List<Double>();

            //记录没有没有初始化过
            double INIT_VALUE = -100;
            //加速因子
            double af = 0;                  //加速因子
                                            //极值
            double ep = INIT_VALUE;         //极点价
                                            //判断是上涨还是下跌  false：下跌
            bool lasttrend = false;
            double SAR = 0;

            for (int i = 0; i < list.Count() - 1; i++)
            {
                //上一个周期的sar
                double priorSAR = SAR;
                HSIFutures item = list[i];
                if (lasttrend)
                {
                    //上涨
                    if (ep == INIT_VALUE || ep < item.GetHigh())
                    {
                        //重新初始化值
                        ep = item.GetHigh();                //当这个周期为上涨，前一个周期的 ep为 最高价
                        af = Math.Min(af + step, maxStep);  //af
                    }
                    SAR = priorSAR + af * (ep - priorSAR);  //这以周期的的SAR值
                    double lowestPrior2Lows = Math.Min(list[Math.Max(1, i) - 1].GetLow(), list[i].GetLow());
                    if (SAR > list[i + 1].GetLow())
                    {
                        SAR = ep;
                        //重新初始化值
                        af = 0;
                        ep = INIT_VALUE;
                        lasttrend = !lasttrend;

                    }
                    else if (SAR > lowestPrior2Lows)
                    {
                        SAR = lowestPrior2Lows;
                    }
                }
                else
                {
                    if (ep == INIT_VALUE || ep > list[i].GetLow())
                    {
                        //重新初始化值
                        ep = list[i].GetLow();
                        af = Math.Min(af + step, maxStep);
                    }
                    SAR = priorSAR + af * (ep - priorSAR);
                    double highestPrior2Highs = Math.Max(list[Math.Max(1, i) - 1].GetHigh(), list[i].GetHigh());
                    if (SAR < list[i + 1].GetHigh())
                    {
                        SAR = ep;
                        //重新初始化值
                        af = 0;
                        ep = INIT_VALUE;
                        lasttrend = !lasttrend;

                    }
                    else if (SAR < highestPrior2Highs)
                    {
                        SAR = highestPrior2Highs;
                    }
                }
                sarList.Add(SAR);
            }
            //确保和 传入的list size一致，
            int size = list.Count() - sarList.Count();
            for (int i = 0; i < size; i++)
            {
                sarList.Insert(0, sarList[i]);
            }

            //返回了一个包含所有SAR值的数组
            return sarList;
            
        }
        }
}

