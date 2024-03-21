using SISTEMAVENTAS.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMASVENTAS.DAL
{
    public class RolDal
    {
        public DataTable ListaRolDal()
        {
            string cosulta = "select * from rol";
            DataTable Lista = conexion.EjecutarDataTabla(cosulta, "tabla");
            return Lista;
        }
        public void InsertarRolDal(ROL r)
        {
            string consulta = "insert into rol values('" + r.Nombre + "'," + "'Activo')";
            conexion.Ejecutar(consulta);
        }

        public ROL ObtenerRolId(int Id)
        {
            string consulta = "select * from rol where idrol=" + Id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            ROL r = new ROL();
            if (tabla.Rows.Count > 0)
            {
                r.IdRol = Convert.ToInt32(tabla.Rows[0]["IdRol"]);
                r.Nombre = tabla.Rows[0]["Nombre"].ToString();
                r.Estado = tabla.Rows[0]["Estado"].ToString();
            }
            return r;
        }
        public void EditarRolDal(ROL r)
        {
            string consulta = "update rol set Nombre='" + r.Nombre + "' " + "where IdRol=" + r.IdRol;
            conexion.Ejecutar(consulta);
        }

        public void EliminarRolDal(int id)
        {
            string consulta = "delete from rol where idrol=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
