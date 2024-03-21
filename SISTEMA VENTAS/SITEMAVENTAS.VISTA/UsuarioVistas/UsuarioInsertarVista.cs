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

namespace SITEMAVENTAS.VISTA.UsuarioVistas
{
    public partial class UsuarioInsertarVista : Form
    {
        public UsuarioInsertarVista()
        {
            InitializeComponent();
        }

        public static int IdPersonaSelecionada = 0;
        PersonaBss bss = new PersonaBss();
        UsuarioBss bssUser = new UsuarioBss();
        private void button1_Click(object sender, EventArgs e)//boton seleccionar
        {
            PersonalListarVista fr = new PersonalListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                PERSONA persona = bss.ObtenerPersonaIdBss(IdPersonaSelecionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }

        private void button3_Click(object sender, EventArgs e)//boton guardar
        {
            USUARIO p = new USUARIO();
            p.IdPersona = IdPersonaSelecionada;
            p.NombreUser = textBox2.Text;
            p.Contraseña = textBox3.Text;
            p.FechaReg = dateTimePicker1.Value;

            bssUser.InsertarUsuarioBss(p);
            MessageBox.Show("Se guardó correctamente a Usuario");
        }

        private void UsuarioInsertarVista_Load(object sender, EventArgs e)
        {

        }
    }
}
