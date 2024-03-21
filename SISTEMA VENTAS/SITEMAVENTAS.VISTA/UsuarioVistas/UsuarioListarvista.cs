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

namespace SITEMAVENTAS.VISTA.UsuarioVistas
{
    public partial class UsuarioListarvista : Form
    {
        public UsuarioListarvista()
        {
            InitializeComponent();
        }
        UsuarioBss bss = new UsuarioBss();

        private void UsuarioListarvista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaUsuarioBss();
        }

        private void button2_Click(object sender, EventArgs e)//agregar
        {
            UsuarioInsertarVista fr = new UsuarioInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaUsuarioBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)//editar
        {
            int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            UsuarioEditarVista fr = new UsuarioEditarVista(IdPersonaSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaUsuarioBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)//eliminar
        {
            int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar esta Usuario?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarUsuarioBss(IdPersonaSeleccionada);
                dataGridView1.DataSource = bss.ListaUsuarioBss();
            }
        }

        private void button1_Click(object sender, EventArgs e)//seleccionar
        {
            UsuarioRolVistas.UsuarioRolInsertarVista.IdUsuarioSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            VentaVistas.VentaInsertarVista.IdVendedorSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            UsuarioRolVistas.UsuarioRolEditarVista.IdUsuarioSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            VentaVistas.VentaEditarVista.IdVendedorSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
