using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezBDNeptuno
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        int Intentos=0;
        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text == "perro" && txtContraseña.Text == "gato")
            {
                this.Hide();
                frmMain f = new frmMain();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                Intentos++;
                MessageBox.Show("Datos incorrectos, intente nuevamente", "",MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Intentos==3)
                {
                    this.Close();
                    MessageBox.Show("Limite de intentos alcanzado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
