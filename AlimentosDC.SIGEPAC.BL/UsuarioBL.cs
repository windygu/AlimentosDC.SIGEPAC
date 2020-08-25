using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlimentosDC.SIGEPAC.EN;
using AlimentosDC.SIGEPAC.DAL;

namespace AlimentosDC.SIGEPAC.BL
{
    public class UsuarioBL
    {
        public static int Guardar(Usuario pUsuario)
        {
            return UsuarioDAL.Guardar(pUsuario);
        }

        public static int Modificar(Usuario pUsuario)
        {
            return UsuarioDAL.Modificar(pUsuario);
        }

        public static int Eliminar(int pIdUsuario)
        {
            return UsuarioDAL.Eliminar(pIdUsuario);
        }
        public static Usuario ObtenerUsuario(string pUsuario, string pClave)
        {
            return UsuarioDAL.ObtenerUsuario(pUsuario, pClave);
        }

        public static Usuario BuscarPorId(int pIdUsuario)
        {
            return UsuarioDAL.BuscarPorId(pIdUsuario);
        }

        public static List<Usuario> ObtenerTodos(string pCondicion = "%")
        {
            return UsuarioDAL.ObtenerTodos(pCondicion);
        }
    }
}
