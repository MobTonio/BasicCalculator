using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrivitiveDataBase
{
    public static class DBHelper
    {
        private const string filePath = "calculations.db";

        public static string[] ReadExpressions()
        {
            List<string> expressions = new List<string>();

            using (StreamReader sr = File.OpenText(filePath))
            {
                while (sr.Peek() != -1)
                {
                    expressions.Add(sr.ReadLine());
                }
            }

            return expressions.ToArray();
        }

        public static void WriteExpression(string expression, string result)
        {
            using (FileStream fs = File.Open(filePath,FileMode.OpenOrCreate))
            {
                fs.Position = fs.Length;
                AddText(fs, expression + "\n");
                AddText(fs, result + "\n");
            }
        }

        private static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
        //[[3][4][12][4]] * [[34, 1, -2, 9]]
        //[[102,3,-6,27][136,4,-8,36][408,12,-24,108][136,4,-8,36]]
    }
}
