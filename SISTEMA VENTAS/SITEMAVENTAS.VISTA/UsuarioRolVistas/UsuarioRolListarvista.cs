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

namespace SITEMAVENTAS.VISTA.UsuarioRolVistas
{
    public partial class UsuarioRolListarvista : Form
    {
        public UsuarioRolListarvista()
        {
            InitializeComponent();
        }
        UsuarioRolBss bss = new UsuarioRolBss();

        private void UsuarioRolListarvista_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = bss.ListaUsuarioRolBss();
            //nueva
            dataGridView1.DataSource = bss.NuevaListaUsuarioRolBss();
        }

        private void button2_Click(object sender, EventArgs e)//agregar
        {
            UsuarioRolInsertarVista fr = new UsuarioRolInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaUsuarioRolBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)//editar
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            UsuarioRolEditarVista fr = new UsuarioRolEditarVista(IdSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaUsuarioRolBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)//eliminar
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar este UsuarioRol?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarUsuarioRolBss(IdSeleccionada);
                dataGridView1.DataSource = bss.ListaUsuarioRolBss();
            }
        }

        private void button1_Click(object sender, EventArgs e)//seleccionar
        {
            //escribir una ruta
        }
    }
}
