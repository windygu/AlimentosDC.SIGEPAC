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

        public static int Eliminar(int pIdPedido)
        {
            return PedidoDAL.Eliminar(pIdPedido);
        }

        public static List<Pedido> ObtenerTodos(string pEstado = "%", string pDatoABuscar = null)
        {
            return PedidoDAL.ObtenerTodos(pEstado, pDatoABuscar);
        }

        public static Pedido BuscarPorId(int pId)
        {
            return PedidoDAL.BuscarPorId(pId);
        }

        public static Pedido BuscarPorNumeroPedido(int pNumeroPedido)
        {
            return PedidoDAL.BuscarPorNumeroPedido(pNumeroPedido);
        }

        public static string GenerarNumeroPedido()
        {
            return PedidoDAL.generarNumeroPedido();
        }
    }
}
