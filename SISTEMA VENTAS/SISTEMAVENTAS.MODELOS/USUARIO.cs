using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAVENTAS.MODELOS
{
    public class USUARIO
    {
        public int IdUsario { get; set; }
        public int IdPersona { get; set; }
        public string NombreUser { get; set; }
        public string Contraseña { get; set; }
        public DateTime FechaReg { get; set; }
    }
}
