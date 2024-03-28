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
    public class DetallelngBss
    {
        DetallelngDal dal = new DetallelngDal();
        public DataTable ListaDetallelngBss()
        {
            return dal.ListaDetallelngDal();
        }
        public DataTable NuevaListaDetealleIngBss()
        {
            return dal.NuevaListaDetalleIngDal();
        }
        public void InsertarDetalleIngBss(DETALLEING detalleing)
        {
            dal.InsertarDetalleIngDal(detalleing);
        }
        public DETALLEING ObtenerDetalleIngIdBss(int id)
        {
            return dal.ObtenerDetalleIngId(id);
        }
        public void EditarDetalleIngBss(DETALLEING detalleing)
        {
            dal.EditarDetalleIngDal(detalleing);
        }
        public void EliminarDetalleIngBss(int id)
        {
            dal.EliminarDetalleIngDal(id);
        }
    }
}

