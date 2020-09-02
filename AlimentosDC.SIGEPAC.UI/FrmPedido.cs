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
using System.Globalization;
using System.Threading;

namespace AlimentosDC.SIGEPAC.UI
{
    public partial class FrmPedido : MetroForm
    {
        FrmPedido objetoPedidoActual;
        FrmHistoriales objetoPedidosActual;
        Pedido pedidoEditando;
        int? idDetallePedidoAEditar = null;
        Producto producto;
        int? idPedido = null;
        public List<DetallePedido> listadoDetallesPedido = new List<DetallePedido>();
        public List<DetallePedido> listadoViejoDetallesPedido = new List<DetallePedido>();
        public List<int> detallesViejosAEliminarDeLaBD = new List<int>();
        Cliente cliente;
        Usuario usuarioActual;
        double totalAPagar = 0;
        public FrmPedido(Usuario usuarioActual)
        {
            InitializeComponent();
            objetoPedidoActual = this;
            this.usuarioActual = usuarioActual;

        }

        //Constructor para editar un pedido
        public FrmPedido(FrmHistoriales objetoPedidosActual, int idPedido)
        {
            InitializeComponent();
            this.objetoPedidosActual = objetoPedidosActual;
            objetoPedidoActual = this;
            this.idPedido = idPedido;
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            try
            {
                if (idPedido == null)
                {
                    lblNumeroPedido.Text = PedidoBL.GenerarNumeroPedido();
                    lblCCF.Text = PedidoBL.generarNumeroCCF();
                    cmbEstadoPedido.SelectedIndex = 0;
                    cmbEstadoDetallePedido.SelectedIndex = 0;
                    dtpFechaCreacion.Focus();
                }
                else
                {
                    CargarDatosAlFormulario();
                    btnGuardarPedido.Text = "Actualizar pedido";
                    dtpFechaCreacion.Focus();
                }
                nudCantidad.TextChanged += NudCantidad_TextChanged;
            }
            catch (Exception error)
            {
                MetroMessageBox.Show(this, $"¡Ha ocurrido un error!\nMÁS INFORMACIÓN: {error.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Close();
            }
        }

        private void NudCantidad_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nudCantidad.Text))
            {
                nudCantidad.Value = 0;
            }
            HabilitarBotonAgregarDetalle();
        }

        void CargarDatosAlFormulario()
        {
            pedidoEditando = PedidoBL.BuscarPorId((int) idPedido);
            lblNumeroPedido.Text = pedidoEditando.NumeroPedido.ToString();
            lblCCF.Text = pedidoEditando.NumeroCCF;
            dtpFechaEntrega.Value = pedidoEditando.FechaEntrega;
            cmbEstadoPedido.SelectedItem = pedidoEditando.Estado;
            dtpFechaCreacion.Value = pedidoEditando.FechaCreacion;
            txtDireccionEntregaPedido.Text = pedidoEditando.DireccionEntrega;
            cliente = ClienteBL.BuscarPorId(pedidoEditando.IdCliente);
            lblCliente.Text = string.Concat(cliente.PrimerNombre, " ", cliente.SegundoNombre, " ",
                cliente.PrimerApellido, " ", cliente.SegundoApellido);
            lblDui.Text = cliente.DUI;
            listadoViejoDetallesPedido = DetallePedidoBL.ObtenerTodos((int)idPedido);
            cmbEstadoDetallePedido.SelectedIndex = 0;
            if (listadoViejoDetallesPedido!=null)
            {
                for (int i = 0; i < listadoViejoDetallesPedido.Count; i++)
                {
                    dgvListadoDetallesPedido.Rows.Add();
                    dgvListadoDetallesPedido.Rows[i].Cells[0].Value = listadoViejoDetallesPedido[i].Id;
                    dgvListadoDetallesPedido.Rows[i].Cells[1].Value = listadoViejoDetallesPedido[i].Cantidad;
                    dgvListadoDetallesPedido.Rows[i].Cells[2].Value = listadoViejoDetallesPedido[i].Producto;
                    dgvListadoDetallesPedido.Rows[i].Cells[3].Value = listadoViejoDetallesPedido[i].Descripcion;
                    dgvListadoDetallesPedido.Rows[i].Cells[4].Value = listadoViejoDetallesPedido[i].Estado;
                    dgvListadoDetallesPedido.Rows[i].Cells[5].Value = listadoViejoDetallesPedido[i].PrecioUnitario;
                    dgvListadoDetallesPedido.Rows[i].Cells[6].Value = listadoViejoDetallesPedido[i].SubTotal;
                    listadoDetallesPedido.Add(listadoViejoDetallesPedido[i]);
                }
                CalcularTotales();
            }
        }

        //Método para ir agregando cada detalle (anteriormente agregado a la 'listadoDetallesPedido') al datagrid
        public void CargarListadoDetalles()
        {
            //Eliminamos los totales para poder colocar los nuevos
            if (dgvListadoDetallesPedido.RowCount>=1)
            {
                int indiceSumas = 0, indiceIva = 0, indiceTotal = 0;
                for (int i = 0; i < dgvListadoDetallesPedido.Rows.Count; i++)
                {
                    switch (dgvListadoDetallesPedido.Rows[i].Cells[5].Value.ToString())
                    {
                        case "TOTAL":
                            indiceTotal = i;
                            break;
                        case "IVA (13%)":
                            indiceIva = i;
                            break;
                        case "SUMAS": indiceSumas = i;
                            break;
                    }
                }
                dgvListadoDetallesPedido.Rows.RemoveAt(indiceTotal);
                dgvListadoDetallesPedido.Rows.RemoveAt(indiceIva);
                dgvListadoDetallesPedido.Rows.RemoveAt(indiceSumas);
            }
            //Agregamos un a fila al datagrid y obtenemos su indice
            int indiceFilaAgregada = dgvListadoDetallesPedido.Rows.Add();
            //Trasladamos los datos del detalle agregado la 'listadoDetallesPedido' a la fila agregada al datagrid
            //Sus indices coinciden perfectamente
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[0].Value = listadoDetallesPedido[indiceFilaAgregada].Id;
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[1].Value = listadoDetallesPedido[indiceFilaAgregada].Cantidad;
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[2].Value = listadoDetallesPedido[indiceFilaAgregada].Producto;
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[3].Value = listadoDetallesPedido[indiceFilaAgregada].Descripcion;
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[4].Value = listadoDetallesPedido[indiceFilaAgregada].Estado;
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[5].Value = listadoDetallesPedido[indiceFilaAgregada].PrecioUnitario;
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[6].Value = listadoDetallesPedido[indiceFilaAgregada].SubTotal;
            CalcularTotales();
        }
        
        void AgregarDetalles()
        {
            if (idDetallePedidoAEditar != null)
            {
                foreach (DetallePedido detalle in listadoDetallesPedido.Where(x => x.Id == idDetallePedidoAEditar))
                {
                    detalle.IdProducto = producto.Id;
                    detalle.Producto = producto.Nombre;
                    detalle.Descripcion = producto.Descripcion;
                    detalle.Cantidad = ushort.Parse(nudCantidad.Text);
                    detalle.PrecioUnitario = producto.PrecioVenta;
                    detalle.SubTotal = ushort.Parse(nudCantidad.Text) * producto.PrecioVenta;
                    detalle.Estado = cmbEstadoDetallePedido.SelectedItem.ToString();
                }
                ActualizarDatagridView();
                LimpiarDetalles();
                btnAgregarDetalle.Text = "Agregar detalle";
            }

            else
            {
                DetallePedido detallePedidoAAgregar = new DetallePedido();
                detallePedidoAAgregar.IdProducto = producto.Id;
                detallePedidoAAgregar.Producto = producto.Nombre;
                detallePedidoAAgregar.Descripcion = producto.Descripcion;
                detallePedidoAAgregar.Cantidad = ushort.Parse(nudCantidad.Text);
                detallePedidoAAgregar.PrecioUnitario = producto.PrecioVenta;
                detallePedidoAAgregar.SubTotal = ushort.Parse(nudCantidad.Text) * producto.PrecioVenta;
                detallePedidoAAgregar.Estado = cmbEstadoDetallePedido.SelectedItem.ToString();
                int idUltimoDetalle;
                if (listadoDetallesPedido.Count >= 1)
                {
                    idUltimoDetalle = listadoDetallesPedido[listadoDetallesPedido.Count - 1].Id;
                }
                else idUltimoDetalle = 0;
                detallePedidoAAgregar.Id = idUltimoDetalle + 1;
                if (listadoDetallesPedido.Exists(x => x.IdProducto == detallePedidoAAgregar.IdProducto))
                {
                    MetroMessageBox.Show(this, "Ya agregó este producto a la lista.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);
                    nudCantidad.ResetText();
                    nudCantidad.Focus();
                }
                else
                {
                    listadoDetallesPedido.Add(detallePedidoAAgregar);
                    CargarListadoDetalles();
                    LimpiarDetalles();
                }
            }
        }

        void CalcularTotales()
        {
            double sumas = 0.00f, iva = 0.00f, total = 0.00f;
            if (listadoDetallesPedido.Count >= 1)
            {
                foreach (var item in listadoDetallesPedido)
                {
                    sumas += item.SubTotal;
                }
                iva = sumas * 0.13;
                total = sumas + iva;
                totalAPagar = 0;
                totalAPagar = total;
            }
            int indiceFilaSumasAgregada = dgvListadoDetallesPedido.Rows.Add();
            int indiceFilaIvaAgregada = dgvListadoDetallesPedido.Rows.Add();
            int indiceFilaTotalAgregada = dgvListadoDetallesPedido.Rows.Add();
            dgvListadoDetallesPedido.Rows[indiceFilaSumasAgregada].Cells[5].Value = "SUMAS";
            dgvListadoDetallesPedido.Rows[indiceFilaSumasAgregada].Cells[6].Value = sumas;
            dgvListadoDetallesPedido.Rows[indiceFilaIvaAgregada].Cells[5].Value = "IVA (13%)";
            dgvListadoDetallesPedido.Rows[indiceFilaIvaAgregada].Cells[6].Value = iva;
            dgvListadoDetallesPedido.Rows[indiceFilaTotalAgregada].Cells[5].Value = "TOTAL";
            dgvListadoDetallesPedido.Rows[indiceFilaTotalAgregada].Cells[6].Value = total;
            txtPagaCon.Clear();
        }

        //Mètodo para actualizar los datos del datagrid solo en el caso que el usuario modifique un detalle
        public void ActualizarDatagridView()
        {
            dgvListadoDetallesPedido.Rows.Clear();
            for (int i = 0; i < listadoDetallesPedido.Count; i++)
            {
                CargarListadoDetalles();
            }
            txtPagaCon.Clear();
        }
        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            AgregarDetalles();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        void Limpiar()
        {
            lblNumeroPedido.Text = PedidoBL.GenerarNumeroPedido();
            lblCCF.Text = PedidoBL.generarNumeroCCF();
            dtpFechaCreacion.Value = DateTime.Now;
            dtpFechaEntrega.Value = DateTime.Now;
            cmbEstadoPedido.SelectedIndex = 0;
            cmbEstadoDetallePedido.SelectedIndex = 0;
            txtDireccionEntregaPedido.Clear();
            lblCliente.Text = "";
            lblDui.Text = "";
            cliente = null;
            LimpiarDetalles();
            dgvListadoDetallesPedido.Rows.Clear();
            listadoDetallesPedido.Clear();
            listadoViejoDetallesPedido.Clear();
            epValidadorControles.Clear();
            dtpFechaCreacion.Focus();
            txtPagaCon.Clear();
            totalAPagar = 0;
            lblCambio.Text = "";
        }

        private void btnGuardarPedido_Click(object sender, EventArgs e)
        {
            GuardarPedido();
        }

        void GuardarPedido()
        {
            Cursor = Cursors.WaitCursor;
        //    try
          //  {
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
                        pedidoARegistrar.IdCliente = cliente.Id;
                        pedidoARegistrar.IdUsuario = usuarioActual.Id;
                        pedidoARegistrar.NumeroPedido = int.Parse(lblNumeroPedido.Text);
                        pedidoARegistrar.FechaCreacion = dtpFechaCreacion.Value;
                        pedidoARegistrar.FechaEntrega = dtpFechaEntrega.Value;
                        pedidoARegistrar.DireccionEntrega = txtDireccionEntregaPedido.Text;
                        pedidoARegistrar.Estado = cmbEstadoPedido.SelectedItem.ToString();
                        pedidoARegistrar.NumeroCCF = lblCCF.Text;
                        resultadoPedido += PedidoBL.Guardar(pedidoARegistrar);
                        for (int i = 0; i < listadoDetallesPedido.Count; i++)
                        {
                            DetallePedido detallePedidoARegistrar = new DetallePedido();
                            detallePedidoARegistrar.IdPedido = (PedidoBL.BuscarPorNumeroPedido(int.Parse(lblNumeroPedido.Text))).Id;
                            detallePedidoARegistrar.IdProducto = listadoDetallesPedido[i].IdProducto;
                            detallePedidoARegistrar.Cantidad = listadoDetallesPedido[i].Cantidad;
                            detallePedidoARegistrar.PrecioUnitario = listadoDetallesPedido[i].PrecioUnitario;
                            detallePedidoARegistrar.Estado = listadoDetallesPedido[i].Estado;
                            resultadoDetallePedido += DetallePedidoBL.Guardar(detallePedidoARegistrar);
                        }
                        MetroMessageBox.Show(this, $"{resultadoPedido} pedido registrado.\n{resultadoDetallePedido} detalle(s) del pedido registrado(s).",
                            "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Thread hiloDos = new Thread(new ThreadStart(MostrarBarra));
                        hiloDos.Start();
                        FrmCCF informe = new FrmCCF(int.Parse(lblNumeroPedido.Text), ref hiloDos);
                        informe.ShowDialog();
                        Limpiar();
                }
                    else
                    {
                        int resultadoPedido = 0;
                        int resultDetallesModificados = 0;
                        int resultDetallesAñadidos = 0;
                        int resultadoEliminados = 0;

                        pedidoEditando.IdCliente = cliente.Id;
                        pedidoEditando.FechaCreacion = dtpFechaCreacion.Value;
                        pedidoEditando.FechaEntrega = dtpFechaEntrega.Value;
                        pedidoEditando.DireccionEntrega = txtDireccionEntregaPedido.Text;
                        pedidoEditando.Estado = cmbEstadoPedido.SelectedItem.ToString();
                        resultadoPedido += PedidoBL.Modificar(pedidoEditando);
                        for (int i = 0; i < listadoDetallesPedido.Count; i++)
                        {
                           DetallePedido detallePedido = new DetallePedido();
                           detallePedido.Id = listadoDetallesPedido[i].Id;
                           detallePedido.IdPedido = (int)idPedido;
                           detallePedido.IdProducto = listadoDetallesPedido[i].IdProducto;
                           detallePedido.Cantidad = listadoDetallesPedido[i].Cantidad;
                           detallePedido.PrecioUnitario = listadoDetallesPedido[i].PrecioUnitario;
                           detallePedido.Estado = listadoDetallesPedido[i].Estado;

                            if (listadoViejoDetallesPedido.Find(x => x.Id == listadoDetallesPedido[i].Id) != null)
                            {
                                resultDetallesModificados += DetallePedidoBL.Modificar(detallePedido);
                            }
                            else
                            {
                                resultDetallesAñadidos += DetallePedidoBL.Guardar(detallePedido);
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
       /*    }
            catch (Exception error)
            {
                 MetroMessageBox.Show(this, $"¡Ha ocurrido un error!\nMÁS INFORMACIÓN: {error.Message}", "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }*/
            Cursor = Cursors.Arrow;
        }

        void MostrarBarra()
        {
            Application.Run(new FrmCargando("Preparando comprobante..."));
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
                    if (listadoDetallesPedido.Remove(detalleAEliminar)==false)
                    {
                        throw new Exception
                        ("No se ha podido encontrar el detalle que se quiere eliminar de la lista 'listadoDetallesPedido'");
                    }
                    ActualizarDatagridView();
                    if (listadoViejoDetallesPedido.Find(x=>x.Id==detalleAEliminar.Id)!=null)
                    {
                        detallesViejosAEliminarDeLaBD.Add(detalleAEliminar.Id);
                    }
                }
                if (dgvListadoDetallesPedido.Rows.Count < 1) epValidadorControles.SetError(dgvListadoDetallesPedido, "Debe agregar al menos un detalle");
                HabilitarBotonGuardarPedido();
            }
        }

        private void dgvListadoDetallesPedido_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListadoDetallesPedido.SelectedRows.Count > 0 && 
                dgvListadoDetallesPedido.SelectedRows[0].Cells[0].Value != null)
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
                txtDireccionEntregaPedido.Focus();
                HabilitarBotonGuardarPedido();
            }
            else HabilitarBotonGuardarPedido();
        }

        void HabilitarBotonGuardarPedido()
        {
            if (
                cmbEstadoPedido.SelectedIndex > 0 && cliente!=null &&
                (!string.IsNullOrWhiteSpace(txtDireccionEntregaPedido.Text)) && dgvListadoDetallesPedido.RowCount > 0
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
            btnEditarDetallePedido.Enabled = true;
            btnEliminarDetallePedido.Enabled = true;
            HabilitarBotonGuardarPedido();
        }

        private void cmbEstadoPedido_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbEstadoPedido.SelectedIndex==0)
            {
                epValidadorControles.SetError(cmbEstadoPedido, "Debe seleccionar un estado.");
            }
            HabilitarBotonGuardarPedido();
        }

        private void btnElegirCliente_Click(object sender, EventArgs e)
        {
            FrmClientes clientes = new FrmClientes(objetoPedidoActual);
            clientes.Owner = this;
            clientes.ShowDialog();
            if (clientes.DialogResult==DialogResult.OK)
            {
                cliente = clientes.clienteSeleccionado;
                lblCliente.Text = string.Concat(cliente.PrimerNombre, " ", cliente.SegundoNombre, " ",
                    cliente.PrimerApellido, " ", cliente.SegundoApellido);
                lblDui.Text = cliente.DUI;
                btnElegirProducto.Focus();
            }
            if (cliente==null) epValidadorControles.SetError(btnElegirCliente, "Debe elegir un cliente");
            else epValidadorControles.SetError(btnElegirCliente, "");
        }

        private void btnElegirProducto_Click(object sender, EventArgs e)
        {
            if (cliente == null)
            {
                epValidadorControles.SetError(btnElegirCliente, "Debe elegir un cliente");
            }
            else
            {
                FrmProductos productos = new FrmProductos(objetoPedidoActual);
                productos.ShowDialog();
                if (productos.DialogResult == DialogResult.OK)
                {
                    producto = productos.productoSeleccionado;
                    lblNombreProducto.Text = producto.Nombre;
                    lblDescripcionProducto.Text = producto.Descripcion;
                    lblPrecioUnitario.Text = string.Concat("$ ", producto.PrecioVenta.ToString("N"));
                    lblStockProducto.Text = producto.Stock.ToString();
                    cmbEstadoDetallePedido.DroppedDown = true;
                }
                if (producto == null) epValidadorControles.SetError(btnElegirProducto, "Debe elegir un producto");
                else epValidadorControles.SetError(btnElegirProducto, "");
            }
        }

        private void btnEditarDetallePedido_Click(object sender, EventArgs e)
        {
            idDetallePedidoAEditar = (int)dgvListadoDetallesPedido.SelectedRows[0].Cells[0].Value;
            CargarDetallesAEditar();
            btnAgregarDetalle.Text = "Actualizar";
        }
        void CargarDetallesAEditar()
        {
            DetallePedido detalleAEditar = listadoDetallesPedido.Find(x => x.Id == idDetallePedidoAEditar);
            producto = ProductoBL.BuscarPorId(detalleAEditar.IdProducto);
            lblNombreProducto.Text = producto.Nombre;
            lblPrecioUnitario.Text = string.Concat("$ ", producto.PrecioVenta.ToString("N"));
            lblDescripcionProducto.Text = producto.Descripcion;
            lblStockProducto.Text = producto.Stock.ToString();
            nudCantidad.Text = detalleAEditar.Cantidad.ToString();
            lblSubTotal.Text = string.Concat("$ ", detalleAEditar.SubTotal.ToString("N"));
            cmbEstadoDetallePedido.SelectedItem = detalleAEditar.Estado;
            HabilitarBotonAgregarDetalle();
        }
        void LimpiarDetalles()
        {
            nudCantidad.Value = 0;
            lblNombreProducto.Text = "";
            lblDescripcionProducto.Text = "";
            lblPrecioUnitario.Text = "";
            lblStockProducto.Text = "";
            lblSubTotal.Text = "";
            cmbEstadoDetallePedido.SelectedIndex = 0;
            producto = null;
            idDetallePedidoAEditar = null;
            epValidadorControles.SetError(nudCantidad, "");
        }

        //private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
        //    {
        //        e.Handled = false;
        //    }
        //    else e.Handled = true;
        //}

        void HabilitarBotonAgregarDetalle()
        {
            if (producto!=null && cmbEstadoDetallePedido.SelectedIndex > 0 &&
                nudCantidad.Value > 0)
            {
                btnAgregarDetalle.Enabled = true;
            }
            else btnAgregarDetalle.Enabled = false;
        }

        private void cmbEstadoPedido_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            if (cmbEstadoPedido.SelectedIndex>0)
            {
                epValidadorControles.SetError(cmbEstadoPedido, "");
                HabilitarBotonAgregarDetalle();
                HabilitarBotonGuardarPedido();
                txtDireccionEntregaPedido.Focus();
            }
            else
            {
                epValidadorControles.SetError(cmbEstadoPedido, "Debe seleccionar un estado");
                HabilitarBotonAgregarDetalle();
                HabilitarBotonGuardarPedido();
            }
        }

        private void cmbEstadoPedido_DropDownClosed_1(object sender, EventArgs e)
        {
            if (cmbEstadoPedido.SelectedIndex==0)
            {
                epValidadorControles.SetError(cmbEstadoPedido, "Debe seleccionar un estado");
            }
        }

        private void cmbEstadoDetallePedido_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbEstadoDetallePedido.SelectedIndex == 0)
            {
                epValidadorControles.SetError(cmbEstadoDetallePedido, "Debe seleccionar un estado del detalle");
            }
        }

        private void cmbEstadoDetallePedido_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbEstadoDetallePedido.SelectedIndex > 0)
            {
                epValidadorControles.SetError(cmbEstadoDetallePedido, "");
                HabilitarBotonAgregarDetalle();
                nudCantidad.Focus();
            }
            else
            {
                epValidadorControles.SetError(cmbEstadoDetallePedido, "Debe seleccionar un estado del detalle");
                HabilitarBotonAgregarDetalle();
            }
        }

        private void txtPagaCon_TextChanged(object sender, EventArgs e)
        {
            if (dgvListadoDetallesPedido.RowCount>=1)
            {
                if (txtPagaCon.Text.Length>=1)
                {
                    switch (Validaciones.ValidarPrecio(txtPagaCon.Text))
                    {
                        case 1:
                            epValidadorControles.SetError(txtPagaCon, "Se permite hasta dos decimales");
                            break;
                        case 2:
                            epValidadorControles.SetError(txtPagaCon, "Dato incorrecto");
                            break;
                        case 0:
                            epValidadorControles.SetError(txtPagaCon, "");
                            lblCambio.Text = (float.Parse(txtPagaCon.Text) - Math.Round(totalAPagar, 2)).ToString("C");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    lblCambio.Text = "";
                }
            }
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (nudCantidad.Value > 0 && lblPrecioUnitario.Text.Length > 0)
            {
                epValidadorControles.SetError(nudCantidad, "");
                lblSubTotal.Text = string.Concat("$ ", (producto.PrecioVenta * (float)nudCantidad.Value).ToString("N"));
                lblStockProducto.Text = (producto.Stock - nudCantidad.Value).ToString();
                if (nudCantidad.Value>producto.Stock)
                {
                    MetroMessageBox.Show(this, "Hay menos productos en Stock que los solicitados.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nudCantidad.Value = 0;
                }
                HabilitarBotonAgregarDetalle();
            }
            else if (nudCantidad.Value > 0)
            {
                epValidadorControles.SetError(nudCantidad, "");
                epValidadorControles.SetError(btnElegirProducto, "Debe seleccionar un producto");
                if (cmbEstadoDetallePedido.SelectedIndex == 0) epValidadorControles.SetError(cmbEstadoDetallePedido, "Debe seleccionar un estado");
            }
            else
            {
                lblSubTotal.Text = "$ 0.00";
                if (producto != null)
                {
                    lblStockProducto.Text = producto.Stock.ToString();
                }
                epValidadorControles.SetError(nudCantidad, "Este campo es obligatorio");
                HabilitarBotonAgregarDetalle();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmPrincipal.delegadoCerrarSesion(null, null);
        }
    }
}
