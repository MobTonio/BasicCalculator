using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    public interface IValueConstructor
    {
        void SetValue(object obj);

        object GetValue(object obj = null);
    }

    public class ValueConstructor<Val,v>: IValueConstructor where Val : Value<v>
    {
        protected Val _val;

        protected static object ExeptionValue { get; set; }
        protected void ExceptionNotification(Exception ex)
        {
            throw new NotImplementedException();
        }

        public object GetValue(object obj)
        {
            try
            {
                return _val.value;
            }
            catch (Exception ex)
            {
                ExceptionNotification(ex);
                return ExeptionValue;
            }  
        }

        public void SetValue(object val)
        {
            try
            {
                _val.value = _val.Convert(val);
            }
            catch (Exception ex)
            {
                ExceptionNotification(ex);
            }
        }
    }
}
