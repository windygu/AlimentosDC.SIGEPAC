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
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace AlimentosDC.SIGEPAC.UI
{
    public partial class FrmPedidos : MetroForm
    {
        List<Pedido> listadoPedidos = new List<Pedido>();
        FrmPedidos objetoActual;
        public FrmPedidos()
        {
            InitializeComponent();
            objetoActual = this;
            btnEditarPedido.Enabled = true;
            btnVerDetallePedido.Enabled = true;
            btnEliminarPedido.Enabled = true;
            txtBuscadorPedidos.GotFocus += TxtBuscadorPedidos_GotFocus;
            cmbMostrando.SelectedItem = "Todos";
            btnNuevoPedido.Focus();
        }

        private void TxtBuscadorPedidos_GotFocus(object sender, EventArgs e)
        {
            dgvListadoPedidos.ClearSelection();
        }

        private void btnVerDetallePedido_Click(object sender, EventArgs e)
        {
            int idPedido = int.Parse(dgvListadoPedidos.SelectedRows[0].Cells[0].Value.ToString());
            int numeroPedido = int.Parse(dgvListadoPedidos.SelectedRows[0].Cells[3].Value.ToString());
            FrmVerDetallesPedido verDetallesPedido = new FrmVerDetallesPedido(idPedido, numeroPedido);
            verDetallesPedido.Owner = this;
            verDetallesPedido.ShowDialog();
        }

        public void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            FrmPedido p = new FrmPedido(ref objetoActual);
            p.Owner = objetoActual;
            p.ShowDialog();
        }

        private void btnEditarPedido_Click(object sender, EventArgs e)
        {
            int idPedido = int.Parse(dgvListadoPedidos.SelectedRows[0].Cells[0].Value.ToString());
            FrmPedido p = new FrmPedido(ref objetoActual, idPedido);
            p.Owner = objetoActual;
            p.ShowDialog();
        }

        private void FrmPedidos_Click(object sender, EventArgs e)
        {
            btnNuevoPedido.Focus();
            dgvListadoPedidos.ClearSelection();
        }

        private void txtBuscadorPedidos_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscadorPedidos.Text))
            {
                txtBuscadorPedidos.Font = new Font(txtBuscadorPedidos.Font, FontStyle.Italic);
            }
            else
                txtBuscadorPedidos.Font = new Font(txtBuscadorPedidos.Font, FontStyle.Regular);
            CargarPedidos(pDatoABuscar: txtBuscadorPedidos.Text);
        }

        public void CargarPedidos(string pEstado = "%", string pDatoABuscar = null)
        {
            dgvListadoPedidos.Rows.Clear();
            listadoPedidos = PedidoBL.ObtenerTodos(pEstado, pDatoABuscar);
            for (int i = 0; i < listadoPedidos.Count; i++)
            {
                dgvListadoPedidos.Rows.Add();
                dgvListadoPedidos.Rows[i].Cells[0].Value = listadoPedidos[i].Id.ToString();
                dgvListadoPedidos.Rows[i].Cells[1].Value = listadoPedidos[i].Cliente.ToString();
                dgvListadoPedidos.Rows[i].Cells[2].Value = listadoPedidos[i].Dui.ToString();
                dgvListadoPedidos.Rows[i].Cells[3].Value = listadoPedidos[i].NumeroPedido.ToString();
                dgvListadoPedidos.Rows[i].Cells[4].Value = listadoPedidos[i].FechaCreacion.ToString();
                dgvListadoPedidos.Rows[i].Cells[5].Value = listadoPedidos[i].FechaEntrega.ToString();
                dgvListadoPedidos.Rows[i].Cells[6].Value = listadoPedidos[i].DireccionEntrega.ToString();
                dgvListadoPedidos.Rows[i].Cells[7].Value = listadoPedidos[i].Estado.ToString();
            }
        }

        private void dgvListadoPedidos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListadoPedidos.SelectedRows.Count>0)
            {
                btnVerDetallePedido.Enabled = true;
                btnEditarPedido.Enabled = true;
                btnEliminarPedido.Enabled = true;
            }
            else
            {
                btnVerDetallePedido.Enabled = false;
                btnEditarPedido.Enabled = false;
                btnEliminarPedido.Enabled = false;
            }
        }

        private void cmbMostrando_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (cmbMostrando.SelectedItem.ToString())
            {
                case "Todos": CargarPedidos();
                    break;
                case "No iniciados": CargarPedidos("No iniciado");
                    break;
                case "Iniciados": CargarPedidos("Iniciado");
                    break;
                case "Revisados": CargarPedidos("Revisado");
                    break;
                case "Enviados": CargarPedidos("Enviado");
                    break;
                case "Finalizados": CargarPedidos("Finalizado");
                    break;
            }
        }

        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {
            int idPedidoAEliminar = int.Parse(dgvListadoPedidos.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult resultadoDialgo = MetroFramework.MetroMessageBox.Show(this, "¿Desea eliminar este pedido?", "Aviso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resultadoDialgo == DialogResult.Yes)
            {
                PedidoBL.Eliminar(idPedidoAEliminar);
            }
        }
    }
}
