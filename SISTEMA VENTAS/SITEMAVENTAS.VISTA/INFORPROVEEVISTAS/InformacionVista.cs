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

namespace SITEMAVENTAS.VISTA.INFORPROVEEVISTAS
{
    public partial class InformacionVista : Form
    {
        public InformacionVista()
        {
            InitializeComponent();
        }

        private void InformacionVista_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//CANCELAR
        {
            this.Hide();
            BIENVENIDA intro = new BIENVENIDA();
            intro.Show();
        }
    }
}
