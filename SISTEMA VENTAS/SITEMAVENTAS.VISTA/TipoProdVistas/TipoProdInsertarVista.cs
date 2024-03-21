using SISTEMASVENTAS.BSS;
using SISTEMAVENTAS.MODELOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SITEMAVENTAS.VISTA.TipoProdVistas
{
    public partial class TipoProdInsertarVista : Form
    {
        public TipoProdInsertarVista()
        {
            InitializeComponent();
        }
        TipoProdBss bss = new TipoProdBss();

        private void button1_Click(object sender, EventArgs e)
        {
            TIPOPROD p = new TIPOPROD();
            p.Nombre = textBox1.Text;

            bss.InsertarTipoProdBss(p);
            MessageBox.Show("Se guardó correctamente a TipoProd");
        }
    }
}
