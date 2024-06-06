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
    public partial class help : Form
    {
        public help()
        {
            InitializeComponent();
        }

        private void Kembali_Click(object sender, EventArgs e)
        {
            FlappyBird back = new FlappyBird();
            back.Show();
            this.Close();
        }
    }
}
