using SISTEMASVENTAS.BSS;
using SISTEMAVENTAS.MODELOS;
using SITEMAVENTAS.VISTA.IngresoVistas;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SITEMAVENTAS.VISTA.DetallelngVistas
{
    public partial class DetalleIngEditarVista : Form
    {
        int idx = 0;
        DETALLEING detalleing = new DETALLEING();
        DetallelngBss bss = new DetallelngBss();
        public DetalleIngEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void DetalleIngEditarVista_Load(object sender, EventArgs e) //cargar
        {
            detalleing = bss.ObtenerDetalleIngIdBss(idx);
            textBox1.Text = detalleing.IdIngreso.ToString();
            textBox2.Text = detalleing.IdProducto.ToString();
            dateTimePicker1.Value = dateTimePicker1.Value;
            textBox4.Text = detalleing.Cantidad.ToString();
            textBox5.Text = detalleing.PrecioCosto.ToString();
            textBox6.Text = detalleing.PrecioVenta.ToString();
            textBox7.Text = detalleing.SubTotal.ToString();
        }

        private void button1_Click(object sender, EventArgs e) //guardar
        {
            detalleing.IdIngreso = Convert.ToInt32(textBox1.Text);
            detalleing.IdProducto = Convert.ToInt32(textBox2.Text);
            detalleing.FechaVenc = dateTimePicker1.Value;
            detalleing.Cantidad = Convert.ToInt32(textBox4.Text);
            detalleing.PrecioCosto = Convert.ToDecimal(textBox5.Text);
            detalleing.PrecioVenta = Convert.ToDecimal(textBox6.Text);
            detalleing.SubTotal = Convert.ToDecimal(textBox7.Text);

            bss.EditarDetalleIngBss(detalleing);
            MessageBox.Show("Datos Actualizados");
        }
        public static int IdProductoSelecionada = 0;
        ProductoBss bsspro = new ProductoBss();
        public static int IdIngresoSeleccionada = 0;
        IngresoBss bssing = new IngresoBss();
        private void button4_Click(object sender, EventArgs e) //seleccionar id ingreso
        {
            IngresoListarvista fr = new IngresoListarvista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                INGRESO ingreso = bssing.ObtenerIngresoIdBss(IdIngresoSeleccionada);
                textBox1.Text = ingreso.IdIngreso.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e) //seleccionar id producto
        {
            ProductoListarvista fr = new ProductoListarvista(); 
            if (fr.ShowDialog() == DialogResult.OK) 
            {
                PRODUCTO producto = bsspro.ObtenerProductoIdBss(IdProductoSelecionada);
                textBox2.Text = producto.Nombre;
            }
        }
    }
}
