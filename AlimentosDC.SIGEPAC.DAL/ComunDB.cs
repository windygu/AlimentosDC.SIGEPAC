using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosDC.SIGEPAC.DAL
{
    public class ComunDB
    {
        const string StrConnection = @"Data Source=ERICK\SQLEXPRESS;Initial Catalog=GestionPedidosAlimentosDC;Integrated Security=True";

        private static SqlConnection ObtenerConexion()
        {
            SqlConnection connection = new SqlConnection(StrConnection);
            connection.Open();
            return connection;
        }

        public static SqlCommand ObtenerComando()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = ObtenerConexion();
            return comando;
        }

        public static int EjecutarComando(SqlCommand pComando)
        {
            int resultado = pComando.ExecuteNonQuery();
            pComando.Connection.Close();
            return resultado;
        }

        public static SqlDataReader EjecutarComandoReader(SqlCommand pComando)
        {
            SqlDataReader reader = pComando.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }
    }
}
