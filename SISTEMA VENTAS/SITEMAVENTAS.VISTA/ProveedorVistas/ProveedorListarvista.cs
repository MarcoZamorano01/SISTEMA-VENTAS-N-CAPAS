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

namespace SITEMAVENTAS.VISTA.ProveedorVistas
{
    public partial class ProveedorListarvista : Form
    {
        public ProveedorListarvista()
        {
            InitializeComponent();
        }
        ProveedorBss bss = new ProveedorBss();

        private void ProveedorListarvista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaProveedorBss();
        }
    }
}
