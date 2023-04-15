using System.Configuration;
using System.DirectoryServices;
using System.Xml.Serialization;
using Baidu.Aip.Face;
using Newtonsoft.Json.Linq;

namespace FaceRecognition
{
    public partial class FaceRecognitionApp : Form
    {
        string API_Key = "YourAPIKey";
        string Secret_Key = "YourSecretKey";

        Face Face_Instance;
        Dictionary<string, object> options;
        string Image_Left;
        string Image_Right;
        bool Left = false;
        bool Right = false;
        bool LeftDectected = false;
        bool RightDectected = false;

        public FaceRecognitionApp()
        {
            InitializeComponent();
            Face_Instance = new Face(API_Key, Secret_Key);
            OFD_Left.Filter = "*.jpg|*.jpg|*.bmp|*.bmp|*.png|*.png";
            OFD_Right.Filter = "*.jpg|*.jpg|*.bmp|*.bmp|*.png|*.png";
            options = new Dictionary<string, object> { { "face_field", "beauty,age,expression,face_shape,gender,race" } };
        }

        private void Btn_LoadImage_Left_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = OFD_Left.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                Picture_Left.Image = new Bitmap(OFD_Left.FileName);
                Picture_Left.SizeMode = PictureBoxSizeMode.StretchImage;
                Left = true;
            }
            LeftDectected = false;
            string image = Convert.ToBase64String(File.ReadAllBytes(OFD_Left.FileName));
            var result = Face_Instance.Detect(image, "BASE64", options);
            JToken[] faceList = result["result"]["face_list"].ToArray<JToken>();
            string displayResult = "未检测到人脸!";
            if(faceList.Length == 0)
            {
                Text_FaceResult_Left.Text = displayResult;
                return;
            }
            LeftDectected = true;
            displayResult = HandleFaceInfo(faceList[0]);
           
            Text_FaceResult_Left.Text = displayResult;
            Text_CompareResult.Text = "";
        }

        private void Btn_LoadImage_Right_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = OFD_Right.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                Picture_Right.Image = new Bitmap(OFD_Right.FileName);
                Picture_Right.SizeMode = PictureBoxSizeMode.StretchImage;
                Right = true;
            }
            RightDectected = false;
            string image = Convert.ToBase64String(File.ReadAllBytes(OFD_Right.FileName));
            var result = Face_Instance.Detect(image, "BASE64", options);
            JToken[] faceList = result["result"]["face_list"].ToArray<JToken>();
            string displayResult = "未检测到人脸!";
            if (faceList.Length == 0)
            {
                Text_FaceResult_Right.Text = displayResult;
                return;
            }
            RightDectected = true;
            displayResult = HandleFaceInfo(faceList[0]);

            Text_FaceResult_Right.Text = displayResult;
            Text_CompareResult.Text = "";
        }

        private void Btn_FaceCompare_Click(object sender, EventArgs e)
        {
            if (!Left)
            {
                MessageBox.Show("比对失败：左图为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Right)
            {
                MessageBox.Show("比对失败：右图为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var faces = new JArray {
                    new JObject {{"image", Convert.ToBase64String (File.ReadAllBytes(OFD_Left.FileName)) },{"image_type", "BASE64"}},
                    new JObject {{"image", Convert.ToBase64String (File.ReadAllBytes(OFD_Right.FileName)) },{"image_type", "BASE64"}}
            };
            var result = Face_Instance.Match(faces);
            string score = result["result"]["score"].ToString();
            string displayText = "相似度: " + score + ", ";
            double scoreVal = Convert.ToDouble(score);
            if(scoreVal == 100)
            {
                displayText += "同一个人";
            }else if (scoreVal >= 80)
            {
                displayText += "像";
            }
            else
            {
                displayText += "不像";
            }

            Text_CompareResult.Text = displayText;
        }

        string HandleFaceInfo(JToken face)
        {
            string displayResult = "";
            string age = face["age"].ToString();
            string beauty = face["beauty"].ToString();
            string expression = face["expression"]["type"].ToString();
            string expressionProbability = face["expression"]["probability"].ToString();
            string faceShape = face["face_shape"]["type"].ToString();
            string faceShapeProbabiltiy = face["face_shape"]["probability"].ToString();
            string gender = face["gender"]["type"].ToString();
            string genderProbability = face["gender"]["probability"].ToString();
            string race = face["race"]["type"].ToString();
            string raceProbability = face["race"]["probability"].ToString();


            displayResult = "估算年龄: " + age + Environment.NewLine;
            displayResult += "样貌评分: " + beauty + Environment.NewLine;
            displayResult += "表情：" + expression + ", 置信度: " + expressionProbability + Environment.NewLine;
            displayResult += "脸型：" + faceShape + ", 置信度: " + faceShapeProbabiltiy + Environment.NewLine;
            displayResult += "性别：" + gender + ", 置信度: " + genderProbability + Environment.NewLine;
            displayResult += "人种：" + race + ", 置信度: " + raceProbability + Environment.NewLine;

            return displayResult;
        }
    }
}