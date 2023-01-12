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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainMenuButtonFromSettings = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.pauseButton = new System.Windows.Forms.Button();
            this.exitGameButton = new System.Windows.Forms.Button();
            this.recordPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.pauseMenuPanel = new System.Windows.Forms.Panel();
            this.StopGameButton = new System.Windows.Forms.Button();
            this.resumeGameButton = new System.Windows.Forms.Button();
            this.Record1Text = new System.Windows.Forms.Label();
            this.Record2Text = new System.Windows.Forms.Label();
            this.Record3Text = new System.Windows.Forms.Label();
            this.Record4Text = new System.Windows.Forms.Label();
            this.Record5Text = new System.Windows.Forms.Label();
            this.Record6Text = new System.Windows.Forms.Label();
            this.Record7Text = new System.Windows.Forms.Label();
            this.Record8Text = new System.Windows.Forms.Label();
            this.Record9Text = new System.Windows.Forms.Label();
            this.Record10Text = new System.Windows.Forms.Label();
            this.Record1Data = new System.Windows.Forms.Label();
            this.Record2Data = new System.Windows.Forms.Label();
            this.Record3Data = new System.Windows.Forms.Label();
            this.Record4Data = new System.Windows.Forms.Label();
            this.Record5Data = new System.Windows.Forms.Label();
            this.Record6Data = new System.Windows.Forms.Label();
            this.Record7Data = new System.Windows.Forms.Label();
            this.Record9Data = new System.Windows.Forms.Label();
            this.Record10Data = new System.Windows.Forms.Label();
            this.Record8Data = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.mainMenuPanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.recordPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.scoresButton.Click += new System.EventHandler(this.scoresButton_Click);
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
            this.settingsPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.settingsPanel.Controls.Add(this.textBox3);
            this.settingsPanel.Controls.Add(this.label3);
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(397, 205);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(43, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Режим игры(1 - обычные люди, 2 - на выбывание)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.gamePanel.Controls.Add(this.pauseButton);
            this.gamePanel.Controls.Add(this.exitGameButton);
            this.gamePanel.Location = new System.Drawing.Point(0, 3);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(600, 720);
            this.gamePanel.TabIndex = 7;
            this.gamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.onPaint);
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
            // recordPanel
            // 
            this.recordPanel.Controls.Add(this.button2);
            this.recordPanel.Controls.Add(this.label4);
            this.recordPanel.Controls.Add(this.groupBox1);
            this.recordPanel.Location = new System.Drawing.Point(4, 1);
            this.recordPanel.Name = "recordPanel";
            this.recordPanel.Size = new System.Drawing.Size(907, 523);
            this.recordPanel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Таблица Рекордов";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Record8Data);
            this.groupBox1.Controls.Add(this.Record10Data);
            this.groupBox1.Controls.Add(this.Record9Data);
            this.groupBox1.Controls.Add(this.Record7Data);
            this.groupBox1.Controls.Add(this.Record6Data);
            this.groupBox1.Controls.Add(this.Record5Data);
            this.groupBox1.Controls.Add(this.Record4Data);
            this.groupBox1.Controls.Add(this.Record3Data);
            this.groupBox1.Controls.Add(this.Record2Data);
            this.groupBox1.Controls.Add(this.Record1Data);
            this.groupBox1.Controls.Add(this.Record10Text);
            this.groupBox1.Controls.Add(this.Record9Text);
            this.groupBox1.Controls.Add(this.Record8Text);
            this.groupBox1.Controls.Add(this.Record7Text);
            this.groupBox1.Controls.Add(this.Record6Text);
            this.groupBox1.Controls.Add(this.Record5Text);
            this.groupBox1.Controls.Add(this.Record4Text);
            this.groupBox1.Controls.Add(this.Record3Text);
            this.groupBox1.Controls.Add(this.Record2Text);
            this.groupBox1.Controls.Add(this.Record1Text);
            this.groupBox1.Location = new System.Drawing.Point(314, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(501, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 49);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // Record1Text
            // 
            this.Record1Text.AutoSize = true;
            this.Record1Text.Location = new System.Drawing.Point(3, 16);
            this.Record1Text.Name = "Record1Text";
            this.Record1Text.Size = new System.Drawing.Size(16, 13);
            this.Record1Text.TabIndex = 0;
            this.Record1Text.Text = "1.";
            this.Record1Text.Click += new System.EventHandler(this.label5_Click);
            // 
            // Record2Text
            // 
            this.Record2Text.AutoSize = true;
            this.Record2Text.Location = new System.Drawing.Point(3, 33);
            this.Record2Text.Name = "Record2Text";
            this.Record2Text.Size = new System.Drawing.Size(16, 13);
            this.Record2Text.TabIndex = 1;
            this.Record2Text.Text = "2.";
            // 
            // Record3Text
            // 
            this.Record3Text.AutoSize = true;
            this.Record3Text.Location = new System.Drawing.Point(3, 46);
            this.Record3Text.Name = "Record3Text";
            this.Record3Text.Size = new System.Drawing.Size(16, 13);
            this.Record3Text.TabIndex = 2;
            this.Record3Text.Text = "3.";
            // 
            // Record4Text
            // 
            this.Record4Text.AutoSize = true;
            this.Record4Text.Location = new System.Drawing.Point(3, 59);
            this.Record4Text.Name = "Record4Text";
            this.Record4Text.Size = new System.Drawing.Size(16, 13);
            this.Record4Text.TabIndex = 3;
            this.Record4Text.Text = "4.";
            // 
            // Record5Text
            // 
            this.Record5Text.AutoSize = true;
            this.Record5Text.Location = new System.Drawing.Point(3, 73);
            this.Record5Text.Name = "Record5Text";
            this.Record5Text.Size = new System.Drawing.Size(16, 13);
            this.Record5Text.TabIndex = 4;
            this.Record5Text.Text = "5.";
            // 
            // Record6Text
            // 
            this.Record6Text.AutoSize = true;
            this.Record6Text.Location = new System.Drawing.Point(3, 86);
            this.Record6Text.Name = "Record6Text";
            this.Record6Text.Size = new System.Drawing.Size(16, 13);
            this.Record6Text.TabIndex = 5;
            this.Record6Text.Text = "6.";
            // 
            // Record7Text
            // 
            this.Record7Text.AutoSize = true;
            this.Record7Text.Location = new System.Drawing.Point(3, 99);
            this.Record7Text.Name = "Record7Text";
            this.Record7Text.Size = new System.Drawing.Size(16, 13);
            this.Record7Text.TabIndex = 6;
            this.Record7Text.Text = "7.";
            // 
            // Record8Text
            // 
            this.Record8Text.AutoSize = true;
            this.Record8Text.Location = new System.Drawing.Point(3, 112);
            this.Record8Text.Name = "Record8Text";
            this.Record8Text.Size = new System.Drawing.Size(16, 13);
            this.Record8Text.TabIndex = 7;
            this.Record8Text.Text = "8.";
            // 
            // Record9Text
            // 
            this.Record9Text.AutoSize = true;
            this.Record9Text.Location = new System.Drawing.Point(3, 125);
            this.Record9Text.Name = "Record9Text";
            this.Record9Text.Size = new System.Drawing.Size(16, 13);
            this.Record9Text.TabIndex = 8;
            this.Record9Text.Text = "9.";
            // 
            // Record10Text
            // 
            this.Record10Text.AutoSize = true;
            this.Record10Text.Location = new System.Drawing.Point(3, 138);
            this.Record10Text.Name = "Record10Text";
            this.Record10Text.Size = new System.Drawing.Size(22, 13);
            this.Record10Text.TabIndex = 9;
            this.Record10Text.Text = "10.";
            // 
            // Record1Data
            // 
            this.Record1Data.AutoSize = true;
            this.Record1Data.Location = new System.Drawing.Point(25, 16);
            this.Record1Data.Name = "Record1Data";
            this.Record1Data.Size = new System.Drawing.Size(10, 13);
            this.Record1Data.TabIndex = 10;
            this.Record1Data.Text = "-";
            // 
            // Record2Data
            // 
            this.Record2Data.AutoSize = true;
            this.Record2Data.Location = new System.Drawing.Point(25, 33);
            this.Record2Data.Name = "Record2Data";
            this.Record2Data.Size = new System.Drawing.Size(10, 13);
            this.Record2Data.TabIndex = 11;
            this.Record2Data.Text = "-";
            // 
            // Record3Data
            // 
            this.Record3Data.AutoSize = true;
            this.Record3Data.Location = new System.Drawing.Point(25, 46);
            this.Record3Data.Name = "Record3Data";
            this.Record3Data.Size = new System.Drawing.Size(10, 13);
            this.Record3Data.TabIndex = 12;
            this.Record3Data.Text = "-";
            // 
            // Record4Data
            // 
            this.Record4Data.AutoSize = true;
            this.Record4Data.Location = new System.Drawing.Point(25, 59);
            this.Record4Data.Name = "Record4Data";
            this.Record4Data.Size = new System.Drawing.Size(10, 13);
            this.Record4Data.TabIndex = 13;
            this.Record4Data.Text = "-";
            // 
            // Record5Data
            // 
            this.Record5Data.AutoSize = true;
            this.Record5Data.Location = new System.Drawing.Point(25, 73);
            this.Record5Data.Name = "Record5Data";
            this.Record5Data.Size = new System.Drawing.Size(10, 13);
            this.Record5Data.TabIndex = 14;
            this.Record5Data.Text = "-";
            // 
            // Record6Data
            // 
            this.Record6Data.AutoSize = true;
            this.Record6Data.Location = new System.Drawing.Point(25, 86);
            this.Record6Data.Name = "Record6Data";
            this.Record6Data.Size = new System.Drawing.Size(10, 13);
            this.Record6Data.TabIndex = 15;
            this.Record6Data.Text = "-";
            // 
            // Record7Data
            // 
            this.Record7Data.AutoSize = true;
            this.Record7Data.Location = new System.Drawing.Point(25, 99);
            this.Record7Data.Name = "Record7Data";
            this.Record7Data.Size = new System.Drawing.Size(10, 13);
            this.Record7Data.TabIndex = 16;
            this.Record7Data.Text = "-";
            // 
            // Record9Data
            // 
            this.Record9Data.AutoSize = true;
            this.Record9Data.Location = new System.Drawing.Point(25, 125);
            this.Record9Data.Name = "Record9Data";
            this.Record9Data.Size = new System.Drawing.Size(10, 13);
            this.Record9Data.TabIndex = 17;
            this.Record9Data.Text = "-";
            // 
            // Record10Data
            // 
            this.Record10Data.AutoSize = true;
            this.Record10Data.Location = new System.Drawing.Point(25, 138);
            this.Record10Data.Name = "Record10Data";
            this.Record10Data.Size = new System.Drawing.Size(10, 13);
            this.Record10Data.TabIndex = 18;
            this.Record10Data.Text = "-";
            // 
            // Record8Data
            // 
            this.Record8Data.AutoSize = true;
            this.Record8Data.Location = new System.Drawing.Point(25, 112);
            this.Record8Data.Name = "Record8Data";
            this.Record8Data.Size = new System.Drawing.Size(10, 13);
            this.Record8Data.TabIndex = 19;
            this.Record8Data.Text = "-";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(703, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 88);
            this.button2.TabIndex = 2;
            this.button2.Text = "Главное Меню";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 719);
            this.Controls.Add(this.mainMenuPanel);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.pauseMenuPanel);
            this.Controls.Add(this.recordPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Pizza Game";
            this.mainMenuPanel.ResumeLayout(false);
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.gamePanel.ResumeLayout(false);
            this.recordPanel.ResumeLayout(false);
            this.recordPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private Panel recordPanel;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private GroupBox groupBox1;
        private Label Record1Text;
        private Label Record8Data;
        private Label Record10Data;
        private Label Record9Data;
        private Label Record7Data;
        private Label Record6Data;
        private Label Record5Data;
        private Label Record4Data;
        private Label Record3Data;
        private Label Record2Data;
        private Label Record1Data;
        private Label Record10Text;
        private Label Record9Text;
        private Label Record8Text;
        private Label Record7Text;
        private Label Record6Text;
        private Label Record5Text;
        private Label Record4Text;
        private Label Record3Text;
        private Label Record2Text;
        private Button button2;
    }
}

