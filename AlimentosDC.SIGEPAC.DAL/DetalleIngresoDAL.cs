using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlimentosDC.SIGEPAC.EN;
using System.Data.SqlClient;

namespace AlimentosDC.SIGEPAC.DAL
{
    public class DetalleIngresoDAL
    {
        public static int Guardar(DetalleIngreso pDetalleIngreso)
        {
            string consulta = @"INSERT INTO DetalleIngreso (IdIngreso, IdProducto, Cantidad, PrecioUnitario, SubTotal) 
            VALUES (@IdIngreso, @IdProducto, @Cantidad, @PrecioUnitario, @SubTotal))";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@IdIngreso", pDetalleIngreso.IdIngreso);
            comando.Parameters.AddWithValue("@IdProducto", pDetalleIngreso.IdProducto);
            comando.Parameters.AddWithValue("@Cantidad", pDetalleIngreso.Cantidad);
            comando.Parameters.AddWithValue("@PrecioUnitario", pDetalleIngreso.PrecioUnitario);
            return ComunDB.EjecutarComando(comando);
        }

        public static int Modificar(DetalleIngreso pDetalleIngreso)
        {
            string consulta = @"UPDATE DetalleIngreso SET IdIngreso = @IdIngreso, IdProducto = @IdProducto, Cantidad = @Cantidad, PrecioUnitario = @PrecioUnitario, SubTotal = @SubTotal WHERE Id = @Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@IdIngreso", pDetalleIngreso.IdIngreso);
            comando.Parameters.AddWithValue("@IdProducto", pDetalleIngreso.IdProducto);
            comando.Parameters.AddWithValue("@Cantidad", pDetalleIngreso.Cantidad);
            comando.Parameters.AddWithValue("@PrecioUnitario", pDetalleIngreso.PrecioUnitario);
            comando.Parameters.AddWithValue("@Id", pDetalleIngreso.Id);
            return ComunDB.EjecutarComando(comando);
        }

        public static int Eliminar(int pIdDetalleIngreso, int? pIdIngreso = null)
        {

            string consulta = @"DELETE FROM DetalleIngreso WHERE Id = @Id;";
            if (pIdIngreso != null)
            {
                consulta = @"DELETE FROM DetalleIngreso WHERE IdIngreso = @IdIngreso;";
            }
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            if (pIdIngreso == null) comando.Parameters.AddWithValue("@Id", pIdDetalleIngreso);
            else comando.Parameters.AddWithValue("@IdIngreso", pIdIngreso);
            return ComunDB.EjecutarComando(comando);
        }

        public static List<DetalleIngreso> ObtenerTodos(int pIdIngreso)
        {
            string consulta = string.Concat("SELECT TOP(500) di.Id, di.IdIngreso, di.IdProducto, pr.Nombre Producto, pr.Descripcion, ",
            "di.Cantidad, di.PrecioUnitario, di.SubTotal from DetalleIngreso di JOIN Producto pr on dp.IdProducto = pr.Id where di.IdIngreso = @IdIngreso");
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@pIdIngreso", pIdIngreso);
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            List<DetalleIngreso> listaDetallesIngreso = new List<DetalleIngreso>();
            while (reader.Read())
            {
                DetalleIngreso detalleIngreso = new DetalleIngreso();
                detalleIngreso.Id = reader.GetInt32(0);
                detalleIngreso.IdIngreso = reader.GetInt32(1);
                detalleIngreso.IdProducto = reader.GetInt32(2);
                detalleIngreso.Producto = reader.GetString(3);
                detalleIngreso.Descripcion = reader.GetString(4);
                detalleIngreso.Cantidad = reader.GetInt32(5);
                detalleIngreso.PrecioUnitario = reader.GetDouble(6);
                detalleIngreso.SubTotal = reader.GetDouble(7);
                listaDetallesIngreso.Add(detalleIngreso);
            }
            return listaDetallesIngreso;
        }

        public static DetalleIngreso BuscarPorId(int pId)
        {
            string consulta = string.Concat("SELECT di.Id, di.IdIngreso, di.IdProducto, pr.Nombre Producto, pr.Descripcion, ",
            "di.Cantidad, di.PrecioUnitario, di.SubTotal from DetalleIngreso di JOIN Producto pr on dp.IdProducto = pr.Id WHERE Id = @Id");
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pId);
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            DetalleIngreso detalleIngreso = new DetalleIngreso();
            while (reader.Read())
            {
                detalleIngreso.Id = reader.GetInt32(0);
                detalleIngreso.IdIngreso = reader.GetInt32(1);
                detalleIngreso.IdProducto = reader.GetInt32(2);
                detalleIngreso.Producto = reader.GetString(3);
                detalleIngreso.Descripcion = reader.GetString(4);
                detalleIngreso.Cantidad = reader.GetInt32(5);
                detalleIngreso.PrecioUnitario = reader.GetDouble(6);
                detalleIngreso.SubTotal = reader.GetDouble(7);
            }
            return detalleIngreso;
        }
    }
}
