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
    public partial class FrmPedidos : MetroForm
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }


        private void btnVerDetallePedido_Click(object sender, EventArgs e)
        {
            FrmVerDetallesPedido vdp = new FrmVerDetallesPedido();
            vdp.Owner = this;
            vdp.ShowDialog();
        }

        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            FrmPedido p = new FrmPedido();
            p.Owner = this;
            p.ShowDialog();
        }

        private void btnEditarPedido_Click(object sender, EventArgs e)
        {
            FrmPedido p = new FrmPedido();
            p.Owner = this;
            p.ShowDialog();
        }
    }
}
