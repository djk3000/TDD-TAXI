using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiTest
{
    public class Kilometretoll
    {
        public string KMtoll(string km)
        {
            var num = Convert.ToInt32(FileStringAnalysis.AnalysisNum(km));
            var result = num - 2 < 0 ? 6 : ((6 + ((num - 8) < 0 ? (num - 2) * 0.8 : 6 * 0.8 + (num - 8) * 1.2)));
            return result.ToString("0.0");
        }
    }
}
