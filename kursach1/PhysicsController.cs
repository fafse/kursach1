using System.Collections.Generic;
using System.Drawing;
using kursach1.creatures;

namespace kursach1
{
    public class PhysicsController
    {
        private readonly List<Rectangle> _rectangles;

        public PhysicsController(List<Rectangle> rectangles)
        {
            _rectangles = new List<Rectangle>();
            AddObj(rectangles);
        }

        public void AddObj(List<Rectangle> _rectangle)
        {
            _rectangles.AddRange(_rectangle);
        }

        public bool IsCollide(Creature objCreature, Point dir)
        {
            foreach (var _rectangle in _rectangles)
                if (_rectangle.Contains(new Point(dir.X + objCreature.getSizeX() / 2,
                        dir.Y + objCreature.getSizeY() / 2)))
                    return true;

            return false;
        }
    }
}