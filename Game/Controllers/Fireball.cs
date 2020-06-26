using System.Drawing;
using System.Windows.Forms;
using Game.Entites;

namespace Game.Controllers
{
    class Fireball
    {
        
        public static int speed = 20;
        static Timer tm = new Timer();
        public static bool startmov = true;
        public static string direction;



        public static bool mkfireball(Graphics g, Entity player,ref Entity FireBall,bool FBint, string facing)
        {
            Pen qe = new Pen(Brushes.Firebrick,10);
            if (startmov)
            {
                direction = facing;
                FireBall.posX = player.posX;
                FireBall.posY = player.posY + 16;
                startmov = false;
                return false;
            }
            g.DrawEllipse(qe,FireBall.posX, FireBall.posY,12 , 12);

            if (true)
            {
                if (direction == "left" && !FBint)
                {
                    FireBall.posX -= 10;
                    return false;
                }
                else
                {
                    if (direction == "right" && !FBint)
                    {
                        FireBall.posX += 10;
                        return false;
                    }
                    else
                    {
                        if (direction == "up" && !FBint)
                        {
                            FireBall.posY -= 10;
                            return false;
                        }
                        else
                        {
                            if (direction == "down" && !FBint)
                            {
                                FireBall.posY += 10;
                                return false;
                            }
                            else
                            {
                                startmov = true;
                                return true;
                            }
                        }
                    } 
                }
                
               
            }

                
        }
    }
}
