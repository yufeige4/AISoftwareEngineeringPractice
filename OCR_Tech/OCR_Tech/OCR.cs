using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baidu.Aip;
using Baidu.Aip.Ocr;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Threading;

namespace OCR_Tech
{
    public partial class OCR : Form
    {
        //Baidu API keys
        private const string API_KEY = "YourAPIKey";
        private const string SECRET_KEY = "YourSecretKey";

        // API交互类
        private readonly Ocr OCR_Instance;


        public OCR()
        {
            InitializeComponent();
            OCR_Instance = new Ocr(API_KEY, SECRET_KEY);
        }

        /**
         * 点击打开图片按钮
         */
        private void btn_openPic_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbox_filePath.Text = openFileDialog.FileName;
            }
            else
            {
                MessageBox.Show("打开文件失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /**
         * 点击通用识别按钮
         */
        private void btn_general_Click(object sender, EventArgs e)
        {
            tbox_general.Clear();
            if (tbox_filePath.Text != string.Empty)
            {
                JObject result;
                var image = File.ReadAllBytes(tbox_filePath.Text);
                Dictionary<String, Object> options = new Dictionary<String, Object> { };
                StringBuilder builder = new StringBuilder(64);

                try
                {
                    if (cbox_localtion.Checked)
                    {
                        options.Add("recognize_granularity", "big");
                        options.Add("vertexes_location", "true");
                    }
                    if (cbox_toward.Checked)
                    {
                        options.Add("detect_direction", "true");
                    }
                    Console.WriteLine("options:" + options.ToString());

                    if (rbtn_generalAcc.Checked)
                    {
                        if (cbox_localtion.Checked)
                            result = OCR_Instance.General(image, options);
                        else
                            result = OCR_Instance.GeneralBasic(image, options);
                    }
                    else
                    {
                        if (cbox_localtion.Checked)
                            result = OCR_Instance.Accurate(image, options);
                        else
                            result = OCR_Instance.AccurateBasic(image, options);
                    }

                    //处理结果
                    if(result.TryGetValue("direction", out JToken directionToken))
                    {
                        builder.Append("方向：" + directionToken.ToString() + Environment.NewLine);
                    }
                    if (result.TryGetValue("words_result", out JToken wordsToken))
                    {
                        foreach (var word in wordsToken)
                        {
                            if (cbox_localtion.Checked)
                                builder.Append("(l:" + word["location"]["left"] + ",t:" + word["location"]["top"] + ",w:" + word["location"]["width"] + ",h:" + word["location"]["height"] + "):");
                            builder.Append(word.Value<string>("words") + Environment.NewLine);
                        }
                    }
                    
                    tbox_general.Text = builder.ToString();
                }
                catch (AipException exp)
                {
                    MessageBox.Show(exp.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("请选择图片", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /**
         * 点击网络图片识别
         */
        private void btn_net_Click(object sender, EventArgs e)
        {
            tbox_net.Clear();
            if (tbox_filePath.Text != string.Empty)
            {
                JObject result;
                var image = File.ReadAllBytes(tbox_filePath.Text);
                Dictionary<String, Object> options = new Dictionary<String, Object> { };
                StringBuilder builder = new StringBuilder(64);

                try
                {
                    result = OCR_Instance.WebImage(image, options);

                    //处理结果
                    if (result.TryGetValue("words_result", out JToken wordsToken))
                    {
                        foreach (var word in wordsToken)
                        {
                            builder.Append(word.Value<string>("words") + Environment.NewLine);
                        }
                    }
                    tbox_net.Text = builder.ToString();
                }
                catch (AipException exp)
                {
                    MessageBox.Show(exp.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("请选择图片", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /**
         * 点击卡证识别
         */
        private void btn_card_Click(object sender, EventArgs e)
        {
            tbox_card.Clear();
            if (tbox_filePath.Text != string.Empty)
            {
                JObject result;
                var image = File.ReadAllBytes(tbox_filePath.Text);
                Dictionary<String, Object> options = new Dictionary<String, Object> { };
                StringBuilder builder = new StringBuilder(64);

                try
                {
                    if (rbtn_cardFront.Checked)
                        result = OCR_Instance.Idcard(image,"front", options);
                    else if(rbtn_cardBack.Checked)
                        result = OCR_Instance.Idcard(image, "back", options);
                    else if (rbtn_cardBank.Checked)
                        result = OCR_Instance.Bankcard(image);
                    else if (rbtn_cardLicense.Checked)
                        result = OCR_Instance.BusinessLicense(image, options);
                    else if (rbtn_cardDrive.Checked)
                        result = OCR_Instance.DrivingLicense(image, options);
                    else if (rbtn_cardDriving.Checked)
                        result = OCR_Instance.VehicleLicense(image, options);
                    else
                        result = OCR_Instance.LicensePlate(image, options);

                    Console.WriteLine(result);

                    //处理结果
                    if (result.TryGetValue("words_result", out JToken wordsToken))
                    {
                        Console.WriteLine(wordsToken.ToString());
                        //单独处理车牌
                        if (rbtn_cardCar.Checked)
                        {
                            builder.Append("颜色：" + wordsToken.Value<string>("color") + Environment.NewLine);
                            builder.Append("号码：" + wordsToken.Value<string>("number") + Environment.NewLine);
                        }
                        else
                            foreach (JProperty word in result["words_result"])
                            {
                                builder.Append(word.Name + ":" + word.First.Value<string>("words") + Environment.NewLine);
                            }
                    }
                    //处理银行卡
                    else if (result.TryGetValue("result", out JToken token))
                    {
                        builder.Append("银行卡号：" + token.Value<string>("bank_card_number") + Environment.NewLine);
                        builder.Append("有效期：" + token.Value<string>("valid_date") + Environment.NewLine);
                        builder.Append("类型：" + token.Value<string>("bank_card_type") + Environment.NewLine);
                        builder.Append("银行名称：" + token.Value<string>("bank_name") + Environment.NewLine);
                        builder.Append("持有人：" + token.Value<string>("holder_name") + Environment.NewLine);
                    }
                    else
                        MessageBox.Show("识别失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbox_card.Text = builder.ToString();
                }
                catch (AipException exp)
                {
                    MessageBox.Show(exp.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("请选择图片", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /**
         * 点击表格识别按钮
         */
        private void btn_table_Click(object sender, EventArgs e)
        {
            tbox_table.Clear();
            if (tbox_filePath.Text != string.Empty)
            {
                JObject result;
                var image = File.ReadAllBytes(tbox_filePath.Text);
                Dictionary<String, Object> options = new Dictionary<String, Object> { };
                options.Add("request_type", "json");
                StringBuilder builder = new StringBuilder(64);

                try
                {
                    //禁用按钮
                    btn_table.Enabled = false;
                    result = OCR_Instance.TableRecognitionRequest(image, options);
                    
                    //处理结果
                    if (result.TryGetValue("result", out JToken token))
                    {
                        //创建子线程获取结果
                        Thread thread = new Thread(getTableRecognitionResult);
                        thread.Start(token.First.Value<string>("request_id"));
                    }
                    else
                    {
                        btn_table.Enabled = true;
                        MessageBox.Show("请求失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (AipException exp)
                {
                    MessageBox.Show(exp.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("请选择图片", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /**
         * 异步获取表格识别结果
         */
        private void getTableRecognitionResult(object requestID)
        {
            JObject result;
            Dictionary<String, Object> options = new Dictionary<String, Object> { };
            options.Add("result_type", "json");
            StringBuilder builder = new StringBuilder(64);

            try
            {
                result = OCR_Instance.TableRecognitionGetResult(requestID.ToString(), options);
                result.TryGetValue("result", out JToken code);
                while(code.Value<int>("ret_code") != 3)
                {
                    Thread.Sleep(1000);
                    result = OCR_Instance.TableRecognitionGetResult(requestID.ToString(), options);
                    result.TryGetValue("result", out JToken newCode);
                    code = newCode;
                }
                
                btn_table.Invoke(new Action(() =>
                {
                    //启用按钮
                    btn_table.Enabled = true;
                }));

                //处理结果
                if (result.TryGetValue("result", out JToken token))
                {
                    builder.Append(token.Value<string>("result_data"));
                    //显示结果
                    tbox_table.Invoke(new Action(() =>
                    {
                        tbox_table.Text = builder.ToString();
                    }));
                }
                else
                {
                    MessageBox.Show("请求失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (AipException exp)
            {
                MessageBox.Show(exp.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

    }
}
