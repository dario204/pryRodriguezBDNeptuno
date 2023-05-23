using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;


namespace pryRodriguezBDNeptuno
{
    internal class clsManejoBD

    {
        OleDbCommand ComandoBD;
        OleDbConnection ConectorBD;
        OleDbDataReader LectorBD;
        public void CargarGrilla(DataGridView grilla, ComboBox pais, ComboBox ciudad)
        {
            try
            {
                ConectorBD = new OleDbConnection();
                ConectorBD.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NEPTUNO.accdb";
                ConectorBD.Open();

                ComandoBD = new OleDbCommand();

                ComandoBD.Connection = ConectorBD;
                ComandoBD.CommandType = System.Data.CommandType.TableDirect;
                ComandoBD.CommandText = "Clientes";


                LectorBD = ComandoBD.ExecuteReader();

                while (LectorBD.Read())
                {
                    string auxPais = LectorBD["País"].ToString();
                    grilla.Rows.Add(LectorBD[0], LectorBD[1], LectorBD[2], LectorBD[3], LectorBD[4], LectorBD[5], LectorBD[6], LectorBD[7], LectorBD[8], LectorBD[9]);

                    if (pais.Items.Count > 0)
                    {
                        int indice = 0;
                        //vamos a ver que no exista otro pais con el mismo nombre
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
                        //si esta vacio el combobox vamos a grabar el primer paìs
                        pais.Items.Add(LectorBD["País"]);

                    }
                    ciudad.Items.Add(LectorBD["Ciudad"]);

                }

            }
            catch (Exception)
            {

            }

        }

        public DataGridView CargarGrilla()
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

                ComandoBD = new OleDbCommand();

                ComandoBD.Connection = ConectorBD;
                ComandoBD.CommandType = System.Data.CommandType.TableDirect;
                ComandoBD.CommandText = "Clientes";


                LectorBD = ComandoBD.ExecuteReader();

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
    }

}
}




