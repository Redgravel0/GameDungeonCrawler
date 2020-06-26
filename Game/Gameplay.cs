using Game.Controllers;
using Game.Entites;
using Game.Models;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Game
{
    public partial class Gameplay : Form
    {
        public bool fire;
        public static string facing = "right";
        public Image MainHeroSheet;
        public Image impSheet;
        public Image SkeletSheet;
        public Image SlimeSheet;
        public Graphics g;

        public Entity FireBall;
        public Entity player;
        public Entity imp1;
        public Entity imp2;
        public Entity imp3;
        public Entity imp4;
        public Entity imp5;
        public Entity imp6;
        public Entity imp7;
        public Entity imp8;
        public Entity Skelet1;
        public Entity Skelet2;
        public Entity Skelet3;
        public Entity Skelet4;
        public Entity Skelet5;
        public Entity Skelet6;
        public Entity Skelet7;
        public Entity Skelet8;
        public Entity Slime1;
        public Entity Slime2;
        public Entity Slime3;
        public Entity Slime4;
        public Entity Slime5;

        public static bool Col1;
        public static bool Col2;
        public static bool Col3;
        public static bool Col4;

        public static bool RB1 = true;
        public Rectangle RedBut1 = new Rectangle(new Point(288, 96), new Size(32, 32));
        public static bool RB2 = true;
        public Rectangle RedBut2 = new Rectangle(new Point(544, 256), new Size(32, 32));
        public static bool RB3 = true;
        public Rectangle RedBut3 = new Rectangle(new Point(1120, 640), new Size(32, 32));
        public static bool RB4 = true;
        public Rectangle RedBut4 = new Rectangle(new Point(192, 672), new Size(32, 32));
        public static bool BB1 = true;
        public Rectangle BlueBut1 = new Rectangle(new Point(928, 288), new Size(32, 32));
        public static bool BB2 = true;
        public Rectangle BlueBut2 = new Rectangle(new Point(928, 896), new Size(32, 32));
        public static bool BB3 = true;
        public Rectangle BlueBut3 = new Rectangle(new Point(544, 768), new Size(32, 32));
        public static bool BB4 = true;
        public Rectangle BlueBut4 = new Rectangle(new Point(128, 768), new Size(32, 32));
        public static bool P1 = true;
        public Rectangle Potion1 = new Rectangle(new Point(544, 128), new Size(32, 32));
        public static bool P2 = true;
        public Rectangle Potion2 = new Rectangle(new Point(640, 160), new Size(32, 32));
        public static bool P3 = true;
        public Rectangle Potion3 = new Rectangle(new Point(1088, 512), new Size(32, 32));
        public static bool P4 = true;
        public Rectangle Potion4 = new Rectangle(new Point(1056, 672), new Size(32, 32));
        public static bool P5 = true;
        public Rectangle Potion5 = new Rectangle(new Point(768, 768), new Size(32, 32));
        public static bool P6 = true;
        public Rectangle Potion6 = new Rectangle(new Point(416, 896), new Size(32, 32));
        public Rectangle PExit = new Rectangle(new Point(448, 544), new Size(32, 32));


        public Rectangle q;
        public Rectangle room1 = new Rectangle(new Point(64, 64), new Size(256, 224));
        public Rectangle room2 = new Rectangle(new Point(448, 64), new Size(256, 224));
        public Rectangle room3 = new Rectangle(new Point(800, 192), new Size(256, 224));
        public Rectangle room4 = new Rectangle(new Point(928, 480), new Size(256, 224));
        public Rectangle room5 = new Rectangle(new Point(736, 736), new Size(256, 224));
        public Rectangle room6 = new Rectangle(new Point(352, 736), new Size(256, 224));
        public Rectangle room7 = new Rectangle(new Point(64, 608), new Size(192, 224));
        public Rectangle room8 = new Rectangle(new Point(352, 416), new Size(224, 192));

        public Rectangle wu1 = new Rectangle(new Point(64, 32), new Size(256, 32));
        public Rectangle wu2 = new Rectangle(new Point(352, 64), new Size(64, 32));
        public Rectangle wu3 = new Rectangle(new Point(448, 32), new Size(256, 32));
        public Rectangle wu4 = new Rectangle(new Point(736, 160), new Size(320, 32));
        public Rectangle wu5 = new Rectangle(new Point(1056, 448), new Size(128, 32));
        public Rectangle wu6 = new Rectangle(new Point(737, 704), new Size(160, 32));
        public Rectangle wu7 = new Rectangle(new Point(640, 736), new Size(64, 32));
        public Rectangle wu8 = new Rectangle(new Point(544, 704), new Size(64, 32));
        public Rectangle wu9 = new Rectangle(new Point(288, 704), new Size(96, 32));
        public Rectangle wu10 = new Rectangle(new Point(64, 576), new Size(192, 32));
        public Rectangle wu11 = new Rectangle(new Point(352, 384), new Size(224, 32));

        public Rectangle wl1 = new Rectangle(new Point(32, 64), new Size(32, 256));
        public Rectangle wl2 = new Rectangle(new Point(416, 224), new Size(32, 64));
        public Rectangle wl3 = new Rectangle(new Point(768, 320), new Size(32, 96));
        public Rectangle wl4 = new Rectangle(new Point(896, 480), new Size(32, 224));
        public Rectangle wl5 = new Rectangle(new Point(704, 896), new Size(32, 64));
        public Rectangle wl6 = new Rectangle(new Point(384, 640), new Size(32, 64));
        public Rectangle wl7 = new Rectangle(new Point(320, 896), new Size(32, 96));
        public Rectangle wl8 = new Rectangle(new Point(32, 608), new Size(32, 224));
        public Rectangle wl9 = new Rectangle(new Point(320, 416), new Size(32, 192));

        public Rectangle wr1 = new Rectangle(new Point(320, 224), new Size(32, 64));
        public Rectangle wr2 = new Rectangle(new Point(704, 64), new Size(32, 96));
        public Rectangle wr3 = new Rectangle(new Point(1056, 192), new Size(32, 224));
        public Rectangle wr4 = new Rectangle(new Point(1184, 480), new Size(32, 224));
        public Rectangle wr5 = new Rectangle(new Point(992, 736), new Size(32, 224));
        public Rectangle wr6 = new Rectangle(new Point(608, 896), new Size(32, 64));
        public Rectangle wr7 = new Rectangle(new Point(512, 640), new Size(32, 64));
        public Rectangle wr8 = new Rectangle(new Point(256, 608), new Size(32, 96));
        public Rectangle wr9 = new Rectangle(new Point(576, 416), new Size(32, 192));

        public Rectangle wd1 = new Rectangle(new Point(64, 288), new Size(256, 32));
        public Rectangle wd2 = new Rectangle(new Point(352, 192), new Size(64, 32));
        public Rectangle wd3 = new Rectangle(new Point(448, 288), new Size(320, 32));
        public Rectangle wd4 = new Rectangle(new Point(800, 416), new Size(128, 32));
        public Rectangle wd5 = new Rectangle(new Point(1024, 704), new Size(160, 32));
        public Rectangle wd6 = new Rectangle(new Point(736, 960), new Size(256, 32));
        public Rectangle wd7 = new Rectangle(new Point(640, 864), new Size(64, 32));
        public Rectangle wd8 = new Rectangle(new Point(352, 960), new Size(256, 32));
        public Rectangle wd9 = new Rectangle(new Point(64, 832), new Size(256, 32));
        public Rectangle wd10 = new Rectangle(new Point(352, 608), new Size(32, 32));
        public Rectangle wd11 = new Rectangle(new Point(544, 608), new Size(32, 32));

        public Rectangle wdl1 = new Rectangle(new Point(320, 64), new Size(32, 32));
        public Rectangle wdl2 = new Rectangle(new Point(704, 160), new Size(32, 32));
        public Rectangle wdl3 = new Rectangle(new Point(1024, 448), new Size(32, 32));
        public Rectangle wdl4 = new Rectangle(new Point(608, 736), new Size(32, 32));
        public Rectangle wdl5 = new Rectangle(new Point(512, 704), new Size(32, 32));
        public Rectangle wdl6 = new Rectangle(new Point(256, 704), new Size(32, 32));

        public Rectangle wur1 = new Rectangle(new Point(416, 192), new Size(32, 32));
        public Rectangle wur2 = new Rectangle(new Point(769, 288), new Size(32, 32));
        public Rectangle wur3 = new Rectangle(new Point(928, 416), new Size(32, 32));
        public Rectangle wur4 = new Rectangle(new Point(704, 864), new Size(32, 32));
        public Rectangle wur5 = new Rectangle(new Point(320, 832), new Size(32, 32));
        public Rectangle wur6 = new Rectangle(new Point(384, 608), new Size(32, 32));

        public Rectangle wul1 = new Rectangle(new Point(320, 192), new Size(32, 32));
        public Rectangle wul2 = new Rectangle(new Point(1024, 416), new Size(32, 32));
        public Rectangle wul3 = new Rectangle(new Point(992, 704), new Size(32, 32));
        public Rectangle wul4 = new Rectangle(new Point(608, 864), new Size(32, 32));
        public Rectangle wul5 = new Rectangle(new Point(512, 608), new Size(32, 32));

        public Rectangle wdr1 = new Rectangle(new Point(416, 64), new Size(32, 32));
        public Rectangle wdr2 = new Rectangle(new Point(928, 448), new Size(32, 32));
        public Rectangle wdr3 = new Rectangle(new Point(896, 704), new Size(32, 32));
        public Rectangle wdr4 = new Rectangle(new Point(704, 736), new Size(32, 32));
        public Rectangle wdr5 = new Rectangle(new Point(384, 704), new Size(32, 32));

        public Label LabelDeath = new Label();
        public Label LabelWin = new Label();
        public Button button_exit = new Button();
        public Button button_back_in_menu = new Button();

        public static FontFamily fontFamily = new FontFamily("Comic Sans MS");

        public Font fontlable = new Font(
            fontFamily,
            162,
            FontStyle.Bold,
            GraphicsUnit.Pixel);

        public Font fontbutton = new Font(
            fontFamily,
            24,
            FontStyle.Bold,
            GraphicsUnit.Pixel);


        public Gameplay()
        {
            InitializeComponent();
            timer1.Interval = 60;
            timer1.Tick += new EventHandler(Update);
            timer2.Interval = 900;
            timer2.Tick += new EventHandler(UpdateCollisionPl);
            timer3.Interval = 1;
            timer3.Tick += new EventHandler(UpdateCollisionFB);
            timer4.Interval = 1;
            timer4.Tick += new EventHandler(UpdateCollision);
            KeyDown += new KeyEventHandler(KeyPress);
            KeyUp += new KeyEventHandler(KeyUnPress);
            InitMesg();
            Init();
        }

        public void KeyUnPress(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    player.dirY = 0;
                    break;
                case Keys.S:
                    player.dirY = 0;
                    break;
                case Keys.A:
                    player.dirX = 0;
                    break;
                case Keys.D:
                    player.dirX = 0;
                    break;
            }

            if (player.dirX == 0 && player.dirY == 0)
            {
                player.isMoving = false;
                player.SetAnimationConfiguration(0);
            }
        }

        public void Exit(object sender, EventArgs e)
        {
            Close();
        }

        public void Back_in_menu(object sender, EventArgs e)
        {
            MainMenu a = new MainMenu();
            this.Hide();
            a.ShowDialog();
            this.Show();
            Close();
        }

        public void InitMesg()
        {
            button_back_in_menu.Location = new Point(200, 450);
            button_back_in_menu.BackColor = Color.Crimson;
            button_back_in_menu.Size = new Size(312, 50);
            button_back_in_menu.Text = "Вернуться в меню";
            button_back_in_menu.Font = fontbutton;
            button_back_in_menu.ForeColor = Color.Black;
            this.Controls.Add(button_back_in_menu);
            button_back_in_menu.Click += new EventHandler(Back_in_menu);
            button_back_in_menu.Enabled = false;
            button_back_in_menu.Visible = false;

            button_exit.Location = new Point(740, 450);
            button_exit.BackColor = Color.Crimson;
            button_exit.Size = new Size(312, 50);
            button_exit.Text = "Покинуть игру";
            button_exit.Font = fontbutton;
            button_exit.ForeColor = Color.Black;
            this.Controls.Add(button_exit);
            button_exit.Click += new EventHandler(Exit);
            button_exit.Enabled = false;
            button_exit.Visible = false;

            LabelDeath.Location = new Point(25, 200);
            LabelDeath.AutoSize = true;
            LabelDeath.BackColor = Color.Transparent;
            LabelDeath.Text = "Вы проиграли";
            LabelDeath.ForeColor = Color.Crimson;
            LabelDeath.Font = fontlable;
            this.Controls.Add(LabelDeath);
            LabelDeath.Enabled = false;
            LabelDeath.Visible = false;

            LabelWin.Location = new Point(50, 200);
            LabelWin.AutoSize = true;
            LabelWin.BackColor = Color.Transparent;
            LabelWin.Text = "Вы победили";
            LabelWin.ForeColor = Color.Crimson;
            LabelWin.Font = fontlable;
            this.Controls.Add(LabelWin);
            LabelWin.Enabled = false;
            LabelWin.Visible = false;
        }

        public void UpdateCollision(object sender, EventArgs e)
        {
            Col1 = !q.IntersectsWith(wu1) && !q.IntersectsWith(wu2) && !q.IntersectsWith(wu3) &&
                   !q.IntersectsWith(wu4) && !q.IntersectsWith(wu5) &&
                   !q.IntersectsWith(wu6) && !q.IntersectsWith(wu7) && !q.IntersectsWith(wu8) &&
                   !q.IntersectsWith(wu9) && !q.IntersectsWith(wu10) && !q.IntersectsWith(wu11) &&
                   !q.IntersectsWith(wl1) && !q.IntersectsWith(wl2) && !q.IntersectsWith(wl3) &&
                   !q.IntersectsWith(wl4) && !q.IntersectsWith(wl5) &&
                   !q.IntersectsWith(wl6) && !q.IntersectsWith(wl7) && !q.IntersectsWith(wl8) &&
                   !q.IntersectsWith(wl9) &&
                   !q.IntersectsWith(wr1) && !q.IntersectsWith(wr2) && !q.IntersectsWith(wr3) &&
                   !q.IntersectsWith(wr4) &&
                   !q.IntersectsWith(wr5) && !q.IntersectsWith(wr6) && !q.IntersectsWith(wr7) &&
                   !q.IntersectsWith(wr8) && !q.IntersectsWith(wr9) &&
                   !q.IntersectsWith(wdl1) && !q.IntersectsWith(wdl2) && !q.IntersectsWith(wdl3) &&
                   !q.IntersectsWith(wdl4) && !q.IntersectsWith(wdl5) && !q.IntersectsWith(wdl6) &&
                   !q.IntersectsWith(wdr1) && !q.IntersectsWith(wdr2) && !q.IntersectsWith(wdr3) &&
                   !q.IntersectsWith(wdr4) && !q.IntersectsWith(wdr5);

            Col2 = !q.IntersectsWith(wd1) && !q.IntersectsWith(wd2) && !q.IntersectsWith(wd3) &&
                   !q.IntersectsWith(wd4) && !q.IntersectsWith(wd5) &&
                   !q.IntersectsWith(wd6) && !q.IntersectsWith(wd7) && !q.IntersectsWith(wd8) &&
                   !q.IntersectsWith(wd9) && !q.IntersectsWith(wd10) && !q.IntersectsWith(wd11) &&
                   !q.IntersectsWith(wl1) && !q.IntersectsWith(wl2) && !q.IntersectsWith(wl3) &&
                   !q.IntersectsWith(wl4) && !q.IntersectsWith(wl5) &&
                   !q.IntersectsWith(wl6) && !q.IntersectsWith(wl7) && !q.IntersectsWith(wl8) &&
                   !q.IntersectsWith(wl9) &&
                   !q.IntersectsWith(wr1) && !q.IntersectsWith(wr2) && !q.IntersectsWith(wr3) &&
                   !q.IntersectsWith(wr4) &&
                   !q.IntersectsWith(wr5) && !q.IntersectsWith(wr6) && !q.IntersectsWith(wr7) &&
                   !q.IntersectsWith(wr8) && !q.IntersectsWith(wr9) &&
                   !q.IntersectsWith(wul1) && !q.IntersectsWith(wul2) && !q.IntersectsWith(wul3) &&
                   !q.IntersectsWith(wul4) && !q.IntersectsWith(wul5) &&
                   !q.IntersectsWith(wur1) && !q.IntersectsWith(wur2) && !q.IntersectsWith(wur3) &&
                   !q.IntersectsWith(wur4) && !q.IntersectsWith(wur5) && !q.IntersectsWith(wur6);

            Col3 = !q.IntersectsWith(wu1) && !q.IntersectsWith(wu2) && !q.IntersectsWith(wu3) &&
                   !q.IntersectsWith(wu4) && !q.IntersectsWith(wu5) &&
                   !q.IntersectsWith(wu6) && !q.IntersectsWith(wu7) && !q.IntersectsWith(wu8) &&
                   !q.IntersectsWith(wu9) && !q.IntersectsWith(wu10) && !q.IntersectsWith(wu11) &&
                   !q.IntersectsWith(wd1) && !q.IntersectsWith(wd2) && !q.IntersectsWith(wd3) &&
                   !q.IntersectsWith(wd4) && !q.IntersectsWith(wd5) &&
                   !q.IntersectsWith(wd6) && !q.IntersectsWith(wd7) && !q.IntersectsWith(wd8) &&
                   !q.IntersectsWith(wd9) && !q.IntersectsWith(wd10) && !q.IntersectsWith(wd11) &&
                   !q.IntersectsWith(wl1) && !q.IntersectsWith(wl2) && !q.IntersectsWith(wl3) &&
                   !q.IntersectsWith(wl4) && !q.IntersectsWith(wl5) &&
                   !q.IntersectsWith(wl6) && !q.IntersectsWith(wl7) && !q.IntersectsWith(wl8) &&
                   !q.IntersectsWith(wl9) &&
                   !q.IntersectsWith(wdr1) && !q.IntersectsWith(wdr2) && !q.IntersectsWith(wdr3) &&
                   !q.IntersectsWith(wdr4) && !q.IntersectsWith(wdr5) &&
                   !q.IntersectsWith(wur1) && !q.IntersectsWith(wur2) && !q.IntersectsWith(wur3) &&
                   !q.IntersectsWith(wur4) && !q.IntersectsWith(wur5) && !q.IntersectsWith(wur6);

            Col4 = !q.IntersectsWith(wu1) && !q.IntersectsWith(wu2) && !q.IntersectsWith(wu3) &&
                   !q.IntersectsWith(wu4) && !q.IntersectsWith(wu5) &&
                   !q.IntersectsWith(wu6) && !q.IntersectsWith(wu7) && !q.IntersectsWith(wu8) &&
                   !q.IntersectsWith(wu9) && !q.IntersectsWith(wu10) && !q.IntersectsWith(wu11) &&
                   !q.IntersectsWith(wd1) && !q.IntersectsWith(wd2) && !q.IntersectsWith(wd3) &&
                   !q.IntersectsWith(wd4) && !q.IntersectsWith(wd5) &&
                   !q.IntersectsWith(wd6) && !q.IntersectsWith(wd7) && !q.IntersectsWith(wd8) &&
                   !q.IntersectsWith(wd9) && !q.IntersectsWith(wd10) && !q.IntersectsWith(wd11) &&
                   !q.IntersectsWith(wr1) && !q.IntersectsWith(wr2) && !q.IntersectsWith(wr3) &&
                   !q.IntersectsWith(wr4) &&
                   !q.IntersectsWith(wr5) && !q.IntersectsWith(wr6) && !q.IntersectsWith(wr7) &&
                   !q.IntersectsWith(wr8) && !q.IntersectsWith(wr9) &&
                   !q.IntersectsWith(wdl1) && !q.IntersectsWith(wdl2) && !q.IntersectsWith(wdl3) &&
                   !q.IntersectsWith(wdl4) && !q.IntersectsWith(wdl5) && !q.IntersectsWith(wdl6) &&
                   !q.IntersectsWith(wul1) && !q.IntersectsWith(wul2) && !q.IntersectsWith(wul3) &&
                   !q.IntersectsWith(wul4) && !q.IntersectsWith(wul5);

            if (q.IntersectsWith(wu1) && q.IntersectsWith(wu2) && q.IntersectsWith(wu3) && q.IntersectsWith(wu4) &&
                q.IntersectsWith(wu5) &&
                q.IntersectsWith(wu6) && q.IntersectsWith(wu7) && q.IntersectsWith(wu8) && q.IntersectsWith(wu9) &&
                q.IntersectsWith(wu10) && q.IntersectsWith(wu11) &&
                q.IntersectsWith(wl1) && q.IntersectsWith(wl2) && q.IntersectsWith(wl3) && q.IntersectsWith(wl4) &&
                q.IntersectsWith(wl5) &&
                q.IntersectsWith(wl6) && q.IntersectsWith(wl7) && q.IntersectsWith(wl8) && q.IntersectsWith(wl9))
            {
                player.isMoving = true;
                player.dirX = 8;
                player.dirY = 8;
            }

            if (q.IntersectsWith(wd1) && q.IntersectsWith(wd2) && q.IntersectsWith(wd3) && q.IntersectsWith(wd4) &&
                q.IntersectsWith(wd5) &&
                q.IntersectsWith(wd6) && q.IntersectsWith(wd7) && q.IntersectsWith(wd8) && q.IntersectsWith(wd9) &&
                q.IntersectsWith(wd10) && q.IntersectsWith(wd11) &&
                q.IntersectsWith(wr1) && q.IntersectsWith(wr2) && q.IntersectsWith(wr3) && q.IntersectsWith(wr4) &&
                q.IntersectsWith(wr5) && q.IntersectsWith(wr6) && q.IntersectsWith(wr7) && q.IntersectsWith(wr8) &&
                q.IntersectsWith(wr9))
            {
                player.isMoving = true;
                player.dirX = -8;
                player.dirY = -8;
            }

            if (q.IntersectsWith(wu1) && q.IntersectsWith(wu2) && q.IntersectsWith(wu3) && q.IntersectsWith(wu4) &&
                q.IntersectsWith(wu5) &&
                q.IntersectsWith(wu6) && q.IntersectsWith(wu7) && q.IntersectsWith(wu8) && q.IntersectsWith(wu9) &&
                q.IntersectsWith(wu10) && q.IntersectsWith(wu11) &&
                q.IntersectsWith(wr1) && q.IntersectsWith(wr2) && q.IntersectsWith(wr3) && q.IntersectsWith(wr4) &&
                q.IntersectsWith(wr5) && q.IntersectsWith(wr6) && q.IntersectsWith(wr7) && q.IntersectsWith(wr8) &&
                q.IntersectsWith(wr9))
            {
                player.isMoving = true;
                player.dirX = -8;
                player.dirY = 8;
            }

            if (q.IntersectsWith(wd1) && q.IntersectsWith(wd2) && q.IntersectsWith(wd3) && q.IntersectsWith(wd4) &&
                q.IntersectsWith(wd5) &&
                q.IntersectsWith(wd6) && q.IntersectsWith(wd7) && q.IntersectsWith(wd8) && q.IntersectsWith(wd9) &&
                q.IntersectsWith(wd10) && q.IntersectsWith(wd11) &&
                q.IntersectsWith(wl1) && q.IntersectsWith(wl2) && q.IntersectsWith(wl3) && q.IntersectsWith(wl4) &&
                q.IntersectsWith(wl5) &&
                q.IntersectsWith(wl6) && q.IntersectsWith(wl7) && q.IntersectsWith(wl8) && q.IntersectsWith(wl9))
            {
                player.isMoving = true;
                player.dirX = 8;
                player.dirY = -8;
            }
        }

        public bool FBInterect(Entity FireBall)
        {
            Rectangle fireball1 = new Rectangle(FireBall.posX, FireBall.posY, 5, 5);
            if (fireball1.IntersectsWith(wu1) || fireball1.IntersectsWith(wu2) || fireball1.IntersectsWith(wu3) ||
                fireball1.IntersectsWith(wu4) || fireball1.IntersectsWith(wu5) ||
                fireball1.IntersectsWith(wu6) || fireball1.IntersectsWith(wu7) || fireball1.IntersectsWith(wu8) ||
                fireball1.IntersectsWith(wu9) || fireball1.IntersectsWith(wu10) || fireball1.IntersectsWith(wu11) ||
                fireball1.IntersectsWith(wr1) || fireball1.IntersectsWith(wr2) || fireball1.IntersectsWith(wr3) ||
                fireball1.IntersectsWith(wr4) || fireball1.IntersectsWith(wr5) ||
                fireball1.IntersectsWith(wr6) || fireball1.IntersectsWith(wr7) || fireball1.IntersectsWith(wr8) ||
                fireball1.IntersectsWith(wr9) ||
                fireball1.IntersectsWith(wl1) || fireball1.IntersectsWith(wl2) || fireball1.IntersectsWith(wl3) ||
                fireball1.IntersectsWith(wl4) || fireball1.IntersectsWith(wl5) ||
                fireball1.IntersectsWith(wl6) || fireball1.IntersectsWith(wl7) || fireball1.IntersectsWith(wl8) ||
                fireball1.IntersectsWith(wl9) ||
                fireball1.IntersectsWith(wd1) || fireball1.IntersectsWith(wd2) || fireball1.IntersectsWith(wd3) ||
                fireball1.IntersectsWith(wd4) || fireball1.IntersectsWith(wd5) ||
                fireball1.IntersectsWith(wd6) || fireball1.IntersectsWith(wd7) || fireball1.IntersectsWith(wd8) ||
                fireball1.IntersectsWith(wd9) || fireball1.IntersectsWith(wd10) || fireball1.IntersectsWith(wd11) ||
                fireball1.IntersectsWith(wur1) || fireball1.IntersectsWith(wur2) || fireball1.IntersectsWith(wur3) ||
                fireball1.IntersectsWith(wur4) || fireball1.IntersectsWith(wur5) || fireball1.IntersectsWith(wur6) ||
                fireball1.IntersectsWith(wdr1) || fireball1.IntersectsWith(wdr2) || fireball1.IntersectsWith(wdr3) ||
                fireball1.IntersectsWith(wdr4) || fireball1.IntersectsWith(wdr5) ||
                fireball1.IntersectsWith(wdl1) || fireball1.IntersectsWith(wdl2) || fireball1.IntersectsWith(wdl3) ||
                fireball1.IntersectsWith(wdl4) || fireball1.IntersectsWith(wdl5) || fireball1.IntersectsWith(wdl6) ||
                fireball1.IntersectsWith(wul1) || fireball1.IntersectsWith(wul2) || fireball1.IntersectsWith(wul3) ||
                fireball1.IntersectsWith(wul4) || fireball1.IntersectsWith(wul5))
                return true;
            else return false;
        }

        public new void KeyPress(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    if (Col1)
                    {
                        player.isMoving = true;
                    }
                    else
                    {
                        player.isMoving = false;
                    }

                    player.dirY = -4;
                    facing = "up";
                    player.SetAnimationConfiguration(1);
                    break;
                case Keys.S:
                {
                    if (Col2)
                    {
                        player.isMoving = true;
                    }
                    else
                    {
                        player.isMoving = false;
                    }

                    player.dirY = 4;
                    facing = "down";
                    player.SetAnimationConfiguration(1);
                    break;
                }
                case Keys.A:
                    if (Col3)
                    {
                        player.isMoving = true;
                    }
                    else
                    {
                        player.isMoving = false;
                    }

                    player.dirX = -4;
                    facing = "left";
                    player.flip = -1;
                    player.SetAnimationConfiguration(1);
                    break;
                case Keys.D:
                    if (Col4)
                    {
                        player.isMoving = true;
                    }
                    else
                    {
                        player.isMoving = false;
                    }

                    player.dirX = 4;
                    facing = "right";
                    player.flip = 1;
                    player.SetAnimationConfiguration(1);
                    break;
                case Keys.Space:

                    player.SetAnimationConfiguration(2);
                    fire = true;
                    player.SetAnimationConfiguration(1);

                    break;
            }
        }

        public void Init()
        {
            MapController.Init();

            Width = 1280;
            Height = 1024;


            MainHeroSheet =
                new Bitmap(Path.Combine(
                    new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(),
                    "Sprites\\DinoMH.png"));
            impSheet = new Bitmap(Path.Combine(
                new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(),
                "Sprites\\imp.png"));
            SkeletSheet =
                new Bitmap(Path.Combine(
                    new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(),
                    "Sprites\\Skelet.png"));
            SlimeSheet =
                new Bitmap(Path.Combine(
                    new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(),
                    "Sprites\\Slime.png"));

            FireBall = new Entity(0, 0, 0, 0, 0, null, 0);
            player = new Entity(94, 160, MainHero.idleFrames, MainHero.runFrames, MainHero.attackFrames, MainHeroSheet,
                6);
            imp1 = new Entity(224, 96, Imp.idleFrames, Imp.runFrames, Imp.attackFrames, impSheet, 1);
            imp2 = new Entity(992, 352, Imp.idleFrames, Imp.runFrames, Imp.attackFrames, impSheet, 1);
            imp3 = new Entity(832, 768, Imp.idleFrames, Imp.runFrames, Imp.attackFrames, impSheet, 1);
            imp4 = new Entity(768, 864, Imp.idleFrames, Imp.runFrames, Imp.attackFrames, impSheet, 1);
            imp5 = new Entity(128, 640, Imp.idleFrames, Imp.runFrames, Imp.attackFrames, impSheet, 1);
            imp6 = new Entity(96, 604, Imp.idleFrames, Imp.runFrames, Imp.attackFrames, impSheet, 1);
            imp7 = new Entity(94, 768, Imp.idleFrames, Imp.runFrames, Imp.attackFrames, impSheet, 1);
            imp8 = new Entity(384, 448, Imp.idleFrames, Imp.runFrames, Imp.attackFrames, impSheet, 1);
            Skelet1 = new Entity(224, 192, Skelet.idleFrames, Skelet.runFrames, Skelet.attackFrames, SkeletSheet, 1);
            Skelet2 = new Entity(960, 224, Skelet.idleFrames, Skelet.runFrames, Skelet.attackFrames, SkeletSheet, 1);
            Skelet3 = new Entity(896, 352, Skelet.idleFrames, Skelet.runFrames, Skelet.attackFrames, SkeletSheet, 1);
            Skelet4 = new Entity(1120, 544, Skelet.idleFrames, Skelet.runFrames, Skelet.attackFrames, SkeletSheet, 1);
            Skelet5 = new Entity(416, 768, Skelet.idleFrames, Skelet.runFrames, Skelet.attackFrames, SkeletSheet, 1);
            Skelet6 = new Entity(448, 864, Skelet.idleFrames, Skelet.runFrames, Skelet.attackFrames, SkeletSheet, 1);
            Skelet7 = new Entity(544, 896, Skelet.idleFrames, Skelet.runFrames, Skelet.attackFrames, SkeletSheet, 1);
            Skelet8 = new Entity(362, 544, Skelet.idleFrames, Skelet.runFrames, Skelet.attackFrames, SkeletSheet, 1);
            Slime1 = new Entity(480, 96, Slime.idleFrames, Slime.runFrames, Slime.attackFrames, SlimeSheet, 1);
            Slime2 = new Entity(480, 224, Slime.idleFrames, Slime.runFrames, Slime.attackFrames, SlimeSheet, 1);
            Slime3 = new Entity(608, 192, Slime.idleFrames, Slime.runFrames, Slime.attackFrames, SlimeSheet, 1);
            Slime4 = new Entity(1056, 608, Slime.idleFrames, Slime.runFrames, Slime.attackFrames, SlimeSheet, 1);
            Slime5 = new Entity(512, 448, Slime.idleFrames, Slime.runFrames, Slime.attackFrames, SlimeSheet, 1);


            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
        }

        public void UpdateCollisionFB(object sender, EventArgs e)
        {
            MobInteraction.CollisionWithFB(FireBall, imp1);
            MobInteraction.CollisionWithFB(FireBall, imp2);
            MobInteraction.CollisionWithFB(FireBall, imp3);
            MobInteraction.CollisionWithFB(FireBall, imp4);
            MobInteraction.CollisionWithFB(FireBall, imp5);
            MobInteraction.CollisionWithFB(FireBall, imp6);
            MobInteraction.CollisionWithFB(FireBall, imp7);
            MobInteraction.CollisionWithFB(FireBall, imp8);
            MobInteraction.CollisionWithFB(FireBall, Skelet1);
            MobInteraction.CollisionWithFB(FireBall, Skelet2);
            MobInteraction.CollisionWithFB(FireBall, Skelet3);
            MobInteraction.CollisionWithFB(FireBall, Skelet4);
            MobInteraction.CollisionWithFB(FireBall, Skelet5);
            MobInteraction.CollisionWithFB(FireBall, Skelet6);
            MobInteraction.CollisionWithFB(FireBall, Skelet7);
            MobInteraction.CollisionWithFB(FireBall, Skelet8);
            MobInteraction.CollisionWithFB(FireBall, Slime1);
            MobInteraction.CollisionWithFB(FireBall, Slime2);
            MobInteraction.CollisionWithFB(FireBall, Slime3);
            MobInteraction.CollisionWithFB(FireBall, Slime4);
            MobInteraction.CollisionWithFB(FireBall, Slime5);
            Entity.MovingMob(player, imp1);
            Entity.MovingMob(player, imp2);
            Entity.MovingMob(player, imp3);
            Entity.MovingMob(player, imp4);
            Entity.MovingMob(player, imp5);
            Entity.MovingMob(player, imp6);
            Entity.MovingMob(player, imp7);
            Entity.MovingMob(player, imp8);
            Entity.MovingMob(player, Skelet1);
            Entity.MovingMob(player, Skelet2);
            Entity.MovingMob(player, Skelet3);
            Entity.MovingMob(player, Skelet4);
            Entity.MovingMob(player, Skelet5);
            Entity.MovingMob(player, Skelet6);
            Entity.MovingMob(player, Skelet7);
            Entity.MovingMob(player, Skelet8);
            Entity.MovingMob(player, Slime1);
            Entity.MovingMob(player, Slime2);
            Entity.MovingMob(player, Slime3);
            Entity.MovingMob(player, Slime4);
            Entity.MovingMob(player, Slime5);
        }

        public void UpdateCollisionPl(object sender, EventArgs e)
        {
            if (RB1)
            {
                RB1 = MapController.ItemInt(q, RedBut1);
            }

            if (RB2)
            {
                RB2 = MapController.ItemInt(q, RedBut2);
            }

            if (RB3)
            {
                RB3 = MapController.ItemInt(q, RedBut3);
            }

            if (RB4)
            {
                RB4 = MapController.ItemInt(q, RedBut4);
            }

            if (BB1)
            {
                BB1 = MapController.ItemInt(q, BlueBut1);
            }

            if (BB2)
            {
                BB2 = MapController.ItemInt(q, BlueBut2);
            }

            if (BB3)
            {
                BB3 = MapController.ItemInt(q, BlueBut3);
            }

            if (BB4)
            {
                BB4 = MapController.ItemInt(q, BlueBut4);
            }

            if (P1 && player.HP <= 4)
            {
                P1 = MapController.ItemInt(q, Potion1);
                if (!P1)
                {
                    player.HP += 2;
                }
            }

            if (P2 && player.HP <= 4)
            {
                P2 = MapController.ItemInt(q, Potion2);
                if (!P2)
                {
                    player.HP += 2;
                }
            }

            if (P3 && player.HP <= 4)
            {
                P3 = MapController.ItemInt(q, Potion3);
                if (!P3)
                {
                    player.HP += 2;
                }
            }

            if (P4 && player.HP <= 4)
            {
                P4 = MapController.ItemInt(q, Potion4);
                if (!P4)
                {
                    player.HP += 2;
                }
            }

            if (P5 && player.HP <= 4)
            {
                P5 = MapController.ItemInt(q, Potion5);
                if (!P5)
                {
                    player.HP += 2;
                }
            }

            if (P6 && player.HP <= 4)
            {
                P6 = MapController.ItemInt(q, Potion6);
                if (!P6)
                {
                    player.HP += 2;
                }
            }

            if (MobInteraction.MobDead(player))
            {
                button_back_in_menu.Enabled = true;
                button_back_in_menu.Visible = true;
                button_exit.Enabled = true;
                button_exit.Visible = true;
                LabelDeath.Enabled = true;
                LabelDeath.Visible = true;
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
            }

            if (!RB1 && !RB2 && !RB3 && !RB4 && !BB1 && !BB2 && !BB3 && !BB4 && q.IntersectsWith(PExit))
            {
                button_back_in_menu.Enabled = true;
                button_back_in_menu.Visible = true;
                button_exit.Enabled = true;
                button_exit.Visible = true;
                LabelWin.Enabled = true;
                LabelWin.Visible = true;
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
            }

            MobInteraction.CollisionWithMob(player, imp1);
            MobInteraction.CollisionWithMob(player, imp2);
            MobInteraction.CollisionWithMob(player, imp3);
            MobInteraction.CollisionWithMob(player, imp4);
            MobInteraction.CollisionWithMob(player, imp5);
            MobInteraction.CollisionWithMob(player, imp6);
            MobInteraction.CollisionWithMob(player, imp7);
            MobInteraction.CollisionWithMob(player, imp8);
            MobInteraction.CollisionWithMob(player, Skelet1);
            MobInteraction.CollisionWithMob(player, Skelet2);
            MobInteraction.CollisionWithMob(player, Skelet3);
            MobInteraction.CollisionWithMob(player, Skelet4);
            MobInteraction.CollisionWithMob(player, Skelet5);
            MobInteraction.CollisionWithMob(player, Skelet6);
            MobInteraction.CollisionWithMob(player, Skelet7);
            MobInteraction.CollisionWithMob(player, Skelet8);
            MobInteraction.CollisionWithMob(player, Slime1);
            MobInteraction.CollisionWithMob(player, Slime2);
            MobInteraction.CollisionWithMob(player, Slime3);
            MobInteraction.CollisionWithMob(player, Slime4);
            MobInteraction.CollisionWithMob(player, Slime5);
        }

        public void Update(object sender, EventArgs e)
        {
            q = new Rectangle(new Point(player.posX - 16, player.posY), new Size(player.size, player.size));

            if (player.isMoving)
                player.Move();
            if (q.IntersectsWith(room1))
            {
                imp1.Move();
                Skelet1.Move();
            }

            if (q.IntersectsWith(room2))
            {
                Slime1.Move();
                Slime2.Move();
                Slime3.Move();
            }

            if (q.IntersectsWith(room3))
            {
                imp2.Move();
                Skelet2.Move();
                Skelet3.Move();
            }

            if (q.IntersectsWith(room4))
            {
                Skelet4.Move();
                Slime4.Move();
            }

            if (q.IntersectsWith(room5))
            {
                imp3.Move();
                imp4.Move();
            }

            if (q.IntersectsWith(room6))
            {
                Skelet5.Move();
                Skelet6.Move();
                Skelet7.Move();
            }

            if (q.IntersectsWith(room7))
            {
                imp5.Move();
                imp6.Move();
                imp7.Move();
            }

            if (q.IntersectsWith(room8))
            {
                imp8.Move();
                Skelet8.Move();
                Slime5.Move();
            }

            Invalidate();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            MapController.SeedMap(g, RB1, RB2, RB3, RB4, BB1, BB2, BB3, BB4, P1, P2, P3, P4, P5, P6);
            MapController.DrawMap(g);
            player.Animation(g);

            if (imp1.HP == 1)
            {
                imp1.Animation(g);
            }

            if (imp2.HP == 1)
            {
                imp2.Animation(g);
            }

            if (imp3.HP == 1)
            {
                imp3.Animation(g);
            }

            if (imp4.HP == 1)
            {
                imp4.Animation(g);
            }

            if (imp5.HP == 1)
            {
                imp5.Animation(g);
            }

            if (imp6.HP == 1)
            {
                imp6.Animation(g);
            }

            if (imp7.HP == 1)
            {
                imp7.Animation(g);
            }

            if (imp8.HP == 1)
            {
                imp8.Animation(g);
            }

            if (Skelet1.HP == 1)
            {
                Skelet1.Animation(g);
            }

            if (Skelet2.HP == 1)
            {
                Skelet2.Animation(g);
            }

            if (Skelet3.HP == 1)
            {
                Skelet3.Animation(g);
            }

            if (Skelet4.HP == 1)
            {
                Skelet4.Animation(g);
            }

            if (Skelet5.HP == 1)
            {
                Skelet5.Animation(g);
            }

            if (Skelet6.HP == 1)
            {
                Skelet6.Animation(g);
            }

            if (Skelet7.HP == 1)
            {
                Skelet7.Animation(g);
            }

            if (Skelet8.HP == 1)
            {
                Skelet8.Animation(g);
            }

            if (Slime1.HP == 1)
            {
                Slime1.Animation(g);
            }

            if (Slime2.HP == 1)
            {
                Slime2.Animation(g);
            }

            if (Slime3.HP == 1)
            {
                Slime3.Animation(g);
            }

            if (Slime4.HP == 1)
            {
                Slime4.Animation(g);
            }

            if (Slime5.HP == 1)
            {
                Slime5.Animation(g);
            }

            if (fire)
            {
                if (Fireball.mkfireball(g, player, ref FireBall, FBInterect(FireBall), facing))
                {
                    fire = false;
                }
            }

            MapController.DisplayHP(g, player);
        }
    }
}