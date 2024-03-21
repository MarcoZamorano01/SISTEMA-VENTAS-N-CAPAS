using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAVENTAS.MODELOS
{
    public class PROVEE
    {
        public int IdProvee { get; set; }
        public int IdProducto { get; set; }
        public int Idproveedor { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Precio { get; set; }
    }
}
