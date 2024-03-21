using SISTEMAVENTAS.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMASVENTAS.DAL
{
    public class DetallelngDal
    {
        public DataTable ListaDetallelngDal()
        {
            string cosulta = "select * from detalleing";
            DataTable Lista = conexion.EjecutarDataTabla(cosulta, "tabla");
            return Lista;
        }
        public void InsertarDetalleIngDal(DETALLEING detalleing)
        {
            string consulta = "insert into detalleing values('" + detalleing.IdIngreso + "','" + detalleing.IdProducto + "'," + "'" + detalleing.FechaVenc + "','" + detalleing.Cantidad + "','" + detalleing.PrecioCosto + "','" + detalleing.PrecioVenta + "','" + detalleing.SubTotal + "'," + "'Exitoso')";
            conexion.Ejecutar(consulta);
        }

        public DETALLEING ObtenerDetalleIngId(int Id)
        {
            string consulta = "select * from detalleing where iddetalleing=" + Id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            DETALLEING Deting = new DETALLEING();
            if (tabla.Rows.Count > 0)
            {
                Deting.IdDetalleIng = Convert.ToInt32(tabla.Rows[0]["IdDetalleIng"]);
                Deting.IdIngreso = Convert.ToInt32(tabla.Rows[0]["IdIngreso"]);
                Deting.IdProducto = Convert.ToInt32(tabla.Rows[0]["IdProducto"]);
                Deting.FechaVenc = Convert.ToDateTime(tabla.Rows[0]["FechaVenc"]);
                Deting.Cantidad = Convert.ToInt32(tabla.Rows[0]["Cantidad"]);
                Deting.PrecioCosto = Convert.ToDecimal(tabla.Rows[0]["PrecioCosto"]);
                Deting.PrecioVenta = Convert.ToDecimal(tabla.Rows[0]["PrecioVenta"]);
                Deting.SubTotal = Convert.ToDecimal(tabla.Rows[0]["SubTotal"]);
                Deting.Estado = tabla.Rows[0]["Estado"].ToString();
            }
            return Deting;
        }
        public void EditarDetalleIngDal(DETALLEING detalleing)
        {
            string consulta = "update detalleing set idingreso='" + detalleing.IdIngreso + "'," + "idproducto='" + detalleing.IdProducto + "'," + "fechavenc='" + detalleing.FechaVenc + "'," + "cantidad='" + detalleing.Cantidad + "'," + "preciocosto='" + detalleing.PrecioCosto + "'," + "precioventa='" + detalleing.PrecioVenta + "'," + "subtotal='" + detalleing.SubTotal + "' " + "where iddetalleing=" + detalleing.IdDetalleIng;
            conexion.Ejecutar(consulta);
        }

        public void EliminarDetalleIngDal(int id)
        {
            string consulta = "delete from detelleing where iddetalleing=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
