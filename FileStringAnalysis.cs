using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TaxiTest
{
    public static class FileStringAnalysis
    {
        public static string[] ReadTestFile()
        {
            var path = string.Format("{0}" + "\\textData.txt", Environment.CurrentDirectory);
            var str = File.ReadAllText(path);
            var retValue = str.Split("\\n");
            return retValue;
        }

        public static string SpiltString(string command, int num)
        {
            var str = command.Split(",");
            if (str != null)
            {
                return str[num];
            }
            else
            {
                return null;
            }
        }

        public static string AnalysisNum(string str)
        {
            var result = System.Text.RegularExpressions.Regex.Replace(str, @"[^0-9]+", "");
            return result;
        }
    }
}
