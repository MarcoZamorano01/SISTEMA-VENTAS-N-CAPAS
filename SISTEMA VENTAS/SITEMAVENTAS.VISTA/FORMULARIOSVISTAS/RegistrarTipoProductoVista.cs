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
    public partial class RegistrarTipoProductoVista : Form
    {
        public RegistrarTipoProductoVista()
        {
            InitializeComponent();
        }
        TipoProdBss bss = new TipoProdBss();
        private void RegistrarTipoProductoVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaTipoProdBss();
        }

        private void button1_Click(object sender, EventArgs e)//GUARDAR
        {
            TIPOPROD p = new TIPOPROD();
            p.Nombre = textBox1.Text;

            bss.InsertarTipoProdBss(p);
            MessageBox.Show("Se guardó correctamente a TipoProd");
        }

        private void button2_Click(object sender, EventArgs e)//CANCELAR
        {
            this.Hide();
            PlataformaPersonalVistas PERSONAL = new PlataformaPersonalVistas();
            PERSONAL.Show();
        }
    }
}
