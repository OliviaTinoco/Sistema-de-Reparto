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
    public partial class frmConsultasRepartidores : Form
    {
        #region Procedimientos
        private void pro_loadQuejasNegativas()
        {

            clsConsultas mclsQuejasNegativas = new clsConsultas();
            dvg_QuejasNegativas.DataSource = mclsQuejasNegativas.fun_getAllQuejasNegativas();


        }

        private void pro_loadQuejasPositivas() {

            clsConsultas mclsQuejaPositivas = new clsConsultas();
            dvg_QuejasPositivas.DataSource = mclsQuejaPositivas.fun_getAllQuejasPositivas();

        }

        #endregion

        public frmConsultasRepartidores()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_QuejasPositivas_Click(object sender, EventArgs e)
        {
            pro_loadQuejasPositivas();
        }

        private void btn_QuejasNegativas_Click(object sender, EventArgs e)
        {
            pro_loadQuejasNegativas();
        }

        private void lbl_buscar_Click(object sender, EventArgs e)
        {

        }
    }
}
