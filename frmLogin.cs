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

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text == "perro" && txtContraseña.Text == "gato")
            {
                btnSiguiente.Enabled = true;
                btnSiguiente
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }
    }
}
