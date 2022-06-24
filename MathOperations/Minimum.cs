using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    internal class Minimum : PrimitiveMathOperation
    {
        public override string Name => _name;
        private static string _name = "Min";

        public override double Execute(double numberA, double numberB)
        {
            return numberA > numberB ? numberB : numberA;
        }
    }
}
