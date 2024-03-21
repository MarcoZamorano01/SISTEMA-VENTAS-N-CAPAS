using SISTEMASVENTAS.BSS;
using SISTEMAVENTAS.MODELOS;
using SITEMAVENTAS.VISTA.ClienteVistas;
using SITEMAVENTAS.VISTA.UsuarioVistas;
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

namespace SITEMAVENTAS.VISTA.VentaVistas
{
    public partial class VentaInsertarVista : Form
    {
        public VentaInsertarVista()
        {
            InitializeComponent();
        }
        VentaBss bss = new VentaBss();

        private void button1_Click(object sender, EventArgs e)//guardar
        {
            VENTA p = new VENTA();
            p.IdCliente = IdClienteSeleccionada;
            p.IdVendedor = IdVendedorSeleccionada;
            p.Fecha = dateTimePicker1.Value;
            p.Total = Convert.ToDecimal(textBox4.Text);

            bss.InsertarVentaBss(p);
            MessageBox.Show("Se guardó correctamente a Venta");
        }
        public static int IdClienteSeleccionada = 0;
        ClienteBss bssclie = new ClienteBss();
        private void button4_Click(object sender, EventArgs e)//seleccionar id cliente
        {
            ClienteListarVista fr = new ClienteListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                CLIENTE cliente = bssclie.ObtenerClienteIdBss(IdClienteSeleccionada);
                textBox1.Text = cliente.IdCliente.ToString();
            }
        }
        public static int IdVendedorSeleccionada = 0;
        UsuarioBss bssven = new UsuarioBss();
        private void button3_Click(object sender, EventArgs e)//seleccionar id vendedor
        {
            UsuarioListarvista fr = new UsuarioListarvista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                USUARIO usuario = bssven.ObtenerUsuarioIdBss(IdVendedorSeleccionada);
                textBox2.Text = usuario.IdUsario.ToString();
            }
        }
    }
}
