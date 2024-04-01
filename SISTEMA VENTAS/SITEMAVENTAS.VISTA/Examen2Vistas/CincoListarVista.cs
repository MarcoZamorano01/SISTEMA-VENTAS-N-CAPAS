using SISTEMASVENTAS.BSS.EXAMEN2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SITEMAVENTAS.VISTA.Examen2Vistas
{
    public partial class CincoListarVista : Form
    {
        public CincoListarVista()
        {
            InitializeComponent();
        }
        Examen2Bss bss = new Examen2Bss();
        private void CincoListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarCincoBss();
        }
    }
}
