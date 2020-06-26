using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Game.Entites;

namespace Game.Controllers
{
    public static class MobController
    {
        public static bool MobDead(Entity x)
        {
            bool Dead = false;
            if (x.HP == 0)
            {
                return Dead = true;
            }
            else
            {
                return Dead;
            }
        }
        public static void MovingMob(Entity x)
        {
            if (player.posX > x.posX)
            { x.dirX = 2; }
            else { x.dirX = -2; }

            if (player.posY > x.posY)
            { x.dirY = 2; }
            else { x.dirY = -2; }
        }
        public void CollisionWithMob(Entity q, Entity e)
        {
            var d = new Rectangle(new Point(q.posX - 16, q.posY), new Size(q.size, q.size));
            var j = new Rectangle(new Point(e.posX - 16, e.posY), new Size(e.size, e.size));
            if (d.IntersectsWith(j))
            {
                q.HP -= 1;
            }
        }
    }
}
