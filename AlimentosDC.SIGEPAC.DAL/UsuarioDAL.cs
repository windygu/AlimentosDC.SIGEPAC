﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlimentosDC.SIGEPAC.EN;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using System.Data;
using System.Data.SqlTypes;

namespace AlimentosDC.SIGEPAC.DAL
{
    public class UsuarioDAL
    {
        public static int Guardar(Usuario pUsuario)
        {
            string consulta = @"INSERT INTO Usuario (Nombres, Apellidos, NombreUsuario, Clave, StatusAdministrador, Imagen) 
            values (@Nombres, @Apellidos, @NombreUsuario, @Clave, @StatusAdministrador, @Imagen)";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Nombres", pUsuario.Nombres);
            comando.Parameters.AddWithValue("@Apellidos", pUsuario.Apellidos);
            comando.Parameters.AddWithValue("@NombreUsuario", pUsuario.NombreUsuario);
            comando.Parameters.AddWithValue("@Clave", pUsuario.Clave);
            comando.Parameters.AddWithValue("@StatusAdministrador", pUsuario.StatusAdmin);
            comando.Parameters.AddWithValue("@Imagen", (pUsuario.Imagen==null)?SqlBinary.Null:pUsuario.Imagen);
            return ComunDB.EjecutarComando(comando);
        }

        public static int Modificar(Usuario pUsuario)
        {
            string consulta = string.Concat("UPDATE Usuario SET Nombres = @Nombres, Apellidos = @Apellidos, NombreUsuario = @NombreUsuario, ",
            "Clave = @Clave, StatusAdministrador = @StatusAdministrador, Imagen = @Imagen WHERE Id = @Id");
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pUsuario.Id);
            comando.Parameters.AddWithValue("@Nombres", pUsuario.Nombres);
            comando.Parameters.AddWithValue("@Apellidos", pUsuario.Apellidos);
            comando.Parameters.AddWithValue("@NombreUsuario", pUsuario.NombreUsuario);
            comando.Parameters.AddWithValue("@Clave", pUsuario.Clave);
            comando.Parameters.AddWithValue("@StatusAdministrador", pUsuario.StatusAdmin);
            comando.Parameters.AddWithValue("@Imagen", (pUsuario.Imagen == null) ? SqlBinary.Null : pUsuario.Imagen);
            return ComunDB.EjecutarComando(comando);
        }

        public static int Eliminar(int pIdUsuario)
        {
            string consulta = @"DELETE FROM Usuario WHERE Id = @Id;";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pIdUsuario);
            return ComunDB.EjecutarComando(comando);
        }
        public static Usuario ObtenerUsuario(string pUsuario, string pClave)
        {
            string consulta = @"SELECT * FROM Usuario WHERE NombreUsuario = @NombreUsuario AND Clave = @Clave";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@NombreUsuario", pUsuario);
            comando.Parameters.AddWithValue("@Clave", pClave);
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            Usuario usuario = new Usuario();
            while (reader.Read())
            {
                usuario.Id = reader.GetByte(0);
                usuario.Nombres = reader.GetString(1);
                usuario.Apellidos = reader.GetString(2);
                usuario.NombreUsuario = reader.GetString(3);
                usuario.Clave = reader.GetString(4);
                usuario.StatusAdmin = reader.GetBoolean(5);
                usuario.Imagen = (reader[6]!=DBNull.Value)?((byte[])reader[6]):null;
            }
            return usuario;
        }

        public static Usuario BuscarPorId(int pIdUsuario)
        {
            string consulta = @"SELECT * FROM Usuario WHERE Id = @Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pIdUsuario);
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            Usuario usuario = new Usuario();
            while (reader.Read())
            {
                usuario.Id = reader.GetByte(0);
                usuario.Nombres = reader.GetString(1);
                usuario.Apellidos = reader.GetString(2);
                usuario.NombreUsuario = reader.GetString(3);
                usuario.Clave = reader.GetString(4);
                usuario.StatusAdmin = reader.GetBoolean(5);
                usuario.Imagen = (reader[6] != DBNull.Value) ? ((byte[])reader[6]) : null;
            }
            return usuario;
        }
        public static List<Usuario> ObtenerTodos(string pCondicion = "%")
        {
            string consulta = string.Concat("SELECT u.Id, u.Nombres, u.Apellidos, u.NombreUsuario, u.Clave, u.StatusAdministrador, ",
            "u.Imagen FROM Usuario u WHERE u.Nombres LIKE CONCAT(@pCondicion, '%') OR u.Apellidos LIKE CONCAT(@pCondicion, '%') OR ",
            "u.NombreUsuario LIKE CONCAT(@pCondicion, '%')");
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@pCondicion", pCondicion);
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            List<Usuario> listadoUsuarios = new List<Usuario>();
            while (reader.Read())
            {
                Usuario usuario = new Usuario();
                usuario.Id = reader.GetByte(0);
                usuario.Nombres = reader.GetString(1);
                usuario.Apellidos = reader.GetString(2);
                usuario.NombreUsuario = reader.GetString(3);
                usuario.Clave = reader.GetString(4);
                usuario.StatusAdmin = reader.GetBoolean(5);
                usuario.Imagen = (reader[6] != DBNull.Value) ? ((byte[])reader[6]) : null;
                listadoUsuarios.Add(usuario);
            }
            return listadoUsuarios;
        }
    }
}

//Finalizado solo falta colocar en rojo los stock en la tabla de Productos cuando el stock alcanza
//El stock minimo
