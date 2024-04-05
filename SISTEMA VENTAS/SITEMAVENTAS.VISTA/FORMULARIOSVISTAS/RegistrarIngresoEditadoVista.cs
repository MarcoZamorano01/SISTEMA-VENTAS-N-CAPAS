using SISTEMASVENTAS.BSS;
using SISTEMAVENTAS.MODELOS;
using SITEMAVENTAS.VISTA.LISTASVISTAS;
using SITEMAVENTAS.VISTA.PLATAFORMAVISTAS;
using SITEMAVENTAS.VISTA.ProveedorVistas;
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

namespace SITEMAVENTAS.VISTA.FORMULARIOSVISTAS
{
    public partial class RegistrarIngresoEditadoVista : Form
    {
        int idx = 0;
        INGRESO p = new INGRESO();
        IngresoBss bss = new IngresoBss();
        public RegistrarIngresoEditadoVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void RegistrarIngresoEditadoVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerIngresoIdBss(idx);
            textBox1.Text = p.IdProveedor.ToString();
            dateTimePicker1.Value = p.FechaIngreso;
            textBox2.Text = p.Total.ToString();
            //textBox3.Text = p.Estado;
        }

        private void button1_Click(object sender, EventArgs e)//guardar
        {
            p.IdProveedor = IdProveedorSeleccionada;
            p.FechaIngreso = dateTimePicker1.Value;
            p.Total = Convert.ToDecimal(textBox2.Text);
            //p.Estado = textBox3.Text;

            bss.EditarIngresoBss(p);
            MessageBox.Show("Datos Actualizados");
        }

        private void button2_Click(object sender, EventArgs e)//cancelar
        {
            this.Hide();
            BIENVENIDA HOLA = new BIENVENIDA();
            HOLA.Show();
        }
        public static int IdProveedorSeleccionada = 0;
        ProveedorBss bssprov = new ProveedorBss();
        private void button3_Click(object sender, EventArgs e)//seleccionar
        {
            ProveedoresListarVista fr = new ProveedoresListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                PROVEEDOR proveedor = bssprov.ObtenerProveedorIdBss(IdProveedorSeleccionada);
                textBox2.Text = proveedor.Nombre;
            }
        }
    }
}
