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

namespace SITEMAVENTAS.VISTA.TipoProdVistas
{
    public partial class TipoProdListarvista : Form
    {
        public TipoProdListarvista()
        {
            InitializeComponent();
        }
        TipoProdBss bss = new TipoProdBss();

        private void TipoProdListarvista_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = bss.ListaTipoProdBss();
            //nueva
            dataGridView1.DataSource = bss.NuevaListaTipoProdBss();
        }

        private void button2_Click(object sender, EventArgs e)//agregar
        {
            TipoProdInsertarVista fr = new TipoProdInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaTipoProdBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)//editar
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            TipoProdEditarVista fr = new TipoProdEditarVista(IdSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaTipoProdBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)//eliminar
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar este TipoProd?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarTipoProdBss(IdSeleccionada);
                dataGridView1.DataSource = bss.ListaTipoProdBss();
            }
        }

        private void button1_Click(object sender, EventArgs e)//seleccionar
        {
            ProductoVistas.ProductoInsertarVista.IdTipoProdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProductoVistas.ProductoEditarVista.IdTipoProdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
