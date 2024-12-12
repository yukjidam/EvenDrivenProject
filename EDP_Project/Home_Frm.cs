using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EDP_Project
{
    public partial class Home_Frm : Form
    {
        string constring = "Data Source=.;Initial Catalog=LuxBite_DB;Integrated Security=True;Encrypt=False;";
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dr;
        SqlDataAdapter adapter;
        DataTable dt;


        int currentID;
        public Home_Frm()
        {
            InitializeComponent();
            con = new SqlConnection(constring);
            currentID = Form1.CurrentUserID;

            timer1.Interval = 1000;  
            timer1.Start();

        }

        private void Home_Frm_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void LoadUserData()
        {
            string query = "SELECT FirstName, LastName, Contact, Email, Image, Entries, Accommodate FROM Dentist WHERE ID = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", currentID);

            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    lbl_on_duty.Text = "Dr. " + dr["FirstName"].ToString() + " " + dr["LastName"].ToString();
                    lbl_accommodated.Text = dr["Accommodate"].ToString();
                    lbl_total_patient.Text = dr["Entries"].ToString();


                    string contact = dr["Contact"].ToString();
                    if (!contact.StartsWith("0"))
                    {
                        contact = "0" + contact;
                    }
                    lbl_doctor_contact.Text = contact;

                    lbl_doctor_email.Text = dr["Email"].ToString();

                    if (dr["Image"] != DBNull.Value)
                    {
                        byte[] imageBytes = (byte[])dr["Image"];
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            pic_doctor.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        pic_doctor.Image = null;
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadUserData();
        }
    }
}
