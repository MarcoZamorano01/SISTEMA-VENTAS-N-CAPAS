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

namespace SITEMAVENTAS.VISTA.MarcaVistas
{
    public partial class MarcaListarvista : Form
    {
        public MarcaListarvista()
        {
            InitializeComponent();
        }
        MarcaBss bss = new MarcaBss();

        private void MarcaListarvista_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = bss.ListaMarcaBss();
            //nueva
            dataGridView1.DataSource = bss.NuevaListaMarcaBss();
        }

        private void button2_Click(object sender, EventArgs e)//agregar
        {
            MarcaInsertarVista fr = new MarcaInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaMarcaBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)//editar
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            MarcaEditarVista fr = new MarcaEditarVista(IdSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaMarcaBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)//eliminar
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
            ProductoVistas.ProductoInsertarVista.IdMarcaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProductoVistas.ProductoEditarVista.IdMarcaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
