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

namespace SITEMAVENTAS.VISTA.ProveeVistas
{
    public partial class ProveeListarvista : Form
    {
        public ProveeListarvista()
        {
            InitializeComponent();
        }
        ProveeBss bss = new ProveeBss();

        private void ProveeListarvista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaProveeBss();
        }
    }
}
