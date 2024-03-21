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

namespace SITEMAVENTAS.VISTA.ProveeVistas
{
    public partial class ProveeListarvista : Form
    {
        public ProveeListarvista()
        {
            InitializeComponent();
        }
        ProveeBss bss = new ProveeBss();

        private void ProveeListarvista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaProveeBss();
        }

        private void button2_Click(object sender, EventArgs e)//agregar
        {
            ProveeInsertarVista fr = new ProveeInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaProveeBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)//editar
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProveeEditarVista fr = new ProveeEditarVista(IdSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaProveeBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)//eliminar
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar este Provee?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarProveeBss(IdSeleccionada);
                dataGridView1.DataSource = bss.ListaProveeBss();
            }
        }

        private void button1_Click(object sender, EventArgs e)//seleccionar
        {
            //especificar ruta
        }
    }
}
