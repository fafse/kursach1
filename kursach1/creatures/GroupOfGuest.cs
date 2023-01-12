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
        private Button button;

        public GroupOfGuest(string path,int numGuests, Button button)
        {
            this.button = button;
            dir = Point.Empty;
            Random random = new Random();
            _guests = new List<Guest>();
            for (int i = 0; i < numGuests; i++)
            {
                _guests.Add(new Guest(path+"guests.png",i));
                _guests[i].setPos(new Point(random.Next(5,500),random.Next(5,200)));
                //_guests.Add(new Guest(path+"guests.png",random.Next(0,6)));
            }

            this.button.Text = _guests.Count.ToString();
        }

        public void ChoosePlace(List<EatingPlace> places)
        {
            foreach (var place in places)
            {
                if (place.isFree() && place.GetNumChairs() >= _guests.Count)
                {
                    place.setAvailable(false);
                    dir = place.GetPoint();
                }
            }
        }
        
        public void AddUpdateToTimer(System.Windows.Forms.Timer GameTimer)
        {
            foreach (var guest in _guests)
            {
                GameTimer.Tick += new EventHandler(guest.update);
            }

            GameTimer.Tick += new EventHandler(MoveToTable);
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
                    }
                }
            }
            
        }
    }
}