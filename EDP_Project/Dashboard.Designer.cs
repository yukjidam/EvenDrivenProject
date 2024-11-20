namespace EDP_Project
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pnl_menu = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_email = new FontAwesome.Sharp.IconButton();
            this.bnt_queue = new FontAwesome.Sharp.IconButton();
            this.btn_records = new FontAwesome.Sharp.IconButton();
            this.btn_dashboard = new FontAwesome.Sharp.IconButton();
            this.pnl_logo = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_home = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnl_titleBar = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_minimize = new Guna.UI2.WinForms.Guna2Button();
            this.btn_maximize = new Guna.UI2.WinForms.Guna2Button();
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_current = new System.Windows.Forms.Label();
            this.currentPic = new FontAwesome.Sharp.IconPictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnl_main = new Guna.UI2.WinForms.Guna2Panel();
            this.pnl_menu.SuspendLayout();
            this.pnl_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).BeginInit();
            this.pnl_titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pnl_menu.Controls.Add(this.btn_email);
            this.pnl_menu.Controls.Add(this.bnt_queue);
            this.pnl_menu.Controls.Add(this.btn_records);
            this.pnl_menu.Controls.Add(this.btn_dashboard);
            this.pnl_menu.Controls.Add(this.pnl_logo);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(220, 556);
            this.pnl_menu.TabIndex = 0;
            this.pnl_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_menu_Paint);
            // 
            // btn_email
            // 
            this.btn_email.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_email.IconChar = FontAwesome.Sharp.IconChar.EnvelopeOpen;
            this.btn_email.IconColor = System.Drawing.Color.Black;
            this.btn_email.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_email.IconSize = 35;
            this.btn_email.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_email.Location = new System.Drawing.Point(0, 320);
            this.btn_email.Name = "btn_email";
            this.btn_email.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_email.Size = new System.Drawing.Size(220, 60);
            this.btn_email.TabIndex = 7;
            this.btn_email.Text = "Email";
            this.btn_email.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_email.UseVisualStyleBackColor = true;
            this.btn_email.Click += new System.EventHandler(this.btn_email_Click);
            // 
            // bnt_queue
            // 
            this.bnt_queue.Dock = System.Windows.Forms.DockStyle.Top;
            this.bnt_queue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_queue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_queue.IconChar = FontAwesome.Sharp.IconChar.PeopleLine;
            this.bnt_queue.IconColor = System.Drawing.Color.Black;
            this.bnt_queue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bnt_queue.IconSize = 35;
            this.bnt_queue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnt_queue.Location = new System.Drawing.Point(0, 260);
            this.bnt_queue.Name = "bnt_queue";
            this.bnt_queue.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bnt_queue.Size = new System.Drawing.Size(220, 60);
            this.bnt_queue.TabIndex = 6;
            this.bnt_queue.Text = "Queue";
            this.bnt_queue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bnt_queue.UseVisualStyleBackColor = true;
            this.bnt_queue.Click += new System.EventHandler(this.bnt_queue_Click_1);
            // 
            // btn_records
            // 
            this.btn_records.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_records.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_records.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_records.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.btn_records.IconColor = System.Drawing.Color.Black;
            this.btn_records.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_records.IconSize = 35;
            this.btn_records.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_records.Location = new System.Drawing.Point(0, 200);
            this.btn_records.Name = "btn_records";
            this.btn_records.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_records.Size = new System.Drawing.Size(220, 60);
            this.btn_records.TabIndex = 5;
            this.btn_records.Text = "Records";
            this.btn_records.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_records.UseVisualStyleBackColor = true;
            this.btn_records.Click += new System.EventHandler(this.btn_records_Click_1);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btn_dashboard.IconColor = System.Drawing.Color.Black;
            this.btn_dashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_dashboard.IconSize = 35;
            this.btn_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.Location = new System.Drawing.Point(0, 140);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_dashboard.Size = new System.Drawing.Size(220, 60);
            this.btn_dashboard.TabIndex = 1;
            this.btn_dashboard.Text = "Home";
            this.btn_dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // pnl_logo
            // 
            this.pnl_logo.Controls.Add(this.btn_home);
            this.pnl_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_logo.Name = "pnl_logo";
            this.pnl_logo.Size = new System.Drawing.Size(220, 140);
            this.pnl_logo.TabIndex = 0;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageRotate = 0F;
            this.btn_home.Location = new System.Drawing.Point(0, 0);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(220, 140);
            this.btn_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_home.TabIndex = 1;
            this.btn_home.TabStop = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // pnl_titleBar
            // 
            this.pnl_titleBar.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pnl_titleBar.Controls.Add(this.btn_minimize);
            this.pnl_titleBar.Controls.Add(this.btn_maximize);
            this.pnl_titleBar.Controls.Add(this.btn_close);
            this.pnl_titleBar.Controls.Add(this.lbl_current);
            this.pnl_titleBar.Controls.Add(this.currentPic);
            this.pnl_titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titleBar.Location = new System.Drawing.Point(220, 0);
            this.pnl_titleBar.Name = "pnl_titleBar";
            this.pnl_titleBar.Size = new System.Drawing.Size(827, 60);
            this.pnl_titleBar.TabIndex = 1;
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_minimize.BackgroundImage")));
            this.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_minimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_minimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_minimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_minimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_minimize.FillColor = System.Drawing.Color.Transparent;
            this.btn_minimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_minimize.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.Location = new System.Drawing.Point(719, 1);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(32, 22);
            this.btn_minimize.TabIndex = 4;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_maximize
            // 
            this.btn_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_maximize.BackgroundImage")));
            this.btn_maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_maximize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_maximize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_maximize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_maximize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_maximize.FillColor = System.Drawing.Color.Transparent;
            this.btn_maximize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_maximize.ForeColor = System.Drawing.Color.White;
            this.btn_maximize.Location = new System.Drawing.Point(757, 1);
            this.btn_maximize.Name = "btn_maximize";
            this.btn_maximize.Size = new System.Drawing.Size(32, 22);
            this.btn_maximize.TabIndex = 3;
            this.btn_maximize.Click += new System.EventHandler(this.btn_maximize_Click);
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
            this.btn_close.Location = new System.Drawing.Point(795, 1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(32, 22);
            this.btn_close.TabIndex = 2;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_current
            // 
            this.lbl_current.AutoSize = true;
            this.lbl_current.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_current.Location = new System.Drawing.Point(44, 24);
            this.lbl_current.Name = "lbl_current";
            this.lbl_current.Size = new System.Drawing.Size(142, 24);
            this.lbl_current.TabIndex = 1;
            this.lbl_current.Text = "Welcome Back!";
            // 
            // currentPic
            // 
            this.currentPic.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.currentPic.ForeColor = System.Drawing.Color.Black;
            this.currentPic.IconChar = FontAwesome.Sharp.IconChar.House;
            this.currentPic.IconColor = System.Drawing.Color.Black;
            this.currentPic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.currentPic.Location = new System.Drawing.Point(6, 20);
            this.currentPic.Name = "currentPic";
            this.currentPic.Size = new System.Drawing.Size(32, 32);
            this.currentPic.TabIndex = 0;
            this.currentPic.TabStop = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.pnl_titleBar;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // pnl_main
            // 
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(220, 60);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(827, 496);
            this.pnl_main.TabIndex = 2;
            this.pnl_main.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_home_Paint);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 556);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.pnl_titleBar);
            this.Controls.Add(this.pnl_menu);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.pnl_menu.ResumeLayout(false);
            this.pnl_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).EndInit();
            this.pnl_titleBar.ResumeLayout(false);
            this.pnl_titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl_menu;
        private Guna.UI2.WinForms.Guna2Panel pnl_logo;
        private FontAwesome.Sharp.IconButton btn_dashboard;
        private Guna.UI2.WinForms.Guna2PictureBox btn_home;
        private Guna.UI2.WinForms.Guna2Panel pnl_titleBar;
        private FontAwesome.Sharp.IconButton bnt_queue;
        private FontAwesome.Sharp.IconButton btn_records;
        private System.Windows.Forms.Label lbl_current;
        private FontAwesome.Sharp.IconPictureBox currentPic;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2Button btn_minimize;
        private Guna.UI2.WinForms.Guna2Button btn_close;
        private FontAwesome.Sharp.IconButton btn_email;
        private Guna.UI2.WinForms.Guna2Panel pnl_main;
        private Guna.UI2.WinForms.Guna2Button btn_maximize;
    }
}