using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorInterpritator;
using System.Windows.Forms;
using Convertation;
using MathOperations;

namespace BasicCalculator
{
    public interface ICalculator
    {
        string Calculate(string expr);
    }
    internal class Calculator : ICalculator
    {
        //[[7]]+[[7]]
        public string Calculate(string expr)
        {
            IParser parser = new Parser();
            try
            {
                OperationTree operationTree = parser.Parce(expr);

                var result = CalculateTree(operationTree);

                return Convertation.Convertation.UndentifiedToString(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "ERROR";
            }
        }

        private object CalculateTree(OperationTree tree)
        {
            if ((tree.nodes == null) || tree.nodes.Count == 0)
            {
                return Convertation.Convertation.ConvertToUnspecifiedValue(tree.Operation);
            }
            else
            {
                List<object> values = new List<object>();

                foreach(OperationTree node in tree.nodes)
                {
                    values.Add(CalculateTree(node));
                }

                return MathOp.Execute(tree.Operation, values);
            }
        }
    }
}
