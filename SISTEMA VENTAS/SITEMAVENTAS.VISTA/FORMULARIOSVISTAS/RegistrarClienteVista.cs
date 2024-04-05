using SISTEMASVENTAS.BSS;
using SISTEMAVENTAS.MODELOS;
using SITEMAVENTAS.VISTA.LISTASVISTAS;
using SITEMAVENTAS.VISTA.NewFolder;
using SITEMAVENTAS.VISTA.PLATAFORMAVISTAS;
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
    public partial class RegistrarClienteVista : Form
    {
        public RegistrarClienteVista()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();  
        private void button3_Click(object sender, EventArgs e)//SELECCIONAR PERSONA
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                PERSONA persona = bssPers.ObtenerPersonaIdBss(IdPersonaSelecionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }
        public static int IdPersonaSelecionada = 0;
        PersonaBss bssPers = new PersonaBss();
        private void button1_Click(object sender, EventArgs e)//GUARDAR
        {
            CLIENTE c = new CLIENTE();
            c.IdPersona = IdPersonaSelecionada;
            c.TipoCliente = textBox2.Text;
            c.CodigoCliente = textBox3.Text;
            bss.InsertarClienteBss(c);
            MessageBox.Show("se guardo correctamente el cliente");
        }

        private void button2_Click(object sender, EventArgs e)//CANCELAR
        {
            this.Hide();
            BIENVENIDA hola = new BIENVENIDA();
            hola.Show();
        }
    }
}
