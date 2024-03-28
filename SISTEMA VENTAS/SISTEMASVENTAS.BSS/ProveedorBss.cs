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
    public class ProveedorBss
    {
        ProveedorDal dal = new ProveedorDal();
        public DataTable ListaProveedorBss()
        {
            return dal.ListaProveedorDal();
        }
        public DataTable NuevaListaProveedorBss()
        {
            return dal.NuevaListaProveedorDal();
        }
        public void InsertarProveedorBss(PROVEEDOR proveedor)
        {
            dal.InsertarProveedorDal(proveedor);
        }
        public PROVEEDOR ObtenerProveedorIdBss(int id)
        {
            return dal.ObtenerProveedorId(id);
        }
        public void EditarProveedorBss(PROVEEDOR provee)
        {
            dal.EditarProveedorDal(provee);
        }
        public void EliminarProveedorBss(int id)
        {
            dal.EliminarProveedorDal(id);
        }
    }
}
