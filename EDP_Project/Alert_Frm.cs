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
    public partial class Alert_Frm : Form
    {
        public bool IsConfirmed { get; private set; } = false;
        Profile_Settings ps = new Profile_Settings();
        public Alert_Frm()
        {
            InitializeComponent();
        }

        private void Alert_Frm_Load(object sender, EventArgs e)
        {

        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            IsConfirmed = true;
            this.Close();
            ps.Close();
            
        }

        private void bnt_no_Click(object sender, EventArgs e)
        {              
            this.Hide();
        }
    }
}
