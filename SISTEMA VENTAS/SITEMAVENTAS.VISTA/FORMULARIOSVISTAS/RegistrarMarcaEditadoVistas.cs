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
    public partial class RegistrarMarcaEditadoVistas : Form
    {
        int idx = 0;
        MARCA p = new MARCA();
        MarcaBss bss = new MarcaBss();
        public RegistrarMarcaEditadoVistas(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void RegistrarMarcaEditadoVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaMarcaBss();
            p = bss.ObtenerMarcaIdBss(idx);
            textBox1.Text = p.Nombre;
        }

        private void button1_Click(object sender, EventArgs e)//GUARDAR
        {
            p.Nombre = textBox1.Text;

            bss.EditarMarcaBss(p);
            MessageBox.Show("Datos Actualizados");
        }

        private void button2_Click(object sender, EventArgs e)//CANCELAR
        {
            this.Hide();
            BIENVENIDA intro = new BIENVENIDA();
            intro.Show();
        }
    }
}
