using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiTest
{
    public class TotalFee
    {
        public string GetTotalValue()
        {
            Kilometretoll kmtoll = new Kilometretoll();
            StopWait sw = new StopWait();
            string retValue = "";
            foreach (var each in FileStringAnalysis.ReadTestFile())
            {
                var km = FileStringAnalysis.SpiltString(each, 0);
                var time = FileStringAnalysis.SpiltString(each, 1);
                var total = Round(Convert.ToDouble(kmtoll.KMtoll(km)) + Convert.ToDouble(sw.StopWaitFee(time)));
                retValue += string.Format("收费{0}元", total) + "\n";
            }
            retValue = retValue.Substring(0, retValue.Length - 1);
            return retValue;
        }

        public string GetTaxiValue(string command)
        {
            Kilometretoll kmtoll = new Kilometretoll();
            StopWait sw = new StopWait();
            var km = FileStringAnalysis.SpiltString(command, 0);
            var time = FileStringAnalysis.SpiltString(command, 1);
            var total = Round(Convert.ToDouble(kmtoll.KMtoll(km)) + Convert.ToDouble(sw.StopWaitFee(time)));
            var retValue = string.Format("收费{0}元", total);
            return retValue;
        }

        public string Round(double num)
        {
            var round = (int)Math.Round(num, MidpointRounding.AwayFromZero);
            return round.ToString();
        }
    }
}
