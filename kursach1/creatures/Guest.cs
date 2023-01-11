using System;
using System.Drawing;

namespace kursach1.creatures
{
    internal class Guest:Creature
    {
        public Guest(String path,int num)
        {
            curImage = new Bitmap(path);
            int yStart = 0;
            if (num >= 4)
            {
                num -= 4;
                yStart = 1;
            }
            
            sizeX = sizeY = 32;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Bitmap part = new Bitmap(32, 32);
                    Graphics g = Graphics.FromImage(part);
                    g.DrawImage(curImage, 0, 0, new Rectangle(new Point(num*sizeX*3+sizeX * j, sizeY * i+yStart*sizeY*4), new Size(sizeX, sizeY)), GraphicsUnit.Pixel);
                    Images[i, j] = part;
                }
            }

            x = 540;
            y = 374;
            direction = 0;
            animNum = 1;
            curImage = Images[direction, animNum];
        }

        public void setPos(Point point)
        {
            x = point.X;
            y = point.Y;
        }
        public void ShowPic( System.Windows.Forms.Timer GameTimer)
        {
            GameTimer.Tick += new EventHandler(update);
        }
        
        public void update(object sender, EventArgs e)
        {
            if(animNum==2)
            {
                animNum = 0;
            }
            if (direction == 3) 
            {
                direction = 0;
            }

            animNum += 1;
            direction++;
        }
        
    }
}
