using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace sistemareparto
{
   public class clsrutamapOp
    {
        public static List<clsrutamaps> Buscar(int prutamap) //Método tipo lista, que retornar el resultado dela busqueda
        {
            List<clsrutamaps> _lista = new List<clsrutamaps>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT pk_codplan,	pk_pclte,	pk_codclte,pk_codemp, 	zona_plan, 	calle_plan,	avenida_plan, estado_plan	 FROM plan  where pk_codplanif ='{0}' ", prutamap), clsBdComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                clsrutamaps  rumap = new clsrutamaps();
                rumap.iplan = _reader.GetInt16(0);
                rumap.icodpedido= _reader.GetInt16(1);
                rumap.icodcliente = _reader.GetInt16(2);
                rumap.icodemp = _reader.GetInt16(3);
                rumap.szonacte = _reader.GetString(4);
                rumap.scallecte = _reader.GetString(5);
                rumap.savecte = _reader.GetString(6);
                rumap.sestado = _reader.GetString(7);
             



                _lista.Add(rumap);
            }

            return _lista;
        }

        public static clsmapa ObtenerDato(int codpedc, int codemp, int codcte)
        {
            clsmapa pmapa = new clsmapa();
            MySqlConnection conexion = clsBdComun.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format(
            "SELECT pk_codplan,	pk_pclte,	pk_codclte,pk_codemp, 	zona_plan, 	calle_plan,	avenida_plan, estado_plan	 FROM plan  where pk_codplan ='{0}' ", codpedc), clsBdComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pmapa.iplan1 = _reader.GetInt32(0);
                //pmapa.snomclte = _reader.GetString(1);
                pmapa.icodped = _reader.GetInt32(2);
                pmapa.snomempl = _reader.GetString(3);
                pmapa.szonaclte = _reader.GetString(4);
                pmapa.scalleclte = _reader.GetString(5);
                pmapa.saveclte = _reader.GetString(6);
                pmapa.sestadoempl = _reader.GetString(7);
            }


            MessageBox.Show(Convert.ToString(pmapa.szonaclte));


            MySqlCommand _comando1 = new MySqlCommand(String.Format(
                    "SELECT  pnom_clte FROM pedidoclte where pk_pclte ='{0}' ", codcte), clsBdComun.ObtenerConexion());
            MySqlDataReader _reader1 = _comando1.ExecuteReader();
            while (_reader1.Read())
            {

                pmapa.snomclte = _reader1.GetString(0);
            }
            //  MessageBox.Show(Convert.ToString(map.snomclte));

            MySqlCommand _comando2 = new MySqlCommand(String.Format(
              "SELECT  pnom_emp FROM empleado where pk_codemp ='{0}' ", codemp), clsBdComun.ObtenerConexion());
            MySqlDataReader _reader2 = _comando2.ExecuteReader();
            while (_reader2.Read())
            {

                pmapa.snomempl = _reader2.GetString(0);
            }
            
       conexion.Close();
            return pmapa;

        }
    }
}
