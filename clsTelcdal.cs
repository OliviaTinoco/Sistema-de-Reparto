using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace sistemareparto
{
    class clsTelcdal
    {
        public static int Agregar(clsTelcliente pTelcliente)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into telefono_clte (pk_codclte, telefono) values ('{0}','{1}')",
               pTelcliente.idc, pTelcliente.telefono), clsBdComun.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
