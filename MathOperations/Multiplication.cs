using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    internal class Multiplication : PrimitiveMathOperation
    {
        public override string Name => _name;
        private static string _name = "Multiplication";

        public override double Execute(double numberA, double numberB)
        {
            return numberA * numberB;
        }

        public override double[,] Execute(double[,] matrixA, double[,] matrixB)
        {
            int x = matrixA.GetLength(0);
            int y = matrixB.GetLength(1);
            int K = matrixA.GetLength(1);
            double[,] result = new double[x, y];
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                {
                    result[i, j] = 0;
                    for (int k =0; k < K; ++k)
                        result[i, j] += Execute(matrixA[i, k], matrixB[k, j]);
                }
            return result;
        }
    }
}
