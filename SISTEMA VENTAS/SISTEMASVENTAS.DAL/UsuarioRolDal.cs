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
    }
}

