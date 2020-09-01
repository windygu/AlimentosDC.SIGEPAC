using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlimentosDC.SIGEPAC.EN;
using System.Data.SqlClient;

namespace AlimentosDC.SIGEPAC.DAL
{
    public class ProductoDAL
    {
        public static int Guardar(Producto pProducto)
        {
            string consulta = @"INSERT INTO Producto (IdMarca, Nombre, Descripcion, PrecioCompra, PrecioVenta, Stock) 
            values (@IdMarca, @Nombre, @Descripcion, @PrecioCompra, @PrecioVenta, @Stock)";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@IdMarca", pProducto.IdMarca);
            comando.Parameters.AddWithValue("@Nombre", pProducto.Nombre);
            comando.Parameters.AddWithValue("@Descripcion", pProducto.Descripcion);
            comando.Parameters.AddWithValue("@PrecioCompra", pProducto.PrecioCompra);
            comando.Parameters.AddWithValue("@PrecioVenta", pProducto.PrecioVenta);
            comando.Parameters.AddWithValue("@Stock", pProducto.Stock);
            return ComunDB.EjecutarComando(comando);
        }

        public static int Modificar(Producto pProducto)
        {
            string consulta = @"UPDATE Producto SET IdMarca = @IdMarca, Nombre = @Nombre, 
            Descripcion = @Descripcion, PrecioCompra = @PrecioCompra, PrecioVenta = @PrecioVenta, Stock = @Stock WHERE Id = @Id;";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pProducto.Id);
            comando.Parameters.AddWithValue("@IdMarca", pProducto.IdMarca);
            comando.Parameters.AddWithValue("@Nombre", pProducto.Nombre);
            comando.Parameters.AddWithValue("@Descripcion", pProducto.Descripcion);
            comando.Parameters.AddWithValue("@PrecioCompra", pProducto.PrecioCompra);
            comando.Parameters.AddWithValue("@PrecioVenta", pProducto.PrecioVenta);
            comando.Parameters.AddWithValue("@Stock", pProducto.Stock);
            return ComunDB.EjecutarComando(comando);
        }

        public static int Eliminar(int pIdProducto)
        {
            string consulta = @"DELETE FROM Producto WHERE Id = @Id;";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pIdProducto);
            return ComunDB.EjecutarComando(comando);
        }

        public static List<Producto> ObtenerTodos(string pNombreMarca = "%", string pCondicion = "%", int? pIdMarca = null)
        {
            string consulta = string.Concat("SELECT TOP(500) pr.Id, pr.Nombre, pr.Descripcion, pr.IdMarca, m.Nombre Marca, pr.PrecioCompra, pr.PrecioVenta, ",
            "pr.Stock FROM Producto pr JOIN Marca m ON pr.IdMarca = m.Id WHERE (pr.Nombre LIKE CONCAT(@pCondicion, '%') ",
            "OR pr.Descripcion LIKE CONCAT(@pCondicion, '%')) AND m.Nombre LIKE @NombreMarca");
            if (pNombreMarca == "- Todas -") pNombreMarca = "%";
            if (pIdMarca!=null) consulta = "SELECT * FROM Producto WHERE IdMarca = @IdMarca";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            if (pIdMarca != null) comando.Parameters.AddWithValue("@IdMarca", pIdMarca);
            else
            {
                comando.Parameters.AddWithValue("@NombreMarca", pNombreMarca);
                comando.Parameters.AddWithValue("@pCondicion", pCondicion);
            }
            
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            List<Producto> listaProductos = new List<Producto>();
            while (reader.Read())
            {
                Producto producto = new Producto();
                producto.Id = reader.GetInt32(0);
                producto.Nombre = reader.GetString(1);
                producto.Descripcion = reader.GetString(2);
                producto.IdMarca = reader.GetInt32(3);
                producto.Marca = reader.GetString(4);
                producto.PrecioCompra = (double)reader.GetDecimal(5);
                producto.PrecioVenta = (double)reader.GetDecimal(6);
                producto.Stock = reader.GetInt32(7);
                listaProductos.Add(producto);
            }
            return listaProductos;
        }

        public static Producto BuscarPorId(int pId)
        {
            string consulta = string.Concat("SELECT pr.Id, pr.Nombre, pr.Descripcion, pr.IdMarca, m.Nombre Marca, pr.PrecioCompra, pr.PrecioVenta, pr.Stock ",
                "FROM Producto pr JOIN Marca m ON pr.IdMarca = m.Id WHERE pr.Id = @Id");
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pId);
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            Producto producto = new Producto();
            while (reader.Read())
            {
                producto.Id = reader.GetInt32(0);
                producto.Nombre = reader.GetString(1);
                producto.Descripcion = reader.GetString(2);
                producto.IdMarca = reader.GetInt32(3);
                producto.Marca = reader.GetString(4);
                producto.PrecioCompra = (double)reader.GetDecimal(5);
                producto.PrecioVenta = (double)reader.GetDecimal(6);
                producto.Stock = reader.GetInt32(7);
            }
            return producto;
        }
    }
}
