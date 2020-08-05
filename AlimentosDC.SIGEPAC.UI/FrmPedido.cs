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
        FrmPedido objeto;
        Pedido pedido;
        int? id = null;
        public List<DetallePedido> listadoDetallesPedido = new List<DetallePedido>();
        public FrmPedido()
        {
            InitializeComponent();
            lblNumeroPedido.Text = PedidoBL.GenerarNumeroPedido();
            objeto = this;
        }

        public void CargarListadoDetalles()
        {
            int indiceFilaAgregada = dgvListadoDetallesPedido.Rows.Add();
            int idTemporal = indiceFilaAgregada + 1;
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[0].Value = idTemporal;
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[1].Value = listadoDetallesPedido[indiceFilaAgregada].Producto;
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[2].Value = listadoDetallesPedido[indiceFilaAgregada].Descripcion;
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[3].Value = listadoDetallesPedido[indiceFilaAgregada].Cantidad;
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[4].Value = listadoDetallesPedido[indiceFilaAgregada].PrecioUnitario;
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[5].Value = listadoDetallesPedido[indiceFilaAgregada].SubTotal;
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[6].Value = cmbEstadoPedido.SelectedItem.ToString();
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
            FrmDetallePedido mantenimientoDetallesPedido = new FrmDetallePedido(ref objeto);
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

        private void btnGuardarPedido_Click(object sender, EventArgs e)
        {
            Pedido pedidoARegistrar = new Pedido();
            pedidoARegistrar.IdCliente = (cmbListadoClientes.SelectedItem as Cliente).Id;
            pedidoARegistrar.NumeroPedido = int.Parse(lblNumeroPedido.Text);
            pedidoARegistrar.FechaCreacion = dtpFechaCreacion.Value;
            pedidoARegistrar.FechaEntrega = dtpFechaEntrega.Value;
            pedidoARegistrar.DireccionEntrega = txtDireccionEntregaPedido.Text;
            pedidoARegistrar.Estado = cmbEstadoPedido.SelectedItem.ToString();

            for (int i = 0; i < dgvListadoDetallesPedido.Rows.Count; i++)
            {
                DetallePedido detallePedidoARegistrar = new DetallePedido();
                detallePedidoARegistrar.IdPedido = int.Parse(lblNumeroPedido.Text);
                detallePedidoARegistrar.IdProducto = 
                //Me quedè aqui 
                //Continuar en hacer las inserciones de los detalles pedidos del pedido insertar
            }
            
        }
    }
}
