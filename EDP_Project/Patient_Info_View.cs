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
    public partial class Patient_Info_View : Form
    {
        string constring = "Data Source=.;Initial Catalog=LuxBite_DB;Integrated Security=True;Encrypt=False;";
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dr;
        SqlDataAdapter adapter;
        DataTable dt;

        private int patientID;
        public Patient_Info_View(int id)
        {
            InitializeComponent();
            con = new SqlConnection(constring);
            patientID = id;
            
        }

        private void LoadPatientDetails(int id)
        {
            string query = "SELECT ID, Firstname, Middlename, Lastname, Age, ContactNumber, EmailAddress, HomeAddress, EmergencyContact, Allergies, MedicalCondition, CurrentMedication, ReasonForVisit, Image FROM Patients WHERE ID = @id";

            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    lbl_id.Text = dr["ID"].ToString();
                    lbl_name.Text = dr["Firstname"].ToString() + " " + dr["Middlename"].ToString() + " " + dr["Lastname"].ToString();
                    lbl_age.Text = dr["Age"].ToString();
                    lbl_contact.Text = dr["ContactNumber"].ToString();
                    lbl_email.Text = dr["EmailAddress"].ToString();
                    lbl_address.Text = dr["HomeAddress"].ToString();
                    lbl_emergency.Text = dr["EmergencyContact"].ToString();
                    lbl_allergy.Text = dr["Allergies"].ToString();
                    lbl_medical.Text = dr["MedicalCondition"].ToString();
                    lbl_medication.Text = dr["CurrentMedication"].ToString();
                    lbl_reason.Text = dr["ReasonForVisit"].ToString();

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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Patient_Info_View_Load(object sender, EventArgs e)
        {
            LoadPatientDetails(patientID);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_patient_img_Click(object sender, EventArgs e)
        {

        }
    }
}
