using System;
using System.Drawing;

namespace kursach1.food
{
    public class Drink
    {
        private Image _image;
        private int x, y;
        private int picSizeX, picSizeY;
        private String name;

        public Drink(String path,int num)
        {
            _image = new Bitmap(path);
            Image part = new Bitmap(picSizeX, picSizeY);
            Graphics g = Graphics.FromImage(part);
            g.DrawImage(_image, 0, 0, new Rectangle(new Point(0, 0), new Size(picSizeX, picSizeY)), GraphicsUnit.Pixel);
            _image = part;
        }

        public String getName()
        {
            return name;
        }
    }
}