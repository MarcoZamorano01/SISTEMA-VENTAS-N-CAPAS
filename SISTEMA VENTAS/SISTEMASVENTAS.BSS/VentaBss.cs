using SISTEMASVENTAS.DAL;
using SISTEMAVENTAS.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMASVENTAS.BSS
{
    public class VentaBss
    {
        VentaDal dal = new VentaDal();
        public DataTable ListaVentaBss()
        {
            return dal.ListaVentaDal();
        }
        public void InsertarVentaBss(VENTA venta)
        {
            dal.InsertarVentaDal(venta);
        }
        public VENTA ObtenerVentaIdBss(int id)
        {
            return dal.ObtenerVentaId(id);
        }
        public void EditarVentaBss(VENTA vt)
        {
            dal.EditarVentaDal(vt);
        }
        public void EliminarVentaBss(int id)
        {
            dal.EliminarVentaDal(id);
        }
    }
}
