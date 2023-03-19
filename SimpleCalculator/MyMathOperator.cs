using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public abstract class MyMathOperator
    {
        public string DisplayText { get; set; }

        public MyMathOperator(){}

        public abstract long Calculate(long left, long right);
    }
}
