using SISTEMASVENTAS.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMASVENTAS.BSS
{
    public class RolBss
    {
        RolDal dal = new RolDal();
        public DataTable ListaRolBss()
        {
            return dal.ListaRolDal();
        }
    }
}
