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

namespace SITEMAVENTAS.VISTA.DetallelngVistas
{
    public partial class DetallelngListarvista : Form
    {
        public DetallelngListarvista()
        {
            InitializeComponent();
        }
        DetallelngBss bss = new DetallelngBss();

        private void DetallelngListarvista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaDetallelngBss();
        }
    }
}
