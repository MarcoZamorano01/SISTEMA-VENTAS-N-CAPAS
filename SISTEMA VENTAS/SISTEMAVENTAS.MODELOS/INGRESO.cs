using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAVENTAS.MODELOS
{
    public class INGRESO
    {
        public string IdIngreso { get; set; }
        public string IdProveedor { get; set; }
        public string FechaIngreso { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }

    }
}
