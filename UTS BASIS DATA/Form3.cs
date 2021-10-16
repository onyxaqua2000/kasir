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
    public partial class formDivisi : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader Rd;

        koneksi koneksi = new koneksi();
        public bool False { get; private set; }
        public bool Loop { get; private set; }
        void memanggilkoneksi()
        {
            SqlDataReader Rd = null;
            SqlConnection conn = koneksi.GetConn();
        }

        void MunculDataDivisi()
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("Select * from divisi", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "divisi");
            DataGridView1.DataSource = ds;
            DataGridView1.DataMember = "divisi";
            DataGridView1.AllowUserToAddRows = false;
            DataGridView1.Refresh();

        }
        public formDivisi()
        {
            InitializeComponent();
        }

        void KondisiAwal()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            Button1.Text = "Input";
            Button2.Text = "Edit";
            Button3.Text = "Hapus";
            Button4.Text = "Tutup";
            MunculDataDivisi();
            textBox1.Text = "";
            textBox2.Text = "";
            Button1.Enabled = true;
            Button2.Enabled = true;
            Button3.Enabled = true;
            Button4.Enabled = true;
        }
        void SiapIsi()
        {

            textBox1.Enabled = true;
            textBox2.Enabled = true;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (Button1.Text == "Input")
            {
                Button1.Text = ("Simpan");
                Button2.Enabled = False;
                Button3.Enabled = False;
                Button4.Text = ("Batal");
                SiapIsi();
            }
            else
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Silahkan Isi Semua Field");
                }
                else
                {
                    SqlDataReader Rd = null;
                    SqlConnection conn = koneksi.GetConn();
                    cmd = new SqlCommand("select * from divisi where id_divisi = '" + textBox1.Text + "' or nama_divisi = '" + textBox2.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    Rd = cmd.ExecuteReader();
                    if (Rd.Read())
                    {
                        MessageBox.Show("ID Divisi atau Divisi Sudah Ada, Silahkan Input ID Divisi atau Divisi Yang Berbeda !");
                    }
                    else
                    {
                        SqlConnection connn = koneksi.GetConn();
                        cmd = new SqlCommand("insert into divisi values('" + textBox1.Text + "','" + textBox2.Text + "')", connn);
                        connn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Divisi Berhasil Di Tambahkan !");
                        KondisiAwal();
                    }
                }
            }
        }


        private void Button4_Click_1(object sender, EventArgs e)
        {
            if (Button4.Text == "Tutup")
            {
                this.Hide();
            }
            else
            {
                KondisiAwal();
            }
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            if (Button3.Text == "Hapus")
            {
                Button3.Text = ("Delete");
                Button1.Enabled = false;
                Button2.Enabled = false;
                Button4.Text = ("Batal");
                SiapIsi();
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                MessageBox.Show("Silahkan Pilih Divisi Yang Ingin Di Hapus Pada Data Di Bawah !");
            }
            else
            {
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    MessageBox.Show("Silahkan Pilih Divisi Yang Ingin Di Hapus Pada Data Di Bawah !");
                }
                else
                {
                    memanggilkoneksi();
                    SqlConnection conn = koneksi.GetConn();
                    cmd = new SqlCommand("delete  from divisi where id_divisi = '" + textBox1.Text + "' or nama_divisi = '" + textBox2.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    Rd = cmd.ExecuteReader();
                    MessageBox.Show("Divisi Berhasil Di Hapus !");
                    KondisiAwal();
                }
            }
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            if (Button2.Text == "Edit")
            {
                Button2.Text = ("Simpan");
                Button1.Enabled = false;
                Button3.Enabled = false;
                Button4.Text = ("Batal");
                SiapIsi();
                textBox1.Enabled = false;
            }
            else
            {
                if (textBox1.Text == "" || textBox1.Text == "")
                {
                    MessageBox.Show("Silahkan Pilih Divisi Yang Ingin Di Edit Pada Data Di Bawah !");
                }
                else
                {
                    SqlDataReader Rd = null;
                    SqlConnection conn = koneksi.GetConn();
                    cmd = new SqlCommand("select * from divisi where nama_divisi = '" + textBox2.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    Rd = cmd.ExecuteReader();
                    if (Rd.Read())
                    {
                        MessageBox.Show("ID Divisi atau Divisi Sudah Ada, Silahkan Input ID Divisi atau Divisi Yang Berbeda !");
                    }
                    else
                    {
                        SqlConnection connn = koneksi.GetConn();
                        cmd = new SqlCommand("update divisi set id_divisi = '"+ textBox1.Text + "', nama_divisi = '" + textBox2.Text + "' where id_divisi = '" +textBox1.Text +"'" , connn);
                        connn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Divisi Berhasil Di Edit !");
                        KondisiAwal();
                    }

                }
            }
        }

            private void formDivisi_Load_1(object sender, EventArgs e)
            {
                KondisiAwal();
            }

            private void button5_Click(object sender, EventArgs e)
            {

            }

            private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = DataGridView1.Rows[index];
                textBox1.Text = selectedRow.Cells[0].Value.ToString();
                textBox2.Text = selectedRow.Cells[1].Value.ToString();
            }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        
    }
}