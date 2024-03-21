using SISTEMASVENTAS.BSS;
using SISTEMAVENTAS.MODELOS;
using SITEMAVENTAS.VISTA.NewFolder;
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
    public partial class ClienteInsertarVista : Form
    {
        public ClienteInsertarVista()
        {
            InitializeComponent();
        }

        ClienteBss bss = new ClienteBss();
        private void button1_Click(object sender, EventArgs e)//BOTON GUARDAR
        {
            CLIENTE c = new CLIENTE();
            c.IdPersona = IdPersonaSelecionada;
            c.TipoCliente = textBox2.Text;
            c.CodigoCliente = textBox3.Text;
            bss.InsertarClienteBss(c);
            MessageBox.Show("se guardo correctamente el cliente");
        }

        private void ClienteInsertarVista_Load(object sender, EventArgs e)
        {

        }

        public static int IdPersonaSelecionada = 0;
        PersonaBss bssPers = new PersonaBss();
        private void button3_Click(object sender, EventArgs e)//SELECIONAR PERSONA
        {
            
            PersonalListarVista fr = new PersonalListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                PERSONA persona = bssPers.ObtenerPersonaIdBss(IdPersonaSelecionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }

    }
}
