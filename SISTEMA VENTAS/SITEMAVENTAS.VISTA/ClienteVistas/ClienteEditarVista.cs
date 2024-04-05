using SISTEMASVENTAS.BSS;
using SISTEMAVENTAS.MODELOS;
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

namespace SITEMAVENTAS.VISTA.ClienteVistas
{
    public partial class ClienteEditarVista : Form
    {
        int idx = 0;
        CLIENTE cli = new CLIENTE();
        ClienteBss bss = new ClienteBss();
        public ClienteEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void ClienteEditarVista_Load(object sender, EventArgs e)
        {
            cli = bss.ObtenerClienteIdBss(idx);
            textBox1.Text = Convert.ToString(cli.IdPersona);
            textBox2.Text = cli.TipoCliente;
            textBox3.Text = cli.CodigoCliente;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cli.IdPersona = Convert.ToInt32(textBox1.Text);
            cli.TipoCliente = textBox2.Text;
            cli.CodigoCliente = textBox3.Text;

            bss.EditarClienteBss(cli);
            MessageBox.Show("Datos Actualizados");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
