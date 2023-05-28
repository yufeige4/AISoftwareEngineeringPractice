using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TetrisGame.Classes.Utils;

namespace TetrisGame.Entities
{
    static class Shapes
    {
        [Serializable]
        public struct Shape
        {
            public List<bool[,]> Blocks;
            public Color Color;
            public Color SideColor;
            public Color TopColor;
            public Color BottomColor;
            public Size Size;

            public Shape(Color color, Color sideColor, Color topColor, Color bottomColor, int[,] shape, int width, int height)
            {
                this.Blocks = new List<bool[,]>();
                this.Color = color;

                SideColor = sideColor;
                TopColor = topColor;
                BottomColor = bottomColor;

                Blocks = ConvertToBoolArrey(shape);

                this.Size = new Size(width, height);
            }
        }

        private static string fileName = "test.dat";

        private static Random rand = new Random();

        private static List<Shape> shapes = new List<Shape>();

        private static void Save()
        {
            SaveAndLoad.Save(fileName, shapes);
        }

        public static void Load()
        {
            
            var dataFromFile = SaveAndLoad.Load<List<Shape>>(fileName);
            if (dataFromFile != null)
            {
                shapes = dataFromFile;
            }
            else
            {
                addDefaultShape();
            }
           

        }

        public static void addNewShape(int[,] tetrimino)
        {
            int Eqal = 0;
            bool isEqal = false;
            for (int sCount = 0; sCount < shapes.Count; sCount++)
            {
                for (int bCount = 0; bCount < shapes[sCount].Blocks.Count; bCount++)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            if (shapes[sCount].Blocks[bCount][i, j] == ConvertToBoolArrey(tetrimino)[0][i, j])
                            {
                                Eqal++;
                            }
                        }
                        
                    }
                    
                    if (Eqal == 16 )
                    {
                        isEqal = true;
                    }
                    Eqal = 0;
                }
               
            }
            if(isEqal == false)
            {
                shapes.Add(new Shape(
                Color.Purple,
                Color.White,
                Color.White,
                Color.White,
                tetrimino, 4, 4));
                Save();
            }
            else
            {
                MessageBox.Show("");
            }

        }

        private static List<bool[,]> ConvertToBoolArrey(int[,] shape)
        {
            List<bool[,]> temp = new List<bool[,]>();
            for (int i = 0; i < shape.Length / 4; i++)
            {
                bool[,] blocks = new bool[4, 4];
                for (int j = 0; j < 4; j++)
                {
                    string str = Convert.ToString(shape[i, j], 2).PadLeft(4, '0');
                    bool[] blockPos = str.Select(s => s.Equals('1')).ToArray();
                    for (int x = 0; x < blockPos.Length; x++)
                    {
                        blocks[x, j] = blockPos[x];
                    } 
                }
                temp.Add(blocks);
            }
            return temp;
        }

        private static void addDefaultShape()
        {
            shapes.Add(new Shape(
            Color.Pink,
            Color.Gray,
            Color.Gray,
            Color.Gray,
            new int[,]
            {
                {
                    0b0000,
                    0b0110,
                    0b0110,
                    0b0000,
                },
            }, 4, 4));
            shapes.Add(new Shape(
            Color.Pink,
            Color.Gray,
            Color.Gray,
            Color.Gray,
            new int[,]
            {
                {
                    0b0000,
                    0b1111,
                    0b0000,
                    0b0000,
                },
                {
                    0b0010,
                    0b0010,
                    0b0010,
                    0b0010,
                },
                {
                    0b0000,
                    0b0000,
                    0b1111,
                    0b0000,
                },
                {
                    0b0100,
                    0b0100,
                    0b0100,
                    0b0100,
                },
            }, 4, 3));
             shapes.Add(new Shape(
            Color.Pink,
            Color.Gray,
            Color.Gray,
            Color.Gray,
             new int[,]
             {
                {
                    0b0000,
                    0b1110,
                    0b0010,
                    0b0000,
                },
                {
                    0b0100,
                    0b0100,
                    0b1100,
                    0b0000,
                },
                {
                    0b1000,
                    0b1110,
                    0b0000,
                    0b0000,
                },
                {
                    0b0110,
                    0b0100,
                    0b0100,
                    0b0000,
                },
             }, 3, 4));
            shapes.Add(new Shape(
            Color.Pink,
            Color.Gray,
            Color.Gray,
            Color.Gray,
            new int[,]
            {
                {
                    0b0000,
                    0b1110,
                    0b1000,
                    0b0000,
                },
                {
                    0b1100,
                    0b0100,
                    0b0100,
                    0b0000,
                },
                {
                    0b0010,
                    0b1110,
                    0b0000,
                    0b0000,
                },
                {
                    0b0100,
                    0b0100,
                    0b0110,
                    0b0000,
                },
            }, 3, 4));
            shapes.Add(new Shape(
            Color.Pink,
            Color.Gray,
            Color.Gray,
            Color.Gray,
            new int[,]
            {
                {
                    0b0000,
                    0b1110,
                    0b0100,
                    0b0000,
                },
                {
                    0b0100,
                    0b1100,
                    0b0100,
                    0b0000,
                },
                {
                    0b0100,
                    0b1110,
                    0b0000,
                    0b0000,
                },
                {
                    0b0100,
                    0b0110,
                    0b0100,
                    0b0000,
                },
            }, 3, 4));
            shapes.Add(new Shape(
            Color.Pink,
            Color.Gray,
            Color.Gray,
            Color.Gray,
            new int[,]
            {
                {
                    0b1100,
                    0b0110,
                    0b0000,
                    0b0000,
                },
                {
                    0b0010,
                    0b0110,
                    0b0100,
                    0b0000,
                },
                {
                    0b0000,
                    0b1100,
                    0b0110,
                    0b0000,
                },
                {
                    0b0100,
                    0b1100,
                    0b1000,
                    0b0000,
                },
            }, 3, 2));
            shapes.Add(new Shape(
            Color.Pink,
            Color.Gray,
            Color.Gray,
            Color.Gray,
            new int[,]
            {
                {
                    0b0110,
                    0b1100,
                    0b0000,
                    0b0000,
                },
                {
                    0b0100,
                    0b0110,
                    0b0010,
                    0b0000,
                },
                {
                    0b0000,
                    0b0110,
                    0b1100,
                    0b0000,
                },
                {
                    0b1000,
                    0b1100,
                    0b0100,
                    0b0000,
                }
            }, 3, 2));
        }

        public static Shape Random()
        {
            int index = rand.Next(shapes.Count);
            return shapes[index];
        }
    }
}
