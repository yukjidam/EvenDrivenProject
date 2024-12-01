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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.X)
            {
                Admin_Frm_Login ad = new Admin_Frm_Login();
                ad.Show();
            }
        }

        private void btn_sign_in_Click_1(object sender, EventArgs e)
        {
            SplashScreen sc = new SplashScreen();
            sc.Show();
            this.Hide();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
