using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsQuiz
{
    public partial class Form1 : Form
    {
        //create a randomizer to generate random numbers
        Random randomizer = new Random();
        int timeLeft;

        //numbers to be added
        int addInt1;
        int addInt2;
        int addIntAns;

        //numbers for subtraction
        int subInt1;
        int subInt2;
        int subIntAns;

        //numbers for multiplication
        int multInt1;
        int multInt2;
        int multIntAns;

        //numbers for division
        int divInt1;
        int divInt2;
        int divIntAns;

        public Form1()
        {
           InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //generate addition components and answer
            addInt1 = randomizer.Next(1, 51);
            addInt2 = randomizer.Next(1, 51);
            addIntAns = addInt1 + addInt2;

            //generate subtraction components and answers
            subInt2 = randomizer.Next(1, 51);
            subIntAns = randomizer.Next(1, 51);
            subInt1 = subInt2 + subIntAns;

            //generate multiplication components and answers
            multInt1 = randomizer.Next(1, 13);
            multInt2 = randomizer.Next(1, 13);
            multIntAns = multInt1 * multInt2;

            //generate division components and answers
            divInt2 = randomizer.Next(1, 13);
            divIntAns = randomizer.Next(1, 13);
            divInt1 = divInt2 * divIntAns;

            //set addition question
            addLeft.Text = addInt1.ToString();
            addRight.Text = addInt2.ToString();

            //set subtraction question
            minusLeft.Text = subInt1.ToString();
            minusRight.Text = subInt2.ToString();

            //set multiplication question
            multiplyLeft.Text = multInt1.ToString();
            multiplyRight.Text = multInt2.ToString();

            //set division question
            divideLeft.Text = divInt1.ToString();
            divideRight.Text = divInt2.ToString();

            //reset all answer fields
            addAnswer.Value = 0;
            minusAnswer.Value = 0;
            multiplyAnswer.Value = 0;
            divideAnswer.Value = 0;

            //start the timer
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
            startButton.Enabled = false;
        }
        public bool checkAnswers()
        {
            if(addAnswer.Value == addIntAns &&
                minusAnswer.Value == subIntAns &&
                divideAnswer.Value == divIntAns &&
                multiplyAnswer.Value == multIntAns)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkAnswers())
            {
                timer1.Stop();
                MessageBox.Show("you got all of the answers right!", "Congratulations!");
                startButton.Enabled = true;
            }
            if (timeLeft > 0)
            {
                //update time each second if time remains
                timeLeft--;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                //if the user runs out of time show a message box
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                startButton.Enabled = true;
            }
        }
    }
}
