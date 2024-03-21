using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAVENTAS.MODELOS
{
    public class USUARIOROL
    {
        public int IdusuarioRol { get; set; }
        public int IdUsario { get; set; }
        public int IdRol { get; set; }
        public DateTime FechaAsigna { get; set; }
        public string Estado { get; set; }
    }
}
