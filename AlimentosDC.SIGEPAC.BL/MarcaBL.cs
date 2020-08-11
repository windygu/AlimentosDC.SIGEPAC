using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlimentosDC.SIGEPAC.DAL;
using AlimentosDC.SIGEPAC.EN;

namespace AlimentosDC.SIGEPAC.BL
{
    public class MarcaBL
    {
        public static int Guardar(Marca pMarca)
        {
            return MarcaDAL.Guardar(pMarca);
        }

        public static int Modificar(Marca pMarca)
        {
            return MarcaDAL.Modificar(pMarca);
        }

        public static int Eliminar(Marca pMarca)
        {
            return MarcaDAL.Eliminar(pMarca);
        }

        public static List<Marca> ObtenerTodos()
        {
            return MarcaDAL.ObtenerTodos();
        }

        public static Marca BuscarPorId(int pId)
        {
            return MarcaDAL.BuscarPorId(pId);
        }
    }
}
