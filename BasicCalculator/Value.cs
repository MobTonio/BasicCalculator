using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Convertation;

namespace BasicCalculator
{
    public abstract class Value<Val>
    {
        public Val value;
        public abstract Val Convert(object obj);
    }

    public class Number : Value<double>
    {
        public override double Convert(object obj)
        {
            return Convertation.Convertation.ConvertToNumber(obj);
        }
    }

    public class Matrix : Value<double[,]>
    {
        public override double[,] Convert(object obj)
        {
            return Convertation.Convertation.ConvertToMatrix(obj);
        }
    }

    public class Logical : Value<bool>
    {
        public override bool Convert(object obj)
        {
            return Convertation.Convertation.ConvertToBool(obj);
        }
    }

    public class Function : Value<Func<double, double>>
    {
        public override Func<double,double> Convert(object obj)
        {
            return Convertation.Convertation.ConvertToFunction(obj);
        }
    }
}
