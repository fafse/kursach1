using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using kursach1.creatures;
using kursach1.food;
using kursach1.furniture;
using kursach1.player;

namespace kursach1
{
    internal class Game
    {
        private string path;
        private Player _player;
        private Timer GameTimer;
        private Panel gamePanel;
        private PhysicsController _controller;
        private Form1 form;
        private Bitmap gameBackground;
        private List<Rectangle> _rectangles;
        private List<EatingPlace> _places;
        private List<GroupOfGuest> groups;
        private Button button1;
        private int maxGroups = 6;
        private int nextGroup;
        private int score;
        private int lostPeople;
        private int people;
        private List<Pizza> pizzas;
        private List<Drink> drinks;
        private bool showFoodBar;
        private bool showDrinkBar;
        private bool isCook;
        private int cookTime;
        private int gamemode;
        private int numPeople;
        
        //tmp
        private bool showColliders = false;
        private List<Food> wrong = new List<Food>();

        public Game(Form1 form, Panel gamePanel, int sizeX, int sizeY, string path, Player _player, Button button,
            int gamemode, int numPeople)
        {
            this.numPeople = numPeople;
            this.gamemode = gamemode;//1 - заданное количество посетителей 2 - опр сбежавшие
            cookTime = 0;
            isCook = false;
            showFoodBar = false;
            score = 0;
            this.path = path;
            this.button1 = button;
            gameBackground= new Bitmap(path+"Pitstseria.png");
            this.form = form;
            form.KeyPreview = true;
            this.gamePanel = gamePanel;
            form.Size = new Size(sizeX, sizeY);
            GameTimer = new Timer();
            GameTimer.Interval = 50;

            _rectangles = new List<Rectangle>();
            _rectangles.Add(new Rectangle(new Point(0, 0), new Size(588, 90)));
            _rectangles.Add(new Rectangle(new Point(0,0), new Size(15,709)));
            _rectangles.Add(new Rectangle(new Point(570, 0), new Size(25,709)));
            _rectangles.Add(new Rectangle(new Point(0, 578), new Size(588,150)));
            
            _rectangles.Add(new Rectangle(new Point(0, 385), new Size(250,100)));
            _rectangles.Add(new Rectangle(new Point(355, 385), new Size(250,100)));

            _places = new List<EatingPlace>();
            _places.Add(new EatingPlace(path+"Chair_amp_amp_Table.png",new Point(100,138),true));
            _places.Add(new EatingPlace(path+"Chair_amp_amp_Table.png",new Point(100,238),true));
            _places.Add(new EatingPlace(path+"Chair_amp_amp_Table.png",new Point(300,138),true));
            _places.Add(new EatingPlace(path+"Chair_amp_amp_Table.png",new Point(300,238),true));
            
            _places.Add(new EatingPlace(path+"Chair_amp_amp_Table.png",new Point(-10,138),false));
            _places.Add(new EatingPlace(path+"Chair_amp_amp_Table.png",new Point(-10,238),false));
            _places.Add(new EatingPlace(path+"Chair_amp_amp_Table.png",new Point(410,138),false));
            _places.Add(new EatingPlace(path+"Chair_amp_amp_Table.png",new Point(410,238),false));
            foreach (var place in _places)
            {
                _rectangles.AddRange(place.GetColiders());
            }

            groups = new List<GroupOfGuest>();


            _controller = new PhysicsController(_rectangles);
            this._player = _player;
            pizzas = new List<Pizza>();//
            for (int i = 0; i < 5; i++)
            {
                pizzas.Add(new Pizza(path+"pizza"+(i+1).ToString()+".png"));
                pizzas[i].setPoint(new Point(120+i*64,540));
            }
            drinks = new List<Drink>();//
            for (int i = 0; i < 3; i++)
            {
                drinks.Add(new Drink(path+"drink"+(i+1).ToString()+".png"));
                drinks[i].setPoint(new Point(355+i*64,540));
            }
            
            
            _player.AddUpdateToTimer(GameTimer);
            GameTimer.Tick += new EventHandler(update);
            Random random = new Random();
            nextGroup = random.Next(0, 50);
            button1.BackColor=Color.Transparent;
            ContunueGame();
        }

        private void spawnGroup()
        {
            Random random = new Random();
            GroupOfGuest tmp = new GroupOfGuest(path, (random.Next(1, 3)) * 2);
            if (tmp.ChoosePlace(_places))
            {
                tmp.AddUpdateToTimer(GameTimer);
                groups.Add(tmp);
            }
        }

        private void update(object sender, EventArgs e)
        {
            if (gamemode == 1&&numPeople<=people||gamemode==2&&numPeople<=lostPeople)
            {
                //WriteScore(path+"scores.txt");
                GameTimer.Stop();
                form.lastScore = score;
                MessageBox.Show("Final score:" + score.ToString());
                StopGame();
                _player.SetDefault();
                form.ExitMenu();
            }
            if (isCook&&showFoodBar)
            {
                if (cookTime > 0)
                {
                    cookTime--;
                }
                else
                {
                    isCook = false;
                    showFoodBar = false;
                }

            }
            if (groups!=null&& groups.Count < maxGroups&&nextGroup==0)
            {
                Random random = new Random();
                spawnGroup();
                nextGroup = random.Next(50, 120);
            }

            if (nextGroup > 0)
            {
                nextGroup--;
            }

            gamePanel.Invalidate();
        }

        public void ChangeDirection(Keys key)
        {
            if (key == Keys.Space )
            {
                if (Math.Abs(_player.X() - 151) <= 50 && Math.Abs(_player.Y() - 500) <= 50 && !isCook)
                {
                    Cook();
                }else if (Math.Abs(_player.X() - 442) <= 50 && Math.Abs(_player.Y() - 488) <= 50)
                {
                    BuyDrinks();

                }
                else
                {
                    foreach (var group in groups)
                    {
                        Point tmp = group.GetCurLoc();
                        if (tmp != Point.Empty)
                        {
                            if (Math.Abs(_player.X() - tmp.X) < 100 && Math.Abs(_player.Y() - tmp.Y) < 100)
                            {
                                List<Food> tmpList = group.GetOrder(_player.GiveOrder());
                                if (tmpList!=null)
                                {
                                    _player.SetOrder();
                                }
                            }
                        }
                    }
                }
            }


            if (showFoodBar&&!isCook)
            {
                switch (key)
                {
                    case Keys.D1:
                    {
                        StartCook(50,0);
                        break;
                    }
                    case Keys.D2:
                    {
                        StartCook(50,1);

                        break;
                    }
                    case Keys.D3:
                    {
                        StartCook(50,2);

                        break;
                    }
                    case Keys.D4:
                    {
                        StartCook(50,3);

                        break;
                    }
                    case Keys.D5:
                    {
                        StartCook(50,4);

                        break;
                    }
                }
            }
            
            if (showDrinkBar)
            {
                switch (key)
                {
                    case Keys.D1:
                    {
                        _player.BuyDrink(0,1);
                        break;
                    }
                    case Keys.D2:
                    {
                        _player.BuyDrink(1,1);

                        break;
                    }
                    case Keys.D3:
                    {
                        _player.BuyDrink(2,1);

                        break;
                    }
                }
            }
            
            if (!showFoodBar&&!showDrinkBar)
            {
                switch (key)
                {
                    case Keys.A:
                    {
                        _player.SetLeftDirection();
                        _player.Go();
                        break;
                    }
                    case Keys.S:
                    {
                        _player.SetDownDirection();
                        _player.Go();
                        break;
                    }
                    case Keys.W:
                    {
                        _player.SetUpDirection();
                        _player.Go();
                        break;
                    }
                    case Keys.D:
                    {
                        _player.SetRightDirection();
                        _player.Go();
                        break;
                    }
                }
            }
        }

        private void StartCook(int num,int pizzaNum)
        {
            _player.MakePizza(pizzaNum);
            cookTime = num;
            isCook = true;
        }

        public void FreeKey()
        {
            _player.Stop();
        }

        public void PauseGame()
        {
            GameTimer.Stop();
        }

        public void ContunueGame()
        {
            GameTimer.Start();
        }
        
        public void StopGame()
        {
            _player.SetDefault();
            _rectangles.Clear();
            _places.Clear();
            form.KeyPreview = false;
            _player=null;
        _controller=null;
            form = null;
            gameBackground = null;
            _rectangles = null;
            _places=null;
            groups = null;

            _controller = null;
            GameTimer = null;
            
        }

        public void Cook()
        {
            _player.Stop();
            showFoodBar = !showFoodBar;
        }
        public void BuyDrinks()
        {
            _player.Stop();
            showDrinkBar = !showDrinkBar;
        }
        
        public void ChangeTimerInterval(int num)
        {
            GameTimer.Interval = num;
        }

        public void Draw(Graphics g,Button button)
        {
            g.DrawImage(gameBackground,0,0);
            if (showColliders)
            {
                foreach (var rectangle in _rectangles)
                {
                    g.DrawRectangle(new Pen(Color.Chartreuse), rectangle);
                }
            }

            foreach (var place in _places)
            {
                place.DrawPlace(g);
            }
            
            if (_controller.IsCollide(_player, new Point(_player.X(), _player.Y())))
            {
                _player.MoveBack();
            }

            _player.PlayAnimation(g);
            GroupOfGuest tmp = null;
            foreach (var group in groups)
            {
                if (!group.isLeft())
                {
                    group.Draw(g);
                }
                else
                {
                    if (group.getScore() == 0)
                    {
                        lostPeople += group.getNumPeople();
                    }
                    else
                    {
                        people += group.getNumPeople();
                    }
                    score += group.getScore();
                    tmp = group;
                }
            }

            if (tmp != null)
            {
                groups.Remove(tmp);
            }

            if (pizzas != null&& showFoodBar)
            {
                foreach (var pizza in pizzas)
                {
                    pizza.Draw(g);
                }
            }
            if (drinks != null&& showDrinkBar)
            {
                foreach (var drink in drinks)
                {
                    drink.Draw(g);
                }
            }

            /*if (_player.GiveOrder().Count != 0)
            {
                int counter = 0;
                foreach (var product in _player.GiveOrder())
                {
                    product.setPoint( new Point(32+counter*64,650));
                    counter++;
                    product.Draw(g);
                }
            }*/
            /*if (wrong.Count != 0)
            {
                int counter = 0;
                foreach (var product in wrong)
                {
                    product.setPoint( new Point(32+counter*64,650));
                    counter++;
                    product.Draw(g);
                }
            }*/

            button1.Text = score.ToString();

        }
    }
}
