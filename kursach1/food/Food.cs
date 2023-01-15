using System.Drawing;

namespace kursach1.food
{
    public class Food
    {
        protected Image _image;
        protected Point curPoint;
        protected Frame frame;
        protected string name;
        protected int score;

        public Food(string path)
        {
            score = 0;
            frame = new Frame(path);
        }

        public int ShowScore()
        {
            return score;
        }

        public string getName()
        {
            return name;
        }

        public void setPoint(Point point)
        {
            curPoint = point;
            frame.setPoint(new Point(curPoint.X - 8, curPoint.Y - 8));
        }

        public void Draw(Graphics g)
        {
            frame.Draw(g);
            g.DrawImage(_image, curPoint);
        }
    }
}