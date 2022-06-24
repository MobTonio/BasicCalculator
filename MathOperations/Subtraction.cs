using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    internal class Subtraction : PrimitiveMathOperation
    {
        public override string Name => _name;
        private static string _name = "Subtraction";

        public override double Execute(double numberA, double numberB)
        {
            return numberA - numberB;
        }
    }
}
