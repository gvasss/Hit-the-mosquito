using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game2
{
    public partial class Form4 : Form
    {
        Model1Container context = new Model1Container();

        Random r;
        int score;
        string name;
        int choice;
        int sec = 10;

        public Form4(int choice, string name)
        {
            InitializeComponent();
            ChoiceFunction(choice);
            GameOver();
            MENU.Hide();
            this.name = name;
            this.choice = choice;
        }

        private void Form4_Load_1(object sender, EventArgs e)
        {
            r = new Random();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            int x = r.Next(0, 1200);
            int y = r.Next(0, 550);
            pictureBox1.Location = new Point(x, y);
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            int x = r.Next(0, 1200);
            int y = r.Next(0, 550);
            pictureBox1.Location = new Point(x, y);
        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            int x = r.Next(0, 1200);
            int y = r.Next(0, 550);
            pictureBox1.Location = new Point(x, y);
        }

        //Choice function that is setting the difficulty
        private void ChoiceFunction(int choice)
        {
            if (choice == 1)
            {
                timer1.Start();
                timer2.Enabled = false;
                timer3.Enabled = false;
            }
            else if (choice == 2)
            {
                timer2.Start();
                timer1.Enabled = false;
                timer3.Enabled = false;
            }
            else
            {
                timer3.Start();
                timer2.Enabled = false;
                timer1.Enabled = false;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (choice == 1)
            {
                score++;
            }
            else if (choice == 2)
            {
                score = score + 2;
            }
            else
            {
                score = score + 3;
            }
            lblScore.Text = "Score : " + score;
        }

        private void GameOver()
        {
            if (sec < 0)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                MENU.Show();
                pictureBox1.Hide();
            }
        }

        private void restartLbl_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Show();
            pictureBox1.Location = new Point(112, 295);
            lblScore.Text = "Score : 0 ";
            sec = 10;
            this.Close();
            new Form2().Show();
        }

        private void quitLbl_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TopScore()
        {
            Player player = new Player();
            player.Username = name.ToString().Trim();
            player.Score = score;
            context.Players1.Add(player);
            context.SaveChanges();
        }

        private void timer4_Tick_1(object sender, EventArgs e)
        {
            countdown.Text = sec--.ToString();

            if (sec < 0)
            {
                timer4.Stop();
                GameOver();
                TopScore();
            }
        }

        private void labelHome_Click(object sender, EventArgs e)
        {
            this.Close();
            new Home().Show();
        }
    }
}
