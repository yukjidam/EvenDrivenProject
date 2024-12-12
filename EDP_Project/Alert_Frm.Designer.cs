namespace EDP_Project
{
    partial class Alert_Frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alert_Frm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bnt_no = new Guna.UI2.WinForms.Guna2Button();
            this.btn_yes = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure you want to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Logout?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EDP_Project.Properties.Resources.caution;
            this.pictureBox1.Location = new System.Drawing.Point(73, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bnt_no
            // 
            this.bnt_no.AutoRoundedCorners = true;
            this.bnt_no.BorderRadius = 14;
            this.bnt_no.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bnt_no.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bnt_no.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bnt_no.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bnt_no.FillColor = System.Drawing.Color.Gray;
            this.bnt_no.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bnt_no.ForeColor = System.Drawing.Color.White;
            this.bnt_no.Location = new System.Drawing.Point(66, 154);
            this.bnt_no.Name = "bnt_no";
            this.bnt_no.Size = new System.Drawing.Size(66, 31);
            this.bnt_no.TabIndex = 3;
            this.bnt_no.Text = "No";
            this.bnt_no.Click += new System.EventHandler(this.bnt_no_Click);
            // 
            // btn_yes
            // 
            this.btn_yes.AutoRoundedCorners = true;
            this.btn_yes.BorderRadius = 14;
            this.btn_yes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_yes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_yes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_yes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_yes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_yes.ForeColor = System.Drawing.Color.White;
            this.btn_yes.Location = new System.Drawing.Point(138, 154);
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Size = new System.Drawing.Size(66, 31);
            this.btn_yes.TabIndex = 4;
            this.btn_yes.Text = "Yes";
            this.btn_yes.Click += new System.EventHandler(this.btn_yes_Click);
            // 
            // Alert_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 197);
            this.Controls.Add(this.btn_yes);
            this.Controls.Add(this.bnt_no);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alert_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alert_Frm";
            this.Load += new System.EventHandler(this.Alert_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button bnt_no;
        private Guna.UI2.WinForms.Guna2Button btn_yes;
    }
}