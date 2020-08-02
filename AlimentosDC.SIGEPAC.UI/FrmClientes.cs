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
    public partial class FrmClientes : MetroForm
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            FrmCliente mantenimientoClientes = new FrmCliente();
            mantenimientoClientes.Owner = this;
            mantenimientoClientes.ShowDialog();
        }

        private void btnEditarPedido_Click(object sender, EventArgs e)
        {
            FrmCliente mantenimientoClientes = new FrmCliente();
            mantenimientoClientes.Owner = this;
            mantenimientoClientes.ShowDialog();
        }
    }
}
