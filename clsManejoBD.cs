using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;


namespace pryRodriguezBDNeptuno
{
    internal class clsManejoBD

    {
        //OBJETOS para manipular la conexiòn y datos de una BD
        //zona de declaraciones de objetos y variables
        OleDbConnection miConexion;
        OleDbCommand miComando;
        OleDbDataReader miLector;

        string ProveedorAccess = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =";
        public string RutaDeBaseDatos = "-";


        public void ConectarBaseDeDatos()
        {
            try
            {
                //crea el objeto en memoria (instanciar)
                miConexion = new OleDbConnection();

                //debo ingresar la cadena de conexiòn
                //proveedor de la base --> connectionsstrings.com
                //ruta
                //nombre de archivo
                //miConexion.ConnectionString = ProveedorAccess + "LocalEnBin.accdb";
                miConexion.ConnectionString = ProveedorAccess + RutaDeBaseDatos;
                miConexion.Open();

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
                miConexion = new OleDbConnection();

                //debo ingresar la cadena de conexiòn
                //proveedor de la base --> connectionsstrings.com
                //ruta
                //nombre de archivo
                miConexion.ConnectionString = ProveedorAccess + rutaArchivo;

                miConexion.Open();

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
            tablas = miConexion.GetSchema("Tables");

            //https://social.msdn.microsoft.com/Forums/es-ES/8b06cfb9-ce9b-4ad4-a8d5-53f0f281f198/obtener-el-nombre-de-todas-las-tablas-existentes-en-una-base-de-datos-acces-en-c?forum=vcses

        }


    }

}





