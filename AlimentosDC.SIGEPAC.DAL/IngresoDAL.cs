using AlimentosDC.SIGEPAC.EN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosDC.SIGEPAC.DAL
{
    public class IngresoDAL
    {
        public static int Guardar(Ingreso pIngreso)
        {
            string consulta = @"INSERT INTO Ingreso (IdUsuario, IdMarca, FechaIngreso, NumeroCCF, Sumas, Iva, Total) VALUES (@IdUsuario, @IdMarca, @FechaIngreso, @NumeroCCF, @Sumas, @Iva, @Total)";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@IdUsuario", pIngreso.IdUsuario);
            comando.Parameters.AddWithValue("@IdMarca", pIngreso.IdMarca);
            comando.Parameters.AddWithValue("@FechaIngreso", pIngreso.FechaIngreso);
            comando.Parameters.AddWithValue("@NumeroCCF", pIngreso.NumeroCCF);
            comando.Parameters.AddWithValue("@Sumas", (pIngreso.Sumas>0)?pIngreso.Sumas:SqlDouble.Null);
            comando.Parameters.AddWithValue("@Iva", (pIngreso.Iva > 0) ? pIngreso.Iva : SqlDouble.Null);
            comando.Parameters.AddWithValue("@Total", (pIngreso.Total > 0) ? pIngreso.Total : SqlDouble.Null);
            return ComunDB.EjecutarComando(comando);
        }

        public static int Modificar(Ingreso pIngreso)
        {
            string consulta = string.Concat("UPDATE Ingreso SET IdUsuario = @IdUsuario, IdMarca = @IdMarca, FechaIngreso = @FechaIngreso, ",
            "NumeroCCF = @NumeroCCF, Sumas = @Sumas, Iva = @Iva, Total = @Total WHERE Id = @Id");
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@IdUsuario", pIngreso.IdUsuario);
            comando.Parameters.AddWithValue("@IdMarca", pIngreso.IdMarca);
            comando.Parameters.AddWithValue("@FechaIngreso", pIngreso.FechaIngreso);
            comando.Parameters.AddWithValue("@NumeroCCF", pIngreso.NumeroCCF);
            comando.Parameters.AddWithValue("@Sumas", pIngreso.Sumas);
            comando.Parameters.AddWithValue("@Iva", pIngreso.Iva);
            comando.Parameters.AddWithValue("@Total", pIngreso.Total);
            comando.Parameters.AddWithValue("@Id", pIngreso.Id);
            return ComunDB.EjecutarComando(comando);
        }

        public static int Eliminar(int pIdIngreso)
        {
            string consulta = @"DELETE FROM Ingreso WHERE Id = @Id;";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pIdIngreso);
            return ComunDB.EjecutarComando(comando);
        }

        public static List<Ingreso> ObtenerTodos(string pCondicion = "%")
        {
            string consulta = string.Concat("SELECT i.Id, i.IdUsuario, CONCAT(u.Nombres, SPACE(1), u.Apellidos) Usuario, i.IdMarca, m.Nombre ",
            "Marca, i.FechaIngreso, i.NumeroCCF, i.Sumas, i.Iva, i.Total FROM Ingreso i JOIN Usuario u on i.IdUsuario = u.Id join Marca m on i.IdMarca = m.Id ",
            "WHERE(CONCAT(u.Nombres, SPACE(1), u.Apellidos) LIKE CONCAT(@pCondicion, '%') OR m.Nombre LIKE CONCAT(@pCondicion, '%') OR ",
            "@pCondicion = DATENAME(MONTH, i.FechaIngreso) OR @pCondicion = DATEPART(YEAR, i.FechaIngreso)");
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@pCondicion", pCondicion);
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            List<Ingreso> listaIngresos = new List<Ingreso>();
            while (reader.Read())
            {
                Ingreso ingreso = new Ingreso();
                ingreso.Id = reader.GetInt32(1);
                ingreso.IdUsuario = reader.GetByte(2);
                ingreso.Usuario = reader.GetString(3);
                ingreso.IdMarca = reader.GetInt32(4);
                ingreso.Marca = reader.GetString(5);
                ingreso.FechaIngreso = reader.GetDateTime(6);
                ingreso.NumeroCCF = reader.GetString(7);
                ingreso.Sumas = reader.GetDouble(8);
                ingreso.Iva = reader.GetDouble(9);
                ingreso.Total = reader.GetDouble(10);
                listaIngresos.Add(ingreso);
            }
            return listaIngresos;
        }

        public static Ingreso BuscarPorId(int pId)
        {
            string consulta = string.Concat("SELECT i.Id, i.IdUsuario, CONCAT(u.Nombres, SPACE(1), u.Apellidos) Usuario, i.IdMarca, m.Nombre ",
            "Marca, i.FechaIngreso, i.NumeroCCF, i.Sumas, i.Iva, i.Total FROM Ingreso i JOIN Usuario u on i.IdUsuario = u.Id join Marca m on i.IdMarca = m.Id ",
            "WHERE i.Id = @Id");
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pId);
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            Ingreso ingreso = new Ingreso();
            while (reader.Read())
            {
                ingreso.Id = reader.GetInt32(1);
                ingreso.IdUsuario = reader.GetByte(2);
                ingreso.Usuario = reader.GetString(3);
                ingreso.IdMarca = reader.GetInt32(4);
                ingreso.Marca = reader.GetString(5);
                ingreso.FechaIngreso = reader.GetDateTime(6);
                ingreso.NumeroCCF = reader.GetString(7);
                ingreso.Sumas = reader.GetDouble(8);
                ingreso.Iva = reader.GetDouble(9);
                ingreso.Total = reader.GetDouble(10);
            }
            return ingreso;
        }

        public static Ingreso BuscarPorNumeroCCF(int pNumeroCCF)
        {
            string consulta = string.Concat("SELECT i.Id, i.IdUsuario, CONCAT(u.Nombres, SPACE(1), u.Apellidos) Usuario, i.IdMarca, m.Nombre ",
            "Marca, i.FechaIngreso, i.NumeroCCF, i.Sumas, i.Iva, i.Total FROM Ingreso i JOIN Usuario u on i.IdUsuario = u.Id join Marca m on i.IdMarca = m.Id ",
            "WHERE i.NumeroCCF = @NumeroCCF");
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@NumeroCCF", pNumeroCCF);
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            Ingreso ingreso = new Ingreso();
            while (reader.Read())
            {
                ingreso.Id = reader.GetInt32(1);
                ingreso.IdUsuario = reader.GetByte(2);
                ingreso.Usuario = reader.GetString(3);
                ingreso.IdMarca = reader.GetInt32(4);
                ingreso.Marca = reader.GetString(5);
                ingreso.FechaIngreso = reader.GetDateTime(6);
                ingreso.NumeroCCF = reader.GetString(7);
                ingreso.Sumas = reader.GetDouble(8);
                ingreso.Iva = reader.GetDouble(9);
                ingreso.Total = reader.GetDouble(10);
            }
            return ingreso;
        }
    }
}
