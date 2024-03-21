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

namespace SITEMAVENTAS.VISTA.DetallelngVistas
{
    public partial class DetallelngListarvista : Form
    {
        public DetallelngListarvista()
        {
            InitializeComponent();
        }
        DetallelngBss bss = new DetallelngBss();

        private void DetallelngListarvista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaDetallelngBss();
        }

        private void button1_Click(object sender, EventArgs e) //seleccionar
        {
            //especificar destino
            
        }

        private void button2_Click(object sender, EventArgs e) //agregar
        {
            DetalleIngInsertarVista fr = new DetalleIngInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaDetallelngBss();
            }
        }

        private void button3_Click(object sender, EventArgs e) //editar
        {
            int IdDetelleIngSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleIngEditarVista fr = new DetalleIngEditarVista(IdDetelleIngSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaDetallelngBss();
            }
        }

        private void button4_Click(object sender, EventArgs e) //eliminar
        {
            int IdDetelleIngSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult reslut = MessageBox.Show("Esta seguro de eliminar este Detalle de Ingreso?", "ELIMINANDO", MessageBoxButtons.YesNo);
            if (reslut == DialogResult.Yes)
            {
                bss.EliminarDetalleIngBss(IdDetelleIngSeleccionada);
                dataGridView1.DataSource = bss.ListaDetallelngBss();
            }
        }
    }
}
