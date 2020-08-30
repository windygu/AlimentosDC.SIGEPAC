using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlimentosDC.SIGEPAC.DAL;
using AlimentosDC.SIGEPAC.EN;

namespace AlimentosDC.SIGEPAC.BL
{
    public class DetalleIngresoBL
    {
        public static int Guardar(DetalleIngreso pDetalleIngreso)
        {
            return DetalleIngresoDAL.Guardar(pDetalleIngreso);
        }

        public static int Modificar(DetalleIngreso pDetalleIngreso)
        {
            return DetalleIngresoDAL.Modificar(pDetalleIngreso);
        }

        public static int Eliminar(int pIdDetalleIngreso, int? pIdIngreso = null)
        {
            return DetalleIngresoDAL.Eliminar(pIdDetalleIngreso, pIdIngreso);
        }

        public static List<DetalleIngreso> ObtenerTodos(int pIdIngreso)
        {
            return DetalleIngresoDAL.ObtenerTodos(pIdIngreso);
        }

        public static DetalleIngreso BuscarPorId(int pId)
        {
            return DetalleIngresoDAL.BuscarPorId(pId);
        }
    }
}
