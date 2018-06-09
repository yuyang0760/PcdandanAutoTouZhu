using DXAppXingyun28.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yy.util
{
    class Util
    {
        /// <summary>
        /// pc28赔率,投注,概率
        /// </summary>
        /// <returns></returns>
        public static List<Odds> GetOdds()
        {
            List<Odds> re = new List<Odds>();
            double[] oddds = new double[28] { 1000, 333.33, 166.67, 100, 66.67, 47.62, 35.71, 27.78, 22.22, 18.18, 15.87, 14.49, 13.7, 13.33, 13.33, 13.7, 14.49, 15.87, 18.18, 22.22, 27.78, 35.71, 47.62, 66.67, 100, 166.67, 333.33, 1000 };
            for (int i = 0; i <= 27; i++)
            {
                Odds odds = new Odds();
                odds.opencode = i;
                odds.odds = oddds[i];
                odds.probability = Math.Round(1000 / oddds[i] / 1000, 4);
                odds.touzhu = int.Parse(Math.Floor(odds.probability * 10000).ToString());
                re.Add(odds);
            }
            return re;
        }

        /// <summary>
        /// 梭哈 根据投注数量和投注号码,计算各个蛋蛋投注数量
        /// </summary>
        /// <param name="dandan">蛋蛋数量 如 1111</param>
        /// <param name="touzhuCode">投注号码,如10,11,12,13</param>
        /// <returns></returns>
        public double[] _计算投注数量(int dandan, List<int> touzhuCode)
        {
            double[] re = new double[28];
            List<Odds> oddsList = GetOdds();
            double sum = 0;
            for (int i = 0; i < touzhuCode.Count; i++)
            {
                sum += oddsList[touzhuCode[i]].touzhu;
            }
            double meiyixiang = dandan / sum;

            for (int i = 0; i < touzhuCode.Count; i++)
            {
                re[touzhuCode[i]] = Math.Floor(meiyixiang * oddsList[touzhuCode[i]].touzhu);
            }

            return re;
        }

 
    }
}
