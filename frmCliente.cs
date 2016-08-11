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

namespace sistemareparto
{
    public partial class cliente : Form
    {
        public cliente()
        {
            InitializeComponent();
        }

        public clsCliente ClienteActual { get; set;}                

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mtel_btn_Click(object sender, EventArgs e)
        {
            frmTelefono tele = new frmTelefono();
            tele.ShowDialog();
        }

        private void cliente_Load(object sender, EventArgs e)
        {
            dgv_cliente.DataSource = clsClientedal.grid();
            dgv_dir.DataSource = clsClientedal.grid2();
            dgv_tel.DataSource = clsClientedal.grid3();            
        }

        private void mdir_btn_Click(object sender, EventArgs e)
        {
            frmDireccion dir = new frmDireccion();
            dir.ShowDialog();
        }

        private void acpt_btn_Click(object sender, EventArgs e)
        {

        }

        private void busc_btn_Click(object sender, EventArgs e)
        {
            frmBuscar_cliente fin = new frmBuscar_cliente();
            fin.ShowDialog();
        }

        private void cncl_btn_Click(object sender, EventArgs e)
        {

        }

        private void new_btn_Click(object sender, EventArgs e)
        {

        }

        private void del_btn_Click(object sender, EventArgs e)
        {

        }

        private void mod_btn_Click(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            frmBuscar_cliente fin = new frmBuscar_cliente();
            fin.ShowDialog();

            if(fin.ClienteSeleccionado != null)
            {
                ClienteActual = fin.ClienteSeleccionado;
                txt_pnombre.Text = fin.ClienteSeleccionado.pnombre;
                txt_snombre.Text = fin.ClienteSeleccionado.snombre;
                txt_papellido.Text = fin.ClienteSeleccionado.papellido;
                txt_sapellido.Text = fin.ClienteSeleccionado.sapellido;
                txt_nit.Text = fin.ClienteSeleccionado.nit;                
                txt_fechanac.Text = fin.ClienteSeleccionado.fecha_nac;

                txt_zona.Text = fin.DireccionSeleccionada.zona;
                txt_calle.Text = fin.DireccionSeleccionada.calle;
                txt_avenida.Text = fin.DireccionSeleccionada.avenida;              
                
                // MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }        
        }

        private void busc_btndir_Click(object sender, EventArgs e)
        {
            frmDireccion dir = new frmDireccion();
            dir.ShowDialog();
        }

        private void bus_btndir_Click(object sender, EventArgs e)
        {

            frmTelefono fin = new frmTelefono();
            fin.ShowDialog();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //clsBdComun.ObtenerConexion();
            //MessageBox.Show("conecto :D");
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            clsCliente pCliente = new clsCliente();         //------------insert cliente             
            pCliente.pnombre = txt_pnombre.Text.Trim();
            pCliente.snombre = txt_snombre.Text.Trim();
            pCliente.papellido = txt_papellido.Text.Trim();
            pCliente.sapellido = txt_sapellido.Text.Trim();
            pCliente.nit = txt_nit.Text.Trim();
            pCliente.fecha_nac = txt_fechanac.Text.Trim();//Convert.ToDateTime(txt_fechanac.Text.Trim());  //dtpFechaNacimiento.Value.Year + "/" + dtpFechaNacimiento.Value.Month + "/" + dtpFechaNacimiento.Value.Day;

            clsDircliente pDircliente = new clsDircliente();            //---------inserta direccion
            pDircliente.zona = txt_zona.Text.Trim();
            pDircliente.calle = txt_calle.Text.Trim();
            pDircliente.avenida = txt_avenida.Text.Trim();

            clsDircliente pDircliente1 = new clsDircliente();            //---------inserta direccion
            pDircliente1.zona = txt_zona1.Text.Trim();
            pDircliente1.calle = txt_calle1.Text.Trim();
            pDircliente1.avenida = txt_avenida1.Text.Trim();

            clsDircliente pDircliente2 = new clsDircliente();            //---------inserta direccion
            pDircliente2.zona = txt_zona2.Text.Trim();
            pDircliente2.calle = txt_calle2.Text.Trim();
            pDircliente2.avenida = txt_avenida2.Text.Trim();

            clsTelcliente pTelcliente = new clsTelcliente();            //---------inserta telefono
            pTelcliente.telefono = txt_tel.Text.Trim();

            clsTelcliente pTelcliente1 = new clsTelcliente();            //---------inserta telefono
            pTelcliente1.telefono = txt_tel1.Text.Trim();

            clsTelcliente pTelcliente2 = new clsTelcliente();            //---------inserta telefono
            pTelcliente2.telefono = txt_tel2.Text.Trim();

            int resultado = clsClientedal.Agregar(pCliente);
            if (resultado > 0)
            {
                MySqlConnection conectar = clsBdComun.ObtenerConexion();

                MySqlCommand _comando = new MySqlCommand(String.Format("SELECT pk_codclte FROM cliente  where papel_clte = '{0}' ", txt_papellido.Text), conectar);
                MySqlDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {

                    pDircliente.idc = _reader.GetInt16(0);
                    pDircliente1.idc = _reader.GetInt16(0);
                    pDircliente2.idc = _reader.GetInt16(0);




                }
                // MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            int resultado1 = clsDircdal.Agregar(pDircliente);
            int resultado2 = clsDircdal.Agregar(pDircliente1);
            int resultado3 = clsDircdal.Agregar(pDircliente2);

            if (resultado > 0 && resultado1 > 0 && resultado2 > 0 && resultado3 > 0)
            {
                //MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MySqlConnection conectar = clsBdComun.ObtenerConexion();

                MySqlCommand _comando = new MySqlCommand(String.Format("SELECT pk_codclte FROM cliente  where papel_clte = '{0}' ", txt_papellido.Text), conectar);
                MySqlDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {

                    pTelcliente.idc = _reader.GetInt16(0);
                    pTelcliente1.idc = _reader.GetInt16(0);
                    pTelcliente2.idc = _reader.GetInt16(0);
                }
            }

            int resultado4 = clsTelcdal.Agregar(pTelcliente);
            int resultado5 = clsTelcdal.Agregar(pTelcliente1);
            int resultado6 = clsTelcdal.Agregar(pTelcliente2);

            if(resultado4 > 0 && resultado5 > 0 && resultado6 > 0)
            {
                MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("FALLO");
            }                       

            //------------mostrar en el grid 
            /*MySqlConnection conectar = clsBdComun.ObtenerConexion();
            MySqlDataAdapter dausuario = new MySqlDataAdapter("SELECT * FROM cliente", conectar);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, "cliente");
            dgv_cliente.DataSource = dsuario;
            dgv_cliente.DataMember = "cliente";
            conexion.Close();*/
        }

        private void dgv_cliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            clsCliente pCliente = new clsCliente();            

            pCliente.pnombre = txt_pnombre.Text.Trim();
            pCliente.snombre = txt_snombre.Text.Trim();
            pCliente.papellido = txt_papellido.Text.Trim();
            pCliente.sapellido = txt_sapellido.Text.Trim();
            pCliente.nit = txt_nit.Text.Trim();
            pCliente.fecha_nac = txt_fechanac.Text.Trim();
            pCliente.id = ClienteActual.id;

            if (clsClientedal.Actualizar(pCliente) > 0)
            {
                MessageBox.Show("Los datos del cliente se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro que desea eliminar el Cliente Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsClientedal.Eliminar(ClienteActual.id) > 0)
                {
                    MessageBox.Show("Cliente Eliminado Correctamente!", "Cliente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Cliente", "Cliente No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
