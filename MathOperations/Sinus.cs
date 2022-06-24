using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    //Max(-23 * Min(-12 + 7, 7 - 4) + 100, 2*-5 +5, -2)
    //5!
    internal class Sinus : SingularMathOperation
    {
        public override string Name => _name;
        private static string _name = "Sin";
        public override object Execute(object obj)
        {
            return Math.Sin((double)obj);
        }
    }
}
