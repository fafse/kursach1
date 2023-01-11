using System;
using System.Collections.Generic;
using System.Drawing;
using kursach1.creatures;

namespace kursach1
{
    public class PhysicsController
    {
        private List<Rectangle> _rectangles;

        public PhysicsController(List<Rectangle> rectangles)
        {
            _rectangles = new List<Rectangle>();
            foreach (var _rectangle in rectangles)
            {
                AddObj(_rectangle);
            }
        }

        public void AddObj(Rectangle _rectangle)
        {
            this._rectangles.Add(_rectangle);
        }

        public Boolean IsCollide(Creature objCreature ,Point dir)
        {
            /*if (dir.X > startHall.X-objCreature.getSizeX()/2 && dir.Y > startHall.Y-objCreature.getSizeY()/2&&
                startHall.X > dir.X+objCreature.getSizeX()/2 && startHall.Y > dir.Y+objCreature.getSizeY())
            {
                return false;
            }
            if (dir.X > startKitchen.X-objCreature.getSizeX()/2 && dir.Y > startKitchen.Y-objCreature.getSizeY()/2&&
                endKitchen.X > dir.X+objCreature.getSizeX()/2 && endKitchen.Y > dir.Y+objCreature.getSizeY())
            {
                return false;
            }
            
            if (dir.X > startHallWay.X-objCreature.getSizeX()/2 && dir.Y > startHallWay.Y-objCreature.getSizeY()/2&&
                      startHallWay.X > dir.X+objCreature.getSizeX()/2&& startHallWay.Y > dir.Y+objCreature.getSizeY())
            {
                return false;
            }*/
            foreach (var _rectangle in _rectangles)
            {
                if( 
                    //_rectangle.Contains(dir)||
                    //_rectangle.Contains(new Point(dir.X+objCreature.getSizeX(),dir.Y+objCreature.getSizeY()))||
                    _rectangle.Contains(new Point(dir.X+objCreature.getSizeX()/2,dir.Y+objCreature.getSizeY()/2))
                    )
                {
                    return true;
                }
            }

            return false;
        }
    }
}