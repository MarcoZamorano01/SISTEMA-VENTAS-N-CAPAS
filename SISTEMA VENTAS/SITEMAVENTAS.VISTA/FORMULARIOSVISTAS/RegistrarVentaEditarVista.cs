using SISTEMASVENTAS.BSS;
using SISTEMAVENTAS.MODELOS;
using SITEMAVENTAS.VISTA.ClienteVistas;
using SITEMAVENTAS.VISTA.LISTASVISTAS;
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
    public partial class RegistrarVentaEditarVista : Form
    {
        int idx = 0;
        VENTA p = new VENTA();
        VentaBss bss = new VentaBss();
        public RegistrarVentaEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }
        public static int IdClienteSeleccionada = 0;
        ClienteBss bssclie = new ClienteBss();
        private void RegistrarVentaEditarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaVentaBss();
            p = bss.ObtenerVentaIdBss(idx);
            textBox1.Text = p.IdCliente.ToString();
            textBox2.Text = p.IdVendedor.ToString();
            dateTimePicker1.Value = p.Fecha;
            textBox3.Text = p.Total.ToString();

        }

        private void button3_Click(object sender, EventArgs e)//seleccionar cliente
        {
            ClientesListarVista fr = new ClientesListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                CLIENTE cliente = bssclie.ObtenerClienteIdBss(IdClienteSeleccionada);
                textBox1.Text = cliente.IdCliente.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)//seleccionar vendedor
        {
            UsuariosListarVista fr = new UsuariosListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                USUARIO usuario = bssven.ObtenerUsuarioIdBss(IdVendedorSeleccionada);
                textBox2.Text = usuario.IdUsario.ToString();
            }
        }
        public static int IdVendedorSeleccionada = 0;
        UsuarioBss bssven = new UsuarioBss();
        private void button1_Click(object sender, EventArgs e)//guardar
        {
            p.IdCliente = IdClienteSeleccionada;
            p.IdVendedor = IdVendedorSeleccionada;
            p.Fecha = dateTimePicker1.Value;
            p.Total = Convert.ToDecimal(textBox3.Text);
            bss.EditarVentaBss(p);
            MessageBox.Show("Datos Actualizados");
        }

        private void button2_Click(object sender, EventArgs e)//cancelar
        {

        }
    }
}
