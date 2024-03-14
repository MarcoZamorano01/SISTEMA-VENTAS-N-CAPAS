using SISTEMASVENTAS.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SITEMAVENTAS.VISTA.VentaVistas
{
    public partial class VentaListarvista : Form
    {
        public VentaListarvista()
        {
            InitializeComponent();
        }
        VentaBss bss = new VentaBss();

        private void VentaListarvista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaVentaBss();
        }
    }
}
