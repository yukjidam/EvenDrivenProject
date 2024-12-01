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
    public partial class Frm_Logs : Form
    {
        string constring = "Data Source=.;Initial Catalog=LuxBite_DB;Integrated Security=True;Encrypt=False;";
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dr;

        public Frm_Logs()
        {
            InitializeComponent();
            con = new SqlConnection(constring);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Admin_Frm_Main fm = new Admin_Frm_Main();
            this.Hide();
            fm.Show();
        }
        private void DisplayLogs()
        {
            string query = "SELECT logs_date, logs_content FROM Logs ORDER BY logs_date DESC";
            cmd = new SqlCommand(query, con);
            con.Open();
            dr = cmd.ExecuteReader();
            txt_logs.Clear();

            while (dr.Read())
            {
                DateTime logDate = Convert.ToDateTime(dr["logs_date"]);
                string logContent = dr["logs_content"].ToString();
                string entry = $"{logDate:yyyy-MM-dd HH:mm:ss}: {logContent}{Environment.NewLine}";
                txt_logs.Text += entry;              
            }
            con.Close();
        }

        private void Frm_Logs_Load(object sender, EventArgs e)
        {
            DisplayLogs();
        }
    }
}
