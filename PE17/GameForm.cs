using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE17
{
    public partial class GameForm : Form
    {
        private int lowNumber;
        private int highNumber;
        private int randomNumber;
        private int remaingTime = 45;
        public GameForm(int lowNumber, int highNumber)
        {
            InitializeComponent();
            this.lowNumber = lowNumber;
            this.highNumber = highNumber;
            GenerateRandomNumber();
           // toolStripProgressBar1.Maximum = 450;
            toolStripProgressBar1.Value = toolStripProgressBar1.Maximum;
           // timer1.Interval = 500;
            StartTimer();

            this.AcceptButton = GuessButton;
        }

        private void GenerateRandomNumber()
        {
            Random rand = new Random();
            randomNumber = rand.Next(lowNumber, highNumber + 1);
        }

        private void StartTimer()
        {
            timer1.Start();
        }
        private void GuessButton_Click(object sender, EventArgs e)
        {
            int guess;

            if (!Int32.TryParse(currentGuessBox.Text, out guess))
            {
                MessageBox.Show("Invalid guess.");
                return;
            }

            
                int nGuesses = 1;


                if (guess > randomNumber)
                {
                    nGuesses = 1;
                    outputLabel.Visible = true;
                    outputLabel.Text = guess + " Too high!";
                    nGuesses++;
                }
                else if (guess < randomNumber)
                {
                    nGuesses = 1;
                    outputLabel.Visible = true;
                    outputLabel.Text = guess + " Too low!";
                    nGuesses++;
                }
                else
                {
                    nGuesses = 1;
                    outputLabel.Visible = true;
                    outputLabel.Text = "Correct!";
                    timer1.Stop();
                    this.Close();
                    MessageBox.Show($"Woohoo, you got it in {nGuesses} guesses!");
                }
            
                
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value--;
            if (toolStripProgressBar1.Value == 0)
            {
                timer1.Stop();
                MessageBox.Show($"Sorry, you didn't guess the number in time. It was {randomNumber}.");
                this.Close();
            }

           
          
        }
    }
}
