namespace SimpleCalculator
{
    public partial class MyCalculator : Form
    {
        private int inputTag = 0;
        public long LeftNum { set; get; }
        public long RightNum { set; get; }
        public long PrevResult { set; get; }

        private MyMathOperator calculateMethod;
        public MyMathOperator CalculateMethod
        {
            set
            {
                inputTag = (inputTag + 1) % 2;
                calculateMethod = value;
            }
            get
            {
                return calculateMethod;
            }
        }

        public MyCalculator()
        {
            InitializeComponent();
        }

        public bool IsLeftNum()
        {
            return inputTag == 0;
        }
        public bool IsRightNum()
        {
            return inputTag == 1;
        }

        private void MyCalculator_Load(object sender, EventArgs e)
        {

        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            // 输出答案
            if (inputTag == 1) {
                long result = CalculateMethod.Calculate(LeftNum, RightNum);
                inputTag = (inputTag + 1) % 2;
                
                LeftNum = 0;
                RightNum = 0;

                PrevResult = result;
                DisplayTextBox.Text = result.ToString();
            }
            else
            {
                // 将之前的计算结果变成输入值
                LeftNum = PrevResult;
                PrevResult = 0;
                DisplayTextBox.Text = LeftNum.ToString();
            }
        }
    }
}