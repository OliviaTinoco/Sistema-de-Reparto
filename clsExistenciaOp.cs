using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace sistemareparto
{
   public class clsExistenciaOp
    {
        public static int Agregar(ClsExistencia pexis) //Para insertar datos a Mysql 
        {


            int iretorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into EXISTENCIA (pk_codexis, pk_codubica, cantidad_exis, precom_exis, preven_exis) values (NULL,'{0}','{1}','{2}','{3}')",
                pexis.icodubi,pexis.icantidad, pexis.iprecompra, pexis.ipreventa), clsBdComun.ObtenerConexion());

            iretorno = comando.ExecuteNonQuery();// Retorna un 1 si se ejecuta la inserción y 0 es error.
           
            return iretorno;


        }


        public static ClsExistencia ObtenerExistencia(int pId)
        {
            ClsExistencia pExis = new ClsExistencia();
            MySqlConnection conexion = clsBdComun.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT pk_codexis, pk_codubica, cantidad_exis,precom_exis, preven_exis FROM EXISTENCIA  where pk_codexis = '{0}' ", pId), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {

                pExis.icod = _reader.GetInt16(0);
                pExis.icodubi= _reader.GetInt16(1);
                pExis.icantidad = _reader.GetInt16(2);
                pExis.iprecompra = _reader.GetInt16(3);
                pExis.ipreventa = _reader.GetInt16(4);



            }

            conexion.Close();
            return pExis;
        }


        public static int Eliminar(int pId)
        {
            int retorno = 0;
            MySqlConnection conexion = clsBdComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From EXISTENCIA where pk_codexis={0}", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }
    }
}
