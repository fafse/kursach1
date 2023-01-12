using System;
using System.Windows.Forms;

namespace kursach1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.scoresButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainMenuButtonFromSettings = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.exitGameButton = new System.Windows.Forms.Button();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.pauseMenuPanel = new System.Windows.Forms.Panel();
            this.StopGameButton = new System.Windows.Forms.Button();
            this.resumeGameButton = new System.Windows.Forms.Button();
            this.mainMenuPanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.pauseMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.mainMenuPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainMenuPanel.BackgroundImage")));
            this.mainMenuPanel.Controls.Add(this.exitButton);
            this.mainMenuPanel.Controls.Add(this.scoresButton);
            this.mainMenuPanel.Controls.Add(this.settingsButton);
            this.mainMenuPanel.Controls.Add(this.playButton);
            this.mainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.mainMenuPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(924, 531);
            this.mainMenuPanel.TabIndex = 6;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(0, 382);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(237, 73);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // scoresButton
            // 
            this.scoresButton.Location = new System.Drawing.Point(0, 266);
            this.scoresButton.Name = "scoresButton";
            this.scoresButton.Size = new System.Drawing.Size(237, 73);
            this.scoresButton.TabIndex = 2;
            this.scoresButton.Text = "Таблица Рекордов";
            this.scoresButton.UseVisualStyleBackColor = true;
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(0, 151);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(237, 73);
            this.settingsButton.TabIndex = 1;
            this.settingsButton.Text = "Настройки";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(0, 18);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(237, 73);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Играть";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.checkedListBox1);
            this.settingsPanel.Controls.Add(this.label2);
            this.settingsPanel.Controls.Add(this.label1);
            this.settingsPanel.Controls.Add(this.mainMenuButtonFromSettings);
            this.settingsPanel.Controls.Add(this.textBox2);
            this.settingsPanel.Controls.Add(this.textBox1);
            this.settingsPanel.Location = new System.Drawing.Point(2, 3);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(910, 527);
            this.settingsPanel.TabIndex = 4;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(138, 244);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(117, 64);
            this.checkedListBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество людей";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя игрока";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mainMenuButtonFromSettings
            // 
            this.mainMenuButtonFromSettings.Location = new System.Drawing.Point(598, 400);
            this.mainMenuButtonFromSettings.Name = "mainMenuButtonFromSettings";
            this.mainMenuButtonFromSettings.Size = new System.Drawing.Size(184, 62);
            this.mainMenuButtonFromSettings.TabIndex = 2;
            this.mainMenuButtonFromSettings.Text = "Главное меню";
            this.mainMenuButtonFromSettings.UseVisualStyleBackColor = true;
            this.mainMenuButtonFromSettings.Click += new System.EventHandler(this.mainMenuButtonFromSettings_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(222, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(43, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.button1);
            this.gamePanel.Controls.Add(this.pauseButton);
            this.gamePanel.Controls.Add(this.exitGameButton);
            this.gamePanel.Location = new System.Drawing.Point(0, 3);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(600, 720);
            this.gamePanel.TabIndex = 7;
            this.gamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.onPaint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(505, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 49);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.Color.Silver;
            this.pauseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pauseButton.BackgroundImage")));
            this.pauseButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pauseButton.FlatAppearance.BorderSize = 0;
            this.pauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pauseButton.Location = new System.Drawing.Point(397, 641);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(89, 38);
            this.pauseButton.TabIndex = 1;
            this.pauseButton.UseCompatibleTextRendering = true;
            this.pauseButton.UseVisualStyleBackColor = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // exitGameButton
            // 
            this.exitGameButton.BackColor = System.Drawing.Color.Silver;
            this.exitGameButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitGameButton.BackgroundImage")));
            this.exitGameButton.FlatAppearance.BorderSize = 0;
            this.exitGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitGameButton.Location = new System.Drawing.Point(492, 641);
            this.exitGameButton.Name = "exitGameButton";
            this.exitGameButton.Size = new System.Drawing.Size(86, 38);
            this.exitGameButton.TabIndex = 0;
            this.exitGameButton.UseVisualStyleBackColor = false;
            this.exitGameButton.Click += new System.EventHandler(this.exitToMenuButton_Click);
            // 
            // pauseMenuPanel
            // 
            this.pauseMenuPanel.Controls.Add(this.StopGameButton);
            this.pauseMenuPanel.Controls.Add(this.resumeGameButton);
            this.pauseMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.pauseMenuPanel.Name = "pauseMenuPanel";
            this.pauseMenuPanel.Size = new System.Drawing.Size(590, 714);
            this.pauseMenuPanel.TabIndex = 8;
            // 
            // StopGameButton
            // 
            this.StopGameButton.Location = new System.Drawing.Point(152, 410);
            this.StopGameButton.Name = "StopGameButton";
            this.StopGameButton.Size = new System.Drawing.Size(241, 118);
            this.StopGameButton.TabIndex = 2;
            this.StopGameButton.Text = "Главное меню";
            this.StopGameButton.UseVisualStyleBackColor = true;
            this.StopGameButton.Click += new System.EventHandler(this.exitToMenuButton_Click);
            // 
            // resumeGameButton
            // 
            this.resumeGameButton.Location = new System.Drawing.Point(152, 131);
            this.resumeGameButton.Name = "resumeGameButton";
            this.resumeGameButton.Size = new System.Drawing.Size(241, 118);
            this.resumeGameButton.TabIndex = 0;
            this.resumeGameButton.Text = "Продолжить";
            this.resumeGameButton.UseVisualStyleBackColor = true;
            this.resumeGameButton.Click += new System.EventHandler(this.resumeGameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 719);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.pauseMenuPanel);
            this.Controls.Add(this.mainMenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Pizza Game";
            this.mainMenuPanel.ResumeLayout(false);
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.gamePanel.ResumeLayout(false);
            this.pauseMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainMenuPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button scoresButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Button exitGameButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Panel pauseMenuPanel;
        private System.Windows.Forms.Button StopGameButton;
        private System.Windows.Forms.Button resumeGameButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Button button1;
        private Panel settingsPanel;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Button mainMenuButtonFromSettings;
        private Label label2;
        private CheckedListBox checkedListBox1;
    }
}

