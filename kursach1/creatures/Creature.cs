using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach1.creatures
{
    public class Creature
    {
        protected int direction,animNum;
        protected int x, y;
        protected Image[,] Images=new Bitmap[4,3];
        protected Image curImage;
        protected PictureBox _pictureBoxCreature;
        protected int speed=10;
        protected bool isStop=true;
        protected int sizeX, sizeY;
        protected readonly int[] directions = new int[2];

        public void Move(int x, int y)
        {
            directions[0] = x;
            directions[1] = y;
            this.x += x * speed;
            this.y += y * speed;
        }

        public void MoveBack()
        {
            Move(-directions[0],-directions[1]);
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
            g.DrawImage(curImage,x,y);
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
