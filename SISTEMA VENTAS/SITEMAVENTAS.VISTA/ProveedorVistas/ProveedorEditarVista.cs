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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SITEMAVENTAS.VISTA.ProveedorVistas
{
    public partial class ProveedorEditarVista : Form
    {
        int idx = 0;
        PROVEEDOR p = new PROVEEDOR();
        ProveedorBss bss = new ProveedorBss();
        public ProveedorEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void ProveedorEditarVista_Load(object sender, EventArgs e)//cargar
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
    }
}
