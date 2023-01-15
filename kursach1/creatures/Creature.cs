using System.Drawing;
using System.Windows.Forms;

namespace kursach1.creatures
{
    public class Creature
    {
        protected readonly int[] directions = new int[2];
        protected Image curImage;
        protected int direction, animNum;
        protected Image[,] Images = new Bitmap[4, 3];
        protected bool isStop = true;
        protected int sizeX, sizeY;
        protected int speed = 10;
        protected int x, y;

        public void Move(int x, int y)
        {
            directions[0] = x;
            directions[1] = y;
            this.x += x * speed;
            this.y += y * speed;
        }

        public void MoveBack()
        {
            Move(-directions[0], -directions[1]);
        }

        public int X()
        {
            return x;
        }

        public int Y()
        {
            return y;
        }

        public void SetLeftDirection()
        {
            direction = 1;
        }

        public void SetRightDirection()
        {
            direction = 2;
        }

        public void SetUpDirection()
        {
            direction = 3;
        }

        public void SetDownDirection()
        {
            direction = 0;
        }

        public void Go()
        {
            isStop = false;
        }

        public void PlayAnimation(Graphics g)
        {
            curImage = Images[direction, animNum];
            g.DrawImage(curImage, x, y);
        }

        public void Stop()
        {
            isStop = true;
            animNum = 1;
        }

        public int getSizeX()
        {
            return sizeX;
        }

        public int getSizeY()
        {
            return sizeY;
        }
    }
}