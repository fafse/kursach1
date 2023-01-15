using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using kursach1.creatures;
using kursach1.food;

namespace kursach1.player
{
    internal class Player : Creature
    {
        private List<Food> foods;
        private readonly string path;

        public Player(string path, int num)
        {
            this.path = path;
            foods = new List<Food>();
            sizeX = 48;
            sizeY = 64;
            curImage = new Bitmap(path + "pizzaMakers.png");
            var yStart = 0;
            if (num >= 4)
            {
                num -= 4;
                yStart = 1;
            }

            for (var i = 0; i < 4; i++)
            for (var j = 0; j < 3; j++)
            {
                var part = new Bitmap(sizeX, sizeY);
                var g = Graphics.FromImage(part);
                g.DrawImage(curImage, 0, 0,
                    new Rectangle(new Point(num * sizeX * 3 + sizeX * j, sizeY * i + yStart * sizeY * 4),
                        new Size(sizeX, sizeY)), GraphicsUnit.Pixel);
                Images[i, j] = part;
            }

            x = 50;
            y = 70;
            direction = 0;
            animNum = 1;
            curImage = Images[direction, animNum];
        }

        public void MakePizza(int pizzaName)
        {
            if (pizzaName < 5) foods.Add(new Pizza(path + "pizza" + (pizzaName + 1) + ".png"));
        }

        public void BuyDrink(int drinkName, int num)
        {
            for (var i = 0; i < num; i++) foods.Add(new Drink(path + "drink" + (drinkName + 1) + ".png"));
        }

        public void AddUpdateToTimer(Timer GameTimer)
        {
            GameTimer.Tick += Update;
        }

        public List<Food> GiveOrder()
        {
            var tmp = new List<Food>();
            tmp.AddRange(foods);
            return tmp;
        }

        public void SetOrder()
        {
            foods.Clear();
        }

        private void Update(object sender, EventArgs e)
        {
            if (!isStop)
            {
                switch (direction)
                {
                    case 0:
                    {
                        Move(0, 1);
                        break;
                    }
                    case 1:
                    {
                        Move(-1, 0);
                        break;
                    }
                    case 2:
                    {
                        Move(1, 0);
                        break;
                    }
                    case 3:
                    {
                        Move(0, -1);
                        break;
                    }
                }

                if (animNum == 0)
                    animNum = 2;
                else
                    animNum = 0;
            }
        }
    }
}