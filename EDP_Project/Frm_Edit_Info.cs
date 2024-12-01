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
using System.Runtime.InteropServices;

namespace EDP_Project
{
    public partial class Frm_Edit_Info : Form
    {

        string constring = "Data Source=.;Initial Catalog=LuxBite_DB;Integrated Security=True;Encrypt=False;";
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dr;

        private string originalFirstName, originalMiddleName, originalLastName, originalEmail, originalAddress;
        private int originalAge;
        private long originalContact, originalEmergencyContact;
        private DateTime originalBirthday;
        private byte[] originalImage;
        private int recordId;


        public Frm_Edit_Info(int id, string firstName, string middleName, string lastName, int age, long contact, string email, long emergencyContact, string address, DateTime birthday, byte[] image)
        {
            InitializeComponent();
            con = new SqlConnection(constring);
            recordId = id;
            originalFirstName = firstName;
            originalMiddleName = middleName;
            originalLastName = lastName;
            originalAge = age;
            originalContact = contact;
            originalEmail = email;
            originalEmergencyContact = emergencyContact;
            originalAddress = address;
            originalBirthday = birthday;
            originalImage = image;

            txt_firstname.Text = firstName;
            txt_middlename.Text = middleName;
            txt_lastname.Text = lastName;
            txt_age.Text = age.ToString();
            txt_contact.Text = contact.ToString();
            txt_email.Text = email;
            txt_emergency.Text = emergencyContact.ToString();
            txt_address.Text = address;
            dtp_dob.Value = birthday;

            if (image != null)
            {
                using (MemoryStream ms = new MemoryStream(image))
                {
                    pic_patient_img.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pic_patient_img.Image = null;
            }
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pic_patient_img.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void btn_record_save_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Dentist SET ";

            List<SqlParameter> parameters = new List<SqlParameter>();

            bool isUpdated = false;

            if (txt_firstname.Text != originalFirstName)
            {
                query += "FirstName = @firstName, ";
                parameters.Add(new SqlParameter("@firstName", txt_firstname.Text));
                isUpdated = true;
            }

            if (txt_middlename.Text != originalMiddleName)
            {
                query += "MiddleName = @middleName, ";
                parameters.Add(new SqlParameter("@middleName", txt_middlename.Text));
                isUpdated = true;
            }

            if (txt_lastname.Text != originalLastName)
            {
                query += "LastName = @lastName, ";
                parameters.Add(new SqlParameter("@lastName", txt_lastname.Text));
                isUpdated = true;
            }

            if (txt_age.Text != originalAge.ToString())
            {
                query += "Age = @age, ";
                parameters.Add(new SqlParameter("@age", Convert.ToInt32(txt_age.Text)));
                isUpdated = true;
            }

            if (txt_contact.Text != originalContact.ToString())
            {
                query += "Contact = @contact, ";
                parameters.Add(new SqlParameter("@contact", Convert.ToInt64(txt_contact.Text)));
                isUpdated = true;
            }

            if (txt_email.Text != originalEmail)
            {
                query += "Email = @email, ";
                parameters.Add(new SqlParameter("@email", txt_email.Text));
                isUpdated = true;
            }

            if (txt_emergency.Text != originalEmergencyContact.ToString())
            {
                query += "Emergency_Contact = @emergency, ";
                parameters.Add(new SqlParameter("@emergency", Convert.ToInt64(txt_emergency.Text)));
                isUpdated = true;
            }

            if (txt_address.Text != originalAddress)
            {
                query += "Address = @address, ";
                parameters.Add(new SqlParameter("@address", txt_address.Text));
                isUpdated = true;
            }

            if (dtp_dob.Value != originalBirthday)
            {
                query += "Birthday = @birthday, ";
                parameters.Add(new SqlParameter("@birthday", dtp_dob.Value));
                isUpdated = true;
            }

            if (isUpdated)
            {
                query = query.TrimEnd(',', ' ') + " WHERE ID = @id";
                parameters.Add(new SqlParameter("@id", recordId));

                try
                {
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddRange(parameters.ToArray());

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record updated successfully.");
                    con.Close();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating record: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No changes were made to update.");
            }
            Logs("ID " + recordId + " Edited");
        }
       
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
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
