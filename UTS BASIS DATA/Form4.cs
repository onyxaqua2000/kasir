using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Globalization;
using System.Text.RegularExpressions;


namespace UTS_BASIS_DATA
{
    public partial class formTambahUsers : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader Rd;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-09067HR;Initial Catalog=dbabsensi;Integrated Security=True");

        koneksi koneksi = new koneksi();
        string imglocation = "";
        public formTambahUsers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imglocation;
            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox1.Text == "" || textBox6.Text == "" || textBox7.Text == "" || comboBox2.Text == "" || imglocation == null)
            {
                MessageBox.Show("Data Harus Di Isi !");
            }
            else
            {
                byte[] images = null;
                FileStream streem = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(streem);
                images = brs.ReadBytes((int)streem.Length);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into users (nik, nama, telp, email, divisi, username, password, level, foto) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + comboBox2.Text + "', @images)";
                cmd.Parameters.Add(new SqlParameter("@images", images));
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Daftar User Berhasil !");
            }


        }

        private void formTambahUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbabsensiDataSet1.divisi' table. You can move, or remove it, as needed.
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select nama_divisi from divisi", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            conn.Close();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "nama_divisi";
            comboBox1.ValueMember = "nama_divisi";


        }

        

        void munculdivisi()
        {
            conn.Open();
            cmd = new SqlCommand("select nama_divisi from divisi", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            conn.Close();

            comboBox1.DisplayMember = "items";
            comboBox1.ValueMember = "items";
            comboBox1.DataSource = ds.Tables[0];

            comboBox1.Enabled = true;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
