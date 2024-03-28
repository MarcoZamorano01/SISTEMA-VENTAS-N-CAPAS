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

namespace SITEMAVENTAS.VISTA.VENTASREALIVISTAS
{
    public partial class VentasRealizadasVistas : Form
    {
        public VentasRealizadasVistas()
        {
            InitializeComponent();
        }
        VentaBss bss = new VentaBss();
        private void VentasRealizadasVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaVentaBss();
        }

        private void button3_Click(object sender, EventArgs e)//eliminar
        {
            //DetalleVenBss bssdetalle = new DetalleVenBss();
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar esta Venta?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarVentaBss(IdSeleccionada);
                //bssdetalle.EliminarDetalleVenBss(IdSeleccionada);
                dataGridView1.DataSource = bss.ListaVentaBss();
            }
        }

        private void button2_Click(object sender, EventArgs e)//editar
        {

        }

        private void button1_Click(object sender, EventArgs e)//agregar
        {

        }
    }
}
