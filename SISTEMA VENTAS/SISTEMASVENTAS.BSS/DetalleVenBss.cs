using SISTEMASVENTAS.DAL;
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
    }
}
