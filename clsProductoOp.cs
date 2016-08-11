using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace sistemareparto
{
    class clsProductoOp
    {
        public static int Agregar(clsProducto pprod) //Para insertar datos a Mysql 
        {


            int iretorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into PRODUCTO (pk_codprod,pk_codprov,pk_codexis,nom_prod,desc_prod,mac_prod) values (NULL,'{0}','{1}','{2}', '{3}','{4}')",

               pprod.icodprov,pprod.icodexist, pprod.snom,pprod.sdesc,pprod.smarc), clsBdComun.ObtenerConexion());

            iretorno = comando.ExecuteNonQuery();// Retorna un 1 si se ejecuta la inserción y 0 es error.
            //MessageBox.Show(Convert.ToString(iretorno));
            return iretorno;



        }



        public static List<clsProducto> Buscar(string pProd) //Método tipo lista, que retornar el resultado dela busqueda
        {
            List<clsProducto> _lista = new List<clsProducto>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT pk_codprod, pk_codprov, pk_codexis, nom_prod, desc_prod, mac_prod FROM PRODUCTO  where nom_prod ='{0}' ", pProd), clsBdComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                clsProducto pProdu = new clsProducto();
                pProdu.icod= _reader.GetInt16(0);
                pProdu.icodprov = _reader.GetInt16(1);
                pProdu.icodexist= _reader.GetInt16(2);
                pProdu.snom = _reader.GetString(3);
                pProdu.sdesc = _reader.GetString(4);
                pProdu.smarc= _reader.GetString(5);


                _lista.Add(pProdu);
            }

            return _lista;
        }

        public static clsProducto ObtenerProd(int pId)
        {
            clsProducto pProdu = new clsProducto();
            MySqlConnection conexion = clsBdComun.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT pk_codprod, pk_codprov, pk_codexis, nom_prod, desc_prod, mac_prod FROM PRODUCTO  where pk_codprod ='{0}' ", pId), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pProdu.icod = _reader.GetInt16(0);
                pProdu.icodprov = _reader.GetInt16(1);
                pProdu.icodexist = _reader.GetInt16(2);
                pProdu.snom = _reader.GetString(3);
                pProdu.sdesc = _reader.GetString(4);
                pProdu.smarc = _reader.GetString(5);
            }

            conexion.Close();
            return pProdu;
        }


        public static int Actualizar(clsProducto pProd)
        {
            int iretorno = 0;
            MySqlConnection conexion = clsBdComun.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("Update producto set pk_codprov='{0}', pk_codexis='{1}', nom_prod='{2}',desc_prod='{3}', mac_prod='{4}' where pk_codprod={5}",
                pProd.icodprov, pProd.icodexist, pProd.snom, pProd.sdesc, pProd.smarc, pProd.icod), conexion);
            iretorno = comando.ExecuteNonQuery();
            conexion.Close();

            return iretorno;


        }

        public static int Eliminar(int pId)
        {
            int retorno = 0;
            MySqlConnection conexion = clsBdComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From PRODUCTO where pk_codprod={0}", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }
    }
}
