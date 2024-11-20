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
    public partial class Admin_Frm_Login : Form
    {
        public Admin_Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Admin_Frm_Main adm = new Admin_Frm_Main(); 
            adm.Show();
            this.Hide();
        }
    }
}
