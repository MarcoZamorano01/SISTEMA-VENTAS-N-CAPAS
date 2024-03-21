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
    public partial class UsuarioEditarVista : Form
    {
        int idx = 0;
        USUARIO p = new USUARIO();
        UsuarioBss bss = new UsuarioBss();
        public UsuarioEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void UsuarioEditarVista_Load(object sender, EventArgs e)//cargar
        {
            p = bss.ObtenerUsuarioIdBss(idx);
            textBox1.Text = p.IdPersona.ToString();
            textBox2.Text = p.NombreUser;
            textBox3.Text = p.Contraseña;
            dateTimePicker1.Value = p.FechaReg;
        }

        private void button3_Click(object sender, EventArgs e)//guardar
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
        private void button1_Click(object sender, EventArgs e)//seleccionar
        {
            PersonalListarVista fr = new PersonalListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                PERSONA persona = bssper.ObtenerPersonaIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }
    }
}
