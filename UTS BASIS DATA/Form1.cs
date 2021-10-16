using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS_BASIS_DATA
{
    public partial class formMenuUtama : Form
    {
        public static formMenuUtama menu;
        MenuStrip menustrip;
        formLogin formLogin;
        StatusStrip ST;

        public void MenuTerkunci()
        {
            loginToolStripMenuItem.Enabled = true;
            masterToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = false;
            masterToolStripMenuItem.Enabled = false;
            STLabelUsername.Text = "";
            STLabelNama.Text = "";
            STLabelDivisi.Text = "";
            STLabelLevel.Text = "";
            menu = this;
        }
        public formMenuUtama()
        {
            InitializeComponent();
        }

        private void FormMenuUtama_Load(object sender, EventArgs e)
        {
            MenuTerkunci();
            STLabelTanggal.Text = DateTime.Now.ToString("dd/mm/yyyy");
            STLabelHari.Text = DateTime.Now.ToString("dddd");
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formLogin formLogin = new formLogin();
            formLogin.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuTerkunci();
        }

        private void divisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDivisi formDivisi = new formDivisi();
            formDivisi.ShowDialog();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formUser formUser = new formUser();
            formUser.ShowDialog();
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            STLabelJam.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
