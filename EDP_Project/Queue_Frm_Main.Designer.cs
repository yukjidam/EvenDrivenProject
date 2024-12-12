namespace EDP_Project
{
    partial class Queue_Frm_Main
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
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.listBox_acc_patients = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_list_patients = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_addQueue = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lbl_total_accommodated = new System.Windows.Forms.Label();
            this.lbl_total_in_queue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_show_queue = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2ShadowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.listBox_acc_patients);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(484, 32);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(301, 367);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // listBox_acc_patients
            // 
            this.listBox_acc_patients.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_acc_patients.FormattingEnabled = true;
            this.listBox_acc_patients.ItemHeight = 19;
            this.listBox_acc_patients.Location = new System.Drawing.Point(8, 43);
            this.listBox_acc_patients.Name = "listBox_acc_patients";
            this.listBox_acc_patients.Size = new System.Drawing.Size(287, 308);
            this.listBox_acc_patients.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accommodated Patients";
            // 
            // cmb_list_patients
            // 
            this.cmb_list_patients.BackColor = System.Drawing.Color.Transparent;
            this.cmb_list_patients.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_list_patients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_list_patients.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_list_patients.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_list_patients.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_list_patients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_list_patients.ItemHeight = 30;
            this.cmb_list_patients.Location = new System.Drawing.Point(34, 107);
            this.cmb_list_patients.Name = "cmb_list_patients";
            this.cmb_list_patients.Size = new System.Drawing.Size(402, 36);
            this.cmb_list_patients.TabIndex = 1;
            this.cmb_list_patients.SelectedIndexChanged += new System.EventHandler(this.cmb_list_patients_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add Patients to Queue";
            // 
            // btn_addQueue
            // 
            this.btn_addQueue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addQueue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addQueue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addQueue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addQueue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_addQueue.ForeColor = System.Drawing.Color.White;
            this.btn_addQueue.Location = new System.Drawing.Point(325, 152);
            this.btn_addQueue.Name = "btn_addQueue";
            this.btn_addQueue.Size = new System.Drawing.Size(111, 33);
            this.btn_addQueue.TabIndex = 3;
            this.btn_addQueue.Text = "Add to Queue";
            this.btn_addQueue.Click += new System.EventHandler(this.btn_addQueue_Click);
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.lbl_total_accommodated);
            this.guna2ShadowPanel2.Controls.Add(this.lbl_total_in_queue);
            this.guna2ShadowPanel2.Controls.Add(this.label4);
            this.guna2ShadowPanel2.Controls.Add(this.label3);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(34, 246);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(402, 153);
            this.guna2ShadowPanel2.TabIndex = 4;
            // 
            // lbl_total_accommodated
            // 
            this.lbl_total_accommodated.Font = new System.Drawing.Font("Franklin Gothic Medium", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_accommodated.Location = new System.Drawing.Point(251, 52);
            this.lbl_total_accommodated.Name = "lbl_total_accommodated";
            this.lbl_total_accommodated.Size = new System.Drawing.Size(86, 81);
            this.lbl_total_accommodated.TabIndex = 8;
            this.lbl_total_accommodated.Text = "0";
            this.lbl_total_accommodated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_total_in_queue
            // 
            this.lbl_total_in_queue.Font = new System.Drawing.Font("Franklin Gothic Medium", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_in_queue.Location = new System.Drawing.Point(55, 52);
            this.lbl_total_in_queue.Name = "lbl_total_in_queue";
            this.lbl_total_in_queue.Size = new System.Drawing.Size(89, 81);
            this.lbl_total_in_queue.TabIndex = 7;
            this.lbl_total_in_queue.Text = "0";
            this.lbl_total_in_queue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Patients Accomodated";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Patients in Queue";
            // 
            // btn_show_queue
            // 
            this.btn_show_queue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_show_queue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_show_queue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_show_queue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_show_queue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_show_queue.ForeColor = System.Drawing.Color.White;
            this.btn_show_queue.Location = new System.Drawing.Point(325, 191);
            this.btn_show_queue.Name = "btn_show_queue";
            this.btn_show_queue.Size = new System.Drawing.Size(111, 33);
            this.btn_show_queue.TabIndex = 5;
            this.btn_show_queue.Text = "Show Queue";
            this.btn_show_queue.Click += new System.EventHandler(this.btn_show_queue_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(34, 162);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(111, 50);
            this.guna2Button1.TabIndex = 6;
            this.guna2Button1.Text = "Next";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Queue_Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 457);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btn_show_queue);
            this.Controls.Add(this.guna2ShadowPanel2);
            this.Controls.Add(this.btn_addQueue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_list_patients);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Queue_Frm_Main";
            this.Text = "Queue_Frm_Main";
            this.Load += new System.EventHandler(this.Queue_Frm_Main_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_acc_patients;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_list_patients;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_addQueue;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private System.Windows.Forms.Label lbl_total_accommodated;
        private System.Windows.Forms.Label lbl_total_in_queue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btn_show_queue;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}