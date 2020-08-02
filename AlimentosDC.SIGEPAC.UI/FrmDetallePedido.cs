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
    }
}
