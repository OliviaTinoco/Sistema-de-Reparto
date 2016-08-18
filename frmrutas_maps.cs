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
    public partial class frmrutas_maps : Form
    {
      
        public frmrutas_maps()
        {
            InitializeComponent();
        }

        private void frmrutas_maps_Load(object sender, EventArgs e)
        {
            string scad = "select * from planificacion_pedidos";
            MySqlCommand mcd = new MySqlCommand(scad, clsBdComun.ObtenerConexion());
            MySqlDataReader mdr = mcd.ExecuteReader();
            while (mdr.Read())
            {
                cbo_fecha.Items.Add(mdr.GetString("fec_planif"));
                
            }


        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            clsrutamaps ru = new clsrutamaps();
            MySqlCommand _comando = new MySqlCommand(String.Format(
                    "SELECT pk_codplanif FROM planificacion_pedidos where fec_planif ='{0}' ", cbo_fecha.Text), clsBdComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {

                ru.icodfec = _reader.GetInt16(0);
            }
            MessageBox.Show(Convert.ToString(ru.icodfec));
            int cod = ru.icodfec;

            dgv_buscac.DataSource = clsrutamapOp.Buscar(cod);
        }
        public clsmapa map1 { get; set; }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            if (dgv_buscac.SelectedRows.Count == 1)
            {
                int idped = Convert.ToInt32(dgv_buscac.CurrentRow.Cells[0].Value);
                int codemp = Convert.ToInt32(dgv_buscac.CurrentRow.Cells[6].Value);
                int codped= Convert.ToInt32(dgv_buscac.CurrentRow.Cells[1].Value);
               // MessageBox.Show(Convert.ToString(codcte));
                map1 = clsrutamapOp.ObtenerDato(idped,codemp,codped);
                MessageBox.Show(Convert.ToString(idped));
                //this.Close();
            }
            else
                MessageBox.Show("debe de seleccionar una fila");



            /*if (dgv_buscac.SelectedRows.Count == 1)
            {
                clsmapa map = new clsmapa();

                map.iplan1 = Convert.ToInt32(dgv_buscac.CurrentRow.Cells[0].Value);
                map.icodped= Convert.ToInt32(dgv_buscac.CurrentRow.Cells[1].Value);
                map.icodclte = Convert.ToInt32(dgv_buscac.CurrentRow.Cells[2].Value);
                map.saveclte = Convert.ToString(dgv_buscac.CurrentRow.Cells[3].Value);
                map.scalleclte = Convert.ToString(dgv_buscac.CurrentRow.Cells[4].Value);
                map.szonaclte = Convert.ToString(dgv_buscac.CurrentRow.Cells[5].Value);
                map.icodempl= Convert.ToInt32(dgv_buscac.CurrentRow.Cells[6].Value);

                

                map.sesta= Convert.ToString(dgv_buscac.CurrentRow.Cells[7].Value);

                //MessageBox.Show(Convert.ToString(map.icodclte));

                /*MySqlCommand _comando = new MySqlCommand(String.Format(
                    "SELECT  pnom_clte FROM pedidoclte where pk_pclte ='{0}' ", map.icodped), clsBdComun.ObtenerConexion());
                MySqlDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {

                    map.snomclte = _reader.GetString(0);
                }
                //  MessageBox.Show(Convert.ToString(map.snomclte));

                MySqlCommand _comando1 = new MySqlCommand(String.Format(
                  "SELECT  pnom_emp FROM empleado where pk_codemp ='{0}' ", map.icodempl), clsBdComun.ObtenerConexion());
                MySqlDataReader _reader1 = _comando1.ExecuteReader();
                while (_reader1.Read())
                {

                    map.snomempl = _reader1.GetString(0);
                }*/
            MessageBox.Show(Convert.ToString(map1.snomempl));

           // frmMapa mapview = new frmMapa();
           // mapview.ShowDialog();
            this.Close();
            //map1 = map;


            /*}
            else
                MessageBox.Show("debe de seleccionar una fila");*/
        }
    }
}
