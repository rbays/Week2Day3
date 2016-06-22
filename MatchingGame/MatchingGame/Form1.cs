using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class Form1 : Form
    {
        //create random object for randomizing positions
        Random randomizer = new Random();

        //list of letters, are icons in webdings, each is there twice
        List<string> icons = new List<string>
        {
            "!", "N", ",", "k", "b", "v", "w", "z",
            "!", "N", ",", "k", "b", "v", "w", "z"
        };

        //pointers to first and second clicked labels
        Label firstClicked = null;
        Label secondClicked = null;


        private void AssignIconsToSquares()
        {
            //assigns each icon to one of the 16 squares,
            //each icon appears twice ie 1 pair
        foreach (Control control in tableLayoutPanel2.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = randomizer.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }


        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
           
            startButton.Enabled = false;
        }

        private void label_Click(object sender, EventArgs e)
        {

            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    clickedLabel.ForeColor = Color.Black;

                    return;
                }
                else if (secondClicked == null)
                {
                    secondClicked = clickedLabel;
                    clickedLabel.ForeColor = Color.Black;
                    if (firstClicked.Text != secondClicked.Text)
                    {
                        timer1.Start();
                        return;
                    }
                    else
                    {
                        firstClicked = null;
                        secondClicked = null;
                    }
                    
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;


        }
    }
}
