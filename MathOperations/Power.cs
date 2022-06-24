using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    internal class Power : DualMathOperation
    {
        public override string Name => _name;
        private static string _name = "Power";

        public override object Execute(object objectA, object objectB)
        {
            if (objectB.GetType() == typeof(double)) 
                return Execute((double)objectA, (double)objectB);
            else 
                return Execute((double[,])objectA, (int)objectA);
        }

        public double Execute(double numberA, double numberB)
        {
            return Math.Pow(numberA, numberB);
        }

        public double[,] Execute(double[,] matrix, int number)
        {
            var multiply = new Multiplication();
            double[,] result = matrix;
            for (int i = 1; i < number; i++)
            {
                result = multiply.Execute(result, matrix);
            }
            return result;
        }
    }
}
