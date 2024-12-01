using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Windows.Media;
using System.Data.SqlClient;

namespace EDP_Project
{
    public partial class Admin_Frm_Login : Form
    {
        //please change connection string if using different system
        //DATABASE CONNECTION DONE!!
        string constring = "Data Source=.;Initial Catalog=LuxBite_DB;Integrated Security=True;Encrypt=False;";
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dr;

        public Admin_Frm_Login()
        {
            InitializeComponent();
            con = new SqlConnection(constring);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //DATABASE QUERY DONE!!
            string query = "select * from Admin where Username=@username and Password=@password";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", txt_username.Text);
            cmd.Parameters.AddWithValue("@password", txt_password.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                
                Admin_Frm_Main adm = new Admin_Frm_Main();
                adm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password is Incorrect.");
            }           
            con.Close();
            Logs("Action Performed: Admin Logged In");
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
    }
}
