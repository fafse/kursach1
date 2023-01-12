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
        private String name="unknown player";
        private Player player = null;
        private Game _game = null;
        private int gamemode;
        public int lastScore;
        private RecordsTable _recordsTable;
        private int numPeople;
        
        String path = "pictures/";
        public Form1()
        {
            lastScore = 0;
            gamemode = 1;
            numPeople = 10;
            _recordsTable = new RecordsTable();
            InitializeComponent();
            
            Size = mainMenuPanel.Size;
            gamePanel.Visible = false;
            mainMenuPanel.Visible = true;
            pauseMenuPanel.Visible = false;
            settingsPanel.Visible = false;
            recordPanel.Visible = false;
            _recordsTable.ReadRecordsTable();
            KeyDown += new KeyEventHandler(GetKeyboardKey);
            KeyUp += new KeyEventHandler(FreeKeyboard);
            typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty).SetValue(gamePanel, true, null);
            player = new Player(path, 1);

        }

        private void FreeKeyboard(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A ||
                e.KeyCode == Keys.W ||
                e.KeyCode == Keys.S ||
                e.KeyCode == Keys.D
                )
            {
                if(_game!=null)
                _game.FreeKey();
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (_game == null)
            {
                _game = null;
                _game = new Game(this, gamePanel, gamePanel.Size.Width, gamePanel.Size.Height, path,
                    player, button1,gamemode,numPeople);
                mainMenuPanel.Visible = false;
                gamePanel.Visible = true;
                settingsPanel.Visible = false;
            }
        }


        

        private void exitButton_Click(object sender, EventArgs e)
        {
            _recordsTable.WriteRecordsTable();
            Close();
        }

        public void exitToMenuButton_Click(object sender, EventArgs e)
        {
            ExitMenu();
            player = null;
            player = new Player(path, 1);
            
        }

        public void ExitMenu()
        {
            this.Size = mainMenuPanel.Size;
            _game = null;
            _recordsTable.ChangeRecordsTable(name,(uint)lastScore);
            _recordsTable.WriteRecordsTable();
            gamePanel.Visible = false;
            pauseMenuPanel.Visible = false;
            mainMenuPanel.Visible = true;
            settingsPanel.Visible = false;
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
            if (_game != null)
            {
                _game.ChangeDirection(e.KeyCode);
            }
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
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            mainMenuPanel.Visible = false;
            settingsPanel.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int tmp;
            if(int.TryParse(textBox2.Text, out tmp))
            {
                numPeople = tmp;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mainMenuButtonFromSettings_Click(object sender, EventArgs e)
        {
            mainMenuPanel.Visible = true;
            settingsPanel.Visible = false;
            if (_game != null)
                _game = null;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int tmp;
            if (int.TryParse(textBox2.Text, out tmp))
            {
                if (tmp < 3 && tmp > 1)
                {
                    gamemode = tmp;
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainMenuPanel.Visible = true;
            recordPanel.Visible = false;
            if (_game != null)
                _game = null;
        }

        private void scoresButton_Click(object sender, EventArgs e)
        {
            mainMenuPanel.Visible = false;
            recordPanel.Visible = true;
         Record1Data.Text = _recordsTable.getSinglePlayer(0);
            Record2Data.Text = _recordsTable.getSinglePlayer(1);
            Record3Data.Text = _recordsTable.getSinglePlayer(2);
            Record4Data.Text = _recordsTable.getSinglePlayer(3);
            Record5Data.Text = _recordsTable.getSinglePlayer(4);
            Record6Data.Text = _recordsTable.getSinglePlayer(5);
            Record7Data.Text = _recordsTable.getSinglePlayer(6);
            Record8Data.Text = _recordsTable.getSinglePlayer(7);
            Record9Data.Text = _recordsTable.getSinglePlayer(8);
            Record10Data.Text = _recordsTable.getSinglePlayer(9);
        }
    }
}
