using SISTEMASVENTAS.BSS;
using SISTEMAVENTAS.MODELOS;
using SITEMAVENTAS.VISTA.RolVistas;
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

namespace SITEMAVENTAS.VISTA.UsuarioRolVistas
{
    public partial class UsuarioRolInsertarVista : Form
    {
        public UsuarioRolInsertarVista()
        {
            InitializeComponent();
        }
        UsuarioRolBss bss = new UsuarioRolBss();
        private void button1_Click(object sender, EventArgs e)//guardar
        {
            USUARIOROL p = new USUARIOROL();
            p.IdUsario = IdUsuarioSeleccionada;
            p.IdRol = IdRolSeleccionada;
            p.FechaAsigna = dateTimePicker1.Value;

            bss.InsertarUsuarioRolBss(p);
            MessageBox.Show("Se guardó correctamente a UsuarioRol");
        }
        public static int IdUsuarioSeleccionada = 0;
        UsuarioBss bssuser = new UsuarioBss();
        private void button4_Click(object sender, EventArgs e)//seleccionar id usuario
        {
            UsuarioListarvista fr = new UsuarioListarvista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                USUARIO usuario = bssuser.ObtenerUsuarioIdBss(IdUsuarioSeleccionada);
                textBox1.Text = usuario.NombreUser;
            }
        }
        public static int IdRolSeleccionada = 0;
        RolBss bssrol = new RolBss();
        private void button3_Click(object sender, EventArgs e)//seleccionar id rol
        {
            RolListarvista fr = new RolListarvista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                ROL rol = bssrol.ObtenerRolIdBss(IdRolSeleccionada);
                textBox2.Text = rol.Nombre;
            }
        }
    }
}
