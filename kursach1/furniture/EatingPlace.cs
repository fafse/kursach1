using System.Collections.Generic;
using System.Drawing;

namespace kursach1.furniture
{
    public class EatingPlace
    {
        private readonly List<Chair> _chairs;
        private readonly Table _table;
        private readonly List<Rectangle> colliders;
        private Point curPos;
        private readonly bool fullPlace;
        private bool isAvailable = true;
        private bool lol = false;

        public EatingPlace(string path, Point curPos, bool fullPlace)
        {
            this.fullPlace = fullPlace;
            _chairs = new List<Chair>();
            colliders = new List<Rectangle>();
            this.curPos = curPos;
            int chairSize = 64, tableSize = 64;
            _chairs.Add(new Chair(path, 0, new Point(curPos.X + chairSize, curPos.Y)));
            _chairs.Add(new Chair(path, 1, new Point(curPos.X + chairSize, curPos.Y + 2 * chairSize / 2)));
            if (fullPlace)
            {
                _chairs.Add(new Chair(path, 3,
                    new Point(curPos.X + chairSize + chairSize / 2, curPos.Y + chairSize / 2)));
                _chairs.Add(new Chair(path, 4, new Point(curPos.X + chairSize / 2, curPos.Y + chairSize / 2)));
            }

            _table = new Table(path, 2, new Point(curPos.X + tableSize, curPos.Y + tableSize / 2));
            colliders.Add(new Rectangle(new Point(curPos.X + _table.getSizeX(), curPos.Y + _table.getSizeY() / 2),
                new Size(_table.getSizeX(), _table.getSizeY())));
        }

        public Point GetPoint()
        {
            return new Point(curPos.X, curPos.Y);
        }

        public int GetNumChairs()
        {
            var num = 4;
            if (!fullPlace) num = 2;
            return num;
        }

        public bool isFree()
        {
            return isAvailable;
        }

        public void setAvailable(bool available)
        {
            isAvailable = available;
        }

        public List<Rectangle> GetColiders()
        {
            return new List<Rectangle>(colliders);
        }

        public void DrawPlace(Graphics g)
        {
            foreach (var chair in _chairs) chair.DrawChair(g, chair.getPoint());
            _table.DrawTable(g, _table.getPoint());
        }
    }
}