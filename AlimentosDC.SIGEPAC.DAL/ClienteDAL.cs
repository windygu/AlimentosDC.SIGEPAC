using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlimentosDC.SIGEPAC.EN;
using System.Data.SqlClient;

namespace AlimentosDC.SIGEPAC.DAL
{
    public class ClienteDAL
    {
        public static int Guardar(Cliente pCliente)
        {
            string consulta = @"INSERT INTO Cliente (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Dui, Direccion, 
            Telefono, Correo) values (@PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, @Dui, @Direccion, 
            @Telefono, @Correo)";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@PrimerNombre", pCliente.PrimerNombre);
            comando.Parameters.AddWithValue("@SegundoNombre", pCliente.SegundoNombre);
            comando.Parameters.AddWithValue("@PrimerApellido", pCliente.PrimerApellido);
            comando.Parameters.AddWithValue("@SegundoApellido", pCliente.SegundoApellido);
            comando.Parameters.AddWithValue("@Dui", pCliente.DUI);
            comando.Parameters.AddWithValue("@Direccion", pCliente.Direccion);
            comando.Parameters.AddWithValue("@Telefono", pCliente.Telefono);
            comando.Parameters.AddWithValue("@Correo", pCliente.Correo);
            return ComunDB.EjecutarComando(comando);
        }

        public static int Modificar(Cliente pCliente)
        {
            string consulta = @"UPDATE Cliente SET PrimerNombre = @PrimerNombre, SegundoNombre = @SegundoNombre, 
            PrimerApellido = @PrimerApellido, SegundoApellido = @SegundoApellido, Dui = @Dui, Direccion = @Direccion, 
            Telefono = @Telefono, Correo = @Correo WHERE Id = @Id;";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@PrimerNombre", pCliente.PrimerNombre);
            comando.Parameters.AddWithValue("@SegundoNombre", pCliente.SegundoNombre);
            comando.Parameters.AddWithValue("@PrimerApellido", pCliente.PrimerApellido);
            comando.Parameters.AddWithValue("@SegundoApellido", pCliente.SegundoApellido);
            comando.Parameters.AddWithValue("@Dui", pCliente.DUI);
            comando.Parameters.AddWithValue("@Direccion", pCliente.Direccion);
            comando.Parameters.AddWithValue("@Telefono", pCliente.Telefono);
            comando.Parameters.AddWithValue("@Correo", pCliente.Correo);
            comando.Parameters.AddWithValue("@Id", pCliente.Id);
            return ComunDB.EjecutarComando(comando);
        }

        public static int Eliminar(Cliente pCliente)
        {
            string consulta = @"DELETE FROM Cliente WHERE Id = @Id;";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pCliente.Id);
            return ComunDB.EjecutarComando(comando);
        }

        public static List<Cliente> ObtenerTodos()
        {
            string consulta = @"SELECT TOP 500 c.Id, c.PrimerNombre, c.SegundoNombre, c.PrimerApellido, c.SegundoApellido, 
            c.Dui, c.Direccion, c.Telefono, c.Correo FROM Cliente c";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            List<Cliente> listaClientes = new List<Cliente>();
            while (reader.Read())
            {
                Cliente cliente = new Cliente();
                cliente.Id = reader.GetInt32(0);
                cliente.PrimerNombre = reader.GetString(1);
                cliente.SegundoNombre = reader.GetString(2);
                cliente.PrimerApellido = reader.GetString(3);
                cliente.SegundoApellido = reader.GetString(4);
                cliente.DUI = reader.GetString(5);
                cliente.Direccion = reader.GetString(6);
                cliente.Telefono = reader.GetString(7);
                cliente.Correo = reader.GetString(8);
                listaClientes.Add(cliente);
            }
            return listaClientes;
        }

        public static Cliente BuscarPorId(int pId)
        {
            string consulta = @"SELECT c.Id, c.PrimerNombre, c.SegundoNombre, c.PrimerApellido, c.SegundoApellido, 
            c.Dui, c.Direccion, c.Telefono, c.Correo FROM Cliente c WHERE Id = @Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pId);
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            Cliente cliente = new Cliente();
            while (reader.Read())
            {
                cliente.Id = reader.GetInt32(0);
                cliente.PrimerNombre = reader.GetString(1);
                cliente.SegundoNombre = reader.GetString(2);
                cliente.PrimerApellido = reader.GetString(3);
                cliente.SegundoApellido = reader.GetString(4);
                cliente.DUI = reader.GetString(5);
                cliente.Direccion = reader.GetString(6);
                cliente.Telefono = reader.GetString(7);
                cliente.Correo = reader.GetString(8);
            }
            return cliente;
        }
    }
}
