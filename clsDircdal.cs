using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace sistemareparto
{
    class clsDircdal
    {
        public static int Agregar(clsDircliente pDircliente)
        {

            int retorno = 0;

            MySqlConnection conectar = clsBdComun.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into direccion_clte (pk_codclte, zona_dir_clte, calle_dir_clte, aven_dir_clte) values ('{0}','{1}','{2}','{3}')",
               pDircliente.idc, pDircliente.zona, pDircliente.calle, pDircliente.avenida), conectar);
            retorno = comando.ExecuteNonQuery();
            conectar.Close();
            return retorno;
        }

        public static List<clsDircliente> Buscar(object col)
        {
            List<clsDircliente> _lista = new List<clsDircliente>();

            MySqlConnection conectar = clsBdComun.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT pk_coddirclte, pk_codclte, zona_dir_clte, calle_dir_clte, aven_dir_clte FROM  direccion_clte"), conectar);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                
                clsDircliente pDircliente = new clsDircliente();
                //pDircliente.id = _reader.GetInt32(0);
                pDircliente.idc = _reader.GetInt32(1);
                pDircliente.zona = _reader.GetString(2);
                pDircliente.calle = _reader.GetString(3);
                pDircliente.avenida = _reader.GetString(4);

                
                //pk_codclte, pnom_clte, snom_clte, papel_clte, sapel_clte, nit_clte, fec_nac_clte

                _lista.Add(pDircliente);
            }
            conectar.Close();
            return _lista;
        }
    }
}
