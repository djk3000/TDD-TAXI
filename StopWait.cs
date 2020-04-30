using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiTest
{
    public class StopWait
    {
        public string StopWaitFee(string time)
        {
            var num = Convert.ToInt32(FileStringAnalysis.AnalysisNum(time));
            var value = Convert.ToInt32(num) * 0.25;
            return value.ToString("0.00");
        }
    }
}
