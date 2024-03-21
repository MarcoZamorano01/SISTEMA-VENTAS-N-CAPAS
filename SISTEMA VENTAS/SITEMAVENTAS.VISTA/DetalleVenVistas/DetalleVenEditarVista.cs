using SISTEMASVENTAS.BSS;
using SISTEMAVENTAS.MODELOS;
using SITEMAVENTAS.VISTA.ProductoVistas;
using SITEMAVENTAS.VISTA.VentaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SITEMAVENTAS.VISTA.DetalleVenVistas
{
    public partial class DetalleVenEditarVista : Form
    {
        int idx = 0;
        DETALLEVENT p = new DETALLEVENT();
        DetalleVenBss bss = new DetalleVenBss();
        public DetalleVenEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void DetalleVenEditarVista_Load(object sender, EventArgs e)//cargar
        {
            p = bss.ObtenerDetalleVenIdBss(idx);
            textBox1.Text = p.IdVenta.ToString();
            textBox2.Text = p.IdProducto.ToString();
            textBox3.Text = p.Cantidad.ToString();
            textBox4.Text = p.PrecioVenta.ToString();
            textBox5.Text = p.SubTotal.ToString();
        }

        private void button1_Click(object sender, EventArgs e)//guardar
        {
            p.IdVenta = IdVentaSeleccionada;
            p.IdProducto = IdProductoSeleccionada;
            p.Cantidad = Convert.ToInt32(textBox3.Text);
            p.PrecioVenta = Convert.ToDecimal(textBox4.Text);
            p.SubTotal = Convert.ToDecimal(textBox5.Text);

            bss.EditarDetalleVenBss(p);
            MessageBox.Show("Datos Actualizados");
        }
        public static int IdVentaSeleccionada = 0;
        VentaBss bssven = new VentaBss();

        private void button4_Click(object sender, EventArgs e)
        {
            VentaListarvista fr = new VentaListarvista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                VENTA venta = bssven.ObtenerVentaIdBss(IdVentaSeleccionada);
                textBox1.Text = venta.IdVenta.ToString();
            }
        }
        public static int IdProductoSeleccionada = 0;
        ProductoBss bsspro = new ProductoBss();

        private void button3_Click(object sender, EventArgs e)
        {
            ProductoListarvista fr = new ProductoListarvista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                PRODUCTO producto = bsspro.ObtenerProductoIdBss(IdProductoSeleccionada);
                textBox2.Text = producto.Nombre;
            }
        }
    }
}
