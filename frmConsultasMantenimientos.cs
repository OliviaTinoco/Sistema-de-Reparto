using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemareparto.Modelo;

namespace sistemareparto
{
    public partial class frmConsultasMantenimientos : Form
    {
        private void pro_loadConsultasMante()
        {
            clsModeloMantimientoVehiculo mclsModeloManteni = new clsModeloMantimientoVehiculo();
            dvg_Mantenimientos.DataSource = mclsModeloManteni.fun_getAllMantenimientos();
            
        }
        public frmConsultasMantenimientos()
        {
            InitializeComponent();
        }

        private void btn_QuejasPositivas_Click(object sender, EventArgs e)
        {
            pro_loadConsultasMante();
        }
    }
}
