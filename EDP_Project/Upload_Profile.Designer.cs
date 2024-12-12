namespace EDP_Project
{
    partial class Upload_Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Upload_Profile));
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.picture_pfp = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn_browse = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_pfp)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Animated = true;
            this.btn_save.AutoRoundedCorners = true;
            this.btn_save.BorderRadius = 22;
            this.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(179, 269);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(99, 46);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Upload";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
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
            this.btn_close.Location = new System.Drawing.Point(324, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(32, 22);
            this.btn_close.TabIndex = 5;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // picture_pfp
            // 
            this.picture_pfp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picture_pfp.Image = global::EDP_Project.Properties.Resources.user;
            this.picture_pfp.ImageRotate = 0F;
            this.picture_pfp.Location = new System.Drawing.Point(62, 12);
            this.picture_pfp.Name = "picture_pfp";
            this.picture_pfp.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picture_pfp.Size = new System.Drawing.Size(232, 238);
            this.picture_pfp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_pfp.TabIndex = 1;
            this.picture_pfp.TabStop = false;
            // 
            // btn_browse
            // 
            this.btn_browse.Animated = true;
            this.btn_browse.AutoRoundedCorners = true;
            this.btn_browse.BorderRadius = 22;
            this.btn_browse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_browse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_browse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_browse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_browse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_browse.ForeColor = System.Drawing.Color.White;
            this.btn_browse.Location = new System.Drawing.Point(74, 269);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(99, 46);
            this.btn_browse.TabIndex = 6;
            this.btn_browse.Text = "Browse";
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // Upload_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 337);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.picture_pfp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Upload_Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload_Profile";
            ((System.ComponentModel.ISupportInitialize)(this.picture_pfp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox picture_pfp;
        private Guna.UI2.WinForms.Guna2Button btn_save;
        private Guna.UI2.WinForms.Guna2Button btn_close;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button btn_browse;
    }
}