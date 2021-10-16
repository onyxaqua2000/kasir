
namespace UTS_BASIS_DATA
{
    partial class formMenuUtama
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.STLabelUsername = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.STLabelNama = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.STLabelDivisi = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.STLabelLevel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.STLabelJam = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel11 = new System.Windows.Forms.ToolStripStatusLabel();
            this.STLabelTanggal = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.STLabelHari = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.masterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.keluarToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.keluarToolStripMenuItem.Text = "Keluar";
            this.keluarToolStripMenuItem.Click += new System.EventHandler(this.keluarToolStripMenuItem_Click);
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.divisiToolStripMenuItem,
            this.userToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // divisiToolStripMenuItem
            // 
            this.divisiToolStripMenuItem.Name = "divisiToolStripMenuItem";
            this.divisiToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.divisiToolStripMenuItem.Text = "Divisi";
            this.divisiToolStripMenuItem.Click += new System.EventHandler(this.divisiToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.STLabelUsername,
            this.toolStripStatusLabel3,
            this.STLabelNama,
            this.toolStripStatusLabel5,
            this.STLabelDivisi,
            this.toolStripStatusLabel7,
            this.STLabelLevel,
            this.toolStripStatusLabel9,
            this.STLabelJam,
            this.toolStripStatusLabel11,
            this.STLabelTanggal,
            this.toolStripStatusLabel4,
            this.STLabelHari});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatusLabel1.Text = "Username : ";
            // 
            // STLabelUsername
            // 
            this.STLabelUsername.Name = "STLabelUsername";
            this.STLabelUsername.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusLabel3.Text = "Nama : ";
            // 
            // STLabelNama
            // 
            this.STLabelNama.Name = "STLabelNama";
            this.STLabelNama.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel5.Text = "Divisi : ";
            // 
            // STLabelDivisi
            // 
            this.STLabelDivisi.Name = "STLabelDivisi";
            this.STLabelDivisi.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel7.Text = "Level : ";
            // 
            // STLabelLevel
            // 
            this.STLabelLevel.Name = "STLabelLevel";
            this.STLabelLevel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel9
            // 
            this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            this.toolStripStatusLabel9.Size = new System.Drawing.Size(37, 17);
            this.toolStripStatusLabel9.Text = "Jam : ";
            // 
            // STLabelJam
            // 
            this.STLabelJam.Name = "STLabelJam";
            this.STLabelJam.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel11
            // 
            this.toolStripStatusLabel11.Name = "toolStripStatusLabel11";
            this.toolStripStatusLabel11.Size = new System.Drawing.Size(57, 17);
            this.toolStripStatusLabel11.Text = "Tanggal : ";
            // 
            // STLabelTanggal
            // 
            this.STLabelTanggal.Name = "STLabelTanggal";
            this.STLabelTanggal.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // STLabelHari
            // 
            this.STLabelHari.Name = "STLabelHari";
            this.STLabelHari.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabel4.Text = "Hari : ";
            // 
            // formMenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formMenuUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Utama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenuUtama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel11;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel STLabelUsername;
        public System.Windows.Forms.ToolStripStatusLabel STLabelNama;
        public System.Windows.Forms.ToolStripStatusLabel STLabelDivisi;
        public System.Windows.Forms.ToolStripStatusLabel STLabelLevel;
        public System.Windows.Forms.ToolStripStatusLabel STLabelJam;
        public System.Windows.Forms.ToolStripStatusLabel STLabelTanggal;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel STLabelHari;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
    }
}