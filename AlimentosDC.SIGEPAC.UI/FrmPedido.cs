using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlimentosDC.SIGEPAC.BL;
using AlimentosDC.SIGEPAC.EN;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace AlimentosDC.SIGEPAC.UI
{
    public partial class FrmPedido : MetroForm
    {
        FrmPedido objetoPedidoActual;
        FrmPedidos objetoPedidosActual;
        Pedido pedido;
        List<Cliente> listadoClientes;
        List<Cliente> listadoNuevoClientes;
        int? idPedido = null;
        //Listado a usarse en un nuevo pedido
        public List<DetallePedido> listadoDetallesPedido = new List<DetallePedido>();
        //Listados a usarse en la modificación de un pedido
        public List<DetallePedido> listadoViejoDetallesPedido = new List<DetallePedido>();
        public List<int> detallesViejosAEliminarDeLaBD = new List<int>();

        //Constructor para un nuevo pedido
        public FrmPedido(ref FrmPedidos objetoPedidosActual)
        {
            InitializeComponent();
            this.objetoPedidosActual = objetoPedidosActual;
            objetoPedidoActual = this;
        }

        //Constructor para editar un pedido
        public FrmPedido(ref FrmPedidos objetoPedidosActual, int idPedido)
        {
            InitializeComponent();
            objetoPedidoActual = this;
            this.objetoPedidosActual = objetoPedidosActual;
            this.idPedido = idPedido;
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            btnGuardarPedido.Enabled = false;
            CargarClientesAlCombobox();
            if (idPedido == null)
            {
                
                lblNumeroPedido.Text = PedidoBL.GenerarNumeroPedido();
                cmbEstadoPedido.SelectedIndex = 0;
                dtpFechaCreacion.Focus();
            }
            else
            {
                CargarDatosAlFormulario();
                dtpFechaCreacion.Focus();
            }
        }

        void CargarDatosAlFormulario()
        {
            pedido = PedidoBL.BuscarPorId((int) idPedido);
            lblNumeroPedido.Text = pedido.NumeroPedido.ToString();
            //List<Cliente> listadoClientes2 = ClienteBL.ObtenerTodos();
            //Cliente cliente = ClienteBL.BuscarPorId(pedido.IdCliente);
            //int indiceDelCliente = listadoClientes2.FindIndex(x => x.Id == cliente.Id);
            //cmbListadoClientes.SelectedIndex = indiceDelCliente;
            cmbListadoClientes.SelectedValue = pedido.IdCliente;
            dtpFechaCreacion.Value = pedido.FechaCreacion;
            cmbEstadoPedido.SelectedItem = pedido.Estado;
            dtpFechaEntrega.Value = pedido.FechaEntrega;
            txtDireccionEntregaPedido.Text = pedido.DireccionEntrega;
            listadoViejoDetallesPedido = DetallePedidoBL.ObtenerTodos((int)idPedido);
            if (listadoViejoDetallesPedido!=null)
            {
                for (int i = 0; i < listadoViejoDetallesPedido.Count; i++)
                {
                    dgvListadoDetallesPedido.Rows.Add();
                    dgvListadoDetallesPedido.Rows[i].Cells[0].Value = listadoViejoDetallesPedido[i].Id;
                    dgvListadoDetallesPedido.Rows[i].Cells[1].Value = listadoViejoDetallesPedido[i].Producto;
                    dgvListadoDetallesPedido.Rows[i].Cells[2].Value = listadoViejoDetallesPedido[i].Descripcion;
                    dgvListadoDetallesPedido.Rows[i].Cells[3].Value = listadoViejoDetallesPedido[i].Cantidad;
                    dgvListadoDetallesPedido.Rows[i].Cells[4].Value = listadoViejoDetallesPedido[i].PrecioUnitario;
                    dgvListadoDetallesPedido.Rows[i].Cells[5].Value = listadoViejoDetallesPedido[i].SubTotal;
                    dgvListadoDetallesPedido.Rows[i].Cells[6].Value = listadoViejoDetallesPedido[i].Estado;
                    listadoDetallesPedido.Add(listadoViejoDetallesPedido[i]);
                }
            }
        }
        void CargarClientesAlCombobox()
        {
            listadoNuevoClientes = new List<Cliente>();
            listadoClientes = ClienteBL.ObtenerTodos();
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
            listadoNuevoClientes.Insert(0, new Cliente() { Id = 0, Nombres = "- Seleccione -" });
            cmbListadoClientes.DataSource = listadoNuevoClientes;
            cmbListadoClientes.DisplayMember = "Nombres";
            cmbListadoClientes.ValueMember = "Id";

        }
        //Método para ir agregando cada detalle (anteriormente agregado a la lista) al datagrid
        public void CargarListadoDetalles()
        {
            int indiceFilaAgregada = dgvListadoDetallesPedido.Rows.Add();
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[0].Value = listadoDetallesPedido[indiceFilaAgregada].Id;
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[1].Value = listadoDetallesPedido[indiceFilaAgregada].Producto;
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[2].Value = listadoDetallesPedido[indiceFilaAgregada].Descripcion;
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[3].Value = listadoDetallesPedido[indiceFilaAgregada].Cantidad;
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[4].Value = listadoDetallesPedido[indiceFilaAgregada].PrecioUnitario;
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[5].Value = listadoDetallesPedido[indiceFilaAgregada].SubTotal;
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[6].Value = listadoDetallesPedido[indiceFilaAgregada].Estado;
        }
        public void ActualizarDatagridView()
        {
            dgvListadoDetallesPedido.Rows.Clear();
            for (int i = 0; i < listadoDetallesPedido.Count; i++)
            {
                CargarListadoDetalles();
            }
        }
        private void btnNuevoDetallePedido_Click(object sender, EventArgs e)
        {
            FrmDetallePedido mantenimientoDetallesPedido = new FrmDetallePedido(ref objetoPedidoActual);
            mantenimientoDetallesPedido.Owner = objetoPedidoActual;
            mantenimientoDetallesPedido.ShowDialog();
        }

        private void btnEditarDetallePedido_Click(object sender, EventArgs e)
        {
            int idDetallePedidoAEditar = int.Parse(dgvListadoDetallesPedido.SelectedRows[0].Cells[0].Value.ToString());
            FrmDetallePedido mantenimientoDetallesPedido =
            new FrmDetallePedido(ref objetoPedidoActual, idDetallePedidoAEditar);
            mantenimientoDetallesPedido.Owner = objetoPedidoActual;
            mantenimientoDetallesPedido.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbListadoClientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if ((int)cmbListadoClientes.SelectedValue>0)
            {
                epValidadorControles.SetError(cmbListadoClientes, "");
                int id = (int)cmbListadoClientes.SelectedValue;
                lblDui.Text = (ClienteBL.BuscarPorId(id)).DUI;
                HabilitarBotonGuardarPedido();
                txtDireccionEntregaPedido.Focus();
            }
            else 
            {
                lblDui.Text = "";
                HabilitarBotonGuardarPedido();
            }
        }

        void Limpiar()
        {
            
            lblNumeroPedido.Text = PedidoBL.GenerarNumeroPedido();
            dtpFechaCreacion.Value = DateTime.Now;
            dtpFechaEntrega.Value = DateTime.Now;
            cmbEstadoPedido.SelectedIndex = 0;
            cmbListadoClientes.SelectedValue = 0;
            txtDireccionEntregaPedido.Clear();
            dgvListadoDetallesPedido.Rows.Clear();
            listadoDetallesPedido.Clear();
            listadoViejoDetallesPedido.Clear();
            epValidadorControles.Clear();
            dtpFechaCreacion.Focus();
        }

        private void btnGuardarPedido_Click(object sender, EventArgs e)
        {
            GuardarPedido();
        }

        void GuardarPedido()
        {
            try
            {
                if (dgvListadoDetallesPedido.Rows.Count < 1)
                {
                    epValidadorControles.SetError(dgvListadoDetallesPedido, "Debe agregar al menos un detalle.");
                }
                else
                {
                    if (idPedido == null)
                    {
                        int resultadoPedido = 0;
                        int resultadoDetallePedido = 0;

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
                            detallePedidoARegistrar.Cantidad = listadoDetallesPedido[i].Cantidad;
                            detallePedidoARegistrar.PrecioUnitario = listadoDetallesPedido[i].PrecioUnitario;
                            detallePedidoARegistrar.SubTotal = listadoDetallesPedido[i].SubTotal;
                            detallePedidoARegistrar.Estado = listadoDetallesPedido[i].Estado;
                            resultadoDetallePedido += DetallePedidoBL.Guardar(detallePedidoARegistrar);
                        }
                        objetoPedidosActual.CargarPedidos();
                        MetroMessageBox.Show(this, $"{resultadoPedido} pedido registrado.\n{resultadoDetallePedido} detalle(s) del pedido registrado(s).",
                            "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        FrmReportes factura = new FrmReportes();
                        factura.reportViewer1.LocalReport.DataSources[0].Value = PedidoBL.DatosFactura(int.Parse(lblNumeroPedido.Text));
                        factura.ShowDialog();
                        Limpiar();
                    }
                    else
                    {
                        int resultadoPedido = 0;
                        int resultDetallesModificados = 0;
                        int resultDetallesAñadidos = 0;
                        int resultadoEliminados = 0;

                        pedido.IdCliente = (cmbListadoClientes.SelectedItem as Cliente).Id;
                        pedido.FechaCreacion = dtpFechaCreacion.Value;
                        pedido.FechaEntrega = dtpFechaEntrega.Value;
                        pedido.DireccionEntrega = txtDireccionEntregaPedido.Text;
                        pedido.Estado = cmbEstadoPedido.SelectedItem.ToString();
                        resultadoPedido += PedidoBL.Modificar(pedido);
                        for (int i = 0; i < dgvListadoDetallesPedido.Rows.Count; i++)
                        {
                            DetallePedido detallePedidoARegistrar = new DetallePedido();
                            detallePedidoARegistrar.Id = listadoDetallesPedido[i].Id;
                            detallePedidoARegistrar.IdPedido = (int)idPedido;
                            detallePedidoARegistrar.IdProducto = listadoDetallesPedido[i].IdProducto;
                            detallePedidoARegistrar.Cantidad = listadoDetallesPedido[i].Cantidad;
                            detallePedidoARegistrar.PrecioUnitario = listadoDetallesPedido[i].PrecioUnitario;
                            detallePedidoARegistrar.SubTotal = listadoDetallesPedido[i].SubTotal;
                            detallePedidoARegistrar.Estado = listadoDetallesPedido[i].Estado;

                            if (listadoViejoDetallesPedido.Find(x => x.Id == listadoDetallesPedido[i].Id) != null)
                            {
                                resultDetallesModificados += DetallePedidoBL.Modificar(detallePedidoARegistrar);
                            }
                            else
                            {
                                resultDetallesAñadidos += DetallePedidoBL.Guardar(detallePedidoARegistrar);
                            }
                        }
                        if (detallesViejosAEliminarDeLaBD.Count >= 1)
                        {
                            for (int i = 0; i < detallesViejosAEliminarDeLaBD.Count; i++)
                            {
                                resultadoEliminados += DetallePedidoBL.Eliminar(detallesViejosAEliminarDeLaBD[i]);
                            }
                        }
                        objetoPedidosActual.CargarPedidos();
                        DialogResult resultadoDelDialgo = MetroMessageBox.Show
                        (this, $"{resultadoPedido} pedido actualizado.\n{resultDetallesModificados} detalle(s) actualizado(s).\n" +
                        $"{resultDetallesAñadidos} detalle(s) registrado(s).\n{resultadoEliminados} detalle(s) eliminado(s).\n¿Desea cerrar el editor?",
                            "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (resultadoDelDialgo == DialogResult.Yes)
                        {
                            Close();
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MetroMessageBox.Show(this, $"¡Ha ocurrido un error!\nMÁS INFORMACIÓN: {error.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEliminarDetallePedido_Click(object sender, EventArgs e)
        {
            DialogResult resultadoDelCuadro = MetroFramework.MetroMessageBox.Show(this, "¿Desea eliminar el detalle del pedido?", "Aviso", 
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resultadoDelCuadro==DialogResult.Yes)
            {
                if (idPedido==null)
                {
                    int idDetallePedidoAEliminar = int.Parse(dgvListadoDetallesPedido.SelectedRows[0].Cells[0].Value.ToString());
                    dgvListadoDetallesPedido.Rows.RemoveAt(dgvListadoDetallesPedido.SelectedRows[0].Index);
                    listadoDetallesPedido.Remove(listadoDetallesPedido.Find(x => x.Id == idDetallePedidoAEliminar));
                    ActualizarDatagridView();
                    
                }
                else
                {
                    int idDetallePedidoAEliminar = int.Parse(dgvListadoDetallesPedido.SelectedRows[0].Cells[0].Value.ToString());
                    dgvListadoDetallesPedido.Rows.RemoveAt(dgvListadoDetallesPedido.SelectedRows[0].Index);
                    DetallePedido detalleAEliminar = listadoDetallesPedido.Find(x => x.Id == idDetallePedidoAEliminar);
                    listadoDetallesPedido.Remove(detalleAEliminar);
                    ActualizarDatagridView();
                    if (listadoViejoDetallesPedido.Find(x=>x.Id==detalleAEliminar.Id)!=null)
                    {
                        for (int i = 0; i < listadoViejoDetallesPedido.Count; i++)
                        {
                            if (listadoViejoDetallesPedido[i].Id==detalleAEliminar.Id)
                            {
                                listadoViejoDetallesPedido.RemoveAt(i);
                            }
                        }
                        detallesViejosAEliminarDeLaBD.Add(detalleAEliminar.Id);
                    }
                }
                if (dgvListadoDetallesPedido.Rows.Count < 1) epValidadorControles.SetError(dgvListadoDetallesPedido, "Debe agregar al menos un detalle");
                HabilitarBotonGuardarPedido();
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

        private void cmbEstadoPedido_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbEstadoPedido.SelectedIndex > 0)
            {
                epValidadorControles.SetError(cmbEstadoPedido, "");
                if ((int)cmbListadoClientes.SelectedValue==0)
                {
                    cmbListadoClientes.DroppedDown = true;
                    Cursor = Cursors.Arrow;
                }
                HabilitarBotonGuardarPedido();
            }
            else
            {
                HabilitarBotonGuardarPedido();
            }
        }

        void HabilitarBotonGuardarPedido()
        {
            if (
                cmbEstadoPedido.SelectedIndex > 0 && (int)cmbListadoClientes.SelectedValue > 0 &&
                (!string.IsNullOrWhiteSpace(txtDireccionEntregaPedido.Text)) && dgvListadoDetallesPedido.Rows.Count > 0
                )
            {
                btnGuardarPedido.Enabled = true;
            }
            else btnGuardarPedido.Enabled = false;
        }

        private void txtDireccionEntregaPedido_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDireccionEntregaPedido.Text))
            {
                epValidadorControles.SetError(txtDireccionEntregaPedido, "");
                if (cmbEstadoPedido.SelectedIndex==0) epValidadorControles.SetError(cmbEstadoPedido, "Debe seleccionar un estado");
                if ((int)cmbListadoClientes.SelectedValue==0) epValidadorControles.SetError(cmbListadoClientes, "Debe seleccionar un cliente");
                HabilitarBotonGuardarPedido();
            }
            else
            {
                epValidadorControles.SetError(txtDireccionEntregaPedido, "Este campo es obligatorio");
                HabilitarBotonGuardarPedido();
            }
        }

        private void dgvListadoDetallesPedido_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            epValidadorControles.SetError(dgvListadoDetallesPedido, "");
            HabilitarBotonGuardarPedido();
        }

        private void cmbEstadoPedido_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbEstadoPedido.SelectedIndex==0)
            {
                epValidadorControles.SetError(cmbEstadoPedido, "Debe seleccionar un estado.");
            }
        }

        private void cmbListadoClientes_DropDownClosed(object sender, EventArgs e)
        {
            if ((int)cmbListadoClientes.SelectedValue == 0)
            {
                epValidadorControles.SetError(cmbListadoClientes, "Debe seleccionar un cliente.");
            }
        }
    }
}
