using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace sistemareparto
{
    public  class ClsEvaluaServOp
    {
        public static int Agregar(ClsEvaluaServ pserv) //Para insertar datos a Mysql 
        {


            int iretorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into evaluacion_servicio (pk_codevser,pk_pclte,fec_recib_evser,obser_evser,calientrega_evser,caliserv_evser) values (NULL,'{0}','{1}','{2}','{3}','{4}')",
                pserv.id, pserv.pfecha, pserv.sobsv, pserv.scalientrega, pserv.scaliserv), clsBdComun.ObtenerConexion());

            iretorno = comando.ExecuteNonQuery();// Retorna un 1 si se ejecuta la inserción y 0 es error.

            return iretorno;


        }
    }
}
