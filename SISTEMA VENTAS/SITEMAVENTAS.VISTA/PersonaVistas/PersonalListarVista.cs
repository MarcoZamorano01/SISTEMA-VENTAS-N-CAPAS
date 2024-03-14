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

namespace SITEMAVENTAS.VISTA.NewFolder
{
    public partial class PersonalListarVista : Form
    {
        public PersonalListarVista()
        {
            InitializeComponent();
        }
        PersonaBss bss= new PersonaBss();

        private void PersonalListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaPersonaBss();
        }
    }
}
