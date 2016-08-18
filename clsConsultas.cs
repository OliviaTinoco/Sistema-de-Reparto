using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemareparto.Modelo
{
    class clsConsultas
    {
        public BindingSource fun_getAllQuejasPositivas()
        {
            /*FUNCION PARA OBTENER LISTADO COMPLETO DE QUEJAS POSITIVAS DE LA BASE DE DATOS
             * Autor: Merlyn Franco
             * Fecha: 16/08/2016*/

            MySqlConnection conn;

            try
            {
                //SE CREA CONEXION
                clsConexion mclsConexion = new clsConexion();
                conn = mclsConexion.fun_Conectar();
                conn.Open();
            }
            catch (MySqlException ex)
            {
                System.Diagnostics.Debug.Write(ex.InnerException.ToString());
                return null;
            }

            try
            {
                //SCRIPT PARA OBTENER TODAS LAS QUEJAS POSITIVAS DE LA BASE DE DATOS
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                string sqlSelectAll = "SELECT 	pk_codevser AS Codigo, 	pk_pclte AS Codigo_Cliente, fec_recib_evser AS Fecha, obser_evser AS Observaciones, calientrega_evser AS Calidad_Entrega, caliserv_evser AS Calidad_Servicio from evaluacion_servicio where caliserv_evser IN('Bueno','Muy Bueno')";
                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, conn);

                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;

                return bSource;
            }
            catch (MySqlException ex)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public BindingSource fun_getAllQuejasNegativas()
        {
            /*FUNCION PARA OBTENER LISTADO COMPLETO DE QUEJAS NEGATIVAS DE LA BASE DE DATOS
             * Autor: Merlyn Franco
             * Fecha: 16/08/2016*/

            MySqlConnection conn;

            try
            {
                //SE CREA CONEXION
                clsConexion mclsConexion = new clsConexion();
                conn = mclsConexion.fun_Conectar();
                conn.Open();
            }
            catch (MySqlException ex)
            {
                System.Diagnostics.Debug.Write(ex.InnerException.ToString());
                return null;
            }

            try
            {
                //SCRIPT PARA OBTENER TODAS LAS QUEJAS NEGATIVAS DE LA BASE DE DATOS
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                string sqlSelectAll = "SELECT 	pk_codevser AS Codigo, 	pk_pclte AS Codigo_Cliente, fec_recib_evser AS Fecha, obser_evser AS Observaciones, calientrega_evser AS Calidad_Entrega, caliserv_evser AS Calidad_Servicio from evaluacion_servicio where caliserv_evser IN('Malo','Muy Malo') ";
                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, conn);

                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;

                return bSource;
            }
            catch (MySqlException ex)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
