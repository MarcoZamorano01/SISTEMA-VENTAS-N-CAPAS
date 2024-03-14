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

namespace SITEMAVENTAS.VISTA.IngresoVistas
{
    public partial class IngresoListarvista : Form
    {
        public IngresoListarvista()
        {
            InitializeComponent();
        }
        IngresoBss bss = new IngresoBss();

        private void IngresoListarvista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaIngresoBss();
        }
    }
}
