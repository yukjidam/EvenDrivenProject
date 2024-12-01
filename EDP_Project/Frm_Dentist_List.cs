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
    public partial class Frm_Dentist_List : Form
    {
        string constring = "Data Source=.;Initial Catalog=LuxBite_DB;Integrated Security=True;Encrypt=False;";
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dr;
        SqlDataAdapter adapter;
        DataTable dt;

        public Frm_Dentist_List()
        {
            InitializeComponent();
            con = new SqlConnection(constring);
            LoadDentist();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Admin_Frm_Main adf = new Admin_Frm_Main();
            this.Close();
            adf.Show();
        }

        private void LoadDentist()
        {
            string query = "SELECT ID, FirstName, MiddleName, LastName, Contact, Email, Address FROM Dentist";

            adapter = new SqlDataAdapter(query, con);
            dt = new DataTable();
            adapter.Fill(dt);

            dataGrid_records.Rows.Clear();


            foreach (DataRow row in dt.Rows)
            {
                dataGrid_records.Rows.Add(
                    row["ID"],
                    row["FirstName"],
                    row["MiddleName"],
                    row["LastName"],
                    row["Contact"],
                    row["Email"],
                    row["Address"]);
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string search = txt_search.Text.Trim();
            string query = "SELECT ID, FirstName, MiddleName, LastName, Contact, Email, Address FROM Dentist " +
                           "WHERE FirstName LIKE @search OR MiddleName LIKE @search OR LastName LIKE @search OR Contact LIKE @search";

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
                    row["Contact"],
                    row["Email"],
                    row["Address"]);
            }
        }

        private void dataGrid_records_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {                   
                    int dentistID = Convert.ToInt32(dataGrid_records.Rows[e.RowIndex].Cells["ID"].Value);
                    Frm_Dentist_Form detailsForm = new Frm_Dentist_Form(dentistID);
                    detailsForm.Show();
                }
            }
        }      

        private void btn_edit_Click(object sender, EventArgs e)
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
                    Logs("Action Performed: Record Deleted ID : " + idToDelete.ToString());
                }
            }
                else
                {
                MessageBox.Show("Please select a record to delete.");
                }
        }
        private void DeleteRecordFromDatabase(int id)
        {
            string query = "DELETE FROM Dentist WHERE ID = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Logs("Entry Deleted ID: " + id.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the record: " + ex.Message);
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGrid_records.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to edit.");
                return;
            }

            DataGridViewRow selectedRow = dataGrid_records.SelectedRows[0];
            int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

            string query = "SELECT * FROM Dentist WHERE ID = @id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                
                string firstName = dr["FirstName"].ToString();
                string middleName = dr["MiddleName"].ToString();
                string lastName = dr["LastName"].ToString();
                int age = Convert.ToInt32(dr["Age"]);
                long contact = Convert.ToInt64(dr["Contact"]);
                string email = dr["Email"].ToString();
                long emergencyContact = Convert.ToInt64(dr["Emergency_Contact"]);
                string address = dr["Address"].ToString();
                DateTime birthday = Convert.ToDateTime(dr["Birthday"]);
                byte[] image = dr["Image"] != DBNull.Value ? (byte[])dr["Image"] : null;

                Frm_Edit_Info editForm = new Frm_Edit_Info(
                    id, firstName, middleName, lastName, age, contact, email, emergencyContact, address, birthday, image);
                editForm.ShowDialog();
                con.Close();
                Logs("Action Performed: Record Edited ID : " + id.ToString());

            }                          
        }

        public void UpdateGrid()
        {
            string query = "SELECT ID, FirstName, MiddleName, LastName, Contact, Email, Address FROM Dentist";

            adapter = new SqlDataAdapter(query, con);
            dt = new DataTable();
            adapter.Fill(dt);

            dataGrid_records.Rows.Clear();


            foreach (DataRow row in dt.Rows)
            {
                dataGrid_records.Rows.Add(
                    row["ID"],
                    row["FirstName"],
                    row["MiddleName"],
                    row["LastName"],
                    row["Contact"],
                    row["Email"],
                    row["Address"]);
            }

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            UpdateGrid();
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
