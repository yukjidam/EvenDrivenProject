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
    public partial class Login_Frm : Form
    {
        SplashScreen sp = new SplashScreen();
        public Login_Frm()
        {
            InitializeComponent();
        }

        private void btn_sign_in_Click(object sender, EventArgs e)
        {
            sp.Show();
            this.Hide();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {

        }
    }
}
