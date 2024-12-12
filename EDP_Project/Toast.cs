using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDP_Project
{
    public partial class Toast : Form
    {
        public Toast(string type, string message)
        {
            InitializeComponent();
            lbl_type.Text = type;
            lbl_message.Text = message;

            switch(type)
            {
                case "Success":                   
                    pictureBox1.Image = Properties.Resources.accept;
                    break;
                case "Error":
                    pictureBox1.Image = Properties.Resources.warning;
                    break;
                case "Alert":
                    pictureBox1.Image = Properties.Resources.caution;
                    break;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
