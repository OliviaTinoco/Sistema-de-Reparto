using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace sistemareparto
{
    class clsDiredal
    {
        public static int Agregar(clsDiremp pDiremp)
        {

            int retorno = 0;

            MySqlConnection conectar = clsBdComun.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into direccion_emp (pk_codemp, zona_dir_emp, calle_dir_emp, aven_dir_emp) values ('{0}','{1}','{2}','{3}')",
               pDiremp.ide, pDiremp.zona, pDiremp.calle, pDiremp.avenida), conectar);
            retorno = comando.ExecuteNonQuery();
            conectar.Close();
            return retorno;
        }

        public static List<clsDiremp> Buscar(object col)
        {
            List<clsDiremp> _lista = new List<clsDiremp>();

            MySqlConnection conectar = clsBdComun.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT  pk_codemp, zona_dir_emp, calle_dir_emp, aven_dir_emp FROM direccion_emp"), conectar);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {

                clsDiremp pDiremp = new clsDiremp();
                //pDircliente.id = _reader.GetInt32(0);
                pDiremp.ide = _reader.GetInt32(1);
                pDiremp.zona = _reader.GetString(2);
                pDiremp.calle = _reader.GetString(3);
                pDiremp.avenida = _reader.GetString(4);


                //pk_codclte, pnom_clte, snom_clte, papel_clte, sapel_clte, nit_clte, fec_nac_clte

                _lista.Add(pDiremp);
            }
            conectar.Close();
            return _lista;
        }

        public static List<clsDiremp> Buscardir(object col)
        {
            List<clsDiremp> _lista = new List<clsDiremp>();

            MySqlConnection conectar = clsBdComun.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT  pk_codemp, zona_dir_emp, calle_dir_emp, aven_dir_emp FROM direccion_emp"), conectar);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {

                clsDiremp pDiremp = new clsDiremp();
                //pDircliente.id = _reader.GetInt32(0);
                pDiremp.ide = _reader.GetInt32(1);
                pDiremp.zona = _reader.GetString(2);
                pDiremp.calle = _reader.GetString(3);
                pDiremp.avenida = _reader.GetString(4);


                //pk_codclte, pnom_clte, snom_clte, papel_clte, sapel_clte, nit_clte, fec_nac_clte

                _lista.Add(pDiremp);
            }
            conectar.Close();
            return _lista;
        }

        public static clsDiremp ObtenerDiremp(int pId)
        {
            clsDiremp pDiremp = new clsDiremp();
            MySqlConnection conexion = clsBdComun.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT pk_codemp, zona_dir_emp, calle_dir_emp, avenida_dir_emp FROM direccion_emp where pk_codemp={0}", pId), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pDiremp.ide = _reader.GetInt32(0);
                pDiremp.zona = _reader.GetString(1);
                pDiremp.calle = _reader.GetString(2);
                pDiremp.avenida = _reader.GetString(3);
                
            }

            conexion.Close();
            return pDiremp;

        }

        public static int Actualizar(clsDiremp pDiremp)
        {
            int retorno = 0;
            MySqlConnection conexion = clsBdComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update direccion_emp set zona_dir_emp='{0}', calle_dir_emp='{1}', aven_dir_emp='{2}' where pk_codemp={3}",
                pDiremp.zona, pDiremp.calle, pDiremp.avenida, pDiremp.ide), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;


        }
    }
}
