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

namespace SITEMAVENTAS.VISTA.MarcaVistas
{
    public partial class MarcaListarvista : Form
    {
        public MarcaListarvista()
        {
            InitializeComponent();
        }
        MarcaBss bss = new MarcaBss();

        private void MarcaListarvista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaMarcaBss();
        }
    }
}
