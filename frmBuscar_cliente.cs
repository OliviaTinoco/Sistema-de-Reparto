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
    public partial class frmBuscar_cliente : Form
    {
        public frmBuscar_cliente()
        {
            InitializeComponent();
        }

        public clsCliente ClienteSeleccionado { get; set; }
        public clsDircliente DireccionSeleccionada { get; set; }
        public clsTelcliente TelefonoSeleccionado { get; set; }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //jala cliente
            if (dgv_buscac.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgv_buscac.CurrentRow.Cells[0].Value);
                ClienteSeleccionado = clsClientedal.ObtenerCliente(id);

                if (dgv_buscdir.SelectedRows.Count == 1)
                {
                    int id2 = Convert.ToInt32(dgv_buscdir.CurrentRow.Cells[0].Value);
                    DireccionSeleccionada = clsClientedal.ObtenerDireccion(id2);

                    if (dgv_busctel.SelectedRows.Count == 1)
                    {
                        int id3 = Convert.ToInt32(dgv_busctel.CurrentRow.Cells[0].Value);
                        TelefonoSeleccionado = clsClientedal.ObtenerTelefono(id);

                        this.Close();
                    }
                    else
                        MessageBox.Show("debe de seleccionar una fila");

                    //this.Close();
                }
                else
                    MessageBox.Show("debe de seleccionar una fila");

                //this.Close();
            }
            else
                MessageBox.Show("debe de seleccionar una fila");

            //jala direccion
            /*if (dgv_buscac.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgv_buscac.CurrentRow.Cells[0].Value);
                DireccionSeleccionada = clsClientedal.ObtenerDireccion(id);

                this.Close();
            }
            else
                MessageBox.Show("debe de seleccionar una fila");*/
        }    

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dgv_buscac.DataSource = clsClientedal.Buscar(txt_nombre.Text, txt_apellido.Text);
            dgv_buscdir.DataSource = clsClientedal.Buscardir(txt_nombre.Text, txt_apellido.Text);
            dgv_busctel.DataSource = clsClientedal.Buscartel(txt_nombre.Text, txt_apellido.Text);
            /*DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
            columna.HeaderText = "hola";
            dgv_buscac.Columns.Add(columna);
            clsDircdal.Buscar(columna);*/
        }

        private void frmBuscar_cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
