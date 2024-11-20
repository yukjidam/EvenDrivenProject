using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using TheArtOfDevHtmlRenderer.Adapters.Entities;
using Color = System.Drawing.Color;

namespace EDP_Project
{
    public partial class Dashboard : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        Email_Frm em = new Email_Frm();
        Records_Frm rf = new Records_Frm();
        Home_Frm hf = new Home_Frm();   
        Queue_Frm_Main qf = new Queue_Frm_Main();  
        public Dashboard()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            pnl_menu.Controls.Add(leftBorderBtn);

            //upon open
            hf.TopLevel = false;
            hf.FormBorderStyle = FormBorderStyle.None;
            hf.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(hf);
            hf.Show();

            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //rgb upon clicking the button
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(0 ,0 ,0);
           
        }


        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(224, 255, 255);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //current tab
                currentPic.IconChar = currentBtn.IconChar;
                currentPic.IconColor = color;

            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(250, 250, 210);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            lbl_current.Text = "Home";

           
            hf.Show();

            //panel control
            em.Hide();
            rf.Hide();
            qf.Hide();

        }

        private void btn_records_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            
        }

        private void bnt_queue_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            hf.Show();
            DisableButton();
            leftBorderBtn.Visible = false;
            currentPic.IconChar = IconChar.House;
            currentPic.IconColor = Color.Black;
            lbl_current.Text = "Home";

         
           
        }

        private void bnt_queue_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            lbl_current.Text = "Queue";

            qf.TopLevel = false;
            qf.FormBorderStyle = FormBorderStyle.None;
            qf.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(qf);
            qf.Show();

            //panel control
            em.Hide();
            rf.Hide();
            hf.Hide();
        }

        private void btn_dashboard_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            lbl_current.Text = "Dashboard";

            //panel control
            em.Hide();
            rf.Hide();
            qf.Hide();

        }

        private void btn_records_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            lbl_current.Text = "Records";

            rf.TopLevel = false;
            rf.FormBorderStyle = FormBorderStyle.None;
            rf.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(rf);
            rf.Show();

            //panel control
            em.Hide();
            hf.Hide();
            qf.Hide();
        }

        private void btn_email_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            lbl_current.Text = "Email";

            em.TopLevel = false;
            em.FormBorderStyle = FormBorderStyle.None;
            em.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(em);
            em.Show();

            //panel control
            rf.Hide();
            hf.Hide();
            qf.Hide();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnl_home_Paint(object sender, PaintEventArgs e)
        {
  
           
        }

        private void pnl_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
           
        }
    }
}