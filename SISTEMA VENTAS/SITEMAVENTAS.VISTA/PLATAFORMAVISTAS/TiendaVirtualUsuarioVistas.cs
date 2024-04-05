using SITEMAVENTAS.VISTA.FORMULARIOSVISTAS;
using SITEMAVENTAS.VISTA.INFORPROVEEVISTAS;
using SITEMAVENTAS.VISTA.LISTASVISTAS;
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
    public partial class TiendaVirtualUsuarioVistas : Form
    {
        public TiendaVirtualUsuarioVistas()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)//solo personal
        {
            this.Hide();
            IngresarVistas ingreso = new IngresarVistas();
            ingreso.Show();
        }

        private void button6_Click(object sender, EventArgs e) //registrar persona
        {
            this.Hide();
            RegistrarseVistas Registrarse = new RegistrarseVistas();
            Registrarse.Show();
        }

        private void button1_Click(object sender, EventArgs e)//lista productos
        {
            this.Hide();
            ProductosUsuariosListarVista ProductosUsuarios = new ProductosUsuariosListarVista();
            ProductosUsuarios.Show();
        }

        private void button2_Click(object sender, EventArgs e)//lista proveedores
        {
            this.Hide();
            ProveedoresUsuariosListarVista ProveedoresUsuarios = new ProveedoresUsuariosListarVista();
            ProveedoresUsuarios.Show();
        }

        private void button3_Click(object sender, EventArgs e)//lista tipos productos
        {
            this.Hide();
            TiposProductosUsuariosListarVista TiposProductosUsuarios = new TiposProductosUsuariosListarVista();
            TiposProductosUsuarios.Show();
        }

        private void button4_Click(object sender, EventArgs e)//listar marcas
        {
            this.Hide();
            MarcasUsuariosListarVista MarcasUsuarios = new MarcasUsuariosListarVista();
            MarcasUsuarios.Show();
        }

        private void button5_Click(object sender, EventArgs e)//ayuda
        {
            this.Hide();
            InformacionVista info = new InformacionVista();
            info.Show();
        }

        private void button8_Click(object sender, EventArgs e)//RGISTRO USUARIO
        {
            this.Hide();
            RegistroUserVistas registroUser = new RegistroUserVistas();
            registroUser.Show();
        }
    }
}
