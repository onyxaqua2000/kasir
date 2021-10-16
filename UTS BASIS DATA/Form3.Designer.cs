
namespace UTS_BASIS_DATA
{
    partial class formDivisi
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
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(165, 206);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(470, 222);
            this.DataGridView1.TabIndex = 14;
            this.DataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_RowHeaderMouseClick);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(271, 148);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(100, 42);
            this.Button2.TabIndex = 15;
            this.Button2.Text = "Edit";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(377, 148);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(100, 42);
            this.Button3.TabIndex = 16;
            this.Button3.Text = "Hapus";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(483, 148);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(100, 42);
            this.Button4.TabIndex = 17;
            this.Button4.Text = "Tutup";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click_1);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(165, 148);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(100, 42);
            this.Button1.TabIndex = 13;
            this.Button1.Text = "Input";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(298, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(337, 20);
            this.textBox2.TabIndex = 11;
            // 
            // Label2
            // 
            this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label2.Location = new System.Drawing.Point(165, 53);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(99, 20);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "Nama Divisi";
            // 
            // Label1
            // 
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label1.Location = new System.Drawing.Point(165, 23);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 20);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "ID Divisi";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(298, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 20);
            this.textBox1.TabIndex = 18;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(653, 23);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 50);
            this.button5.TabIndex = 19;
            this.button5.Text = "Cari Divisi";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // formDivisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "formDivisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Divisi";
            this.Load += new System.EventHandler(this.formDivisi_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox textBox2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.Button button5;
    }
}