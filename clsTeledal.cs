using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace sistemareparto
{
    class clsTeledal
    {
        public static int Agregar(clsTelemp pTelemp)
        {

            int retorno = 0;

            MySqlConnection conectar = clsBdComun.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into telefono_emp (pk_codemp, telefono) values ('{0}','{1}')",
               pTelemp.ide, pTelemp.telefono), conectar);
            retorno = comando.ExecuteNonQuery();
            conectar.Close();
            return retorno;
        }
    }
}
