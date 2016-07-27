using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form_modificar_pedido : Form
    {
        public Form_modificar_pedido()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Btn_registro_pedido_Click(object sender, EventArgs e)
        {
            Form_registro_pedido forma1 = new Form_registro_pedido();
            forma1.ShowDialog();
        }

        private void Btn_modificar_pedido_Click(object sender, EventArgs e)
        {
            Form_modificar_pedido forma1 = new Form_modificar_pedido();
            forma1.ShowDialog();
        }
    }
}
