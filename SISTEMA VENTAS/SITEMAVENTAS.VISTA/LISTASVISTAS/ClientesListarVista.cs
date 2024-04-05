using SISTEMASVENTAS.BSS;
using SITEMAVENTAS.VISTA.ClienteVistas;
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
    public partial class ClientesListarVista : Form
    {
        public ClientesListarVista()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        private void ClientesListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaClienteBss();
        }

        private void button1_Click(object sender, EventArgs e)//agregar
        {
            ClienteInsertarVista fr = new ClienteInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaClienteBss();
            }
        }

        private void button2_Click(object sender, EventArgs e)//editar
        {
            int IdClienteSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ClienteEditarVista fr = new ClienteEditarVista(IdClienteSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaClienteBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)//eliminar
        {
            int IdClienteSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult reslut = MessageBox.Show("Esta seguro de eliminar este Cliente?", "ELIMINANDO", MessageBoxButtons.YesNo);
            if (reslut == DialogResult.Yes)
            {
                bss.EliminarClienteBss(IdClienteSeleccionada);
                dataGridView1.DataSource = bss.ListaClienteBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)//seleccionar
        {
            VentaVistas.VentaInsertarVista.IdClienteSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            VentaVistas.VentaEditarVista.IdClienteSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            FORMULARIOSVISTAS.RegistrarVentaVista.IdClienteSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            FORMULARIOSVISTAS.RegistrarVentaEditarVista.IdClienteSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
