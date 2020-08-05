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
        public FrmDetallePedido(ref FrmPedido objeto)
        {
            InitializeComponent();
            this.objeto = objeto;
        }

        public FrmDetallePedido()
        {
            InitializeComponent();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            FrmProductos listadoProductos = new FrmProductos();
            listadoProductos.Owner = this;
            listadoProductos.ShowDialog();
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

        private void FrmDetallePedido_Load(object sender, EventArgs e)
        {
            listadoProductos = ProductoBL.ObtenerTodos();
            cmbProducto.Items.AddRange(listadoProductos.ToArray());
        }

        private void cmbProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = int.Parse((cmbProducto.SelectedItem as Producto).Id.ToString());
            lblPrecioUnitario.Text = (ProductoBL.BuscarPorId(id)).Precio.ToString();
            lblDescripcion.Text = (ProductoBL.BuscarPorId(id)).Descripcion;
            lblSubTotal.Text = "$ 0.00";
            lblExistencias.Text = (ProductoBL.BuscarPorId(id)).Stock.ToString();
            txtCantidad.Text = "";
            txtCantidad.Focus();
        }

        private void btnAgregarDetallePedido_Click(object sender, EventArgs e)
        {
            DetallePedido detallePedido = new DetallePedido();
            detallePedido.IdProducto = (cmbProducto.SelectedItem as Producto).Id;
            detallePedido.Producto = (cmbProducto.SelectedItem as Producto).Nombre;
            detallePedido.Descripcion = (cmbProducto.SelectedItem as Producto).Descripcion;
            detallePedido.Cantidad = ushort.Parse(txtCantidad.Text);
            detallePedido.PrecioUnitario = (cmbProducto.SelectedItem as Producto).Precio;
            detallePedido.SubTotal = float.Parse(lblSubTotal.Text);
            objeto.listadoDetallesPedido.Add(detallePedido);
            objeto.CargarListadoDetalles();
        }
    }
}
