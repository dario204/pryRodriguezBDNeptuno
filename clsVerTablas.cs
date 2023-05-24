using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace pryRodriguezBDNeptuno
{
    internal class clsVerTablas
    {
        //OBJETOS para manipular la conexiòn y datos de una BD
        //zona de declaraciones de objetos y variables
        OleDbConnection ConexionBD;
        OleDbCommand ComandoBD;
        OleDbDataReader LectorBD;

        string ProveedorAccess = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =";
        public string RutaDeBaseDatos = "-";


        public void ConectarBaseDeDatos()
        {
            try
            {
                //crea el objeto en memoria (instanciar)
                ConexionBD = new OleDbConnection();

                //debo ingresar la cadena de conexiòn
                //proveedor de la base --> connectionsstrings.com
                //ruta
                //nombre de archivo
                //ConexionBD.ConnectionString = ProveedorAccess + "LocalEnBin.accdb";
                ConexionBD.ConnectionString = ProveedorAccess + RutaDeBaseDatos;
                ConexionBD.Open();

                MessageBox.Show("base de Datos abierta - con propiedades de la clase");
            }
            catch (Exception falla)
            {
                MessageBox.Show("Error: " + falla.Message);
            }

        }

        public void ConectarBaseDeDatos(string rutaArchivo)
        {
            try
            {
                //crea el objeto en memoria (instanciar)
                ConexionBD = new OleDbConnection();

                //debo ingresar la cadena de conexiòn
                //proveedor de la base --> connectionsstrings.com
                //ruta
                //nombre de archivo
                ConexionBD.ConnectionString = ProveedorAccess + rutaArchivo;

                ConexionBD.Open();

                MessageBox.Show("base de Datos abierta - con parametros");
            }
            catch (Exception falla)
            {
                MessageBox.Show("Error: " + falla.Message);
            }
        }

        public void ListarTablasDeLaBaseDeDatos()
        {
            DataTable tablas;
            tablas = ConexionBD.GetSchema("Tables");

            //https://social.msdn.microsoft.com/Forums/es-ES/8b06cfb9-ce9b-4ad4-a8d5-53f0f281f198/obtener-el-nombre-de-todas-las-tablas-existentes-en-una-base-de-datos-acces-en-c?forum=vcses

        }
    }
}
