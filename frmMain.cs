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

        private void btnBase_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVerTablas_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string conexion= "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NEPTUNO.accdb;";
            try
            {
                ConexionBD = new OleDbConnection(conexion);
                ConexionBD.Open();
                ComandoBD=new OleDbCommand();
                ComandoBD.CommandType = CommandType.TableDirect;
                ComandoBD.CommandText = "Clientes";
                LectorBD = ComandoBD.ExecuteReader();
                string FiltrarPais = cboPais.SelectedItem.ToString();
                while (LectorBD.Read())
                {
                    if (FiltrarPais == LectorBD[8].ToString())
                    {
                        DataTable InfoFiltrada = new DataTable();
                        InfoFiltrada.Rows.Add(LectorBD[0], LectorBD[1], LectorBD[2], LectorBD[3], LectorBD[4], LectorBD[5], LectorBD[6], LectorBD[7], LectorBD[8], LectorBD[9]);

                    }
                }
                MessageBox.Show("Los datos fueron obtenidos", "", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error" + ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Warning);

            }
        }

        private void cboPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NEPTUNO.accdb;";
            try
            {
                ConexionBD = new OleDbConnection(conexion);
                ConexionBD.Open();
                ComandoBD = new OleDbCommand();
                ComandoBD.Connection = ConexionBD;
                ComandoBD.CommandType = CommandType.TableDirect;
                ComandoBD.CommandText = "Clientes";
                LectorBD = ComandoBD.ExecuteReader();

                cboCiudad.Items.Clear();
                HashSet<string> PaisNoRepetido = new HashSet<string>();
                while (LectorBD.Read())
                {
                    if (LectorBD[8].ToString() == cboPais.Text)
                    {
                        string ciudad = LectorBD[5].ToString();
                        PaisNoRepetido.Add(ciudad);
                    }
                }
                cboCiudad.Items.AddRange(PaisNoRepetido.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
