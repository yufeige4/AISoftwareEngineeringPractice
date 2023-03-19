using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class BtnNum : MyButtonBase
    {
        public int Number { get; set; }
        public BtnNum(MyCalculator Parent,int number) : base(Parent)
        {
            Number = number;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (ParentCalculator != null)
            {
                if (ParentCalculator.IsLeftNum())
                {
                    ParentCalculator.LeftNum = ParentCalculator.LeftNum*10+Number;
                    ParentCalculator.DisplayTextBox.Text = ParentCalculator.LeftNum.ToString();
                }
                else
                {
                    ParentCalculator.RightNum = ParentCalculator.RightNum*10+Number;
                    ParentCalculator.DisplayTextBox.Text = ParentCalculator.RightNum.ToString();
                }
            }
        }
    }
}
