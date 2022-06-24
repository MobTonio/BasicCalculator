using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    internal class Maximum : PrimitiveMathOperation
    {
        public override string Name => _name;
        private static string _name = "Max";

        public override double Execute(double numberA, double numberB)
        {
            return numberA > numberB ? numberA : numberB;
        }
    }
}
