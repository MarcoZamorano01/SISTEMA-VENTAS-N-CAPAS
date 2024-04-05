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
    public partial class RegistrarseEditadoVistas : Form
    {
        int idx = 0;
        PERSONA p = new PERSONA();
        PersonaBss bss = new PersonaBss();
        public RegistrarseEditadoVistas(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void RegistrarseEditadoVistas_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerPersonaIdBss(idx);
            textBox1.Text = p.Nombre;
            textBox2.Text = p.Apellido;
            textBox3.Text = p.Telefono;
            textBox4.Text = p.Ci;
            textBox5.Text = p.Correo;
        }

        private void button1_Click(object sender, EventArgs e)//guardar
        {
            p.Nombre = textBox1.Text;
            p.Apellido = textBox2.Text;
            p.Telefono = textBox3.Text;
            p.Ci = textBox4.Text;
            p.Correo = textBox5.Text;

            bss.EditarPersonaBss(p);
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
