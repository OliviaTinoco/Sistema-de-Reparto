using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace sistemareparto
{
    class clsEmpleadodal
    {
        public static int Agregar(clsEmpleado pEmpleado)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into empleado (pk_codpuesto, pnom_emp, snom_emp, papel_emp, sapel_emp, fec_nac_emp, nit_emp, sueldo_emp, estado_emp) values ('{0}','{1}','{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
                pEmpleado.idp, pEmpleado.pnombre, pEmpleado.snombre, pEmpleado.papellido, pEmpleado.sapellido, pEmpleado.fecha_nac, pEmpleado.nit, pEmpleado.sueldo, pEmpleado.estado), clsBdComun.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static List<clsEmpleado> Buscar(string pNombre, string pApellido)
        {
            List<clsEmpleado> _lista = new List<clsEmpleado>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT pk_codemp, pk_codpuesto, pnom_emp, snom_emp, papel_emp, sapel_emp, fec_nac_emp, nit_emp, sueldo_emp, estado_emp FROM empleado where pnom_emp ='{0}' or papel_emp='{1}'", pNombre, pApellido), clsBdComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                clsEmpleado pEmpleado = new clsEmpleado();
                pEmpleado.id = _reader.GetInt32(0);
                pEmpleado.idp = _reader.GetInt32(1);
                pEmpleado.pnombre = _reader.GetString(2);
                pEmpleado.snombre = _reader.GetString(3);
                pEmpleado.papellido = _reader.GetString(4);
                pEmpleado.sapellido = _reader.GetString(5);
                pEmpleado.fecha_nac = _reader.GetString(6);
                pEmpleado.nit = _reader.GetString(7);
                pEmpleado.sueldo = _reader.GetString(8);
                pEmpleado.estado = _reader.GetString(9);

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

                _lista.Add(pEmpleado);
            }

            return _lista;
        }

        public static clsEmpleado ObtenerEmpleado(int pId)
        {
            clsEmpleado pEmpleado = new clsEmpleado();
            MySqlConnection conexion = clsBdComun.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT pk_codemp, pnom_emp, snom_emp, papel_emp, sapel_emp, fec_nac_emp, nit_emp, sueldo_emp, estado_emp FROM empleado where pk_codemp={0}", pId), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pEmpleado.id = _reader.GetInt32(0);
                pEmpleado.pnombre = _reader.GetString(1);
                pEmpleado.snombre = _reader.GetString(2);
                pEmpleado.papellido = _reader.GetString(3);
                pEmpleado.sapellido = _reader.GetString(4);
                pEmpleado.fecha_nac = _reader.GetString(5);
                pEmpleado.nit = _reader.GetString(6);
                pEmpleado.sueldo = _reader.GetString(7);
                pEmpleado.estado = _reader.GetString(8);

            }

            conexion.Close();
            return pEmpleado;

        }

        public static int Actualizar(clsEmpleado pEmpleado)
        {
            int retorno = 0;
            MySqlConnection conexion = clsBdComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update empleado set pnom_emp='{0}', snom_emp='{1}', papel_emp='{2}', sapel_emp='{3}', fec_nac_emp='{4}', nit_emp='{5}', sueldo_emp='{6}', estado_emp='{7}' where pk_codemp={8}",
                pEmpleado.pnombre, pEmpleado.snombre, pEmpleado.papellido, pEmpleado.sapellido, pEmpleado.fecha_nac, pEmpleado.nit, pEmpleado.sueldo, pEmpleado.estado, pEmpleado.id), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;


        }

        public static int Eliminar(int pId)
        {
            int retorno = 0;
            MySqlConnection conexion = clsBdComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("delete from direccion_emp where pk_codemp ='{0}'; delete from telefono_emp where pk_codemp = '{0}'; delete from correo_emp where pk_codemp = '{0}'; delete from empleado where pk_codemp = '{0}'", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }

        public static List<clsEmpleado> grid()
        {
            List<clsEmpleado> _lista = new List<clsEmpleado>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT pk_codemp, pk_codpuesto, pnom_emp, snom_emp, papel_emp, sapel_emp, fec_nac_emp, nit_emp, sueldo_emp, estado_emp FROM empleado"), clsBdComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                clsEmpleado pEmpleado = new clsEmpleado();
                pEmpleado.id = _reader.GetInt32(0);
                pEmpleado.idp = _reader.GetInt32(1);
                pEmpleado.pnombre = _reader.GetString(2);
                pEmpleado.snombre = _reader.GetString(3);
                pEmpleado.papellido = _reader.GetString(4);
                pEmpleado.sapellido = _reader.GetString(5);
                pEmpleado.fecha_nac = _reader.GetString(6);
                pEmpleado.nit = _reader.GetString(7);
                pEmpleado.sueldo = _reader.GetString(8);
                pEmpleado.estado = _reader.GetString(9);

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

                _lista.Add(pEmpleado);
            }

            return _lista;
        }

        public static List<clsDiremp> grid2()
        {
            List<clsDiremp> _lista = new List<clsDiremp>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT pk_codemp, zona_dir_emp, calle_dir_emp, aven_dir_emp FROM direccion_emp"), clsBdComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                clsDiremp pDiremp = new clsDiremp();
                pDiremp.ide = _reader.GetInt32(0);
                pDiremp.zona = _reader.GetString(1);
                pDiremp.avenida = _reader.GetString(2);
                pDiremp.calle = _reader.GetString(3);

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

                _lista.Add(pDiremp);
            }

            return _lista;
        }

        public static List<clsTelemp> grid3()
        {
            List<clsTelemp> _lista = new List<clsTelemp>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT pk_codemp, telefono FROM telefono_emp"), clsBdComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                clsTelemp pTelemp = new clsTelemp();
                pTelemp.ide = _reader.GetInt32(0);
                pTelemp.telefono = _reader.GetString(1);
                
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

                _lista.Add(pTelemp);
            }

            return _lista;
        }

        public static List<clsCorreoemp> grid4()
        {
            List<clsCorreoemp> _lista = new List<clsCorreoemp>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT pk_codemp, correo FROM correo_emp"), clsBdComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                clsCorreoemp pCoremp = new clsCorreoemp();
                pCoremp.ide = _reader.GetInt32(0);
                pCoremp.correo = _reader.GetString(1);
                
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

                _lista.Add(pCoremp);
            }

            return _lista;
        }

        public static List<clsDiremp> Buscardir(string pNombre, string pApellido)
        {
            List<clsDiremp> _lista = new List<clsDiremp>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT  d.pk_codemp, d.zona_dir_emp, d.calle_dir_emp, d.aven_dir_emp, e.pk_codemp, e.pnom_emp, e.papel_emp FROM direccion_emp d, empleado e where e.pnom_emp = '{0}' or e.papel_emp = '{1}' and e.pk_codemp = d.pk_codemp", pNombre, pApellido), clsBdComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {

                clsDiremp pDiremp = new clsDiremp();
                //pDircliente.id = _reader.GetInt32(0);
                pDiremp.ide = _reader.GetInt32(0);
                pDiremp.zona = _reader.GetString(1);
                pDiremp.calle = _reader.GetString(2);
                pDiremp.avenida = _reader.GetString(3);


                //pk_codclte, pnom_clte, snom_clte, papel_clte, sapel_clte, nit_clte, fec_nac_clte

                _lista.Add(pDiremp);
            }

            return _lista;
        }

        public static clsDiremp ObtenerDiremp(int pId)
        {
            clsDiremp pdire = new clsDiremp();
            MySqlConnection conexion = clsBdComun.ObtenerConexion();

            //MessageBox.Show(Convert.ToString(pId));
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT pk_codemp, zona_dir_emp, calle_dir_emp, aven_dir_emp FROM direccion_emp where pk_codemp={0}", pId), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pdire.ide = _reader.GetInt32(0);
                pdire.zona = _reader.GetString(1);
                pdire.calle = _reader.GetString(2);
                pdire.avenida = _reader.GetString(3);
                
            }

            conexion.Close();
            return pdire;

        }

        public static List<clsTelemp> Buscartel(string pNombre, string pApellido)
        {
            List<clsTelemp> _lista = new List<clsTelemp>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT  t.pk_codemp, t.telefono, e.pk_codemp, e.pnom_emp, e.papel_emp FROM telefono_emp t, empleado e where e.pnom_emp = '{0}' or e.papel_emp = '{1}' and e.pk_codemp = t.pk_codemp", pNombre, pApellido), clsBdComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {

                clsTelemp ptelemp = new clsTelemp();
                //pDircliente.id = _reader.GetInt32(0);
                ptelemp.ide = _reader.GetInt32(0);
                ptelemp.telefono = _reader.GetString(1);
                

                //pk_codclte, pnom_clte, snom_clte, papel_clte, sapel_clte, nit_clte, fec_nac_clte

                _lista.Add(ptelemp);
            }

            return _lista;
        }

        public static clsTelemp ObtenerTelemp(int pId)
        {
            clsTelemp ptele = new clsTelemp();
            MySqlConnection conexion = clsBdComun.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT pk_codemp, telefono FROM telefono_emp where pk_codemp={0}", pId), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                ptele.ide = _reader.GetInt32(0);
                ptele.telefono = _reader.GetString(1);
                
            }

            conexion.Close();
            return ptele;

        }

        public static List<clsCorreoemp> Buscarcor(string pNombre, string pApellido)
        {
            List<clsCorreoemp> _lista = new List<clsCorreoemp>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT  c.pk_codemp, c.correo, e.pk_codemp, e.pnom_emp, e.papel_emp FROM correo_emp c, empleado e where e.pnom_emp = '{0}' or e.papel_emp = '{1}' and e.pk_codemp = c.pk_codemp", pNombre, pApellido), clsBdComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {

                clsCorreoemp pcoremp = new clsCorreoemp();
                //pDircliente.id = _reader.GetInt32(0);
                pcoremp.ide = _reader.GetInt32(0);
                pcoremp.correo = _reader.GetString(1);
                

                //pk_codclte, pnom_clte, snom_clte, papel_clte, sapel_clte, nit_clte, fec_nac_clte

                _lista.Add(pcoremp);
            }

            return _lista;
        }

        public static clsCorreoemp ObtenerCorreo(int pId)
        {
            clsCorreoemp pcor = new clsCorreoemp();
            MySqlConnection conexion = clsBdComun.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT pk_codemp, correo FROM correo_emp where pk_codemp={0}", pId), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pcor.ide = _reader.GetInt32(0);
                pcor.correo = _reader.GetString(1);
                
            }

            conexion.Close();
            return pcor;

        }
    }
}
