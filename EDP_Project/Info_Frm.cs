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
    public partial class Info_Frm : Form
    {
        string constring = "Data Source=.;Initial Catalog=LuxBite_DB;Integrated Security=True;Encrypt=False;";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        int id;
        int id_log;

        public Info_Frm()
        {
            InitializeComponent();
            con = new SqlConnection(constring);
            DisplayNextPatientID();
            id = Form1.CurrentUserID;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void DisplayNextPatientID()
        {
            string query = "SELECT IDENT_CURRENT('Patients') + IDENT_INCR('Patients') AS NextID";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                object result = cmd.ExecuteScalar();
                con.Close();

                if (result != null && int.TryParse(result.ToString(), out int nextID))
                {
                    lbl_id.Text =  nextID.ToString();
                    id_log = nextID;
                }
                else
                {
                    lbl_id.Text = "Unable to fetch next ID.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching next ID: " + ex.Message);
            }
        }

        private void btn_record_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_lastname.Text) || string.IsNullOrEmpty(txt_firstname.Text) ||
                string.IsNullOrEmpty(txt_contact.Text) || string.IsNullOrEmpty(txt_emergency_contact.Text))
            {
                MessageBox.Show("Please fill in all the required fields (Lastname, Firstname, Contact, Emergency Contact).");
                return;
            }

            string query = "INSERT INTO Patients (Lastname, Firstname, Middlename, Age, ContactNumber, EmailAddress, HomeAddress, Allergies, CurrentMedication, MedicalCondition, EmergencyContact, NextAppointmentDate, ReasonForVisit, Image) " +
                           "VALUES (@lastname, @firstname, @middlename, @age, @contact, @email, @address, @allergies, @medication, @condition, @emergency, @appointment, @reason, @image)";

            try
            {                
                con.Open();            
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@lastname", txt_lastname.Text);
                cmd.Parameters.AddWithValue("@firstname", txt_firstname.Text);
                cmd.Parameters.AddWithValue("@middlename", txt_middlename.Text);
                cmd.Parameters.AddWithValue("@age", txt_age.Text);
                cmd.Parameters.AddWithValue("@contact", Convert.ToInt64(txt_contact.Text));
                cmd.Parameters.AddWithValue("@email", txt_email.Text);
                cmd.Parameters.AddWithValue("@address", txt_address.Text);
                cmd.Parameters.AddWithValue("@allergies", txt_allergies.Text);
                cmd.Parameters.AddWithValue("@medication", txt_medication.Text);
                cmd.Parameters.AddWithValue("@condition", txt_condition.Text);
                cmd.Parameters.AddWithValue("@emergency", Convert.ToInt64(txt_emergency_contact.Text));
                cmd.Parameters.AddWithValue("@appointment", dtp_appointment.Value);
                cmd.Parameters.AddWithValue("@reason", txt_reason.Text);

                if (pic_patient_img.Image != null)
                {
                    cmd.Parameters.AddWithValue("@image", ImageToByteArray(pic_patient_img.Image));
                }
                else
                {
                    cmd.Parameters.AddWithValue("@image", DBNull.Value);
                }   
                cmd.ExecuteNonQuery();
                con.Close();

                UpdateEntries();
                showToast("Success", "Record Saved!");
                Logs("Record Saved ID :" + id_log.ToString());
                ClearForm();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void showToast(string type, string message)
        {
            Toast tst = new Toast(type, message);

            tst.Opacity = 0; 
            tst.Show();
            Timer fadeInTimer = new Timer();
            fadeInTimer.Interval = 50;
            fadeInTimer.Tick += (sender, e) =>
            {
                if (tst.Opacity < 1)
                {
                    tst.Opacity += 0.15; 
                }
                else
                {
                    fadeInTimer.Stop(); 
                }
            };
            fadeInTimer.Start();
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
        public void UpdateEntries()
        {
            try
            {
                
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

             
                string incrementQuery = @"
            IF EXISTS (SELECT 1 FROM Dentist WHERE ID = @userID)
            BEGIN
                UPDATE Dentist 
                SET Entries = ISNULL(Entries, 0) + 1 
                WHERE ID = @userID
            END
            ELSE
            BEGIN
                INSERT INTO Dentist (ID, Entries) 
                VALUES (@userID, 1)
            END";

                using (SqlCommand incrementCmd = new SqlCommand(incrementQuery, con))
                {
                    incrementCmd.Parameters.AddWithValue("@userID", Form1.CurrentUserID);
                    incrementCmd.ExecuteNonQuery(); 
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error incrementing Entries: " + ex.Message);
            }
        }




        private void btn_browse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select an Image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"; 
                openFileDialog.Multiselect = false; 

                
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        
                        pic_patient_img.Image = Image.FromFile(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Unable to load image. " + ex.Message);
                    }
                }
            }
        }
        private byte[] ImageToByteArray(Image image)
        {
            MemoryStream stream = new MemoryStream();
            pic_patient_img.Image.Save(stream, pic_patient_img.Image.RawFormat);
            return stream.GetBuffer();
        }
        private void ClearForm()
        {
            txt_lastname.Clear();
            txt_firstname.Clear();
            txt_middlename.Clear();
            txt_age.Clear();
            txt_contact.Clear();
            txt_email.Clear();
            txt_address.Clear();
            txt_allergies.Clear();
            txt_medication.Clear();
            txt_condition.Clear();
            txt_emergency_contact.Clear();
            txt_reason.Clear();
            dtp_appointment.Value = DateTime.Now;
            pic_patient_img.Image = null; 
        }

        private void lbl_id_Click(object sender, EventArgs e)
        {

        }
    }
}
