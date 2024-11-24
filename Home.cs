using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Game2
{
    public partial class Home : Form
    {
        private readonly Model1Container context = new Model1Container();

        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void helpButton_Click_1(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void strButton_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void buttonTop_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();

            // query prints in decending Username and Score
            var query2 = from s in context.Players1
                         orderby s.Score descending
                         select new { s.Username, s.Score };

            foreach (var item in query2)
            {
                builder.Append(item.ToString()).Append(Environment.NewLine);
            }

            MessageBox.Show(builder.ToString());
        }

        // button Top 5 Users
        private void button2_Click(object sender, EventArgs e)
        {
            var query3 = from p in context.Players1
                         orderby p.Score descending
                         select new { p.Username };

            StringBuilder builder2 = new StringBuilder();

            int i = 0;
            foreach (var item in query3)
            {
                if (i < 5)
                {
                    builder2.Append(item.ToString()).Append(Environment.NewLine);
                    i++;
                }
                else
                {
                    break;
                }
            }

            MessageBox.Show(builder2.ToString());
        }

        private void buttonScore_Click(object sender, EventArgs e)
        {
            var query4 = from p in context.Players1
                         orderby p.Score descending
                         select new { p.Score };

            StringBuilder builder3 = new StringBuilder();

            int i = 0;
            foreach (var item in query4)
            {
                if (i < 1)
                {
                    builder3.Append(item.ToString()).Append(Environment.NewLine);
                    i++;
                }
                else
                {
                    break;
                }
            }

            MessageBox.Show(builder3.ToString());
        }
    }
}
