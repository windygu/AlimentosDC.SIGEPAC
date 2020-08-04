using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlimentosDC.SIGEPAC.DAL;
using AlimentosDC.SIGEPAC.EN;

namespace AlimentosDC.SIGEPAC.BL
{
    public class PedidoBL
    {
        public static int Guardar(Pedido pPedido)
        {
            return PedidoDAL.Guardar(pPedido);
        }

        public static int Modificar(Pedido pPedido)
        {
            return PedidoDAL.Modificar(pPedido);
        }

        public static int Eliminar(Pedido pPedido)
        {
            return PedidoDAL.Eliminar(pPedido);
        }

        public static List<Pedido> ObtenerTodos()
        {
            return PedidoDAL.ObtenerTodos();
        }

        public static Pedido BuscarPorId(int pId)
        {
            return PedidoDAL.BuscarPorId(pId);
        }

        public static string GenerarNumeroPedido()
        {
            return PedidoDAL.generarNumeroPedido();
        }
    }
}
