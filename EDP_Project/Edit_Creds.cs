using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EDP_Project
{
    public partial class Edit_Creds : Form
    {
        string constring = "Data Source=.;Initial Catalog=LuxBite_DB;Integrated Security=True;Encrypt=False;";
        SqlConnection con;
        SqlCommand cmd;

        public int CurrentUserID { get; set; } 
        public string CurrentUsername { get; set; }

        public Edit_Creds()
        {
            InitializeComponent();
            con = new SqlConnection(constring);
            CurrentUserID = Form1.CurrentUserID;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Profile_Settings ps = new Profile_Settings();
            this.Hide();
            ps.Show();
        }

        private void Edit_Creds_Load(object sender, EventArgs e)
        {
            string query = "SELECT Username FROM Dentist WHERE ID = @UserID";

            using (cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@UserID", CurrentUserID);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        CurrentUsername = reader["Username"].ToString();
                        txt_username.Text = CurrentUsername;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading username: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string newUsername = txt_username.Text.Trim();
            string oldPassword = txt_oldpass.Text.Trim();
            string newPassword = txt_newpass.Text.Trim();
            string confirmPassword = txt_confirmpass.Text.Trim();

            if (string.IsNullOrEmpty(oldPassword) && (newUsername != CurrentUsername || !string.IsNullOrEmpty(newPassword)))
            {
                MessageBox.Show("Old password is required to make changes.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(newPassword) || !string.IsNullOrEmpty(confirmPassword))
            {
                if (newPassword != confirmPassword)
                {
                    showToast("Error", "Did not matched.");
                    return;
                }
            }

            string query = "SELECT Password FROM Dentist WHERE ID = @UserID";
            string currentPassword = null;

            using (cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@UserID", CurrentUserID);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        currentPassword = reader["Password"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error validating old password: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                finally
                {
                    con.Close();
                }
            }

            if (!string.IsNullOrEmpty(oldPassword) && oldPassword != currentPassword)
            {
                showToast("Error", "Old Password is incorrect.");
                return;
            }

            query = "UPDATE Dentist SET Username = @NewUsername, Password = CASE WHEN @NewPassword IS NOT NULL THEN @NewPassword ELSE Password END WHERE ID = @UserID";

            using (cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@NewUsername", string.IsNullOrEmpty(newUsername) ? CurrentUsername : newUsername);
                cmd.Parameters.AddWithValue("@NewPassword", string.IsNullOrEmpty(newPassword) ? (object)DBNull.Value : newPassword);
                cmd.Parameters.AddWithValue("@UserID", CurrentUserID);

                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        showToast("Success", "Updated!");
                        if (newUsername != CurrentUsername)
                        {
                            CurrentUsername = newUsername;
                        }
                    }
                    else
                    {
                        showToast("Alert", "No changes were made.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating credentials: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
            this.Close();
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
    }
}
