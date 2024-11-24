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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExampleUsername name = new ExampleUsername("Example_Username");
            ExampleScore score = new ExampleScore(6);
            
            richTextBox1.Text = "To Username σου είναι: " + name.Username.ToString() + "\n" 
                + "Το σκόρ σου είναι: " + score.Score.ToString();
            this.Controls.Add(richTextBox1);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }
    }
}
