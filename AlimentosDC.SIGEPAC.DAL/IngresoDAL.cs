﻿using AlimentosDC.SIGEPAC.EN;
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
            string consulta = @"INSERT INTO Ingreso (IdUsuario, IdMarca, FechaIngreso, NumeroCCF, Sumas) VALUES (@IdUsuario, @IdMarca, @FechaIngreso, @NumeroCCF, @Sumas)";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@IdUsuario", pIngreso.IdUsuario);
            comando.Parameters.AddWithValue("@IdMarca", pIngreso.IdMarca);
            comando.Parameters.AddWithValue("@FechaIngreso", pIngreso.FechaIngreso);
            comando.Parameters.AddWithValue("@NumeroCCF", pIngreso.NumeroCCF);
            comando.Parameters.AddWithValue("@Sumas", (pIngreso.Sumas>0)?pIngreso.Sumas:SqlDouble.Null);
            return ComunDB.EjecutarComando(comando);
        }

        public static int Modificar(Ingreso pIngreso)
        {
            string consulta = string.Concat("UPDATE Ingreso SET IdUsuario = @IdUsuario, IdMarca = @IdMarca, FechaIngreso = @FechaIngreso, ",
            "NumeroCCF = @NumeroCCF, Sumas = @Sumas WHERE Id = @Id");
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@IdUsuario", pIngreso.IdUsuario);
            comando.Parameters.AddWithValue("@IdMarca", pIngreso.IdMarca);
            comando.Parameters.AddWithValue("@FechaIngreso", pIngreso.FechaIngreso);
            comando.Parameters.AddWithValue("@NumeroCCF", pIngreso.NumeroCCF);
            comando.Parameters.AddWithValue("@Sumas", (pIngreso.Sumas>0)?pIngreso.Sumas:SqlDouble.Null);
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
            string consulta = string.Concat("IF ISNUMERIC(@pCondicion)=1 SELECT i.Id, i.IdUsuario, CONCAT(u.Nombres, SPACE(1), u.Apellidos) ",
            "Usuario, i.IdMarca, m.Nombre Marca, i.FechaIngreso, i.NumeroCCF, i.Sumas, i.Iva, i.Total FROM Ingreso i JOIN Usuario u on ",
            "i.IdUsuario = u.Id join Marca m on i.IdMarca = m.Id WHERE CONCAT(u.Nombres, SPACE(1), u.Apellidos) LIKE CONCAT(@pCondicion, '%') ",
            "OR m.Nombre LIKE CONCAT(@pCondicion, '%') OR @pCondicion = DATENAME(MONTH, i.FechaIngreso) OR @pCondicion = DATEPART(YEAR, i.FechaIngreso) ",
            "ELSE SELECT i.Id, i.IdUsuario, CONCAT(u.Nombres, SPACE(1), u.Apellidos) Usuario, i.IdMarca, m.Nombre Marca, i.FechaIngreso, i.NumeroCCF, ",
            "i.Sumas, i.Iva, i.Total FROM Ingreso i JOIN Usuario u on i.IdUsuario = u.Id join Marca m on i.IdMarca = m.Id WHERE CONCAT(u.Nombres, ",
            "SPACE(1), u.Apellidos) LIKE CONCAT(@pCondicion, '%') OR m.Nombre LIKE CONCAT(@pCondicion, '%') OR @pCondicion = DATENAME(MONTH, i.FechaIngreso)");
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@pCondicion", pCondicion);
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            List<Ingreso> listaIngresos = new List<Ingreso>();
            while (reader.Read())
            {
                Ingreso ingreso = new Ingreso();
                ingreso.Id = reader.GetInt32(0);
                ingreso.IdUsuario = reader.GetByte(1);
                ingreso.Usuario = reader.GetString(2);
                ingreso.IdMarca = reader.GetInt32(3);
                ingreso.Marca = reader.GetString(4);
                ingreso.FechaIngreso = reader.GetDateTime(5);
                ingreso.NumeroCCF = reader.GetString(6);
                ingreso.Sumas = (reader[7] != DBNull.Value) ? (double)reader.GetDecimal(7) : 0;
                ingreso.Iva = (reader[8] != DBNull.Value) ? (double)reader.GetDecimal(8) : 0;
                ingreso.Total = (reader[9] != DBNull.Value) ? (double)reader.GetDecimal(9) : 0;
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
                ingreso.Id = reader.GetInt32(0);
                ingreso.IdUsuario = reader.GetByte(1);
                ingreso.Usuario = reader.GetString(2);
                ingreso.IdMarca = reader.GetInt32(3);
                ingreso.Marca = reader.GetString(4);
                ingreso.FechaIngreso = reader.GetDateTime(5);
                ingreso.NumeroCCF = reader.GetString(6);
                ingreso.Sumas = (reader[7] != DBNull.Value) ? (double)reader.GetDecimal(7) : 0;
                ingreso.Iva = (reader[8] != DBNull.Value) ? (double)reader.GetDecimal(8) : 0;
                ingreso.Total = (reader[9] != DBNull.Value) ? (double)reader.GetDecimal(9) : 0;
            }
            return ingreso;
        }

        public static Ingreso BuscarPorNumeroCCF(int pIdMarca, DateTime pFechaIngreso, string pNumeroCCF)
        {
            string consulta = string.Concat("SELECT i.Id, i.IdUsuario, CONCAT(u.Nombres, SPACE(1), u.Apellidos) Usuario, i.IdMarca, m.Nombre ",
            "Marca, i.FechaIngreso, i.NumeroCCF, i.Sumas, i.Iva, i.Total FROM Ingreso i JOIN Usuario u on i.IdUsuario = u.Id join Marca m on i.IdMarca = m.Id ",
            "WHERE i.IdMarca = @IdMarca AND i.FechaIngreso = @FechaIngreso AND i.NumeroCCF = @NumeroCCF");
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@IdMarca", pIdMarca);
            comando.Parameters.AddWithValue("@FechaIngreso", pFechaIngreso.ToShortDateString());
            comando.Parameters.AddWithValue("@NumeroCCF", pNumeroCCF);
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            Ingreso ingreso = new Ingreso();
            while (reader.Read())
            {
                ingreso.Id = reader.GetInt32(0);
                ingreso.IdUsuario = reader.GetByte(1);
                ingreso.Usuario = reader.GetString(2);
                ingreso.IdMarca = reader.GetInt32(3);
                ingreso.Marca = reader.GetString(4);
                ingreso.FechaIngreso = reader.GetDateTime(5);
                ingreso.NumeroCCF = reader.GetString(6);
                ingreso.Sumas = (reader[7] != DBNull.Value) ? (double)reader.GetDecimal(7) : 0;
                ingreso.Iva = (reader[8] != DBNull.Value) ? (double)reader.GetDecimal(8) : 0;
                ingreso.Total = (reader[9] != DBNull.Value) ? (double)reader.GetDecimal(9) : 0;
            }
            return ingreso;
        }
    }
}
