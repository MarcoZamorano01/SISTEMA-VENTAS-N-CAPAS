using SISTEMASVENTAS.BSS;
using SITEMAVENTAS.VISTA.FORMULARIOSVISTAS;
using SITEMAVENTAS.VISTA.IngresoVistas;
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

namespace SITEMAVENTAS.VISTA.INGRESOSACTVISTAS
{
    public partial class IngresosActualesVistas : Form
    {
        public IngresosActualesVistas()
        {
            InitializeComponent();
        }
        IngresoBss bss = new IngresoBss();
        private void IngresosActualesVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaIngresoBss();
        }

        private void button3_Click(object sender, EventArgs e)//EDITAR
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            RegistrarIngresoEditadoVista fr = new RegistrarIngresoEditadoVista(IdSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaIngresoBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)//AGREGAR
        {
            RegistrarIngresoActualVista fr = new RegistrarIngresoActualVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaIngresoBss();
            }
        }

        private void button1_Click(object sender, EventArgs e)//ELIMINAR
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar este Ingreso?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarIngresoBss(IdSeleccionada);
                dataGridView1.DataSource = bss.ListaIngresoBss();
            }
        }

        private void button2_Click(object sender, EventArgs e)//CANCELAR
        {
            this.Hide();
            PlataformaPersonalVistas PERSONAL = new PlataformaPersonalVistas();
            PERSONAL.Show();
        }
    }
}
