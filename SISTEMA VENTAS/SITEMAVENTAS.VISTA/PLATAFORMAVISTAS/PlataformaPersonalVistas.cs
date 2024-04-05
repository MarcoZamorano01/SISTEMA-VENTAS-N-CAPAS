using SITEMAVENTAS.VISTA.FORMULARIOSVISTAS;
using SITEMAVENTAS.VISTA.INGRESOSACTVISTAS;
using SITEMAVENTAS.VISTA.LISTASVISTAS;
using SITEMAVENTAS.VISTA.UsuarioVistas;
using SITEMAVENTAS.VISTA.VENTASREALIVISTAS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SITEMAVENTAS.VISTA.PLATAFORMAVISTAS
{
    public partial class PlataformaPersonalVistas : Form
    {
        public PlataformaPersonalVistas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//AÑADIR PRODUCTO
        {
            this.Hide();
            RegistrarProductoVista RegisProd = new RegistrarProductoVista();
            RegisProd.Show();
        }

        private void button2_Click(object sender, EventArgs e)//AÑADIR TIPO PRODUCTO
        {
            this.Hide();
            RegistrarTipoProductoVista RegisTiProd = new RegistrarTipoProductoVista();
            RegisTiProd.Show();
        }

        private void button6_Click(object sender, EventArgs e)//AÑADIR MARCAS
        {
            this.Hide();
            RegistrarMarcaVista RegisMarca = new RegistrarMarcaVista();
            RegisMarca.Show();
        }

        private void button7_Click(object sender, EventArgs e)//AÑADIR PROVEEDOR
        {
            this.Hide();
            RegistrarProveedorVistas RegisProvee = new RegistrarProveedorVistas();
            RegisProvee.Show();
        }

        private void button5_Click(object sender, EventArgs e)//VENTAS
        {
            this.Hide();
            VentasRealizadasVistas VentaReal = new VentasRealizadasVistas();
            VentaReal.Show();
        }

        private void button3_Click(object sender, EventArgs e)//INGRESOS 
        {
            this.Hide();
            IngresosActualesVistas IngresoActual = new IngresosActualesVistas();
            IngresoActual.Show();
        }

        private void button4_Click(object sender, EventArgs e)//USUARIOS
        {
            this.Hide();
            UsuariosListarVista usuarios = new UsuariosListarVista();
            usuarios.Show();
        }
    }
}
