using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlimentosDC.SIGEPAC.DAL;
using AlimentosDC.SIGEPAC.EN;

namespace AlimentosDC.SIGEPAC.BL
{
    public class ClienteBL
    {
        public static int Guardar(Cliente pCliente)
        {
            return ClienteDAL.Guardar(pCliente);
        }

        public static int Modificar(Cliente pCliente)
        {
            return ClienteDAL.Modificar(pCliente);
        }

        public static int Eliminar(int pIdCliente)
        {
            return ClienteDAL.Eliminar(pIdCliente);
        }

        public static List<Cliente> ObtenerTodos(string pCondicion = "%")
        {
            return ClienteDAL.ObtenerTodos(pCondicion);
        }

        public static Cliente BuscarPorId(int pId)
        {
            return ClienteDAL.BuscarPorId(pId);
        }
    }
}
