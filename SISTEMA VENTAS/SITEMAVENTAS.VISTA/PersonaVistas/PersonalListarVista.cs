using SISTEMASVENTAS.BSS;
using SITEMAVENTAS.VISTA.ClienteVistas;
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

namespace SITEMAVENTAS.VISTA.NewFolder
{
    public partial class PersonalListarVista : Form
    {
        public PersonalListarVista()
        {
            InitializeComponent();
        }
        PersonaBss bss = new PersonaBss();

        private void PersonalListarVista_Load(object sender, EventArgs e)//listar al salir la ventana
        {
            //dataGridView1.DataSource = bss.ListaPersonaBss();
            //nueva
            dataGridView1.DataSource = bss.NuevaListaPersonaBss();
        }

        private void button1_Click(object sender, EventArgs e)//seleccionar
        {
            UsuarioInsertarVista.IdPersonaSelecionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ClienteInsertarVista.IdPersonaSelecionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button2_Click(object sender, EventArgs e)//agregar
        {
            PersonaInsertarVista fr = new PersonaInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaPersonaBss();

            }
        }

        private void button3_Click(object sender, EventArgs e)//editar
        {
            int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            PersonaEditarVista fr = new PersonaEditarVista(IdPersonaSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaPersonaBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)//eliminar
        {
            int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult reslut = MessageBox.Show("Esta seguro de eliminar esta persona?", "ELIMINANDO", MessageBoxButtons.YesNo);
            if (reslut == DialogResult.Yes)
            {
                bss.EliminarPersonaBss(IdPersonaSeleccionada);
                dataGridView1.DataSource = bss.ListaPersonaBss();
            }
        }
    }
}
