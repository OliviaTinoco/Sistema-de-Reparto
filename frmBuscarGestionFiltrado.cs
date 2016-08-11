using System;
using System.Windows.Forms;
using sistemareparto.Modelo;


namespace sistemareparto
{
    public partial class frmBuscarGestionFiltrado : Form
    {
        public clsVehiculo Vehiculo;

        #region Procedimiento

        private void pro_loadVehiculos()
        {
            clsModeloGestion mclsModeloGestion = new clsModeloGestion();
            dgv_vehiculo.DataSource = mclsModeloGestion.fun_getAllGestionesFiltrado(txt_placa.Text, txt_chasis.Text);

        }

        #endregion
        public frmBuscarGestionFiltrado()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            pro_loadVehiculos();

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (dgv_vehiculo.SelectedRows.Count == 1)
            {
                DataGridViewRow dgvrFila = dgv_vehiculo.SelectedRows[0];

                Vehiculo = new clsVehiculo();

                Vehiculo.iId = Convert.ToInt32(dgvrFila.Cells[0].Value.ToString());
                Vehiculo.sPlaca = dgvrFila.Cells[1].Value.ToString();
                Vehiculo.sChasis = dgvrFila.Cells[2].Value.ToString();
                Vehiculo.sColor = dgvrFila.Cells[3].Value.ToString();
                Vehiculo.sLinea = dgvrFila.Cells[4].Value.ToString();
                Vehiculo.sMarca = dgvrFila.Cells[5].Value.ToString();
                Vehiculo.sEstado = dgvrFila.Cells[6].Value.ToString();

                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un vehiculo");
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
