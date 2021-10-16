
namespace UTS_BASIS_DATA
{
    partial class formUser
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
            this.btnTambahUser = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dbabsensiDataSet = new UTS_BASIS_DATA.dbabsensiDataSet();
            this.dbabsensiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbladminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_adminTableAdapter = new UTS_BASIS_DATA.dbabsensiDataSetTableAdapters.tbl_adminTableAdapter();
            this.dbabsensiDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbabsensiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbabsensiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbladminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbabsensiDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTambahUser
            // 
            this.btnTambahUser.Location = new System.Drawing.Point(650, 393);
            this.btnTambahUser.Name = "btnTambahUser";
            this.btnTambahUser.Size = new System.Drawing.Size(138, 45);
            this.btnTambahUser.TabIndex = 0;
            this.btnTambahUser.Text = "Tambah User";
            this.btnTambahUser.UseVisualStyleBackColor = true;
            this.btnTambahUser.Click += new System.EventHandler(this.btnTambahUser_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(327, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cari User";
            // 
            // dbabsensiDataSet
            // 
            this.dbabsensiDataSet.DataSetName = "dbabsensiDataSet";
            this.dbabsensiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbabsensiDataSetBindingSource
            // 
            this.dbabsensiDataSetBindingSource.DataSource = this.dbabsensiDataSet;
            this.dbabsensiDataSetBindingSource.Position = 0;
            // 
            // tbladminBindingSource
            // 
            this.tbladminBindingSource.DataMember = "tbl_admin";
            this.tbladminBindingSource.DataSource = this.dbabsensiDataSetBindingSource;
            // 
            // tbl_adminTableAdapter
            // 
            this.tbl_adminTableAdapter.ClearBeforeFill = true;
            // 
            // dbabsensiDataSetBindingSource1
            // 
            this.dbabsensiDataSetBindingSource1.DataSource = this.dbabsensiDataSet;
            this.dbabsensiDataSetBindingSource1.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(629, 340);
            this.dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Edit User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnTambahUser);
            this.Name = "formUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbabsensiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbabsensiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbladminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbabsensiDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTambahUser;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private dbabsensiDataSet dbabsensiDataSet;
        private System.Windows.Forms.BindingSource dbabsensiDataSetBindingSource;
        private System.Windows.Forms.BindingSource tbladminBindingSource;
        private dbabsensiDataSetTableAdapters.tbl_adminTableAdapter tbl_adminTableAdapter;
        private System.Windows.Forms.BindingSource dbabsensiDataSetBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}