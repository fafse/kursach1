using System;
using System.Drawing;

namespace kursach1.food
{
    public class Pizza
    {
        private Image _image;
        private int x, y;
        private int picSizeX, picSizeY;
        private String name;

        public Pizza(String path)
        {
            _image = new Bitmap(path);
        }
        public String getName()
        {
            return name;
        }
    }
}