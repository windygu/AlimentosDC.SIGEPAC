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
    public partial class FrmVerDetallesPedido : MetroForm
    {
        public FrmVerDetallesPedido()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevoDetallePedido_Click(object sender, EventArgs e)
        {
            FrmDetallePedido mantenimientoDetallesPedidos = new FrmDetallePedido();
            mantenimientoDetallesPedidos.Owner = this;
            mantenimientoDetallesPedidos.ShowDialog();
        }

        private void btnEditarDetallePedido_Click(object sender, EventArgs e)
        {
            FrmDetallePedido mantenimientoDetallesPedidos = new FrmDetallePedido();
            mantenimientoDetallesPedidos.Owner = this;
            mantenimientoDetallesPedidos.ShowDialog();
        }
    }
}
