using Game.Entites;
using System.Drawing;

namespace Game.Controllers
{
    public class MobInteraction
    {
        public static bool MobDead(Entity x)
        {
            if (x.HP == 0)
                return true;
            return false;
        }
        public static void CollisionWithMob(Entity q, Entity e)
        {
            {
                var d = new Rectangle(new Point(q.posX - 16, q.posY), new Size(q.size, q.size));
                var j = new Rectangle(new Point(e.posX - 16, e.posY), new Size(e.size, e.size));
                if (d.IntersectsWith(j)&&q.HP!=0)
                {
                    q.HP -= 1;
                    if (q.posX < e.posX)
                    {
                        e.posX += 4;
                    }

                    if (q.posX > e.posX)
                    {
                        e.posX -= 4;
                    }

                    if (q.posY < e.posY)
                    {
                        e.posY += 4;
                    }

                    if (q.posY > e.posY)
                    {
                        e.posY -= 4;
                    }
                }
            }
        }
        public static void CollisionWithFB(Entity FB, Entity e)
        {
            var d = new Rectangle(new Point(FB.posX , FB.posY), new Size(12, 12));
            var j = new Rectangle(new Point(e.posX - 16, e.posY), new Size(e.size, e.size));
            if (d.IntersectsWith(j))
            {
                e.HP -= 1;
            }
        }
    }
}
