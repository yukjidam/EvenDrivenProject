using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EDP_Project
{
    public partial class Profile : Form
    {
        string constring = "Data Source=.;Initial Catalog=LuxBite_DB;Integrated Security=True;Encrypt=False;";
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dr;

       
        int currentUser;
       
        public Profile()
        {
            InitializeComponent();
            con = new SqlConnection(constring);
            currentUser = Form1.CurrentUserID;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            pnl_about.Hide();
            pnl_note.Hide();
            LoadProfileData();
        }

        public void LoadProfileData()
        {
            try
            {
                con.Open();
                string query = "SELECT FirstName, LastName, Address, Email, Profile_Pic, About, Notes FROM Dentist WHERE ID = @UserID";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserID", currentUser);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string fullName = dr["LastName"].ToString() + ", " + dr["FirstName"].ToString();
                    lbl_name.Text = fullName;

                    lbl_address.Text = dr["Address"].ToString();
                    lbl_email.Text = dr["Email"].ToString();
                    lbl_about.Text = dr["About"].ToString();
                    lbl_notes.Text = dr["Notes"].ToString();


                    if (dr["Profile_Pic"] != DBNull.Value)
                    {
                        byte[] picData = (byte[])dr["Profile_Pic"];
                        MemoryStream ms = new MemoryStream(picData);
                        picture_pfp.Image = Image.FromStream(ms);
                    }
                    else
                    {
                        picture_pfp.Image = Properties.Resources.user;
                    }

                   
                }
                else
                {
                    MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading profile: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_add_about_Click(object sender, EventArgs e)
        {
            pnl_about.Show();
        }

        private void btn_cancel_about_Click(object sender, EventArgs e)
        {
            pnl_about.Hide();
        }

        private void btn_add_notes_Click(object sender, EventArgs e)
        {
            pnl_note.Show();
        }

        private void btn_cancel_note_Click(object sender, EventArgs e)
        {
            pnl_note.Hide();
        }

        private void btn_save_about_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string updateQuery = "UPDATE Dentist SET About = @About WHERE ID = @UserID";
                cmd = new SqlCommand(updateQuery, con);
                cmd.Parameters.AddWithValue("@About", txtbox_about.Text);
                cmd.Parameters.AddWithValue("@UserID", currentUser);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    lbl_about.Text = txtbox_about.Text; 
                    pnl_about.Hide();
                }
                else
                {
                    MessageBox.Show("Error updating About", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving About: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_save_note_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string updateQuery = "UPDATE Dentist SET Notes = @Notes WHERE ID = @UserID";
                cmd = new SqlCommand(updateQuery, con);
                cmd.Parameters.AddWithValue("@Notes", txtbox_notes.Text);
                cmd.Parameters.AddWithValue("@UserID", currentUser);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    lbl_notes.Text = txtbox_notes.Text;
                    pnl_note.Hide();
                }
                else
                {
                    MessageBox.Show("Error updating Notes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving Notes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Profile_Settings ps;
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (ps == null || ps.IsDisposed)
            {
                ps = Profile_Settings.Instance;
                ps.Show();
            }
            else
            {
                ps.Show();
                ps.BringToFront();
                ps.Activate();
            }
        }
    }
}
