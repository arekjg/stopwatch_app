using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using stopwatch_app;

namespace stopwatch_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        // git test

        private void button_pause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label.Text = "00:00:00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

    }
}
