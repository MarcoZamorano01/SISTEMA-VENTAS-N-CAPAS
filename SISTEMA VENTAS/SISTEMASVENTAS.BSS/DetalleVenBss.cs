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
    public class DetalleVenBss
    {
        DetalleVenDal dal = new DetalleVenDal();
        public DataTable ListaDetalleVenBss()
        {
            return dal.ListaDetalleVenDal();
        }
        public void InsertarDetalleVenBss(DETALLEVENT detallevent)
        {
            dal.InsertarDetalleVenDal(detallevent);
        }
        public DETALLEVENT ObtenerDetalleVenIdBss(int id)
        {
            return dal.ObtenerDetalleVenId(id);
        }
        public void EditarDetalleVenBss(DETALLEVENT det)
        {
            dal.EditarDetalleVenDal(det);
        }
        public void EliminarDetalleVenBss(int id)
        {
            dal.EliminarDetalleVenDal(id);
        }
    }
}
