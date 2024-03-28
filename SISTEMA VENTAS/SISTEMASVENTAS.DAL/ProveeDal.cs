using SISTEMAVENTAS.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMASVENTAS.DAL
{
    public class ProveeDal
    {
        public DataTable ListaProveeDal()
        {
            string cosulta = "select * from provee";
            DataTable Lista = conexion.EjecutarDataTabla(cosulta, "tabla");
            return Lista;
        }
        public DataTable NuevaListaProveeDal()
        {
            string consulta = "SELECT PEE.IDPROVEE, P.NOMBRE AS PRODUCTO,\r\nPEER.NOMBRE AS PROVEEDOR, PEE.FECHA,PEE.PRECIO\r\nFROM PROVEE PEE\r\nINNER JOIN PRODUCTO P ON P.IDPRODUCTO = PEE.IDPRODUCTO\r\nINNER JOIN PROVEEDOR PEER ON PEE.IDPROVEEDOR = PEER.IDPROVEEDOR\r\n";

            return conexion.EjecutarDataTabla(consulta, "asda");
        }
        public void InsertarProveeDal(PROVEE provee)
        {
            string consulta = "insert into provee values('" + provee.IdProducto + "','" + provee.Idproveedor + "','" + provee.Fecha + "','" + provee.Precio + "')";
            conexion.Ejecutar(consulta);
        }

        public PROVEE ObtenerProveeId(int Id)
        {
            string consulta = "select * from provee where idprovee=" + Id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            PROVEE provee = new PROVEE();
            if (tabla.Rows.Count > 0)
            {
                provee.IdProvee = Convert.ToInt32(tabla.Rows[0]["IdProvee"]);
                provee.IdProducto = Convert.ToInt32(tabla.Rows[0]["IdProducto"]);
                provee.Idproveedor = Convert.ToInt32(tabla.Rows[0]["Idproveedor"]);
                provee.Fecha = Convert.ToDateTime(tabla.Rows[0]["Fecha"]);
                provee.Precio = Convert.ToDecimal(tabla.Rows[0]["Precio"]);
            }
            return provee;
        }
        public void EditarProveeDal(PROVEE provee)
        {
            string consulta = "update provee set IdProducto='" + provee.IdProducto + "'," + "Idproveedor='" + provee.Idproveedor + "'," + "Fecha='" + provee.Fecha + "'," + "Precio='" + provee.Precio + "' " + "where idprovee=" + provee.IdProvee;
            conexion.Ejecutar(consulta);
        }

        public void EliminarProveeDal(int id)
        {
            string consulta = "delete from provee where idprovee=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
