using System;
using SISTEMAVENTAS.MODELOS;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SISTEMASVENTAS.DAL
{
    public class PersonaDal
    {
        public DataTable ListaPersonasDal()
        {
            string cosulta = "select * from persona";
            DataTable Lista = conexion.EjecutarDataTabla(cosulta, "tabla");
            return Lista;
        }
        public DataTable NuevaListaPersonaDal()
        {
            string consulta = "SELECT P.IDPERSONA, P.NOMBRE+' '+P.APELLIDO AS NOMBRE,U.NOMBREUSER, U.FECHAREG, \r\nP.TELEFONO, P.CI, P.CORREO,P.ESTADO\r\nFROM PERSONA P\r\nINNER JOIN USUARIO U ON U.IDPERSONA = P.IDPERSONA\r\n";

            return conexion.EjecutarDataTabla(consulta, "asda");
        }
        public void InsertarPersonaDal(PERSONA persona)
        {
            string consulta = "insert into persona values('"+persona.Nombre+ "',"+"'"+persona.Apellido+ "',"+"'" + persona.Telefono+ "',"+"'" + persona.Ci+ "',"+"'" + persona.Correo+ "',"+"'Activo')";
            conexion.Ejecutar(consulta);
        }

        public PERSONA ObtenerPersonaId(int Id)
        {
            string consulta = "select * from persona where idpersona=" + Id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            PERSONA p = new PERSONA();
            if (tabla.Rows.Count>0)
            {
                p.IdPersona = Convert.ToInt32(tabla.Rows[0]["IdPersona"]);
                p.Nombre = tabla.Rows[0]["nombre"].ToString();
                p.Apellido = tabla.Rows[0]["apellido"].ToString();
                p.Telefono = tabla.Rows[0]["telefono"].ToString();
                p.Ci = tabla.Rows[0]["ci"].ToString();
                p.Correo = tabla.Rows[0]["correo"].ToString();
                p.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return p;
        }
        public void EditarPersonaDal(PERSONA p)
        {
            string consulta = "update persona set nombre='" + p.Nombre + "'," + "apellido='" + p.Apellido + "'," + "telefono='" + p.Telefono + "'," + "ci='" + p.Ci + "'," + "correo='" + p.Correo + "' " + "where idpersona=" + p.IdPersona;
            conexion.Ejecutar(consulta);
        }

        public void EliminarPersonaDal(int id)
        {
            string consulta = "delete from persona where idpersona=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}