using SISTEMASVENTAS.BSS;
using SISTEMAVENTAS.MODELOS;
using SITEMAVENTAS.VISTA.MarcaVistas;
using SITEMAVENTAS.VISTA.TipoProdVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SITEMAVENTAS.VISTA.ProductoVistas
{
    public partial class ProductoInsertarVista : Form
    {
        public ProductoInsertarVista()
        {
            InitializeComponent();
        }
        ProductoBss bss = new ProductoBss();

        private void button1_Click(object sender, EventArgs e)//guardar
        {
            PRODUCTO p = new PRODUCTO();
            p.IdTipoProducto = IdTipoProdSeleccionada;
            p.IdMarca = IdMarcaSeleccionada;
            p.Nombre = textBox3.Text;
            p.CodigoBarra = textBox4.Text;
            p.Unidad = Convert.ToInt32(textBox5.Text);
            p.Descripcion = textBox6.Text;

            bss.InsertarProductoBss(p);
            MessageBox.Show("Se guardó correctamente a Producto");
        }

        public static int IdTipoProdSeleccionada = 0;
        TipoProdBss bsstip = new TipoProdBss();
        private void button4_Click(object sender, EventArgs e)//id tipo producto
        {
            TipoProdListarvista fr = new TipoProdListarvista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                TIPOPROD tipoprod = bsstip.ObtenerTipoProdIdBss(IdTipoProdSeleccionada);
                textBox1.Text = tipoprod.Nombre;
            }
        }
        public static int IdMarcaSeleccionada = 0;
        MarcaBss bssmar = new MarcaBss();
        private void button3_Click(object sender, EventArgs e)// id marca
        {
            MarcaListarvista fr = new MarcaListarvista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                MARCA marca = bssmar.ObtenerMarcaIdBss(IdMarcaSeleccionada);
                textBox4.Text = marca.Nombre;
            }
        }
    }
}
