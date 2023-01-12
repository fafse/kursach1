using kursach1.player;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace kursach1
{
    public partial class Form1 : Form
    {
        private Player player = null;
        private Game _game = null;
        private int gamemode;
        private int numPeople;
        private List<String> _recordTable;
        String path = "pictures/";
        public Form1()
        {
            gamemode = 1;
            numPeople = 10;
            _recordTable = new List<string>();
            InitializeComponent();
            
            Size = mainMenuPanel.Size;
            gamePanel.Visible = false;
            mainMenuPanel.Visible = true;
            pauseMenuPanel.Visible = false;
            List<Player> players = new List<Player>();
            for (int i = 0; i < 8; i++)
            {
                players.Add(new Player(path, i));
            }

            KeyDown += new KeyEventHandler(GetKeyboardKey);
            KeyUp += new KeyEventHandler(FreeKeyboard);
            typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty).SetValue(gamePanel, true, null);
            player = players[1];

        }

        private void FreeKeyboard(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A ||
                e.KeyCode == Keys.W ||
                e.KeyCode == Keys.S ||
                e.KeyCode == Keys.D
                )
            {
                _game.FreeKey();
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (_game == null)
            {
                _game = new Game(this, gamePanel, gamePanel.Size.Width, gamePanel.Size.Height, path,
                    player, button1,gamemode,numPeople);
                mainMenuPanel.Visible = false;
                gamePanel.Visible = true;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void exitToMenuButton_Click(object sender, EventArgs e)
        {
            ExitMenu();
        }

        public void ExitMenu()
        {
            this.Size = mainMenuPanel.Size;
            _game.StopGame();
            _game = null;
            gamePanel.Visible = false;
            pauseMenuPanel.Visible = false;
            mainMenuPanel.Visible = true;
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            gamePanel.Visible = false;
            pauseMenuPanel.Visible = true;
            _game.PauseGame();
        }

        private void resumeGameButton_Click(object sender, EventArgs e)
        {
            gamePanel.Visible = true;
            pauseMenuPanel.Visible = false;
            _game.ContunueGame();
        }

        private void GetKeyboardKey(object sender, KeyEventArgs e)
        {
            _game.ChangeDirection(e.KeyCode);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        
        

        private void onPaint(object sender, PaintEventArgs e)
        {
            if (player != null && _game != null)
            {
                _game.Draw(e.Graphics,pauseButton);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            /*if(_game!=null)
            {
                _game.Cook();
            }*/
        }
    }
}
