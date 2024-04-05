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
    public partial class MarcasUsuariosListarVista : Form
    {
        public MarcasUsuariosListarVista()
        {
            InitializeComponent();
        }
        MarcaBss bss = new MarcaBss();
        private void MarcasUsuariosListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaMarcaBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BIENVENIDA intro = new BIENVENIDA();
            intro.Show();
        }
    }
}
