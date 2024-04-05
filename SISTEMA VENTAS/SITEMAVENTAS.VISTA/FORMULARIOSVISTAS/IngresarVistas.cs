using SITEMAVENTAS.VISTA.PLATAFORMAVISTAS;
using SITEMAVENTAS.VISTA.VENTASREALIVISTAS;
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
    public partial class IngresarVistas : Form
    {
        public IngresarVistas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//INGRESAR
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;

            if (usuario == "usuario" && contraseña == "contraseña")
            {
                PlataformaPersonalVistas plataforma = new PlataformaPersonalVistas();
                plataforma.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            BIENVENIDA hola = new BIENVENIDA();
            hola.Show();
        }
    }
}
