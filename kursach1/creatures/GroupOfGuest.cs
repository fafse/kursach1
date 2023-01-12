using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using kursach1.food;
using kursach1.furniture;

namespace kursach1.creatures
{
    public class GroupOfGuest
    {
        private List<Guest> _guests;
        private Point dir;
        private List<Food> order;
        private string path;
        private bool showOrder;
        private Timer GameTimer;
        private int awaitingTime;
        private bool waitForOrder;
        private bool leave;
        private int score;
        private EatingPlace cutPlace;
        private Point CurPos;

        public GroupOfGuest(string path,int numGuests)
        {
            score = 0;
            cutPlace = null;
            leave = false;
            waitForOrder = false;
            showOrder = false;
            this.path = path;
            dir = Point.Empty;
            Random random = new Random();
            awaitingTime = random.Next(400, 700);
                _guests = new List<Guest>();
            for (int i = 0; i < numGuests; i++)
            {
                _guests.Add(new Guest(path+"guests.png",random.Next(0,7)));
                _guests[i].setPos(new Point(267,81));
                
            }

        }

        private List<Food> GenerateOrder(int numGuests)
        {
            Random random = new Random();
            List<Food> tmp = new List<Food>();
            int numPositions = random.Next(0, numGuests);
            int position;
            for(int i = 0;i<= numPositions;i++)
            {
                position = random.Next(0, 8);
                if (position < 5)
                {
                    tmp.Add(new Pizza(path+"pizza"+(position+1).ToString()+".png"));
                }
                else
                {
                    tmp.Add(new Drink(path+"drink"+(position-4).ToString() +".png"));
                }
            }

            return tmp;
        }

        public Point GetCurLoc()
        {
            if (waitForOrder)
            {
                return CurPos;
            }
            else
            {
                return Point.Empty;
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
                    cutPlace = place;
                    place.setAvailable(false);
                    dir = place.GetPoint();
                    return true;
                }
            }

            return false;
        }
        
        public void AddUpdateToTimer(System.Windows.Forms.Timer GameTimer)
        {
            this.GameTimer = GameTimer;
            foreach (var guest in _guests)
            {
                GameTimer.Tick += guest.update;
            }

            GameTimer.Tick += MoveToTable;
        }

        
        
        public void Leave()
        {
            cutPlace.setAvailable(true);
            leave = true;
            foreach (var guest in _guests)
            {
                GameTimer.Tick -= guest.update;
            }

            GameTimer.Tick -= MoveToTable;
        }

        public bool isLeft()
        {
            return leave;
        }

        public void Draw(Graphics g)
        {
            int counter = 0;
            foreach (var guest in _guests)
            {
                guest.PlayAnimation(g);
                counter++;
                if (showOrder)
                {
                    foreach (var food in order)
                    {
                        food.Draw(g);
                    }
                }
                

            }
        }

        public int getNumPeople()
        {
            return _guests.Count;
        }

        public int getScore()
        {
            int curSCore=0;
            if (awaitingTime > 0)
            {
                foreach (var food in order)
                {
                    curSCore += food.ShowScore();
                }
            }

            return curSCore;
        }

        public List<Food> GetOrder(List<Food> orderPizza)
        {
            if (waitForOrder)
            {
                bool isAll = false;
                foreach (var foodSearch in this.order)
                {
                    /*if (!orderPizza.Contains(food))
                    {
                        isAll = false;
                        break;
                    }*/
                    foreach (var food in orderPizza)
                    {
                        if (food.getName().Equals(foodSearch.getName()))
                        {
                            isAll = true;
                            break;
                        }
                    }
                }

                if (isAll)
                {
                    List<Food> newOrder = new List<Food>();
                    List<Food> result = new List<Food>();
                    newOrder.AddRange(orderPizza);
                    foreach (var food in this.order)
                    {
                        foreach (var elem in newOrder )
                        {
                            if (!elem.getName().Equals(food.getName()))
                            {
                                result.Add(elem);
                            }
                        }
                    }
                    Leave();
                    return result;
                }
            }

            return null;
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
                    order = new List<Food>();
                    order.AddRange(GenerateOrder(_guests.Count));
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
                    foreach (var guest in _guests)
                    {
                        if (order.Count >= _guests.IndexOf(guest) + 1)
                        {
                            order[_guests.IndexOf(guest)].setPoint(new Point(guest.X() + 8, guest.Y() - 40));
                        }
                        else
                        {
                            break;
                        }
                    }
                    showOrder = true;
                    waitForOrder = true;
                    CurPos = dir;
                    dir = Point.Empty;
                }
            }
            else
            {
                if (awaitingTime == 0)
                {
                    Leave();
                }
                else
                {
                    awaitingTime--;

                }
            }
            
            
        }
    }
}