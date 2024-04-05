using SISTEMASVENTAS.BSS;
using SISTEMAVENTAS.MODELOS;
using SITEMAVENTAS.VISTA.IngresoVistas;
using SITEMAVENTAS.VISTA.LISTASVISTAS;
using SITEMAVENTAS.VISTA.PLATAFORMAVISTAS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SITEMAVENTAS.VISTA.FORMULARIOSVISTAS
{
    public partial class RegistrarClienteEditadoVista : Form
    {
        int idx = 0;
        CLIENTE cli = new CLIENTE();
        ClienteBss bss = new ClienteBss();
        public RegistrarClienteEditadoVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void RegistrarClienteEditadoVista_Load(object sender, EventArgs e)
        {
            cli = bss.ObtenerClienteIdBss(idx);
            textBox1.Text = cli.IdPersona.ToString();
            textBox2.Text = cli.TipoCliente;
            textBox3.Text = cli.CodigoCliente;
        }
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bssPer = new PersonaBss();
        private void button3_Click(object sender, EventArgs e)//seleccionar persona
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                PERSONA persona = bssPer.ObtenerPersonaIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.IdPersona.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)//guardar
        {
            cli.IdPersona = Convert.ToInt32(textBox1.Text);
            cli.TipoCliente = textBox2.Text;
            cli.CodigoCliente = textBox3.Text;

            bss.EditarClienteBss(cli);
            MessageBox.Show("Datos Actualizados");
        }

        private void button2_Click(object sender, EventArgs e)//cancelar
        {
            this.Hide();
            BIENVENIDA hola = new BIENVENIDA();
            hola.Show();
        }
    }
}
