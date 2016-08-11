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
    class clsModeloGestion
    {
        public bool fun_guardarGestion(clsGestionVehiculo pGestion)
        {
            /*FUNCION PARA INSERTAR EN BASE DE DATOS LA GESTION
             * Autor: Merlyn Franco
             * Fecha: 10/08/2016*/

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
                return false;
            }

            //INICIA INSERCIÓN
            try
            {
                //SE CREA SCRIPT DE INSERCIÓN
                string Query = "INSERT INTO gestion_vehiculo (fk_codvehiculo, fec_salida_gest_vehi, fec_ingre_gest_vehi, esta_ingre_gest_vehi, esta_salida_gest_vehi, estado_gestion) VALUES(" + pGestion.iVehi + ", '" + pGestion.dFechaSale.Date.ToString("yyyy-MM-dd") + "', '" + pGestion.dFechaIngre.Date.ToString("yyyy-MM-dd") + "', '" + pGestion.sEstadoIngre + "' , '" + pGestion.sEstadoSale + "', 'ACTIVO');";

                MySqlCommand command = conn.CreateCommand();
                command.CommandText = Query;
                command.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                System.Diagnostics.Debug.Write(ex.InnerException.ToString());
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool fun_actualizarGestion(clsGestionVehiculo pGestion)
        {
            /*FUNCION PARA ACTUALIZAR DATOS DE GESTION DE VEHICULO EN BASE DE DATOS
             * Autor: Merlyn Franco
             * Fecha: 10/08/2016*/

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
                return false;
            }

            //INICIA LA ACTUALIZACION 
            try
            {
                //SE CREA SCRIPT DE LA ACTUALIZACION
                string Query = "UPDATE gestion_vehiculo SET ";
                Query += "fec_salida_gest_vehi = '" + pGestion.dFechaSale.Date.ToString("yyyy-MM-dd") + "', ";
                Query += "	fec_ingre_gest_vehi= '" + pGestion.dFechaIngre.Date.ToString("yyyy-MM-dd") + "', ";
                Query += "esta_ingre_gest_vehi = '" + pGestion.sEstadoIngre + "', ";
                Query += "esta_salida_gest_vehi = '" + pGestion.sEstadoSale + "' ";
                Query += "WHERE pk_codgestvehi = " + pGestion.iIdGest.ToString();

                MySqlCommand command = conn.CreateCommand();
                command.CommandText = Query;
                command.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {

                System.Diagnostics.Debug.Write(ex.InnerException.ToString());
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool fun_eliminarGestion(int pIdGestion)
        {
            /*FUNCION PARA ELIMINAR DATOS DE LA GESTION EN BASE DE DATOS
             * Autor: Merlyn Franco
             * Fecha: 10/08/2016*/

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
                return false;
            }

            //INICIA ELIMINACION
            try
            {

                //SE CREA SCRIPT DE ELIMINACION
                string Query = "UPDATE gestion_vehiculo SET ";
                Query += "estado_gestion = 'ELIMINADO' ";
                Query += "WHERE pk_codgestvehi = " + pIdGestion.ToString();

                MySqlCommand command = conn.CreateCommand();
                command.CommandText = Query;
                command.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                System.Diagnostics.Debug.Write(ex.InnerException.ToString());
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public BindingSource fun_getAllGestiones()
        {

            /*FUNCION PARA OBTENER LISTADO COMPLETO DE LAS GESTIONES DE LOS VEHICULOS DE BASE DE DATOS
             * Autor: Merlyn Franco
             * Fecha: 10/08/2016*/

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
                //SCRIPT PARA OBTENER TODOS LAS GESTIONES DE LA BASE DE DATOS
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                string sqlSelectAll = "SELECT pk_codgestvehi AS Codigo, fk_codvehiculo AS CodigoVehiculo, DATE_FORMAT(fec_salida_gest_vehi,'%d/%m/%Y') AS Sale_Vehiculo, DATE_FORMAT(fec_ingre_gest_vehi,'%d/%m/%Y') AS Ingresa_Vehiculo, esta_ingre_gest_vehi AS Estado_Ingreso, esta_salida_gest_vehi AS Estado_Salida, estado_gestion AS Estado_Gestion FROM gestion_vehiculo WHERE estado_gestion != 'ELIMINADO'";
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

        public BindingSource fun_getAllGestionesFiltrado(String pPlaca, String pChasis)
        {
            /*FUNCION PARA OBTENER LISTADO DE VEHICULO QUE CUMPLAN CON LAS RESTRICCIONES DE BASE DE DATOS 
             * Autor: Merlyn Franco
             * Fecha: 10/08/2016*/

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
                //SCRIPT PARA OBTENER TODOS LOS VEHICULOS DE LA BASE DE DATOS
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                string sqlSelectAll = "SELECT v.* FROM vehiculo v WHERE NOT EXISTS(SELECT 1 FROM mantenimiento m WHERE m.fk_codvehi = v.pk_codvehi AND m.estado_mante != 'ELIMINADO')AND v.estado_vehi != 'ELIMINADO'  AND (placa_vehi = '" + pPlaca + "' OR '" + pPlaca + "' = '') AND chasis_vehi LIKE '%" + pChasis + "%'"; 
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
