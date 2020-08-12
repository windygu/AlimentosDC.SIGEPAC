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
            string consulta = @"INSERT INTO Producto (IdMarca, Nombre, Descripcion, Precio, Stock) 
            values (@IdMarca, @Nombre, @Descripcion, @Precio, @Stock)";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@IdMarca", pProducto.IdMarca);
            comando.Parameters.AddWithValue("@Nombre", pProducto.Nombre);
            comando.Parameters.AddWithValue("@Descripcion", pProducto.Descripcion);
            comando.Parameters.AddWithValue("@Precio", pProducto.Precio);
            comando.Parameters.AddWithValue("@Stock", pProducto.Stock);
            return ComunDB.EjecutarComando(comando);
        }

        public static int Modificar(Producto pProducto)
        {
            string consulta = @"UPDATE Producto SET IdMarca = @IdMarca, Nombre = @Nombre, 
            Descripcion = @Descripcion, Precio = @Precio, Stock = @Stock WHERE Id = @Id;";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pProducto.Id);
            comando.Parameters.AddWithValue("@IdMarca", pProducto.IdMarca);
            comando.Parameters.AddWithValue("@Nombre", pProducto.Nombre);
            comando.Parameters.AddWithValue("@Descripcion", pProducto.Descripcion);
            comando.Parameters.AddWithValue("@Precio", pProducto.Precio);
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

        public static List<Producto> ObtenerTodos(string pCondicion = "%")
        {
            string consulta = string.Concat("SELECT TOP(500) pr.Id, pr.Nombre, pr.Descripcion, m.Nombre Marca, pr.Precio, ",
            "pr.Stock FROM Producto pr JOIN Marca m ON pr.IdMarca = m.Id WHERE pr.Nombre LIKE CONCAT(@pCondicion, '%') ",
            "OR pr.Descripcion LIKE CONCAT(@pCondicion, '%')");
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@pCondicion", pCondicion);
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            List<Producto> listaProductos = new List<Producto>();
            while (reader.Read())
            {
                Producto producto = new Producto();
                producto.Id = reader.GetInt32(0);
                producto.Nombre = reader.GetString(1);
                producto.Descripcion = reader.GetString(2);
                producto.Marca = reader.GetString(3);
                producto.Precio = (float) reader.GetDecimal(4);
                producto.Stock = reader.GetInt32(5);
                listaProductos.Add(producto);
            }
            return listaProductos;
        }

        public static Producto BuscarPorId(int pId)
        {
            string consulta = @"SELECT pr.Id, pr.IdMarca, pr.Nombre, pr.Descripcion, pr.Precio, pr.Stock FROM Producto pr WHERE Id = @Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pId);
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            Producto producto = new Producto();
            while (reader.Read())
            {
                producto.Id = reader.GetInt32(0);
                producto.IdMarca = reader.GetInt32(1);
                producto.Nombre = reader.GetString(2);
                producto.Descripcion = reader.GetString(3);
                producto.Precio = (float) reader.GetDecimal(4);
                producto.Stock = reader.GetInt32(5);
            }
            return producto;

            //Continuar en encontrar el error que no ingresa punto decimal a la BD
        }
    }
}
