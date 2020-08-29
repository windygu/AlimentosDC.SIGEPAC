namespace AlimentosDC.SIGEPAC.UI
{
    partial class FrmReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporte));
            this.datosInformeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GestionPedidosAlimentosDCDataSet1 = new AlimentosDC.SIGEPAC.UI.GestionPedidosAlimentosDCDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpPrimeraFecha = new System.Windows.Forms.DateTimePicker();
            this.dtpSegundaFecha = new System.Windows.Forms.DateTimePicker();
            this.btnGenerarInforme = new System.Windows.Forms.Button();
            this.datosInformeTableAdapter = new AlimentosDC.SIGEPAC.UI.GestionPedidosAlimentosDCDataSet1TableAdapters.datosInformeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datosInformeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GestionPedidosAlimentosDCDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // datosInformeBindingSource
            // 
            this.datosInformeBindingSource.DataMember = "datosInforme";
            this.datosInformeBindingSource.DataSource = this.GestionPedidosAlimentosDCDataSet1;
            // 
            // GestionPedidosAlimentosDCDataSet1
            // 
            this.GestionPedidosAlimentosDCDataSet1.DataSetName = "GestionPedidosAlimentosDCDataSet1";
            this.GestionPedidosAlimentosDCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.datosInformeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AlimentosDC.SIGEPAC.UI.Informe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 110);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(814, 667);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta:";
            // 
            // dtpPrimeraFecha
            // 
            this.dtpPrimeraFecha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPrimeraFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPrimeraFecha.Location = new System.Drawing.Point(76, 76);
            this.dtpPrimeraFecha.Name = "dtpPrimeraFecha";
            this.dtpPrimeraFecha.Size = new System.Drawing.Size(120, 25);
            this.dtpPrimeraFecha.TabIndex = 0;
            // 
            // dtpSegundaFecha
            // 
            this.dtpSegundaFecha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSegundaFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSegundaFecha.Location = new System.Drawing.Point(280, 76);
            this.dtpSegundaFecha.Name = "dtpSegundaFecha";
            this.dtpSegundaFecha.Size = new System.Drawing.Size(120, 25);
            this.dtpSegundaFecha.TabIndex = 1;
            // 
            // btnGenerarInforme
            // 
            this.btnGenerarInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarInforme.Location = new System.Drawing.Point(434, 74);
            this.btnGenerarInforme.Name = "btnGenerarInforme";
            this.btnGenerarInforme.Size = new System.Drawing.Size(100, 30);
            this.btnGenerarInforme.TabIndex = 2;
            this.btnGenerarInforme.Text = "Generar";
            this.btnGenerarInforme.UseVisualStyleBackColor = true;
            this.btnGenerarInforme.Click += new System.EventHandler(this.btnGenerarInforme_Click);
            // 
            // datosInformeTableAdapter
            // 
            this.datosInformeTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 800);
            this.Controls.Add(this.btnGenerarInforme);
            this.Controls.Add(this.dtpSegundaFecha);
            this.Controls.Add(this.dtpPrimeraFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmReporte";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Informe";
            ((System.ComponentModel.ISupportInitialize)(this.datosInformeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GestionPedidosAlimentosDCDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpPrimeraFecha;
        private System.Windows.Forms.DateTimePicker dtpSegundaFecha;
        private System.Windows.Forms.Button btnGenerarInforme;
        private System.Windows.Forms.BindingSource datosInformeBindingSource;
        private GestionPedidosAlimentosDCDataSet1 GestionPedidosAlimentosDCDataSet1;
        private GestionPedidosAlimentosDCDataSet1TableAdapters.datosInformeTableAdapter datosInformeTableAdapter;
    }
}