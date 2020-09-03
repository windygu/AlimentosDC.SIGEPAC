using AlimentosDC.SIGEPAC.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlimentosDC.SIGEPAC.DAL;

namespace AlimentosDC.SIGEPAC.BL
{
    public class IngresoBL
    {
        public static int Guardar(Ingreso pIngreso)
        {
            return IngresoDAL.Guardar(pIngreso);
        }

        public static int Modificar(Ingreso pIngreso)
        {
            return IngresoDAL.Modificar(pIngreso);
        }

        public static int Eliminar(int pIdIngreso)
        {
            return IngresoDAL.Eliminar(pIdIngreso);
        }

        public static List<Ingreso> ObtenerTodos(string pCondicion = "%")
        {
            return IngresoDAL.ObtenerTodos(pCondicion);
        }

        public static Ingreso BuscarPorId(int pId)
        {
            return IngresoDAL.BuscarPorId(pId);
        }

        public static Ingreso BuscarPorNumeroCCF(int pIdMarca, DateTime pFechaIngreso, string pNumeroCCF)
        {
            return IngresoDAL.BuscarPorNumeroCCF(pIdMarca, pFechaIngreso, pNumeroCCF);
        }
    }
}
