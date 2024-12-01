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
    
    public partial class Admin_Frm_Main : Form
    {
        Admin_Frm_Login adl = new Admin_Frm_Login();
        public Admin_Frm_Main()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close(); 
            adl.Show();
        }

        private void btn_add_account_Click(object sender, EventArgs e)
        {
            Frm_Dentist_Info di = new Frm_Dentist_Info();
            di.Show();
            this.Hide();
        }

        private void btn_acc_list_Click(object sender, EventArgs e)
        {
            Frm_Dentist_List dl = new Frm_Dentist_List();
            dl.Show();
            this.Hide();
        }

        private void btn_logs_Click(object sender, EventArgs e)
        {
            Frm_Logs fl = new Frm_Logs();   
            fl.Show();
            this.Hide();
        }
    }
}
