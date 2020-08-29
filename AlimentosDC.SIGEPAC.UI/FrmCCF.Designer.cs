namespace AlimentosDC.SIGEPAC.UI
{
    partial class FrmCCF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCCF));
            this.DatosNotaRemisionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GestionPedidosAlimentosDCDataSet = new AlimentosDC.SIGEPAC.UI.GestionPedidosAlimentosDCDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DatosNotaRemisionTableAdapter = new AlimentosDC.SIGEPAC.UI.GestionPedidosAlimentosDCDataSetTableAdapters.DatosNotaRemisionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DatosNotaRemisionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GestionPedidosAlimentosDCDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosNotaRemisionBindingSource
            // 
            this.DatosNotaRemisionBindingSource.DataMember = "DatosNotaRemision";
            this.DatosNotaRemisionBindingSource.DataSource = this.GestionPedidosAlimentosDCDataSet;
            // 
            // GestionPedidosAlimentosDCDataSet
            // 
            this.GestionPedidosAlimentosDCDataSet.DataSetName = "GestionPedidosAlimentosDCDataSet";
            this.GestionPedidosAlimentosDCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DatosNotaRemisionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AlimentosDC.SIGEPAC.UI.InformeNotaRemision.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(660, 670);
            this.reportViewer1.TabIndex = 0;
            // 
            // DatosNotaRemisionTableAdapter
            // 
            this.DatosNotaRemisionTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCCF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 750);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCCF";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Comprobante Crédito Fiscal";
            this.Load += new System.EventHandler(this.FrmCCF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosNotaRemisionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GestionPedidosAlimentosDCDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DatosNotaRemisionBindingSource;
        private GestionPedidosAlimentosDCDataSet GestionPedidosAlimentosDCDataSet;
        private GestionPedidosAlimentosDCDataSetTableAdapters.DatosNotaRemisionTableAdapter DatosNotaRemisionTableAdapter;
    }
}