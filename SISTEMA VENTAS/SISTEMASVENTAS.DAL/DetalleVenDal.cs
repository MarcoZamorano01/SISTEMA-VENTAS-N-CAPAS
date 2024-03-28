using SISTEMAVENTAS.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMASVENTAS.DAL
{
    public class DetalleVenDal
    {
        public DataTable ListaDetalleVenDal()
        {
            string cosulta = "select * from detalleventa";
            DataTable Lista = conexion.EjecutarDataTabla(cosulta, "tabla");
            return Lista;
        }
        public DataTable NuevaListaDetalleVenDal()
        {
            string consulta = "SELECT DETALLEVENTA.IDDETALLEVENTA, VENTA.FECHA, PRODUCTO.NOMBRE, \r\n\t\tDETALLEVENTA.CANTIDAD,DETALLEVENTA.PRECIOVENTA, DETALLEVENTA.SUBTOTAL, DETALLEVENTA.ESTADO\r\nFROM DETALLEVENTA \r\nINNER JOIN VENTA ON DETALLEVENTA.IDVENTA = VENTA.IDVENTA \r\nINNER JOIN PRODUCTO ON DETALLEVENTA.IDPRODUCTO = PRODUCTO.IDPRODUCTO\r\n";

            return conexion.EjecutarDataTabla(consulta, "asda");
        }
        public void InsertarDetalleVenDal(DETALLEVENT detallevent)
        {
            string consulta = "insert into detalleventa values('" + detallevent.IdVenta + "'," + "'" + detallevent.IdProducto + "'," + "'" + detallevent.Cantidad + "'," + "'" + detallevent.PrecioVenta + "'," + "'" + detallevent.SubTotal + "'," + "'Exitoso')";
            conexion.Ejecutar(consulta);
        }

        public DETALLEVENT ObtenerDetalleVenId(int Id)
        {
            string consulta = "select * from detalleventa where iddetalleventa=" + Id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            DETALLEVENT detavent = new DETALLEVENT();
            if (tabla.Rows.Count > 0)
            {
                detavent.IdDetalleVenta = Convert.ToInt32(tabla.Rows[0]["IdDetalleVenta"]);
                detavent.IdVenta = Convert.ToInt32(tabla.Rows[0]["IdVenta"]);
                detavent.IdProducto = Convert.ToInt32(tabla.Rows[0]["IdProducto"]);
                detavent.Cantidad = Convert.ToInt32(tabla.Rows[0]["Cantidad"]);
                detavent.PrecioVenta = Convert.ToDecimal(tabla.Rows[0]["PrecioVenta"]); ;
                detavent.SubTotal = Convert.ToDecimal(tabla.Rows[0]["SubTotal"]); ;
                detavent.Estado = tabla.Rows[0]["Estado"].ToString();
            }
            return detavent;
        }
        public void EditarDetalleVenDal(DETALLEVENT detavent)
        {
            string consulta = "update detalleventa set idventa='" + detavent.IdVenta + "'," + "idproducto='" + detavent.IdProducto + "'," + "cantidad='" + detavent.Cantidad + "'," + "precioventa='" + detavent.PrecioVenta + "'," + "subtotal='" + detavent.SubTotal + "' " + "where iddetalleventa=" + detavent.IdDetalleVenta;
            conexion.Ejecutar(consulta);
        }

        public void EliminarDetalleVenDal(int id)
        {
            string consulta = "delete from detalleventa where iddetalleventa=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
