namespace NLP_App
{
    partial class Form_NLP
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
            GroupBox_1 = new GroupBox();
            OutputTree_DSP = new TreeView();
            OutputList_DNN = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            OutputList_LexicalAnalysis = new ListView();
            Col_1 = new ColumnHeader();
            Col_2 = new ColumnHeader();
            Col_3 = new ColumnHeader();
            Col_4 = new ColumnHeader();
            OutputText_SentenceFrequency = new TextBox();
            label1 = new Label();
            Btn_Confirm_DNN = new Button();
            Btn_Confirm_DependencySyntacticParsing = new Button();
            Btn_Confirm_LexicalAnalysis = new Button();
            InputText_Group1 = new TextBox();
            GroupBox_2 = new GroupBox();
            OutputText_Sim = new TextBox();
            label2 = new Label();
            Btn_Confirm_Similarity = new Button();
            InputText_SimB = new TextBox();
            InputText_SimA = new TextBox();
            GroupBox_3 = new GroupBox();
            Btn_Confirm_Emotion = new Button();
            Btn_Confirm_Comment = new Button();
            OutputText_Comment = new TextBox();
            label3 = new Label();
            InputText_Comment = new TextBox();
            comboBox1 = new ComboBox();
            GroupBox_4 = new GroupBox();
            Btn_Confirm_WordEmbed = new Button();
            OutputText_WordEmbed = new TextBox();
            InputText_WordEmbedding = new TextBox();
            GroupBox_6 = new GroupBox();
            Btn_Confirm_ArticleClassify = new Button();
            Btn_Confirm_ArticleLabel = new Button();
            OutputText_Article = new TextBox();
            InputText_ArticleContent = new TextBox();
            InputText_ArticleHeader = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            GroupBox_5 = new GroupBox();
            OutputText_WordSim = new TextBox();
            label6 = new Label();
            Btn_Confirm_WordSim = new Button();
            label5 = new Label();
            label4 = new Label();
            InputText_WordSimB = new TextBox();
            InputText_WordSimA = new TextBox();
            GroupBox_1.SuspendLayout();
            GroupBox_2.SuspendLayout();
            GroupBox_3.SuspendLayout();
            GroupBox_4.SuspendLayout();
            GroupBox_6.SuspendLayout();
            GroupBox_5.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox_1
            // 
            GroupBox_1.Controls.Add(OutputTree_DSP);
            GroupBox_1.Controls.Add(OutputList_DNN);
            GroupBox_1.Controls.Add(OutputList_LexicalAnalysis);
            GroupBox_1.Controls.Add(OutputText_SentenceFrequency);
            GroupBox_1.Controls.Add(label1);
            GroupBox_1.Controls.Add(Btn_Confirm_DNN);
            GroupBox_1.Controls.Add(Btn_Confirm_DependencySyntacticParsing);
            GroupBox_1.Controls.Add(Btn_Confirm_LexicalAnalysis);
            GroupBox_1.Controls.Add(InputText_Group1);
            GroupBox_1.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBox_1.Location = new Point(15, 20);
            GroupBox_1.Name = "GroupBox_1";
            GroupBox_1.Size = new Size(325, 600);
            GroupBox_1.TabIndex = 0;
            GroupBox_1.TabStop = false;
            GroupBox_1.Text = "词法分析/依存句法分析/DNN语言模型";
            // 
            // OutputTree_DSP
            // 
            OutputTree_DSP.Location = new Point(15, 283);
            OutputTree_DSP.Name = "OutputTree_DSP";
            OutputTree_DSP.Size = new Size(295, 125);
            OutputTree_DSP.TabIndex = 11;
            // 
            // OutputList_DNN
            // 
            OutputList_DNN.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            OutputList_DNN.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            OutputList_DNN.Location = new Point(15, 460);
            OutputList_DNN.Name = "OutputList_DNN";
            OutputList_DNN.Size = new Size(295, 125);
            OutputList_DNN.TabIndex = 10;
            OutputList_DNN.UseCompatibleStateImageBehavior = false;
            OutputList_DNN.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "序号";
            columnHeader1.Width = 45;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "分词";
            columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "概率值";
            columnHeader3.Width = 150;
            // 
            // OutputList_LexicalAnalysis
            // 
            OutputList_LexicalAnalysis.Columns.AddRange(new ColumnHeader[] { Col_1, Col_2, Col_3, Col_4 });
            OutputList_LexicalAnalysis.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            OutputList_LexicalAnalysis.Location = new Point(15, 104);
            OutputList_LexicalAnalysis.Name = "OutputList_LexicalAnalysis";
            OutputList_LexicalAnalysis.Size = new Size(295, 125);
            OutputList_LexicalAnalysis.TabIndex = 9;
            OutputList_LexicalAnalysis.UseCompatibleStateImageBehavior = false;
            OutputList_LexicalAnalysis.View = View.Details;
            // 
            // Col_1
            // 
            Col_1.Text = "序号";
            Col_1.Width = 45;
            // 
            // Col_2
            // 
            Col_2.Text = "分词";
            Col_2.Width = 75;
            // 
            // Col_3
            // 
            Col_3.Text = "词性";
            Col_3.Width = 75;
            // 
            // Col_4
            // 
            Col_4.Text = "基本词";
            Col_4.Width = 200;
            // 
            // OutputText_SentenceFrequency
            // 
            OutputText_SentenceFrequency.Location = new Point(109, 421);
            OutputText_SentenceFrequency.Name = "OutputText_SentenceFrequency";
            OutputText_SentenceFrequency.ReadOnly = true;
            OutputText_SentenceFrequency.Size = new Size(70, 27);
            OutputText_SentenceFrequency.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 423);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 7;
            label1.Text = "句子通顺值";
            // 
            // Btn_Confirm_DNN
            // 
            Btn_Confirm_DNN.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Confirm_DNN.Location = new Point(190, 419);
            Btn_Confirm_DNN.Name = "Btn_Confirm_DNN";
            Btn_Confirm_DNN.Size = new Size(120, 30);
            Btn_Confirm_DNN.TabIndex = 6;
            Btn_Confirm_DNN.Text = "DNN语言模型";
            Btn_Confirm_DNN.UseVisualStyleBackColor = true;
            Btn_Confirm_DNN.Click += Btn_Confirm_DNN_Clicked;
            // 
            // Btn_Confirm_DependencySyntacticParsing
            // 
            Btn_Confirm_DependencySyntacticParsing.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Confirm_DependencySyntacticParsing.Location = new Point(190, 241);
            Btn_Confirm_DependencySyntacticParsing.Name = "Btn_Confirm_DependencySyntacticParsing";
            Btn_Confirm_DependencySyntacticParsing.Size = new Size(120, 30);
            Btn_Confirm_DependencySyntacticParsing.TabIndex = 3;
            Btn_Confirm_DependencySyntacticParsing.Text = "依存句法分析";
            Btn_Confirm_DependencySyntacticParsing.UseVisualStyleBackColor = true;
            Btn_Confirm_DependencySyntacticParsing.Click += Btn_Confirm_DSP_Clicked;
            // 
            // Btn_Confirm_LexicalAnalysis
            // 
            Btn_Confirm_LexicalAnalysis.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Confirm_LexicalAnalysis.Location = new Point(220, 62);
            Btn_Confirm_LexicalAnalysis.Name = "Btn_Confirm_LexicalAnalysis";
            Btn_Confirm_LexicalAnalysis.Size = new Size(90, 30);
            Btn_Confirm_LexicalAnalysis.TabIndex = 1;
            Btn_Confirm_LexicalAnalysis.Text = "词法分析";
            Btn_Confirm_LexicalAnalysis.UseVisualStyleBackColor = true;
            Btn_Confirm_LexicalAnalysis.Click += Btn_Confirm_LA_Clicked;
            // 
            // InputText_Group1
            // 
            InputText_Group1.Location = new Point(15, 25);
            InputText_Group1.Name = "InputText_Group1";
            InputText_Group1.Size = new Size(295, 27);
            InputText_Group1.TabIndex = 0;
            InputText_Group1.Text = "我们在北航学习人工智能";
            // 
            // GroupBox_2
            // 
            GroupBox_2.Controls.Add(OutputText_Sim);
            GroupBox_2.Controls.Add(label2);
            GroupBox_2.Controls.Add(Btn_Confirm_Similarity);
            GroupBox_2.Controls.Add(InputText_SimB);
            GroupBox_2.Controls.Add(InputText_SimA);
            GroupBox_2.Location = new Point(355, 20);
            GroupBox_2.Name = "GroupBox_2";
            GroupBox_2.Size = new Size(375, 155);
            GroupBox_2.TabIndex = 1;
            GroupBox_2.TabStop = false;
            GroupBox_2.Text = "短文本相似度";
            // 
            // OutputText_Sim
            // 
            OutputText_Sim.Location = new Point(215, 111);
            OutputText_Sim.Name = "OutputText_Sim";
            OutputText_Sim.ReadOnly = true;
            OutputText_Sim.Size = new Size(120, 27);
            OutputText_Sim.TabIndex = 12;
            OutputText_Sim.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(165, 115);
            label2.Name = "label2";
            label2.Size = new Size(42, 21);
            label2.TabIndex = 12;
            label2.Text = "结果";
            // 
            // Btn_Confirm_Similarity
            // 
            Btn_Confirm_Similarity.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Confirm_Similarity.Location = new Point(35, 110);
            Btn_Confirm_Similarity.Name = "Btn_Confirm_Similarity";
            Btn_Confirm_Similarity.Size = new Size(120, 30);
            Btn_Confirm_Similarity.TabIndex = 12;
            Btn_Confirm_Similarity.Text = "短文本相似度";
            Btn_Confirm_Similarity.UseVisualStyleBackColor = true;
            Btn_Confirm_Similarity.Click += Btn_Confirm_Sim_Clicked;
            // 
            // InputText_SimB
            // 
            InputText_SimB.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            InputText_SimB.Location = new Point(200, 25);
            InputText_SimB.Multiline = true;
            InputText_SimB.Name = "InputText_SimB";
            InputText_SimB.ScrollBars = ScrollBars.Both;
            InputText_SimB.Size = new Size(160, 75);
            InputText_SimB.TabIndex = 1;
            InputText_SimB.Text = "创建帐户后，需要在调用AI之前创建应用程序。这是呼叫服务的基本能力单位。这是不可缺少的";
            // 
            // InputText_SimA
            // 
            InputText_SimA.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            InputText_SimA.Location = new Point(15, 25);
            InputText_SimA.Multiline = true;
            InputText_SimA.Name = "InputText_SimA";
            InputText_SimA.ScrollBars = ScrollBars.Both;
            InputText_SimA.Size = new Size(160, 75);
            InputText_SimA.TabIndex = 0;
            InputText_SimA.Text = "创建好账号后，在正式调用AI能力之前，需要您创建一下应用，这个是调用服务的基础能力单元，不可或缺哦";
            // 
            // GroupBox_3
            // 
            GroupBox_3.Controls.Add(Btn_Confirm_Emotion);
            GroupBox_3.Controls.Add(Btn_Confirm_Comment);
            GroupBox_3.Controls.Add(OutputText_Comment);
            GroupBox_3.Controls.Add(label3);
            GroupBox_3.Controls.Add(InputText_Comment);
            GroupBox_3.Controls.Add(comboBox1);
            GroupBox_3.Location = new Point(355, 180);
            GroupBox_3.Name = "GroupBox_3";
            GroupBox_3.Size = new Size(375, 240);
            GroupBox_3.TabIndex = 2;
            GroupBox_3.TabStop = false;
            GroupBox_3.Text = "评论观点抽取/情感倾向分析";
            // 
            // Btn_Confirm_Emotion
            // 
            Btn_Confirm_Emotion.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Confirm_Emotion.Location = new Point(255, 112);
            Btn_Confirm_Emotion.Name = "Btn_Confirm_Emotion";
            Btn_Confirm_Emotion.Size = new Size(110, 30);
            Btn_Confirm_Emotion.TabIndex = 16;
            Btn_Confirm_Emotion.Text = "情感倾向分析";
            Btn_Confirm_Emotion.UseVisualStyleBackColor = true;
            // 
            // Btn_Confirm_Comment
            // 
            Btn_Confirm_Comment.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Confirm_Comment.Location = new Point(139, 112);
            Btn_Confirm_Comment.Name = "Btn_Confirm_Comment";
            Btn_Confirm_Comment.Size = new Size(110, 30);
            Btn_Confirm_Comment.TabIndex = 15;
            Btn_Confirm_Comment.Text = "评论观点抽取";
            Btn_Confirm_Comment.UseVisualStyleBackColor = true;
            // 
            // OutputText_Comment
            // 
            OutputText_Comment.Location = new Point(13, 153);
            OutputText_Comment.Multiline = true;
            OutputText_Comment.Name = "OutputText_Comment";
            OutputText_Comment.ReadOnly = true;
            OutputText_Comment.ScrollBars = ScrollBars.Vertical;
            OutputText_Comment.Size = new Size(350, 75);
            OutputText_Comment.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1, 116);
            label3.Name = "label3";
            label3.Size = new Size(42, 21);
            label3.TabIndex = 13;
            label3.Text = "行业";
            // 
            // InputText_Comment
            // 
            InputText_Comment.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            InputText_Comment.Location = new Point(13, 26);
            InputText_Comment.Multiline = true;
            InputText_Comment.Name = "InputText_Comment";
            InputText_Comment.ScrollBars = ScrollBars.Vertical;
            InputText_Comment.Size = new Size(350, 75);
            InputText_Comment.TabIndex = 1;
            InputText_Comment.Text = "个人觉得这车不错，外观漂亮年轻，动力和操控性都很好";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "酒店", "KTV", "丽人", "美食餐饮", "旅游", "健康", "教育", "商业", "房产", "汽车", "生活", "购物", "3C" });
            comboBox1.Location = new Point(43, 113);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(90, 28);
            comboBox1.TabIndex = 0;
            // 
            // GroupBox_4
            // 
            GroupBox_4.Controls.Add(Btn_Confirm_WordEmbed);
            GroupBox_4.Controls.Add(OutputText_WordEmbed);
            GroupBox_4.Controls.Add(InputText_WordEmbedding);
            GroupBox_4.Location = new Point(355, 420);
            GroupBox_4.Name = "GroupBox_4";
            GroupBox_4.Size = new Size(155, 200);
            GroupBox_4.TabIndex = 3;
            GroupBox_4.TabStop = false;
            GroupBox_4.Text = "词向量";
            // 
            // Btn_Confirm_WordEmbed
            // 
            Btn_Confirm_WordEmbed.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Confirm_WordEmbed.Location = new Point(77, 33);
            Btn_Confirm_WordEmbed.Margin = new Padding(2);
            Btn_Confirm_WordEmbed.Name = "Btn_Confirm_WordEmbed";
            Btn_Confirm_WordEmbed.Size = new Size(65, 30);
            Btn_Confirm_WordEmbed.TabIndex = 12;
            Btn_Confirm_WordEmbed.Text = "词向量";
            Btn_Confirm_WordEmbed.UseVisualStyleBackColor = true;
            Btn_Confirm_WordEmbed.Click += Btn_Confirm_WordEmbed_Clicked;
            // 
            // OutputText_WordEmbed
            // 
            OutputText_WordEmbed.Location = new Point(12, 77);
            OutputText_WordEmbed.Multiline = true;
            OutputText_WordEmbed.Name = "OutputText_WordEmbed";
            OutputText_WordEmbed.ReadOnly = true;
            OutputText_WordEmbed.ScrollBars = ScrollBars.Vertical;
            OutputText_WordEmbed.Size = new Size(130, 108);
            OutputText_WordEmbed.TabIndex = 1;
            // 
            // InputText_WordEmbedding
            // 
            InputText_WordEmbedding.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            InputText_WordEmbedding.Location = new Point(12, 35);
            InputText_WordEmbedding.Name = "InputText_WordEmbedding";
            InputText_WordEmbedding.Size = new Size(60, 26);
            InputText_WordEmbedding.TabIndex = 0;
            InputText_WordEmbedding.Text = "智能";
            InputText_WordEmbedding.TextAlign = HorizontalAlignment.Center;
            // 
            // GroupBox_6
            // 
            GroupBox_6.Controls.Add(Btn_Confirm_ArticleClassify);
            GroupBox_6.Controls.Add(Btn_Confirm_ArticleLabel);
            GroupBox_6.Controls.Add(OutputText_Article);
            GroupBox_6.Controls.Add(InputText_ArticleContent);
            GroupBox_6.Controls.Add(InputText_ArticleHeader);
            GroupBox_6.Controls.Add(label9);
            GroupBox_6.Controls.Add(label8);
            GroupBox_6.Controls.Add(label7);
            GroupBox_6.Location = new Point(745, 20);
            GroupBox_6.Name = "GroupBox_6";
            GroupBox_6.Size = new Size(300, 600);
            GroupBox_6.TabIndex = 4;
            GroupBox_6.TabStop = false;
            GroupBox_6.Text = "文章标签/文章分类";
            // 
            // Btn_Confirm_ArticleClassify
            // 
            Btn_Confirm_ArticleClassify.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Confirm_ArticleClassify.Location = new Point(185, 402);
            Btn_Confirm_ArticleClassify.Name = "Btn_Confirm_ArticleClassify";
            Btn_Confirm_ArticleClassify.Size = new Size(90, 30);
            Btn_Confirm_ArticleClassify.TabIndex = 14;
            Btn_Confirm_ArticleClassify.Text = "文章分类";
            Btn_Confirm_ArticleClassify.UseVisualStyleBackColor = true;
            Btn_Confirm_ArticleClassify.Click += Btn_Confirm_ArticleClassify_Clicked;
            // 
            // Btn_Confirm_ArticleLabel
            // 
            Btn_Confirm_ArticleLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Confirm_ArticleLabel.Location = new Point(25, 403);
            Btn_Confirm_ArticleLabel.Name = "Btn_Confirm_ArticleLabel";
            Btn_Confirm_ArticleLabel.Size = new Size(90, 30);
            Btn_Confirm_ArticleLabel.TabIndex = 12;
            Btn_Confirm_ArticleLabel.Text = "文章标签";
            Btn_Confirm_ArticleLabel.UseVisualStyleBackColor = true;
            Btn_Confirm_ArticleLabel.Click += Btn_Confirm_ArticleLabel_Clicked;
            // 
            // OutputText_Article
            // 
            OutputText_Article.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            OutputText_Article.Location = new Point(25, 475);
            OutputText_Article.Multiline = true;
            OutputText_Article.Name = "OutputText_Article";
            OutputText_Article.ScrollBars = ScrollBars.Vertical;
            OutputText_Article.Size = new Size(250, 110);
            OutputText_Article.TabIndex = 13;
            // 
            // InputText_ArticleContent
            // 
            InputText_ArticleContent.Location = new Point(25, 138);
            InputText_ArticleContent.Multiline = true;
            InputText_ArticleContent.Name = "InputText_ArticleContent";
            InputText_ArticleContent.Size = new Size(250, 250);
            InputText_ArticleContent.TabIndex = 12;
            InputText_ArticleContent.Text = "欧洲冠军联赛是欧洲足球协会联盟主办的年度足球比赛，代表欧洲俱乐部足球最高荣誉和水平，被认为是全世界最高素质、最具影响力以及最高水平的俱乐部赛事，亦是世界上奖金最高的足球赛事和体育赛事之一。";
            // 
            // InputText_ArticleHeader
            // 
            InputText_ArticleHeader.Location = new Point(25, 65);
            InputText_ArticleHeader.Name = "InputText_ArticleHeader";
            InputText_ArticleHeader.Size = new Size(250, 27);
            InputText_ArticleHeader.TabIndex = 11;
            InputText_ArticleHeader.Text = "欧洲冠军杯足球赛";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(23, 443);
            label9.Name = "label9";
            label9.Size = new Size(113, 21);
            label9.TabIndex = 10;
            label9.Text = "标签/分类结果";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(23, 105);
            label8.Name = "label8";
            label8.Size = new Size(74, 21);
            label8.TabIndex = 9;
            label8.Text = "文章内容";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(23, 31);
            label7.Name = "label7";
            label7.Size = new Size(74, 21);
            label7.TabIndex = 8;
            label7.Text = "文章标题";
            // 
            // GroupBox_5
            // 
            GroupBox_5.Controls.Add(OutputText_WordSim);
            GroupBox_5.Controls.Add(label6);
            GroupBox_5.Controls.Add(Btn_Confirm_WordSim);
            GroupBox_5.Controls.Add(label5);
            GroupBox_5.Controls.Add(label4);
            GroupBox_5.Controls.Add(InputText_WordSimB);
            GroupBox_5.Controls.Add(InputText_WordSimA);
            GroupBox_5.Location = new Point(520, 420);
            GroupBox_5.Name = "GroupBox_5";
            GroupBox_5.Size = new Size(210, 200);
            GroupBox_5.TabIndex = 5;
            GroupBox_5.TabStop = false;
            GroupBox_5.Text = "词义相似度";
            // 
            // OutputText_WordSim
            // 
            OutputText_WordSim.Location = new Point(78, 157);
            OutputText_WordSim.Name = "OutputText_WordSim";
            OutputText_WordSim.ReadOnly = true;
            OutputText_WordSim.Size = new Size(120, 27);
            OutputText_WordSim.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(19, 161);
            label6.Name = "label6";
            label6.Size = new Size(42, 21);
            label6.TabIndex = 19;
            label6.Text = "结果";
            // 
            // Btn_Confirm_WordSim
            // 
            Btn_Confirm_WordSim.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Confirm_WordSim.Location = new Point(88, 114);
            Btn_Confirm_WordSim.Name = "Btn_Confirm_WordSim";
            Btn_Confirm_WordSim.Size = new Size(110, 30);
            Btn_Confirm_WordSim.TabIndex = 17;
            Btn_Confirm_WordSim.Text = "词义相似度";
            Btn_Confirm_WordSim.UseVisualStyleBackColor = true;
            Btn_Confirm_WordSim.Click += Btn_Confirm_WordSim_Clicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(19, 75);
            label5.Name = "label5";
            label5.Size = new Size(35, 21);
            label5.TabIndex = 18;
            label5.Text = "词2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(19, 35);
            label4.Name = "label4";
            label4.Size = new Size(35, 21);
            label4.TabIndex = 17;
            label4.Text = "词1";
            // 
            // InputText_WordSimB
            // 
            InputText_WordSimB.Location = new Point(78, 73);
            InputText_WordSimB.Name = "InputText_WordSimB";
            InputText_WordSimB.Size = new Size(120, 27);
            InputText_WordSimB.TabIndex = 1;
            InputText_WordSimB.Text = "打搅";
            // 
            // InputText_WordSimA
            // 
            InputText_WordSimA.Location = new Point(78, 33);
            InputText_WordSimA.Name = "InputText_WordSimA";
            InputText_WordSimA.Size = new Size(120, 27);
            InputText_WordSimA.TabIndex = 0;
            InputText_WordSimA.Text = "打扰";
            // 
            // Form_NLP
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 636);
            Controls.Add(GroupBox_5);
            Controls.Add(GroupBox_6);
            Controls.Add(GroupBox_4);
            Controls.Add(GroupBox_3);
            Controls.Add(GroupBox_2);
            Controls.Add(GroupBox_1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form_NLP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "自然语言处理";
            GroupBox_1.ResumeLayout(false);
            GroupBox_1.PerformLayout();
            GroupBox_2.ResumeLayout(false);
            GroupBox_2.PerformLayout();
            GroupBox_3.ResumeLayout(false);
            GroupBox_3.PerformLayout();
            GroupBox_4.ResumeLayout(false);
            GroupBox_4.PerformLayout();
            GroupBox_6.ResumeLayout(false);
            GroupBox_6.PerformLayout();
            GroupBox_5.ResumeLayout(false);
            GroupBox_5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBox_1;
        private GroupBox GroupBox_2;
        private GroupBox GroupBox_3;
        private GroupBox GroupBox_4;
        private GroupBox GroupBox_6;
        private GroupBox GroupBox_5;
        private TextBox OutputText_SentenceFrequency;
        private Label label1;
        private Button Btn_Confirm_DNN;
        private Button Btn_Confirm_DependencySyntacticParsing;
        private Button Btn_Confirm_LexicalAnalysis;
        private TextBox InputText_Group1;
        private ListView OutputList_LexicalAnalysis;
        private ColumnHeader Col_1;
        private ColumnHeader Col_2;
        private ColumnHeader Col_3;
        private ColumnHeader Col_4;
        private ListView OutputList_DNN;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TreeView OutputTree_DSP;
        private TextBox InputText_SimA;
        private Button Btn_Confirm_Similarity;
        private TextBox InputText_SimB;
        private Label label2;
        private TextBox OutputText_Sim;
        private TextBox InputText_Comment;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox OutputText_Comment;
        private Button Btn_Confirm_Emotion;
        private Button Btn_Confirm_Comment;
        private TextBox InputText_WordEmbedding;
        private Button Btn_Confirm_WordEmbed;
        private TextBox OutputText_WordEmbed;
        private TextBox InputText_WordSimA;
        private TextBox InputText_WordSimB;
        private TextBox OutputText_WordSim;
        private Label label6;
        private Button Btn_Confirm_WordSim;
        private Label label5;
        private Label label4;
        private TextBox InputText_ArticleHeader;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox InputText_ArticleContent;
        private TextBox OutputText_Article;
        private Button Btn_Confirm_ArticleClassify;
        private Button Btn_Confirm_ArticleLabel;
    }
}