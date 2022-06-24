using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Convertation
{
    public static class Convertation
    {
        private static Dictionary<string, long> numberTable = new Dictionary<string, long>{
        {"zero",0},{"one",1},{"two",2},{"three",3},{"four",4},{"five",5},{"six",6}, {"seven",7},{"eight",8},{"nine",9},
        {"ten",10},{"eleven",11},{"twelve",12}, {"thirteen",13},{"fourteen",14},{"fifteen",15},{"sixteen",16},{"seventeen",17}, {"eighteen",18},{"nineteen",19},
        {"twenty",20},{"thirty",30},{"forty",40}, {"fifty",50},{"sixty",60},{"seventy",70},{"eighty",80},{"ninety",90},
        {"hundred",100},
        {"thousand",1000}, {"million",1000000}, {"billion",1000000000},{"trillion",1000000000000}};

        public static long ConvertToNumber(string numberString)
        {
            var numbers = Regex.Matches(numberString, @"\w+").Cast<Match>()
                    .Select(m => m.Value.ToLowerInvariant())
                    .Where(v => numberTable.ContainsKey(v))
                    .Select(v => numberTable[v]);
            long acc = 0, total = 0L;
            foreach (var n in numbers)
            {
                if (n >= 1000)
                {
                    total += acc * n;
                    acc = 0;
                }
                else if (n >= 100)
                {
                    acc *= n;
                }
                else acc += n;
            }
            return (total + acc) * (numberString.StartsWith("minus",
                    StringComparison.InvariantCultureIgnoreCase) ? -1 : 1);
        }
        
        public static object ConvertToUnspecifiedValue(string value)
        {
            if (char.IsDigit(value[0]) || value[0] == '-')
            {
                return double.Parse(value.Replace('.',','));
            }
            if (value[0] == '[')
            {
                return ConvertToMatrix(value);
            }
            if (value[0] == '<')
            {
                return ConvertToFunction(value);
            }
            if (Regex.Matches(value, @"\w+").Cast<Match>().Any()) return ConvertToNumber(value);

            throw new ArgumentException($"unexpected value {value}");
        }

        public static double ConvertToNumber(object numberObject)
        {
            switch (numberObject.GetType().Name)
            {
                case "Byte":    return (byte)numberObject;
                case "SByte":   return (sbyte)numberObject;
                case "UInt16":  return (ushort)numberObject;
                case "UInt32":  return (uint)numberObject;
                case "UInt64":  return (ulong)numberObject;
                case "Int16":   return (short)numberObject;
                case "Int32":   return (int)numberObject;
                case "Int64":   return (long)numberObject;
                case "Single":  return (float)numberObject;
                case "Double":  return (double)numberObject;
                case "Decimal": return (double)((decimal)numberObject);
                case "String":  return ConvertToNumber(numberObject.ToString());
                default: throw new NotImplementedException();
            }
        }

        public static bool ConvertToBool(string boolString)
        {
            return bool.Parse(boolString);
        }

        public static bool ConvertToBool(object boolObject)
        {
            return ConvertToBool(boolObject.ToString());
        }


        public static double[,] ConvertToMatrix(object matrixObject)
        {
            // TO DO
            throw new NotImplementedException();
        }

        public static double[,] ConvertToMatrix(string matrixString)
        {
            // [[344.25,45][12,17][18,12]]
            matrixString = Regex.Replace(matrixString,@"\s+","");

            double[,] result;

            int x = matrixString.Count(ch => ch == '[') - 1;
            int y = (matrixString.Count(ch => ch == ',') / x) + 1; // в матрице каждый столбец одинаковой длины поэтому узнать их количество можно по количеству запятых

            result = new double[x, y];
            int n = 2; // первые 2 символа это открывающиеся квадратные скобки
            try
            {
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y - 1; j++)
                    {
                        int length = matrixString.IndexOf(',', n) - n;
                        double val = double.Parse(matrixString.Substring(n, length));
                        result[i, j] = val;
                        n += length + 1; // пропускаем число и запятую
                    }

                    {
                        int lengthLast = matrixString.IndexOf(']', n) - n;
                        double val = double.Parse(matrixString.Substring(n, lengthLast));
                        result[i, y - 1] = val;
                        n += lengthLast + 2; // пропускаем число и две скобки
                    }

                }
                return result;
            }
            catch (Exception)
            {
                throw new Exception($"incorrect format of matrix : {matrixString}");
            }
        }

        public static Func<double,double> ConvertToFunction(object functionObject) 
        {
            // TO DO
            throw new NotImplementedException();
        }

        public static Func<double, double> ConvertToFunction(string functionString)
        {
            // TO DO
            throw new NotImplementedException();
        }

        public static string UndentifiedToString(object val)
        {
            if (val == null) return null;
            switch (val.GetType().Name)
            {
                case "Double[,]": return MatrixToString(val);
                case "Func`2": return FunctionToString(val);
                default: return val.ToString();
            }
        }

        public static string MatrixToString(object valObj)
        {
            string result = "[";
            double[,] value = (double[,])valObj;
            int x = value.GetLength(0);
            int y = value.GetLength(1);
            for (int i = 0; i < x; i++)
            {
                result += "[";

                for (int j = 0; j < y - 1; j++)
                {
                    result += value[i,j];
                    result += ",";
                }

                result += value[i, y - 1];
                result += "]";
            }
            result += "]";
            return result;
        }

        public static string FunctionToString(object val)
        {
            throw new NotImplementedException();
        }
    }
}
