using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    internal class BtnMath : MyButtonBase
    {
        public MyMathOperator MathOperator { get; set; }
        public BtnMath(MyCalculator Parent,MyMathOperator MathOp):base(Parent) {
            MathOperator = MathOp;
        }    

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (ParentCalculator != null)
            {
                ParentCalculator.CalculateMethod = MathOperator;
                ParentCalculator.DisplayTextBox.Text = MathOperator.DisplayText;
            }
        }
    }
}
