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

namespace SITEMAVENTAS.VISTA.TipoProdVistas
{
    public partial class TipoProdListarvista : Form
    {
        public TipoProdListarvista()
        {
            InitializeComponent();
        }
        TipoProdBss bss = new TipoProdBss();

        private void TipoProdListarvista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaTipoProdBss();
        }
    }
}
