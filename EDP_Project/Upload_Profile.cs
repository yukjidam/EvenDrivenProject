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
    public partial class Upload_Profile : Form
    {
        string constring = "Data Source=.;Initial Catalog=LuxBite_DB;Integrated Security=True;Encrypt=False;";
        SqlConnection con;
        SqlCommand cmd;
        int currentUser;
        string selectedImagePath;
        public Upload_Profile()
        {
            InitializeComponent();
            con = new SqlConnection(constring);
            currentUser = Form1.CurrentUserID;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Title = "Select Profile Picture"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                picture_pfp.Image = Image.FromFile(selectedImagePath);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (picture_pfp.Image == null)
            {
                MessageBox.Show("Please select an image before saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                byte[] imageBytes = File.ReadAllBytes(selectedImagePath);
                con.Open();

                
                string checkQuery = "SELECT COUNT(*) FROM Dentist WHERE ID = @UserID AND Profile_Pic IS NOT NULL";
                cmd = new SqlCommand(checkQuery, con);
                cmd.Parameters.AddWithValue("@UserID", currentUser);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    
                    string updateQuery = "UPDATE Dentist SET Profile_Pic = @ProfilePic WHERE ID = @UserID";
                    cmd = new SqlCommand(updateQuery, con);
                }
                else
                {
                    
                    string insertQuery = "UPDATE Dentist SET Profile_Pic = @ProfilePic WHERE ID = @UserID";
                    cmd = new SqlCommand(insertQuery, con);
                }

                cmd.Parameters.AddWithValue("@ProfilePic", imageBytes);
                cmd.Parameters.AddWithValue("@UserID", currentUser);

                cmd.ExecuteNonQuery();
                con.Close();

              

               
                Profile profileForm = (Profile)Application.OpenForms["Profile"];
                if (profileForm != null)
                {
                    profileForm.LoadProfileData();
                }

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving profile picture: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
