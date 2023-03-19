using System.Reflection.Metadata.Ecma335;

namespace SimpleCalculator
{
    partial class MyCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new BtnNum(this,1);
            button2 = new BtnNum(this,2);
            button3 = new BtnNum(this,3);
            button4 = new BtnNum(this,4);
            button5 = new BtnNum(this,5);
            button6 = new BtnNum(this,6);
            button7 = new BtnNum(this,7);
            button8 = new BtnNum(this,8);
            button9 = new BtnNum(this,9);
            button0 = new BtnNum(this,0);
            BtnPlus = new BtnMath(this,new PlusOperator());
            BtnMinus = new BtnMath(this,new MinusOperator());
            BtnMultiply = new BtnMath(this,new MultiplyOperator());
            BtnDivide = new BtnMath(this,new DivideOperator());
            BtnEnter = new Button();
            this.DisplayTextBox = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(234, 111);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(342, 111);
            button2.Name = "button2";
            button2.Size = new Size(50, 50);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(453, 111);
            button3.Name = "button3";
            button3.Size = new Size(50, 50);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(234, 196);
            button4.Name = "button4";
            button4.Size = new Size(50, 50);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(342, 196);
            button5.Name = "button5";
            button5.Size = new Size(50, 50);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(453, 196);
            button6.Name = "button6";
            button6.Size = new Size(50, 50);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(234, 289);
            button7.Name = "button7";
            button7.Size = new Size(50, 50);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(342, 289);
            button8.Name = "button8";
            button8.Size = new Size(50, 50);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(453, 289);
            button9.Name = "button9";
            button9.Size = new Size(50, 50);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            button0.Location = new Point(234, 378);
            button0.Name = "button0";
            button0.Size = new Size(50, 50);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            // 
            // BtnPlus
            // 
            BtnPlus.Location = new Point(120, 111);
            BtnPlus.Name = "BtnPlus";
            BtnPlus.Size = new Size(50, 50);
            BtnPlus.TabIndex = 10;
            BtnPlus.Text = "+";
            BtnPlus.UseVisualStyleBackColor = true;
            // 
            // BtnMinus
            // 
            BtnMinus.Location = new Point(120, 196);
            BtnMinus.Name = "BtnMinus";
            BtnMinus.Size = new Size(50, 50);
            BtnMinus.TabIndex = 11;
            BtnMinus.Text = "-";
            BtnMinus.UseVisualStyleBackColor = true;
            // 
            // BtnMultiply
            // 
            BtnMultiply.Location = new Point(120, 289);
            BtnMultiply.Name = "BtnMultiply";
            BtnMultiply.Size = new Size(50, 50);
            BtnMultiply.TabIndex = 12;
            BtnMultiply.Text = "*";
            BtnMultiply.UseVisualStyleBackColor = true;
            // 
            // BtnDivide
            // 
            BtnDivide.Location = new Point(120, 378);
            BtnDivide.Name = "BtnDivide";
            BtnDivide.Size = new Size(50, 50);
            BtnDivide.TabIndex = 13;
            BtnDivide.Text = "/";
            BtnDivide.UseVisualStyleBackColor = true;
            // 
            // BtnEnter
            // 
            BtnEnter.Location = new Point(342, 378);
            BtnEnter.Name = "BtnEnter";
            BtnEnter.Size = new Size(161, 50);
            BtnEnter.TabIndex = 14;
            BtnEnter.Text = "计算";
            BtnEnter.UseVisualStyleBackColor = true;
            BtnEnter.Click += BtnEnter_Click;
            // 
            // DisplayTextBox
            // 
            this.DisplayTextBox.Location = new Point(120, 55);
            this.DisplayTextBox.Name = "DisplayTextBox";
            this.DisplayTextBox.Size = new Size(383, 27);
            this.DisplayTextBox.TabIndex = 15;
            // 
            // MyCalculator
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(this.DisplayTextBox);
            Controls.Add(BtnEnter);
            Controls.Add(BtnDivide);
            Controls.Add(BtnMultiply);
            Controls.Add(BtnMinus);
            Controls.Add(BtnPlus);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MyCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyCalculator";
            Load += MyCalculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private BtnNum button1;
        private BtnNum button2;
        private BtnNum button3;
        private BtnNum button4;
        private BtnNum button5;
        private BtnNum button6;
        private BtnNum button7;
        private BtnNum button8;
        private BtnNum button9;
        private BtnNum button0;
        private BtnMath BtnMinus;
        private BtnMath BtnMultiply;
        private BtnMath BtnDivide;
        private Button BtnEnter;
        private BtnMath BtnPlus;

        public TextBox DisplayTextBox { set; get; }
    }
}