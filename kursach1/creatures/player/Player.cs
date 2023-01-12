using kursach1.creatures;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using kursach1.food;

namespace kursach1.player
{
    internal class Player : Creature
    {
        private int[] drinks;
        public Player(String path,int num)
        {
            drinks = new int[3];
            sizeX = 48;
            sizeY = 64;
            curImage = new Bitmap(path+"pizzaMakers.png");
            int yStart = 0;
            if (num >= 4)
            {
                num -= 4;
                yStart = 1;
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Bitmap part = new Bitmap(sizeX, sizeY);
                    Graphics g = Graphics.FromImage(part);
                    g.DrawImage(curImage, 0, 0, new Rectangle(new Point(num*sizeX*3+sizeX * j, sizeY * i+yStart*sizeY*4), new Size(sizeX, sizeY)), GraphicsUnit.Pixel);
                    Images[i, j] = part;
                }
            }
            x = 50;
            y = 70;
            direction = 0;
            animNum = 1;
            curImage = Images[direction, animNum];
        }

        public void SetDefault()
        {
            drinks = null;
            drinks = new int[3];
            x = 50;
            y = 70;
            direction = 0;
            animNum = 1;
            curImage = Images[direction, animNum];
        }

        public void BuyDrink(int drinkName,int num)
        {
            drinks[drinkName] += num;
        }
        public void AddUpdateToTimer(System.Windows.Forms.Timer GameTimer)
        {
            GameTimer.Tick += new EventHandler(Update);
        }

        private void Update(object sender, EventArgs e)
        {
            if (!isStop)
            {
                switch(direction)
                {
                    case 0:
                    {
                        Move(0,1);
                        break;
                    }
                    case 1:
                    {
                        Move(-1,0);
                        break;
                    }
                    case 2:
                    {
                        Move(1,0);
                        break;
                    }
                    case 3:
                    {
                        Move(0,-1);
                        break;
                    }
                }
                if (animNum == 0)
                {
                    animNum = 2;
                }
                else
                {
                    animNum = 0;
                }
            }
        }
    }
}
