using Flappy_Bird_Windows_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace games
{
    public partial class FlappyBird : Form
    {
        public FlappyBird()
        {
            InitializeComponent();
        }

        private void LoadGame(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Left  >= Width)
                {
                pictureBox1.Left = -pictureBox1.Width;
                }
            else
            {

                pictureBox1.Left = pictureBox1.Left + 15;
            }
         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            help help = new help();
            help.Show();
            this.Close();
        }
    }
}
