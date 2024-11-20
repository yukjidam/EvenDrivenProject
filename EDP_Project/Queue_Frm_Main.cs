using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDP_Project
{
    public partial class Queue_Frm_Main : Form
    {
        Queue_Frm qf = new Queue_Frm();
        public Queue_Frm_Main()
        {
            InitializeComponent();
        }

        private void btn_show_queue_Click(object sender, EventArgs e)
        {
            qf.Show();
        }
    }
}
