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
    public partial class RolInsertarVista : Form
    {
        public RolInsertarVista()
        {
            InitializeComponent();
        }
        RolBss bss = new RolBss();

        private void button1_Click(object sender, EventArgs e)
        {
            ROL p = new ROL();
            p.Nombre = textBox1.Text;

            bss.InsertarRolBss(p);
            MessageBox.Show("Se guardó correctamente a Rol");
        }
    }
}
