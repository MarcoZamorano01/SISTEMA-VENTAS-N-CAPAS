using SISTEMASVENTAS.BSS;
using SISTEMASVENTAS.DAL;
using SISTEMAVENTAS.MODELOS;
using SITEMAVENTAS.VISTA.ProductoVistas;
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

namespace SITEMAVENTAS.VISTA.ProveeVistas
{
    public partial class ProveeInsertarVista : Form
    {
        public ProveeInsertarVista()
        {
            InitializeComponent();
        }
        ProveeBss bss = new ProveeBss();

        private void button1_Click(object sender, EventArgs e)//guardar
        {
            PROVEE p = new PROVEE();
            p.IdProducto = IdProductoSeleccionada;
            p.Idproveedor = IdProveedorSeleccionada;
            p.Fecha = dateTimePicker1.Value;
            p.Precio = Convert.ToDecimal(textBox3.Text);
            bss.InsertarProveeBss(p);
            MessageBox.Show("Se guardó correctamente a Provee");
        }
        public static int IdProductoSeleccionada = 0;
        ProductoBss bsspro = new ProductoBss();
        private void button4_Click(object sender, EventArgs e)//seleccionar id producto
        {
            ProductoListarvista fr = new ProductoListarvista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                PRODUCTO producto = bsspro.ObtenerProductoIdBss(IdProductoSeleccionada);
                textBox1.Text = producto.Nombre;
            }
        }
        public static int IdProveedorSeleccionada = 0;
        ProveedorBss bssprov = new ProveedorBss();
        private void button3_Click(object sender, EventArgs e)//sleccionar id proveedor
        {
            ProveedorListarvista fr = new ProveedorListarvista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                PROVEEDOR proveedor = bssprov.ObtenerProveedorIdBss(IdProveedorSeleccionada);
                textBox2.Text = proveedor.Nombre;
            }
        }
    }
}
