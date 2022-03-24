using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DongHoBamGio
{
    public partial class DongHoBamGio: UserControl
    {
        public DongHoBamGio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            milisecond += 1;
            labelMS.Text = milisecond.ToString();
            labelS.Text = hour + ":" + minute + ":" + second;
            
            if (milisecond == 1000)
            {
                milisecond = 0;
                second += 1;
            }
            if (second == 60)
            {
                second = 0;
                minute += 1;
            }
            if (minute == 60)
            {
                minute = 0;
                hour += 1;
            }            
        }

        private int milisecond = 0;
        private int second = 0;
        private int minute = 0;
        private int hour = 0;

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
                buttonStartStop.Text = "Stop";
                buttonLap.Text = "Lap";
                timer1.Interval = 1;
            }
            else
            {
                timer1.Enabled = false;
                buttonStartStop.Text = "Start";
                buttonLap.Text = "Lap, Reset";
            }
        }

        private void buttonLap_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter txt = new System.IO.StreamWriter("E:\\LuuDuLieuSinhVien\\TranGiaPhuc\\Buoi3\\bamgio.txt");

            txt.WriteLine(labelS.Text + "    " + labelMS.Text);
            txt.Close();

            if (timer1.Enabled == false)
            {
                milisecond = 0;
                second = 0;
                minute = 0;
                hour = 0;
                labelMS.Text = "0";
                labelS.Text = "0:0:0";
            }
        }
    }
}
