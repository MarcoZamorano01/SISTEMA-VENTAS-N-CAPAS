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

namespace SITEMAVENTAS.VISTA.ProductoVistas
{
    public partial class ProductoListarvista : Form
    {
        public ProductoListarvista()
        {
            InitializeComponent();
        }
        ProductoBss bss = new ProductoBss();

        private void ProductoListarvista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaProductoBss();
        }

        private void button2_Click(object sender, EventArgs e)//agregar
        {
            ProductoInsertarVista fr = new ProductoInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaProductoBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)//editar
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProductoEditarVista fr = new ProductoEditarVista(IdSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaProductoBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)//eliminar
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar esta Producto?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarProductoBss(IdSeleccionada);
                dataGridView1.DataSource = bss.ListaProductoBss();
            }
        }

        private void button1_Click(object sender, EventArgs e)//seleccionar
        {
            DetalleVenVistas.DetalleVenInsertarVistas.IdProductoSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetallelngVistas.DetalleIngInsertarVista.IdProductoSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProveeVistas.ProveeInsertarVista.IdProductoSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleVenVistas.DetalleVenEditarVista.IdProductoSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetallelngVistas.DetalleIngEditarVista.IdProductoSelecionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProveeVistas.ProveeEditarVista.IdProductoSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
