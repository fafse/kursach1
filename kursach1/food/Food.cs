﻿using System;
using System.Drawing;

namespace kursach1.food
{
    public class Food
    {
        protected Image _image;
        protected Point curPoint;
        protected String name;
        protected Frame frame;

        public Food(string path)
        {
            frame = new Frame(path);
        }
        
        public String getName()
        {
            return name;
        }
        public void setPoint(Point point)
        {
            curPoint = point;
            frame.setPoint(new Point(curPoint.X-8, curPoint.Y-8));
        }

        public void Draw(Graphics g)
        {
            frame.Draw(g);
            g.DrawImage(_image,curPoint);
        }
    }
}