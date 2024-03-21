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
    public partial class ProveeEditarVista : Form
    {
        int idx = 0;
        PROVEE p = new PROVEE();
        ProveeBss bss = new ProveeBss();
        public ProveeEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void ProveeEditarVista_Load(object sender, EventArgs e)//cargar
        {
            p = bss.ObtenerProveeIdBss(idx);
            textBox1.Text = p.IdProducto.ToString();
            textBox2.Text = p.Idproveedor.ToString();
            dateTimePicker1.Value = p.Fecha;
            textBox3.Text = p.Precio.ToString();
        }

        private void button1_Click(object sender, EventArgs e)//guardar
        {
            p.IdProducto = IdProductoSeleccionada;
            p.Idproveedor = IdProveedorSeleccionada;
            p.Fecha = dateTimePicker1.Value;
            p.Precio = Convert.ToDecimal(textBox3.Text);

            bss.EditarProveeBss(p);
            MessageBox.Show("Datos Actualizados");
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
        private void button3_Click(object sender, EventArgs e)//seleccionar id proveedor
        {
            ProveeListarvista fr = new ProveeListarvista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                PROVEEDOR proveedor = bssprov.ObtenerProveedorIdBss(IdProveedorSeleccionada);
                textBox2.Text = proveedor.Nombre;
            }
        }
    }
}
