using SISTEMASVENTAS.BSS;
using SISTEMAVENTAS.MODELOS;
using SITEMAVENTAS.VISTA.PLATAFORMAVISTAS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SITEMAVENTAS.VISTA.FORMULARIOSVISTAS
{
    public partial class RegistrarProveedorEditadoVista : Form
    {
        int idx = 0;
        PROVEEDOR p = new PROVEEDOR();
        ProveedorBss bss = new ProveedorBss();
        public RegistrarProveedorEditadoVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void RegistrarProveedorEditadoVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerProveedorIdBss(idx);
            textBox1.Text = p.Nombre;
            textBox2.Text = p.Telefono;
            textBox3.Text = p.Direccion;
        }

        private void button1_Click(object sender, EventArgs e)//guardar
        {
            p.Nombre = textBox1.Text;
            p.Telefono = textBox2.Text;
            p.Direccion = textBox3.Text;

            bss.EditarProveedorBss(p);
            MessageBox.Show("Datos Actualizados");
        }

        private void button2_Click(object sender, EventArgs e)//cancelar
        {
            this.Hide();
            BIENVENIDA HOLA = new BIENVENIDA();
            HOLA.Show();
        }
    }
}
