using SISTEMASVENTAS.BSS;
using SITEMAVENTAS.VISTA.ClienteVistas;
using SITEMAVENTAS.VISTA.UsuarioVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SITEMAVENTAS.VISTA.DetalleVenVistas
{
    public partial class DetalleVenListarvista : Form
    {
        public DetalleVenListarvista()
        {
            InitializeComponent();
        }
        DetalleVenBss bss = new DetalleVenBss();

        private void DetalleVenListarvista_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = bss.ListaDetalleVenBss();
            //nueva
            dataGridView1.DataSource = bss.NuevaListaDetalleVenBss();
        }

        private void button2_Click(object sender, EventArgs e)//agregar
        {
            DetalleVenInsertarVistas fr = new DetalleVenInsertarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaDetalleVenBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)//editar
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleVenEditarVista fr = new DetalleVenEditarVista(IdSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaDetalleVenBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)//eliminar
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar este Detalle de Venta?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarDetalleVenBss(IdSeleccionada);
                dataGridView1.DataSource = bss.ListaDetalleVenBss();
            }
        }

        private void button1_Click(object sender, EventArgs e)//seleccionar
        {
            //especificar ruta
            
        }
    }
}
