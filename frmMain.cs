using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace pryRodriguezBDNeptuno
{
    public partial class frmMain : Form
    {
        OleDbCommand ComandoBD;
        OleDbConnection ConexionBD;
        OleDbDataReader LectorBD;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                ComandoBD = new OleDbCommand();

                ComandoBD.Connection = ConexionBD;
                ComandoBD.CommandType = CommandType.TableDirect;
                ComandoBD.CommandText = "Clientes";
                LectorBD = ComandoBD.ExecuteReader();

                lblError.Text = "Tabla Obtenida";
                lblError.BackColor = Color.Green;

                

                while (LectorBD.Read())
                {
                    dgvClientes.Rows.Add(LectorBD[0], LectorBD[1], LectorBD[2], LectorBD[3], LectorBD[4], LectorBD[5], LectorBD[6], LectorBD[7], LectorBD[8], LectorBD[9]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");
                
            }
            
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            try
            {

                ConexionBD = new OleDbConnection();
                ConexionBD.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\NEPTUNO.accdb";
                ConexionBD.Open();

                lblError.Text = "Acceso correcto";
                lblError.BackColor = Color.Green;
            }
            catch (Exception)
            {
                lblError.Text = "Error";
                lblError.BackColor = Color.Red;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
