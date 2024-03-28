using SISTEMASVENTAS.BSS;
using SISTEMAVENTAS.MODELOS;
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
    public partial class RegistrarProveedorVistas : Form
    {
        public RegistrarProveedorVistas()
        {
            InitializeComponent();
        }
        ProveedorBss bss = new ProveedorBss();
        private void button2_Click(object sender, EventArgs e)//cancelar
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)//guardar
        {
            PROVEEDOR p = new PROVEEDOR();
            p.Nombre = textBox1.Text;
            p.Telefono = textBox2.Text;
            p.Direccion = textBox3.Text;
            bss.InsertarProveedorBss(p);
            MessageBox.Show("Se guardó correctamente a Proveedor");
        }
    }
}
