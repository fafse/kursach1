using System;
using System.Drawing;

namespace kursach1.food
{
    public class Drink : Food
    {
        public Drink(String path) : base(path)
        {
            score = 300;
            _image = new Bitmap(path);
            name = path;
        }
    }
}