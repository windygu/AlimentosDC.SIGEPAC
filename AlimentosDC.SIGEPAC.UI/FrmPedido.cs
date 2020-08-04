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
            txtDuiClientePedido.Text = pedido.Dui;
            txtNumeroPedido.Text = pedido.NumeroPedido.ToString();
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
    }
}
