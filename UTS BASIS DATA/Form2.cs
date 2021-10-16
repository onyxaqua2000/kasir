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
    public partial class formLogin : Form
    {
        public void MenuTerbuka()
        {
            formMenuUtama.menu.loginToolStripMenuItem.Enabled = false;
            formMenuUtama.menu.logoutToolStripMenuItem.Enabled = true;
            formMenuUtama.menu.masterToolStripMenuItem.Enabled = true;
            formMenuUtama.menu.statusStrip1.Enabled = true;
            SqlDataReader rd = null;
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from divisi where id_divisi = '" + formMenuUtama.menu.STLabelDivisi.Text + "'", conn);
            cmd.ExecuteNonQuery();
            rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                formMenuUtama.menu.STLabelDivisi.Text = rd[1].ToString();
            }

        }

        //4
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        //5

        koneksi koneksi = new koneksi();
        public formLogin()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
         if (TextBox1 .Text =="" || TextBox2 .Text == "")
            {
                MessageBox.Show("Username dan Password Tidak Boleh Kosong!");
            }
            else
            {
                SqlDataReader rd = null;
                SqlConnection conn = koneksi.GetConn();
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from users where username = '" + TextBox1.Text + "' and password = '" + TextBox2.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    rd = cmd.ExecuteReader();
                    if(rd.Read())
                    {
                        this.Hide();
                        formMenuUtama formMenuUtama = new formMenuUtama();
                        formMenuUtama.menu.STLabelUsername.Text = rd[7].ToString();
                        formMenuUtama.menu.STLabelNama.Text = rd[2].ToString();
                        formMenuUtama.menu.STLabelLevel.Text = rd[9].ToString();
                        formMenuUtama.menu.STLabelDivisi.Text = rd[6].ToString();
                        MenuTerbuka();
                        if (formMenuUtama.menu.STLabelLevel.Text == "Manager")
                        {
                            formMenuUtama.menu.masterToolStripMenuItem.Enabled = true;
                        }
                        else
                        {
                            formMenuUtama.menu.masterToolStripMenuItem.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username atau Password Salah !");
                    }
                }

            }
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
