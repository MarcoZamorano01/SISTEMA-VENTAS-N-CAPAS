using SISTEMASVENTAS.BSS;
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
    public partial class UsuarioListarvista : Form
    {
        public UsuarioListarvista()
        {
            InitializeComponent();
        }
        UsuarioBss bss = new UsuarioBss();

        private void UsuarioListarvista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaUsuarioBss();
        }
    }
}
