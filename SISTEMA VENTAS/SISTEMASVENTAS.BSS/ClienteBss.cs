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
    public class ClienteBss
    {
        ClienteDal dal = new ClienteDal();
        public DataTable ListaClienteBss()
        {
            return dal.ListaClienteDal();
        }
        public DataTable NuevaListaClienteBss()
        {
            return dal.NuevaListaClienteDal();
        }
        public void InsertarClienteBss(CLIENTE cliente)
        {
            dal.InsertarClienteDal(cliente);
        }
        public CLIENTE ObtenerClienteIdBss(int id)
        {
            return dal.ObtenerClienteId(id);
        }
        public void EditarClienteBss(CLIENTE cl)
        {
            dal.EditarClienteDal(cl);
        }
        public void EliminarClienteBss(int id)
        {
            dal.EliminarClienteDal(id);
        }
    }
}
