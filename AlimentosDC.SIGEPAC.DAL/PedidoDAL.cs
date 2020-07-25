using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlimentosDC.SIGEPAC.EN;
using System.Data.SqlClient;

namespace AlimentosDC.SIGEPAC.DAL
{
    public class PedidoDAL
    {
        public static int Guardar(Pedido pPedido)
        {
            string consulta = @"INSERT INTO Pedido (IdCliente, NumeroPedido, FechaCreacion, FechaEntrega, DireccionEntrega, Estado) 
            values (@IdCliente, @NumeroPedido, @FechaCreacion, @FechaEntrega, @DireccionEntrega, @Estado)";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@IdCliente", pPedido.IdCliente);
            comando.Parameters.AddWithValue("@NumeroPedido", pPedido.NumeroPedido);
            comando.Parameters.AddWithValue("@FechaCreacion", pPedido.FechaCreacion);
            comando.Parameters.AddWithValue("@FechaEntrega", pPedido.FechaEntrega);
            comando.Parameters.AddWithValue("@DireccionEntrega", pPedido.DireccionEntrega);
            comando.Parameters.AddWithValue("@Estado", pPedido.Estado);
            return ComunDB.EjecutarComando(comando);
        }

        public static int Modificar(Pedido pPedido)
        {
            string consulta = @"UPDATE Pedido SET IdCliente = @IdCliente, NumeroPedido = @NumeroPedido, 
            FechaCreacion = @FechaCreacion, FechaEntrega = @FechaEntrega, DireccionEntrega = @DireccionEntrega, 
            Estado = @Estado WHERE Id = @Id;";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@IdCliente", pPedido.IdCliente);
            comando.Parameters.AddWithValue("@NumeroPedido", pPedido.NumeroPedido);
            comando.Parameters.AddWithValue("@FechaCreacion", pPedido.FechaCreacion);
            comando.Parameters.AddWithValue("@FechaEntrega", pPedido.FechaEntrega);
            comando.Parameters.AddWithValue("@DireccionEntrega", pPedido.DireccionEntrega);
            comando.Parameters.AddWithValue("@Estado", pPedido.Estado);
            return ComunDB.EjecutarComando(comando);
        }

        public static int Eliminar(Pedido pPedido)
        {
            string consulta = @"DELETE FROM Pedido WHERE Id = @Id;";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pPedido.Id);
            return ComunDB.EjecutarComando(comando);
        }

        public static List<Pedido> ObtenerTodos()
        {
            string consulta = @"SELECT TOP 500 p.Id, p.IdCliente, p.NumeroPedido, p.FechaCreacion, p.FechaEntrega, p.DireccionEntrega, 
            p.Estado FROM Pedido p";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            List<Pedido> listaPedidos = new List<Pedido>();
            while (reader.Read())
            {
                Pedido pedido = new Pedido();
                pedido.Id = reader.GetInt32(0);
                pedido.IdCliente = reader.GetInt32(1);
                pedido.NumeroPedido = reader.GetInt32(2);
                pedido.FechaCreacion = reader.GetDateTime(3);
                pedido.FechaEntrega = reader.GetDateTime(4);
                pedido.DireccionEntrega = reader.GetString(5);
                pedido.Estado = reader.GetString(6);
                listaPedidos.Add(pedido);
            }
            return listaPedidos;
        }

        public static Pedido BuscarPorId(int pId)
        {
            string consulta = @"SELECT p.Id, p.IdCliente, p.NumeroPedido, p.FechaCreacion, p.FechaEntrega, p.DireccionEntrega, 
            p.Estado FROM Pedido p WHERE Id = @Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pId);
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            Pedido pedido = new Pedido();
            while (reader.Read())
            {
                pedido.Id = reader.GetInt32(0);
                pedido.IdCliente = reader.GetInt32(1);
                pedido.NumeroPedido = reader.GetInt32(2);
                pedido.FechaCreacion = reader.GetDateTime(3);
                pedido.FechaEntrega = reader.GetDateTime(4);
                pedido.DireccionEntrega = reader.GetString(5);
                pedido.Estado = reader.GetString(6);
            }
            return pedido;
        }
    }
}
