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
using AlimentosDC.SIGEPAC.EN;
using AlimentosDC.SIGEPAC.BL;

namespace AlimentosDC.SIGEPAC.UI
{
    public partial class FrmVerDetallesPedido : MetroForm
    {
        List<DetallePedido> listadoDetallesPedido;
        int idPedido, numeroPedido;
        public FrmVerDetallesPedido(int idPedido, int numeroPedido)
        {
            InitializeComponent();
            this.idPedido = idPedido;
            this.numeroPedido = numeroPedido;
            CargarDetalles();
            lblIdPedido.Text = idPedido.ToString();
            lblNumeroPedido.Text = numeroPedido.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        void CargarDetalles()
        {
            listadoDetallesPedido = DetallePedidoBL.ObtenerTodos(idPedido);
            dgvListadoDetallesPedido.Rows.Clear();
            int sumaProductos = 0;
            float total = 0.00f;
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
            lblTotal.Text = total.ToString();
        }
    }
}
