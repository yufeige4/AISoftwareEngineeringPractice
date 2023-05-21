using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    public partial class SnakeGame : Form
    {
        // 配置地图大小
        private const int WIDTH = 30;
        private const int HEIGHT = 30;
        private const string SCORE_STRING = "Score: {0}";
        // 配置地图背景颜色
        private readonly Color m_BackgroundColor = Color.White;
        private readonly Game m_Game;
        private readonly Bitmap m_GameField;
        private readonly Graphics m_GameGraphics;

        public SnakeGame()
        {
            InitializeComponent();
            // 初始化
            m_GameField = new Bitmap(WIDTH * Piece.SIDE, HEIGHT * Piece.SIDE);
            m_GameGraphics = Graphics.FromImage(m_GameField); m_GameGraphics.PageUnit = GraphicsUnit.Pixel;
            ClientSize = new Size(m_GameField.Width, m_GameField.Height + m_RestartBtn.Height);
            m_Game = new Game(WIDTH, HEIGHT);
            m_Timer.Start();
        }

        private void UpdateScore()
        {
            scoreLbl.Text = string.Format(SCORE_STRING, m_Game.GetScore());
        }

        // 游戏Tick函数
        private void OnTimerTick(object sender, EventArgs e)
        {
            // 位移+吃判断
            if (m_Game.SnakeHasGrown())
            {
                UpdateScore();
            }
            // 失败判断
            if (m_Game.Lost())
            {
                m_Timer.Stop();
                m_RestartBtn.Enabled = true;
                MessageBox.Show("触碰墙壁或自身，游戏结束！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Invalidate();
        }

        // 玩家输入控制
        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    m_Game.ChangeSnakeDIrection(Direction.Left);
                    break;
                case Keys.Right:
                    m_Game.ChangeSnakeDIrection(Direction.Right);
                    break;
                case Keys.Up:
                    m_Game.ChangeSnakeDIrection(Direction.Up);
                    break;
                case Keys.Down:
                    m_Game.ChangeSnakeDIrection(Direction.Down);
                    break;
            }
        }

        // 绘制游戏
        private void OnPaint(object sender, PaintEventArgs e)
        {
            m_GameGraphics.Clear(m_BackgroundColor);
            m_Game.Draw(m_GameGraphics);
            e.Graphics.DrawImage(m_GameField, 0, m_RestartBtn.Height);
        }

        // 重启游戏
        private void OnRestartBtnClick(object sender, EventArgs e)
        {
            m_RestartBtn.Enabled = false;
            m_Game.Restart();
            UpdateScore();
            m_Timer.Start();
        }

        private void Window_Load(object sender, EventArgs e)
        {

        }
    }
}

