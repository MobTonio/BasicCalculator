using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    internal class Factorial : SingularMathOperation
    {
        public override string Name => _name;
        private static string _name = "Factorial";

        public override object Execute(object number)
        {
            double result = 1;
            if ((double)number != Math.Round((double)number)) throw new ArgumentException($"Unacceptable fractal value - {(double)number}!");
            for (int i = 1; i <= (double)number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
