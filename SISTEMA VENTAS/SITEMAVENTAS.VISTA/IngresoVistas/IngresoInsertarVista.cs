using SISTEMASVENTAS.BSS;
using SISTEMASVENTAS.DAL;
using SISTEMAVENTAS.MODELOS;
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

namespace SITEMAVENTAS.VISTA.IngresoVistas
{
    public partial class IngresoInsertarVista : Form
    {
        public IngresoInsertarVista()
        {
            InitializeComponent();
        }
        IngresoBss bss = new IngresoBss();
        public static int IdProveedorSeleccionada = 0;
        ProveedorBss bssprov = new ProveedorBss();

        private void button3_Click(object sender, EventArgs e)//seleccionar proveedor
        {
            ProveedorListarvista fr = new ProveedorListarvista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                PROVEEDOR proveedor = bssprov.ObtenerProveedorIdBss(IdProveedorSeleccionada);
                textBox3.Text = proveedor.Nombre;
            }
        }

        private void button1_Click(object sender, EventArgs e)//ingreso
        {
            INGRESO p = new INGRESO();
            p.IdProveedor = IdProveedorSeleccionada;
            p.FechaIngreso = dateTimePicker1.Value;
            p.Total = Convert.ToDecimal(textBox2.Text);
            //p.Estado = textBox3.Text;

            bss.InsertarIngresoBss(p);
            MessageBox.Show("Se guardó correctamente a Ingreso");
        }
    }
}
