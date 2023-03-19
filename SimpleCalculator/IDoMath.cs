using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SimpleCalculator
{
    internal interface IDoMath
    {
        long DoMath(long left,long right);
    }

    internal interface IPlus : IDoMath {
        new long DoMath(long left, long right);
    }
    internal interface IMinus : IDoMath
    {
        new long DoMath(long left, long right);
    }
    internal interface IMultiply : IDoMath
    {
        new long DoMath(long left, long right);
    }
    internal interface IDivide : IDoMath
    {
        new long DoMath(long left, long right);
    }


}
