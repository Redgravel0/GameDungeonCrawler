using System.Drawing;
using System.IO;
using Game.Entites;

namespace Game.Controllers
{
    public static class MapController
    {
        public const int mapWidth = 40;
        public const int mapHeight = 32;
        public static int cellSize = 32;
        public static int[,] map = new int[mapWidth, mapHeight];
        public static Image spriteSheet;

        public static void Init()
        {
            map = GetMap();
            spriteSheet = new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Sprites\\texture.png"));
        }
        public static int[,] GetMap()
        {
            return new int[,]                                                                        
            {                                                                                                                  
                {-1,-1,-1,-1,-1 ,-1,-1 ,-1,-1,-1 ,-1,-1,-1,-1 ,-1,-1,-1,-1 ,-1,-1,-1 ,-1,-1,-1,-1 ,-1,-1,-1,-1,-1 ,-1,-1,-1,-1 ,-1 ,-1 ,-1,-1,-1,-1},
                {-1,10, 5, 5, 5 , 5, 5 , 5, 5, 5 ,11,-1,-1,10 , 5, 5, 5, 5 , 5, 5, 5 , 5,11,-1,-1 ,-1,-1,-1,-1,-1 ,-1,-1,-1,-1 ,-1 ,-1 ,-1,-1,-1,-1},
                {-1, 2, 1, 1, 1 , 1, 1 , 1, 1, 1 , 6, 5, 5, 7 , 1, 1, 1, 1 , 1, 1, 1 , 1, 3,-1,-1 ,-1,-1,-1,-1,-1 ,-1,-1,-1,-1 ,-1 ,-1 ,-1,-1,-1,-1},
                {-1, 2, 0, 0, 0 , 0, 0 , 0, 0,301, 1, 1, 1, 1 , 0, 0, 0, 0 , 0, 0, 0 , 0, 3,-1,-1 ,-1,-1,-1,-1,-1 ,-1,-1,-1,-1 ,-1 ,-1 ,-1,-1,-1,-1},
                {-1, 2, 0, 0,20 , 0, 0 , 0, 0, 0 , 0, 0,20, 0 , 0, 0, 0,321,20, 0,21 , 0, 3,-1,-1 ,-1,-1,-1,-1,-1 ,-1,-1,-1,-1 ,-1 ,-1 ,-1,-1,-1,-1},
                {-1, 2, 0, 0, 0 , 0,20 , 0, 0, 0 , 0, 0, 0, 0 , 0, 0,20, 0 , 0, 0,322, 0, 6, 5, 5 , 5, 5, 5, 5, 5 , 5, 5, 5,11 ,-1 ,-1 ,-1,-1,-1,-1},
                {-1, 2, 0, 0, 0 , 0, 0 , 0, 0,21 , 8, 4, 4, 9 , 0, 0, 0,20 , 0, 0, 0 , 0, 1, 1, 1 , 1, 1, 1, 1, 1 , 1, 1, 1, 3 ,-1 ,-1 ,-1,-1,-1,-1},
                {-1, 2, 0, 0,20 , 0, 0 , 0, 0, 0 , 3,-1,-1, 2 , 0, 0, 0, 0 , 0, 0, 0 , 0, 0, 0, 0 , 0, 0, 0, 0, 0 , 0, 0, 0, 3 ,-1 ,-1 ,-1,-1,-1,-1},
                {-1, 2, 0, 0, 0 , 0, 0 , 0, 0, 0 , 3,-1,-1, 2 , 0, 0, 0,302, 0, 0, 0 , 0, 0, 0, 0 , 0, 0, 0, 0, 0 , 0, 0, 0, 3 ,-1 ,-1 ,-1,-1,-1,-1},
                {-1,13, 4, 4, 4 , 4, 4 , 4, 4, 4 ,12,-1,-1,13 , 4, 4, 4, 4 , 4, 4, 4 , 4, 4, 4, 9 , 0, 0,21, 0,311,20, 0, 0, 3 ,-1 ,-1 ,-1,-1,-1,-1},
                {-1,-1,-1,-1,-1 ,-1,-1 ,-1,-1,-1 ,-1,-1,-1,-1 ,-1,-1,-1,-1 ,-1,-1,-1 ,-1,-1,-1, 2 , 0,21, 0, 0, 0 , 0,20, 0, 3 ,-1 ,-1 ,-1,-1,-1,-1},
                {-1,-1,-1,-1,-1 ,-1,-1 ,-1,-1,-1 ,-1,-1,-1,-1 ,-1,-1,-1,-1 ,-1,-1,-1 ,-1,-1,-1, 2 , 0, 0, 0,20, 0 , 0, 0, 0, 3 ,-1 ,-1 ,-1,-1,-1,-1},
                {-1,-1,-1,-1,-1 ,-1,-1 ,-1,-1,-1 ,10, 5, 5, 5 , 5, 5, 5, 5 ,11,-1,-1 ,-1,-1,-1, 2 , 0, 0, 0, 0, 0 , 0, 0, 0, 3 ,-1 ,-1 ,-1,-1,-1,-1},
                {-1,-1,-1,-1,-1 ,-1,-1 ,-1,-1,-1 , 2, 1, 1, 1 , 1, 1, 1, 1 , 3,-1,-1 ,-1,-1,-1,13 , 4, 4, 4, 4, 9 , 0, 0, 8,12 ,-1 ,-1 ,-1,-1,-1,-1},
                {-1,-1,-1,-1,-1 ,-1,-1 ,-1,-1,-1 , 2, 0, 0, 0 , 0,20, 0, 0 , 3,-1,-1 ,-1,-1,-1,-1 ,-1,-1,-1,10, 7 , 0, 0, 6, 5 , 5 , 5 , 5,11,-1,-1},
                {-1,-1,-1,-1,-1 ,-1,-1 ,-1,-1,-1 , 2, 0,21,21 ,21,21,21, 0 , 3,-1,-1 ,-1,-1,-1,-1 ,-1,-1,-1, 2, 1 , 0, 0, 1, 1 , 1 , 1 , 1, 3,-1,-1},
                {-1,-1,-1,-1,-1 ,-1,-1 ,-1,-1,-1 , 2, 0,21,20 , 0, 0,21, 0 , 3,-1,-1 ,-1,-1,-1,-1 ,-1,-1,-1, 2, 0 , 0, 0, 0, 0 ,323, 0 , 0, 3,-1,-1},
                {-1,-1,-1,-1,-1 ,-1,-1 ,-1,-1,-1 , 2,20,21, 0 ,33,20,21, 0 , 3,-1,-1 ,-1,-1,-1,-1 ,-1,-1,-1, 2, 0 , 0, 0, 0, 0 , 0 ,20 , 0, 3,-1,-1},
                {-1,10, 5, 5, 5 , 5, 5 , 5,11,-1 , 2, 0,21, 0 , 0, 0,21, 0 , 3,-1,-1 ,-1,-1,-1,-1 ,-1,-1,-1, 2, 0 , 0,20, 0, 0 , 0 , 0 , 0, 3,-1,-1},
                {-1, 2, 1, 1, 1 , 1, 1 , 1, 3,-1 ,13, 4, 9, 0 , 0, 0, 8, 4 ,12,-1,-1 ,-1,-1,-1,-1 ,-1,-1,-1, 2, 0 , 0, 0, 0,21 , 0 , 0 , 0, 3,-1,-1},
                {-1, 2,20, 0, 0 , 0, 0 , 0, 3,-1 ,-1,-1, 2, 0 , 0, 0, 3,-1 ,-1,-1,-1 ,-1,-1,-1,-1 ,-1,-1,-1, 2, 0 , 0, 0,20, 0 , 0 ,303, 0, 3,-1,-1},
                {-1, 2, 0, 0, 0 ,21,304, 0, 3,-1 ,-1,-1, 2, 0 , 0, 0, 3,-1 ,-1,-1,-1 ,-1,-1,-1,-1 ,-1,-1,-1, 2, 0 , 0, 0, 0,324, 0 , 0 , 0, 3,-1,-1},
                {-1, 2, 0,21,20 , 0, 0 , 0, 6, 5 , 5, 5, 7, 0 , 0, 0, 6, 5 , 5,11,-1 ,-1,10, 5, 5 , 5, 5, 5, 7, 0 , 0, 8, 4, 4 , 4 , 4 , 4,12,-1,-1},
                {-1, 2, 0, 0, 0 , 0,21 , 0, 1, 1 , 1, 1, 1, 0 ,20, 0, 1, 1 , 1, 6, 5 , 5, 7, 1, 1 , 1, 1, 1, 1, 0 , 0, 3,-1,-1 ,-1 ,-1 ,-1,-1,-1,-1},
                {-1, 2,20, 0,314, 0, 0 , 0, 0, 0 , 0, 0, 0, 0 , 0, 0, 0,313, 0, 1, 1 , 1, 1, 0,325, 0, 0, 0, 0, 0 , 0, 3,-1,-1 ,-1 ,-1 ,-1,-1,-1,-1},
                {-1, 2, 0, 0, 0 ,20, 0 , 0, 0, 0 , 0, 0, 0, 0 , 0, 0, 0, 0 , 0, 0, 0 , 0, 0, 0, 0 ,21, 0, 0,20, 0 , 0, 3,-1,-1 ,-1 ,-1 ,-1,-1,-1,-1},
                {-1,13, 4, 4, 4 , 4, 4 , 4, 4, 4 , 9, 0, 0,20 , 0, 0, 0,20 , 0, 0, 0 , 0, 0, 0, 0 , 0, 0, 0, 0, 0 , 0, 3,-1,-1 ,-1 ,-1 ,-1,-1,-1,-1},
                {-1,-1,-1,-1,-1 ,-1,-1 ,-1,-1,-1 , 2, 0, 0, 0 , 0, 0, 0, 0 , 0, 8, 4 , 4, 9, 0, 0 , 0, 0, 0, 0, 0 , 0, 3,-1,-1 ,-1 ,-1 ,-1,-1,-1,-1},
                {-1,-1,-1,-1,-1 ,-1,-1 ,-1,-1,-1 , 2, 0, 0,326, 0, 0,20, 0 , 0, 3,-1 ,-1, 2, 0,20 , 0,21, 0, 0,312, 0, 3,-1,-1 ,-1 ,-1 ,-1,-1,-1,-1},
                {-1,-1,-1,-1,-1 ,-1,-1 ,-1,-1,-1 , 2, 0, 0, 0 , 0, 0, 0, 0 , 0, 3,-1 ,-1, 2, 0, 0 , 0, 0, 0, 0, 0 , 0, 3,-1,-1 ,-1 ,-1 ,-1,-1,-1,-1},
                {-1,-1,-1,-1,-1 ,-1,-1 ,-1,-1,-1 ,13, 4, 4, 4 , 4, 4, 4, 4 , 4,12,-1 ,-1,13, 4, 4 , 4, 4, 4, 4, 4 , 4,12,-1,-1 ,-1 ,-1 ,-1,-1,-1,-1},
                {-1,-1,-1,-1,-1 ,-1,-1 ,-1,-1,-1 ,-1,-1,-1,-1 ,-1,-1,-1,-1 ,-1,-1,-1 ,-1,-1,-1,-1 ,-1,-1,-1,-1,-1 ,-1,-1,-1,-1 ,-1 ,-1 ,-1,-1,-1,-1},
            };
        }

        public static bool ItemInt(Rectangle Pl, Rectangle I)
        {
            if (Pl.IntersectsWith(I))
            {
                return false;
            }

            return true;
        }
        public static void DisplayHP(Graphics g, Entity q)
        {
            switch (q.HP)
            {
                case 6:
                    g.DrawImage(spriteSheet, new Rectangle(new Point(0, 0), new Size(cellSize*3, cellSize)), 160, 48, 96, 32, GraphicsUnit.Pixel);
                    break;
                case 5:
                    g.DrawImage(spriteSheet, new Rectangle(new Point(0, 0), new Size(cellSize*3, cellSize)), 160, 80, 96, 32, GraphicsUnit.Pixel);
                    break;
                case 4:
                    g.DrawImage(spriteSheet, new Rectangle(new Point(0, 0), new Size(cellSize*3, cellSize)), 160, 112, 96, 32, GraphicsUnit.Pixel);
                    break;
                case 3:
                    g.DrawImage(spriteSheet, new Rectangle(new Point(0, 0), new Size(cellSize*3, cellSize)), 160, 142, 96, 32, GraphicsUnit.Pixel);
                    break;
                case 2:
                    g.DrawImage(spriteSheet, new Rectangle(new Point(0, 0), new Size(cellSize*3, cellSize)), 160, 174, 96, 32, GraphicsUnit.Pixel);
                    break;
                case 1:
                    g.DrawImage(spriteSheet, new Rectangle(new Point(0, 0), new Size(cellSize*3, cellSize)), 160, 206, 96, 32, GraphicsUnit.Pixel);
                    break;
                case 0:
                    g.DrawImage(spriteSheet, new Rectangle(new Point(0, 0), new Size(cellSize*3, cellSize)), 160, 238, 96, 32, GraphicsUnit.Pixel);
                    break;
            }
        }

        public static void SeedMap(Graphics g, bool RB1, bool RB2, bool RB3, bool RB4, bool BB1, bool BB2, bool BB3, bool BB4, bool P1, bool P2, bool P3, bool P4, bool P5, bool P6)
        {
            for (int i = 0; i < mapHeight; i++)
            {
                for (int j = 0; j < mapWidth; j++)
                {
                    if (map[i, j] == 20)//cranium
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 64, 288, 32, 32, GraphicsUnit.Pixel);
                    }
                    else
                    if (map[i, j] == 21)//torches
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 64, 320, 32, 32, GraphicsUnit.Pixel);
                    }
                    else
                    if (map[i, j] == 301)//red buttons
                    {
                        if (RB1)
                        {
                            g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 0, 256, 32, 32, GraphicsUnit.Pixel);
                        }
                        else
                        {
                            g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 32, 256, 32, 32, GraphicsUnit.Pixel);
                        }
                        
                    }
                    else
                    if (map[i, j] == 302)//red buttons
                    {
                        if (RB2)
                        {
                            g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 0, 256, 32, 32, GraphicsUnit.Pixel);
                        }
                        else
                        {
                            g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 32, 256, 32, 32, GraphicsUnit.Pixel);
                        }
                    }
                    else
                    if (map[i, j] == 303)//red buttons
                    {
                        if (RB3)
                        {
                            g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 0, 256, 32, 32, GraphicsUnit.Pixel);
                        }
                        else
                        {
                            g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 32, 256, 32, 32, GraphicsUnit.Pixel);
                        }
                    }
                    else
                    if (map[i, j] == 304)//red buttons
                    {
                        if (RB4)
                        {
                            g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 0, 256, 32, 32, GraphicsUnit.Pixel);
                        }
                        else
                        {
                            g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 32, 256, 32, 32, GraphicsUnit.Pixel);
                        }
                    }
                    else
                    if (map[i, j] == 311)//blue buttons
                    {
                        if (BB1)
                        {
                            g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 0, 288, 32, 32, GraphicsUnit.Pixel);
                        }
                        else
                        {
                            g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 32, 288, 32, 32, GraphicsUnit.Pixel);
                        }
                    }
                    else
                    if (map[i, j] == 312)//blue buttons
                    {
                        if (BB2)
                        {
                            g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 0, 288, 32, 32, GraphicsUnit.Pixel);
                        }
                        else
                        {
                            g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 32, 288, 32, 32, GraphicsUnit.Pixel);
                        }
                    }
                    else
                    if (map[i, j] == 313)//blue buttons
                    {
                        if (BB3)
                        {
                            g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 0, 288, 32, 32, GraphicsUnit.Pixel);
                        }
                        else
                        {
                            g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 32, 288, 32, 32, GraphicsUnit.Pixel);
                        }
                    }
                    else
                    if (map[i, j] == 314)//blue buttons
                    {
                        if (BB4)
                        {
                            g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 0, 288, 32, 32, GraphicsUnit.Pixel);
                        }
                        else
                        {
                            g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 32, 288, 32, 32, GraphicsUnit.Pixel);
                        }
                    }
                    else
                    if (map[i, j] == 321)//potion
                    {
                        if (P1)
                        {
                            g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 64, 256, 32, 32, GraphicsUnit.Pixel);
                        }
                        else
                        {
                            g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 32, 128, 32, 32, GraphicsUnit.Pixel);
                        }
                    }
                    else
                    if (map[i, j] == 322)//potion
                    {
                        if (P2)
                        {
                            g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 64, 256, 32, 32, GraphicsUnit.Pixel);
                        }
                        else
                        {
                            g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 32, 128, 32, 32, GraphicsUnit.Pixel);
                        }
                    }
                    else
                    if (map[i, j] == 323)//potion
                    {
                        if (P3)
                        {
                            g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 64, 256, 32, 32, GraphicsUnit.Pixel);
                        }
                        else
                        {
                            g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 32, 128, 32, 32, GraphicsUnit.Pixel);
                        }
                    }
                    else
                    if (map[i, j] == 324)//potion
                    {
                        if (P4)
                        {
                            g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 64, 256, 32, 32, GraphicsUnit.Pixel);
                        }
                        else
                        {
                            g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 32, 128, 32, 32, GraphicsUnit.Pixel);
                        }
                    }
                    else
                    if (map[i, j] == 325)//potion
                    {
                        if (P5)
                        {
                            g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 64, 256, 32, 32, GraphicsUnit.Pixel);
                        }
                        else
                        {
                            g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 32, 128, 32, 32, GraphicsUnit.Pixel);
                        }
                    }
                    else
                    if (map[i, j] == 326)//potion
                    {
                        if (P6)
                        {
                            g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 64, 256, 32, 32, GraphicsUnit.Pixel);
                        }
                        else
                        {
                            g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 32, 128, 32, 32, GraphicsUnit.Pixel);
                        }
                    }
                    else
                    if (map[i, j] == 33)//exit
                    {
                        if (!RB1 && !RB2 && !RB3 && !RB4 && !BB1 && !BB2 && !BB3 && !BB4)
                        {
                            g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 32, 320, 32, 32, GraphicsUnit.Pixel);
                        }
                        else
                        {
                            g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 32, 128, 32, 32, GraphicsUnit.Pixel);
                        }
                    }
                    else
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 0, 0, 1, 1, GraphicsUnit.Pixel);
                    }

                }
            }
        }
        public static void DrawMap(Graphics g)
        {
            for (int i = 0; i < mapHeight; i++)
            {
                for (int j = 0; j < mapWidth; j++)
                {
                    if (map[i, j] == 0)
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 32, 128, 32, 32, GraphicsUnit.Pixel);
                    }
                    else
                    if (map[i, j] == 1)
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 64, 32, 32, 32, GraphicsUnit.Pixel);
                    }
                    else
                    if (map[i, j] == 2)
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 0, 224, 32, 32, GraphicsUnit.Pixel);
                    }
                    else
                    if (map[i, j] == 3)
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 32, 224, 32, 32, GraphicsUnit.Pixel);
                    }
                    else
                    if (map[i, j] == 4)
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 64, 0, 32, 32, GraphicsUnit.Pixel);
                    }
                    else
                    if (map[i, j] == 5)
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 32, 0, 32, 32, GraphicsUnit.Pixel);
                    }
                    else
                    if (map[i, j] == 6)
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 64, 64, 32, 32, GraphicsUnit.Pixel);
                    }
                    else
                    if (map[i, j] == 7)
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 96, 64, 32, 32, GraphicsUnit.Pixel);
                    }
                    else
                    if (map[i, j] == 8)
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 64, 96, 32, 32, GraphicsUnit.Pixel);
                    }
                    else
                    if (map[i, j] == 9)
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 96, 96, 32, 32, GraphicsUnit.Pixel);
                    }
                    else
                    if (map[i, j] == 10)
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 0, 32, 32, 32, GraphicsUnit.Pixel);
                    }
                    else
                    if (map[i, j] == 11)
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 0, 0, 32, 32, GraphicsUnit.Pixel);
                    }
                    else
                    if (map[i, j] == 12)
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 0, 64, 32, 32, GraphicsUnit.Pixel);
                    }
                    else 
                    if (map[i, j] == 13)
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 0, 96, 32, 32, GraphicsUnit.Pixel);
                    }
                    else
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(j * cellSize, i * cellSize), new Size(cellSize, cellSize)), 0, 0, 1, 1, GraphicsUnit.Pixel);
                    }
                }
            }
        }
     }
}
