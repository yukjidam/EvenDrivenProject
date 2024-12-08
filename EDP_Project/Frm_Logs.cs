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
using System.IO;

namespace EDP_Project
{
    public partial class Frm_Logs : Form
    {
        string constring = "Data Source=.;Initial Catalog=LuxBite_DB;Integrated Security=True;Encrypt=False;";
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dr;

        private DateTime lastDisplayedDate;

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
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            string query = "SELECT logs_date, logs_content FROM Logs WHERE CAST(logs_date AS DATE) = @today ORDER BY logs_date DESC";

            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@today", today);

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
            DateTime currentDate = DateTime.Now.Date;

            if (lastDisplayedDate != currentDate)
            {
                DisplayLogs(); 
                lastDisplayedDate = currentDate; 
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveLogs();
        }
        private void SaveLogs()
        {
            string query = "SELECT logs_date, logs_content FROM Logs ORDER BY logs_date DESC";
            con.Open();
            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();

            StringBuilder logContent = new StringBuilder();

            while (dr.Read())
            {
                DateTime logDate = Convert.ToDateTime(dr["logs_date"]);
                string logEntry = dr["logs_content"].ToString();
                logContent.AppendLine($"{logDate:yyyy-MM-dd HH:mm:ss}: {logEntry}");
            }
            dr.Close();

            //Streams DONE!
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Logs.txt");
            File.WriteAllText(filePath, logContent.ToString());
            MessageBox.Show($"Logs saved successfully to {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start("notepad.exe", filePath);
            con.Close();
        }
    }
}
