using SISTEMASVENTAS.BSS;
using SISTEMAVENTAS.MODELOS;
using SITEMAVENTAS.VISTA.ClienteVistas;
using SITEMAVENTAS.VISTA.LISTASVISTAS;
using SITEMAVENTAS.VISTA.PLATAFORMAVISTAS;
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

namespace SITEMAVENTAS.VISTA.FORMULARIOSVISTAS
{
    public partial class RegistrarVentaVista : Form
    {
        public RegistrarVentaVista()
        {
            InitializeComponent();
        }
        VentaBss bss = new VentaBss();
        private void RegistrarVentaVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaVentaBss();
        }

        private void button3_Click(object sender, EventArgs e)//SELECCION ID CLIENTE
        {
            ClientesListarVista fr = new ClientesListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                CLIENTE cliente = bssclie.ObtenerClienteIdBss(IdClienteSeleccionada);
                textBox1.Text = cliente.IdCliente.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)//GUARDAR
        {
            VENTA p = new VENTA();
            p.IdCliente = IdClienteSeleccionada;
            p.IdVendedor = IdVendedorSeleccionada;
            p.Fecha = dateTimePicker1.Value;
            p.Total = Convert.ToDecimal(textBox3.Text);

            bss.InsertarVentaBss(p);
            MessageBox.Show("Se guardó correctamente la Venta");
        }
        public static int IdClienteSeleccionada = 0;
        ClienteBss bssclie = new ClienteBss();
        private void button2_Click(object sender, EventArgs e)//CANCELAR
        {
            this.Hide();
            BIENVENIDA hola = new BIENVENIDA();
            hola.Show();
        }
        public static int IdVendedorSeleccionada = 0;
        UsuarioBss bssven = new UsuarioBss();
        private void button4_Click(object sender, EventArgs e)//seleccionar id vendedor
        {
            UsuariosListarVista fr = new UsuariosListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                USUARIO usuario = bssven.ObtenerUsuarioIdBss(IdVendedorSeleccionada);
                textBox2.Text = usuario.IdUsario.ToString();
            }
        }
    }
}
