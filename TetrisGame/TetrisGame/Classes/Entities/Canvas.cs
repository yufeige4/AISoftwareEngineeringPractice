using System.Drawing;

namespace TetrisGame.Entities
{
    class Canvas
    {
        private int boardWidth;
        private int boardHeight;
        private int blockSize;

        private Brick[,] boardState;

        public int BlockSize { get { return blockSize; } }
        public Size Size { get { return new Size(boardWidth, boardHeight); } }
        public Rectangle NextDisplayRect { get; }

        public Canvas(int width, int height, Rectangle container)
        {
            this.boardWidth = width;
            this.boardHeight = height;

            blockSize = (int)((double)container.Height / boardHeight);
            boardState = new Brick[width, height];

            Size displaySize = new Size(4 * blockSize, 4 * blockSize);
            NextDisplayRect = new Rectangle(new Point((boardWidth * blockSize) + ((container.Width - (boardWidth * blockSize)) / 2) - (displaySize.Width / 2), (container.Height / 2) - (displaySize.Height / 2)), displaySize);
        }

        public bool IsFilled(int x, int y)
        {
            if (y < 0) return false;
            return boardState[x, y] != null;
        }

        public bool IsLineComplete(int line)
        {
            for (int i = 0; i < boardWidth; i++)
            {
                if (boardState[i, line] == null) return false;
            }
            return true;
        }

        public void MoveDown(int deletedLine)
        {
            for (int y = deletedLine - 1; y >= 0; y--)
            {
                for (int x = 0; x < boardWidth; x++)
                {
                    boardState[x, y + 1] = boardState[x, y];
                }
            }
        }

        public int Clear()
        {
            int lines = 0;
            int i = Size.Height - 1;
            while (i >= 0)
            {
                if (IsLineComplete(i))
                {
                    MoveDown(i);
                    lines++;
                }
                else i--;
            }
            return lines;
        }

        public void SetBlocks(Brick[,] blocks)
        {
            for (int j = 0; j < boardHeight; j++)
            {
                for (int i = 0; i < boardWidth; i++)
                {
                    if (blocks[i, j] != null)
                    {
                        boardState[i, j] = blocks[i, j];
                    }
                }
            }
        }

        public void Render(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Black), NextDisplayRect);
            for (int i = 0; i < boardWidth; i++)
            {
                for (int j = 0; j < boardHeight; j++)
                {
                    Brick b;
                    if (boardState[i, j] == null)
                    {
                        g.FillRectangle(new SolidBrush(Color.Black), i * blockSize, j * blockSize, blockSize, blockSize);
                        g.DrawRectangle(new Pen(Color.Gray, 0.2f), i * blockSize, j * blockSize, blockSize, blockSize);
                    }
                    else
                    {
                        b = boardState[i, j];
                        b.Location = new Point(i * blockSize, j * blockSize);
                        b.Render(g);
                    }
                }
            }
        }
    }
}
