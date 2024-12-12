using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace EDP_Project
{
    public partial class SplashScreen : Form
    {
        private Thread loadingThread;
        public static bool IsLogout { get; set; } = false;

        public SplashScreen()
        {
            InitializeComponent();
        }

        public void LogoutAndReturnToLogin()
        {
           
            foreach (Form form in Application.OpenForms)
            {
                if (form != this) 
                {
                    form.Close(); 
                }
            }

            
            Form1 loginForm = new Form1();
            loginForm.Show(); 
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

                if (IsLogout)
                {          
                    Form1 loginForm = new Form1();
                    loginForm.Show();  
                    this.Close();
                }
                else
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();                  
                    this.Close();
                }
            }
        }

        private void pnl_splash_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_splash_Paint_1(object sender, PaintEventArgs e)
        {

        }      
    }
}
