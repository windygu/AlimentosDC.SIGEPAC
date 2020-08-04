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

namespace AlimentosDC.SIGEPAC.UI
{
    public partial class FrmDetallePedido : MetroForm
    {

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
            if (txtCantidad.Text.Length>0 && txtPrecioUnitario.Text.Length>0)
            {
                lblSubTotal.Text = (int.Parse(txtPrecioUnitario.Text) + int.Parse(txtCantidad.Text)).ToString();
            }
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData >= Keys.D0 && e.KeyData <= Keys.D9)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }
    }
}
