using SISTEMASVENTAS.BSS;
using SITEMAVENTAS.VISTA.FORMULARIOSVISTAS;
using SITEMAVENTAS.VISTA.PLATAFORMAVISTAS;
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

namespace SITEMAVENTAS.VISTA.LISTASVISTAS
{
    public partial class UsuariosListarVista : Form
    {
        public UsuariosListarVista()
        {
            InitializeComponent();
        }
        UsuarioBss bss = new UsuarioBss();
        private void UsuariosListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaUsuarioBss();
        }

        private void button3_Click(object sender, EventArgs e)//EDITAR
        {
            int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            RegistroUserEditadoVistas fr = new RegistroUserEditadoVistas(IdPersonaSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaUsuarioBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)//AGREGAR
        {
            RegistroUserVistas fr = new RegistroUserVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaUsuarioBss();
            }
        }

        private void button1_Click(object sender, EventArgs e)//ELIMINAR
        {
            int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar esta Usuario?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarUsuarioBss(IdPersonaSeleccionada);
                dataGridView1.DataSource = bss.ListaUsuarioBss();
            }
        }

        private void button2_Click(object sender, EventArgs e)//SELECCIONAR
        {
            FORMULARIOSVISTAS.RegistrarVentaVista.IdVendedorSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            FORMULARIOSVISTAS.RegistrarVentaEditarVista.IdVendedorSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlataformaPersonalVistas PERSONAL = new PlataformaPersonalVistas();
            PERSONAL.Show();
        }
    }
}
