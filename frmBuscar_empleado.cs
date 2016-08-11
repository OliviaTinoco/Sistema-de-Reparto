using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemareparto
{
    public partial class frmBuscar_empleado : Form
    {
        public frmBuscar_empleado()
        {
            InitializeComponent();
        }

        public clsEmpleado EmpleadoSeleccionado { get; set; }
        public clsDiremp DireccionSeleccionada { get; set; }
        public clsTelemp TelefonoSeleccionado { get; set; }
        public clsCorreoemp CorreoSeleccionado { get; set; }

        private void frmBuscar_empleado_Load(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //jala empleado
            if (dgv_buscemp.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgv_buscemp.CurrentRow.Cells[0].Value);
                EmpleadoSeleccionado = clsEmpleadodal.ObtenerEmpleado(id);

                //this.Close();
            }
            else
                MessageBox.Show("debe de seleccionar una fila");

            //jala la direccion
            if (dgv_buscdir.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgv_buscdir.CurrentRow.Cells[0].Value);
                DireccionSeleccionada = clsEmpleadodal.ObtenerDiremp(id);

                //this.Close();
            }
            else
                MessageBox.Show("debe de seleccionar una fila");
            
            //jala el telefono            
            if (dgv_busctel.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgv_busctel.CurrentRow.Cells[0].Value);
                TelefonoSeleccionado = clsEmpleadodal.ObtenerTelemp(id);

                //this.Close();
            }
            else
                MessageBox.Show("debe de seleccionar una fila");

            //jala el correo
            if (dgv_buscor.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgv_buscor.CurrentRow.Cells[0].Value);
                CorreoSeleccionado = clsEmpleadodal.ObtenerCorreo(id);

                this.Close();
            }
            else
                MessageBox.Show("debe de seleccionar una fila");
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dgv_buscemp.DataSource = clsEmpleadodal.Buscar(txt_nombre.Text, txt_apellido.Text);
            dgv_buscdir.DataSource = clsEmpleadodal.Buscardir(txt_nombre.Text, txt_apellido.Text);
            dgv_busctel.DataSource = clsEmpleadodal.Buscartel(txt_nombre.Text, txt_apellido.Text);
            dgv_buscor.DataSource = clsEmpleadodal.Buscarcor(txt_nombre.Text, txt_apellido.Text);
        }
    }
}
