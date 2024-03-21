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
    public class IngresoBss
    {
        IngresoDal dal = new IngresoDal();
        public DataTable ListaIngresoBss()
        {
            return dal.ListaIngresoDal();
        }
        public void InsertarIngresoBss(INGRESO ingreso)
        {
            dal.InsertarIngresoDal(ingreso);
        }
        public INGRESO ObtenerIngresoIdBss(int id)
        {
            return dal.ObtenerIngresoId(id);
        }
        public void EditarIngresoBss(INGRESO ing)
        {
            dal.EditarIngresoDal(ing);
        }
        public void EliminarIngresoBss(int id)
        {
            dal.EliminarIngresoDal(id);
        }
    }
}

