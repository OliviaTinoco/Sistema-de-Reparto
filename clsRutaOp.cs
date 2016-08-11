using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace sistemareparto
{
    public class clsRutaOp //Clase que ejecuta todas las operaciones a la base de datos
    {
        public static int Agregar(clsRuta pruta) //Para insertar datos a Mysql 
        {

            
                int iretorno = 0;

                MySqlCommand comando = new MySqlCommand(string.Format("Insert into ruta (pk_codruta, zona_ruta, desc_ruta) values (NULL,'{0}','{1}')",
                    pruta.szona, pruta.sdecripcion), clsBdComun.ObtenerConexion());

                iretorno = comando.ExecuteNonQuery();// Retorna un 1 si se ejecuta la inserción y 0 es error.
            MessageBox.Show(Convert.ToString(iretorno));
            return iretorno;
            
            
        }

        public static List<clsRuta> Buscar(string pzona) //Método tipo lista, que retornar el resultado dela busqueda
        {
            List<clsRuta> _lista = new List<clsRuta>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT pk_codruta, zona_ruta, desc_ruta FROM RUTA  where zona_ruta ='{0}' ", pzona), clsBdComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                clsRuta pRuta = new clsRuta();
                pRuta.icod = _reader.GetInt16(0);
                pRuta.szona = _reader.GetString(1);
                pRuta.sdecripcion= _reader.GetString(2);
            

                _lista.Add(pRuta);
            }

            return _lista;
        }

        public static clsRuta ObtenerRuta(int pId) 
        {
            clsRuta pRuta = new clsRuta();
            MySqlConnection conexion = clsBdComun.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT pk_codruta, zona_ruta, desc_ruta FROM RUTA where pk_codruta={0}", pId), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pRuta.icod = _reader.GetInt16(0);
                pRuta.szona = _reader.GetString(1);
                pRuta.sdecripcion = _reader.GetString(2);
            }

            conexion.Close();
            return pRuta;
        }


        public static int Actualizar(clsRuta pRut)
        {
            int iretorno = 0;
            MySqlConnection conexion = clsBdComun.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("Update ruta set zona_ruta='{0}', desc_ruta='{1}' where pk_codruta={0}",
                pRut.szona, pRut.sdecripcion), conexion);
            iretorno = comando.ExecuteNonQuery();
            conexion.Close();

            return iretorno;


        }

        public static int Eliminar(int pId)
        {
            int retorno = 0;
            MySqlConnection conexion = clsBdComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From ruta where pk_codruta={0}", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }


    }

}
