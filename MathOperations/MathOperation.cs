using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    public interface IMathOperation
    {
        string Name { get; }
        object Execute(List<object> list);
    }

    public static class MathOp
    {
        private static readonly List<IMathOperation> _operations = new List<IMathOperation>() 
            { new Addition(), new Subtraction(), new Multiplication(), new Division(),
            new Maximum(), new Minimum(), new Cosinus(), new Sinus(), new Power(), new Factorial()};
        public static object Execute(string name, List<object> list) => _operations.Find(x => x.Name.Equals(name)).Execute(list);

        public static string[] GetOperationNames()
        {
            return _operations.Select(x => x.Name).ToArray();
        }
    }

    /// <summary>
    /// Операции возможные для проводимых переменных
    /// На вход должны подаватся только уже обработанные и готовые переменные!!
    /// </summary>
    public abstract class MathOperation : IMathOperation
    {
        public abstract string Name { get; }
        public abstract object Execute(List<object> list);
    }

    // мат операции принимающие только один эллемент
    public abstract class SingularMathOperation : MathOperation
    {
        public override object Execute(List<object> list)
        {
            return Execute(list[0]);
        }

        public abstract object Execute(object obj);
    }

    // мат операции принимающие 2 эллемента
    public abstract class DualMathOperation : MathOperation
    {
        public override object Execute(List<object> list)
        {
            object result = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                result = Execute(result, list[i]);
            }
            return result;
        }

        public abstract object Execute(object objectA, object objectB);
    }

    // примитивные математические операции - "+, -, *, /, min, max" 
    public abstract class PrimitiveMathOperation : DualMathOperation
    {
        public override object Execute(object objectA, object objectB)
        {
            switch (objectA.GetType().Name + " " + objectB.GetType().Name)
            {
                case "Double Double": return Execute((double)objectA, (double)objectB);
                case "Double[,] Double": return Execute((double[,])objectA, (double)objectB);
                case "Func`2 Double": return Execute((Func<double, double>)objectA, (double)objectB);
                case "Func`2 Func`2": return Execute((Func<double, double>)objectA, (Func<double, double>)objectB);
                case "Double[,] Double[,]": return Execute((double[,])objectA, (double[,])objectB);
                default: throw new NotSupportedException();
            }
        }

        public abstract double Execute(double numberA, double numberB);

        public virtual double[,] Execute(double[,] matrixA, double[,] matrixB)
        {
            int x = matrixA.GetLength(0);
            int y = matrixA.GetLength(1);
            double[,] result = new double[x, y];
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    result[i, j] = Execute(matrixA[i, j], matrixB[i, j]);
            return result;
        }

        public double[,] Execute(double[,] matrix, double number)
        {
            int x = matrix.GetLength(0);
            int y = matrix.GetLength(1);
            double[,] result = new double[x, y];
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    result[i, j] = Execute(matrix[i, j], number);
            return result;
        }

        public Func<double, double> Execute(Func<double, double> functionA, Func<double, double> functionB)
        {
            throw new NotImplementedException();
        }

        public Func<double, double> Execute(Func<double, double> function, double number)
        {
            throw new NotImplementedException();
        }
    }
}
