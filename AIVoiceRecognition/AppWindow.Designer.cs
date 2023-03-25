namespace AIVoiceRecognition
{
    partial class AppWindow
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
            OFD_1 = new OpenFileDialog();
            Text_OpenFile = new TextBox();
            Button_OpenFile = new Button();
            Selector_FileFormat = new ComboBox();
            Button_StartVoiceRecog = new Button();
            Text_VoiceRegResult = new TextBox();
            Label_Hint = new Label();
            Group_VoiceRecog = new GroupBox();
            Group_VoiceSyn = new GroupBox();
            TextBox_InputText = new TextBox();
            Button_StartSyn = new Button();
            Group_VoiceRecog.SuspendLayout();
            Group_VoiceSyn.SuspendLayout();
            SuspendLayout();
            // 
            // OFD_1
            // 
            OFD_1.Filter = "(*.pcm)|*.pcm|(*.wav)|*.wav|(*.amr)|*.amr|(*.m4a)|*.m4a";
            // 
            // Text_OpenFile
            // 
            Text_OpenFile.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Text_OpenFile.Location = new Point(23, 38);
            Text_OpenFile.Name = "Text_OpenFile";
            Text_OpenFile.ReadOnly = true;
            Text_OpenFile.Size = new Size(275, 24);
            Text_OpenFile.TabIndex = 0;
            // 
            // Button_OpenFile
            // 
            Button_OpenFile.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Button_OpenFile.Location = new Point(323, 32);
            Button_OpenFile.Name = "Button_OpenFile";
            Button_OpenFile.Size = new Size(100, 35);
            Button_OpenFile.TabIndex = 1;
            Button_OpenFile.Text = "打开文件";
            Button_OpenFile.UseVisualStyleBackColor = true;
            Button_OpenFile.Click += Button_OpenFile_Click;
            // 
            // Selector_FileFormat
            // 
            Selector_FileFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            Selector_FileFormat.FormattingEnabled = true;
            Selector_FileFormat.Items.AddRange(new object[] { ".pcm", ".wav", ".amr", ".m4a" });
            Selector_FileFormat.Location = new Point(148, 112);
            Selector_FileFormat.Name = "Selector_FileFormat";
            Selector_FileFormat.Size = new Size(150, 31);
            Selector_FileFormat.TabIndex = 2;
            Selector_FileFormat.SelectedIndexChanged += FileFormat_SelectedIndexChanged;
            // 
            // Button_StartVoiceRecog
            // 
            Button_StartVoiceRecog.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Button_StartVoiceRecog.Location = new Point(323, 107);
            Button_StartVoiceRecog.Name = "Button_StartVoiceRecog";
            Button_StartVoiceRecog.Size = new Size(100, 35);
            Button_StartVoiceRecog.TabIndex = 3;
            Button_StartVoiceRecog.Text = "开始识别";
            Button_StartVoiceRecog.UseVisualStyleBackColor = true;
            Button_StartVoiceRecog.Click += StartRecog_Click;
            // 
            // Text_VoiceRegResult
            // 
            Text_VoiceRegResult.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Text_VoiceRegResult.Location = new Point(23, 204);
            Text_VoiceRegResult.Multiline = true;
            Text_VoiceRegResult.Name = "Text_VoiceRegResult";
            Text_VoiceRegResult.ReadOnly = true;
            Text_VoiceRegResult.Size = new Size(400, 200);
            Text_VoiceRegResult.TabIndex = 4;
            // 
            // Label_Hint
            // 
            Label_Hint.AutoSize = true;
            Label_Hint.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label_Hint.Location = new Point(23, 115);
            Label_Hint.Name = "Label_Hint";
            Label_Hint.Size = new Size(106, 21);
            Label_Hint.TabIndex = 5;
            Label_Hint.Text = "选择文件格式";
            Label_Hint.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Group_VoiceRecog
            // 
            Group_VoiceRecog.Controls.Add(Selector_FileFormat);
            Group_VoiceRecog.Controls.Add(Label_Hint);
            Group_VoiceRecog.Controls.Add(Text_OpenFile);
            Group_VoiceRecog.Controls.Add(Text_VoiceRegResult);
            Group_VoiceRecog.Controls.Add(Button_OpenFile);
            Group_VoiceRecog.Controls.Add(Button_StartVoiceRecog);
            Group_VoiceRecog.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Group_VoiceRecog.Location = new Point(12, 13);
            Group_VoiceRecog.Name = "Group_VoiceRecog";
            Group_VoiceRecog.Size = new Size(450, 425);
            Group_VoiceRecog.TabIndex = 6;
            Group_VoiceRecog.TabStop = false;
            Group_VoiceRecog.Text = "语音识别";
            // 
            // Group_VoiceSyn
            // 
            Group_VoiceSyn.Controls.Add(Button_StartSyn);
            Group_VoiceSyn.Controls.Add(TextBox_InputText);
            Group_VoiceSyn.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Group_VoiceSyn.Location = new Point(480, 13);
            Group_VoiceSyn.Name = "Group_VoiceSyn";
            Group_VoiceSyn.Size = new Size(300, 425);
            Group_VoiceSyn.TabIndex = 7;
            Group_VoiceSyn.TabStop = false;
            Group_VoiceSyn.Text = "语音合成";
            // 
            // TextBox_InputText
            // 
            TextBox_InputText.BorderStyle = BorderStyle.FixedSingle;
            TextBox_InputText.Location = new Point(28, 38);
            TextBox_InputText.Multiline = true;
            TextBox_InputText.Name = "TextBox_InputText";
            TextBox_InputText.Size = new Size(250, 315);
            TextBox_InputText.TabIndex = 0;
            TextBox_InputText.TextChanged += TextBox_InputText_TextChanged;
            // 
            // Button_StartSyn
            // 
            Button_StartSyn.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Button_StartSyn.Location = new Point(178, 369);
            Button_StartSyn.Name = "Button_StartSyn";
            Button_StartSyn.Size = new Size(100, 35);
            Button_StartSyn.TabIndex = 1;
            Button_StartSyn.Text = "开始合成";
            Button_StartSyn.UseVisualStyleBackColor = true;
            Button_StartSyn.Click += VoiceSyn_Click;
            // 
            // AppWindow
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Group_VoiceSyn);
            Controls.Add(Group_VoiceRecog);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AppWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Voice Recognition";
            Group_VoiceRecog.ResumeLayout(false);
            Group_VoiceRecog.PerformLayout();
            Group_VoiceSyn.ResumeLayout(false);
            Group_VoiceSyn.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog OFD_1;
        private TextBox Text_OpenFile;
        private Button Button_OpenFile;
        private ComboBox Selector_FileFormat;
        private Button Button_StartVoiceRecog;
        private TextBox Text_VoiceRegResult;
        private Label Label_Hint;
        private GroupBox Group_VoiceRecog;
        private GroupBox Group_VoiceSyn;
        private Button Button_StartSyn;
        private TextBox TextBox_InputText;
    }
}