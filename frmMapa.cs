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
    public partial class frmMapa : Form
    {
        public frmMapa()
        {
            InitializeComponent();
        }

        public clsmapa DatoActual { get; set; }

        private void frmMapa_Load(object sender, EventArgs e)
        {
            frmrutas_maps fin = new frmrutas_maps();
            

            if (fin.map1 != null)
            {
                DatoActual = fin.map1;
                txt_nomc.Text = fin.map1.snomclte;
                /*txt_pedido.Text = fin.ClienteSeleccionado.snombre;
                txt_zona.Text = fin.ClienteSeleccionado.papellido;
                txt_calle.Text = fin.ClienteSeleccionado.sapellido;
                txt_aven.Text = fin.ClienteSeleccionado.nit;
                txt_nome.Text = fin.ClienteSeleccionado.fecha_nac;*/

                // MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

           frmrutas_maps fin = new frmrutas_maps();
            fin.ShowDialog();


            if (fin.map1 != null)
            {
                DatoActual = fin.map1;
                txt_nomc.Text = fin.map1.snomclte;
                txt_aven.Text = fin.map1.saveclte;
                txt_calle.Text = fin.map1.scalleclte;
                txt_zona.Text = fin.map1.szonaclte;
                txt_nome.Text = fin.map1.snomempl;
                txt_pedido.Text = Convert.ToString(fin.map1.icodped);
                /*txt_pedido.Text = fin.ClienteSeleccionado.snombre;
                txt_zona.Text = fin.ClienteSeleccionado.papellido;
                txt_calle.Text = fin.ClienteSeleccionado.sapellido;
                txt_aven.Text = fin.ClienteSeleccionado.nit;
                txt_nome.Text = fin.ClienteSeleccionado.fecha_nac;*/

                // MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_mapa_Click(object sender, EventArgs e)
        {
            string street = txt_calle.Text;
            string zone = txt_zona.Text;
            string aven = txt_aven.Text;

            try
            {
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("http://maps.google.com.gt/maps?q=");

                if (street != string.Empty)
                {
                    queryaddress.Append(street + "," + ",");
                }

                if (zone != string.Empty)
                {
                    queryaddress.Append(zone + "," + ",");
                }

                if (aven != string.Empty)
                {
                    queryaddress.Append(aven + "," + ",");
                }

                webBrowser1.Navigate(queryaddress.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "ERROR");
            }
        }
    }
}
