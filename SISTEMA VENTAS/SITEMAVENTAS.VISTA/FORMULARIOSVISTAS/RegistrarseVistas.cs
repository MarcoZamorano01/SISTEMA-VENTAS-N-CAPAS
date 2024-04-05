using SISTEMASVENTAS.BSS;
using SISTEMAVENTAS.MODELOS;
using SITEMAVENTAS.VISTA.LISTASVISTAS;
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
    public partial class RegistrarseVistas : Form
    {
        public RegistrarseVistas()
        {
            InitializeComponent();
        }
        PersonaBss bss = new PersonaBss();

        private void button1_Click(object sender, EventArgs e)//guardar
        {
            PERSONA p = new PERSONA();
            p.Nombre = textBox1.Text;
            p.Apellido = textBox2.Text;
            p.Telefono = textBox3.Text;
            p.Ci = textBox4.Text;
            p.Correo = textBox5.Text;

            bss.InsertarPersonaBss(p);
            MessageBox.Show("se guardo correctamente la persona");
            
        }

        private void button2_Click(object sender, EventArgs e)//cancelar
        {
            this.Hide();
            BIENVENIDA intro = new BIENVENIDA();
            intro.Show();
        }
    }
}
