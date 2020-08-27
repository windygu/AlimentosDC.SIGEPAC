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
using Microsoft.Reporting.WinForms;
using System.Threading;

namespace AlimentosDC.SIGEPAC.UI
{
    public partial class FrmReporte : MetroForm
    {
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {

            Thread hiloDos = new Thread(new ThreadStart(MostrarBarra));
            hiloDos.Start();
            DateTime primeraFecha = dtpPrimeraFecha.Value;
            DateTime segundaFecha = dtpSegundaFecha.Value;
            ReportParameter[] parametrosDelInforme = new ReportParameter[2];
            parametrosDelInforme[0] = new ReportParameter("primeraFecha", primeraFecha.ToString());
            parametrosDelInforme[1] = new ReportParameter("segundaFecha", segundaFecha.ToString());
            this.datosInformeTableAdapter.Fill(this.GestionPedidosAlimentosDCDataSet1.datosInforme, primeraFecha, segundaFecha);
            reportViewer1.LocalReport.SetParameters(parametrosDelInforme);
            this.reportViewer1.RefreshReport();
            hiloDos.Abort();
        }

        void MostrarBarra()
        {
            FrmGenerandoInforme progreso = new FrmGenerandoInforme();
            progreso.Text = "Generando Informe";
            progreso.ShowDialog();
        }
    }
}
