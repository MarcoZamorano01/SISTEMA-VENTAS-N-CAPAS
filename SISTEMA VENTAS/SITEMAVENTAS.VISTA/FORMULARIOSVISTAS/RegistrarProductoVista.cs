using SISTEMASVENTAS.BSS;
using SISTEMAVENTAS.MODELOS;
using SITEMAVENTAS.VISTA.INGRESOSACTVISTAS;
using SITEMAVENTAS.VISTA.LISTASVISTAS;
using SITEMAVENTAS.VISTA.MarcaVistas;
using SITEMAVENTAS.VISTA.PLATAFORMAVISTAS;
using SITEMAVENTAS.VISTA.TIPOPRODUCTVISTAS;
using SITEMAVENTAS.VISTA.TipoProdVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SITEMAVENTAS.VISTA.FORMULARIOSVISTAS
{
    public partial class RegistrarProductoVista : Form
    {
        public RegistrarProductoVista()
        {
            InitializeComponent();
        }
        ProductoBss bss = new ProductoBss();
        private void button1_Click(object sender, EventArgs e)//GUARDAR
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

        private void button3_Click(object sender, EventArgs e)//SELECCION ID TIPO PRODUCTO
        {
            TiposProductosVista fr = new TiposProductosVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                TIPOPROD tipoprod = bsstip.ObtenerTipoProdIdBss(IdTipoProdSeleccionada);
                textBox1.Text = tipoprod.Nombre;
            }
        }
        public static int IdMarcaSeleccionada = 0;
        MarcaBss bssmar = new MarcaBss();
        private void button4_Click(object sender, EventArgs e)//SELECCION ID MARCA
        {
            MarcasListarVista fr = new MarcasListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                MARCA marca = bssmar.ObtenerMarcaIdBss(IdMarcaSeleccionada);
                textBox4.Text = marca.Nombre;
            }
        }

        private void button2_Click(object sender, EventArgs e)//CANCELAR
        {
            this.Hide();
            PlataformaPersonalVistas PERSONAL = new PlataformaPersonalVistas();
            PERSONAL.Show();
        }
    }
}
