using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EDP_Project
{
    public partial class Profile_Settings : Form
    {
        string constring = "Data Source=.;Initial Catalog=LuxBite_DB;Integrated Security=True;Encrypt=False;";
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter adapter;
        DataTable dt;

        private static Profile_Settings _instance;

        public static Profile_Settings Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new Profile_Settings();
                }
                return _instance;
            }
        }
        public Profile_Settings()
        {
            InitializeComponent();
            con = new SqlConnection(constring);
        }

        private void btn_add_account_Click(object sender, EventArgs e)
        {
            Upload_Profile up = new Upload_Profile();
            this.Hide();
            up.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_username_Click(object sender, EventArgs e)
        {
            Edit_Creds ed = new Edit_Creds();
            this.Hide();
            ed.Show();
        }
        private void Logs(string content)
        {
            string query = "INSERT INTO Logs (logs_date, logs_content) VALUES (@logs_date, @logs_content)";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@logs_date", DateTime.Now);
            cmd.Parameters.AddWithValue("@logs_content", content);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            using (Alert_Frm alertForm = new Alert_Frm())
            {
                this.Close();
                alertForm.ShowDialog();


                if (alertForm.IsConfirmed)
                {

                    foreach (Form openForm in Application.OpenForms)
                    {
                        if (openForm is Dashboard dashboardForm)
                        {
                            dashboardForm.Close();
                            break;
                        }
                    }
                    this.Close();
                    SplashScreen.IsLogout = true;
                    Logs("User " + Form1.CurrentUserID.ToString() + " Logged Out.");
                    SplashScreen splashScreen = new SplashScreen();
                    splashScreen.Show();
                }

            }


        }
    }
}
