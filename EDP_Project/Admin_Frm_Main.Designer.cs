namespace EDP_Project
{
    partial class Admin_Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Frm_Main));
            this.btn_add_account = new Guna.UI2.WinForms.Guna2Button();
            this.btn_acc_list = new Guna.UI2.WinForms.Guna2Button();
            this.btn_logs = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.SuspendLayout();
            // 
            // btn_add_account
            // 
            this.btn_add_account.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add_account.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add_account.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add_account.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add_account.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_account.ForeColor = System.Drawing.Color.White;
            this.btn_add_account.Location = new System.Drawing.Point(83, 99);
            this.btn_add_account.Name = "btn_add_account";
            this.btn_add_account.Size = new System.Drawing.Size(172, 54);
            this.btn_add_account.TabIndex = 0;
            this.btn_add_account.Text = "Create Account";
            this.btn_add_account.Click += new System.EventHandler(this.btn_add_account_Click);
            // 
            // btn_acc_list
            // 
            this.btn_acc_list.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_acc_list.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_acc_list.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_acc_list.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_acc_list.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acc_list.ForeColor = System.Drawing.Color.White;
            this.btn_acc_list.Location = new System.Drawing.Point(83, 170);
            this.btn_acc_list.Name = "btn_acc_list";
            this.btn_acc_list.Size = new System.Drawing.Size(172, 54);
            this.btn_acc_list.TabIndex = 1;
            this.btn_acc_list.Text = "Account List";
            this.btn_acc_list.Click += new System.EventHandler(this.btn_acc_list_Click);
            // 
            // btn_logs
            // 
            this.btn_logs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_logs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_logs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_logs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_logs.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logs.ForeColor = System.Drawing.Color.White;
            this.btn_logs.Location = new System.Drawing.Point(83, 241);
            this.btn_logs.Name = "btn_logs";
            this.btn_logs.Size = new System.Drawing.Size(172, 54);
            this.btn_logs.TabIndex = 2;
            this.btn_logs.Text = "Logs";
            this.btn_logs.Click += new System.EventHandler(this.btn_logs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Administrator";
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
            this.btn_close.Location = new System.Drawing.Point(308, 1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(32, 22);
            this.btn_close.TabIndex = 4;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Admin_Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(338, 355);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_logs);
            this.Controls.Add(this.btn_acc_list);
            this.Controls.Add(this.btn_add_account);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Frm_Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_add_account;
        private Guna.UI2.WinForms.Guna2Button btn_acc_list;
        private Guna.UI2.WinForms.Guna2Button btn_logs;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_close;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}