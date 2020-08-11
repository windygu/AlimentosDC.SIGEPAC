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
    public partial class FrmCliente : MetroForm
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
