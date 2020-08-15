using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlimentosDC.SIGEPAC.UI
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ConjuntoDatos.DataTable1' Puede moverla o quitarla según sea necesario.
            //this.DataTable1TableAdapter.Fill(this.ConjuntoDatos.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
