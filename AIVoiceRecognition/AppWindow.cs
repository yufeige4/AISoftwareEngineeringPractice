using Baidu.Aip.Speech;
using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json.Nodes;

namespace AIVoiceRecognition
{
    public partial class AppWindow : Form
    {
        [DllImport("winmm.dll", SetLastError = true)]
        static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);

        // API related
        private string App_ID = "Your_ID";
        private string API_Key = "Your_ApiKey";
        private string Secret_Key = "Your_SecretKey";
        // Voice recognition
        private string[] Array_FileFormats = { "pcm", "wav", "amr", "m4a" };
        private int FileFormatIndex = 0;
        private bool bFinishSetting = false;
        // Voice synthesis
        private string QueryText;
        public AppWindow()
        {
            InitializeComponent();
        }

        private void Button_OpenFile_Click(object sender, EventArgs e)
        {
            DialogResult result = OFD_1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Text_OpenFile.Text = OFD_1.FileName;
                MessageBox.Show("打开文件成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Selector_FileFormat.Text = Array_FileFormats[FileFormatIndex];
                bFinishSetting = true;
            }
        }

        private void FileFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileFormatIndex = Selector_FileFormat.SelectedIndex;
            Selector_FileFormat.Text = Array_FileFormats[FileFormatIndex];
        }

        private void StartRecog_Click(object sender, EventArgs e)
        {
            Text_VoiceRegResult.Text = "";
            string Result = "";
            if (bFinishSetting)
            {
                Result = VoiceRecognize();
            }
            if ("".Equals(Result))
            {
                return;
            }
            Text_VoiceRegResult.Text = Result;
        }

        private string VoiceRecognize()
        {
            Asr AsrInstance = new Asr(App_ID, API_Key, Secret_Key);
            string FileFormat = Array_FileFormats[FileFormatIndex];
            const int Rate = 16000;
            /*Dictionary<string, object> Result;*/
            byte[] Data = System.IO.File.ReadAllBytes(OFD_1.FileName);

            JObject JResult = AsrInstance.Recognize(Data, FileFormat, Rate);
            Console.WriteLine(JResult.ToString());
            if ("success.".Equals((string)(JResult["err_msg"])))
            {
                MessageBox.Show("识别成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return (string)(JResult["result"][0]);
            }
            else
            {
                MessageBox.Show("识别失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return "";
            }
        }

        private byte[]? VoiceSynthesis()
        {
            byte[]? Result = null;
            Tts TtsInstance = new Tts(API_Key, Secret_Key);
            TtsResponse Response = TtsInstance.Synthesis(QueryText);
            if(Response.Success) 
            {
                Result = Response.Data;
            }
            return Result;
        }

        private void TextBox_InputText_TextChanged(object sender, EventArgs e)
        {
            QueryText = TextBox_InputText.Text;
        }

        private void VoiceSyn_Click(object sender, EventArgs e)
        {
            if ("".Equals(QueryText))
            {
                MessageBox.Show("合成失败：输入为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            byte[]? Result = VoiceSynthesis();

            if (Result == null) 
            {
                MessageBox.Show("合成失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                System.IO.File.WriteAllBytes("./temp.mp3", Result);
                MessageBox.Show("合成成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // 播放音频
                mciSendString("open temp.mp3 alias temp_alias", null, 0, IntPtr.Zero);
                mciSendString("play temp_alias", null, 0, IntPtr.Zero);
                StringBuilder strReturn = new StringBuilder(64);
                do
                {
                    mciSendString("status temp_alias mode", strReturn, 64, IntPtr.Zero);
                } while (!strReturn.ToString().Contains("stopped"));
                mciSendString("close temp_alias", null, 0, IntPtr.Zero);
            }

        }
    }


}