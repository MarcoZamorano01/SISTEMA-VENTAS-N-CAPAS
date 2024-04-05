using SISTEMASVENTAS.BSS;
using SISTEMAVENTAS.MODELOS;
using SITEMAVENTAS.VISTA.LISTASVISTAS;
using SITEMAVENTAS.VISTA.PLATAFORMAVISTAS;
using SITEMAVENTAS.VISTA.ProveedorVistas;
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

namespace SITEMAVENTAS.VISTA.FORMULARIOSVISTAS
{
    public partial class RegistrarIngresoActualVista : Form
    {
        public RegistrarIngresoActualVista()
        {
            InitializeComponent();
        }
        IngresoBss bss = new IngresoBss();
        public static int IdProveedorSeleccionada = 0;
        ProveedorBss bssprov = new ProveedorBss();

        private void button3_Click(object sender, EventArgs e)//SELECCIONAR PROVEEDOR
        {
            ProveedoresListarVista fr = new ProveedoresListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                PROVEEDOR proveedor = bssprov.ObtenerProveedorIdBss(IdProveedorSeleccionada);
                textBox1.Text = proveedor.Nombre;
            }
        }

        private void button1_Click(object sender, EventArgs e)//GUARDAR
        {
            INGRESO p = new INGRESO();
            p.IdProveedor = IdProveedorSeleccionada;
            p.FechaIngreso = dateTimePicker1.Value;
            p.Total = Convert.ToDecimal(textBox2.Text);
            //p.Estado = textBox3.Text;

            bss.InsertarIngresoBss(p);
            MessageBox.Show("Se guardó correctamente a Ingreso");
        }

        private void button2_Click(object sender, EventArgs e)//CANCELAR
        {
            this.Hide();
            BIENVENIDA HOLA = new BIENVENIDA();
            HOLA.Show();
        }
    }
}
