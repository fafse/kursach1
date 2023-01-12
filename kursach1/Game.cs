using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using kursach1.creatures;
using kursach1.furniture;
using kursach1.player;

namespace kursach1
{
    internal class Game
    {
        private List<Guest> _guests = new List<Guest>();
        private Player _player;
        private Timer GameTimer;
        private Panel gamePanel;
        private PhysicsController _controller;
        private Form1 form;
        private Bitmap gameBackground;
        private List<Rectangle> _rectangles;
        private List<EatingPlace> _places;
        private GroupOfGuest one;
        
        //tmp
        private bool showColliders = true;

        public Game(Form1 form, Panel gamePanel, int sizeX, int sizeY, string path, Player _player,Button button)
        {
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

            one = new GroupOfGuest(path, 3,button);
            one.ChoosePlace(_places);
            one.AddUpdateToTimer(GameTimer);
            
            
            _controller = new PhysicsController(_rectangles);
            this._player = _player;
            
            
            
            _player.AddUpdateToTimer(GameTimer);
            GameTimer.Tick += new EventHandler(update);

            
            ContunueGame();
        }

        private void update(object sender, EventArgs e)
        {
            gamePanel.Invalidate();
        }

        public void ChangeDirection(Keys key)
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
            _guests.Clear();
            _rectangles.Clear();
            _places.Clear();
            form.KeyPreview = false;
            _guests = null;
        _player=null;
        _controller=null;
            form = null;
            gameBackground = null;
            _rectangles = null;
            _places=null;
        
            
            _controller = null;
            GameTimer = null;
            
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
            one.Draw(g);


        }
    }
}
