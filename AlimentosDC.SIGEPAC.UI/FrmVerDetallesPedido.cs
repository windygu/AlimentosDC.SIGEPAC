using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlimentosDC.SIGEPAC.EN;
using AlimentosDC.SIGEPAC.BL;
using System.Globalization;
using System.Threading;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace AlimentosDC.SIGEPAC.UI
{
    public partial class FrmVerDetallesPedido : MetroForm
    {
        List<DetallePedido> listadoDetallesPedido;
        Pedido pedido;
        Cliente cliente;
        int idPedido, numeroPedido;
        public FrmVerDetallesPedido(int idPedido, int numeroPedido)
        {
            InitializeComponent();
            this.idPedido = idPedido;
            this.numeroPedido = numeroPedido;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmVerDetallesPedido_Load(object sender, EventArgs e)
        {
            CargarDetalles();
        }

        void CargarDetalles()
        {
            try
            {
                listadoDetallesPedido = DetallePedidoBL.ObtenerTodos(idPedido);
                dgvListadoDetallesPedido.Rows.Clear();
                pedido = PedidoBL.BuscarPorId(idPedido);
                lblIdPedido.Text = pedido.Id.ToString();
                lblNumeroPedido.Text = pedido.NumeroPedido.ToString();
                lblFechaCreacion.Text = pedido.FechaCreacion.ToString();
                lblEstadoPedido.Text = pedido.Estado;
                lblFechaEntrega.Text = pedido.FechaEntrega.ToString();
                lblDireccionEntrega.Text = pedido.DireccionEntrega;
                cliente = ClienteBL.BuscarPorId(pedido.IdCliente);
                lblCliente.Text = string.Concat(cliente.PrimerNombre, " ", cliente.SegundoNombre, " ",
                    cliente.PrimerApellido, " ", cliente.SegundoApellido);
                lblDuiCliente.Text = cliente.DUI;
                int sumaProductos = 0;
                float total = 0;
                for (int i = 0; i < listadoDetallesPedido.Count; i++)
                {
                    dgvListadoDetallesPedido.Rows.Add();
                    dgvListadoDetallesPedido.Rows[i].Cells[0].Value = listadoDetallesPedido[i].Id;
                    dgvListadoDetallesPedido.Rows[i].Cells[1].Value = listadoDetallesPedido[i].Producto;
                    dgvListadoDetallesPedido.Rows[i].Cells[2].Value = listadoDetallesPedido[i].Descripcion;
                    dgvListadoDetallesPedido.Rows[i].Cells[3].Value = listadoDetallesPedido[i].Cantidad;
                    dgvListadoDetallesPedido.Rows[i].Cells[4].Value = listadoDetallesPedido[i].PrecioUnitario;
                    dgvListadoDetallesPedido.Rows[i].Cells[5].Value = listadoDetallesPedido[i].SubTotal;
                    dgvListadoDetallesPedido.Rows[i].Cells[6].Value = listadoDetallesPedido[i].Estado;
                    sumaProductos += listadoDetallesPedido[i].Cantidad;
                    total += listadoDetallesPedido[i].SubTotal;
                }

                lblProductos.Text = sumaProductos.ToString();
                int cantidad;
                lblTotal.Text =
                "$ " + ((int.TryParse(total.ToString(), out cantidad) == true) ? (total.ToString() + ".00") : total.ToString());

            }
            catch (Exception error)
            {
                MetroMessageBox.Show(this, $"¡Ha ocurrido un error!\nMÁS INFORMACIÓN: {error.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
