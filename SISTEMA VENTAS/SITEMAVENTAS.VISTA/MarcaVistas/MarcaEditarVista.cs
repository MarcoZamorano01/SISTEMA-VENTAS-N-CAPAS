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

namespace SITEMAVENTAS.VISTA.MarcaVistas
{
    public partial class MarcaEditarVista : Form
    {
        int idx = 0;
        MARCA p = new MARCA();
        MarcaBss bss = new MarcaBss();
        public MarcaEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void MarcaEditarVista_Load(object sender, EventArgs e)//carga
        {
            p = bss.ObtenerMarcaIdBss(idx);
            textBox1.Text = p.Nombre;
        }

        private void button1_Click(object sender, EventArgs e)//guardar
        {
            p.Nombre = textBox1.Text;

            bss.EditarMarcaBss(p);
            MessageBox.Show("Datos Actualizados");
        }
    }
}
