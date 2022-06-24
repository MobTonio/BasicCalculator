using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    public class Addition : PrimitiveMathOperation
    {
        public override string Name => _name;
        private static string _name = "Addition";

        public override double Execute(double numberA, double numberB)
        {
            return numberA + numberB;
        }
    }
}
