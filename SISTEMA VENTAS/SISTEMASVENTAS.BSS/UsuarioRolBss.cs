using SISTEMASVENTAS.DAL;
using SISTEMAVENTAS.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMASVENTAS.BSS
{
    public class UsuarioRolBss
    {
        UsuarioRolDal dal = new UsuarioRolDal();
        public DataTable ListaUsuarioRolBss()
        {
            return dal.ListaUsuarioRolDal();
        }
        public void InsertarUsuarioRolBss(USUARIOROL usuariorol)
        {
            dal.InsertarUsuarioRolDal(usuariorol);
        }
        public USUARIOROL ObtenerUsuarioRolIdBss(int id)
        {
            return dal.ObtenerUsuarioRolId(id);
        }
        public void EditarUsuarioRolBss(USUARIOROL usurl)
        {
            dal.EditarUsuarioRolDal(usurl);
        }
        public void EliminarUsuarioRolBss(int id)
        {
            dal.EliminarUsuarioRolDal(id);
        }
    }
}
