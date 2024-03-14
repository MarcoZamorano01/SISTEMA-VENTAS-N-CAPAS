using SISTEMASVENTAS.DAL;
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
    }
}
