using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.IO;

namespace EDP_Project
{
    public partial class Records_Frm : Form
    {
        string constring = "Data Source=.;Initial Catalog=LuxBite_DB;Integrated Security=True;Encrypt=False;";
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter adapter;
        DataTable dt;

        Info_Frm info = new Info_Frm();
        int curr = Form1.CurrentUserID;

        public Records_Frm()
        {
            InitializeComponent();
            con = new SqlConnection(constring);
            LoadPatients();
            this.KeyPreview = true;  
        }

        private void Records_Frm_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.Control && e.KeyCode == Keys.S)
            {
                e.SuppressKeyPress = true;  
                SavePatientInfoAsPdf();  
            }
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

        private void SavePatientInfoAsPdf()
        {
            
            if (dataGrid_records.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGrid_records.SelectedRows[0];
                int patientID = Convert.ToInt32(selectedRow.Cells["ID"].Value);

               
                string query = "SELECT * FROM Patients WHERE ID = @id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", patientID);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string firstName = dr["Firstname"].ToString();
                    string middleName = dr["Middlename"].ToString();
                    string lastName = dr["Lastname"].ToString();
                    string contact = dr["ContactNumber"].ToString();
                    string email = dr["EmailAddress"].ToString();
                    string address = dr["HomeAddress"].ToString();
                    string allergies = dr["Allergies"].ToString();
                    string medicalCondition = dr["MedicalCondition"].ToString();

                    
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                        saveFileDialog.FileName = $"Patient_{patientID}.pdf"; 

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string filePath = saveFileDialog.FileName;

                          
                            using (PdfWriter writer = new PdfWriter(filePath))
                            using (PdfDocument pdfDocument = new PdfDocument(writer))
                            {
                                Document document = new Document(pdfDocument);

                                
                                document.Add(new Paragraph($"Patient ID: {patientID}"));
                                document.Add(new Paragraph($"Name: {firstName} {middleName} {lastName}"));
                                document.Add(new Paragraph($"Contact: {contact}"));
                                document.Add(new Paragraph($"Email: {email}"));
                                document.Add(new Paragraph($"Address: {address}"));
                                document.Add(new Paragraph($"Allergies: {allergies}"));
                                document.Add(new Paragraph($"Medical Condition: {medicalCondition}"));                            
                                document.Close();
                            }

                            MessageBox.Show($"Patient information has been saved as PDF: {filePath}", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                con.Close();
            }
            else
            {
                MessageBox.Show("Please select a patient record to save as PDF.", "No Record Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                int id_del = idToDelete;

                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    DeleteRecordFromDatabase(idToDelete);
                    dataGrid_records.Rows.RemoveAt(selectedRowIndex);
                    showToast("Success", "Record Deleted");
                    Logs("User " + id_del.ToString() + " Deleted by " +  curr.ToString());
                    con.Close();

                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.");
            }
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
