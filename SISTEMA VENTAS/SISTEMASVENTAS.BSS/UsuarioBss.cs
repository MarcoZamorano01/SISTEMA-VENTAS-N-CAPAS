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
    public class UsuarioBss
    {
        UsuarioDal dal = new UsuarioDal();
        public DataTable ListaUsuarioBss()
        {
            return dal.ListaUsuarioDal();
        }
        public void InsertarUsuarioBss(USUARIO usuario)
        {
            dal.InsertarUsuarioDal(usuario);
        }
        public USUARIO ObtenerUsuarioIdBss(int id)
        {
            return dal.ObtenerUsuarioId(id);
        }
        public void EditarUsuarioBss(USUARIO us)
        {
            dal.EditarUsuarioDal(us);
        }
        public void EliminarUsuarioBss(int id)
        {
            dal.EliminarUsuarioDal(id);
        }
    }
}
