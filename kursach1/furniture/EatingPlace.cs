using System;
using System.Collections.Generic;
using System.Drawing;

namespace kursach1.furniture
{
    public class EatingPlace
    {
        private List<Chair> _chairs = new List<Chair>();
        private Table _table;
        private Boolean isAvailable = true;
        private Point curPos;
        public EatingPlace(string path, Point curPos)
        {
            this.curPos = curPos;
            for (int i = 0; i <= 4; i++)
            {
                if (i != 2)
                {
                    _chairs.Add(new Chair(path, i));
                }
                else
                {
                    _table = new Table(path, i);
                }
            }
        }

        public void DrawPlace(Graphics g)
        {
            /*_chairs[0].DrawChair(g,new Point(curPos.X+_chairs[0].getSizeX(),curPos.Y));
            _chairs[1].DrawChair(g,new Point(curPos.X+_chairs[1].getSizeX(),curPos.Y+2*_chairs[1].getSizeY()));
            _chairs[2].DrawChair(g,new Point(curPos.X+2*+_chairs[2].getSizeY(),curPos.Y+_chairs[2].getSizeY()));
            _chairs[3].DrawChair(g,new Point(curPos.X,curPos.Y+_chairs[3].getSizeY()));*/

            _chairs[0].DrawChair(g,new Point(curPos.X+_chairs[0].getSizeX(),curPos.Y));//up
            _chairs[1].DrawChair(g,new Point(curPos.X+_chairs[1].getSizeX(),curPos.Y+2*_chairs[1].getSizeY()/2));//down
            _chairs[2].DrawChair(g,new Point(curPos.X+_chairs[2].getSizeX()+_chairs[2].getSizeX()/2,curPos.Y+_chairs[2].getSizeY()/2));//right
            _chairs[3].DrawChair(g,new Point(curPos.X+_chairs[3].getSizeX()/2,curPos.Y+_chairs[3].getSizeY()/2));//left
            
            _table.DrawTable(g,new Point(curPos.X+_table.getSizeX(),curPos.Y+_table.getSizeY()/2));
        }
        
    }
}