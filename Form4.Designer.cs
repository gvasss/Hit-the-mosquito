namespace Game2
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.MENU = new System.Windows.Forms.GroupBox();
            this.labelHome = new System.Windows.Forms.Label();
            this.quitLbl = new System.Windows.Forms.Label();
            this.restartLbl = new System.Windows.Forms.Label();
            this.gameOverLbl = new System.Windows.Forms.Label();
            this.countdown = new System.Windows.Forms.Label();
            this.timerLbl = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MENU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MENU
            // 
            this.MENU.BackColor = System.Drawing.Color.Gray;
            this.MENU.Controls.Add(this.labelHome);
            this.MENU.Controls.Add(this.quitLbl);
            this.MENU.Controls.Add(this.restartLbl);
            this.MENU.Controls.Add(this.gameOverLbl);
            this.MENU.Location = new System.Drawing.Point(396, 239);
            this.MENU.Name = "MENU";
            this.MENU.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MENU.Size = new System.Drawing.Size(494, 263);
            this.MENU.TabIndex = 9;
            this.MENU.TabStop = false;
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelHome.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.ForeColor = System.Drawing.Color.White;
            this.labelHome.Location = new System.Drawing.Point(206, 118);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(74, 27);
            this.labelHome.TabIndex = 3;
            this.labelHome.Text = "HOME";
            this.labelHome.Click += new System.EventHandler(this.labelHome_Click);
            // 
            // quitLbl
            // 
            this.quitLbl.AutoSize = true;
            this.quitLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitLbl.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitLbl.ForeColor = System.Drawing.Color.White;
            this.quitLbl.Location = new System.Drawing.Point(206, 192);
            this.quitLbl.Name = "quitLbl";
            this.quitLbl.Size = new System.Drawing.Size(62, 27);
            this.quitLbl.TabIndex = 2;
            this.quitLbl.Text = "QUIT";
            this.quitLbl.Click += new System.EventHandler(this.quitLbl_Click_1);
            // 
            // restartLbl
            // 
            this.restartLbl.AutoSize = true;
            this.restartLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restartLbl.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartLbl.ForeColor = System.Drawing.Color.White;
            this.restartLbl.Location = new System.Drawing.Point(190, 154);
            this.restartLbl.Name = "restartLbl";
            this.restartLbl.Size = new System.Drawing.Size(102, 27);
            this.restartLbl.TabIndex = 1;
            this.restartLbl.Text = "RESTART";
            this.restartLbl.Click += new System.EventHandler(this.restartLbl_Click_1);
            // 
            // gameOverLbl
            // 
            this.gameOverLbl.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLbl.ForeColor = System.Drawing.Color.White;
            this.gameOverLbl.Location = new System.Drawing.Point(84, 30);
            this.gameOverLbl.Name = "gameOverLbl";
            this.gameOverLbl.Size = new System.Drawing.Size(324, 70);
            this.gameOverLbl.TabIndex = 0;
            this.gameOverLbl.Text = "GAME OVER";
            this.gameOverLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countdown
            // 
            this.countdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.countdown.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdown.ForeColor = System.Drawing.Color.White;
            this.countdown.Location = new System.Drawing.Point(1210, 17);
            this.countdown.Name = "countdown";
            this.countdown.Size = new System.Drawing.Size(42, 23);
            this.countdown.TabIndex = 8;
            // 
            // timerLbl
            // 
            this.timerLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timerLbl.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLbl.ForeColor = System.Drawing.Color.White;
            this.timerLbl.Location = new System.Drawing.Point(1104, 17);
            this.timerLbl.Name = "timerLbl";
            this.timerLbl.Size = new System.Drawing.Size(100, 23);
            this.timerLbl.TabIndex = 7;
            this.timerLbl.Text = "Time :";
            this.timerLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(12, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(103, 23);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "Score : 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 800;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 400;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick_1);
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Interval = 1100;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Game2.Properties.Resources._7000024_scary_horror_halloween_spider_animal_icon;
            this.pictureBox1.Location = new System.Drawing.Point(1146, 575);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.MENU);
            this.Controls.Add(this.countdown);
            this.Controls.Add(this.timerLbl);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Form4_Load_1);
            this.MENU.ResumeLayout(false);
            this.MENU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MENU;
        private System.Windows.Forms.Label quitLbl;
        private System.Windows.Forms.Label restartLbl;
        private System.Windows.Forms.Label gameOverLbl;
        private System.Windows.Forms.Label countdown;
        private System.Windows.Forms.Label timerLbl;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label labelHome;
    }
}