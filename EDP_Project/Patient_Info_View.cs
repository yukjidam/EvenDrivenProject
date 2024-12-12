using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;  
using System.IO;
using System.Windows.Forms;

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
            this.KeyPreview = true; 
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
                            pic_photo.Image = System.Drawing.Image.FromStream(ms); 
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

        private void Patient_Info_View_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                e.SuppressKeyPress = true;  
                SavePatientInfoAsPdf();  
            }
        }

        private void SavePatientInfoAsPdf()
        {
            try
            {
                
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf"; 
                saveFileDialog.Title = "Save Patient Information as PDF";

                string defaultFileName = $"{lbl_name.Text} ({lbl_id.Text}).pdf";
                saveFileDialog.FileName = defaultFileName;  

               
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                   
                    string filePath = saveFileDialog.FileName;

                   
                    if (!filePath.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase))
                    {
                        filePath += ".pdf"; 
                    }

                    
                    PdfDocument pdfDoc = new PdfDocument();

                   
                    PdfPage page = pdfDoc.AddPage();
                    XGraphics gfx = XGraphics.FromPdfPage(page);

                    
                    Bitmap formBitmap = CaptureFormAsImage();

                    
                    string tempFilePath = Path.Combine(Path.GetTempPath(), "temp_image.png");
                    formBitmap.Save(tempFilePath, System.Drawing.Imaging.ImageFormat.Png);

                   
                    XImage xImage = XImage.FromFile(tempFilePath);

                    
                    double widthRatio = page.Width / xImage.PixelWidth;
                    double heightRatio = page.Height / xImage.PixelHeight;
                    double scaleRatio = Math.Min(widthRatio, heightRatio);  

                   
                    double xPosition = (page.Width - (xImage.PixelWidth * scaleRatio)) / 2;
                    double yPosition = (page.Height - (xImage.PixelHeight * scaleRatio)) / 2;

                    
                    XColor transparentColor = XColor.FromArgb(128, 255, 255, 255);  
                    XSolidBrush transparentBrush = new XSolidBrush(transparentColor);

                    
                    gfx.DrawImage(xImage, xPosition, yPosition, xImage.PixelWidth * scaleRatio, xImage.PixelHeight * scaleRatio);

                  
                    pdfDoc.Save(filePath);

                    MessageBox.Show($"Patient information has been saved as PDF: {filePath}", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ioEx)
            {
                MessageBox.Show($"File error: {ioEx.Message}\n{ioEx.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException uaEx)
            {
                MessageBox.Show($"Permission error: {uaEx.Message}\n{uaEx.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Error saving PDF: {ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private Bitmap CaptureFormAsImage()
        {
           
            Bitmap formBitmap = new Bitmap(this.Width, this.Height);        
            this.DrawToBitmap(formBitmap, new Rectangle(0, 0, this.Width, this.Height));
            return formBitmap;
        }
    }
}
