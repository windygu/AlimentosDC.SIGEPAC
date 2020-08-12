using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlimentosDC.SIGEPAC.DAL;
using AlimentosDC.SIGEPAC.EN;

namespace AlimentosDC.SIGEPAC.BL
{
    public class DetallePedidoBL
    {
        public static int Guardar(DetallePedido pDetallePedido)
        {
            return DetallePedidoDAL.Guardar(pDetallePedido);
        }

        public static int Modificar(DetallePedido pDetallePedido)
        {
            return DetallePedidoDAL.Modificar(pDetallePedido);
        }

        public static int Eliminar(int pDetallePedido, int? idPedido = null)
        {
            return DetallePedidoDAL.Eliminar(pDetallePedido);
        }

        public static List<DetallePedido> ObtenerTodos(int pIdPedido)
        {
            return DetallePedidoDAL.ObtenerTodos(pIdPedido);
        }

        public static DetallePedido BuscarPorId(int pId)
        {
            return DetallePedidoDAL.BuscarPorId(pId);
        }
    }
}
