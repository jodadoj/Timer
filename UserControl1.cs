using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class uc_new_timer : UserControl
    {

        string currentlabel;

        public uc_new_timer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentlabel = input_timer_label.Text;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
