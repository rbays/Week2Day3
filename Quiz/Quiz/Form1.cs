using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        public int timeLeft;

        //make questions visable
        private void makeVisable()
        {
            groupBox1.Show();
            groupBox2.Show();
            groupBox3.Show();
        }
        
        //check all 3 answers
        private void checkAnswers()
        {
            timer1.Stop();
           int score = 0;
           //check 1st answer
           if (question1Ans3.Checked){
                score += 1;
                }
            //check 2ns answer
            if (question2Ans2.Checked)
            {
                score += 1;
            }
            if (question3Ans3.Checked)
            {
                score += 1;
            }
            MessageBox.Show("You scored " + score + "/3 with " + timeLeft + " seconds left!");
        }

        public Form1()
        {
            InitializeComponent();
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timeLeft ==0)
            {
                timer1.Stop();
                MessageBox.Show("You are out of time!", "Game Over");
                startButton.Enabled = true;
            }
            else
            {
                timeLeft -= 1;
                timeLeftLabel.Text = (timeLeft + " seconds");
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            makeVisable();
            timeLeft = 20;
            timeLeftLabel.Text = timeLeft + " seconds";
            timer1.Start();
            startButton.Enabled = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            checkAnswers();
        }
    }
}
