using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlimentosDC.SIGEPAC.EN;
using System.Data.SqlClient;

namespace AlimentosDC.SIGEPAC.DAL
{
    public class UsuarioDAL
    {
        public static int Guardar(Usuario pUsuario)
        {
            string consulta = @"INSERT INTO Usuario (Usuario, Clave, StatusAdmin, Imagen) 
            values (@Usuario, @Clave, @StatusAdmin, @Imagen)";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Usuario", pUsuario.Usuario1);
            comando.Parameters.AddWithValue("@Clave", pUsuario.Clave);
            comando.Parameters.AddWithValue("@StatusAdmin", pUsuario.StatusAdmin);
            comando.Parameters.AddWithValue("@Imagen", pUsuario.Imagen);
            return ComunDB.EjecutarComando(comando);
        }

        public static int Modificar(Usuario pUsuario)
        {
            string consulta = @"UPDATE Usuario SET Usuario = @Usuario, Clave = @Clave, StatusAdmin = @StatusAdmin, Imagen = @Imagen
            WHERE Id = @Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pUsuario.Id);
            comando.Parameters.AddWithValue("@Usuario", pUsuario.Usuario1);
            comando.Parameters.AddWithValue("@Clave", pUsuario.Clave);
            comando.Parameters.AddWithValue("@StatusAdmin", pUsuario.StatusAdmin);
            comando.Parameters.AddWithValue("@Imagen", pUsuario.Imagen);
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
            string consulta = @"SELECT * FROM Usuario WHERE Usuario = @pUsuario AND Clave = @pClave";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@pUsuario", pUsuario);
            comando.Parameters.AddWithValue("@pClave", pClave);
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            Usuario usuario = new Usuario();
            while (reader.Read())
            {
                usuario.Id = reader.GetByte(0);
                usuario.Usuario1 = reader.GetString(1);
                usuario.Clave = reader.GetString(2);
                usuario.StatusAdmin = reader.GetBoolean(3);
                usuario.Imagen = (reader[4]!=DBNull.Value)?((byte[])reader[4]):null;
            }
            return usuario;
        }
    }
}
