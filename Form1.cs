using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        System.Timers.Timer current_timer;
        int current_hours;
        int current_mins;
        int current_secs;
        int current_ms;

        int time_01;
        int time_02;
        int time_03;
        int time_04;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            current_timer = new System.Timers.Timer();
            current_timer.Interval = 1;
            current_timer.Elapsed += OnTimeEvent;

        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                current_ms += 1;
                if (current_ms >= 60)
                {
                    current_ms = 0;
                    current_secs += 1;
                }
                if (current_secs == 60)
                {
                    current_secs = 0;
                    current_mins += 1;
                }
                if (current_mins == 60)
                {
                    current_mins = 0;
                    current_hours += 1;
                }

                lbl_current_time.Text = string.Format(
                    "{0}:{1}:{2}:{3}",
                    current_hours.ToString().PadLeft(2, '0'),
                    current_mins.ToString().PadLeft(2, '0'),
                    current_secs.ToString().PadLeft(2, '0'),
                    (current_ms*10/6).ToString().PadLeft(2, '0')
                    );

            }
            ));
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            current_timer.Start();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            current_timer.Stop();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            current_timer.Stop();

            string saved_time = lbl_current_time.Text;

            current_ms = 0;
            current_secs = 0;
            current_mins = 0;
            current_hours = 0;
            lbl_current_time.Text = "00:00:00:00";

            if (time_01 == 0)
            {
                lbl_time_04.Text = lbl_time_03.Text;
                lbl_time_03.Text = lbl_time_02.Text;
                lbl_time_02.Text = lbl_time_01.Text;
                lbl_time_01.Text = saved_time;
                time_01 += 1;
            }
            else if (time_02 < time_01)
            {
                lbl_time_04.Text = lbl_time_03.Text;
                lbl_time_03.Text = lbl_time_02.Text;
                lbl_time_02.Text = lbl_time_01.Text;
                lbl_time_01.Text = saved_time;
                time_02 += 1;
            }
            else if (time_03 < time_02)
            {
                lbl_time_04.Text = lbl_time_03.Text;
                lbl_time_03.Text = lbl_time_02.Text;
                lbl_time_02.Text = lbl_time_01.Text;
                lbl_time_01.Text = saved_time;
                time_03 += 1;
            }
            else if (time_04 < time_03)
            {
                lbl_time_04.Text = lbl_time_03.Text;
                lbl_time_03.Text = lbl_time_02.Text;
                lbl_time_02.Text = lbl_time_01.Text;
                lbl_time_01.Text = saved_time;
                time_04 += 1;
            }
            else if (time_01 == time_04)
            {
                lbl_time_04.Text = lbl_time_03.Text;
                lbl_time_03.Text = lbl_time_02.Text;
                lbl_time_02.Text = lbl_time_01.Text;
                lbl_time_01.Text = saved_time;
                time_01 += 1;
            }
        }
    }
}
