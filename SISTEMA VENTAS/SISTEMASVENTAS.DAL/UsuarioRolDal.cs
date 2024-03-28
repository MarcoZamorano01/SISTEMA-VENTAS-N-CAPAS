using SISTEMAVENTAS.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMASVENTAS.DAL
{
    public class UsuarioRolDal
    {
        public DataTable ListaUsuarioRolDal()
        {
            string cosulta = "select * from usuariorol";
            DataTable Lista = conexion.EjecutarDataTabla(cosulta, "tabla");
            return Lista;
        }
        public DataTable NuevaListaUsuarioRolDal()
        {
            string consulta = "SELECT UR.IDUSUARIOROL, U.NOMBREUSER, R.NOMBRE AS ROL,\r\nUR.FECHAASIGNA, UR.ESTADO\r\nFROM USUARIOROL UR\r\nINNER JOIN USUARIO U ON U.IDUSUARIO = UR.IDUSUARIO\r\nINNER JOIN ROL R ON R.IDROL = UR.IDROL\r\n";

            return conexion.EjecutarDataTabla(consulta, "asda");
        }
        public void InsertarUsuarioRolDal(USUARIOROL usuaruiorol)
        {
            string consulta = "insert into usuariorol values('" + usuaruiorol.IdUsario + "','" + usuaruiorol.IdRol + "'," + "'" + usuaruiorol.FechaAsigna + "'," + "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public USUARIOROL ObtenerUsuarioRolId(int Id)
        {
            string consulta = "select * from usuariorol where idusuariorol=" + Id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            USUARIOROL usuaruiorol = new USUARIOROL();
            if (tabla.Rows.Count > 0)
            {
                usuaruiorol.IdusuarioRol = Convert.ToInt32(tabla.Rows[0]["IdusuarioRol"]);
                usuaruiorol.IdUsario = Convert.ToInt32(tabla.Rows[0]["IdUsario"]);
                usuaruiorol.IdRol = Convert.ToInt32(tabla.Rows[0]["IdRol"]);
                usuaruiorol.FechaAsigna = Convert.ToDateTime(tabla.Rows[0]["FechaAsigna"]);
                usuaruiorol.Estado = tabla.Rows[0]["Estado"].ToString();
            }
            return usuaruiorol;
        }
        public void EditarUsuarioRolDal(USUARIOROL usuaruiorol)
        {
            string consulta = "update usuariorol set IdUsario='" + usuaruiorol.IdUsario + "'," + "IdRol='" + usuaruiorol.IdRol + "'," + "FechaAsigna='" + usuaruiorol.FechaAsigna + "' " + "where IdusuarioRol=" + usuaruiorol.IdusuarioRol;
            conexion.Ejecutar(consulta);
        }

        public void EliminarUsuarioRolDal(int id)
        {
            string consulta = "delete from usuariorol where idusuariorol=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}

