namespace AlimentosDC.SIGEPAC.UI
{
    partial class FrmCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompras));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtBuscadorCompras = new AlimentosDC.SIGEPAC.UI.TextBoxWaterMark();
            this.btnVerDetalleCompra = new System.Windows.Forms.Button();
            this.btnEliminarCompra = new System.Windows.Forms.Button();
            this.btnEditarCompra = new System.Windows.Forms.Button();
            this.dgvListadoIngresos = new System.Windows.Forms.DataGridView();
            this.dgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNumeroCCF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNumeroPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoIngresos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(579, 447);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 30);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(697, 447);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 30);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // txtBuscadorCompras
            // 
            this.txtBuscadorCompras.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscadorCompras.Location = new System.Drawing.Point(21, 67);
            this.txtBuscadorCompras.Name = "txtBuscadorCompras";
            this.txtBuscadorCompras.Size = new System.Drawing.Size(335, 27);
            this.txtBuscadorCompras.TabIndex = 7;
            this.txtBuscadorCompras.TextoMarcaAgua = "Buscar por usuario, marca, mes o año";
            // 
            // btnVerDetalleCompra
            // 
            this.btnVerDetalleCompra.Enabled = false;
            this.btnVerDetalleCompra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalleCompra.Location = new System.Drawing.Point(383, 64);
            this.btnVerDetalleCompra.Name = "btnVerDetalleCompra";
            this.btnVerDetalleCompra.Size = new System.Drawing.Size(100, 30);
            this.btnVerDetalleCompra.TabIndex = 10;
            this.btnVerDetalleCompra.Text = "Ver detalle";
            this.btnVerDetalleCompra.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCompra
            // 
            this.btnEliminarCompra.Enabled = false;
            this.btnEliminarCompra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCompra.Location = new System.Drawing.Point(628, 64);
            this.btnEliminarCompra.Name = "btnEliminarCompra";
            this.btnEliminarCompra.Size = new System.Drawing.Size(100, 30);
            this.btnEliminarCompra.TabIndex = 12;
            this.btnEliminarCompra.Text = "Eliminar";
            this.btnEliminarCompra.UseVisualStyleBackColor = true;
            // 
            // btnEditarCompra
            // 
            this.btnEditarCompra.Enabled = false;
            this.btnEditarCompra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCompra.Location = new System.Drawing.Point(508, 64);
            this.btnEditarCompra.Name = "btnEditarCompra";
            this.btnEditarCompra.Size = new System.Drawing.Size(100, 30);
            this.btnEditarCompra.TabIndex = 11;
            this.btnEditarCompra.Text = "Editar";
            this.btnEditarCompra.UseVisualStyleBackColor = true;
            // 
            // dgvListadoIngresos
            // 
            this.dgvListadoIngresos.AllowUserToAddRows = false;
            this.dgvListadoIngresos.AllowUserToDeleteRows = false;
            this.dgvListadoIngresos.AllowUserToResizeRows = false;
            this.dgvListadoIngresos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvListadoIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoIngresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvId,
            this.dgvNumeroCCF,
            this.dgvDui,
            this.dgvNumeroPedido,
            this.dgvUsuario});
            this.dgvListadoIngresos.Location = new System.Drawing.Point(21, 115);
            this.dgvListadoIngresos.MultiSelect = false;
            this.dgvListadoIngresos.Name = "dgvListadoIngresos";
            this.dgvListadoIngresos.ReadOnly = true;
            this.dgvListadoIngresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoIngresos.Size = new System.Drawing.Size(782, 313);
            this.dgvListadoIngresos.TabIndex = 8;
            // 
            // dgvId
            // 
            this.dgvId.Frozen = true;
            this.dgvId.HeaderText = "ID";
            this.dgvId.Name = "dgvId";
            this.dgvId.ReadOnly = true;
            this.dgvId.Width = 70;
            // 
            // dgvNumeroCCF
            // 
            this.dgvNumeroCCF.Frozen = true;
            this.dgvNumeroCCF.HeaderText = "NO. CCF";
            this.dgvNumeroCCF.Name = "dgvNumeroCCF";
            this.dgvNumeroCCF.ReadOnly = true;
            // 
            // dgvDui
            // 
            this.dgvDui.Frozen = true;
            this.dgvDui.HeaderText = "MARCA";
            this.dgvDui.Name = "dgvDui";
            this.dgvDui.ReadOnly = true;
            this.dgvDui.Width = 250;
            // 
            // dgvNumeroPedido
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dgvNumeroPedido.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNumeroPedido.Frozen = true;
            this.dgvNumeroPedido.HeaderText = "FECHA INGRESO";
            this.dgvNumeroPedido.Name = "dgvNumeroPedido";
            this.dgvNumeroPedido.ReadOnly = true;
            this.dgvNumeroPedido.Width = 120;
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.Frozen = true;
            this.dgvUsuario.HeaderText = "USUARIO";
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            this.dgvUsuario.Width = 180;
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 495);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtBuscadorCompras);
            this.Controls.Add(this.btnVerDetalleCompra);
            this.Controls.Add(this.btnEliminarCompra);
            this.Controls.Add(this.btnEditarCompra);
            this.Controls.Add(this.dgvListadoIngresos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCompras";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "HISTORIAL COMPRAS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoIngresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCerrar;
        private TextBoxWaterMark txtBuscadorCompras;
        private System.Windows.Forms.Button btnVerDetalleCompra;
        private System.Windows.Forms.Button btnEliminarCompra;
        private System.Windows.Forms.Button btnEditarCompra;
        private System.Windows.Forms.DataGridView dgvListadoIngresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNumeroCCF;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDui;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNumeroPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUsuario;
    }
}