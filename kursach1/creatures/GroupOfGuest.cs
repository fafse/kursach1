using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using kursach1.furniture;

namespace kursach1.creatures
{
    public class GroupOfGuest
    {
        private List<Guest> _guests;
        private Point dir;

        public GroupOfGuest(string path,int numGuests)
        {
            dir = Point.Empty;
            Random random = new Random();
            _guests = new List<Guest>();
            for (int i = 0; i < numGuests; i++)
            {
                _guests.Add(new Guest(path+"guests.png",random.Next(0,7)));
                _guests[i].setPos(new Point(267,81));
            }
            
        }

        public bool ChoosePlace(List<EatingPlace> places)
        {
            if (places.Count == 0)
            {
                return false;
            }
            foreach (var place in places)
            {
                if (place.isFree() && place.GetNumChairs() == _guests.Count)
                {
                    place.setAvailable(false);
                    dir = place.GetPoint();
                    return true;
                }
            }

            return false;
        }
        
        public void AddUpdateToTimer(System.Windows.Forms.Timer GameTimer)
        {
            foreach (var guest in _guests)
            {
                GameTimer.Tick += guest.update;
            }

            GameTimer.Tick += MoveToTable;
        }

        public void Draw(Graphics g)
        {
            foreach (var guest in _guests)
            {
                guest.PlayAnimation(g);
            }
        }

        public void MoveToTable(object sender, EventArgs e)
        {
            if (dir != Point.Empty)
            {
                int counter = 0;

                foreach (var guest in _guests)
                {
                    if (dir.Y > guest.Y()+9)
                    {
                        guest.SetDownDirection();
                        guest.Go();
                    }else if (dir.Y+9 < guest.Y())
                    {
                        guest.SetUpDirection();
                        guest.Go();
                    }else if (dir.X+9 < guest.X())
                    {
                        guest.SetLeftDirection();
                        guest.Go();
                    }
                    else if (dir.X > guest.X()+9)
                    {
                        guest.SetRightDirection();
                        guest.Go();
                    }
                    if(Math.Abs(dir.X-guest.X())<10
                            && 
                            Math.Abs(dir.Y-guest.Y())<10)
                    {
                        
                        guest.Stop();
                        counter++;
                    }
                }
                if (counter == _guests.Count)
                {
                    _guests[0].setPos(new Point(dir.X + 64+64/4, dir.Y));
                    _guests[0].SetDownDirection();
                    _guests[1].setPos(new Point(dir.X+64+64/4,dir.Y+2*64/2));
                    _guests[1].SetUpDirection();
                    if (_guests.Count == 4)
                    {
                        _guests[2].setPos(new Point(dir.X+64+64*3/2/2,dir.Y+64/2));
                        _guests[2].SetLeftDirection();
                        _guests[3].setPos(new Point(dir.X+64*3/2/2,dir.Y+64/2));
                        _guests[3].SetRightDirection();
                    }
                    dir = Point.Empty;
                }
            }
            
            
        }
    }
}