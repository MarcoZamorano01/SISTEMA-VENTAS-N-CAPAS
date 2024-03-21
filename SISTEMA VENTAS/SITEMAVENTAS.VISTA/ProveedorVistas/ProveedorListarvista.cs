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

namespace SITEMAVENTAS.VISTA.ProveedorVistas
{
    public partial class ProveedorListarvista : Form
    {
        public ProveedorListarvista()
        {
            InitializeComponent();
        }
        ProveedorBss bss = new ProveedorBss();

        private void ProveedorListarvista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaProveedorBss();
        }

        private void button2_Click(object sender, EventArgs e)//agregar
        {
            ProveedorInsertarVista fr = new ProveedorInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaProveedorBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)//editar
        {
            int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProveedorEditarVista fr = new ProveedorEditarVista(IdPersonaSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaProveedorBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)//eliminar
        {
            int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar este Proveedor?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarProveedorBss(IdPersonaSeleccionada);
                dataGridView1.DataSource = bss.ListaProveedorBss();
            }
        }

        private void button1_Click(object sender, EventArgs e)//seleccionar
        {
            IngresoVistas.IngresoInsertarVista.IdProveedorSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProveeVistas.ProveeInsertarVista.IdProveedorSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            IngresoVistas.IngresoEditarVista.IdProveedorSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProveeVistas.ProveeEditarVista.IdProveedorSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
