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
        clsManejoBD objBaseDatos = new clsManejoBD();

        private void frmMain_Load(object sender, EventArgs e)
        {
            objBaseDatos.ConectarBaseDeDatos();
           // objBaseDatos.CargarBaseDeDatos();
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
                
                
            }
            
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBase_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVerTablas_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            
        }

        private void cboPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            objBaseDatos.CargarcboPais(cboPais);
            
        }

        private void cboCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            objBaseDatos.CargarcboCiudad(cboCiudad, Pais);
        }
    }
}
