using SISTEMAVENTAS.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMASVENTAS.DAL
{
    public class VentaDal
    {
        public DataTable ListaVentaDal()
        {
            string cosulta = "select * from venta";
            DataTable Lista = conexion.EjecutarDataTabla(cosulta, "tabla");
            return Lista;
        }
        public DataTable NuevaListaVentaDal()
        {
            string consulta = "";

            return conexion.EjecutarDataTabla(consulta, "asda");
        }

        public void InsertarVentaDal(VENTA ven)
        {
            string consulta = "insert into venta values('" + ven.IdCliente + "','" + ven.IdVendedor + "'," + "'" + ven.Fecha + "','" + ven.Total + "'," + "'Exitoso')";
            conexion.Ejecutar(consulta);
        }

        public VENTA ObtenerVentaId(int Id)
        {
            string consulta = "select * from venta where idventa=" + Id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            VENTA ven = new VENTA();
            if (tabla.Rows.Count > 0)
            {
                ven.IdVenta = Convert.ToInt32(tabla.Rows[0]["IdVenta"]);
                ven.IdCliente = Convert.ToInt32(tabla.Rows[0]["IdCliente"]);
                ven.IdVendedor = Convert.ToInt32(tabla.Rows[0]["IdVendedor"]);
                ven.Fecha = Convert.ToDateTime(tabla.Rows[0]["Fecha"]);
                ven.Total = Convert.ToDecimal(tabla.Rows[0]["Total"]);
                ven.Estado = tabla.Rows[0]["Estado"].ToString();
            }
            return ven;
        }
        public void EditarVentaDal(VENTA ven)
        {
            string consulta = "update venta set IdCliente='" + ven.IdCliente + "'," + "IdVendedor='" + ven.IdVendedor + "'," + "Fecha='" + ven.Fecha + "'," + "Total='" + ven.Total +  "' " + "where IdVenta=" + ven.IdVenta;
            conexion.Ejecutar(consulta);
        }

        public void EliminarVentaDal(int id)
        {
            string consulta = "delete from venta where idventa=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
