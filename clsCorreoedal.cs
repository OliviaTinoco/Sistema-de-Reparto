using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace sistemareparto
{
    class clsCorreoedal
    {
        public static int Agregar(clsCorreoemp pCorreoemp)
        {

            int retorno = 0;

            MySqlConnection conectar = clsBdComun.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into correo_emp (pk_codemp, correo) values ('{0}','{1}')",
               pCorreoemp.ide, pCorreoemp.correo), conectar);
            retorno = comando.ExecuteNonQuery();
            conectar.Clone();
            return retorno;
        }
    }
}
