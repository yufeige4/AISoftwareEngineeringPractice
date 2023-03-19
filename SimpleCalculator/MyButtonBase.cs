using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class MyButtonBase : Button
    {
        protected MyCalculator ParentCalculator;
        public enum ButtonType { MathOperator, Number};
        public ButtonType BtnType { set; get; }
        public MyButtonBase(MyCalculator Parent)
        {
            ParentCalculator = Parent;
        }
    }

}
