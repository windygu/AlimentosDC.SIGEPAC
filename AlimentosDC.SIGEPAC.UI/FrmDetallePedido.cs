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
    public partial class FrmDetallePedido : MetroFramework.Forms.MetroForm
    {
        List<Producto> listadoProductos;
        FrmPedido objeto;
        int? idDetallePedidoAEditar = null;
        int? idPedidoEditando = null;
        DetallePedido detallePedidoAEditar;

        //Constructor para un nuevo detalle de un nuevo pedido
        public FrmDetallePedido(ref FrmPedido objeto)
        {
            InitializeComponent();
            btnAgregarDetallePedido.Enabled = false;
            listadoProductos = ProductoBL.ObtenerTodos();
            cmbProducto.Items.AddRange(listadoProductos.ToArray());
            this.objeto = objeto;
        }
        //Constructor para editar un detalle de un nuevo o viejo pedido
        public FrmDetallePedido(ref FrmPedido objeto, int? idPedidoEditando, int? idDetallePedidoAEditar)
        {
            InitializeComponent();
            btnAgregarDetallePedido.Enabled = false;
            listadoProductos = ProductoBL.ObtenerTodos();
            cmbProducto.Items.AddRange(listadoProductos.ToArray());
            this.idPedidoEditando = idPedidoEditando;
            this.idDetallePedidoAEditar = idDetallePedidoAEditar;
            this.objeto = objeto;
            if (idDetallePedidoAEditar != null)
            {
                detallePedidoAEditar = objeto.listadoDetallesPedido.Find(x => x.Id == idDetallePedidoAEditar);
                btnAgregarDetallePedido.Text = "Actualizar";
                CargarDatosAlFormulario();
                txtCantidad.Focus();
            }
            
        }

        void CargarDatosAlFormulario()
        {
            List<Producto> listadoProductos = ProductoBL.ObtenerTodos();
            Producto producto = ProductoBL.BuscarPorId(detallePedidoAEditar.IdProducto);
            int indiceDelProducto = listadoProductos.FindIndex(x => x.Id == producto.Id);
            cmbProducto.SelectedIndex = indiceDelProducto;
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
                    lblSubTotal.Text = (float.Parse(lblPrecioUnitario.Text) * float.Parse(txtCantidad.Text)).ToString();
                    int stock = (cmbProducto.SelectedItem as Producto).Stock;
                    int stockMinimo = 10;
                    lblExistencias.Text = (stock - int.Parse(txtCantidad.Text)).ToString();
                    if ((stock - int.Parse(txtCantidad.Text)) < stockMinimo)
                    {
                        MessageBoxEx.Show("Las existencias mínimas de este producto deben ser 10 unidades.");
                        txtCantidad.Text = "";
                    }
                }
                else if (string.IsNullOrEmpty(txtCantidad.Text))
                {
                    lblSubTotal.Text = "0.00";
                    if (cmbProducto.SelectedItem != null)
                    {
                        lblExistencias.Text = (cmbProducto.SelectedItem as Producto).Stock.ToString();
                    }

                }
                if (cmbEstadoDetallePedido.SelectedItem != null && cmbProducto.SelectedItem != null &&
                    (txtCantidad.Text.Length >= 1))
                {
                    btnAgregarDetallePedido.Enabled = true;
                }
                else if (cmbProducto.SelectedItem == null)
                {
                    cmbProducto.DroppedDown = true;
                    Cursor = Cursors.Arrow;
                }
                else if (string.IsNullOrEmpty(txtCantidad.Text))
                {
                    cmbProducto.DroppedDown = false;
                    cmbEstadoDetallePedido.DroppedDown = false;
                    btnAgregarDetallePedido.Enabled = false;
                }
                else if (cmbEstadoDetallePedido.SelectedItem == null)
                {
                    cmbEstadoDetallePedido.DroppedDown = true;
                    Cursor = Cursors.Arrow;
                }
                else btnAgregarDetallePedido.Enabled = true;
            }
            catch (Exception er)
            {
                MessageBoxEx.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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
            if (cmbProducto.SelectedItem!=null)
            {
                int id = int.Parse((cmbProducto.SelectedItem as Producto).Id.ToString());
                lblPrecioUnitario.Text = (ProductoBL.BuscarPorId(id)).Precio.ToString();
                lblDescripcion.Text = (ProductoBL.BuscarPorId(id)).Descripcion;
                lblSubTotal.Text = "0.00";
                lblExistencias.Text = (ProductoBL.BuscarPorId(id)).Stock.ToString();
                txtCantidad.Text = "";
                cmbEstadoDetallePedido.DroppedDown = true;
                if (cmbEstadoDetallePedido.SelectedItem != null && (txtCantidad.Text.Length >= 1))
                {
                    btnAgregarDetallePedido.Enabled = true;
                    btnAgregarDetallePedido.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txtCantidad.Text))
                {
                    btnAgregarDetallePedido.Enabled = false;
                    txtCantidad.Focus();
                }
                else
                {
                    btnAgregarDetallePedido.Enabled = false;
                    cmbEstadoDetallePedido.DroppedDown = true;
                }
            }
        }

        private void btnAgregarDetallePedido_Click(object sender, EventArgs e)
        {
                if (idDetallePedidoAEditar != null)
                {
                    foreach (var detallePedido in objeto.listadoDetallesPedido.Where(x => x.Id == idDetallePedidoAEditar))
                    {
                        detallePedido.IdProducto = (cmbProducto.SelectedItem as Producto).Id;
                        detallePedido.Producto = (cmbProducto.SelectedItem as Producto).Nombre;
                        detallePedido.Descripcion = (cmbProducto.SelectedItem as Producto).Descripcion;
                        detallePedido.PrecioUnitario = (cmbProducto.SelectedItem as Producto).Precio;
                        detallePedido.Cantidad = ushort.Parse(txtCantidad.Text);
                        detallePedido.SubTotal = float.Parse(lblSubTotal.Text);
                        detallePedido.Estado = cmbEstadoDetallePedido.SelectedItem.ToString();
                    }
                    objeto.ActualizarDatagridView();
                    Close();
                }
                else
                {
                    DetallePedido detallePedido = new DetallePedido();
                    int idUltimoDetalle;
                    if (objeto.listadoDetallesPedido.Count >= 1)
                    {
                        idUltimoDetalle = objeto.listadoDetallesPedido[objeto.listadoDetallesPedido.Count - 1].Id;
                    }
                    else idUltimoDetalle = 0;
                    detallePedido.Id = idUltimoDetalle + 1;
                    detallePedido.IdProducto = (cmbProducto.SelectedItem as Producto).Id;
                    detallePedido.Producto = (cmbProducto.SelectedItem as Producto).Nombre;
                    detallePedido.Descripcion = (cmbProducto.SelectedItem as Producto).Descripcion;
                    detallePedido.Cantidad = ushort.Parse(txtCantidad.Text);
                    detallePedido.PrecioUnitario = (cmbProducto.SelectedItem as Producto).Precio;
                    detallePedido.SubTotal = float.Parse(lblSubTotal.Text);
                    detallePedido.Estado = cmbEstadoDetallePedido.SelectedItem.ToString();
                    if (objeto.listadoDetallesPedido.Exists(x => x.IdProducto == detallePedido.IdProducto))
                    {
                        MessageBoxEx.Show("Ya agregó este producto a la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1);
                        txtCantidad.Text = "";
                        txtCantidad.Focus();
                    }
                    else
                    {
                        objeto.listadoDetallesPedido.Add(detallePedido);
                        objeto.CargarListadoDetalles();
                        Limpiar();
                    }
                
            }
        }

        private void cmbEstadoDetallePedido_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbEstadoDetallePedido.SelectedItem!=null)
            {
                if (cmbEstadoDetallePedido.SelectedItem != null && (txtCantidad.Text.Length >= 1))
                {
                    btnAgregarDetallePedido.Enabled = true;
                }
                else btnAgregarDetallePedido.Enabled = false;
                if (cmbProducto.SelectedItem != null && (txtCantidad.Text.Length >= 1))
                {
                    btnAgregarDetallePedido.Focus();
                }
                else if (cmbProducto.SelectedItem == null)
                {
                    cmbProducto.DroppedDown = true;
                }
                else txtCantidad.Focus();
            }
        }

        void Limpiar()
        {
            cmbProducto.SelectedItem = null;
            txtCantidad.Text = "";
            lblPrecioUnitario.Text = "";
            lblDescripcion.Text = "";
            lblExistencias.Text = "";
            cmbEstadoDetallePedido.SelectedItem = null;
            cmbProducto.DroppedDown = true;
        }

        private void FrmDetallePedido_Load(object sender, EventArgs e)
        {
            if (idDetallePedidoAEditar==null)
            {
                cmbProducto.DroppedDown = true;
                cmbProducto.Focus();
            }
        }
    }
}
