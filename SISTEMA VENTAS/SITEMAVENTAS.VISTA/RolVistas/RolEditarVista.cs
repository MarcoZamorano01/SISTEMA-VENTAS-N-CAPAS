using SISTEMASVENTAS.BSS;
using SISTEMAVENTAS.MODELOS;
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

namespace SITEMAVENTAS.VISTA.RolVistas
{
    public partial class RolEditarVista : Form
    {
        int idx = 0;
        ROL p = new ROL();
        RolBss bss = new RolBss();
        public RolEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void RolEditarVista_Load(object sender, EventArgs e)//cargar
        {
            p = bss.ObtenerRolIdBss(idx);
            textBox1.Text = p.Nombre;
        }

        private void button1_Click(object sender, EventArgs e)//guardar
        {
            p.Nombre = textBox1.Text;

            bss.EditarRolBss(p);
            MessageBox.Show("Datos Actualizados");
        }
    }
}
