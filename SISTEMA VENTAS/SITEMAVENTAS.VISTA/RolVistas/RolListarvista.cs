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

namespace SITEMAVENTAS.VISTA.RolVistas
{
    public partial class RolListarvista : Form
    {
        public RolListarvista()
        {
            InitializeComponent();
        }
        RolBss bss = new RolBss();

        private void RolListarvista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaRolBss();
        }

        private void button2_Click(object sender, EventArgs e)//agregar
        {
            RolInsertarVista fr = new RolInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaRolBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)//editar
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            RolEditarVista fr = new RolEditarVista(IdSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaRolBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)//eliminar
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar este Rol?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarRolBss(IdSeleccionada);
                dataGridView1.DataSource = bss.ListaRolBss();
            }
        }

        private void button1_Click(object sender, EventArgs e)//seleccionar
        {
            UsuarioRolVistas.UsuarioRolInsertarVista.IdRolSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            UsuarioRolVistas.UsuarioRolEditarVista.IdRolSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
