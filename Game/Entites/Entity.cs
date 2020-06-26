using System.Drawing;

namespace Game.Entites
{
    public class Entity
    {
        public int HP;
        public int posX;
        public int posY;
        public int dirX;
        public int dirY;
        public bool isMoving;
        public int flip;
        public int currentAnimation;
        public int currentFrame;
        public int currentLimit;
        public int idleFrames;
        public int runFrames;
        public int attackFrames;
        public int size;
        public Image spriteSheet;

        public Entity(int posX, int posY, int idleFrames, int runFrames, int attackFrames, Image spriteSheet, int HP)
        {
            this.HP = HP;
            this.posX = posX;
            this.posY = posY;
            this.idleFrames = idleFrames;
            this.runFrames = runFrames;
            this.attackFrames = attackFrames;
            this.spriteSheet = spriteSheet;
            size = 44;
            currentAnimation = 0;
            currentFrame = 0;
            currentLimit = idleFrames;
            flip = 1;
        }
        public void Move()
        {
            posX += dirX;
            posY += dirY;
        }
        public static void MovingMob(Entity player, Entity x)
        {
            if (x.HP != 0)
            {
                if (player.posX > x.posX)
                { x.dirX = 2; }
                else { x.dirX = -2; }

                if (player.posY > x.posY)
                { x.dirY = 2; }
                else { x.dirY = -2; }
            }
            else
            {
                x.posY = 0;
                x.posX = 0;
            }
            
        }
        public void Animation(Graphics g)
        {
            if (currentFrame < currentLimit - 1)
                currentFrame++;
            else currentFrame = 0;
            g.DrawImage(spriteSheet, new Rectangle(new Point(posX - flip * size/2 , posY), new Size(flip * size, size)), 44 * currentFrame, 44 * currentAnimation, size, size, GraphicsUnit.Pixel);
        }
        public void SetAnimationConfiguration(int currentAnimation)
        {
            this.currentAnimation = currentAnimation;

            switch (currentAnimation)
            {
                case 0:
                    currentLimit = idleFrames;
                    break;
                case 1:
                    currentLimit = runFrames;
                    break;
                case 2:
                    currentLimit = attackFrames;
                    break;
            }
        }
    }
}
