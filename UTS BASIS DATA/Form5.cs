using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UTS_BASIS_DATA
{
    public partial class formUser : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader Rd;
        public string pilih = "";
        koneksi koneksi = new koneksi();
        public formUser()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                munculdatausers();
            }
            else
            {
                SqlConnection conn = koneksi.GetConn();
                conn.Open();
                cmd = new SqlCommand("select * from users where username = '" + textBox1.Text + "' or nama = '" + textBox1.Text + "'", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "users");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "users";
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
            }
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            munculdatausers();
        }
        void munculdatausers()
        {
                SqlConnection conn = koneksi.GetConn();
                conn.Open();
                cmd = new SqlCommand("Select * from users", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "users");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "users";
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();

        }

        private void btnTambahUser_Click(object sender, EventArgs e)
        {
            formTambahUsers formTambahUsers = new formTambahUsers();
            formTambahUsers.ShowDialog();
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            string pilih = selectedRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi.GetConn();
            cmd = new SqlCommand("select * from users where id_user = '" + pilih + "'", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            Rd = cmd.ExecuteReader();
            if(pilih == null)
            {
                MessageBox.Show("Silakan Pilih User Yang Ingin Di Edit !");
            }
            else
            {
                formEditUser formEditUser = new formEditUser();
                formEditUser.ShowDialog();
            }
        }
    }
}
