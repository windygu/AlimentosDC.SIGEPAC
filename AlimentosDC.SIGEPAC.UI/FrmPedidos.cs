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
using System.Data.SqlClient;

namespace AlimentosDC.SIGEPAC.UI
{
    public partial class FrmPedidos : MetroForm
    {
        List<Pedido> listadoPedidos = new List<Pedido>();
        FrmPedidos objetoPedidosActual;
        Usuario usuarioActual;
        public FrmPedidos(Usuario usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
            objetoPedidosActual = this;
            btnEditarPedido.Enabled = false;
            btnVerDetallePedido.Enabled = false;
            btnEliminarPedido.Enabled = false;
            txtBuscadorPedidos.GotFocus += TxtBuscadorPedidos_GotFocus;
        }

        private void TxtBuscadorPedidos_GotFocus(object sender, EventArgs e)
        {
            dgvListadoPedidos.ClearSelection();
        }

        private void btnVerDetallePedido_Click(object sender, EventArgs e)
        {
            int idPedido = int.Parse(dgvListadoPedidos.SelectedRows[0].Cells[0].Value.ToString());
            int numeroPedido = int.Parse(dgvListadoPedidos.SelectedRows[0].Cells[4].Value.ToString());
            FrmVerDetallesPedido verDetallesPedido = new FrmVerDetallesPedido(idPedido, numeroPedido, usuarioActual);
            verDetallesPedido.Owner = this;
            verDetallesPedido.ShowDialog();
        }


        private void btnEditarPedido_Click(object sender, EventArgs e)
        {
            int idPedido = int.Parse(dgvListadoPedidos.SelectedRows[0].Cells[0].Value.ToString());
            FrmPedido p = new FrmPedido(idPedido);
            p.Owner = objetoPedidosActual;
            p.ShowDialog();
        }

        private void FrmPedidos_Click(object sender, EventArgs e)
        {
            dgvListadoPedidos.ClearSelection();
        }

        private void txtBuscadorPedidos_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscadorPedidos.Text))
            {
                txtBuscadorPedidos.Font = new Font(txtBuscadorPedidos.Font, FontStyle.Italic);
            }
            else txtBuscadorPedidos.Font = new Font(txtBuscadorPedidos.Font, FontStyle.Regular);
            if (cmbMostrando.SelectedItem.ToString() == "Todos")
            {
                CargarPedidos(txtBuscadorPedidos.Text);
            }
            else
            {
                string pEstado = cmbMostrando.SelectedItem.ToString();
                string parametroEstado = pEstado.Remove(pEstado.Length - 1, 1);
                CargarPedidos(txtBuscadorPedidos.Text, parametroEstado);
            }
            
        }

        public void CargarPedidos(string pCondicion = "%", string pEstado = "%")
        {
            dgvListadoPedidos.Rows.Clear();
            listadoPedidos = PedidoBL.ObtenerTodos(pCondicion, pEstado);
            for (int i = 0; i < listadoPedidos.Count; i++)
            {
                dgvListadoPedidos.Rows.Add();
                dgvListadoPedidos.Rows[i].Cells[0].Value = listadoPedidos[i].Id.ToString();
                dgvListadoPedidos.Rows[i].Cells[1].Value = listadoPedidos[i].Cliente.ToString();
                dgvListadoPedidos.Rows[i].Cells[2].Value = listadoPedidos[i].Usuario.ToString();
                dgvListadoPedidos.Rows[i].Cells[3].Value = listadoPedidos[i].Dui.ToString();
                dgvListadoPedidos.Rows[i].Cells[4].Value = listadoPedidos[i].NumeroPedido.ToString();
                dgvListadoPedidos.Rows[i].Cells[5].Value = listadoPedidos[i].NumeroCCF.ToString();
                dgvListadoPedidos.Rows[i].Cells[6].Value = listadoPedidos[i].FechaCreacion.ToString();
                dgvListadoPedidos.Rows[i].Cells[7].Value = listadoPedidos[i].FechaEntrega.ToString();
                dgvListadoPedidos.Rows[i].Cells[8].Value = listadoPedidos[i].DireccionEntrega.ToString();
                dgvListadoPedidos.Rows[i].Cells[9].Value = listadoPedidos[i].Estado.ToString();
            }
            dgvListadoPedidos.ClearSelection();
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
            try
            {
                switch (cmbMostrando.SelectedItem.ToString())
                {
                    case "Todos":
                        CargarPedidos(txtBuscadorPedidos.Text);
                        break;
                    case "No iniciados":
                        CargarPedidos(txtBuscadorPedidos.Text, "No iniciado");
                        break;
                    case "Iniciados":
                        CargarPedidos(txtBuscadorPedidos.Text, "Iniciado");
                        break;
                    case "Revisados":
                        CargarPedidos(txtBuscadorPedidos.Text, "Revisado");
                        break;
                    case "Enviados":
                        CargarPedidos(txtBuscadorPedidos.Text, "Enviado");
                        break;
                    case "Finalizados":
                        CargarPedidos(txtBuscadorPedidos.Text, "Finalizado");
                        break;
                }
            }
            catch (SqlException error)
            {
                MetroMessageBox.Show(this, string.Concat("Hubo un error al intentar conectarse al servidor, ",
                    $"por favor revise si es posible conectarse al servidor de la base datos.\nMÁS INFORMACIÓN: {error.Message}"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            catch(Exception error)
            {
                MetroMessageBox.Show(this, $"¡Ha ocurrido un error!\nMÁS INFORMACIÓN: {error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            
        }

        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {
            int idPedidoAEliminar = int.Parse(dgvListadoPedidos.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult resultadoDialgo = MetroMessageBox.Show(this, "¿Desea eliminar este pedido?", "Aviso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resultadoDialgo == DialogResult.Yes)
            {
                List<DetallePedido> listadoDetalles = DetallePedidoBL.ObtenerTodos(idPedidoAEliminar);
                if (listadoDetalles.Count>=1)
                {
                    DialogResult resultado = MetroMessageBox.Show(this, "Se eliminarán el pedido y todos sus detalles.", "¡Advertencia!", 
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (resultado == DialogResult.OK)
                    {
                        foreach (var item in listadoDetalles)
                        {
                            DetallePedidoBL.Eliminar(item.Id);
                        }
                        PedidoBL.Eliminar(idPedidoAEliminar);
                    }
                }
                else PedidoBL.Eliminar(idPedidoAEliminar);
                CargarPedidos();
            }
            
        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            cmbMostrando.SelectedItem = "Todos";
        }
    }
}
