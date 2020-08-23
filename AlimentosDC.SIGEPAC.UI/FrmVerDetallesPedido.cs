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
        Usuario usuarioActual;
        public FrmVerDetallesPedido(int idPedido, int numeroPedido, Usuario usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
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

        private void lblNumeroPedido_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.DarkGray, 0, ButtonBorderStyle.None,
                Color.Transparent, 0, ButtonBorderStyle.None, Color.Transparent, 0, ButtonBorderStyle.None,
                Color.Black, 1, ButtonBorderStyle.Solid);
        }


        void CargarDetalles()
        {
            try
            {
                listadoDetallesPedido = DetallePedidoBL.ObtenerTodos(idPedido);
                dgvListadoDetallesPedido.Rows.Clear();
                pedido = PedidoBL.BuscarPorId(idPedido);
                lblNumeroPedido.Text = pedido.NumeroPedido.ToString();
                lblNumeroCCF.Text = pedido.NumeroCCF;
                lblFechaCreacion.Text = pedido.FechaCreacion.ToString("d");
                lblEstadoPedido.Text = pedido.Estado;
                lblFechaEntrega.Text = pedido.FechaEntrega.ToString("d");
                lblDireccionEntrega.Text = pedido.DireccionEntrega;
                cliente = ClienteBL.BuscarPorId(pedido.IdCliente);
                lblCliente.Text = string.Concat(cliente.PrimerNombre, " ", cliente.SegundoNombre, " ",
                    cliente.PrimerApellido, " ", cliente.SegundoApellido);
                lblDuiCliente.Text = cliente.DUI;
                lblUsuario.Text = string.Concat(usuarioActual.Nombres, " ", usuarioActual.Apellidos);
                float sumas = 0.00f;
                for (int i = 0; i < listadoDetallesPedido.Count; i++)
                {
                    dgvListadoDetallesPedido.Rows.Add();
                    dgvListadoDetallesPedido.Rows[i].Cells[0].Value = listadoDetallesPedido[i].Id;
                    dgvListadoDetallesPedido.Rows[i].Cells[1].Value = listadoDetallesPedido[i].Estado;
                    dgvListadoDetallesPedido.Rows[i].Cells[2].Value = listadoDetallesPedido[i].Producto;
                    dgvListadoDetallesPedido.Rows[i].Cells[3].Value = listadoDetallesPedido[i].Descripcion;
                    dgvListadoDetallesPedido.Rows[i].Cells[4].Value = listadoDetallesPedido[i].Cantidad;
                    dgvListadoDetallesPedido.Rows[i].Cells[5].Value = listadoDetallesPedido[i].PrecioUnitario.ToString("C");
                    dgvListadoDetallesPedido.Rows[i].Cells[6].Value = listadoDetallesPedido[i].SubTotal.ToString("C");
                    sumas += listadoDetallesPedido[i].SubTotal;
                }
                lblSumas.Text = sumas.ToString("C");
                lblIva.Text = (sumas * 0.13).ToString("C");
                lblTotal.Text = (sumas * 1.13).ToString("C");
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
