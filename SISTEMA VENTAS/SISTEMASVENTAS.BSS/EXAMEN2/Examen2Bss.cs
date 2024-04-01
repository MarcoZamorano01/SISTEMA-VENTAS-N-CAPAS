using SISTEMASVENTAS.DAL;
using SISTEMASVENTAS.DAL.EXAMEN2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMASVENTAS.BSS.EXAMEN2
{
    public class Examen2Bss
    {
        Examen2Dal dal = new Examen2Dal();

        public DataTable ListarUnoBss()
        {
            return dal.LitarUnoDal();
        }
        public DataTable ListarDosBss()
        {
            return dal.LitarDosDal();
        }
        public DataTable ListarTresBss()
        {
            return dal.LitarTresDal();
        }
        public DataTable ListarCuatroBss()
        {
            return dal.LitarCuatroDal();
        }
        public DataTable ListarCincoBss()
        {
            return dal.LitarCincoDal();
        }
        public DataTable ListarSeisBss()
        {
            return dal.LitarSeisDal();
        }
        public DataTable ListarSieteBss()
        {
            return dal.LitarSieteDal();
        }
        public DataTable ListarOchoBss()
        {
            return dal.LitarOchoDal();
        }
        public DataTable ListarNueveBss()
        {
            return dal.LitarNueveDal();
        }
        public DataTable ListarDiezBss()
        {
            return dal.LitarDiezDal();
        }
    }
}
