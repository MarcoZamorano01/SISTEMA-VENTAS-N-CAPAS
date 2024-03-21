using SISTEMASVENTAS.BSS;
using SISTEMAVENTAS.MODELOS;
using SITEMAVENTAS.VISTA.IngresoVistas;
using SITEMAVENTAS.VISTA.NewFolder;
using SITEMAVENTAS.VISTA.ProductoVistas;
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
    public partial class DetalleIngInsertarVista : Form
    {
        public DetalleIngInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdIngresoSelecionada = 0;
        public static int IdProductoSeleccionada = 0;

        DetallelngBss bss = new DetallelngBss();
        IngresoBss bssIngreso = new IngresoBss();
        ProductoBss bssProducto = new ProductoBss();
        private void button1_Click(object sender, EventArgs e)//guardar
        {
            DETALLEING d = new DETALLEING();
            d.IdIngreso = Convert.ToInt32(textBox1.Text);
            d.IdProducto = Convert.ToInt32(textBox2.Text);
            d.FechaVenc = dateTimePicker1.Value;
            d.Cantidad = Convert.ToInt32(textBox4.Text);
            d.PrecioCosto = Convert.ToDecimal(textBox5.Text);
            d.PrecioVenta = Convert.ToDecimal(textBox6.Text);
            d.SubTotal = Convert.ToDecimal(textBox7.Text);
            bss.InsertarDetalleIngBss(d);
            MessageBox.Show("se guardo correctamente el detalle de ingreso");
        }

        private void button4_Click(object sender, EventArgs e)//seleccionar id ingreso
        {
            
            IngresoListarvista fr = new IngresoListarvista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                INGRESO ingreso = bssIngreso.ObtenerIngresoIdBss(IdIngresoSelecionada);
                textBox1.Text = Convert.ToString(ingreso.IdIngreso);
            }
        }

        private void button3_Click(object sender, EventArgs e)//seleccionar id producto
        {
            
            ProductoListarvista fr = new ProductoListarvista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                PRODUCTO producto = bssProducto.ObtenerProductoIdBss(IdProductoSeleccionada);
                textBox2.Text = Convert.ToString(producto.IdProducto);
            }
        }
    }
}
