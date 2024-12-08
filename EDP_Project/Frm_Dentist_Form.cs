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
    public partial class Frm_Dentist_Form : Form
    {
        string constring = "Data Source=.;Initial Catalog=LuxBite_DB;Integrated Security=True;Encrypt=False;";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        private int dentistID;

        public Frm_Dentist_Form(int id)
        {
            InitializeComponent();
            con = new SqlConnection(constring);
            dentistID = id;
            LoadDentistDetails();
        }
        public Frm_Dentist_Form()
        {
            InitializeComponent();
           
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadDentistDetails()
        {
            string query = "SELECT ID, FirstName, LastName, Age, Contact, Email, Address, Birthday, Image, Emergency_Contact FROM Dentist WHERE ID = @id";

            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", dentistID);

            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string fullName = $"{dr["FirstName"]} {dr["LastName"]}";

                lbl_id.Text = dr["ID"].ToString();
                lbl_name .Text = fullName;
                lbl_contact.Text = dr["Contact"].ToString();
                lbl_email.Text = dr["Email"].ToString();
                lbl_address.Text = dr["Address"].ToString();
                lbl_birthday.Text = Convert.ToDateTime(dr["Birthday"]).ToString("yyyy-MM-dd");
                lbl_age.Text = dr["Age"].ToString();
                lbl_emergency.Text = dr["Emergency_Contact"].ToString();

                if (dr["Image"] != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])dr["Image"];
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {

                        pic_photo.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                   
                    pic_photo.Image = null; 
                }
            }

            con.Close();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pic_photo_Click(object sender, EventArgs e)
        {

        }
    }
}
