using SISTEMASVENTAS.BSS;
using SITEMAVENTAS.VISTA.PLATAFORMAVISTAS;
using SITEMAVENTAS.VISTA.VENTAPRODVISTAS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SITEMAVENTAS.VISTA.LISTASVISTAS
{
    public partial class TiposProductosUsuariosListarVista : Form
    {
        public TiposProductosUsuariosListarVista()
        {
            InitializeComponent();
        }
        TipoProdBss bss = new TipoProdBss();

        private void TiposProductosUsuariosListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaTipoProdBss();
        }

        private void button1_Click(object sender, EventArgs e)//cancelar
        {
            this.Hide();
            BIENVENIDA intro = new BIENVENIDA();
            intro.Show();
        }

        private void button2_Click(object sender, EventArgs e)//comprar
        {
            this.Hide();
            VentaProductoVista VentaProducto = new VentaProductoVista();
            VentaProducto.Show();
        }
    }
}
