using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    internal class Cosinus : SingularMathOperation
    {
        public override string Name => _name;
        private static string _name = "Cos";
        public override object Execute(object obj)
        {
            return Math.Cos((double)obj);
        }
    }
}
