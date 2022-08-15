using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();

            CountDownTimer timer = new CountDownTimer();
            
            //set to 30 mins
            timer.SetTime(0, 20);

            timer.Start();

            //update label text
            timer.TimeChanged += () => timerLabel.Text = timer.TimeLeftMsStr;

            // show messageBox on timer = 00:00.000
            //timer.CountDownFinished += () => MessageBox.Show("Timer finished the work!");
            timer.CountDownFinished += () => Application.Exit();

            //timer step. By default is 1 second
            timer.StepMs = 77; // for nice milliseconds time switch
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
