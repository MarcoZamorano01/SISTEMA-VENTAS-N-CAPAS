using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAVENTAS.MODELOS
{
    public class VENTA
    {
        public string IdVenta { get; set; }
        public string IdCliente { get; set; }
        public string IdVendedor { get; set; }
        public string Fecha { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }

    }
}
