using SISTEMASVENTAS.BSS;
using SITEMAVENTAS.VISTA.PLATAFORMAVISTAS;
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
    public partial class ProveedoresContactosListarVista : Form
    {
        public ProveedoresContactosListarVista()
        {
            InitializeComponent();
        }
        ProveedorBss bss = new ProveedorBss();
        private void ProveedoresContactosListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaProveedorContactoBss();
        }

        private void button1_Click(object sender, EventArgs e)//volver
        {
            this.Hide();
            BIENVENIDA intro = new BIENVENIDA();
            intro.Show();
        }
    }
}
