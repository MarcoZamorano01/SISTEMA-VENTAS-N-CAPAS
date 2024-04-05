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
    public partial class RegistroUserVistas : Form
    {
        public RegistroUserVistas()
        {
            InitializeComponent();
        }
        public static int IdPersonaSelecionada = 0;
        PersonaBss bss = new PersonaBss();
        UsuarioBss bssUser = new UsuarioBss();
        private void button3_Click(object sender, EventArgs e)//SELECCIONAR PERSONA
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                PERSONA persona = bss.ObtenerPersonaIdBss(IdPersonaSelecionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }

        private void button1_Click(object sender, EventArgs e)//GUARDAR
        {
            USUARIO p = new USUARIO();
            p.IdPersona = IdPersonaSelecionada;
            p.NombreUser = textBox2.Text;
            p.Contraseña = textBox3.Text;
            p.FechaReg = dateTimePicker1.Value;

            bssUser.InsertarUsuarioBss(p);
            MessageBox.Show("Se guardó correctamente a Usuario");

        }

        private void button2_Click(object sender, EventArgs e)//CANCELAR
        {
            this.Hide();
            BIENVENIDA HOLA = new BIENVENIDA();
            HOLA.Show();
        }
    }
}
