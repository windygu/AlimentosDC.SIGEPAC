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
            comando.Parameters.AddWithValue("@Id", pPedido.Id);
            comando.Parameters.AddWithValue("@IdCliente", pPedido.IdCliente);
            comando.Parameters.AddWithValue("@NumeroPedido", pPedido.NumeroPedido);
            comando.Parameters.AddWithValue("@FechaCreacion", pPedido.FechaCreacion);
            comando.Parameters.AddWithValue("@FechaEntrega", pPedido.FechaEntrega);
            comando.Parameters.AddWithValue("@DireccionEntrega", pPedido.DireccionEntrega);
            comando.Parameters.AddWithValue("@Estado", pPedido.Estado);
            return ComunDB.EjecutarComando(comando);
        }

        public static int Eliminar(int pIdPedido)
        {
            string consulta = @"DELETE FROM Pedido WHERE Id = @Id;";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pIdPedido);
            return ComunDB.EjecutarComando(comando);
        }

        public static List<Pedido> ObtenerTodos(string pCondicion = "%", string pEstado = "%", int? idCliente = null)
        {
            string consulta = string.Concat("SELECT p.Id, c.PrimerNombre+' '+c.PrimerApellido Cliente, c.Dui, p.NumeroPedido, ", 
            "p.FechaCreacion, p.FechaEntrega, p.DireccionEntrega, p.Estado FROM pedido p JOIN Cliente c ON p.IdCliente = c.Id ",
            "WHERE (p.NumeroPedido LIKE CONCAT(@pCondicion, '%') OR CONCAT(c.PrimerNombre, ' ', c.SegundoNombre, ' ', c.PrimerApellido, ' ', ",
            "c.SegundoApellido) LIKE CONCAT('%', @pCondicion, '%')) AND p.Estado LIKE @pEstado");
            if (idCliente!= null)
            {
                consulta = string.Concat("SELECT TOP(500) p.Id, c.PrimerNombre+' '+c.PrimerApellido ",
                "Cliente, c.Dui, p.NumeroPedido, p.FechaCreacion, p.FechaEntrega, p.DireccionEntrega, p.Estado ",
                "FROM Cliente c JOIN Pedido p ON c.Id = p.IdCliente WHERE p.IdCliente = @idCliente");
            }    
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            if (idCliente != null) comando.Parameters.AddWithValue("@idCliente", idCliente);
            else
            {
                comando.Parameters.AddWithValue("@pCondicion", pCondicion);
                comando.Parameters.AddWithValue("@pEstado", pEstado);
            }
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            List<Pedido> listaPedidos = new List<Pedido>();
            while (reader.Read())
            {
                Pedido pedido = new Pedido();
                pedido.Id = reader.GetInt32(0);
                pedido.Cliente = reader.GetString(1);
                pedido.Dui = reader.GetString(2);
                pedido.NumeroPedido = reader.GetInt32(3);
                pedido.FechaCreacion = reader.GetDateTime(4);
                pedido.FechaEntrega = reader.GetDateTime(5);
                pedido.DireccionEntrega = reader.GetString(6);
                pedido.Estado = reader.GetString(7);
                listaPedidos.Add(pedido);
            }
            return listaPedidos;
        }

        public static Pedido BuscarPorId(int pId)
        {
            string consulta = @"select p.Id, p.IdCliente, CONCAT(c.PrimerNombre, ' ', c.PrimerApellido) Cliente, 
            c.Dui, p.NumeroPedido, p.FechaCreacion, p.FechaEntrega, p.DireccionEntrega, p.Estado 
            from Cliente c join Pedido p on c.Id = p.IdCliente where p.Id = @Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pId);
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            Pedido pedido = new Pedido();
            while (reader.Read())
            {
                pedido.Id = reader.GetInt32(0);
                pedido.IdCliente = reader.GetInt32(1);
                pedido.Cliente = reader.GetString(2);
                pedido.Dui = reader.GetString(3);
                pedido.NumeroPedido = reader.GetInt32(4);
                pedido.FechaCreacion = reader.GetDateTime(5);
                pedido.FechaEntrega = reader.GetDateTime(6);
                pedido.DireccionEntrega = reader.GetString(7);
                pedido.Estado = reader.GetString(8);
            }
            return pedido;
        }

        public static Pedido BuscarPorNumeroPedido(int pNumeroPedido)
        {
            string consulta = @"select p.Id, CONCAT(c.PrimerNombre, ' ', c.PrimerApellido) Cliente, 
            c.Dui, p.NumeroPedido, p.FechaCreacion, p.FechaEntrega, p.DireccionEntrega, p.Estado 
            from Cliente c join Pedido p on c.Id = p.IdCliente where p.NumeroPedido = @NumeroPedido";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@NumeroPedido", pNumeroPedido);
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            Pedido pedido = new Pedido();
            while (reader.Read())
            {
                pedido.Id = reader.GetInt32(0);
                pedido.Cliente = reader.GetString(1);
                pedido.Dui = reader.GetString(2);
                pedido.NumeroPedido = reader.GetInt32(3);
                pedido.FechaCreacion = reader.GetDateTime(4);
                pedido.FechaEntrega = reader.GetDateTime(5);
                pedido.DireccionEntrega = reader.GetString(6);
                pedido.Estado = reader.GetString(7);
            }
            return pedido;
        }

        public static string generarNumeroPedido()
        {
            int numeroPedido = 0;
            string consulta = 
            string.Concat
            ("declare @numeroPedido int\n",
            "if (not exists(select numeroPedido from pedido))\n",
            "begin\n",
            "set @numeroPedido = 1\n",
            "select @numeroPedido\n",
            "end\n",
            "else\n",
            "begin\n",
            "select @numeroPedido = max(numeroPedido) + 1 from Pedido\n",  
            "select @numeroPedido\n",
            "end");
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            while (reader.Read())
            {
                numeroPedido = reader.GetInt32(0);
            }
            
            return numeroPedido.ToString();
        }
    }
}
