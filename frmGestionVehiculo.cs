using System;
using System.Windows.Forms;
using sistemareparto.Modelo;

namespace sistemareparto
{
    public partial class frmGestionVehiculo : Form
    {
        #region Procedimientos

        private void pro_habilitaInputs()
        {
            /*METODO PARA HABILITAR TODOS LOS CAMPOS
           * Autor: Merlyn Franco
           * Fecha: 10/08/2016*/
            try
            {
                txt_Vehiculo.Enabled = true;
                ltp_ingreso.Enabled = true;
                ltp_salida.Enabled = true;
                txt_entrada.Enabled = true;
                txt_salida.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }

        }

        private void pro_deshabilitaInputs()
        {
            /*METODO PARA DESHABILITAR TODOS LOS CAMPOS
             * Autor: Merlyn Franco
             * Fecha: 10/08/2016*/
            try
            {
                txt_Vehiculo.Enabled = false;
                ltp_ingreso.Enabled = false;
                ltp_salida.Enabled = false;
                txt_entrada.Enabled = false;
                txt_salida.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }

        }

        private void pro_limpiaInputs()
        {

            /*METODO PARA LIMPIAR VALORES DE TODOS LOS CAMPOS
             * Autor: Merlyn Franco
             * Fecha: 10/08/2016*/
            try
            {
                txt_Vehiculo.Text = string.Empty;
                ltp_ingreso.Text = string.Empty;
                ltp_salida.Text = string.Empty;
                txt_entrada.Text = string.Empty;
                txt_salida.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void pro_habilitaBotones()
        {
            btn_nuevo.Enabled = true;
            btn_buscar.Enabled = true;
        }

        private void pro_loadGestion()
        {
            clsModeloGestion mclsModeloGestion = new clsModeloGestion();
            dgv_gestion.DataSource = mclsModeloGestion.fun_getAllGestiones();

        }

        #endregion

        #region Funciones
        private bool fun_esEntero(String SNumero)
        {
            /*FUNCION PARA QUE VALIDA STRING PARA ASEGURAR QUE ES ENTERO
             * Autor: Merlyn Franco
             * Fecha: 10/08/2016*/
            int INumero;
            return int.TryParse(SNumero, out INumero);
        }

        private bool fun_esDecimal(String SNumero)
        {
            /*FUNCION PARA QUE VALIDA STRING PARA ASEGURAR QUE ES DOUBLE
             * Autor: Merlyn Franco
             * Fecha: 10/08/2016*/
            Double DNumero;
            return Double.TryParse(SNumero, out DNumero);
        }

        private bool fun_validaCampos()
        {
            /*FUNCION PARA VALIDAR LOS DATOS INGRESADOS
             * Autor: Merlyn Franco
             * Fecha: 10/08/2016*/

            if (txt_Vehiculo.Text == String.Empty)
            {
                MessageBox.Show("Debe Indicar un Vehiculo");
                return false;
            }
            if (ltp_ingreso.Text == String.Empty)
            {
                MessageBox.Show("Debe Indicar una Fecha de Ingreso");
                return false;
            }
            if (ltp_salida.Text == String.Empty)
            {
                MessageBox.Show("Debe Indicar una Fecha de Salida");
                return false;
            }
            if (txt_entrada.Text == String.Empty)
            {
                MessageBox.Show("Debe Indicar un Estado de Entrada ");
                return false;
            }
            if (txt_salida.Text == String.Empty)
            {
                MessageBox.Show("Debe Indicar un Estado de Salida");
                return false;
            }

            return true;
        }

        #endregion

        #region eventos


        public frmGestionVehiculo()
        {
            InitializeComponent();
            pro_loadGestion();
        }


        private void busc_btn_Click(object sender, EventArgs e)
        {
            frmBuscarGestionFiltrado busc = new frmBuscarGestionFiltrado();
            busc.ShowDialog();
            

            if (busc.Vehiculo != null)
            {
                txt_Vehiculo.Text = busc.Vehiculo.iId.ToString();


                //HABILITAMOS CAMPOS DE INGRESO DE DATOS
                pro_habilitaInputs();


                //HABILITAR BOTONES NECESARIOS
                btn_nuevo.Enabled = false;
                btn_guardar.Enabled = true;
                btn_modificar.Enabled = false;
                btn_eliminar.Enabled = false;
                btn_cancelar.Enabled = true;
                btn_buscar.Enabled = false;

            }
            //usuariodal.obtenerBitacora(usuariodal.varibaleUsuario, "Buscar", "gestion_vehiculo");
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            //DESHABILITA BOTONES INECESARIOS
            btn_nuevo.Enabled = false;
            btn_guardar.Enabled = true;
            btn_modificar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_cancelar.Enabled = true;
            btn_buscar.Enabled = false;

            //HABILITA CAMPOS PARA INGRESO DE DATOS
            pro_habilitaInputs();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            /*EVENTO DESENCADENADO EN CLICK DEL BOTON GUARDAR
            * Autor: Merlyn Franco
            * Fecha: 10/08/2016*/

            //SE VALIDA QUE SE INGRESEN LOS CAMPOS CORRECTAMENTE
            if (fun_validaCampos())
            {
                //CREAMOS OBJETO GESTION CON DATOS INGRESADOS
                clsGestionVehiculo mGestion = new clsGestionVehiculo();
                mGestion.iVehi = Convert.ToInt32(txt_Vehiculo.Text);
                mGestion.dFechaIngre = ltp_ingreso.Value.Date;
                mGestion.dFechaSale = ltp_salida.Value.Date;
                mGestion.sEstadoIngre = txt_entrada.Text;
                mGestion.sEstadoSale = txt_salida.Text;


                //INSERTA GESTION
                clsModeloGestion mModeloGestion = new clsModeloGestion();

                //GUARDA LA GESTION EN BBDD
                if (mModeloGestion.fun_guardarGestion(mGestion))
                {
                    MessageBox.Show(" Gestion de Vehiculo guardada correctamente...");

                    //LIMPIA INFORMACIÓN DE CAMPOS
                    pro_limpiaInputs();
                    //DESHABILITA LOS CAMPOS
                    pro_deshabilitaInputs();
                    //HABILITA LOS BOTONES
                    pro_habilitaBotones();
                    //LLENA DATAGRIDVIEW CON EL NUEVO REGISTRO
                    pro_loadGestion();

                    //DESHABILITA BOTONES INECESARIOS
                    btn_guardar.Enabled = true;
                    btn_cancelar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error al guardar Vehículo");
                }
            }

            //usuariodal.obtenerBitacora(usuariodal.varibaleUsuario, "guardar", "gestion_vehiculo");

        }

        private void btn_BuscarVehi_Click(object sender, EventArgs e)
        {
            frmBuscarGestionFiltrado busc = new frmBuscarGestionFiltrado();
            busc.ShowDialog();

            if (busc.Vehiculo != null)
            {
                txt_Vehiculo.Text = busc.Vehiculo.iId.ToString();


                //HABILITAMOS CAMPOS DE INGRESO DE DATOS
                pro_habilitaInputs();


                //HABILITAR BOTONES NECESARIOS
                btn_nuevo.Enabled = false;
                btn_guardar.Enabled = true;
                btn_modificar.Enabled = false;
                btn_eliminar.Enabled = false;
                btn_cancelar.Enabled = true;
                btn_buscar.Enabled = false;

            }
            //usuariodal.obtenerBitacora(usuariodal.varibaleUsuario, "Buscar", "gestion_vehiculo");
        }



        private void btn_modificar_Click(object sender, EventArgs e)
        {
            //SE VALIDA QUE SE INGRESEN LOS CAMPOS CORRECTAMENTE
            if (fun_validaCampos())
            {
                //CREAMOS OBJETO GESTION VEHICULO CON DATOS INGRESADOS

                clsGestionVehiculo mGestion = new clsGestionVehiculo();

                mGestion.iIdGest = Convert.ToInt32(txt_Id.Text);
                mGestion.iVehi = Convert.ToInt32(txt_Vehiculo.Text);
                mGestion.dFechaIngre = ltp_ingreso.Value.Date;
                mGestion.dFechaSale = ltp_salida.Value.Date;
                mGestion.sEstadoIngre = txt_entrada.Text;
                mGestion.sEstadoSale = txt_salida.Text;

                //ACTUALIZA GESTION VEHICULO
                clsModeloGestion mModeloGestion = new clsModeloGestion();
                
                //ACTUALIZA LA GESTION DEL VEHICULO EN BDD
                if (mModeloGestion.fun_actualizarGestion(mGestion))
                {
                    MessageBox.Show("Gestion de Vehiculo Actualizado correctamente...");
                    //LIMPIA INFORMACIÓN DE CAMPOS
                    pro_limpiaInputs();
                    //DESHABILITA LOS CAMPOS
                    pro_deshabilitaInputs();
                    //HABILITA LOS BOTONES
                    pro_habilitaBotones();
                    //LLENA DATAGRIDVIEW CON EL NUEVO REGISTRO
                    pro_loadGestion();

                    //DESHABILITA BOTONES INECESARIOS
                    btn_modificar.Enabled = false;
                    btn_eliminar.Enabled = false;
                    btn_cancelar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error al Actualizar Gestion de Vehículo");
                }

            }
            else
            {
                MessageBox.Show("Seleccione una Gestion de Vehiculo Correcta");
            }

            //usuariodal.obtenerBitacora(usuariodal.varibaleUsuario, "Modificar", "gestion_vehiculo");
        }

        private void dgv_gestion_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_gestion.SelectedRows.Count > 0)
            {
                DataGridViewRow dgvrFila = dgv_gestion.SelectedRows[0];

                txt_Id.Text = dgvrFila.Cells[0].Value.ToString();
                txt_Vehiculo.Text = dgvrFila.Cells[1].Value.ToString();
                ltp_salida.Value = Convert.ToDateTime(dgvrFila.Cells[2].Value.ToString());
                ltp_ingreso.Value = Convert.ToDateTime(dgvrFila.Cells[3].Value.ToString());
                txt_entrada.Text = dgvrFila.Cells[4].Value.ToString();
                txt_salida.Text = dgvrFila.Cells[5].Value.ToString();
                

                //HABILITAMOS CAMPOS DE INGRESO DE DATOS
                pro_habilitaInputs();
                //HABILITAR BOTONES NECESARIOS
                btn_nuevo.Enabled = false;
                btn_guardar.Enabled = false;
                btn_modificar.Enabled = true;
                btn_eliminar.Enabled = true;
                btn_cancelar.Enabled = true;
                btn_buscar.Enabled = false;
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            /*EVENTO DESENCADENADO EN CLICK DEL BOTON ELIMINAR
            * Autor: Merlyn Franco
            * Fecha: 10/08/2016*/

            //SE VALIDA QUE HAYA SELECIONADO UNA GESTION DE VEHICULO
            if (txt_Id.Text != String.Empty && fun_esEntero(txt_Id.Text))
            {
                //ELIMINA GESTION VEHICULO
                clsModeloGestion mModeloGestion = new clsModeloGestion();
                
                //ELIMINA LA GESTION DEL VEHICULO EN BDD
                if (mModeloGestion.fun_eliminarGestion(Convert.ToInt32(txt_Id.Text)))
                {
                    MessageBox.Show("Gestion de Vehiculo Eliminado correctamente...");

                    //LIMPIA INFORMACIÓN DE CAMPOS
                    pro_limpiaInputs();
                    //DESHABILITA LOS CAMPOS
                    pro_deshabilitaInputs();
                    //HABILITA LOS BOTONES
                    pro_habilitaBotones();
                    //LLENA DATAGRIDVIEW CON EL NUEVO REGISTRO
                    pro_loadGestion();

                    //DESHABILITA BOTONES INECESARIOS
                    btn_modificar.Enabled = false;
                    btn_eliminar.Enabled = false;
                    btn_cancelar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error al eliminar Gestion de Vehiculo");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una Gestion de Vehiculo Correcto");
            }

            //usuariodal.obtenerBitacora(usuariodal.varibaleUsuario, "Eliminar", "gestion_vehiculo");
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            /*EVENTO DESENCADENADO EN CLICK DEL BOTON CANCELAR
            * Autor: Merlyn Franco
            * Fecha: 10/08/2016*/

            //LIMPIA INFORMACIÓN DE CAMPOS
            pro_limpiaInputs();
            //DESHABILITA LOS CAMPOS
            pro_deshabilitaInputs();
            //HABILITA LOS BOTONES
            pro_habilitaBotones();

            //DESHABILITA BOTONES INECESARIOS
            btn_guardar.Enabled = false;
            btn_modificar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_cancelar.Enabled = false;
        }

        //usuariodal.obtenerBitacora(usuariodal.varibaleUsuario, "Cancelar", "gestion_vehiculo");

        #endregion
    }
}
