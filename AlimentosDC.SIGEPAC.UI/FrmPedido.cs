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
            int indiceDetallePedidoAEditar = dgvListadoDetallesPedido.SelectedRows[0].Index;
            FrmDetallePedido mantenimientoDetallesPedido = new FrmDetallePedido(ref objeto, indiceDetallePedidoAEditar, ref listadoDetallesPedido);
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

        void Limpiar()
        {
            lblNumeroPedido.Text = PedidoBL.GenerarNumeroPedido();
            dtpFechaCreacion.Value = DateTime.Now;
            dtpFechaEntrega.Value = DateTime.Now;
            cmbEstadoPedido.SelectedItem = null;
            cmbListadoClientes.SelectedItem = null;
            txtDireccionEntregaPedido.Text = "";
            dgvListadoDetallesPedido.Rows.Clear();
            listadoDetallesPedido.Clear();
            dtpFechaCreacion.Focus();
        }

        private void btnGuardarPedido_Click(object sender, EventArgs e)
        {
            int resultadoPedido = 0;
            int resultadoDetallePedido = 0;
            try
            {
                Pedido pedidoARegistrar = new Pedido();
                pedidoARegistrar.IdCliente = (cmbListadoClientes.SelectedItem as Cliente).Id;
                pedidoARegistrar.NumeroPedido = int.Parse(lblNumeroPedido.Text);
                pedidoARegistrar.FechaCreacion = dtpFechaCreacion.Value;
                pedidoARegistrar.FechaEntrega = dtpFechaEntrega.Value;
                pedidoARegistrar.DireccionEntrega = txtDireccionEntregaPedido.Text;
                pedidoARegistrar.Estado = cmbEstadoPedido.SelectedItem.ToString();
                resultadoPedido += PedidoBL.Guardar(pedidoARegistrar);
                for (int i = 0; i < dgvListadoDetallesPedido.Rows.Count; i++)
                {
                    DetallePedido detallePedidoARegistrar = new DetallePedido();
                    detallePedidoARegistrar.IdPedido = (PedidoBL.BuscarPorNumeroPedido(int.Parse(lblNumeroPedido.Text))).Id;
                    detallePedidoARegistrar.IdProducto = listadoDetallesPedido[i].IdProducto;
                    detallePedidoARegistrar.Cantidad = ushort.Parse(dgvListadoDetallesPedido.Rows[i].Cells[3].Value.ToString());
                    detallePedidoARegistrar.PrecioUnitario = float.Parse(dgvListadoDetallesPedido.Rows[i].Cells[4].Value.ToString());
                    detallePedidoARegistrar.SubTotal = float.Parse(dgvListadoDetallesPedido.Rows[i].Cells[5].Value.ToString());
                    detallePedidoARegistrar.Estado = dgvListadoDetallesPedido.Rows[i].Cells[6].Value.ToString();
                    resultadoDetallePedido += DetallePedidoBL.Guardar(detallePedidoARegistrar);
                }
                MessageBoxEx.Show($"{resultadoPedido} pedido registrado.\n{resultadoDetallePedido} detalle(s) del pedido registrado(s).", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            catch (Exception exc)
            {
                MessageBoxEx.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminarDetallePedido_Click(object sender, EventArgs e)
        {
            DialogResult resultadoDelCuadro = MessageBoxEx.Show("¿Desea eliminar el detalle del pedido?", "Aviso", 
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resultadoDelCuadro==DialogResult.Yes)
            {
                int indiceFilaAEliminar = dgvListadoDetallesPedido.SelectedRows[0].Index;
                dgvListadoDetallesPedido.Rows.RemoveAt(indiceFilaAEliminar);
                listadoDetallesPedido.RemoveAt(indiceFilaAEliminar);
                for (int i = 0; i < dgvListadoDetallesPedido.RowCount; i++)
                {
                    dgvListadoDetallesPedido.Rows[i].Cells[0].Value = i + 1;
                    listadoDetallesPedido[i].Id = i + 1;
                }
            }
        }

        private void dgvListadoDetallesPedido_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListadoDetallesPedido.SelectedRows.Count > 0)
            {
                btnEditarDetallePedido.Enabled = true;
                btnEliminarDetallePedido.Enabled = true;
            }
            else
            {
                btnEditarDetallePedido.Enabled = false;
                btnEliminarDetallePedido.Enabled = false;
            }
        }
    }
}
