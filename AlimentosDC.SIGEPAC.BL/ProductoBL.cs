using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlimentosDC.SIGEPAC.DAL;
using AlimentosDC.SIGEPAC.EN;

namespace AlimentosDC.SIGEPAC.BL
{
    public class ProductoBL
    {
        public static int Guardar(Producto pProducto)
        {
            return ProductoDAL.Guardar(pProducto);
        }

        public static int Modificar(Producto pProducto)
        {
            return ProductoDAL.Modificar(pProducto);
        }

        public static int Eliminar(int pIdProducto)
        {
            return ProductoDAL.Eliminar(pIdProducto);
        }

        public static List<Producto> ObtenerTodos(string pNombreMarca = "%", string pCondicion = "%", int? pIdMarca = null)
        {
            return ProductoDAL.ObtenerTodos(pNombreMarca, pCondicion, pIdMarca);
        }

        public static Producto BuscarPorId(int pId)
        {
            return ProductoDAL.BuscarPorId(pId);
        }
    }
}
