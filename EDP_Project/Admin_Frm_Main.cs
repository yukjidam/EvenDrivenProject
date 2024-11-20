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
    }
}
