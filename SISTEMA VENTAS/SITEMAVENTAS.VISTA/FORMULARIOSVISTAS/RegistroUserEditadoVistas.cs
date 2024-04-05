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
    public partial class RegistroUserEditadoVistas : Form
    {
        int idx = 0;
        USUARIO p = new USUARIO();
        UsuarioBss bss = new UsuarioBss();
        public RegistroUserEditadoVistas(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void RegistroUserEditadoVistas_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerUsuarioIdBss(idx);
            textBox1.Text = p.IdPersona.ToString();
            textBox2.Text = p.NombreUser;
            textBox3.Text = p.Contraseña;
            dateTimePicker1.Value = p.FechaReg;
        }

        private void button1_Click(object sender, EventArgs e)//guardar
        {
            p.IdPersona = IdPersonaSeleccionada;
            p.NombreUser = textBox2.Text;
            p.Contraseña = textBox3.Text;
            p.FechaReg = dateTimePicker1.Value;
            bss.EditarUsuarioBss(p);
            MessageBox.Show("Datos Actualizados");
        }
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bssper = new PersonaBss();
        private void button2_Click(object sender, EventArgs e)//cancelar
        {
            this.Hide();
            BIENVENIDA hola = new BIENVENIDA();
            hola.Show();
        }

        private void button3_Click(object sender, EventArgs e)//seleccion id persona
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                PERSONA persona = bssper.ObtenerPersonaIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }
    }
}
