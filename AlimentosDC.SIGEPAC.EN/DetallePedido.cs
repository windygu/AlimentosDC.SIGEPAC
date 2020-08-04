using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosDC.SIGEPAC.EN
{
    public class DetallePedido
    {
        public int Id { get; set; }
        public int IdPedido { get; set; }
        public int IdProducto { get; set; }
        public string Producto { get; set; }
        public string Descripcion { get; set; }
        public ushort Cantidad { get; set; }
        public float PrecioUnitario { get; set; }
        public float SubTotal { get; set; }
        public string Estado { get; set; }

    }
}
