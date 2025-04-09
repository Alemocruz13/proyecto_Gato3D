using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_Gato3D
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormClosing += new FormClosingEventHandler(this.frmMenu_FormClosing);
        }

        private void bntUvU_Click(object sender, EventArgs e)
        {
            Form tablero = new frmTablero(false);
            tablero.Show();
            this.Hide();
        }

        private void btnUvC_Click(object sender, EventArgs e)
        {
            Form tablero = new frmTablero(true);
            tablero.Show();
            this.Hide();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
