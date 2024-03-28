using SISTEMAVENTAS.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMASVENTAS.DAL
{
    public class TipoProdDal
    {
        public DataTable ListaTipoProdDal()
        {
            string cosulta = "select * from tipoprod";
            DataTable Lista = conexion.EjecutarDataTabla(cosulta, "tabla");
            return Lista;
        }
        public DataTable NuevaListaTipoProdDal()
        {
            string consulta = "SELECT TP.IDTIPOPROD, P.NOMBRE AS PRODUCTO, P.DESCRIPCION,P.UNIDAD,TP.ESTADO\r\nFROM TIPOPROD TP\r\nINNER JOIN PRODUCTO P ON P.IDTIPOPROD = TP.IDTIPOPROD\r\n";

            return conexion.EjecutarDataTabla(consulta, "asda");
        }
        public void InsertarTipoProdDal(TIPOPROD tiprod)
        {
            string consulta = "insert into tipoprod values('" + tiprod.Nombre + "'," + "'Activo')";
            conexion.Ejecutar(consulta);
        }

        public TIPOPROD ObtenerTipoProdId(int Id)
        {
            string consulta = "select * from tipoprod where idtipoprod=" + Id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            TIPOPROD tiprod = new TIPOPROD();
            if (tabla.Rows.Count > 0)
            {
                tiprod.IdTipoProd = Convert.ToInt32(tabla.Rows[0]["IdTipoProd"]);
                tiprod.Nombre = tabla.Rows[0]["Nombre"].ToString();
                tiprod.Estado = tabla.Rows[0]["Estado"].ToString();
            }
            return tiprod;
        }
        public void EditarTipoProdDal(TIPOPROD tiprod)
        {
            string consulta = "update tipoprod set Nombre='" + tiprod.Nombre + "' " + "where IdTipoProd=" + tiprod.IdTipoProd;
            conexion.Ejecutar(consulta);
        }

        public void EliminarTipoProdDal(int id)
        {
            string consulta = "delete from tipoprod where idtipoprod=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
