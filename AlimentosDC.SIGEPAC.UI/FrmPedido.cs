using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar;
using AlimentosDC.SIGEPAC.BL;
using AlimentosDC.SIGEPAC.EN;

namespace AlimentosDC.SIGEPAC.UI
{
    public partial class FrmPedido : MetroForm
    {
        Pedido pedido;
        int? id = null;
        public FrmPedido()
        {
            InitializeComponent();
            lblNumeroPedido.Text = PedidoBL.GenerarNumeroPedido();
        }

        public FrmPedido(int id)
        {
            InitializeComponent();
            this.id = id;
            cmbListadoClientes.Focus();
            lblTitulo.Text = "Editar pedido";
            btnNuevoPedido.Visible = false;
            CargarDatos();
        }

        void CargarDatos()
        {
            pedido = PedidoBL.BuscarPorId((int) id);
            cmbListadoClientes.Text = pedido.Cliente;
            lblDui.Text = pedido.Dui;
            lblNumeroPedido.Text = pedido.NumeroPedido.ToString();
            dtpFechaCreacion.Value = pedido.FechaCreacion;
            cmbEstadoPedido.Text = pedido.Estado;
            dtpFechaEntrega.Value = pedido.FechaEntrega;
            txtDireccionEntregaPedido.Text = pedido.DireccionEntrega;

        }

        private void btnNuevoDetallePedido_Click(object sender, EventArgs e)
        {
            FrmDetallePedido mantenimientoDetallesPedido = new FrmDetallePedido();
            mantenimientoDetallesPedido.Owner = this;
            mantenimientoDetallesPedido.ShowDialog();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmClientes listadoClientes = new FrmClientes();
            listadoClientes.Owner = this;
            listadoClientes.ShowDialog();
        }

        private void btnEditarDetallePedido_Click(object sender, EventArgs e)
        {
            FrmDetallePedido mantenimientoDetallesPedido = new FrmDetallePedido();
            mantenimientoDetallesPedido.Owner = this;
            mantenimientoDetallesPedido.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            List<Cliente> listadoNuevoClientes = new List<Cliente>();
            List<Cliente> listadoClientes = ClienteBL.ObtenerTodos();
            for (int i = 0; i < listadoClientes.Count; i++)
            {
                Cliente cliente = new Cliente();
                cliente.Id = listadoClientes[i].Id;
                cliente.Nombres = string.Concat(listadoClientes[i].Nombres, " ", listadoClientes[i].Apellidos);
                cliente.DUI = listadoClientes[i].DUI;
                cliente.Direccion = listadoClientes[i].Direccion;
                cliente.Telefono = listadoClientes[i].Telefono;
                cliente.Correo = listadoClientes[i].Correo;
                listadoNuevoClientes.Add(cliente);
            }
            cmbListadoClientes.Items.AddRange(listadoNuevoClientes.ToArray());
            cmbListadoClientes.DisplayMember  = "Nombres";
        }

        private void cmbListadoClientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = int.Parse((cmbListadoClientes.SelectedItem as Cliente).Id.ToString());
            lblDui.Text = (ClienteBL.BuscarPorId(id)).DUI;
        }
    }
}
