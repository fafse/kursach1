using System.Drawing;

namespace kursach1.furniture
{
    public class Chair
    {
        private readonly Image image;
        private Point myPos;
        private readonly int sizeX = 64;
        private readonly int sizeY = 64;

        public Chair(string path, int num, Point myPos)
        {
            image = new Bitmap(path);
            var yStart = 0;
            Image part = new Bitmap(sizeX, sizeY);
            var g = Graphics.FromImage(part);
            g.DrawImage(image, 0, 0, new Rectangle(new Point(num * sizeX, 0), new Size(sizeX, sizeY)),
                GraphicsUnit.Pixel);
            image = part;
            this.myPos = myPos;
        }

        public void DrawChair(Graphics g, Point point)
        {
            g.DrawImage(image, point);
        }

        public Point getPoint()
        {
            return new Point(myPos.X, myPos.Y);
        }
    }
}