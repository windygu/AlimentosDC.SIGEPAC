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
    public partial class FrmDetallePedido : MetroForm
    {
        List<Producto> listadoProductos;
        FrmPedido objetoPedidoActual;
        int? idDetallePedidoAEditar = null;
        DetallePedido detallePedidoAEditar;
        CultureInfo cultura = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();

        //Constructor para un nuevo detalle de un nuevo pedido
        public FrmDetallePedido(ref FrmPedido objetoPedidoActual)
        {
            InitializeComponent();
            this.objetoPedidoActual = objetoPedidoActual;
            cultura.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = cultura;
            
        }
        //Constructor para editar un detalle de un nuevo o viejo pedido
        public FrmDetallePedido(ref FrmPedido objetoPedidoActual, int? idDetallePedidoAEditar)
        {
            InitializeComponent();
            cultura.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = cultura;
            this.objetoPedidoActual = objetoPedidoActual;
            this.idDetallePedidoAEditar = idDetallePedidoAEditar;
            btnAgregarDetallePedido.Enabled = false;
        }

        private void FrmDetallePedido_Load(object sender, EventArgs e)
        {
            btnAgregarDetallePedido.Enabled = false;
            listadoProductos = ProductoBL.ObtenerTodos();
            listadoProductos.Insert(0, new Producto() { Id = 0, Nombre = "- Seleccione -" });
            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.ValueMember = "Id";
            cmbProducto.DataSource = listadoProductos;
            cmbEstadoDetallePedido.SelectedIndex = 0;
            epValidarControles.Clear();
            if (idDetallePedidoAEditar != null)
            { 
                detallePedidoAEditar = objetoPedidoActual.listadoDetallesPedido.Find(x => x.Id == idDetallePedidoAEditar);
                btnAgregarDetallePedido.Text = "Actualizar";
                CargarDatosAlFormulario();
                txtCantidad.Focus();
            }
        }
        void CargarDatosAlFormulario()
        {
            cmbProducto.SelectedValue = detallePedidoAEditar.IdProducto;
            cmbEstadoDetallePedido.SelectedItem = detallePedidoAEditar.Estado;
            txtCantidad.Text = detallePedidoAEditar.Cantidad.ToString();
        }

        private void btnCerrarDetallePedido_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCantidad.Text.Length > 0 && lblPrecioUnitario.Text.Length > 0)
                {
                    epValidarControles.SetError(txtCantidad, "");
                    lblSubTotal.Text = (float.Parse(lblPrecioUnitario.Text) * float.Parse(txtCantidad.Text)).ToString();
                    int stock = (cmbProducto.SelectedItem as Producto).Stock;
                    int stockMinimo = 10;
                    lblExistencias.Text = (stock - int.Parse(txtCantidad.Text)).ToString();
                    if ((stock - int.Parse(txtCantidad.Text)) < stockMinimo)
                    {
                        MetroMessageBox.Show(this, "Las existencias mínimas de este producto deben ser 10 unidades.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCantidad.Text = "";
                    }
                    HabilitarBotonAgregarDetalle();
                }
                else if (txtCantidad.TextLength >= 1)
                {
                    epValidarControles.SetError(txtCantidad, "");
                    epValidarControles.SetError(cmbProducto, "Debe seleccionar un producto");
                    if (cmbEstadoDetallePedido.SelectedIndex == 0) epValidarControles.SetError(cmbEstadoDetallePedido, "Debe seleccionar un estado");
                }
                else
                {
                    lblSubTotal.Text = "0.00";
                    if ((int)cmbProducto.SelectedValue > 0)
                    {
                        lblExistencias.Text = (cmbProducto.SelectedItem as Producto).Stock.ToString();
                    }
                    epValidarControles.SetError(txtCantidad, "Este campo es obligatorio");
                    HabilitarBotonAgregarDetalle();
                }
            }
            catch (Exception er)
            {
                MetroMessageBox.Show(this, er.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void HabilitarBotonAgregarDetalle()
        {
            if ((int)cmbProducto.SelectedValue > 0 && cmbEstadoDetallePedido.SelectedIndex > 0 &&
                txtCantidad.Text.Length >= 1
                )
            {
                btnAgregarDetallePedido.Enabled = true;
            }
            else btnAgregarDetallePedido.Enabled = false;
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char) Keys.Back)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }

        private void cmbProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblSubTotal.Text = "0.00";
            txtCantidad.Text = "";
            if ((int)cmbProducto.SelectedValue>0)
            {
                epValidarControles.SetError(cmbProducto, "");
                int id = (int)cmbProducto.SelectedValue;
                lblPrecioUnitario.Text = (ProductoBL.BuscarPorId(id)).Precio.ToString();
                lblDescripcion.Text = (ProductoBL.BuscarPorId(id)).Descripcion;
                lblExistencias.Text = (ProductoBL.BuscarPorId(id)).Stock.ToString();
                if (idDetallePedidoAEditar == null && cmbEstadoDetallePedido.SelectedIndex == 0) cmbEstadoDetallePedido.DroppedDown = true;
                HabilitarBotonAgregarDetalle();
            }
            else
            {
                lblPrecioUnitario.Text = "";
                lblDescripcion.Text = "";
                lblExistencias.Text = "";
                epValidarControles.SetError(cmbProducto, "Debe seleccionar un producto");
                HabilitarBotonAgregarDetalle();
            }
        }

        private void btnAgregarDetallePedido_Click(object sender, EventArgs e)
        {
            AgregarDetallePedido();
        }

        void AgregarDetallePedido()
        {
            try
            {
                if (idDetallePedidoAEditar != null)
                {
                    foreach (DetallePedido detalle in objetoPedidoActual.listadoDetallesPedido.Where(x => x.Id == idDetallePedidoAEditar))
                    {
                        detalle.IdProducto = (cmbProducto.SelectedItem as Producto).Id;
                        detalle.Producto = (cmbProducto.SelectedItem as Producto).Nombre;
                        detalle.Descripcion = (cmbProducto.SelectedItem as Producto).Descripcion;
                        detalle.Cantidad = ushort.Parse(txtCantidad.Text);
                        detalle.PrecioUnitario = (cmbProducto.SelectedItem as Producto).Precio;
                        detalle.SubTotal = float.Parse(lblSubTotal.Text);
                        detalle.Estado = cmbEstadoDetallePedido.SelectedItem.ToString();
                    }
                    objetoPedidoActual.ActualizarDatagridView();
                    Close();
                }
                else
                {
                    DetallePedido detallePedido = new DetallePedido();
                    detallePedido.IdProducto = (cmbProducto.SelectedItem as Producto).Id;
                    detallePedido.Producto = (cmbProducto.SelectedItem as Producto).Nombre;
                    detallePedido.Descripcion = (cmbProducto.SelectedItem as Producto).Descripcion;
                    detallePedido.Cantidad = ushort.Parse(txtCantidad.Text);
                    detallePedido.PrecioUnitario = (cmbProducto.SelectedItem as Producto).Precio;
                    detallePedido.SubTotal = float.Parse(lblSubTotal.Text);
                    detallePedido.Estado = cmbEstadoDetallePedido.SelectedItem.ToString();
                    int idUltimoDetalle;
                    if (objetoPedidoActual.listadoDetallesPedido.Count >= 1)
                    {
                        idUltimoDetalle = objetoPedidoActual.listadoDetallesPedido[objetoPedidoActual.listadoDetallesPedido.Count - 1].Id;
                    }
                    else idUltimoDetalle = 0;
                    detallePedido.Id = idUltimoDetalle + 1;
                    if (objetoPedidoActual.listadoDetallesPedido.Exists(x => x.IdProducto == detallePedido.IdProducto))
                    {
                        MetroMessageBox.Show(this, "Ya agregó este producto a la lista.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1);
                        txtCantidad.Clear();
                        txtCantidad.Focus();
                    }
                    else
                    {
                        objetoPedidoActual.listadoDetallesPedido.Add(detallePedido);
                        objetoPedidoActual.CargarListadoDetalles();
                        Limpiar();
                    }
                }
            }
            catch (Exception error)
            {
                MetroMessageBox.Show(this, $"¡Ha ocurrido un error!\nMÁS INFORMACIÓN: {error.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Close();
            }
            
        }

        private void cmbEstadoDetallePedido_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbEstadoDetallePedido.SelectedIndex > 0)
            {
                epValidarControles.SetError(cmbEstadoDetallePedido, "");
                HabilitarBotonAgregarDetalle();
            }
            else epValidarControles.SetError(cmbEstadoDetallePedido, "Debe seleccionar un estado");
            txtCantidad.Focus();            
        }

        void Limpiar()
        {
            cmbProducto.SelectedValue = 0;
            cmbEstadoDetallePedido.SelectedIndex = 0;
            lblDescripcion.Text = "";
            lblExistencias.Text = "";
            lblPrecioUnitario.Text = "";
            txtCantidad.Clear();
            epValidarControles.Clear();
            cmbProducto.Focus();
        }

        private void cmbProducto_DropDownClosed(object sender, EventArgs e)
        {
            if ((int)cmbProducto.SelectedValue==0)
            {
                epValidarControles.SetError(cmbProducto, "Debe seleccionar un producto");
            }
        }

        private void cmbEstadoDetallePedido_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbEstadoDetallePedido.SelectedIndex == 0)
            {
                epValidarControles.SetError(cmbEstadoDetallePedido, "Debe seleccionar un estado");
            }
        }
    }
}
