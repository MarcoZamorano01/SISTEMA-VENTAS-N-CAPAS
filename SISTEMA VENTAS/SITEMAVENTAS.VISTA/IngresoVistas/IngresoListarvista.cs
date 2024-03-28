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

namespace SITEMAVENTAS.VISTA.IngresoVistas
{
    public partial class IngresoListarvista : Form
    {
        public IngresoListarvista()
        {
            InitializeComponent();
        }
        IngresoBss bss = new IngresoBss();

        private void IngresoListarvista_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = bss.ListaIngresoBss();
            //nueva
            dataGridView1.DataSource = bss.NuevaListaIngresoBss();
        }

        private void button2_Click(object sender, EventArgs e)//agregar
        {
            IngresoInsertarVista fr = new IngresoInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaIngresoBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)//editar
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            IngresoEditarVista fr = new IngresoEditarVista(IdSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaIngresoBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)//eliminar
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar este Ingreso?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarIngresoBss(IdSeleccionada);
                dataGridView1.DataSource = bss.ListaIngresoBss();
            }
        }

        private void button1_Click(object sender, EventArgs e)//seleccionar
        {
            DetallelngVistas.DetalleIngInsertarVista.IdIngresoSelecionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetallelngVistas.DetalleIngEditarVista.IdIngresoSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

        }
    }
}
