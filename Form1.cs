using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using stopwatch_app;

namespace stopwatch_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sec = 0;
        int min = 0;
        int hour = 0;

        private void timer_Tick(object sender, EventArgs e)
        {
            sec += 1;
            if (sec == 60)
            {
                sec = 0;
                min += 1;
            }
            if (min == 60)
            {
                min = 0;
                hour += 1;
            }
            
            if (sec < 10)
            {
                label_s.Text = "0" + sec;
            }
            else
            {
                label_s.Text = sec.ToString();
            }
            if (min < 10)
            {
                label_m.Text = "0" + min;
            }
            else
            {
                label_m.Text = min.ToString();
            }
            if (hour < 10)
            {
                label_h.Text = "0" + hour;
            }
            else
            {
                label_h.Text = hour.ToString();
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void button_pause_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            sec = 0;
            min = 0;
            hour = 0;
            label_s.Text = "00";
            label_m.Text = "00";
            label_h.Text = "00";
        }
    }
}
