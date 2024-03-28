using SISTEMAVENTAS.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMASVENTAS.DAL
{
    public class MarcaDal
    {
        public DataTable ListaMarcaDal()
        {
            string cosulta = "select * from marca";
            DataTable Lista = conexion.EjecutarDataTabla(cosulta, "tabla");
            return Lista;
        }
        public DataTable NuevaListaMarcaDal()
        {
            string consulta = "SELECT M.IDMARCA, M.NOMBRE AS NOMBRE_PROD, P.DESCRIPCION, M.ESTADO\r\nFROM MARCA M\r\nINNER JOIN PRODUCTO P ON P.IDMARCA = M.IDMARCA";

            return conexion.EjecutarDataTabla(consulta, "asda");
        }
        public void InsertarMarcaDal(MARCA marca)
        {
            string consulta = "insert into marca values('" + marca.Nombre + "'," + "'Exitoso')";
            conexion.Ejecutar(consulta);
        }

        public MARCA ObtenerMarcaId(int Id)
        {
            string consulta = "select * from marca where idmarca=" + Id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            MARCA marca = new MARCA();
            if (tabla.Rows.Count > 0)
            {
                marca.IdMarca = Convert.ToInt32(tabla.Rows[0]["IdMarca"]);
                marca.Nombre = tabla.Rows[0]["Nombre"].ToString();
                marca.Estado = tabla.Rows[0]["Estado"].ToString();
            }
            return marca;
        }
        public void EditarMarcaDal(MARCA marca)
        {
            string consulta = "update marca set nombre='" + marca.Nombre +  "' " + "where idmarca=" + marca.IdMarca;
            conexion.Ejecutar(consulta);
        }

        public void EliminarMarcaDal(int id)
        {
            string consulta = "delete from marca where idmarca=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
