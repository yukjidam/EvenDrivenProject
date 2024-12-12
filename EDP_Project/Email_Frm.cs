using System;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using kp.Toaster;

namespace EDP_Project
{
    public partial class Email_Frm : Form
    {
        string LuxBite_Mail = "luxbite.noreply@gmail.com";
        string Mail_Password = "mvio kuag skpk hmev";

        string constring = "Data Source=.;Initial Catalog=LuxBite_DB;Integrated Security=True;Encrypt=False;";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        // Delegates DONE!!
        public delegate void LoadContactsDelegate();
        public delegate void SendEmailDelegate(string receiverEmail, string subject, string body);
        public LoadContactsDelegate LoadContacts { get; set; }
        public SendEmailDelegate SendEmail { get; set; }

        public Email_Frm()
        {
            InitializeComponent();
            con = new SqlConnection(constring);
            LoadContacts = LoadContactsToComboBox;
            SendEmail = SendEmailToRecipient;
            LoadContacts.Invoke();
        }

        private void LoadContactsToComboBox()
        {
            try
            {
                string query = "SELECT ID, Firstname, Lastname, EmailAddress FROM Patients";
                cmd = new SqlCommand(query, con);
                con.Open();
                dr = cmd.ExecuteReader();

                cmb_email.Items.Clear(); 
                while (dr.Read())
                {
                    string fullName = $"{dr["Firstname"]} {dr["Lastname"]}";
                    cmb_email.Items.Add(new ComboBoxItem
                    {
                        Text = fullName,
                        Value = dr["EmailAddress"].ToString()
                    });
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading contacts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendEmailToRecipient(string receiverEmail, string subject, string body)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(LuxBite_Mail, Mail_Password),
                    EnableSsl = true
                };

                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(LuxBite_Mail),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = false
                };

                mail.To.Add(receiverEmail);

                smtpClient.Send(mail);
                showToast("Success", "Email has been sent.");
                txt_subject.Clear();
                txt_body.Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_email.SelectedItem is ComboBoxItem selectedContact)
                {
                    string receiverEmail = selectedContact.Value;
                    string subject = txt_subject.Text.Trim();
                    string body = txt_body.Text.Trim();

                    if (string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(body))
                    {
                        MessageBox.Show("Please enter both subject and body of the email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    SendEmail?.Invoke(receiverEmail, subject, body);
                }
                else
                {
                    MessageBox.Show("Please select a contact from the list.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cmb_email_DropDown(object sender, EventArgs e)
        {
            LoadContacts?.Invoke();
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

    public class ComboBoxItem
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
