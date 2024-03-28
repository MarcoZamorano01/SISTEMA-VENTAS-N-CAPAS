using SISTEMAVENTAS.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMASVENTAS.DAL
{
    public class IngresoDal
    {
        public DataTable ListaIngresoDal()
        {
            string cosulta = "select * from ingreso";
            DataTable Lista = conexion.EjecutarDataTabla(cosulta, "tabla");
            return Lista;
        }
        public DataTable NuevaListaIngresoDal()
        {
            string consulta = "SELECT I.IDINGRESO, P.NOMBRE AS NOM_PROVEEDOR, P.DIRECCION, P.TELEFONO, I.FECHAINGRESO, I.TOTAL, I.ESTADO\r\nFROM INGRESO I\r\nINNER JOIN PROVEEDOR P ON P.IDPROVEEDOR = I.IDPROVEEDOR";

            return conexion.EjecutarDataTabla(consulta, "asda");
        }
        public void InsertarIngresoDal(INGRESO ing)
        {
            string consulta = "insert into ingreso values('" + ing.IdProveedor + "','" + ing.FechaIngreso + "'," + "'" + ing.Total +  "'," + "'Activo')";
            conexion.Ejecutar(consulta);
        }

        public INGRESO ObtenerIngresoId(int Id)
        {
            string consulta = "select * from ingreso where idingreso=" + Id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            INGRESO ing = new INGRESO();
            if (tabla.Rows.Count > 0)
            {
                ing.IdIngreso = Convert.ToInt32(tabla.Rows[0]["IdIngreso"]);
                ing.IdProveedor = Convert.ToInt32(tabla.Rows[0]["IdProveedor"]);
                ing.FechaIngreso = Convert.ToDateTime(tabla.Rows[0]["FechaIngreso"]);
                ing.Total = Convert.ToDecimal(tabla.Rows[0]["Total"]);
                ing.Estado = tabla.Rows[0]["Estado"].ToString();
            }
            return ing;
        }
        public void EditarIngresoDal(INGRESO ing)
        {
            string consulta = "update ingreso set idproveedor='" + ing.IdProveedor + "'," + "fechaingreso='" + ing.FechaIngreso + "'," + "total='" + ing.Total + "'," +  "' " + "where idingreso=" + ing.IdIngreso;
            conexion.Ejecutar(consulta);
        } 

        public void EliminarIngresoDal(int id)
        {
            string consulta = "delete from ingreso where idingreso=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
