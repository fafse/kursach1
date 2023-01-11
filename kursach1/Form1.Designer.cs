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
            this.gamePanel = new System.Windows.Forms.Panel();
            this.playerBox = new System.Windows.Forms.PictureBox();
            this.pauseButton = new System.Windows.Forms.Button();
            this.exitGameButton = new System.Windows.Forms.Button();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.pauseMenuPanel = new System.Windows.Forms.Panel();
            this.StopGameButton = new System.Windows.Forms.Button();
            this.helpGameButton = new System.Windows.Forms.Button();
            this.resumeGameButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.mainMenuPanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).BeginInit();
            this.pauseMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.mainMenuPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainMenuPanel.BackgroundImage")));
            this.mainMenuPanel.Controls.Add(this.flowLayoutPanel1);
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
            this.exitButton.Location = new System.Drawing.Point(2, 385);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(237, 73);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // scoresButton
            // 
            this.scoresButton.Location = new System.Drawing.Point(2, 269);
            this.scoresButton.Name = "scoresButton";
            this.scoresButton.Size = new System.Drawing.Size(237, 73);
            this.scoresButton.TabIndex = 2;
            this.scoresButton.Text = "Таблица Рекордов";
            this.scoresButton.UseVisualStyleBackColor = true;
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(2, 154);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(237, 73);
            this.settingsButton.TabIndex = 1;
            this.settingsButton.Text = "Настройки";
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(2, 21);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(237, 73);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Играть";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.playerBox);
            this.gamePanel.Controls.Add(this.pauseButton);
            this.gamePanel.Controls.Add(this.exitGameButton);
            this.gamePanel.Location = new System.Drawing.Point(0, 3);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(600, 720);
            this.gamePanel.TabIndex = 7;
            this.gamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.onPaint);
            // 
            // playerBox
            // 
            this.playerBox.BackColor = System.Drawing.Color.Transparent;
            this.playerBox.Location = new System.Drawing.Point(261, 535);
            this.playerBox.Name = "playerBox";
            this.playerBox.Size = new System.Drawing.Size(67, 61);
            this.playerBox.TabIndex = 2;
            this.playerBox.TabStop = false;
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
            this.pauseMenuPanel.Controls.Add(this.helpGameButton);
            this.pauseMenuPanel.Controls.Add(this.resumeGameButton);
            this.pauseMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.pauseMenuPanel.Name = "pauseMenuPanel";
            this.pauseMenuPanel.Size = new System.Drawing.Size(590, 714);
            this.pauseMenuPanel.TabIndex = 8;
            // 
            // StopGameButton
            // 
            this.StopGameButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StopGameButton.BackgroundImage")));
            this.StopGameButton.Location = new System.Drawing.Point(211, 481);
            this.StopGameButton.Name = "StopGameButton";
            this.StopGameButton.Size = new System.Drawing.Size(117, 51);
            this.StopGameButton.TabIndex = 2;
            this.StopGameButton.UseVisualStyleBackColor = true;
            this.StopGameButton.Click += new System.EventHandler(this.exitToMenuButton_Click);
            // 
            // helpGameButton
            // 
            this.helpGameButton.Location = new System.Drawing.Point(152, 261);
            this.helpGameButton.Name = "helpGameButton";
            this.helpGameButton.Size = new System.Drawing.Size(241, 118);
            this.helpGameButton.TabIndex = 1;
            this.helpGameButton.Text = "Помощь";
            this.helpGameButton.UseVisualStyleBackColor = true;
            // 
            // resumeGameButton
            // 
            this.resumeGameButton.Location = new System.Drawing.Point(152, 59);
            this.resumeGameButton.Name = "resumeGameButton";
            this.resumeGameButton.Size = new System.Drawing.Size(241, 118);
            this.resumeGameButton.TabIndex = 0;
            this.resumeGameButton.Text = "Продолжить";
            this.resumeGameButton.UseVisualStyleBackColor = true;
            this.resumeGameButton.Click += new System.EventHandler(this.resumeGameButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(639, 198);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 719);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.pauseMenuPanel);
            this.Controls.Add(this.mainMenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Pizza Game";
            this.mainMenuPanel.ResumeLayout(false);
            this.gamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).EndInit();
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
        private System.Windows.Forms.PictureBox playerBox;
        private System.Windows.Forms.Panel pauseMenuPanel;
        private System.Windows.Forms.Button StopGameButton;
        private System.Windows.Forms.Button helpGameButton;
        private System.Windows.Forms.Button resumeGameButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}

