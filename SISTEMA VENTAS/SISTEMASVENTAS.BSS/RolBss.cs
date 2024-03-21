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
    public class RolBss
    {
        RolDal dal = new RolDal();
        public DataTable ListaRolBss()
        {
            return dal.ListaRolDal();
        }
        public void InsertarRolBss(ROL rol)
        {
            dal.InsertarRolDal(rol);
        }
        public ROL ObtenerRolIdBss(int id)
        {
            return dal.ObtenerRolId(id);
        }
        public void EditarRolBss(ROL r)
        {
            dal.EditarRolDal(r);
        }
        public void EliminarRolBss(int id)
        {
            dal.EliminarRolDal(id);
        }
    }
}
