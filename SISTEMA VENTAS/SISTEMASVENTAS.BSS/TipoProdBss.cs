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
    public class TipoProdBss
    {
        TipoProdDal dal = new TipoProdDal();
        public DataTable ListaTipoProdBss()
        {
            return dal.ListaTipoProdDal();
        }
        public DataTable NuevaListaTipoProdBss()
        {
            return dal.NuevaListaTipoProdDal();
        }
        public void InsertarTipoProdBss(TIPOPROD tipoprod)
        {
            dal.InsertarTipoProdDal(tipoprod);
        }
        public TIPOPROD ObtenerTipoProdIdBss(int id)
        {
            return dal.ObtenerTipoProdId(id);
        }
        public void EditarTipoProdBss(TIPOPROD tp)
        {
            dal.EditarTipoProdDal(tp);
        }
        public void EliminarTipoProdBss(int id)
        {
            dal.EliminarTipoProdDal(id);
        }
    }
}
