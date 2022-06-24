using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    public interface IOperation
    {
        string Name { get; }
        object Execute(List<object> list);
    }

    /// <summary>
    /// Операции возможные для проводимых переменных
    /// На вход должны подаватся только уже обработанные и готовые переменные!!
    /// </summary>
    public abstract class Operation : IOperation
    {
        public abstract string Name { get; }
        public abstract object Execute(List<object> list);
    }
}
