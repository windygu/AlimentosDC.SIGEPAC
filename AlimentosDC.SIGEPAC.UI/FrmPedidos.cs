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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPedido fp = new FrmPedido();
            fp.Owner = this;
            fp.ShowDialog();
        }
    }
}
