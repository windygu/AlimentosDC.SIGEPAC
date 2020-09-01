using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlimentosDC.SIGEPAC.EN;
using System.Data.SqlClient;

namespace AlimentosDC.SIGEPAC.DAL
{
    public class DetallePedidoDAL
    {
        public static int Guardar(DetallePedido pDetallePedido)
        {
            string consulta = @"INSERT INTO DetallePedido (IdPedido, IdProducto, Cantidad, PrecioUnitario, Estado) 
            values (@IdPedido, @IdProducto, @Cantidad, @PrecioUnitario, @Estado)";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@IdPedido", pDetallePedido.IdPedido);
            comando.Parameters.AddWithValue("@IdProducto", pDetallePedido.IdProducto);
            comando.Parameters.AddWithValue("@Cantidad", (int) pDetallePedido.Cantidad);
            comando.Parameters.AddWithValue("@PrecioUnitario", (decimal) pDetallePedido.PrecioUnitario);
            comando.Parameters.AddWithValue("@Estado", pDetallePedido.Estado);
            return ComunDB.EjecutarComando(comando);
        }

        public static int Modificar(DetallePedido pDetallePedido)
        {
            string consulta = @"UPDATE DetallePedido SET IdPedido = @IdPedido, IdProducto = @IdProducto, Cantidad = @Cantidad, 
            PrecioUnitario = @PrecioUnitario, Estado = @Estado WHERE Id = @Id;";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pDetallePedido.Id);
            comando.Parameters.AddWithValue("@IdPedido", pDetallePedido.IdPedido);
            comando.Parameters.AddWithValue("@IdProducto", pDetallePedido.IdProducto);
            comando.Parameters.AddWithValue("@Cantidad", (int) pDetallePedido.Cantidad);
            comando.Parameters.AddWithValue("@PrecioUnitario", (decimal) pDetallePedido.PrecioUnitario);
            comando.Parameters.AddWithValue("@Estado", pDetallePedido.Estado);
            return ComunDB.EjecutarComando(comando);
        }

        public static int Eliminar(int pDetallePedido, int? idPedido=null)
        {
            
            string consulta = @"DELETE FROM DetallePedido WHERE Id = @Id;";
            if (idPedido!=null)
            {
                consulta = @"DELETE FROM DetallePedido WHERE IdPedido = @IdPedido;";
            }
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            if (idPedido==null) comando.Parameters.AddWithValue("@Id", pDetallePedido);
            else comando.Parameters.AddWithValue("@IdPedido", idPedido);
            return ComunDB.EjecutarComando(comando);
        }

        public static List<DetallePedido> ObtenerTodos(int pIdPedido)
        {
            string consulta = @"select top(500) dp.Id, dp.IdProducto, pr.Nombre Producto, pr.Descripcion, dp.Cantidad, dp.PrecioUnitario, 
            dp.SubTotal, dp.Estado from Producto pr join DetallePedido dp on pr.Id = dp.IdProducto 
            where dp.IdPedido = @IdPedido";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@IdPedido", pIdPedido);
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            List<DetallePedido> listaDetallePedido = new List<DetallePedido>();
            while (reader.Read())
            {
                DetallePedido detallePedido = new DetallePedido();
                detallePedido.Id = reader.GetInt32(0);
                detallePedido.IdProducto = reader.GetInt32(1);
                detallePedido.Producto = reader.GetString(2);
                detallePedido.Descripcion = reader.GetString(3);
                detallePedido.Cantidad = (ushort) reader.GetInt16(4);
                detallePedido.PrecioUnitario = (float) reader.GetDecimal(5);
                detallePedido.SubTotal = (float) reader.GetDecimal(6);
                detallePedido.Estado = reader.GetString(7);
                listaDetallePedido.Add(detallePedido);
            }
            return listaDetallePedido;
        }

        public static DetallePedido BuscarPorId(int pId)
        {
            string consulta = @"SELECT dp.Id, dp.IdPedido, dp.IdProducto, dp.Cantidad, dp.PrecioUnitario, dp.SubTotal, 
            dp.Estado FROM DetallePedido dp WHERE Id = @Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pId);
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            DetallePedido detallePedido = new DetallePedido();
            while (reader.Read())
            {
                detallePedido.Id = reader.GetInt32(0);
                detallePedido.IdPedido = reader.GetInt32(1);
                detallePedido.IdProducto = reader.GetInt32(2);
                detallePedido.Cantidad = (ushort) reader.GetInt16(3);
                detallePedido.PrecioUnitario = reader.GetFloat(4);
                detallePedido.SubTotal = (double)reader.GetDecimal(5);
                detallePedido.Estado = reader.GetString(6);
            }
            return detallePedido;
        }
    }
}
