namespace EDP_Project
{
    partial class Email_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Email_Frm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_email = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_subject = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_body = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_send = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Send Email";
            // 
            // cmb_email
            // 
            this.cmb_email.BackColor = System.Drawing.Color.Transparent;
            this.cmb_email.BorderColor = System.Drawing.Color.Black;
            this.cmb_email.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_email.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_email.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_email.ItemHeight = 30;
            this.cmb_email.Location = new System.Drawing.Point(28, 76);
            this.cmb_email.Name = "cmb_email";
            this.cmb_email.Size = new System.Drawing.Size(366, 36);
            this.cmb_email.TabIndex = 2;
            this.cmb_email.DropDown += new System.EventHandler(this.cmb_email_DropDown);
            // 
            // txt_subject
            // 
            this.txt_subject.BackColor = System.Drawing.SystemColors.Control;
            this.txt_subject.BorderColor = System.Drawing.Color.Black;
            this.txt_subject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_subject.DefaultText = "";
            this.txt_subject.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_subject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_subject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_subject.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_subject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_subject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subject.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_subject.Location = new System.Drawing.Point(28, 118);
            this.txt_subject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.PasswordChar = '\0';
            this.txt_subject.PlaceholderText = "Subject";
            this.txt_subject.SelectedText = "";
            this.txt_subject.Size = new System.Drawing.Size(366, 36);
            this.txt_subject.TabIndex = 3;
            // 
            // txt_body
            // 
            this.txt_body.BorderColor = System.Drawing.Color.Black;
            this.txt_body.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_body.DefaultText = "";
            this.txt_body.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_body.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_body.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_body.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_body.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_body.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_body.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_body.Location = new System.Drawing.Point(28, 161);
            this.txt_body.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_body.Multiline = true;
            this.txt_body.Name = "txt_body";
            this.txt_body.PasswordChar = '\0';
            this.txt_body.PlaceholderText = "";
            this.txt_body.SelectedText = "";
            this.txt_body.Size = new System.Drawing.Size(786, 270);
            this.txt_body.TabIndex = 4;
            // 
            // btn_send
            // 
            this.btn_send.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_send.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_send.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_send.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_send.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_send.ForeColor = System.Drawing.Color.White;
            this.btn_send.Location = new System.Drawing.Point(655, 438);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(159, 36);
            this.btn_send.TabIndex = 5;
            this.btn_send.Text = "Send";
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // Email_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(827, 496);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_body);
            this.Controls.Add(this.txt_subject);
            this.Controls.Add(this.cmb_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Email_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Email_Frm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_email;
        private Guna.UI2.WinForms.Guna2TextBox txt_subject;
        private Guna.UI2.WinForms.Guna2TextBox txt_body;
        private Guna.UI2.WinForms.Guna2Button btn_send;
    }
}