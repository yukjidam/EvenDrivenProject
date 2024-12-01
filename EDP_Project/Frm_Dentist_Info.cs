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
    public partial class Frm_Dentist_Info : Form
    {
        string constring = "Data Source=.;Initial Catalog=LuxBite_DB;Integrated Security=True;Encrypt=False;";
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dr;
        SqlDataAdapter adapter;
        DataTable dt;
        public Frm_Dentist_Info()
        {
            InitializeComponent();
            con = new SqlConnection(constring);
        }

        private void Frm_Dentist_Info_Load(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Admin_Frm_Main adf = new Admin_Frm_Main();  
            this.Close();
            adf.Show();
        }
        private void btn_browse_Click(object sender, EventArgs e)
        {
            //FILESTREAM DONE!!
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff"; 

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pic_patient_img.Image = new Bitmap(openFileDialog.FileName); 
            }
        }

        private void btn_record_save_Click(object sender, EventArgs e)
        {
            string default_username = "user";
            string default_password = "123";

            if (string.IsNullOrEmpty(txt_firstname.Text) || string.IsNullOrEmpty(txt_lastname.Text) ||
                string.IsNullOrEmpty(txt_age.Text) || string.IsNullOrEmpty(txt_contact.Text) ||
                string.IsNullOrEmpty(lbl_email.Text) || pic_patient_img.Image == null)
            {
                MessageBox.Show("Please fill in all the fields and select an image.");
                return; 
            }

            string query = "INSERT INTO Dentist (Username, Password, FirstName, MiddleName, LastName, Age, Contact, Email, Address, Emergency_Contact, Birthday, Image) " +
                           "VALUES (@username, @password, @first, @middle, @last, @age, @contact, @email, @address, @emergency, @birthday, @image)";

            //EXCEPTIONS DONE!!
            try
            {         
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", default_username);
                cmd.Parameters.AddWithValue("@password", default_password);
                cmd.Parameters.AddWithValue("@first", txt_firstname.Text);
                cmd.Parameters.AddWithValue("@middle", txt_middlename.Text);
                cmd.Parameters.AddWithValue("@last", txt_lastname.Text);
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txt_age.Text));
                cmd.Parameters.AddWithValue("@contact", Convert.ToInt64(txt_contact.Text));
                cmd.Parameters.AddWithValue("@email", txt_email.Text);
                cmd.Parameters.AddWithValue("@address", txt_address.Text);
                cmd.Parameters.AddWithValue("@emergency", Convert.ToInt64(txt_emergency.Text));
                cmd.Parameters.AddWithValue("@birthday", dtp_dob.Value);
                cmd.Parameters.AddWithValue("@image", getPhoto());


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record saved successfully.");

                DialogResult result = MessageBox.Show("Do you want to enter another entry?", "Confirmation", MessageBoxButtons.YesNo);

                if(result == DialogResult.Yes)
                {
                    txt_firstname.Clear();
                    txt_middlename.Clear();
                    txt_lastname.Clear();
                    txt_age.Clear();
                    txt_contact.Clear();
                    txt_email.Clear();
                    txt_emergency.Clear();
                    txt_address.Clear();
                    pic_patient_img.Image = null;
                    dtp_dob.Value = DateTime.Now;
                }
                else
                {
                    Admin_Frm_Main adm = new Admin_Frm_Main();
                    this.Hide();
                    adm.Show();                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            Logs("Account Created");
        }
        private byte[] getPhoto()
        {
            MemoryStream stream = new MemoryStream();
            pic_patient_img.Image.Save(stream, pic_patient_img.Image.RawFormat);
            return stream.GetBuffer();
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
