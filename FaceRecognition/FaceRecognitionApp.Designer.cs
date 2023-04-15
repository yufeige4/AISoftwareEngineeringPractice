namespace FaceRecognition
{
    partial class FaceRecognitionApp
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
            Picture_Left = new PictureBox();
            Picture_Right = new PictureBox();
            Btn_LoadImage_Left = new Button();
            Btn_LoadImage_Right = new Button();
            Text_FaceResult_Left = new TextBox();
            Text_FaceResult_Right = new TextBox();
            Btn_FaceCompare = new Button();
            Text_CompareResult = new TextBox();
            label1 = new Label();
            OFD_Left = new OpenFileDialog();
            OFD_Right = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)Picture_Left).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Picture_Right).BeginInit();
            SuspendLayout();
            // 
            // Picture_Left
            // 
            Picture_Left.Location = new Point(50, 50);
            Picture_Left.Name = "Picture_Left";
            Picture_Left.Size = new Size(300, 300);
            Picture_Left.TabIndex = 0;
            Picture_Left.TabStop = false;
            // 
            // Picture_Right
            // 
            Picture_Right.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Picture_Right.Location = new Point(775, 50);
            Picture_Right.Name = "Picture_Right";
            Picture_Right.Size = new Size(300, 300);
            Picture_Right.TabIndex = 1;
            Picture_Right.TabStop = false;
            // 
            // Btn_LoadImage_Left
            // 
            Btn_LoadImage_Left.Location = new Point(250, 370);
            Btn_LoadImage_Left.Name = "Btn_LoadImage_Left";
            Btn_LoadImage_Left.Size = new Size(100, 35);
            Btn_LoadImage_Left.TabIndex = 2;
            Btn_LoadImage_Left.Text = "载入图像";
            Btn_LoadImage_Left.UseVisualStyleBackColor = true;
            Btn_LoadImage_Left.Click += Btn_LoadImage_Left_Click;
            // 
            // Btn_LoadImage_Right
            // 
            Btn_LoadImage_Right.Location = new Point(775, 370);
            Btn_LoadImage_Right.Name = "Btn_LoadImage_Right";
            Btn_LoadImage_Right.Size = new Size(100, 35);
            Btn_LoadImage_Right.TabIndex = 3;
            Btn_LoadImage_Right.Text = "载入图像";
            Btn_LoadImage_Right.UseVisualStyleBackColor = true;
            Btn_LoadImage_Right.Click += Btn_LoadImage_Right_Click;
            // 
            // Text_FaceResult_Left
            // 
            Text_FaceResult_Left.Location = new Point(50, 430);
            Text_FaceResult_Left.Multiline = true;
            Text_FaceResult_Left.Name = "Text_FaceResult_Left";
            Text_FaceResult_Left.ReadOnly = true;
            Text_FaceResult_Left.Size = new Size(300, 300);
            Text_FaceResult_Left.TabIndex = 4;
            // 
            // Text_FaceResult_Right
            // 
            Text_FaceResult_Right.Location = new Point(775, 430);
            Text_FaceResult_Right.Multiline = true;
            Text_FaceResult_Right.Name = "Text_FaceResult_Right";
            Text_FaceResult_Right.ReadOnly = true;
            Text_FaceResult_Right.Size = new Size(300, 300);
            Text_FaceResult_Right.TabIndex = 5;
            // 
            // Btn_FaceCompare
            // 
            Btn_FaceCompare.Location = new Point(510, 50);
            Btn_FaceCompare.Name = "Btn_FaceCompare";
            Btn_FaceCompare.Size = new Size(100, 35);
            Btn_FaceCompare.TabIndex = 6;
            Btn_FaceCompare.Text = "人脸比对";
            Btn_FaceCompare.UseVisualStyleBackColor = true;
            Btn_FaceCompare.Click += Btn_FaceCompare_Click;
            // 
            // Text_CompareResult
            // 
            Text_CompareResult.Location = new Point(410, 180);
            Text_CompareResult.Multiline = true;
            Text_CompareResult.Name = "Text_CompareResult";
            Text_CompareResult.ReadOnly = true;
            Text_CompareResult.Size = new Size(300, 225);
            Text_CompareResult.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(505, 130);
            label1.Name = "label1";
            label1.Size = new Size(110, 31);
            label1.TabIndex = 8;
            label1.Text = "比对结果";
            // 
            // OFD_Left
            // 
            OFD_Left.FileName = "OFD_File_Left";
            // 
            // OFD_Right
            // 
            OFD_Right.FileName = "OFD_File_Right";
            // 
            // FaceRecognitionApp
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 821);
            Controls.Add(label1);
            Controls.Add(Text_CompareResult);
            Controls.Add(Btn_FaceCompare);
            Controls.Add(Text_FaceResult_Right);
            Controls.Add(Text_FaceResult_Left);
            Controls.Add(Btn_LoadImage_Right);
            Controls.Add(Btn_LoadImage_Left);
            Controls.Add(Picture_Right);
            Controls.Add(Picture_Left);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FaceRecognitionApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Face Recognition";
            ((System.ComponentModel.ISupportInitialize)Picture_Left).EndInit();
            ((System.ComponentModel.ISupportInitialize)Picture_Right).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Picture_Left;
        private PictureBox Picture_Right;
        private Button Btn_LoadImage_Left;
        private Button Btn_LoadImage_Right;
        private TextBox Text_FaceResult_Left;
        private TextBox Text_FaceResult_Right;
        private Button Btn_FaceCompare;
        private TextBox Text_CompareResult;
        private Label label1;
        private OpenFileDialog OFD_Left;
        private OpenFileDialog OFD_Right;
    }
}