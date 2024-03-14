using SISTEMASVENTAS.DAL;
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
    }
}
