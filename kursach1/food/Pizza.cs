using System;
using System.Drawing;

namespace kursach1.food
{
    public class Pizza : Food
    {
        public Pizza(String path) : base(path)
        {
            score = 500;
            _image = new Bitmap(path);
            name = path;
        }
        
    }
}