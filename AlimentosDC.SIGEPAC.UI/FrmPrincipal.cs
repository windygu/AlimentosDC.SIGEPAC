using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace AlimentosDC.SIGEPAC.UI
{
    public partial class FrmPrincipal : MetroForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FrmPedidos fm = new FrmPedidos();
            fm.Owner = this;
            fm.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos listadoProductos = new FrmProductos();
            listadoProductos.Owner = this;
            listadoProductos.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes listadoClientes = new FrmClientes();
            listadoClientes.Owner = this;
            listadoClientes.ShowDialog();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            FrmMarcas listadoMarcas = new FrmMarcas();
            listadoMarcas.Owner = this;
            listadoMarcas.ShowDialog();
        }
    }
}
