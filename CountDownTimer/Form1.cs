using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDownTimer
{
    public partial class CountDownTimer : Form
    {
        public CountDownTimer()
        {
            InitializeComponent();
        }

        int timeLeft = 60;
        private void timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timerLabel.Text = timeLeft + " Seconds";
            }
            else
            {
                timer.Stop();
                timerLabel.Text = "Time is out";
            }
        }

        private void resetButton_Click_1(object sender, EventArgs e)
        {
            timer.Stop();
            timeLeft = 60;
            timerLabel.Text = timeLeft + " Seconds";
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            timeLeft = timeLeft + 1;
            timerLabel.Text = timeLeft.ToString() + " Seconds";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            timeLeft = timeLeft - 1;
            timerLabel.Text = timeLeft.ToString() + " Seconds";
        }

       
    }
}
