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
    public partial class FrmDetallePedido : MetroForm
    {
        List<Producto> listadoProductos;
        FrmPedido objeto;
        int? idDetallePedidoAEditar = null;
        int? idPedidoEditando = null;
        List<DetallePedido> listadoDetallesPedido;
        List<DetallePedido> listadoViejoDetallesPedido;
        DetallePedido detallePedidoAEditar;

        //Constructor para un nuevo detalle de un nuevo pedido
        public FrmDetallePedido(ref FrmPedido objeto)
        {
            InitializeComponent();
            listadoProductos = ProductoBL.ObtenerTodos();
            cmbProducto.Items.AddRange(listadoProductos.ToArray());
            this.objeto = objeto;
        }
        //Constructor para un nuevo detalle pedido de un viejo pedido
        public FrmDetallePedido(ref FrmPedido objeto, int idPedidoEditando)
        {
            InitializeComponent();
            listadoProductos = ProductoBL.ObtenerTodos();
            cmbProducto.Items.AddRange(listadoProductos.ToArray());
            this.idPedidoEditando = idPedidoEditando;
            this.objeto = objeto;
        }

        //Constructor para la modificación de detalles pedido de un nuevo pedido
        public FrmDetallePedido(ref FrmPedido objeto, int idDetallePedidoAEditar, ref List<DetallePedido> listadoDetalles)
        {
            InitializeComponent();
            listadoProductos = ProductoBL.ObtenerTodos();
            cmbProducto.Items.AddRange(listadoProductos.ToArray());
            btnNuevoDetallePedido.Visible = false;
            btnAgregarDetallePedido.Text = "Actualizar";
            this.objeto = objeto;
            this.idDetallePedidoAEditar = idDetallePedidoAEditar;
            listadoDetallesPedido = listadoDetalles;
            CargarDatosAlFormulario();
            detallePedidoAEditar = listadoDetallesPedido.Find(x => x.Id == idDetallePedidoAEditar);

        }

        //Contructor para la modificación de un detalle pedido de un viejo pedido
        public FrmDetallePedido(ref FrmPedido objeto, int idDetallePedidoAEditar, ref List<DetallePedido> listadoDetallesPedido,
           ref List<DetallePedido> listadoViejoDetallesPedido, int idPedidoEditando)
        {
            InitializeComponent();
            listadoProductos = ProductoBL.ObtenerTodos();
            cmbProducto.Items.AddRange(listadoProductos.ToArray());
            btnNuevoDetallePedido.Visible = false;
            btnAgregarDetallePedido.Text = "Actualizar";
            this.objeto = objeto;
            this.idDetallePedidoAEditar = idDetallePedidoAEditar;
            this.listadoDetallesPedido = listadoDetallesPedido;
            this.listadoViejoDetallesPedido = listadoViejoDetallesPedido;
            detallePedidoAEditar = objeto.listadoDetallesPedido.Find(x => x.Id == idDetallePedidoAEditar);
            CargarDatosAlFormulario();
        }

        void CargarDatosAlFormulario()
        {
            List<Producto> listadoProductos = ProductoBL.ObtenerTodos();
            Producto producto = ProductoBL.BuscarPorId(detallePedidoAEditar.IdProducto);
            int indiceDelProducto = listadoProductos.FindIndex(x => x.Id == producto.Id);
            cmbProducto.SelectedIndex = indiceDelProducto;
            txtCantidad.Text = detallePedidoAEditar.Cantidad.ToString();
        }

        private void btnCerrarDetallePedido_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Text.Length>0 && lblPrecioUnitario.Text.Length>0)
            {
                lblSubTotal.Text = (float.Parse(lblPrecioUnitario.Text) * float.Parse(txtCantidad.Text)).ToString();
                int stock = (cmbProducto.SelectedItem as Producto).Stock;
                int stockMinimo = 10;
                lblExistencias.Text = (stock-int.Parse(txtCantidad.Text)).ToString();
                if ((stock-int.Parse(txtCantidad.Text))<stockMinimo)
                {
                    MessageBoxEx.Show("Las existencias mínimas de este producto deben ser 10 unidades.");
                    txtCantidad.Text = "";
                }
                
            }
            else if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                lblSubTotal.Text = "$ 0.00";
                lblExistencias.Text = (cmbProducto.SelectedItem as Producto).Stock.ToString();
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
                txtCantidad.Focus();
            }
            
        }

        private void btnAgregarDetallePedido_Click(object sender, EventArgs e)
        {
            if (idDetallePedidoAEditar != null)
            {
                foreach (var detallePedido in listadoDetallesPedido.Where(x => x.Id == idDetallePedidoAEditar))
                {
                    detallePedido.IdProducto = (cmbProducto.SelectedItem as Producto).Id;
                    detallePedido.Producto = (cmbProducto.SelectedItem as Producto).Nombre;
                    detallePedido.Descripcion = (cmbProducto.SelectedItem as Producto).Descripcion;
                    detallePedido.PrecioUnitario = (cmbProducto.SelectedItem as Producto).Precio;
                    detallePedido.Cantidad = ushort.Parse(txtCantidad.Text);
                    detallePedido.SubTotal = float.Parse(lblSubTotal.Text);
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
                }
            }
        }
    }
}
