using SISTEMAVENTAS.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMASVENTAS.DAL
{
    public class ProductoDal
    {
        public DataTable ListaProductoDal()
        {
            string cosulta = "select * from producto";
            DataTable Lista = conexion.EjecutarDataTabla(cosulta, "tabla");
            return Lista;
        }
        public DataTable NuevaListaProductoDal()
        {
            string consulta = "SELECT P.IDPRODUCTO, TP.NOMBRE AS TIPOPRODUCTO, M.NOMBRE AS MARCA, \r\nP.NOMBRE, P.CODIGOBARRA,P.UNIDAD,P.DESCRIPCION,P.ESTADO\r\nFROM PRODUCTO P \r\nINNER JOIN TIPOPROD TP ON TP.IDTIPOPROD = P.IDTIPOPROD\r\nINNER JOIN MARCA M ON M.IDMARCA = P.IDMARCA";

            return conexion.EjecutarDataTabla(consulta, "asda");
        }
        public void InsertarProductoDal(PRODUCTO produc)
        {
            string consulta = "insert into producto values('" + produc.IdTipoProducto + "','" + produc.IdMarca + "'," + "'" + produc.Nombre + "','" + produc.CodigoBarra + "','" + produc.Unidad + "','" + produc.Descripcion +  "'," + "'Activo')";
            conexion.Ejecutar(consulta);
        }

        public PRODUCTO ObtenerProductoId(int Id)
        {
            string consulta = "select * from producto where idproducto=" + Id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            PRODUCTO produc = new PRODUCTO();
            if (tabla.Rows.Count > 0)
            {
                produc.IdProducto = Convert.ToInt32(tabla.Rows[0]["IdProducto"]);
                produc.IdTipoProducto = Convert.ToInt32(tabla.Rows[0]["IdTipoProducto"]);
                produc.IdMarca = Convert.ToInt32(tabla.Rows[0]["IdMarca"]);
                produc.Nombre = tabla.Rows[0]["Nombre"].ToString();
                produc.CodigoBarra = tabla.Rows[0]["CodigoBarra"].ToString();
                produc.Unidad = Convert.ToInt32(tabla.Rows[0]["Unidad"]);
                produc.Descripcion = tabla.Rows[0]["Descripcion"].ToString();
                produc.Estado = tabla.Rows[0]["Estado"].ToString();
            }
            return produc;
        }
        public void EditarProductoDal(PRODUCTO produc)
        {
            string consulta = "update producto set IdTipoProducto='" + produc.IdTipoProducto + "'," + "IdMarca='" + produc.IdMarca + "'," + "Nombre='" + produc.Nombre + "'," + "CodigoBarra='" + produc.CodigoBarra + "'," + "Unidad='" + produc.Unidad + "'," + "Descripcion='" + produc.Descripcion +  "' " + "where idproducto=" + produc.IdProducto;
            conexion.Ejecutar(consulta);
        }

        public void EliminarProductoDal(int id)
        {
            string consulta = "delete from producto where idproducto=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
