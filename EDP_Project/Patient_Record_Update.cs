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
    public partial class Patient_Record_Update : Form
    {
        string constring = "Data Source=.;Initial Catalog=LuxBite_DB;Integrated Security=True;Encrypt=False;";
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dr;
        SqlDataAdapter adapter;
        DataTable dt;

        private string originalFirstName, originalMiddleName, originalLastName, originalEmail, originalHomeAddress;
        private int originalAge;
        private long originalContact, originalEmergencyContact;
        private string originalAllergies, originalMedicalCondition, originalCurrentMedication, originalReasonForVisit;

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_record_save_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Patients SET ";

            List<SqlParameter> parameters = new List<SqlParameter>();

            bool isUpdated = false;

            if (txt_firstname.Text != originalFirstName)
            {
                query += "Firstname = @firstname, ";
                parameters.Add(new SqlParameter("@firstname", txt_firstname.Text));
                isUpdated = true;
            }

            if (txt_middlename.Text != originalMiddleName)
            {
                query += "Middlename = @middlename, ";
                parameters.Add(new SqlParameter("@middlename", txt_middlename.Text));
                isUpdated = true;
            }

            if (txt_lastname.Text != originalLastName)
            {
                query += "Lastname = @lastname, ";
                parameters.Add(new SqlParameter("@lastname", txt_lastname.Text));
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
                query += "ContactNumber = @contact, ";
                parameters.Add(new SqlParameter("@contact", Convert.ToInt64(txt_contact.Text)));
                isUpdated = true;
            }

            if (txt_email.Text != originalEmail)
            {
                query += "EmailAddress = @email, ";
                parameters.Add(new SqlParameter("@email", txt_email.Text));
                isUpdated = true;
            }

            if (txt_address.Text != originalHomeAddress)
            {
                query += "HomeAddress = @homeaddress, ";
                parameters.Add(new SqlParameter("@homeaddress", txt_address.Text));
                isUpdated = true;
            }

            if (txt_allergies.Text != originalAllergies)
            {
                query += "Allergies = @allergies, ";
                parameters.Add(new SqlParameter("@allergies", txt_allergies.Text));
                isUpdated = true;
            }

            if (txt_condition.Text != originalMedicalCondition)
            {
                query += "MedicalCondition = @medicalcondition, ";
                parameters.Add(new SqlParameter("@medicalcondition", txt_condition.Text));
                isUpdated = true;
            }

            if (txt_emergency_contact.Text != originalEmergencyContact.ToString())
            {
                query += "EmergencyContact = @emergency, ";
                parameters.Add(new SqlParameter("@emergency", Convert.ToInt64(txt_emergency_contact.Text)));
                isUpdated = true;
            }

            if (txt_medication.Text != originalCurrentMedication)
            {
                query += "CurrentMedication = @medication, ";
                parameters.Add(new SqlParameter("@medication", txt_medication.Text));
                isUpdated = true;
            }

            if (dtp_appointment.Value != originalNextAppointment)
            {
                query += "NextAppointmentDate = @appointment, ";
                parameters.Add(new SqlParameter("@appointment", dtp_appointment.Value));
                isUpdated = true;
            }

            if (txt_reason.Text != originalReasonForVisit)
            {
                query += "ReasonForVisit = @reason, ";
                parameters.Add(new SqlParameter("@reason", txt_reason.Text));
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
        }
          
         


        private DateTime originalNextAppointment;
        private byte[] originalImage;
        private int recordId;

        public Patient_Record_Update(int id, string firstName, string middleName, string lastName, int age, long contact, string email,
                              string homeAddress, string allergies, string medicalCondition, long emergencyContact,
                              string currentMedication, DateTime nextAppointment, string reasonForVisit, byte[] image)
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
            originalHomeAddress = homeAddress;
            originalAllergies = allergies;
            originalMedicalCondition = medicalCondition;
            originalEmergencyContact = emergencyContact;
            originalCurrentMedication = currentMedication;
            originalNextAppointment = nextAppointment;
            originalReasonForVisit = reasonForVisit;
            originalImage = image;
        
            txt_firstname.Text = firstName;
            txt_middlename.Text = middleName;
            txt_lastname.Text = lastName;
            txt_age.Text = age.ToString();
            txt_contact.Text = contact.ToString();
            txt_email.Text = email;
            txt_address.Text = homeAddress;
            txt_allergies.Text = allergies;
            txt_medication.Text = medicalCondition;
            txt_emergency_contact.Text = emergencyContact.ToString();
            txt_medication.Text = currentMedication;
            dtp_appointment.Value = nextAppointment;
            txt_reason.Text = reasonForVisit;

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
       
        public Patient_Record_Update()
        {
            InitializeComponent();
        }


    }
}
