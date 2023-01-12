using System;
using System.Drawing;

namespace kursach1.food
{
    public class Drink : Food
    {
        public Drink(String path) : base(path)
        {
            _image = new Bitmap(path);
        }
    }
}