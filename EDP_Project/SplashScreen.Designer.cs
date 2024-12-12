namespace EDP_Project
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.pnl_splash = new Guna.UI2.WinForms.Guna2Panel();
            this.pnl_loading = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tmr_loading = new System.Windows.Forms.Timer(this.components);
            this.pnl_splash.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_splash
            // 
            this.pnl_splash.BackColor = System.Drawing.Color.Black;
            this.pnl_splash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_splash.BackgroundImage")));
            this.pnl_splash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_splash.Controls.Add(this.pnl_loading);
            this.pnl_splash.Controls.Add(this.guna2Panel1);
            this.pnl_splash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_splash.Location = new System.Drawing.Point(0, 0);
            this.pnl_splash.Name = "pnl_splash";
            this.pnl_splash.Size = new System.Drawing.Size(834, 436);
            this.pnl_splash.TabIndex = 0;
            this.pnl_splash.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_splash_Paint_1);
            // 
            // pnl_loading
            // 
            this.pnl_loading.BackColor = System.Drawing.Color.White;
            this.pnl_loading.Location = new System.Drawing.Point(0, 426);
            this.pnl_loading.Name = "pnl_loading";
            this.pnl_loading.Size = new System.Drawing.Size(15, 10);
            this.pnl_loading.TabIndex = 1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 426);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(834, 10);
            this.guna2Panel1.TabIndex = 0;
            // 
            // tmr_loading
            // 
            this.tmr_loading.Enabled = true;
            this.tmr_loading.Interval = 20;
            this.tmr_loading.Tick += new System.EventHandler(this.tmr_loading_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 436);
            this.Controls.Add(this.pnl_splash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.pnl_splash.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl_splash;
        private Guna.UI2.WinForms.Guna2Panel pnl_loading;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Timer tmr_loading;
    }
}