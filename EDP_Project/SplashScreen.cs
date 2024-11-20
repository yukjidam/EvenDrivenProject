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
    public partial class SplashScreen : Form
    {
           
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void tmr_loading_Tick(object sender, EventArgs e)
        {
            pnl_loading.Width += 15;

            if(pnl_loading.Width >= 850)
            {
                tmr_loading.Stop();              
                Dashboard ds = new Dashboard();
                ds.Show();
                this.Close();
            }
        }

        private void pnl_splash_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
