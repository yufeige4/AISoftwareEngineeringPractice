using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using TetrisGame.Classes.Utils;
using TetrisGame.Entities;

namespace TetrisGame.Forms
{
    public partial class GameForm : Form
    {
        private Stopwatch timer;
        private TimeSpan lastMoveTime;
        private float tickTime = 0.5f;
        private Canvas board;
        private int width = 655;
        private int height = 655;
        protected Rectangle container;
        private Game nextShape;
        private bool gameOver;
        private Game currentShape;
        GameSettings gameSettings = new GameSettings();
        public GameForm()
        {
            InitializeComponent();
            SetContainerLocation();
            menu_panel.Hide();
            DoubleBuffered = true;
            this.Resize += onResize;
            this.KeyPreview = true;
            this.PreviewKeyDown += new PreviewKeyDownEventHandler(OnKeyDown);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            StartGame();
        }

        protected virtual void onResize(object sender, EventArgs e)
        {
            SetContainerLocation();
            Refresh();
        }
        private void NextShape()
        {
            currentShape = nextShape;
            currentShape.MakeCurrent();
            nextShape = new Game(board, Shapes.Random());
        }

        private void MoveDown()
        {
            if (!currentShape.Move(0))
            {
                if (currentShape.Location.Y >= 0)
                    board.SetBlocks(currentShape.BlocksInBoard);

                int linesCleared = board.Clear();
                if (linesCleared > 0)
                {
                    GameData.Score += (int)Math.Pow(2, linesCleared - 1) * 100;
                    GameData.ClearedString += linesCleared;
                }

                if (!currentShape.Moved || currentShape.Location.Y < 0)
                {
                    GameOver();
                    return;
                }
                NextShape();
            }
        }
        private void OnKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                MoveDown();
                GameData.Score += 2;
            }
            else if (e.KeyCode == Keys.Left)
            {
                currentShape.Move(-1);
            }
            else if (e.KeyCode == Keys.Right)
            {
                currentShape.Move(1);
            }
            else if (e.KeyCode == Keys.Up)
            {
                currentShape.Rotate();
            }
        }
        private void StartGame()
        {
            var dataFromFile = SaveAndLoad.Load<GameSettings>("settingsData.dat");
            if (dataFromFile != null)
            {
                gameSettings.Row = dataFromFile.Row;
                gameSettings.Column = dataFromFile.Column;
            }
            else
            {
                gameSettings.Row = 15;
                gameSettings.Column = 20;
            }
            timer = new Stopwatch();
            lastMoveTime = new TimeSpan(0);

                board = new Canvas(gameSettings.Row, gameSettings.Column, container);

            nextShape = new Game(board, Shapes.Random());
            NextShape();
            gameOver = false;
            timer.Start();
        }
        private void GameOver()
        {
            gameOver = true;
            MessageBox.Show("游戏结束！请点击\"确定\"按钮重新开始游戏。");
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.BackColor = Color.White;
            e.Graphics.FillRectangle(new SolidBrush(Color.White), container);

            Graphics g = e.Graphics;
            g.TranslateTransform(container.X, container.Y);

            TimeSpan timePassed = timer.Elapsed - lastMoveTime;
            if (timePassed.TotalSeconds >= tickTime)
            {
                MoveDown();
                GameData.Score++;
                lastMoveTime = timer.Elapsed;
            }

            board.Render(g);
            currentShape.Render(g);
            nextShape.Render(g);

            Font font = new Font("Arial", 15);
            SolidBrush textBrush = new SolidBrush(Color.DarkViolet);
            SizeF stringSize = g.MeasureString("Next:", font);
            int beginText = (board.Size.Width * board.BlockSize) + (container.Width - board.Size.Width * board.BlockSize) / 2;

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            g.DrawString("Next:", font, textBrush, beginText, board.NextDisplayRect.Top - stringSize.Height, sf);
            g.DrawString($"Score: {GameData.Score}\nString: {GameData.ClearedString}", font, textBrush, beginText, 30, sf);
            if (!gameOver)
            {
                Invalidate();
            }
        }

        private void SetContainerLocation()
        {   
            container = new Rectangle((ClientRectangle.Width / 2) - (width / 2), (ClientRectangle.Height / 2) - (height / 2), width, height);
            menu_panel.Location = new Point
            (
                (this.ClientRectangle.Width / 2) - (menu_panel.Size.Width / 2),
                (this.ClientRectangle.Height / 2) - (menu_panel.Size.Height / 2)
            );
        }

    }
}
