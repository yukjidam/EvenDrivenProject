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
    public partial class Records_Frm : Form
    {
        string constring = "Data Source=.;Initial Catalog=LuxBite_DB;Integrated Security=True;Encrypt=False;";
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dr;
        SqlDataAdapter adapter;
        DataTable dt;

        Info_Frm info = new Info_Frm();

        public Records_Frm()
        {
            InitializeComponent();
            con = new SqlConnection(constring);
            LoadPatients();
        }

     
        private void LoadPatients()
        {
            string query = @"
        SELECT 
            ID, 
            Firstname, 
            Middlename, 
            Lastname, 
            ContactNumber, 
            EmailAddress, 
            HomeAddress, 
            NextAppointmentDate 
        FROM Patients";

            adapter = new SqlDataAdapter(query, con);
            dt = new DataTable();

            try
            {
                adapter.Fill(dt); 

                dataGrid_records.Rows.Clear();
              
                foreach (DataRow row in dt.Rows)
                {
                  
                    dataGrid_records.Rows.Add(
                        row["ID"],
                        row["Firstname"],
                        row["Lastname"],
                        row["ContactNumber"],
                        row["EmailAddress"],
                        row["HomeAddress"],
                        row["NextAppointmentDate"]);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); 
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            info.Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void dataGrid_records_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                int patientID = Convert.ToInt32(dataGrid_records.Rows[e.RowIndex].Cells["ID"].Value);
                Patient_Info_View viewForm = new Patient_Info_View(patientID);
                viewForm.ShowDialog();
            }
        }

        private void UpdateGrid()
        {
            string query = @"
        SELECT 
            ID, 
            Firstname, 
            Middlename, 
            Lastname, 
            ContactNumber, 
            EmailAddress, 
            HomeAddress, 
            NextAppointmentDate 
        FROM Patients";

            adapter = new SqlDataAdapter(query, con);
            dt = new DataTable();

            try
            {
                adapter.Fill(dt);

                dataGrid_records.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {

                    dataGrid_records.Rows.Add(
                        row["ID"],
                        row["Firstname"],
                        row["Lastname"],
                        row["ContactNumber"],
                        row["EmailAddress"],
                        row["HomeAddress"],
                        row["NextAppointmentDate"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dataGrid_records.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to edit.");
                return;
            }

            DataGridViewRow selectedRow = dataGrid_records.SelectedRows[0];
            int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

            string query = "SELECT * FROM Patients WHERE ID = @id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string firstName = dr["Firstname"].ToString();
                string middleName = dr["Middlename"].ToString();
                string lastName = dr["Lastname"].ToString();
                int age = Convert.ToInt32(dr["Age"]);
                long contact = Convert.ToInt64(dr["ContactNumber"]);
                string email = dr["EmailAddress"].ToString();
                string homeAddress = dr["HomeAddress"].ToString();
                string allergies = dr["Allergies"].ToString();
                string medicalCondition = dr["MedicalCondition"].ToString();
                long emergencyContact = Convert.ToInt64(dr["EmergencyContact"]);
                string currentMedication = dr["CurrentMedication"].ToString();
                DateTime nextAppointment = Convert.ToDateTime(dr["NextAppointmentDate"]);
                string reasonForVisit = dr["ReasonForVisit"].ToString();
                byte[] image = dr["Image"] != DBNull.Value ? (byte[])dr["Image"] : null;

                Patient_Record_Update editForm = new Patient_Record_Update(
                    id, firstName, middleName, lastName, age, contact, email, homeAddress, allergies, medicalCondition,
                    emergencyContact, currentMedication, nextAppointment, reasonForVisit, image);
                editForm.ShowDialog();
                con.Close();

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGrid_records.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGrid_records.SelectedCells[0].RowIndex;
                int idToDelete = Convert.ToInt32(dataGrid_records.Rows[selectedRowIndex].Cells["ID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    DeleteRecordFromDatabase(idToDelete);
                    dataGrid_records.Rows.RemoveAt(selectedRowIndex);
                    MessageBox.Show("Record deleted successfully.");
                    con.Close();
                    
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.");
            }
        }

        private void DeleteRecordFromDatabase(int id)
        {
            string query = "DELETE FROM Patients WHERE ID = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the record: " + ex.Message);
            }

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string search = txt_search.Text.Trim();
            string query = "SELECT ID, FirstName, MiddleName, LastName, ContactNumber, EmailAddress, HomeAddress, Allergies, MedicalCondition, EmergencyContact, CurrentMedication, NextAppointmentDate, ReasonForVisit FROM Patients " +
                           "WHERE FirstName LIKE @search OR MiddleName LIKE @search OR LastName LIKE @search OR ContactNumber LIKE @search OR EmailAddress LIKE @search OR HomeAddress LIKE @search";

            dt = new DataTable();
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@search", $"%{search}%");
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            dataGrid_records.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                dataGrid_records.Rows.Add(
                    row["ID"],
                    row["FirstName"],
                    row["MiddleName"],
                    row["LastName"],
                    row["ContactNumber"],
                    row["EmailAddress"],
                    row["HomeAddress"],
                    row["Allergies"],
                    row["MedicalCondition"],
                    row["EmergencyContact"],
                    row["CurrentMedication"],
                    row["NextAppointmentDate"] != DBNull.Value ? Convert.ToDateTime(row["NextAppointmentDate"]).ToShortDateString() : "",
                    row["ReasonForVisit"]);
            }
        }
    }
}


