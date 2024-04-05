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
    public partial class RegistrarMarcaVista : Form
    {
        public RegistrarMarcaVista()
        {
            InitializeComponent();
        }
        MarcaBss bss = new MarcaBss();
        private void RegistrarMarcaVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaMarcaBss();
        }

        private void button1_Click(object sender, EventArgs e)//GUARDAR
        {
            MARCA p = new MARCA();
            p.Nombre = textBox1.Text;
            bss.InsertarMarcaBss(p);
            MessageBox.Show("Se guardó correctamente a Marca");
        }

        private void button2_Click(object sender, EventArgs e)//CANCELAR
        {
            this.Hide();
            PlataformaPersonalVistas PERSONAL = new PlataformaPersonalVistas();
            PERSONAL.Show();
        }
    }
}
