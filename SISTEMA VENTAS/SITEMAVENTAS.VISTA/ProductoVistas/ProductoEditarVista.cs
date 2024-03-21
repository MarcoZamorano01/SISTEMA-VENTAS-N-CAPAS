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
    public partial class ProductoEditarVista : Form
    {
        int idx = 0;
        PRODUCTO p = new PRODUCTO();
        ProductoBss bss = new ProductoBss();
        public ProductoEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//guardar
        {
            p.IdTipoProducto = IdTipoProdSeleccionada;
            p.IdMarca = IdMarcaSeleccionada;
            p.Nombre = textBox3.Text;
            p.CodigoBarra = textBox4.Text;
            p.Unidad = Convert.ToInt32(textBox5.Text);
            p.Descripcion = textBox6.Text;

            bss.EditarProductoBss(p);
            MessageBox.Show("Datos Actualizados");
        }
        public static int IdTipoProdSeleccionada = 0;
        TipoProdBss bsstip = new TipoProdBss();
        private void button4_Click(object sender, EventArgs e)//seleccionar tipo prod
        {
            TipoProdListarvista fr = new TipoProdListarvista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                TIPOPROD tipoprod = bsstip.ObtenerTipoProdIdBss(IdTipoProdSeleccionada);
                textBox1.Text = tipoprod.Nombre;
            }
        }

        private void ProductoEditarVista_Load(object sender, EventArgs e)//cargar
        {
            p = bss.ObtenerProductoIdBss(idx);
            textBox1.Text = p.IdTipoProducto.ToString();
            textBox2.Text = p.IdMarca.ToString();
            textBox3.Text = p.Nombre;
            textBox4.Text = p.CodigoBarra;
            textBox5.Text = p.Unidad.ToString();
            textBox6.Text = p.Descripcion;
        }
        public static int IdMarcaSeleccionada = 0;
        MarcaBss bssmar = new MarcaBss();
        private void button3_Click(object sender, EventArgs e)//seleccionar id marca
        {
            MarcaListarvista fr = new MarcaListarvista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                MARCA marca = bssmar.ObtenerMarcaIdBss(IdMarcaSeleccionada);
                textBox2.Text = marca.Nombre;
            }
        }
    }
}
