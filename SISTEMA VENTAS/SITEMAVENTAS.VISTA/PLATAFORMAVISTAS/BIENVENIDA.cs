using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SITEMAVENTAS.VISTA.PLATAFORMAVISTAS
{
    public partial class BIENVENIDA : Form
    {
        public BIENVENIDA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TiendaVirtualUsuarioVistas TiendaVirtual = new TiendaVirtualUsuarioVistas();
            TiendaVirtual.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DESPEDIDA CHAU = new DESPEDIDA();
            CHAU.Show();
        }
    }
}
