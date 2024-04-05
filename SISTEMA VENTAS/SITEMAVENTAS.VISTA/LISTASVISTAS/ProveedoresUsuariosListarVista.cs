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
    public partial class ProveedoresUsuariosListarVista : Form
    {
        public ProveedoresUsuariosListarVista()
        {
            InitializeComponent();
        }
        ProveedorBss bss = new ProveedorBss();

        private void button1_Click(object sender, EventArgs e)//CANCELAR
        {
            this.Hide();
            BIENVENIDA intro = new BIENVENIDA();
            intro.Show();
        }

        private void ProveedoresUsuariosListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaProveedorBss();
        }

        private void button2_Click(object sender, EventArgs e)//contacto
        {
            this.Hide();
            ProveedoresContactosListarVista contacto = new ProveedoresContactosListarVista();
            contacto.Show();
        }
    }
}
