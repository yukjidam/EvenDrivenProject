namespace EDP_Project
{
    partial class Patient_Record_Update
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient_Record_Update));
            this.dtp_appointment = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.btn_record_save = new Guna.UI2.WinForms.Guna2Button();
            this.txt_emergency_contact = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_condition = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_medication = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_allergies = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_address = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_contact = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_age = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_middlename = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_firstname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_lastname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_reason = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_patient_img = new System.Windows.Forms.PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_patient_img)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_appointment
            // 
            this.dtp_appointment.BackColor = System.Drawing.Color.White;
            this.dtp_appointment.Checked = true;
            this.dtp_appointment.FillColor = System.Drawing.Color.White;
            this.dtp_appointment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_appointment.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_appointment.Location = new System.Drawing.Point(280, 582);
            this.dtp_appointment.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_appointment.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_appointment.Name = "dtp_appointment";
            this.dtp_appointment.Size = new System.Drawing.Size(231, 36);
            this.dtp_appointment.TabIndex = 68;
            this.dtp_appointment.Value = new System.DateTime(2024, 10, 31, 20, 28, 2, 243);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_close.FillColor = System.Drawing.Color.Transparent;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(745, 1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(32, 22);
            this.btn_close.TabIndex = 67;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_record_save
            // 
            this.btn_record_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_record_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_record_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_record_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_record_save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_record_save.ForeColor = System.Drawing.Color.White;
            this.btn_record_save.Location = new System.Drawing.Point(648, 767);
            this.btn_record_save.Name = "btn_record_save";
            this.btn_record_save.Size = new System.Drawing.Size(114, 45);
            this.btn_record_save.TabIndex = 66;
            this.btn_record_save.Text = "Update";
            this.btn_record_save.Click += new System.EventHandler(this.btn_record_save_Click);
            // 
            // txt_emergency_contact
            // 
            this.txt_emergency_contact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_emergency_contact.DefaultText = "";
            this.txt_emergency_contact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_emergency_contact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_emergency_contact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_emergency_contact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_emergency_contact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_emergency_contact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_emergency_contact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_emergency_contact.Location = new System.Drawing.Point(283, 490);
            this.txt_emergency_contact.Name = "txt_emergency_contact";
            this.txt_emergency_contact.PasswordChar = '\0';
            this.txt_emergency_contact.PlaceholderText = "";
            this.txt_emergency_contact.SelectedText = "";
            this.txt_emergency_contact.Size = new System.Drawing.Size(228, 36);
            this.txt_emergency_contact.TabIndex = 63;
            // 
            // txt_condition
            // 
            this.txt_condition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_condition.DefaultText = "";
            this.txt_condition.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_condition.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_condition.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_condition.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_condition.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_condition.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_condition.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_condition.Location = new System.Drawing.Point(22, 490);
            this.txt_condition.Name = "txt_condition";
            this.txt_condition.PasswordChar = '\0';
            this.txt_condition.PlaceholderText = "";
            this.txt_condition.SelectedText = "";
            this.txt_condition.Size = new System.Drawing.Size(211, 36);
            this.txt_condition.TabIndex = 62;
            // 
            // txt_medication
            // 
            this.txt_medication.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_medication.DefaultText = "";
            this.txt_medication.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_medication.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_medication.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_medication.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_medication.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_medication.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_medication.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_medication.Location = new System.Drawing.Point(22, 586);
            this.txt_medication.Name = "txt_medication";
            this.txt_medication.PasswordChar = '\0';
            this.txt_medication.PlaceholderText = "";
            this.txt_medication.SelectedText = "";
            this.txt_medication.Size = new System.Drawing.Size(228, 36);
            this.txt_medication.TabIndex = 61;
            // 
            // txt_allergies
            // 
            this.txt_allergies.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_allergies.DefaultText = "";
            this.txt_allergies.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_allergies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_allergies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_allergies.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_allergies.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_allergies.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_allergies.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_allergies.Location = new System.Drawing.Point(283, 400);
            this.txt_allergies.Name = "txt_allergies";
            this.txt_allergies.PasswordChar = '\0';
            this.txt_allergies.PlaceholderText = "";
            this.txt_allergies.SelectedText = "";
            this.txt_allergies.Size = new System.Drawing.Size(220, 36);
            this.txt_allergies.TabIndex = 60;
            // 
            // txt_address
            // 
            this.txt_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_address.DefaultText = "";
            this.txt_address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_address.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_address.Location = new System.Drawing.Point(22, 400);
            this.txt_address.Name = "txt_address";
            this.txt_address.PasswordChar = '\0';
            this.txt_address.PlaceholderText = "";
            this.txt_address.SelectedText = "";
            this.txt_address.Size = new System.Drawing.Size(211, 36);
            this.txt_address.TabIndex = 59;
            // 
            // txt_email
            // 
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.DefaultText = "";
            this.txt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.Location = new System.Drawing.Point(283, 309);
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PlaceholderText = "";
            this.txt_email.SelectedText = "";
            this.txt_email.Size = new System.Drawing.Size(220, 36);
            this.txt_email.TabIndex = 58;
            // 
            // txt_contact
            // 
            this.txt_contact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_contact.DefaultText = "";
            this.txt_contact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_contact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_contact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_contact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_contact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_contact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_contact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_contact.Location = new System.Drawing.Point(22, 309);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.PasswordChar = '\0';
            this.txt_contact.PlaceholderText = "";
            this.txt_contact.SelectedText = "";
            this.txt_contact.Size = new System.Drawing.Size(211, 36);
            this.txt_contact.TabIndex = 57;
            // 
            // txt_age
            // 
            this.txt_age.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_age.DefaultText = "";
            this.txt_age.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_age.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_age.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_age.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_age.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_age.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_age.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_age.Location = new System.Drawing.Point(283, 219);
            this.txt_age.Name = "txt_age";
            this.txt_age.PasswordChar = '\0';
            this.txt_age.PlaceholderText = "";
            this.txt_age.SelectedText = "";
            this.txt_age.Size = new System.Drawing.Size(220, 36);
            this.txt_age.TabIndex = 56;
            // 
            // txt_middlename
            // 
            this.txt_middlename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_middlename.DefaultText = "";
            this.txt_middlename.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_middlename.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_middlename.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_middlename.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_middlename.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_middlename.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_middlename.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_middlename.Location = new System.Drawing.Point(22, 219);
            this.txt_middlename.Name = "txt_middlename";
            this.txt_middlename.PasswordChar = '\0';
            this.txt_middlename.PlaceholderText = "";
            this.txt_middlename.SelectedText = "";
            this.txt_middlename.Size = new System.Drawing.Size(211, 36);
            this.txt_middlename.TabIndex = 55;
            // 
            // txt_firstname
            // 
            this.txt_firstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_firstname.DefaultText = "";
            this.txt_firstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_firstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_firstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_firstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_firstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_firstname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_firstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_firstname.Location = new System.Drawing.Point(283, 140);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.PasswordChar = '\0';
            this.txt_firstname.PlaceholderText = "";
            this.txt_firstname.SelectedText = "";
            this.txt_firstname.Size = new System.Drawing.Size(220, 36);
            this.txt_firstname.TabIndex = 54;
            // 
            // txt_lastname
            // 
            this.txt_lastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_lastname.DefaultText = "";
            this.txt_lastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_lastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_lastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_lastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_lastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_lastname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_lastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_lastname.Location = new System.Drawing.Point(22, 140);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.PasswordChar = '\0';
            this.txt_lastname.PlaceholderText = "";
            this.txt_lastname.SelectedText = "";
            this.txt_lastname.Size = new System.Drawing.Size(211, 36);
            this.txt_lastname.TabIndex = 53;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(279, 551);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 19);
            this.label15.TabIndex = 52;
            this.label15.Text = "Next Appointment:";
            // 
            // txt_reason
            // 
            this.txt_reason.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_reason.DefaultText = "";
            this.txt_reason.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_reason.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_reason.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_reason.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_reason.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_reason.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_reason.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_reason.Location = new System.Drawing.Point(22, 669);
            this.txt_reason.Multiline = true;
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.PasswordChar = '\0';
            this.txt_reason.PlaceholderText = "";
            this.txt_reason.SelectedText = "";
            this.txt_reason.Size = new System.Drawing.Size(740, 82);
            this.txt_reason.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(18, 636);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 19);
            this.label14.TabIndex = 50;
            this.label14.Text = "Reason for Visit:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 453);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 19);
            this.label12.TabIndex = 49;
            this.label12.Text = "Medical Condition:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 551);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 19);
            this.label11.TabIndex = 48;
            this.label11.Text = "Current Medications:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(282, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 19);
            this.label10.TabIndex = 47;
            this.label10.Text = "Allergies:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(296, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 27);
            this.label9.TabIndex = 46;
            this.label9.Text = "Patient Information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(282, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 19);
            this.label8.TabIndex = 45;
            this.label8.Text = "Age:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 19);
            this.label7.TabIndex = 44;
            this.label7.Text = "Middle Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(279, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 19);
            this.label6.TabIndex = 43;
            this.label6.Text = "Emergency Contact:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 19);
            this.label5.TabIndex = 42;
            this.label5.Text = "Home Address:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(282, 278);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(112, 19);
            this.lblemail.TabIndex = 41;
            this.lblemail.Text = "Email Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "Contact Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "First Name:";
            // 
            // pic_patient_img
            // 
            this.pic_patient_img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_patient_img.Location = new System.Drawing.Point(544, 140);
            this.pic_patient_img.Name = "pic_patient_img";
            this.pic_patient_img.Size = new System.Drawing.Size(218, 276);
            this.pic_patient_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_patient_img.TabIndex = 36;
            this.pic_patient_img.TabStop = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Patient_Record_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 837);
            this.Controls.Add(this.dtp_appointment);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_record_save);
            this.Controls.Add(this.txt_emergency_contact);
            this.Controls.Add(this.txt_condition);
            this.Controls.Add(this.txt_medication);
            this.Controls.Add(this.txt_allergies);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_contact);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_middlename);
            this.Controls.Add(this.txt_firstname);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_reason);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_patient_img);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patient_Record_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient_Record_Update";
            ((System.ComponentModel.ISupportInitialize)(this.pic_patient_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_appointment;
        private Guna.UI2.WinForms.Guna2Button btn_close;
        private Guna.UI2.WinForms.Guna2Button btn_record_save;
        private Guna.UI2.WinForms.Guna2TextBox txt_emergency_contact;
        private Guna.UI2.WinForms.Guna2TextBox txt_condition;
        private Guna.UI2.WinForms.Guna2TextBox txt_medication;
        private Guna.UI2.WinForms.Guna2TextBox txt_allergies;
        private Guna.UI2.WinForms.Guna2TextBox txt_address;
        private Guna.UI2.WinForms.Guna2TextBox txt_email;
        private Guna.UI2.WinForms.Guna2TextBox txt_contact;
        private Guna.UI2.WinForms.Guna2TextBox txt_age;
        private Guna.UI2.WinForms.Guna2TextBox txt_middlename;
        private Guna.UI2.WinForms.Guna2TextBox txt_firstname;
        private Guna.UI2.WinForms.Guna2TextBox txt_lastname;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2TextBox txt_reason;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_patient_img;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}