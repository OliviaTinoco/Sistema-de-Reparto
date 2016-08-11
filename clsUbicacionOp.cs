using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace sistemareparto
{
    public class clsUbicacionOp
    {
        public static int Agregar(clsUbicacion pubica) //Para insertar datos a Mysql 
        {


            int iretorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into UBICACION (pk_codubica,pk_codbod,pasillo_ubica,estant_ubica,slot_ubica) values (NULL,'{0}','{1}','{2}', '{3}')",

               pubica.icodbod, pubica.spasillo, pubica.sestante, pubica.sslot), clsBdComun.ObtenerConexion());

            iretorno = comando.ExecuteNonQuery();// Retorna un 1 si se ejecuta la inserción y 0 es error.
            //MessageBox.Show(Convert.ToString(iretorno));
            return iretorno;



        }

        public static List<clsUbicacion> Buscar(string ppasillo) //Método tipo lista, que retornar el resultado de la busqueda
        {
            List<clsUbicacion> _lista = new List<clsUbicacion>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT pk_codubica, pk_codbod, pasillo_ubica,estant_ubica,slot_ubica FROM UBICACION  where pasillo_ubica ='{0}' ", ppasillo), clsBdComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                clsUbicacion pUbi = new clsUbicacion();
                pUbi.icod = _reader.GetInt16(0);
                pUbi.icodbod = _reader.GetInt16(1);
                pUbi.spasillo = _reader.GetString(2);
                pUbi.sestante = _reader.GetString(3);
                pUbi.sslot = _reader.GetString(4);


                _lista.Add(pUbi);
            }

            return _lista;
        }


        public static clsUbicacion ObtenerUbicacion(int pId)
        {
            clsUbicacion pUbi = new clsUbicacion();
            MySqlConnection conexion = clsBdComun.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT pk_codubica, pk_codbod, pasillo_ubica, estant_ubica, slot_ubica FROM UBICACION  where pk_codubica = '{0}' ", pId), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {

                pUbi.icod = _reader.GetInt16(0);
                pUbi.icodbod = _reader.GetInt16(1);
                pUbi.spasillo = _reader.GetString(2);
                pUbi.sestante = _reader.GetString(3);
                pUbi.sslot = _reader.GetString(4);



            }

            conexion.Close();
            return pUbi;
        }

        public static int Actualizar(clsUbicacion pUbic)
        {
            int iretorno = 0;
            MySqlConnection conexion = clsBdComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update ubicacion set pk_codbod='{0}', pasillo_ubica='{1}', estant_ubica='{2}', slot_ubica='{3}' where pk_codubica={0}",
                pUbic.icodbod, pUbic.spasillo, pUbic.sestante, pUbic.sslot), conexion);

            iretorno = comando.ExecuteNonQuery();
            conexion.Close();

            return iretorno;


        }

        public static int Eliminar(int pId)
        {
            int retorno = 0;
            MySqlConnection conexion = clsBdComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From ubicacion where pk_codubica={0}", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }

    }

}
