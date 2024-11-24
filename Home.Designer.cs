namespace Game2
{
    partial class Home
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
            System.Windows.Forms.Button helpButton;
            System.Windows.Forms.Button strButton;
            System.Windows.Forms.Button buttonTop;
            System.Windows.Forms.Button buttonScore;
            System.Windows.Forms.Button buttonPlayers;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            helpButton = new System.Windows.Forms.Button();
            strButton = new System.Windows.Forms.Button();
            buttonTop = new System.Windows.Forms.Button();
            buttonScore = new System.Windows.Forms.Button();
            buttonPlayers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helpButton
            // 
            helpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            helpButton.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            helpButton.Location = new System.Drawing.Point(397, 339);
            helpButton.Name = "helpButton";
            helpButton.Size = new System.Drawing.Size(190, 100);
            helpButton.TabIndex = 4;
            helpButton.Text = "HELP";
            helpButton.UseVisualStyleBackColor = true;
            helpButton.Click += new System.EventHandler(this.helpButton_Click_1);
            // 
            // strButton
            // 
            strButton.BackColor = System.Drawing.Color.White;
            strButton.Cursor = System.Windows.Forms.Cursors.Hand;
            strButton.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            strButton.Location = new System.Drawing.Point(397, 127);
            strButton.Name = "strButton";
            strButton.Size = new System.Drawing.Size(190, 100);
            strButton.TabIndex = 3;
            strButton.Text = "START";
            strButton.UseVisualStyleBackColor = false;
            strButton.Click += new System.EventHandler(this.strButton_Click);
            // 
            // buttonTop
            // 
            buttonTop.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonTop.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonTop.Location = new System.Drawing.Point(397, 233);
            buttonTop.Name = "buttonTop";
            buttonTop.Size = new System.Drawing.Size(190, 100);
            buttonTop.TabIndex = 6;
            buttonTop.Text = "All PLAYERS";
            buttonTop.UseVisualStyleBackColor = true;
            buttonTop.Click += new System.EventHandler(this.buttonTop_Click);
            // 
            // buttonScore
            // 
            buttonScore.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonScore.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonScore.Location = new System.Drawing.Point(593, 233);
            buttonScore.Name = "buttonScore";
            buttonScore.Size = new System.Drawing.Size(190, 100);
            buttonScore.TabIndex = 7;
            buttonScore.Text = "TOP SCORE";
            buttonScore.UseVisualStyleBackColor = true;
            buttonScore.Click += new System.EventHandler(this.buttonScore_Click);
            // 
            // buttonPlayers
            // 
            buttonPlayers.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonPlayers.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonPlayers.Location = new System.Drawing.Point(201, 233);
            buttonPlayers.Name = "buttonPlayers";
            buttonPlayers.Size = new System.Drawing.Size(190, 100);
            buttonPlayers.TabIndex = 8;
            buttonPlayers.Text = "TOP 5 USERS";
            buttonPlayers.UseVisualStyleBackColor = true;
            buttonPlayers.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Image = global::Game2.Properties.Resources._7000024_scary_horror_halloween_spider_animal_icon;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(984, 124);
            this.label1.TabIndex = 5;
            this.label1.Text = "HIT THE SPIDER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(buttonPlayers);
            this.Controls.Add(buttonScore);
            this.Controls.Add(buttonTop);
            this.Controls.Add(this.label1);
            this.Controls.Add(helpButton);
            this.Controls.Add(strButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}

