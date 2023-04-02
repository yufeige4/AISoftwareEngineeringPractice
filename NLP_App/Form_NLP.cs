namespace NLP_App
{
    using Baidu.Aip.Nlp;
    using Newtonsoft.Json.Linq;
    using System.CodeDom.Compiler;
    using System.Text;


    public partial class Form_NLP : Form
    {
        #region 查表
        // 词性表
        private readonly Dictionary<string, string> POSTable =
            new Dictionary<string, string>() {{"a", "形容词"},
                                               {"ad", "副形词"},
                                               {"ag", "形语素"},
                                               {"an", "名形词"},
                                               {"b", "区别词"},
                                               {"c", "连词"},
                                               {"d", "副词"},
                                               {"dg", "副语素"},
                                               {"e", "叹词"},
                                               {"f", "方位名词"},
                                               {"g", "语素"},
                                               {"h", "前接成分"},
                                               {"i", "成语"},
                                               {"j", "简称略语"},
                                               {"k", "后接成分"},
                                               {"l", "习惯语"},
                                               {"m", "数量词"},
                                               {"n", "普通名词"},
                                               {"ng", "名语素"},
                                               {"nr", "人名"},
                                               {"ns", "地名"},
                                               {"nt", "机构团体名"},
                                               {"nw", "作品名"},
                                               {"nz", "其他专名"},
                                               {"o", "拟声词"},
                                               {"p", "介词"},
                                               {"q", "量词"},
                                               {"r", "代词"},
                                               {"s", "处所名词"},
                                               {"t", "时间名词"},
                                               {"tg", "时语素"},
                                               {"u", "助词"},
                                               {"un","未知词"},
                                               {"v", "普通动词"},
                                               {"vd", "动副词"},
                                               {"vg", "动语素"},
                                               {"vn", "动名词"},
                                               {"w", "标点符号"},
                                               {"x", "非语素字"},
                                               {"xc", "其他虚词"},
                                               {"y", "语气词"},
                                               {"z", "状态词"},
                                               {"PER", "人名"},
                                               {"LOC", "地名"},
                                               {"ORG", "机构名"},
                                               {"TIME", "时间"},
                                               {"","/"}};

        // 专名缩写表
        private readonly Dictionary<string, string> NETable =
            new Dictionary<string, string>() {{"PER", "人名"},
                                               {"LOC", "地名"},
                                               {"ORG", "机构名"},
                                               {"TIME", "时间"},
                                               {"","/"}};

        // 依存关系缩写
        private readonly Dictionary<string, string> DEPRELTable =
            new Dictionary<string, string>() {{"SBV", "主谓关系"},
                                               {"VOB", "动宾关系"},
                                               {"POB", "介宾关系"},
                                               {"ADV", "状中关系"},
                                               {"CMP", "动补关系"},
                                               {"ATT", "定中关系"},
                                               {"F", "方位关系"},
                                               {"COO", "并列关系"},
                                               {"DBL", "兼语结构"},
                                               {"DOB", "双宾语结构"},
                                               {"VV", "连谓结构"},
                                               {"IC", "子句结构"},
                                               {"MT", "虚词成分"},
                                               {"HED", "核心关系"},
                                               {"",""}};
        #endregion
        string API_Key = "";
        string Secret_Key = "";

        public Form_NLP()
        {
            InitializeComponent();
        }

        string? ConvertGBK(string str)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            try
            {
                Encoding utf8 = Encoding.UTF8;
                Encoding gbk = Encoding.GetEncoding("gbk");
                byte[] temp_utf8 = utf8.GetBytes(str);
                byte[] temp_gbk = Encoding.Convert(utf8, gbk, temp_utf8);
                string result = gbk.GetString(temp_gbk);
                return result;
            }
            catch
            {
                return null;
            }
        }
        private void Btn_Confirm_LA_Clicked(object sender, EventArgs e)
        {
            var NLP_Instance = new Nlp(API_Key, Secret_Key);
            JObject? LA_Result = NLP_Instance.Lexer(ConvertGBK(InputText_Group1.Text));
            JToken result = LA_Result["items"];
            LA_OutputHandler(result);
        }

        private void LA_OutputHandler(JToken input)
        {
            JToken[] arr = input.ToArray();
            int len = arr.Length;
            for (int i = 0; i < len; i++)
            {
                JToken temp = arr[i];
                ListViewItem item = new ListViewItem();
                item.Text = (i + 1).ToString();
                item.SubItems.Add(temp["item"].ToString());
                item.SubItems.Add(POSTable[temp["pos"].ToString()]);
                item.SubItems.Add(temp["basic_words"].ToString());
                OutputList_LexicalAnalysis.Items.Add(item);

            }

        }

        private void Btn_Confirm_DSP_Clicked(object sender, EventArgs e)
        {
            var NLP_Instance = new Nlp(API_Key, Secret_Key);
            JObject DSP_Result = NLP_Instance.DepParser(ConvertGBK(InputText_Group1.Text));
            JToken result = DSP_Result["items"];
            DSP_OutputHandler(result);
        }

        private void DSP_OutputHandler(JToken input)
        {
            JToken[] arr = input.ToArray();
            int len = arr.Length;
            // DEPRELTable "deprel"
            // JToken[] sortedArr = Sort(arr, len);
            TreeNode[] nodes = new TreeNode[len];
            for (int i = 0; i < len; ++i)
            {
                string temp = arr[i]["word"].ToString() + "(" + DEPRELTable[arr[i]["deprel"].ToString()] + ")";
                nodes[i] = new TreeNode(temp);
            }
            TreeNode Root = new TreeNode();
            for (int i = 0; i < len; ++i)
            {
                int parentIndex = (int)arr[i]["head"] - 1;
                if (parentIndex == -1)
                {
                    Root = nodes[i];
                    continue;
                }
                nodes[parentIndex].Nodes.Add(nodes[i]);
            }
            OutputTree_DSP.Nodes.Add(Root);
            OutputTree_DSP.ExpandAll();
        }

        #region Deprecated
        private JToken[] Sort(JToken[] input, int len)
        {
            JToken[] arr = new JToken[len];
            for (int i = 0; i < len; ++i)
            {
                JToken temp = input[i].DeepClone();
                arr[i] = temp;
            }
            for (int i = 0; i < len - 1; ++i)
            {
                for (int j = 0; j < len - 1 - i; ++j)
                {
                    int left = (int)arr[j]["head"];
                    int right = (int)arr[j + 1]["head"];
                    if (left > right)
                    {
                        JToken temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
        #endregion
        private void Btn_Confirm_DNN_Clicked(object sender, EventArgs e)
        {
            var NLP_Instance = new Nlp(API_Key, Secret_Key);
            JObject DNN_Result = NLP_Instance.DnnlmCn(ConvertGBK(InputText_Group1.Text));
            OutputText_SentenceFrequency.Text = DNN_Result["ppl"].ToString();
            DNN_OutputHandler(DNN_Result["items"]);
        }

        private void DNN_OutputHandler(JToken input)
        {
            JToken[] arr = input.ToArray();
            int len = arr.Length;
            for (int i = 0; i < len; i++)
            {
                JToken temp = arr[i];
                ListViewItem item = new ListViewItem();
                item.Text = (i + 1).ToString();
                item.SubItems.Add(temp["word"].ToString());
                item.SubItems.Add(temp["prob"].ToString());
                OutputList_DNN.Items.Add(item);

            }

        }

        private void Btn_Confirm_Sim_Clicked(object sender, EventArgs e)
        {
            var NLP_Instance = new Nlp(API_Key, Secret_Key);
            JObject Sim_Result = NLP_Instance.Simnet(ConvertGBK(InputText_SimA.Text), ConvertGBK(InputText_SimB.Text));
            OutputText_Sim.Text = Sim_Result["score"].ToString();
        }

        private void Btn_Confirm_WordEmbed_Clicked(object sender, EventArgs e)
        {
            var NLP_Instance = new Nlp(API_Key, Secret_Key);
            JObject WordEmbed_Result = NLP_Instance.WordEmbedding(ConvertGBK(InputText_WordEmbedding.Text));
            Console.WriteLine(WordEmbed_Result.ToString());
            JToken[] lines = WordEmbed_Result["vec"].ToArray();
            int len = lines.Length;
            string result = "";
            for (int i = 0; i < len; ++i)
            {
                result += lines[i].ToString() + Environment.NewLine;
            }
            OutputText_WordEmbed.Text = result;
        }

        private void Btn_Confirm_WordSim_Clicked(object sender, EventArgs e)
        {
            string? WordA = ConvertGBK(InputText_WordSimA.Text);
            string? WordB = ConvertGBK(InputText_WordSimB.Text);
            var NLP_Instance = new Nlp(API_Key, Secret_Key);
            JObject WordSim_Result = NLP_Instance.WordSimEmbedding(WordA, WordB);
            OutputText_WordSim.Text = WordSim_Result["score"].ToString();
        }

        private void Btn_Confirm_ArticleLabel_Clicked(object sender, EventArgs e)
        {
            var NLP_Instance = new Nlp(API_Key, Secret_Key);
            string? Header = ConvertGBK(InputText_ArticleHeader.Text);
            string? Content = ConvertGBK(InputText_ArticleContent.Text);
            JObject ArticleLabel_Result = NLP_Instance.Keyword(Header, Content);
            string result = "";
            JToken[] items = ArticleLabel_Result["items"].ToArray();
            int len = items.Length;
            for (int i = 0; i < len; i++)
            {
                result += items[i]["tag"] + ": " + items[i]["score"] + Environment.NewLine;
            }
            OutputText_Article.Text = result;
        }

        private void Btn_Confirm_ArticleClassify_Clicked(object sender, EventArgs e)
        {
            var NLP_Instance = new Nlp(API_Key, Secret_Key);
            string? Header = ConvertGBK(InputText_ArticleHeader.Text);
            string? Content = ConvertGBK(InputText_ArticleContent.Text);
            JObject ArticleClassify_Result = NLP_Instance.Topic(Header, Content);
            JToken[] Level_1 = ArticleClassify_Result["item"]["lv1_tag_list"].ToArray();
            string result = "";
            result += "一级分类结果:" + Environment.NewLine + "    " + Level_1[0]["tag"].ToString() + ": " + Level_1[0]["score"].ToString() + Environment.NewLine;
            result += "二级分类结果:" + Environment.NewLine;
            JToken[] Level_2 = ArticleClassify_Result["item"]["lv2_tag_list"].ToArray();
            int len = Level_2.Length;
            for (int i = 0; i < len; ++i)
            {
                result += "    " + Level_2[i]["tag"].ToString() + ": "
                + Level_2[i]["score"].ToString() + Environment.NewLine;
            }
            OutputText_Article.Text = result;
        }
    }
}