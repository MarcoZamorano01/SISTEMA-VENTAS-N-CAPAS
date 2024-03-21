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
    public partial class TipoProdEditarVista : Form
    {
        int idx = 0;
        TIPOPROD p = new TIPOPROD();
        TipoProdBss bss = new TipoProdBss();
        public TipoProdEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void TipoProdEditarVista_Load(object sender, EventArgs e)//cargar
        {
            p = bss.ObtenerTipoProdIdBss(idx);
            textBox1.Text = p.Nombre;
        }

        private void button1_Click(object sender, EventArgs e)//guardar
        {
            p.Nombre = textBox1.Text;

            bss.EditarTipoProdBss(p);
            MessageBox.Show("Datos Actualizados");
        }
    }
}
