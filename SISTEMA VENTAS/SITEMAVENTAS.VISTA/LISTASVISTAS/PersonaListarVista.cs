using SISTEMASVENTAS.BSS;
using SITEMAVENTAS.VISTA.ClienteVistas;
using SITEMAVENTAS.VISTA.FORMULARIOSVISTAS;
using SITEMAVENTAS.VISTA.PersonaVistas;
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
    public partial class PersonaListarVista : Form
    {
        public PersonaListarVista()
        {
            InitializeComponent();
        }
        PersonaBss bss = new PersonaBss();
        private void PersonaListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaPersonaBss();
        }

        private void button3_Click(object sender, EventArgs e)//editar
        {
            int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            RegistrarseEditadoVistas fr = new RegistrarseEditadoVistas(IdPersonaSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaPersonaBss();
            }
        }

        private void button1_Click(object sender, EventArgs e)//agregar
        {
            RegistrarseVistas fr = new RegistrarseVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaPersonaBss();

            }
        }

        private void button2_Click(object sender, EventArgs e)//eliminar
        {
            int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult reslut = MessageBox.Show("Esta seguro de eliminar esta persona?", "ELIMINANDO", MessageBoxButtons.YesNo);
            if (reslut == DialogResult.Yes)
            {
                bss.EliminarPersonaBss(IdPersonaSeleccionada);
                dataGridView1.DataSource = bss.ListaPersonaBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)//seleccionar
        {
            FORMULARIOSVISTAS.RegistroUserVistas.IdPersonaSelecionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            FORMULARIOSVISTAS.RegistroUserEditadoVistas.IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            FORMULARIOSVISTAS.RegistrarClienteEditadoVista.IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            FORMULARIOSVISTAS.RegistrarClienteVista.IdPersonaSelecionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
