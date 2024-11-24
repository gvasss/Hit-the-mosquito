using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game2
{
    public partial class Form2 : Form
    {
        int choice;
        string name;

        Model1Container context = new Model1Container();
        public Form2()
        {
            InitializeComponent();
        }

        private void easyButton_Click_1(object sender, EventArgs e)
        {
            if (name == null)
            {
                MessageBox.Show("Παρακαλώ βάλτε Username");
            }
            else
            {
                choice = 1;
                new Form4(choice, name).Show();
                this.Close();
            }
        }

        private void mediumButton_Click_1(object sender, EventArgs e)
        {
            if (name == null)
            {
                MessageBox.Show("Παρακαλώ βάλτε Username");
            }
            else
            {
                choice = 2;
                new Form4(choice, name).Show();
                this.Close();
            }
        }

        private void hardButton_Click_1(object sender, EventArgs e)
        {
            if (name == null)
            {
                MessageBox.Show("Παρακαλώ βάλτε Username");
            }
            else
            {
                choice = 3;
                new Form4(choice, name).Show();
                this.Close();
            }
        }

        private void userTxt_TextChanged(object sender, EventArgs e)
        {
            name = userTxt.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }
    }
}
