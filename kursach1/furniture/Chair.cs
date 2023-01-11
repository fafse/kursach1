using System.Drawing;
using System.Windows.Forms;

namespace kursach1.furniture
{
    public class Chair
    {
        private Image image;
        private PictureBox _pictureBoxChair;
        private int sizeX=64, sizeY=64;
        public Chair(string path,int num)
        {
            image = new Bitmap(path);
            int yStart = 0;
            Image part = new Bitmap(sizeX, sizeY);
            Graphics g = Graphics.FromImage(part);
            g.DrawImage(image, 0, 0, new Rectangle(new Point(num*sizeX, 0), new Size(sizeX, sizeY)), GraphicsUnit.Pixel);
            image = part;
        }
        public void DrawChair(Graphics g, Point point)
        {
            g.DrawImage(image,point);
        }

        public int getSizeX()
        {
            return sizeX;
        }
        public int getSizeY()
        {
            return sizeY;
        }
    }
}