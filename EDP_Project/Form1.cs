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
using Guna.UI2.WinForms;

namespace EDP_Project
{
    public partial class Form1 : Form
    {
        string constring = "Data Source=.;Initial Catalog=LuxBite_DB;Integrated Security=True;Encrypt=False;";
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dr;

        int currentID = -1;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(constring);
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
            string query = "SELECT ID FROM Dentist WHERE Username = @username AND Password = @password";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", txtBox_username.Text);
            cmd.Parameters.AddWithValue("@password", txtBox_password.Text);
            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    currentID = Convert.ToInt32(dr["ID"]);
                    CurrentUserID = Convert.ToInt32(dr["ID"]);
                    
                }
                ResetGunaTextBoxHighlight(txtBox_password);
                ResetGunaTextBoxHighlight(txtBox_username);
                SplashScreen sc = new SplashScreen();
                sc.Show();
                this.Hide();
            }
            else
            {
                Highlight(txtBox_username);
                Highlight(txtBox_password);

            }

            con.Close();
            Logs($"Action Performed: Admin Logged In (User ID: {currentID})");

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void Highlight(Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            textBox.FillColor = Color.MistyRose;      
            textBox.BorderColor = Color.Red;          
            textBox.FocusedState.BorderColor = Color.DarkRed; 
        }

        private void ResetGunaTextBoxHighlight(Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            textBox.FillColor = Color.White;          
            textBox.BorderColor = Color.Silver;       
            textBox.FocusedState.BorderColor = Color.Blue;
        }
        public static int CurrentUserID { get; set; }

    }
}
