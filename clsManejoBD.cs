using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace pryRodriguezBDNeptuno
{
    internal class clsManejoBD

    {
        OleDbConnection miConexion= new OleDbConnection();
        OleDbCommand miComando= new OleDbCommand();
        OleDbDataReader miLector;

        string ProveedorAccess = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =NEPTUNO.accdb";
   
        public void ConectarBaseDeDatos()
        {
            try
            {
               
                    miConexion.ConnectionString = ProveedorAccess;
                    miConexion.Open();
                    MessageBox.Show("Base de Datos conectada");
            }
                catch (Exception error)
            {     
                    MessageBox.Show("Error: " + error.Message);
                

            }
        }
        public void CargarcboPais(ComboBox cboPais )
        {
            try
            {
                miComando.Connection=miConexion;

                miComando.CommandType = System.Data.CommandType.TableDirect;
                miComando.CommandText = "Proveedores";
                miLector = miComando.ExecuteReader();
                cboPais.Items.Clear();
                while (miLector.Read())
                {
                    cboPais.Items.Add(miLector.GetString(8));
                }
                miLector.Close();

                
            }
            catch (Exception falla)
            {
                MessageBox.Show("Error: " + falla.Message);
            }
        }

        public void CargarcboCiudad(ComboBox cboCiudad, string Pais)
        {
            miComando.Connection = miConexion;
            miComando.CommandType= System.Data.CommandType.TableDirect;
            miComando.CommandText = "Proveedores";
            miLector = miComando.ExecuteReader();
            cboCiudad.Items.Clear();
            while (miLector.Read())
            {
                if (miLector.GetString(8) == Pais)
                {
                    cboCiudad.Items.Add(miLector.GetString(5));
                }
            }
            miLector.Close();
        }
        
        
    }

}





