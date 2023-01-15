using System.Drawing;

namespace kursach1
{
    public class Frame
    {
        private readonly Image _image;
        private Point curPoint;

        public Frame(string path)
        {
            path = path.Substring(0, path.LastIndexOf("/") + 1);
            _image = new Bitmap(path + "frame.png");
        }

        public void setPoint(Point point)
        {
            curPoint = point;
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(_image, curPoint);
        }
    }
}