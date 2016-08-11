using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace sistemareparto
{
    class clsClientedal
    {
        public static int Agregar(clsCliente pCliente)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into cliente (pnom_clte, snom_clte, papel_clte, saple_clte, nit_clte, fec_nac_clte) values ('{0}','{1}','{2}', '{3}', '{4}', '{5}')",
                pCliente.pnombre, pCliente.snombre, pCliente.papellido, pCliente.sapellido, pCliente.nit, pCliente.fecha_nac), clsBdComun.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static List<clsCliente> Buscar(string pNombre, string pApellido)
        {
            List<clsCliente> _lista = new List<clsCliente>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT pk_codclte, pnom_clte, snom_clte, papel_clte, saple_clte, nit_clte, fec_nac_clte FROM cliente where pnom_clte ='{0}' or papel_clte='{1}'", pNombre, pApellido),  clsBdComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                clsCliente pCliente = new clsCliente();
                pCliente.id= _reader.GetInt32(0);
                pCliente.pnombre = _reader.GetString(1);
                pCliente.snombre = _reader.GetString(2);
                pCliente.papellido = _reader.GetString(3);
                pCliente.sapellido = _reader.GetString(4);
                pCliente.nit = _reader.GetString(5);
                pCliente.fecha_nac = _reader.GetString(6);

                /*clsDircliente pDircliente = new clsDircliente();
                //pDircliente.id = _reader.GetInt32(7);
                //pDircliente.idc = _reader.GetInt32(8);
                pDircliente.zona = _reader.GetString(7);
                pDircliente.calle = _reader.GetString(8);
                pDircliente.avenida = _reader.GetString(9);

                clsTelcliente pTelcliente = new clsTelcliente();
                //pTelcliente.id = _reader.GetInt32(12);
                //pTelcliente.idc = _reader.GetInt32(13);
                pTelcliente.telefono = _reader.GetString(10);*/
                                 

                //pk_codclte, pnom_clte, snom_clte, papel_clte, sapel_clte, nit_clte, fec_nac_clte

                _lista.Add(pCliente);                
            }

            return _lista;
        }

        public static clsCliente ObtenerCliente(int pId)
        {
            clsCliente pCliente = new clsCliente();
            MySqlConnection conexion = clsBdComun.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT pk_codclte, pnom_clte, snom_clte, papel_clte, saple_clte, nit_clte, fec_nac_clte FROM cliente where pk_codclte={0}", pId), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pCliente.id = _reader.GetInt32(0);
                pCliente.pnombre = _reader.GetString(1);
                pCliente.snombre = _reader.GetString(2);
                pCliente.papellido = _reader.GetString(3);
                pCliente.sapellido = _reader.GetString(4);
                pCliente.nit = _reader.GetString(5);
                pCliente.fecha_nac = _reader.GetString(6);

            }

            conexion.Close();
            return pCliente;

        }

        public static int Actualizar(clsCliente pCliente)
        {
            int retorno = 0;
            MySqlConnection conexion = clsBdComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update cliente set pnom_clte='{0}', snom_clte='{1}', papel_clte='{2}', saple_clte='{3}', nit_clte='{4}', fec_nac_clte='{5}' where pk_codclte={6}",
                pCliente.pnombre, pCliente.snombre, pCliente.papellido, pCliente.sapellido, pCliente.nit, pCliente.fecha_nac, pCliente.id), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;


        }

        public static int Eliminar(int pId)
        {
            int retorno = 0;
            MySqlConnection conexion = clsBdComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("delete from direccion_clte where pk_codclte ='{0}'; delete from telefono_clte where pk_codclte = '{0}'; delete from cliente where pk_codclte = '{0}' ", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }

        public static List<clsCliente> grid()
        {
            List<clsCliente> _lista = new List<clsCliente>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT pk_codclte, pnom_clte, snom_clte, papel_clte, saple_clte, nit_clte, fec_nac_clte FROM cliente"), clsBdComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                clsCliente pCliente = new clsCliente();
                pCliente.id = _reader.GetInt32(0);
                pCliente.pnombre = _reader.GetString(1);
                pCliente.snombre = _reader.GetString(2);
                pCliente.papellido = _reader.GetString(3);
                pCliente.sapellido = _reader.GetString(4);
                pCliente.nit = _reader.GetString(5);
                pCliente.fecha_nac = _reader.GetString(6);

                /*clsDircliente pDircliente = new clsDircliente();
                //pDircliente.id = _reader.GetInt32(7);
                //pDircliente.idc = _reader.GetInt32(8);
                pDircliente.zona = _reader.GetString(7);
                pDircliente.calle = _reader.GetString(8);
                pDircliente.avenida = _reader.GetString(9);

                clsTelcliente pTelcliente = new clsTelcliente();
                //pTelcliente.id = _reader.GetInt32(12);
                //pTelcliente.idc = _reader.GetInt32(13);
                pTelcliente.telefono = _reader.GetString(10);*/


                //pk_codclte, pnom_clte, snom_clte, papel_clte, sapel_clte, nit_clte, fec_nac_clte

                _lista.Add(pCliente);
            }

            return _lista;
        }

        public static List<clsDircliente> grid2()
        {
            List<clsDircliente> _lista = new List<clsDircliente>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT pk_codclte, zona_dir_clte, calle_dir_clte, aven_dir_clte FROM direccion_clte"), clsBdComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                clsDircliente pDircliente = new clsDircliente();
                pDircliente.idc = _reader.GetInt32(0);
                pDircliente.zona = _reader.GetString(1);
                pDircliente.calle = _reader.GetString(2);
                pDircliente.avenida = _reader.GetString(3);

                /*clsDircliente pDircliente = new clsDircliente();
                //pDircliente.id = _reader.GetInt32(7);
                //pDircliente.idc = _reader.GetInt32(8);
                pDircliente.zona = _reader.GetString(7);
                pDircliente.calle = _reader.GetString(8);
                pDircliente.avenida = _reader.GetString(9);

                clsTelcliente pTelcliente = new clsTelcliente();
                //pTelcliente.id = _reader.GetInt32(12);
                //pTelcliente.idc = _reader.GetInt32(13);
                pTelcliente.telefono = _reader.GetString(10);*/


                //pk_codclte, pnom_clte, snom_clte, papel_clte, sapel_clte, nit_clte, fec_nac_clte

                _lista.Add(pDircliente);
            }

            return _lista;
        }

        public static List<clsTelcliente> grid3()
        {
            List<clsTelcliente> _lista = new List<clsTelcliente>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT pk_codclte, telefono FROM telefono_clte"), clsBdComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                clsTelcliente pTelcliente = new clsTelcliente();
                //pTelcliente.id = _reader.GetInt32(12);
                //pTelcliente.idc = _reader.GetInt32(13);
                pTelcliente.idc = _reader.GetInt32(0);
                pTelcliente.telefono = _reader.GetString(1); 

                 /*clsDircliente pDircliente = new clsDircliente();
                 //pDircliente.id = _reader.GetInt32(7);
                 //pDircliente.idc = _reader.GetInt32(8);
                 pDircliente.zona = _reader.GetString(7);
                 pDircliente.calle = _reader.GetString(8);
                 pDircliente.avenida = _reader.GetString(9);

                 clsTelcliente pTelcliente = new clsTelcliente();
                 //pTelcliente.id = _reader.GetInt32(12);
                 //pTelcliente.idc = _reader.GetInt32(13);
                 pTelcliente.telefono = _reader.GetString(10);*/


                 //pk_codclte, pnom_clte, snom_clte, papel_clte, sapel_clte, nit_clte, fec_nac_clte

                 _lista.Add(pTelcliente);
            }

            return _lista;
        }

        public static List<clsDircliente> Buscardir(string pNombre, string pApellido)
        {
            List<clsDircliente> _lista = new List<clsDircliente>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT d.pk_codclte, d.zona_dir_clte, d.calle_dir_clte, d.aven_dir_clte, c.pnom_clte, c.papel_clte FROM direccion_clte d, cliente c where c.pnom_clte ='{0}' or c.papel_clte='{1}'", pNombre, pApellido), clsBdComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                clsDircliente pdir = new clsDircliente();
                pdir.idc = _reader.GetInt32(0);
                pdir.zona = _reader.GetString(1);
                pdir.calle = _reader.GetString(2);
                pdir.avenida = _reader.GetString(3);                

                /*clsDircliente pDircliente = new clsDircliente();
                //pDircliente.id = _reader.GetInt32(7);
                //pDircliente.idc = _reader.GetInt32(8);
                pDircliente.zona = _reader.GetString(7);
                pDircliente.calle = _reader.GetString(8);
                pDircliente.avenida = _reader.GetString(9);

                clsTelcliente pTelcliente = new clsTelcliente();
                //pTelcliente.id = _reader.GetInt32(12);
                //pTelcliente.idc = _reader.GetInt32(13);
                pTelcliente.telefono = _reader.GetString(10);*/


                //pk_codclte, pnom_clte, snom_clte, papel_clte, sapel_clte, nit_clte, fec_nac_clte

                _lista.Add(pdir);
            }

            return _lista;
        }

        public static clsDircliente ObtenerDireccion(int pId)
        {
            clsDircliente pdire = new clsDircliente();
            MySqlConnection conexion = clsBdComun.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT pk_codclte, zona_dir_clte, calle_dir_clte, aven_dir_clte FROM direccion_clte where pk_codclte={0}", pId), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pdire.idc = _reader.GetInt32(0);
                pdire.zona = _reader.GetString(1);
                pdire.calle = _reader.GetString(2);
                pdire.avenida = _reader.GetString(3);
            }

            conexion.Close();
            return pdire;

        }
    }
}
