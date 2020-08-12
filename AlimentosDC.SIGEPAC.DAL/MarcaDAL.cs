using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlimentosDC.SIGEPAC.EN;
using System.Data.SqlClient;

namespace AlimentosDC.SIGEPAC.DAL
{
    public class MarcaDAL
    {
        public static int Guardar(Marca pMarca)
        {
            string consulta = @"INSERT INTO Marca (Nombre, Comentario) values (@Nombre, @Comentario)";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Nombre", pMarca.Nombre);
            comando.Parameters.AddWithValue("@Comentario", pMarca.Comentario);
            return ComunDB.EjecutarComando(comando);
        }

        public static int Modificar(Marca pMarca)
        {
            string consulta = @"UPDATE Marca SET Nombre = @Nombre, Comentario = @Comentario WHERE Id = @Id;";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Nombre", pMarca.Nombre);
            comando.Parameters.AddWithValue("@Comentario", pMarca.Comentario);
            comando.Parameters.AddWithValue("@Id", pMarca.Id);
            return ComunDB.EjecutarComando(comando);
        }

        public static int Eliminar(int idMarca)
        {
            string consulta = @"DELETE FROM Marca WHERE Id = @Id;";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", idMarca);
            return ComunDB.EjecutarComando(comando);
        }

        public static List<Marca> ObtenerTodos(string pCondicion = "%")
        {
            string consulta = @"SELECT TOP 500 m.Id, m.Nombre, m.Comentario FROM Marca m WHERE Nombre like CONCAT(@pCondicion, '%') OR 
            Comentario LIKE CONCAT(@pCondicion, '%')";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@pCondicion", pCondicion);
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            List<Marca> listaMarcas = new List<Marca>();
            while (reader.Read())
            {
                Marca marca = new Marca();
                marca.Id = reader.GetInt32(0);
                marca.Nombre = reader.GetString(1);
                marca.Comentario = reader.GetString(2);
                listaMarcas.Add(marca);
            }
            return listaMarcas;
        }

        public static Marca BuscarPorId(int pId)
        {
            string consulta = @"SELECT m.Id, m.Nombre, m.Comentario FROM Marca m WHERE Id = @Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pId);
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            Marca marca = new Marca();
            while (reader.Read())
            {
                marca.Id = reader.GetInt32(0);
                marca.Nombre = reader.GetString(1);
                marca.Comentario = reader.GetString(2);
            }
            return marca;
        }
    }
}
