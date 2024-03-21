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
    public class MarcaBss
    {
        MarcaDal dal = new MarcaDal();
        public DataTable ListaMarcaBss()
        {
            return dal.ListaMarcaDal();
        }
        public void InsertarMarcaBss(MARCA marca)
        {
            dal.InsertarMarcaDal(marca);
        }
        public MARCA ObtenerMarcaIdBss(int id)
        {
            return dal.ObtenerMarcaId(id);
        }
        public void EditarMarcaBss(MARCA mar)
        {
            dal.EditarMarcaDal(mar);
        }
        public void EliminarMarcaBss(int id)
        {
            dal.EliminarMarcaDal(id);
        }
    }
}

