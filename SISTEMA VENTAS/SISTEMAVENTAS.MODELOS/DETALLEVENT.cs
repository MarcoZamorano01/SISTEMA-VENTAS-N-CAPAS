using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAVENTAS.MODELOS
{
    public class DETALLEVENT
    {
        public string IdDetalleVent { get; set; }
        public string IdVenta { get; set; }
        public string IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal SubTotal { get; set; }
        public string Estado { get; set; }
    }
}
