using System.Drawing;

namespace kursach1.food
{
    public class Pizza : Food
    {
        public Pizza(string path) : base(path)
        {
            score = 500;
            _image = new Bitmap(path);
            name = path;
        }
    }
}