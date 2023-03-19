using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    internal class PlusOperator : MyMathOperator, IPlus
    {
        public PlusOperator() {
            base.DisplayText = "+";
        }

        public override long Calculate(long left, long right)
        {
            return DoMath(left, right);    
        }

        public long DoMath(long left, long right)
        {
            return left+ right;
        }
    }


    internal class MinusOperator : MyMathOperator, IMinus
    {
        public MinusOperator() {
            base.DisplayText = "-";
        }

        public override long Calculate(long left, long right)
        {
            return DoMath(left, right);
        }

        public long DoMath(long left, long right)
        {
            return left - right;
        }
    }



    internal class MultiplyOperator : MyMathOperator, IMultiply
    {
        public MultiplyOperator() {
            base.DisplayText = "*";
        }

        public override long Calculate(long left, long right)
        {
            return DoMath(left, right);
        }

        public long DoMath(long left, long right)
        {
            return left * right;
        }
    }


    internal class DivideOperator : MyMathOperator, IDivide
    {
        public DivideOperator() {
            base.DisplayText = "/";
        }

        public override long Calculate(long left, long right)
        {
            return DoMath(left, right);
        }

        public long DoMath(long left, long right)
        {
            return left / right;
        }
    }
}
