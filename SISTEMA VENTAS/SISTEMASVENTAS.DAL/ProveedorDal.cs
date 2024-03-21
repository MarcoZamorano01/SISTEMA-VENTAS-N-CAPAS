using SISTEMAVENTAS.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMASVENTAS.DAL
{
    public class ProveedorDal
    {
        public DataTable ListaProveedorDal()
        {
            string cosulta = "select * from proveedor";
            DataTable Lista = conexion.EjecutarDataTabla(cosulta, "tabla");
            return Lista;
        }
        public void InsertarProveedorDal(PROVEEDOR proveedor)
        {
            string consulta = "insert into proveedor values('" + proveedor.Nombre + "','" + proveedor.Telefono + "'," + "'" + proveedor.Direccion +  "'," + "'Activo')";
            conexion.Ejecutar(consulta);
        }

        public PROVEEDOR ObtenerProveedorId(int Id)
        {
            string consulta = "select * from proveedor where idproveedor=" + Id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            PROVEEDOR proveedor = new PROVEEDOR();
            if (tabla.Rows.Count > 0)
            {
                proveedor.IdProveedor = Convert.ToInt32(tabla.Rows[0]["IdProveedor"]);
                proveedor.Nombre = tabla.Rows[0]["Nombre"].ToString();
                proveedor.Telefono = tabla.Rows[0]["Telefono"].ToString();
                proveedor.Direccion = tabla.Rows[0]["Direccion"].ToString();
                proveedor.Estado = tabla.Rows[0]["Estado"].ToString();
            }
            return proveedor;
        }
        public void EditarProveedorDal(PROVEEDOR proveedor)
        {
            string consulta = "update proveedor set Nombre='" + proveedor.Nombre + "'," + "Telefono='" + proveedor.Telefono + "'," + "Direccion='" + proveedor.Direccion +  "' " + "where IdProveedor=" + proveedor.IdProveedor;
            conexion.Ejecutar(consulta);
        }

        public void EliminarProveedorDal(int id)
        {
            string consulta = "delete from proveedor where idproveedor=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
