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

namespace SITEMAVENTAS.VISTA.UsuarioRolVistas
{
    public partial class UsuarioRolListarvista : Form
    {
        public UsuarioRolListarvista()
        {
            InitializeComponent();
        }
        UsuarioRolBss bss = new UsuarioRolBss();

        private void UsuarioRolListarvista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaUsuarioRolBss();
        }
    }
}
