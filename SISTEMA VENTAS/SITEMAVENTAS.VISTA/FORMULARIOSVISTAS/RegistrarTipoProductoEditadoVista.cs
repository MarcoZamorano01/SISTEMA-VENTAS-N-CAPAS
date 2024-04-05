using SISTEMASVENTAS.BSS;
using SISTEMAVENTAS.MODELOS;
using SITEMAVENTAS.VISTA.PLATAFORMAVISTAS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SITEMAVENTAS.VISTA.FORMULARIOSVISTAS
{
    public partial class RegistrarTipoProductoEditadoVista : Form
    {
        int idx = 0;
        TIPOPROD p = new TIPOPROD();
        TipoProdBss bss = new TipoProdBss();
        public RegistrarTipoProductoEditadoVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void RegistrarTipoProductoEditadoVista_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)//cancelar
        {
            this.Hide();
            BIENVENIDA HOLA = new BIENVENIDA();
            HOLA.Show();
        }
    }
}
