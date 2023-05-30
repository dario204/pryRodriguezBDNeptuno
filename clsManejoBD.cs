using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;

namespace pryRodriguezBDNeptuno
{
    internal class clsManejoBD

    {
        //OBJETOS para manipular la conexiòn y datos de una BD
        //zona de declaraciones de objetos y variables
        OleDbCommand ConexionBD;
        OleDbConnection ConectorBD;
        OleDbDataReader LectorBD;
        string ProveedorAccess = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =";
        public string RutaDeBaseDatos = "-";
        public void CargarBaseDeDatos(DataGridView grilla, ComboBox pais, ComboBox ciudad)
        {
            try
            {
                ConectorBD = new OleDbConnection();
                ConectorBD.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NEPTUNO.accdb";
                ConectorBD.Open();

               ConexionBD = new OleDbCommand();

               ConexionBD.Connection = ConectorBD;
               ConexionBD.CommandType = System.Data.CommandType.TableDirect;
               ConexionBD.CommandText = "Clientes";


                LectorBD =ConexionBD.ExecuteReader();

                while (LectorBD.Read())
                {
                    string auxPais = LectorBD["País"].ToString();
                    grilla.Rows.Add(LectorBD[0], LectorBD[1], LectorBD[2], LectorBD[3], LectorBD[4], LectorBD[5], LectorBD[6], LectorBD[7], LectorBD[8], LectorBD[9]);

                    if (pais.Items.Count > 0)
                    {
                        int indice = 0;
                        //verifica que no exista otro pais con el mismo nombre
                        while (indice < pais.Items.Count)
                        {
                            pais.SelectedIndex = indice;
                            if (LectorBD["País"].ToString() == pais.SelectedValue.ToString())
                            {

                            }
                            pais.Items.Add(LectorBD["País"]);

                        }

                    }
                    else
                    {
                        //si esta vacio el combobox graba el primer paìs
                        pais.Items.Add(LectorBD["País"]);

                    }
                    ciudad.Items.Add(LectorBD["Ciudad"]);

                }

            }
            catch (Exception)
            {

            }

        }

        public DataGridView CargarBaseDeDatos(string rutaArechivo)
        {
            try
            {
                DataGridView grilla = new DataGridView();

                for (int i = 0; i < 10; i++)
                {

                    grilla.Columns.Add(i.ToString(), i.ToString());
                }

                ConectorBD = new OleDbConnection();
                ConectorBD.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NEPTUNO.accdb";
                ConectorBD.Open();

               ConexionBD = new OleDbCommand();

               ConexionBD.Connection = ConectorBD;
               ConexionBD.CommandType = System.Data.CommandType.TableDirect;
               ConexionBD.CommandText = "Clientes";


                LectorBD =ConexionBD.ExecuteReader();

                while (LectorBD.Read())
                {
                    grilla.Rows.Add(LectorBD[0], LectorBD[1], LectorBD[2], LectorBD[3], LectorBD[4], LectorBD[5], LectorBD[6], LectorBD[7], LectorBD[8], LectorBD[9]);

                }
                return grilla;
            }
            catch (Exception)
            {
                return null;
            }
           
        }
        public void ConectarBaseDeDatos()
        {
            try
            {
                //crea el objeto en memoria (instanciar)
                ConexionBD = new OleDbCommand();

                //debo ingresar la cadena de conexiòn
                //proveedor de la base --> connectionsstrings.com
                //ruta
                //nombre de archivo
                //ConexionBD.ConnectionString = ProveedorAccess + "LocalEnBin.accdb";
                ConexionBD.ToString() = ProveedorAccess + RutaDeBaseDatos;
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
                ConexionBD = new OleDbCommand();

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
        public void FiltrarPais()
        {
            ConexionBD.Connection = ConectorBD;
            ConexionBD.CommandType=System.Data.CommandType.TableDirect;
            ConexionBD.CommandText = "clientes";

            LectorBD = ConexionBD.ExecuteReader();
            DataGridView grilla = new DataGridView();
            DataGridView pais = new DataGridView();
            DataGridView ciudad = new DataGridView();
            while (LectorBD.Read())
            {
                string auxPais = LectorBD["Pais"].ToString();
                grilla.Rows.Add(LectorBD[0], LectorBD[1], LectorBD[2], LectorBD[3], LectorBD[4], LectorBD[5], LectorBD[6], LectorBD[7], LectorBD[8], LectorBD[9]);
                if (pais.Items.Count>0)
                {
                    int indice = 0;
                    //vamos a ver que no exista otro pais con el mismo nombre
                    while (indice< pais.Items.Count)
                    {
                        pais.SelectedIndex = indice;

                        if (LectorBD["Pais"].ToString()== pais.SelectedItem.ToString())
                        {

                        }
                    }
                    
                }
                else
                {

                }
            }


        }

    }

}





