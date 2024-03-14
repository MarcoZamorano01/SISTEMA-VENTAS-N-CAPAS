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

namespace SITEMAVENTAS.VISTA.DetalleVenVistas
{
    public partial class DetalleVenListarvista : Form
    {
        public DetalleVenListarvista()
        {
            InitializeComponent();
        }
        DetalleVenBss bss = new DetalleVenBss();

        private void DetalleVenListarvista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaDetalleVenBss();
        }
    }
}
