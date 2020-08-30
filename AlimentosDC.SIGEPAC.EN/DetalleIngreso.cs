using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosDC.SIGEPAC.EN
{
    public class DetalleIngreso
    {
        public int Id { get; set; }
        public int IdIngreso { get; set; }
        public int IdProducto { get; set; }
        public string Producto { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; }
        public double SubTotal { get; set; }
    }
}
