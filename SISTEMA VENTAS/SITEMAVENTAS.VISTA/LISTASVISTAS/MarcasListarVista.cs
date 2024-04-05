using SISTEMASVENTAS.BSS;
using SITEMAVENTAS.VISTA.FORMULARIOSVISTAS;
using SITEMAVENTAS.VISTA.MarcaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SITEMAVENTAS.VISTA.LISTASVISTAS
{
    public partial class MarcasListarVista : Form
    {
        public MarcasListarVista()
        {
            InitializeComponent();
        }
        MarcaBss bss = new MarcaBss();
        private void MarcasListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.NuevaListaMarcaBss();
        }

        private void button3_Click(object sender, EventArgs e)//editar
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            RegistrarMarcaEditadoVistas fr = new RegistrarMarcaEditadoVistas(IdSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaMarcaBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)//agregar
        {
            RegistrarMarcaVista fr = new RegistrarMarcaVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaMarcaBss();
            }
        }

        private void button2_Click(object sender, EventArgs e)//eliminar
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar este Marca?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarMarcaBss(IdSeleccionada);
                dataGridView1.DataSource = bss.ListaMarcaBss();
            }
        }

        private void button1_Click(object sender, EventArgs e)//seleccionar
        {
            FORMULARIOSVISTAS.RegistrarProductoVista.IdMarcaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
