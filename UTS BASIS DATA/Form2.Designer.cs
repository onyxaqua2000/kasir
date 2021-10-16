
namespace UTS_BASIS_DATA
{
    partial class formLogin
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
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(245, 146);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(79, 44);
            this.Button2.TabIndex = 10;
            this.Button2.Text = "Cancel";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(144, 146);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(79, 44);
            this.Button1.TabIndex = 9;
            this.Button1.Text = "Login";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(144, 108);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.PasswordChar = '⚫';
            this.TextBox2.Size = new System.Drawing.Size(180, 20);
            this.TextBox2.TabIndex = 8;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(144, 38);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(180, 20);
            this.TextBox1.TabIndex = 7;
            // 
            // Label2
            // 
            this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label2.Location = new System.Drawing.Point(39, 108);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(99, 20);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Password";
            // 
            // Label1
            // 
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label1.Location = new System.Drawing.Point(39, 38);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 20);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Kode Admin";
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 229);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.formLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}