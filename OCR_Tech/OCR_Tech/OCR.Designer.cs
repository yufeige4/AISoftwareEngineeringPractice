
namespace OCR_Tech
{
    partial class OCR
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbox_filePath = new System.Windows.Forms.TextBox();
            this.btn_openPic = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbox_general = new System.Windows.Forms.TextBox();
            this.btn_general = new System.Windows.Forms.Button();
            this.cbox_toward = new System.Windows.Forms.CheckBox();
            this.cbox_localtion = new System.Windows.Forms.CheckBox();
            this.rbtn_highAcc = new System.Windows.Forms.RadioButton();
            this.rbtn_generalAcc = new System.Windows.Forms.RadioButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_net = new System.Windows.Forms.Button();
            this.tbox_net = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbox_card = new System.Windows.Forms.TextBox();
            this.btn_card = new System.Windows.Forms.Button();
            this.rbtn_cardCar = new System.Windows.Forms.RadioButton();
            this.rbtn_cardDriving = new System.Windows.Forms.RadioButton();
            this.rbtn_cardDrive = new System.Windows.Forms.RadioButton();
            this.rbtn_cardLicense = new System.Windows.Forms.RadioButton();
            this.rbtn_cardBank = new System.Windows.Forms.RadioButton();
            this.rbtn_cardBack = new System.Windows.Forms.RadioButton();
            this.rbtn_cardFront = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbox_table = new System.Windows.Forms.TextBox();
            this.btn_table = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbox_filePath
            // 
            this.tbox_filePath.Location = new System.Drawing.Point(9, 16);
            this.tbox_filePath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbox_filePath.Name = "tbox_filePath";
            this.tbox_filePath.Size = new System.Drawing.Size(186, 20);
            this.tbox_filePath.TabIndex = 0;
            // 
            // btn_openPic
            // 
            this.btn_openPic.Location = new System.Drawing.Point(214, 17);
            this.btn_openPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_openPic.Name = "btn_openPic";
            this.btn_openPic.Size = new System.Drawing.Size(73, 23);
            this.btn_openPic.TabIndex = 1;
            this.btn_openPic.Text = "打开图片";
            this.btn_openPic.UseVisualStyleBackColor = true;
            this.btn_openPic.Click += new System.EventHandler(this.btn_openPic_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbox_general);
            this.groupBox1.Controls.Add(this.btn_general);
            this.groupBox1.Controls.Add(this.cbox_toward);
            this.groupBox1.Controls.Add(this.cbox_localtion);
            this.groupBox1.Controls.Add(this.rbtn_highAcc);
            this.groupBox1.Controls.Add(this.rbtn_generalAcc);
            this.groupBox1.Location = new System.Drawing.Point(9, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(278, 224);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "通用文字识别";
            // 
            // tbox_general
            // 
            this.tbox_general.Location = new System.Drawing.Point(18, 68);
            this.tbox_general.Multiline = true;
            this.tbox_general.Name = "tbox_general";
            this.tbox_general.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbox_general.Size = new System.Drawing.Size(243, 144);
            this.tbox_general.TabIndex = 4;
            // 
            // btn_general
            // 
            this.btn_general.Location = new System.Drawing.Point(188, 42);
            this.btn_general.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_general.Name = "btn_general";
            this.btn_general.Size = new System.Drawing.Size(73, 22);
            this.btn_general.TabIndex = 3;
            this.btn_general.Text = "识别图片";
            this.btn_general.UseVisualStyleBackColor = true;
            this.btn_general.Click += new System.EventHandler(this.btn_general_Click);
            // 
            // cbox_toward
            // 
            this.cbox_toward.AutoSize = true;
            this.cbox_toward.Location = new System.Drawing.Point(105, 45);
            this.cbox_toward.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbox_toward.Name = "cbox_toward";
            this.cbox_toward.Size = new System.Drawing.Size(74, 17);
            this.cbox_toward.TabIndex = 3;
            this.cbox_toward.Text = "检测方向";
            this.cbox_toward.UseVisualStyleBackColor = true;
            // 
            // cbox_localtion
            // 
            this.cbox_localtion.AutoSize = true;
            this.cbox_localtion.Location = new System.Drawing.Point(18, 45);
            this.cbox_localtion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbox_localtion.Name = "cbox_localtion";
            this.cbox_localtion.Size = new System.Drawing.Size(86, 17);
            this.cbox_localtion.TabIndex = 2;
            this.cbox_localtion.Text = "含位置信息";
            this.cbox_localtion.UseVisualStyleBackColor = true;
            // 
            // rbtn_highAcc
            // 
            this.rbtn_highAcc.AutoSize = true;
            this.rbtn_highAcc.Location = new System.Drawing.Point(105, 21);
            this.rbtn_highAcc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn_highAcc.Name = "rbtn_highAcc";
            this.rbtn_highAcc.Size = new System.Drawing.Size(61, 17);
            this.rbtn_highAcc.TabIndex = 1;
            this.rbtn_highAcc.Text = "高精度";
            this.rbtn_highAcc.UseVisualStyleBackColor = true;
            // 
            // rbtn_generalAcc
            // 
            this.rbtn_generalAcc.AutoSize = true;
            this.rbtn_generalAcc.Checked = true;
            this.rbtn_generalAcc.Location = new System.Drawing.Point(17, 22);
            this.rbtn_generalAcc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn_generalAcc.Name = "rbtn_generalAcc";
            this.rbtn_generalAcc.Size = new System.Drawing.Size(73, 17);
            this.rbtn_generalAcc.TabIndex = 0;
            this.rbtn_generalAcc.TabStop = true;
            this.rbtn_generalAcc.Text = "普通精度";
            this.rbtn_generalAcc.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "图片文件(*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_net);
            this.groupBox2.Controls.Add(this.tbox_net);
            this.groupBox2.Location = new System.Drawing.Point(9, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 194);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "网络图片文字识别";
            // 
            // btn_net
            // 
            this.btn_net.Location = new System.Drawing.Point(187, 16);
            this.btn_net.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_net.Name = "btn_net";
            this.btn_net.Size = new System.Drawing.Size(73, 22);
            this.btn_net.TabIndex = 5;
            this.btn_net.Text = "识别图片";
            this.btn_net.UseVisualStyleBackColor = true;
            this.btn_net.Click += new System.EventHandler(this.btn_net_Click);
            // 
            // tbox_net
            // 
            this.tbox_net.Location = new System.Drawing.Point(17, 43);
            this.tbox_net.Multiline = true;
            this.tbox_net.Name = "tbox_net";
            this.tbox_net.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbox_net.Size = new System.Drawing.Size(243, 144);
            this.tbox_net.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbox_card);
            this.groupBox3.Controls.Add(this.btn_card);
            this.groupBox3.Controls.Add(this.rbtn_cardCar);
            this.groupBox3.Controls.Add(this.rbtn_cardDriving);
            this.groupBox3.Controls.Add(this.rbtn_cardDrive);
            this.groupBox3.Controls.Add(this.rbtn_cardLicense);
            this.groupBox3.Controls.Add(this.rbtn_cardBank);
            this.groupBox3.Controls.Add(this.rbtn_cardBack);
            this.groupBox3.Controls.Add(this.rbtn_cardFront);
            this.groupBox3.Location = new System.Drawing.Point(305, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 204);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "卡证识别";
            // 
            // tbox_card
            // 
            this.tbox_card.Location = new System.Drawing.Point(16, 69);
            this.tbox_card.Multiline = true;
            this.tbox_card.Name = "tbox_card";
            this.tbox_card.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbox_card.Size = new System.Drawing.Size(301, 127);
            this.tbox_card.TabIndex = 5;
            // 
            // btn_card
            // 
            this.btn_card.Location = new System.Drawing.Point(244, 42);
            this.btn_card.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_card.Name = "btn_card";
            this.btn_card.Size = new System.Drawing.Size(73, 22);
            this.btn_card.TabIndex = 5;
            this.btn_card.Text = "识别图片";
            this.btn_card.UseVisualStyleBackColor = true;
            this.btn_card.Click += new System.EventHandler(this.btn_card_Click);
            // 
            // rbtn_cardCar
            // 
            this.rbtn_cardCar.AutoSize = true;
            this.rbtn_cardCar.Location = new System.Drawing.Point(139, 42);
            this.rbtn_cardCar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn_cardCar.Name = "rbtn_cardCar";
            this.rbtn_cardCar.Size = new System.Drawing.Size(49, 17);
            this.rbtn_cardCar.TabIndex = 11;
            this.rbtn_cardCar.Text = "车牌";
            this.rbtn_cardCar.UseVisualStyleBackColor = true;
            // 
            // rbtn_cardDriving
            // 
            this.rbtn_cardDriving.AutoSize = true;
            this.rbtn_cardDriving.Location = new System.Drawing.Point(78, 42);
            this.rbtn_cardDriving.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn_cardDriving.Name = "rbtn_cardDriving";
            this.rbtn_cardDriving.Size = new System.Drawing.Size(61, 17);
            this.rbtn_cardDriving.TabIndex = 10;
            this.rbtn_cardDriving.Text = "行驶证";
            this.rbtn_cardDriving.UseVisualStyleBackColor = true;
            // 
            // rbtn_cardDrive
            // 
            this.rbtn_cardDrive.AutoSize = true;
            this.rbtn_cardDrive.Location = new System.Drawing.Point(16, 42);
            this.rbtn_cardDrive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn_cardDrive.Name = "rbtn_cardDrive";
            this.rbtn_cardDrive.Size = new System.Drawing.Size(61, 17);
            this.rbtn_cardDrive.TabIndex = 9;
            this.rbtn_cardDrive.Text = "驾驶证";
            this.rbtn_cardDrive.UseVisualStyleBackColor = true;
            // 
            // rbtn_cardLicense
            // 
            this.rbtn_cardLicense.AutoSize = true;
            this.rbtn_cardLicense.Location = new System.Drawing.Point(246, 21);
            this.rbtn_cardLicense.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn_cardLicense.Name = "rbtn_cardLicense";
            this.rbtn_cardLicense.Size = new System.Drawing.Size(73, 17);
            this.rbtn_cardLicense.TabIndex = 8;
            this.rbtn_cardLicense.Text = "营业执照";
            this.rbtn_cardLicense.UseVisualStyleBackColor = true;
            // 
            // rbtn_cardBank
            // 
            this.rbtn_cardBank.AutoSize = true;
            this.rbtn_cardBank.Location = new System.Drawing.Point(184, 21);
            this.rbtn_cardBank.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn_cardBank.Name = "rbtn_cardBank";
            this.rbtn_cardBank.Size = new System.Drawing.Size(61, 17);
            this.rbtn_cardBank.TabIndex = 7;
            this.rbtn_cardBank.Text = "银行卡";
            this.rbtn_cardBank.UseVisualStyleBackColor = true;
            // 
            // rbtn_cardBack
            // 
            this.rbtn_cardBack.AutoSize = true;
            this.rbtn_cardBack.Location = new System.Drawing.Point(100, 21);
            this.rbtn_cardBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn_cardBack.Name = "rbtn_cardBack";
            this.rbtn_cardBack.Size = new System.Drawing.Size(85, 17);
            this.rbtn_cardBack.TabIndex = 6;
            this.rbtn_cardBack.Text = "身份证背面";
            this.rbtn_cardBack.UseVisualStyleBackColor = true;
            // 
            // rbtn_cardFront
            // 
            this.rbtn_cardFront.AutoSize = true;
            this.rbtn_cardFront.Checked = true;
            this.rbtn_cardFront.Location = new System.Drawing.Point(16, 21);
            this.rbtn_cardFront.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn_cardFront.Name = "rbtn_cardFront";
            this.rbtn_cardFront.Size = new System.Drawing.Size(85, 17);
            this.rbtn_cardFront.TabIndex = 5;
            this.rbtn_cardFront.TabStop = true;
            this.rbtn_cardFront.Text = "身份证正面";
            this.rbtn_cardFront.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbox_table);
            this.groupBox4.Controls.Add(this.btn_table);
            this.groupBox4.Location = new System.Drawing.Point(305, 227);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(331, 244);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "表格文字识别";
            // 
            // tbox_table
            // 
            this.tbox_table.Location = new System.Drawing.Point(16, 51);
            this.tbox_table.Multiline = true;
            this.tbox_table.Name = "tbox_table";
            this.tbox_table.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbox_table.Size = new System.Drawing.Size(301, 187);
            this.tbox_table.TabIndex = 5;
            // 
            // btn_table
            // 
            this.btn_table.Location = new System.Drawing.Point(244, 19);
            this.btn_table.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_table.Name = "btn_table";
            this.btn_table.Size = new System.Drawing.Size(73, 22);
            this.btn_table.TabIndex = 5;
            this.btn_table.Text = "识别图片";
            this.btn_table.UseVisualStyleBackColor = true;
            this.btn_table.Click += new System.EventHandler(this.btn_table_Click);
            // 
            // OCR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 485);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_openPic);
            this.Controls.Add(this.tbox_filePath);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OCR";
            this.Text = "OCR";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_filePath;
        private System.Windows.Forms.Button btn_openPic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_general;
        private System.Windows.Forms.CheckBox cbox_toward;
        private System.Windows.Forms.CheckBox cbox_localtion;
        private System.Windows.Forms.RadioButton rbtn_highAcc;
        private System.Windows.Forms.RadioButton rbtn_generalAcc;
        private System.Windows.Forms.TextBox tbox_general;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_net;
        private System.Windows.Forms.TextBox tbox_net;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbox_card;
        private System.Windows.Forms.Button btn_card;
        private System.Windows.Forms.RadioButton rbtn_cardCar;
        private System.Windows.Forms.RadioButton rbtn_cardDriving;
        private System.Windows.Forms.RadioButton rbtn_cardDrive;
        private System.Windows.Forms.RadioButton rbtn_cardLicense;
        private System.Windows.Forms.RadioButton rbtn_cardBank;
        private System.Windows.Forms.RadioButton rbtn_cardBack;
        private System.Windows.Forms.RadioButton rbtn_cardFront;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbox_table;
        private System.Windows.Forms.Button btn_table;
    }
}

