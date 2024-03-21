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
    public class ProductoBss
    {
        ProductoDal dal = new ProductoDal();
        public DataTable ListaProductoBss()
        {
            return dal.ListaProductoDal();
        }
        public void InsertarProductoBss(PRODUCTO producto)
        {
            dal.InsertarProductoDal(producto);
        }
        public PRODUCTO ObtenerProductoIdBss(int id)
        {
            return dal.ObtenerProductoId(id);
        }
        public void EditarProductoBss(PRODUCTO prod)
        {
            dal.EditarProductoDal(prod);
        }
        public void EliminarProductoBss(int id)
        {
            dal.EliminarProductoDal(id);
        }
    }
}
