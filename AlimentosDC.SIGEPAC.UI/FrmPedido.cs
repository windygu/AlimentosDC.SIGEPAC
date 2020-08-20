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
        Pedido pedidoEditando;
        int? idDetallePedidoAEditar = null;
        Producto producto;
        int? idPedido = null;
        //Listado a usarse en un nuevo pedido
        public List<DetallePedido> listadoDetallesPedido = new List<DetallePedido>();
        //Listados a usarse en la modificación de un pedido
        public List<DetallePedido> listadoViejoDetallesPedido = new List<DetallePedido>();
        public List<int> detallesViejosAEliminarDeLaBD = new List<int>();
        Cliente cliente = null;
        //Constructor para un nuevo pedido
        public FrmPedido(ref FrmPedidos objetoPedidosActual)
        {
            InitializeComponent();
            this.objetoPedidosActual = objetoPedidosActual;
            objetoPedidoActual = this;
            dtpFechaCreacion.Focus();
        }

        //Constructor para editar un pedido
        public FrmPedido(ref FrmPedidos objetoPedidosActual, int idPedido)
        {
            InitializeComponent();
            objetoPedidoActual = this;
            this.objetoPedidosActual = objetoPedidosActual;
            this.idPedido = idPedido;
            dtpFechaCreacion.Focus();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            btnGuardarPedido.Enabled = false;
            try
            {
                if (idPedido == null)
                {

                    lblNumeroPedido.Text = PedidoBL.GenerarNumeroPedido();
                    lblCCF.Text = PedidoBL.generarNumeroCCF();
                    cmbEstadoPedido.SelectedIndex = 0;

                }
                else
                {
                    CargarDatosAlFormulario();

                }
            }
            catch (Exception error)
            {
                MetroMessageBox.Show(this, $"¡Ha ocurrido un error!\nMÁS INFORMACIÓN: {error.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        void CargarDatosAlFormulario()
        {
            pedidoEditando = PedidoBL.BuscarPorId((int) idPedido);
            lblNumeroPedido.Text = pedidoEditando.NumeroPedido.ToString();
            lblCCF.Text = pedidoEditando.NumeroCCF;
            dtpFechaCreacion.Value = pedidoEditando.FechaCreacion;
            dtpFechaEntrega.Value = pedidoEditando.FechaEntrega;
            cmbEstadoPedido.SelectedItem = pedidoEditando.Estado;
            txtDireccionEntregaPedido.Text = pedidoEditando.DireccionEntrega;
            cliente = ClienteBL.BuscarPorId(pedidoEditando.IdCliente);
            lblCliente.Text = string.Concat(cliente.PrimerNombre, " ", cliente.SegundoNombre, " ",
                cliente.PrimerApellido, " ", cliente.SegundoApellido);
            lblDui.Text = cliente.DUI;
            listadoViejoDetallesPedido = DetallePedidoBL.ObtenerTodos((int)idPedido);
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

        //Método para ir agregando cada detalle (anteriormente agregado a la lista) al datagrid
        public void CargarListadoDetalles()
        {
            int indiceFilaAgregada = dgvListadoDetallesPedido.Rows.Add();
            bool existeSumas = false;
            for (int i = 0; i < dgvListadoDetallesPedido.RowCount; i++)
            {
                if (dgvListadoDetallesPedido.Rows[i].Cells[5].Value!=null)
                {
                    if (dgvListadoDetallesPedido.Rows[i].Cells[5].Value.ToString()=="SUMAS")
                    {
                        existeSumas = true;
                    }
                }
            }
            if (existeSumas == true)
            {
                indiceFilaAgregada = indiceFilaAgregada - 3;
            }

            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[0].Value = listadoDetallesPedido[indiceFilaAgregada].Id;
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[1].Value = listadoDetallesPedido[indiceFilaAgregada].Cantidad;
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[2].Value = listadoDetallesPedido[indiceFilaAgregada].Producto;
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[3].Value = listadoDetallesPedido[indiceFilaAgregada].Descripcion;
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[4].Value = listadoDetallesPedido[indiceFilaAgregada].Estado;
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[5].Value = listadoDetallesPedido[indiceFilaAgregada].PrecioUnitario;
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[6].Value = listadoDetallesPedido[indiceFilaAgregada].SubTotal;
            CalcularTotales();
        }
        public void ActualizarDatagridView()
        {
            dgvListadoDetallesPedido.Rows.Clear();
            for (int i = 0; i < listadoDetallesPedido.Count; i++)
            {
                CargarListadoDetalles();
            }
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
                        pedidoARegistrar.IdCliente = cliente.Id;
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
                            detallePedidoARegistrar.SubTotal = listadoDetallesPedido[i].SubTotal;
                            detallePedidoARegistrar.Estado = listadoDetallesPedido[i].Estado;
                            resultadoDetallePedido += DetallePedidoBL.Guardar(detallePedidoARegistrar);
                        }
                        objetoPedidosActual.CargarPedidos();
                        MetroMessageBox.Show(this, $"{resultadoPedido} pedido registrado.\n{resultadoDetallePedido} detalle(s) del pedido registrado(s).",
                            "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        FrmCCF comprobanteCreditoFiscal = new FrmCCF(int.Parse(lblNumeroPedido.Text));
                        comprobanteCreditoFiscal.Owner = this;
                        comprobanteCreditoFiscal.ShowDialog();
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
                           detallePedido.SubTotal = listadoDetallesPedido[i].SubTotal;
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
                txtDireccionEntregaPedido.Focus();
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
                cmbEstadoPedido.SelectedIndex > 0 && cliente!=null &&
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
                    lblPrecioUnitario.Text = producto.Precio.ToString();
                    lblStockProducto.Text = producto.Stock.ToString();
                    cmbEstadoDetallePedido.DroppedDown = true;
                }
                if (producto == null) epValidadorControles.SetError(btnElegirProducto, "Debe elegir un producto");
                else epValidadorControles.SetError(btnElegirProducto, "");
            }
            
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            AgregarDetalles();
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
                    detalle.Cantidad = ushort.Parse(txtCantidad.Text);
                    detalle.PrecioUnitario = producto.Precio;
                    detalle.SubTotal = float.Parse(lblSubTotal.Text);
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
                detallePedidoAAgregar.Cantidad = ushort.Parse(txtCantidad.Text);
                detallePedidoAAgregar.PrecioUnitario = producto.Precio;
                detallePedidoAAgregar.SubTotal = float.Parse(lblSubTotal.Text);
                detallePedidoAAgregar.Estado = cmbEstadoDetallePedido.SelectedItem.ToString();
                int idUltimoDetalle;
                if (listadoDetallesPedido.Count >= 1)
                {
                    idUltimoDetalle = objetoPedidoActual.listadoDetallesPedido[listadoDetallesPedido.Count - 1].Id;
                }
                else idUltimoDetalle = 0;
                detallePedidoAAgregar.Id = idUltimoDetalle + 1;
                if (listadoDetallesPedido.Exists(x => x.IdProducto == detallePedidoAAgregar.IdProducto))
                {
                    MetroMessageBox.Show(this, "Ya agregó este producto a la lista.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);
                    txtCantidad.Clear();
                    txtCantidad.Focus();
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
            if (listadoDetallesPedido.Count>=1)
            {
                foreach (var item in listadoDetallesPedido)
                {
                    sumas += item.SubTotal;
                }
                iva = sumas * 0.13;
                total = sumas + iva;
                
                for (int i = 0; i < dgvListadoDetallesPedido.RowCount; i++)
                {
                    if (dgvListadoDetallesPedido.Rows[i].Cells[5].Value!=null)
                    {
                        if (dgvListadoDetallesPedido.Rows[i].Cells[5].Value.ToString() == "SUMAS" ||
                            dgvListadoDetallesPedido.Rows[i].Cells[5].Value.ToString() == "IVA" ||
                            dgvListadoDetallesPedido.Rows[i].Cells[5].Value.ToString() == "TOTAL")
                        {
                            dgvListadoDetallesPedido.Rows.RemoveAt(i);
                        }
                    }

                    //ME QUEDE AQUI BUSCANDO EL ERROR QUE AL AGREGAR UN SEGUNDO DETALLE NO SE AGREGAN CORRECTAMENTE LOS TOTALES
                }
                
            }

            int indiceFilaSumasAgregada = dgvListadoDetallesPedido.Rows.Add();
            int indiceFilaIvaAgregada = dgvListadoDetallesPedido.Rows.Add();
            int indiceFilaTotalAgregada = dgvListadoDetallesPedido.Rows.Add();
            dgvListadoDetallesPedido.Rows[indiceFilaSumasAgregada].Cells[5].Value = "SUMAS";
            dgvListadoDetallesPedido.Rows[indiceFilaSumasAgregada].Cells[6].Value = sumas;
            dgvListadoDetallesPedido.Rows[indiceFilaIvaAgregada].Cells[5].Value = "IVA";
            dgvListadoDetallesPedido.Rows[indiceFilaIvaAgregada].Cells[6].Value = iva;
            dgvListadoDetallesPedido.Rows[indiceFilaTotalAgregada].Cells[5].Value = "TOTAL";
            dgvListadoDetallesPedido.Rows[indiceFilaTotalAgregada].Cells[6].Value = total;
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
            lblPrecioUnitario.Text = producto.Precio.ToString();
            lblDescripcionProducto.Text = producto.Descripcion;
            lblStockProducto.Text = producto.Stock.ToString();
            txtCantidad.Text = detalleAEditar.Cantidad.ToString();
            lblSubTotal.Text = detalleAEditar.SubTotal.ToString();
            cmbEstadoDetallePedido.SelectedItem = detalleAEditar.Estado;
        }
        void LimpiarDetalles()
        {
            txtCantidad.Clear();
            lblNombreProducto.Text = "";
            lblDescripcionProducto.Text = "";
            lblPrecioUnitario.Text = "";
            lblStockProducto.Text = "";
            lblSubTotal.Text = "";
            cmbEstadoDetallePedido.SelectedIndex = 0;
            producto = null;
            idDetallePedidoAEditar = null;
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Text.Length > 0 && lblPrecioUnitario.Text.Length > 0)
            {
                epValidadorControles.SetError(txtCantidad, "");
                lblSubTotal.Text = (float.Parse(lblPrecioUnitario.Text) * float.Parse(txtCantidad.Text)).ToString();
                int stock = producto.Stock;
                int stockMinimo = 10;
                lblStockProducto.Text = (stock - int.Parse(txtCantidad.Text)).ToString();
                if ((stock - int.Parse(txtCantidad.Text)) < stockMinimo)
                {
                    MetroMessageBox.Show(this, "Las existencias mínimas de este producto deben ser 10 unidades.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantidad.Text = "";
                }
                HabilitarBotonAgregarDetalle();
            }
            else if (txtCantidad.TextLength >= 1)
            {
                epValidadorControles.SetError(txtCantidad, "");
                epValidadorControles.SetError(btnElegirProducto, "Debe seleccionar un producto");
                if (cmbEstadoDetallePedido.SelectedIndex == 0) epValidadorControles.SetError(cmbEstadoDetallePedido, "Debe seleccionar un estado");
            }
            else
            {
                lblSubTotal.Text = "0.00";
                if (producto!=null)
                {
                    lblStockProducto.Text = producto.Stock.ToString();
                }
                epValidadorControles.SetError(txtCantidad, "Este campo es obligatorio");
                HabilitarBotonAgregarDetalle();
            }
        }
        void HabilitarBotonAgregarDetalle()
        {
            if (producto!=null && cmbEstadoDetallePedido.SelectedIndex > 0 &&
                txtCantidad.Text.Length >= 1
                )
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
                HabilitarBotonGuardarPedido();
                txtCantidad.Focus();
            }
            else
            {
                epValidadorControles.SetError(cmbEstadoDetallePedido, "Debe seleccionar un estado del detalle");
                HabilitarBotonAgregarDetalle();
                HabilitarBotonGuardarPedido();
            }
        }
    }

    //CONTINUAR CORRIENDO LOS ERRORES 
}
