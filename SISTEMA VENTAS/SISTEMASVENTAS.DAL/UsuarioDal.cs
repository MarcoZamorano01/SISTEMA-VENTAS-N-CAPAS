using SISTEMAVENTAS.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMASVENTAS.DAL
{
    public class UsuarioDal
    {
        public DataTable ListaUsuarioDal()
        {
            string cosulta = "select * from usuario";
            DataTable Lista = conexion.EjecutarDataTabla(cosulta, "tabla");
            return Lista;
        }
        public void InsertarUsuarioDal(USUARIO usua) 
        {
            string consulta = "insert into usuario values('" + usua.IdPersona + "','" + usua.NombreUser + "','" + usua.Contraseña + "','" + usua.FechaReg + "')";
            conexion.Ejecutar(consulta);
        }
        public USUARIO ObtenerUsuarioId(int Id)
        {
            string consulta = "select * from usuario where idusuario=" + Id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            USUARIO usua = new USUARIO();
            if (tabla.Rows.Count > 0)
            {
                usua.IdUsario = Convert.ToInt32(tabla.Rows[0]["IdUsario"]);
                usua.IdPersona = Convert.ToInt32(tabla.Rows[0]["IdPersona"]);
                usua.NombreUser = tabla.Rows[0]["NombreUser"].ToString();
                usua.Contraseña = tabla.Rows[0]["Contraseña"].ToString();
                usua.FechaReg = Convert.ToDateTime(tabla.Rows[0]["FechaReg"]);
            }
            return usua;
        }
        public void EditarUsuarioDal(USUARIO usua)
        {
            string consulta = "update usuario set IdPersona='" + usua.IdPersona + "'," + "NombreUser='" + usua.NombreUser + "'," + "Contraseña='" + usua.Contraseña + "'," + "FechaReg='" + usua.FechaReg + "' " + "where IdUsario=" + usua.IdUsario;
            conexion.Ejecutar(consulta);
        }

        public void EliminarUsuarioDal(int id)
        {
            string consulta = "delete from usuario where idusuario=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
