namespace AlimentosDC.SIGEPAC.UI
{
    partial class FrmVerDetalleIngreso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvListadoDetallesIngreso = new System.Windows.Forms.DataGridView();
            this.dgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUsuario = new AlimentosDC.SIGEPAC.UI.LableBordeInferior();
            this.lblTotal = new AlimentosDC.SIGEPAC.UI.LableBordeInferior();
            this.lblIva = new AlimentosDC.SIGEPAC.UI.LableBordeInferior();
            this.lblSumas = new AlimentosDC.SIGEPAC.UI.LableBordeInferior();
            this.lblMarca = new AlimentosDC.SIGEPAC.UI.LableBordeInferior();
            this.lblNumeroCCF = new AlimentosDC.SIGEPAC.UI.LableBordeInferior();
            this.lblFechaIngreso = new AlimentosDC.SIGEPAC.UI.LableBordeInferior();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDetallesIngreso)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEntrega.Location = new System.Drawing.Point(661, 67);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(118, 20);
            this.lblFechaEntrega.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(519, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 67;
            this.label5.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 66;
            this.label2.Text = "Fecha de ingreso:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 19);
            this.label10.TabIndex = 76;
            this.label10.Text = "No. CCF:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(19, 498);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 19);
            this.label15.TabIndex = 80;
            this.label15.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(208, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 62;
            this.label4.Text = "Sumas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(517, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 64;
            this.label6.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 78;
            this.label3.Text = "IVA:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(741, 522);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 30);
            this.btnCerrar.TabIndex = 59;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvListadoDetallesIngreso
            // 
            this.dgvListadoDetallesIngreso.AllowUserToAddRows = false;
            this.dgvListadoDetallesIngreso.AllowUserToDeleteRows = false;
            this.dgvListadoDetallesIngreso.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvListadoDetallesIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoDetallesIngreso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvId,
            this.dgvCantidad,
            this.dgvProducto,
            this.dgvDescripcion,
            this.dgvPrecioUnitario,
            this.dgvSubTotal});
            this.dgvListadoDetallesIngreso.Location = new System.Drawing.Point(23, 113);
            this.dgvListadoDetallesIngreso.MultiSelect = false;
            this.dgvListadoDetallesIngreso.Name = "dgvListadoDetallesIngreso";
            this.dgvListadoDetallesIngreso.ReadOnly = true;
            this.dgvListadoDetallesIngreso.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListadoDetallesIngreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoDetallesIngreso.Size = new System.Drawing.Size(818, 331);
            this.dgvListadoDetallesIngreso.TabIndex = 90;
            // 
            // dgvId
            // 
            this.dgvId.HeaderText = "ID";
            this.dgvId.Name = "dgvId";
            this.dgvId.ReadOnly = true;
            this.dgvId.Width = 50;
            // 
            // dgvCantidad
            // 
            this.dgvCantidad.HeaderText = "CANTIDAD";
            this.dgvCantidad.Name = "dgvCantidad";
            this.dgvCantidad.ReadOnly = true;
            this.dgvCantidad.Width = 70;
            // 
            // dgvProducto
            // 
            this.dgvProducto.HeaderText = "PRODUCTO";
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            this.dgvProducto.Width = 170;
            // 
            // dgvDescripcion
            // 
            this.dgvDescripcion.HeaderText = "DESCRIPCIÓN";
            this.dgvDescripcion.Name = "dgvDescripcion";
            this.dgvDescripcion.ReadOnly = true;
            this.dgvDescripcion.Width = 230;
            // 
            // dgvPrecioUnitario
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dgvPrecioUnitario.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrecioUnitario.HeaderText = "P. UNITARIO";
            this.dgvPrecioUnitario.Name = "dgvPrecioUnitario";
            this.dgvPrecioUnitario.ReadOnly = true;
            this.dgvPrecioUnitario.Width = 110;
            // 
            // dgvSubTotal
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.dgvSubTotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSubTotal.HeaderText = "SUB-TOTALES";
            this.dgvSubTotal.Name = "dgvSubTotal";
            this.dgvSubTotal.ReadOnly = true;
            this.dgvSubTotal.Width = 125;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(81, 497);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(260, 20);
            this.lblUsuario.TabIndex = 89;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(557, 460);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(88, 19);
            this.lblTotal.TabIndex = 88;
            // 
            // lblIva
            // 
            this.lblIva.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.Location = new System.Drawing.Point(404, 460);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(88, 19);
            this.lblIva.TabIndex = 87;
            // 
            // lblSumas
            // 
            this.lblSumas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumas.Location = new System.Drawing.Point(259, 460);
            this.lblSumas.Name = "lblSumas";
            this.lblSumas.Size = new System.Drawing.Size(88, 19);
            this.lblSumas.TabIndex = 86;
            // 
            // lblMarca
            // 
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(571, 69);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(269, 19);
            this.lblMarca.TabIndex = 85;
            // 
            // lblNumeroCCF
            // 
            this.lblNumeroCCF.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCCF.Location = new System.Drawing.Point(87, 68);
            this.lblNumeroCCF.Name = "lblNumeroCCF";
            this.lblNumeroCCF.Size = new System.Drawing.Size(110, 19);
            this.lblNumeroCCF.TabIndex = 83;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngreso.Location = new System.Drawing.Point(341, 69);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(150, 19);
            this.lblFechaIngreso.TabIndex = 82;
            // 
            // FrmVerDetalleIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 571);
            this.Controls.Add(this.dgvListadoDetallesIngreso);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblIva);
            this.Controls.Add(this.lblSumas);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblNumeroCCF);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblFechaEntrega);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCerrar);
            this.Name = "FrmVerDetalleIngreso";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Detalles del ingreso";
            this.Load += new System.EventHandler(this.FrmVerDetalleIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDetallesIngreso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFechaEntrega;
        private LableBordeInferior lblMarca;
        private System.Windows.Forms.Label label5;
        private LableBordeInferior lblFechaIngreso;
        private System.Windows.Forms.Label label2;
        private LableBordeInferior lblNumeroCCF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private LableBordeInferior lblUsuario;
        private System.Windows.Forms.Label label4;
        private LableBordeInferior lblSumas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private LableBordeInferior lblIva;
        private LableBordeInferior lblTotal;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvListadoDetallesIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubTotal;
    }
}