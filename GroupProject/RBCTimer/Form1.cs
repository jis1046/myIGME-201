using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBCTimer
{


    public partial class RBCTimer : Form
    {
        TimeSpan timerValue = TimeSpan.Zero;
        public RBCTimer()
        {
            InitializeComponent();

            this.button1.Click += new EventHandler(Button1__Click);
            this.button2.Click += new EventHandler(Button2__Click);
            this.timer1.Tick += new EventHandler(Timer1__Tick);
        }

        private void Button1__Click(object sender, EventArgs e)
        {
            if (button1.Text == "Start")
            {
                timer1.Start();
                button1.Text = "Stop";
  
            }
            else
            {
                timer1.Stop();
                button1.Text = "Start";
            }
        }

        private void Button2__Click(object sender, EventArgs e)
        {
                // Stop the timer if it's running
                timer1.Stop();

                // Reset the timerValue variable to zero
                timerValue = TimeSpan.Zero;

                // Update the Label with the new time
                label1.Text = timerValue.ToString(@"hh\:mm\:ss");

        }

        private void Timer1__Tick(object sender, EventArgs e)
        {

                // Add one second to timerValue
                timerValue = timerValue.Add(TimeSpan.FromSeconds(1));

                // Update the Label with the new time
                label1.Text = timerValue.ToString(@"hh\:mm\:ss");

        }
    }
}
