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
    public partial class FrmPedido : MetroForm
    {
        public FrmPedido()
        {
            InitializeComponent();
        }

        private void btnNuevoDetallePedido_Click(object sender, EventArgs e)
        {
            FrmDetallePedido mantenimientoDetallesPedido = new FrmDetallePedido();
            mantenimientoDetallesPedido.Owner = this;
            mantenimientoDetallesPedido.ShowDialog();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmClientes listadoClientes = new FrmClientes();
            listadoClientes.Owner = this;
            listadoClientes.ShowDialog();
        }

        private void btnEditarDetallePedido_Click(object sender, EventArgs e)
        {
            FrmDetallePedido mantenimientoDetallesPedido = new FrmDetallePedido();
            mantenimientoDetallesPedido.Owner = this;
            mantenimientoDetallesPedido.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
