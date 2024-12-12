namespace EDP_Project
{
    partial class Records_Frm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Records_Frm));
            this.dataGrid_records = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btn_edit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btn_delete = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btn_refresh = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_records)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_records
            // 
            this.dataGrid_records.AllowUserToAddRows = false;
            this.dataGrid_records.AllowUserToDeleteRows = false;
            this.dataGrid_records.AllowUserToResizeColumns = false;
            this.dataGrid_records.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGrid_records.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_records.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_records.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_records.ColumnHeadersHeight = 40;
            this.dataGrid_records.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGrid_records.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.first_name,
            this.last_name,
            this.contact,
            this.email,
            this.address,
            this.appointment});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_records.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_records.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid_records.Location = new System.Drawing.Point(0, 48);
            this.dataGrid_records.Name = "dataGrid_records";
            this.dataGrid_records.ReadOnly = true;
            this.dataGrid_records.RowHeadersVisible = false;
            this.dataGrid_records.Size = new System.Drawing.Size(827, 448);
            this.dataGrid_records.TabIndex = 0;
            this.dataGrid_records.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_records.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGrid_records.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGrid_records.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGrid_records.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGrid_records.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dataGrid_records.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid_records.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGrid_records.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid_records.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid_records.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGrid_records.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGrid_records.ThemeStyle.HeaderStyle.Height = 40;
            this.dataGrid_records.ThemeStyle.ReadOnly = true;
            this.dataGrid_records.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_records.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid_records.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid_records.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGrid_records.ThemeStyle.RowsStyle.Height = 22;
            this.dataGrid_records.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid_records.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGrid_records.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_records_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // first_name
            // 
            this.first_name.HeaderText = "First Name";
            this.first_name.Name = "first_name";
            this.first_name.ReadOnly = true;
            // 
            // last_name
            // 
            this.last_name.HeaderText = "Last Name";
            this.last_name.Name = "last_name";
            this.last_name.ReadOnly = true;
            // 
            // contact
            // 
            this.contact.HeaderText = "Contact Number";
            this.contact.Name = "contact";
            this.contact.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // appointment
            // 
            this.appointment.HeaderText = "Appointment Schedule";
            this.appointment.Name = "appointment";
            this.appointment.ReadOnly = true;
            // 
            // txt_search
            // 
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.DefaultText = "";
            this.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Location = new System.Drawing.Point(600, 9);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderText = "Search";
            this.txt_search.SelectedText = "";
            this.txt_search.Size = new System.Drawing.Size(220, 29);
            this.txt_search.TabIndex = 1;
            this.txt_search.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.MediumSpringGreen;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2CircleButton1.Image = global::EDP_Project.Properties.Resources.plus;
            this.guna2CircleButton1.Location = new System.Drawing.Point(68, 436);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(50, 48);
            this.guna2CircleButton1.TabIndex = 77;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_edit.FillColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_edit.Image = global::EDP_Project.Properties.Resources.edit;
            this.btn_edit.Location = new System.Drawing.Point(709, 436);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_edit.Size = new System.Drawing.Size(50, 48);
            this.btn_edit.TabIndex = 76;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete.FillColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_delete.Image = global::EDP_Project.Properties.Resources.delete;
            this.btn_delete.Location = new System.Drawing.Point(765, 436);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_delete.Size = new System.Drawing.Size(50, 48);
            this.btn_delete.TabIndex = 75;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_refresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_refresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_refresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_refresh.FillColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_refresh.Image = global::EDP_Project.Properties.Resources.refresh;
            this.btn_refresh.Location = new System.Drawing.Point(12, 436);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_refresh.Size = new System.Drawing.Size(50, 48);
            this.btn_refresh.TabIndex = 74;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Records_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(827, 496);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dataGrid_records);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Records_Frm";
            this.Text = "Records_Frm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_records)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGrid_records;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointment;
        private Guna.UI2.WinForms.Guna2CircleButton btn_refresh;
        private Guna.UI2.WinForms.Guna2CircleButton btn_delete;
        private Guna.UI2.WinForms.Guna2CircleButton btn_edit;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
    }
}