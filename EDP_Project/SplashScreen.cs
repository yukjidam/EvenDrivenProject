using System;
using System.Threading;
using System.Windows.Forms;

namespace EDP_Project
{
    public partial class SplashScreen : Form
    {
        private Thread loadingThread;

        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            //THREADING DONE!
            loadingThread = new Thread(PerformLoading);
            loadingThread.IsBackground = true;
            loadingThread.Start();
            tmr_loading.Start();
        }

        private void PerformLoading()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
            }
        }

        private void tmr_loading_Tick(object sender, EventArgs e)
        {
            pnl_loading.Width += 15;

            if (pnl_loading.Width >= 850)
            {
                tmr_loading.Stop();
                Dashboard ds = new Dashboard();
                ds.Show();
                this.Hide();
            }
        }

        private void pnl_splash_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
