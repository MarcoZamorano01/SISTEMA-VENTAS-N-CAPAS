using SISTEMASVENTAS.BSS;
using SISTEMASVENTAS.DAL;
using SISTEMAVENTAS.MODELOS;
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

namespace SITEMAVENTAS.VISTA.IngresoVistas
{
    public partial class IngresoEditarVista : Form
    {
        int idx = 0;
        INGRESO p = new INGRESO();
        IngresoBss bss = new IngresoBss();
        public IngresoEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void IngresoEditarVista_Load(object sender, EventArgs e)//cargar
        {
            p = bss.ObtenerIngresoIdBss(idx);
            textBox3.Text = p.IdProveedor.ToString();
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

        public static int IdProveedorSeleccionada = 0;
        ProveedorBss bssprov = new ProveedorBss();
        private void button3_Click(object sender, EventArgs e)//seleccionar
        {
            ProveedorListarvista fr = new ProveedorListarvista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                PROVEEDOR proveedor = bssprov.ObtenerProveedorIdBss(IdProveedorSeleccionada);
                textBox3.Text = proveedor.Nombre;
            }
        }
    }
}
