using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace sistemareparto
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        void ayudar()
        {
            string ruta = @"C:\Users\ale_\Desktop\Repositorio.pdf";
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = "AcroRd32.exe";
            startinfo.Arguments = ruta;
            Process.Start(startinfo);
        }

        public void mostrar()
        {
            dgv_empleado.DataSource = clsEmpleadodal.grid();
            dgv_diremp.DataSource = clsEmpleadodal.grid2();
            dgv_telemp.DataSource = clsEmpleadodal.grid3();
            dgv_correo.DataSource = clsEmpleadodal.grid4();
        }

        void Limpiar()
        {
            txt_pnombre.Clear();
            txt_snombre.Clear();
            txt_papellido.Clear();
            txt_sapellido.Clear();
            txt_nit.Clear();
            txt_fechanac.Clear();
            txt_zona.Clear();
            txt_calle.Clear();
            txt_avenida.Clear();
            txt_zona1.Clear();
            txt_calle1.Clear();
            txt_avenida1.Clear();            
            txt_tel.Clear();
            txt_tel1.Clear();
            txt_correo.Clear();
            txt_correo1.Clear();
            txt_estado.Clear();
            txt_sueldo.Clear();
            //cbo_emp = null;            

        }

        void Habilitar()
        {

            txt_pnombre.Enabled = true;
            txt_snombre.Enabled = true;
            txt_papellido.Enabled = true;
            txt_sapellido.Enabled = true;
            txt_nit.Enabled = true;
            txt_fechanac.Enabled = true;
            txt_zona.Enabled = true;
            txt_calle.Enabled = true;
            txt_avenida.Enabled = true;
            txt_zona1.Enabled = true;
            txt_calle1.Enabled = true;
            txt_avenida1.Enabled = true;            
            txt_tel.Enabled = true;
            txt_tel1.Enabled = true;
            txt_correo.Enabled = true;
            txt_correo1.Enabled = true;
            cbo_emp.Enabled = true;            
            //btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;

        }

        void Deshabilitar()
        {
            txt_pnombre.Enabled = false;
            txt_snombre.Enabled = false;
            txt_papellido.Enabled = false;
            txt_sapellido.Enabled = false;
            txt_nit.Enabled = false;
            txt_fechanac.Enabled = false;
            txt_zona.Enabled = false;
            txt_calle.Enabled = false;
            txt_avenida.Enabled = false;
            txt_zona1.Enabled = false;
            txt_calle1.Enabled = false;
            txt_avenida1.Enabled = false;
            txt_tel.Enabled = false;
            txt_tel1.Enabled = false;
            txt_correo.Enabled = false;
            txt_correo1.Enabled = false;
            cbo_emp.Enabled = false;
            btn_guardar.Enabled = false;
            btn_cancelar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_modificar.Enabled = false;


        }

        public clsEmpleado EmpleadoActual { get; set; }

        private void busc_btn_Click(object sender, EventArgs e)
        {
            frmBuscar_empleado fin = new frmBuscar_empleado();
            fin.ShowDialog();            

            if (fin.EmpleadoSeleccionado != null)
            {
                EmpleadoActual = fin.EmpleadoSeleccionado;
                txt_pnombre.Text = fin.EmpleadoSeleccionado.pnombre;
                txt_snombre.Text = fin.EmpleadoSeleccionado.snombre;
                txt_papellido.Text = fin.EmpleadoSeleccionado.papellido;
                txt_sapellido.Text = fin.EmpleadoSeleccionado.sapellido;
                txt_nit.Text = fin.EmpleadoSeleccionado.nit;
                txt_fechanac.Text = fin.EmpleadoSeleccionado.fecha_nac;
                txt_estado.Text = fin.EmpleadoSeleccionado.estado;
                txt_sueldo.Text = fin.EmpleadoSeleccionado.sueldo;
                txt_zona.Text = fin.DireccionSeleccionada.zona;
                txt_calle.Text = fin.DireccionSeleccionada.calle;
                txt_avenida.Text = fin.DireccionSeleccionada.avenida;

                txt_tel.Text = fin.TelefonoSeleccionado.telefono;

                txt_correo.Text = fin.CorreoSeleccionado.correo;
                // MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Habilitar();
            btn_modificar.Enabled = true;
            btn_eliminar.Enabled = true;
            btn_guardar.Enabled = false;
            btn_nuevo.Enabled = false;
        }

        private void mdir_btn_Click(object sender, EventArgs e)
        {
            frmDireccionEmp dir = new frmDireccionEmp();
            dir.ShowDialog();
        }

        private void mtel_btn_Click(object sender, EventArgs e)
        {
            frmTelefonoEmp tel = new frmTelefonoEmp();
            tel.ShowDialog();
        }

        private void mmail_btn_Click(object sender, EventArgs e)
        {
            frmCorreoEmp corre = new frmCorreoEmp();
            corre.ShowDialog();
        }

        private void puesto_btn_Click(object sender, EventArgs e)
        {
            frmPuestEmp pues = new frmPuestEmp();
            pues.ShowDialog();
        }

        private void busc_btndir_Click(object sender, EventArgs e)
        {
            frmPuestEmp pues = new frmPuestEmp();
            pues.ShowDialog();
        }

        private void Btn_btel_Click(object sender, EventArgs e)
        {
            frmCorreoEmp tel = new frmCorreoEmp();
            tel.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTelefonoEmp tel = new frmTelefonoEmp();
            tel.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDireccionEmp dir = new frmDireccionEmp();
            dir.ShowDialog();
        }

        private void Empleado_Load(object sender, EventArgs e)
        {
            /*string scad = "select * from puesto";
            MySqlCommand mcd = new MySqlCommand(scad, clsBdComun.ObtenerConexion());
            MySqlDataReader mdr = mcd.ExecuteReader();
            while (mdr.Read())
            {
                cbo_emp.Items.Add(mdr.GetString("nom_puesto"));
            }*/
            Limpiar();
            Deshabilitar();
            mostrar();
        }

        private void cbo_emp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            string scad = "select * from puesto";
            MySqlCommand mcd = new MySqlCommand(scad, clsBdComun.ObtenerConexion());
            MySqlDataReader mdr = mcd.ExecuteReader();
            while (mdr.Read())
            {
                cbo_emp.Items.Add(mdr.GetString("nom_puesto"));
            }

            //dgv_empleado.DataSource = clsEmpleadodal.grid();
            Limpiar();
            Habilitar();
            btn_modificar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_buscar.Enabled = false;
            mostrar();

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try { 
            MySqlConnection conect = clsBdComun.ObtenerConexion();

            MySqlCommand _comand = new MySqlCommand(String.Format("SELECT pk_codpuesto FROM puesto where nom_puesto = '{0}' ", cbo_emp.Text), conect);
            MySqlDataReader _read = _comand.ExecuteReader();
                clsEmpleado pEmpleado = new clsEmpleado();
                while (_read.Read())
                {


                    pEmpleado.idp = _read.GetInt16(0);

                }
                MessageBox.Show(Convert.ToString(pEmpleado.idp)); //------------insert cliente             
           pEmpleado.pnombre = txt_pnombre.Text.Trim();
                pEmpleado.snombre = txt_snombre.Text.Trim();
                pEmpleado.papellido = txt_papellido.Text.Trim();
                pEmpleado.sapellido = txt_sapellido.Text.Trim();
                pEmpleado.nit = txt_nit.Text.Trim();
                pEmpleado.fecha_nac = txt_fechanac.Text.Trim();//Convert.ToDateTime(txt_fechanac.Text.Trim());  //dtpFechaNacimiento.Value.Year + "/" + dtpFechaNacimiento.Value.Month + "/" + dtpFechaNacimiento.Value.Day;
                pEmpleado.sueldo = txt_sueldo.Text.Trim();
                pEmpleado.estado = txt_estado.Text.Trim();

                clsDiremp pDiremp = new clsDiremp();            //---------inserta direccion
                pDiremp.zona = txt_zona.Text.Trim();
                pDiremp.calle = txt_calle.Text.Trim();
                pDiremp.avenida = txt_avenida.Text.Trim();

                clsDiremp pDiremp1 = new clsDiremp();            //---------inserta direccion
                pDiremp1.zona = txt_zona1.Text.Trim();
                pDiremp1.calle = txt_calle1.Text.Trim();
                pDiremp1.avenida = txt_avenida1.Text.Trim();

                clsTelemp pTelemp = new clsTelemp();            //---------inserta telefono
                pTelemp.telefono = txt_tel.Text.Trim();

                clsTelemp pTelemp1 = new clsTelemp();            //---------inserta telefono
                pTelemp1.telefono = txt_tel1.Text.Trim();

                clsCorreoemp pCorreoemp = new clsCorreoemp();            //---------inserta correo
                pCorreoemp.correo = txt_correo.Text.Trim();

                clsCorreoemp pCorreoemp1 = new clsCorreoemp();            //---------inserta correo
                pCorreoemp1.correo = txt_correo1.Text.Trim();

                int resultado = clsEmpleadodal.Agregar(pEmpleado);
              if (resultado > 0)
                {
                    MySqlConnection conectar = clsBdComun.ObtenerConexion();

                    MySqlCommand _comando = new MySqlCommand(String.Format("SELECT pk_codemp FROM empleado where papel_emp = '{0}' ", txt_papellido.Text), conectar);
                    MySqlDataReader _reader = _comando.ExecuteReader();
                    while (_reader.Read())
                    {

                        pDiremp.ide = _reader.GetInt16(0);
                        pDiremp1.ide = _reader.GetInt16(0);

                    }
                    conectar.Close();
                    // MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                int resultado1 = clsDiredal.Agregar(pDiremp);
                int resultado2 = clsDiredal.Agregar(pDiremp1);

                if (resultado > 0 && resultado1 > 0 && resultado2 > 0)
                {
                    //MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MySqlConnection conectar = clsBdComun.ObtenerConexion();

                    MySqlCommand _comando = new MySqlCommand(String.Format("SELECT pk_codemp FROM empleado where papel_emp = '{0}' ", txt_papellido.Text), conectar);
                    MySqlDataReader _reader = _comando.ExecuteReader();
                    while (_reader.Read())
                    {

                        pTelemp.ide = _reader.GetInt16(0);
                        pTelemp1.ide = _reader.GetInt16(0);
                    }
                    conectar.Close();
                }

                int resultado3 = clsTeledal.Agregar(pTelemp);
                int resultado4 = clsTeledal.Agregar(pTelemp1);

                if (resultado3 > 0 && resultado4 > 0)
                {
                    //MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MySqlConnection conectar = clsBdComun.ObtenerConexion();

                    MySqlCommand _comando = new MySqlCommand(String.Format("SELECT pk_codemp FROM empleado where papel_emp = '{0}' ", txt_papellido.Text), conectar);
                    MySqlDataReader _reader = _comando.ExecuteReader();
                    while (_reader.Read())
                    {
                       
                        pCorreoemp.ide = _reader.GetInt16(0);
                        pCorreoemp1.ide = _reader.GetInt16(0);
                    }
                    conectar.Close();
                    //MessageBox.Show(Convert.ToString(pCorreoemp.ide));
                }

                int resultado5 = clsCorreoedal.Agregar(pCorreoemp);
                int resultado6 = clsCorreoedal.Agregar(pCorreoemp1);

                if (resultado5 > 0 && resultado6 > 0)
                {
                    MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    usuariodal.obtenerBitacora(usuariodal.varibaleUsuario, "Insertar", "Empleado");

                }
                else
                {
                    MessageBox.Show("FALLO");
                }

                //------------mostrar en el grid 
                /*MySqlConnection conectar = clsBdComun.ObtenerConexion();
                MySqlDataAdapter dausuario = new MySqlDataAdapter("SELECT * FROM empleado", conectar);
                DataSet dsuario = new DataSet();
                dausuario.Fill(dsuario, "cliente");
                dgv_empleado.DataSource = dsuario;
                dgv_empleado.DataMember = "cliente";*/
                conect.Close();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            dgv_empleado.DataSource = clsEmpleadodal.grid();

            Limpiar();
            Deshabilitar();
            btn_nuevo.Enabled = true;
            btn_buscar.Enabled = true;            
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                clsEmpleado pEmpleado = new clsEmpleado();

                pEmpleado.pnombre = txt_pnombre.Text.Trim();
                pEmpleado.snombre = txt_snombre.Text.Trim();
                pEmpleado.papellido = txt_papellido.Text.Trim();
                pEmpleado.sapellido = txt_sapellido.Text.Trim();
                pEmpleado.nit = txt_nit.Text.Trim();
                pEmpleado.fecha_nac = txt_fechanac.Text.Trim();
                pEmpleado.sueldo = txt_sueldo.Text.Trim();
                pEmpleado.estado = txt_estado.Text.Trim();
                pEmpleado.id = EmpleadoActual.id;

                if (clsEmpleadodal.Actualizar(pEmpleado) > 0)
                {
                    clsDiremp pDiremp = new clsDiremp();

                    pDiremp.zona = txt_zona.Text.Trim();
                    pDiremp.calle = txt_calle.Text.Trim();
                    pDiremp.avenida = txt_avenida.Text.Trim();

                    clsDiremp pDiremp1 = new clsDiremp();

                    pDiremp.zona = txt_zona1.Text.Trim();
                    pDiremp.calle = txt_calle1.Text.Trim();
                    pDiremp.avenida = txt_avenida1.Text.Trim();

                    if (clsDiredal.Actualizar(pDiremp) > 0 && clsDiredal.Actualizar(pDiremp1) > 0)
                    {
                        MessageBox.Show("Los datos del cliente se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        usuariodal.obtenerBitacora(usuariodal.varibaleUsuario, "Modificar", "Empleado");

                    }

                }
                else
                {
                    MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            dgv_empleado.DataSource = clsEmpleadodal.grid();

            Limpiar();
            Deshabilitar();
            btn_nuevo.Enabled = true;
            btn_buscar.Enabled = true;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro que desea eliminar el Cliente Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsClientedal.Eliminar(EmpleadoActual.id) > 0)
                {
                    MessageBox.Show("Cliente Eliminado Correctamente!", "Cliente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    usuariodal.obtenerBitacora(usuariodal.varibaleUsuario, "Eliminar", "Empleado");

                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Cliente", "Cliente No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            dgv_empleado.DataSource = clsEmpleadodal.grid();

            Limpiar();
            Deshabilitar();
            btn_nuevo.Enabled = true;
            btn_buscar.Enabled = true;
        }

        private void dgv_empleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {           
            //this.dgv_empleado.DataSource = clsEmpleadodal.grid();
        }

        private void dgv_diremp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            ayudar();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Deshabilitar();
            btn_nuevo.Enabled = true;
            btn_buscar.Enabled = true;
        }
    }
}
