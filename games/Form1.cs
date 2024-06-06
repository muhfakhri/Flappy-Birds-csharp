using games;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Windows_Form
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 8; 
        int gravity = 45;
        int score = 0;

        bool gameover = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Space)
            {
                
                gravity = -15;
            }


        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
          

            if (e.KeyCode == Keys.Space)
            {
               
                gravity = 15;
            }
            if(e.KeyCode == Keys.R && gameover)
            {
                RestartGame();
              
            }

        }

        private void endGame()
        {
           
            gameTimer.Stop();
            scoreText.Text += "   Game over!!!";
            gameover = true;

        }



        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity; 
            pipeBottom.Left -= pipeSpeed; 
            pipeTop.Left -= pipeSpeed; 
            scoreText.Text = "Score: " + score;

           

            if (pipeBottom.Left < -150)
            {
                
                pipeBottom.Left = 800;
                score++;
            }
            if (pipeTop.Left < -160)
            {
                
                pipeTop.Left = 950;
                score++;
            }

            
            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -25
                )
            {
                
                endGame();
            }


           
            if (score > 5)
            {
                pipeSpeed = 15;
            }

        }

        private void RestartGame()
        {

            gameover = false;
            flappyBird.Location = new Point(66, 274);
            pipeTop.Left = 800;
            pipeBottom.Left = 1200;

            score = 0;
            pipeSpeed = 8;
            scoreText.Text = "Score = 0";
            gameTimer.Start();
        }

        private void BackHome_Click(object sender, EventArgs e)
        {
            FlappyBird mw = new FlappyBird();
            mw.Show();
            this.Close();
        }
    }
}