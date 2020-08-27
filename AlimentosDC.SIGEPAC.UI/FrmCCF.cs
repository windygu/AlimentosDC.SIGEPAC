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
using MetroFramework.Controls;
using MetroFramework.Forms;
using System.Threading;

namespace AlimentosDC.SIGEPAC.UI
{
    public partial class FrmCCF : MetroForm
    {
        int numeroPedido;
        Thread hilo;
        public FrmCCF(int numeroPedido, ref Thread hilo)
        {
            InitializeComponent();
            this.hilo = hilo;
            this.numeroPedido = numeroPedido;
        }

        private void FrmCCF_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'GestionPedidosAlimentosDCDataSet.DatosNotaRemision' Puede moverla o quitarla según sea necesario.
            this.DatosNotaRemisionTableAdapter.Fill(this.GestionPedidosAlimentosDCDataSet.DatosNotaRemision, numeroPedido);
            this.reportViewer1.RefreshReport();
            hilo.Abort();
        }
    }
}
