using SISTEMASVENTAS.BSS;
using SITEMAVENTAS.VISTA.FORMULARIOSVISTAS;
using SITEMAVENTAS.VISTA.ProveedorVistas;
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
    public partial class ProveedoresListarVista : Form
    {
        public ProveedoresListarVista()
        {
            InitializeComponent();
        }
        ProveedorBss bss = new ProveedorBss();

        private void ProveedoresListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaProveedorBss();
        }

        private void button3_Click(object sender, EventArgs e)//editar
        {
            int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            RegistrarProveedorEditadoVista fr = new RegistrarProveedorEditadoVista(IdPersonaSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaProveedorBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)//agregar
        {
            RegistrarProveedorVistas fr = new RegistrarProveedorVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaProveedorBss();
            }
        }

        private void button1_Click(object sender, EventArgs e)//eliminar
        {
            int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar este Proveedor?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarProveedorBss(IdPersonaSeleccionada);
                dataGridView1.DataSource = bss.ListaProveedorBss();
            }
        }

        private void button2_Click(object sender, EventArgs e)//seleccionar
        {
            FORMULARIOSVISTAS.RegistrarIngresoActualVista.IdProveedorSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            FORMULARIOSVISTAS.RegistrarIngresoEditadoVista.IdProveedorSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
