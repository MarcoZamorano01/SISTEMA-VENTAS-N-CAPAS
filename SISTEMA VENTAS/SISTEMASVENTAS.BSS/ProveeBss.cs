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
    public class ProveeBss
    {
        ProveeDal dal = new ProveeDal();
        public DataTable ListaProveeBss()
        {
            return dal.ListaProveeDal();
        }
        public void InsertarProveeBss(PROVEE provee)
        {
            dal.InsertarProveeDal(provee);
        }
        public PROVEE ObtenerProveeIdBss(int id)
        {
            return dal.ObtenerProveeId(id);
        }
        public void EditarProveeBss(PROVEE prvee)
        {
            dal.EditarProveeDal(prvee);
        }
        public void EliminarProveeBss(int id)
        {
            dal.EliminarProveeDal(id);
        }
    }
}
