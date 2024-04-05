using SISTEMASVENTAS.BSS;
using SITEMAVENTAS.VISTA.FORMULARIOSVISTAS;
using SITEMAVENTAS.VISTA.LISTASVISTAS;
using SITEMAVENTAS.VISTA.PLATAFORMAVISTAS;
using SITEMAVENTAS.VISTA.VentaVistas;
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
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar esta Venta?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarVentaBss(IdSeleccionada);
                dataGridView1.DataSource = bss.ListaVentaBss();
            }
        }

        private void button2_Click(object sender, EventArgs e)//editar
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            RegistrarVentaEditarVista fr = new RegistrarVentaEditarVista(IdSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaVentaBss();
            }
        }

        private void button1_Click(object sender, EventArgs e)//agregar
        {
            RegistrarVentaVista fr = new RegistrarVentaVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaVentaBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)//cancelar
        {
            this.Hide();
            PlataformaPersonalVistas PERSONAL = new PlataformaPersonalVistas();
            PERSONAL.Show();
        }
    }
}
