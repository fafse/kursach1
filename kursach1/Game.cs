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

        public Game(Form1 form, Panel gamePanel, int sizeX, int sizeY, string path, Player _player)
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
            _places.Add(new EatingPlace(path+"Chair_amp_amp_Table.png",new Point(200,200)));
            _places.Add(new EatingPlace(path+"Chair_amp_amp_Table.png",new Point(250,400)));
            for (int i = 0; i < 6; i++)
            {
                _guests.Add(new Guest(path+"guests.png", i));
                _guests[i].setPos(new Point(32*i+50,150));
            }
            _controller = new PhysicsController(_rectangles);
            this._player = _player;
            
            
            
            _player.AddUpdateToTimer(GameTimer);
            foreach (var guest in _guests)
            {
                guest.ShowPic(GameTimer);
            }
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
            foreach (var rectangle in _rectangles)
            {
                g.DrawRectangle(new Pen(Color.Chartreuse), rectangle);
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

            

            foreach (var guest in _guests)
            {
                guest.PlayAnimation(g);
            }
        }
    }
}
