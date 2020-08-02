namespace AlimentosDC.SIGEPAC.UI
{
    partial class FrmVerDetallesPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerDetallesPedido));
            this.btnEliminarDetallePedido = new System.Windows.Forms.Button();
            this.btnEditarDetallePedido = new System.Windows.Forms.Button();
            this.btnNuevoDetallePedido = new System.Windows.Forms.Button();
            this.dgvListadoDetallesPedido = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblNumeroPedido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDetallesPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarDetallePedido
            // 
            this.btnEliminarDetallePedido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDetallePedido.Location = new System.Drawing.Point(353, 386);
            this.btnEliminarDetallePedido.Name = "btnEliminarDetallePedido";
            this.btnEliminarDetallePedido.Size = new System.Drawing.Size(100, 30);
            this.btnEliminarDetallePedido.TabIndex = 25;
            this.btnEliminarDetallePedido.Text = "Eliminar";
            this.btnEliminarDetallePedido.UseVisualStyleBackColor = true;
            // 
            // btnEditarDetallePedido
            // 
            this.btnEditarDetallePedido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarDetallePedido.Location = new System.Drawing.Point(234, 386);
            this.btnEditarDetallePedido.Name = "btnEditarDetallePedido";
            this.btnEditarDetallePedido.Size = new System.Drawing.Size(100, 30);
            this.btnEditarDetallePedido.TabIndex = 24;
            this.btnEditarDetallePedido.Text = "Editar";
            this.btnEditarDetallePedido.UseVisualStyleBackColor = true;
            this.btnEditarDetallePedido.Click += new System.EventHandler(this.btnEditarDetallePedido_Click);
            // 
            // btnNuevoDetallePedido
            // 
            this.btnNuevoDetallePedido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoDetallePedido.Location = new System.Drawing.Point(116, 386);
            this.btnNuevoDetallePedido.Name = "btnNuevoDetallePedido";
            this.btnNuevoDetallePedido.Size = new System.Drawing.Size(100, 30);
            this.btnNuevoDetallePedido.TabIndex = 21;
            this.btnNuevoDetallePedido.Text = "Nuevo";
            this.btnNuevoDetallePedido.UseVisualStyleBackColor = true;
            this.btnNuevoDetallePedido.Click += new System.EventHandler(this.btnNuevoDetallePedido_Click);
            // 
            // dgvListadoDetallesPedido
            // 
            this.dgvListadoDetallesPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoDetallesPedido.Location = new System.Drawing.Point(12, 70);
            this.dgvListadoDetallesPedido.Name = "dgvListadoDetallesPedido";
            this.dgvListadoDetallesPedido.Size = new System.Drawing.Size(668, 293);
            this.dgvListadoDetallesPedido.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "No. Pedido:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(474, 386);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 30);
            this.btnCerrar.TabIndex = 28;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblNumeroPedido
            // 
            this.lblNumeroPedido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPedido.Location = new System.Drawing.Point(95, 9);
            this.lblNumeroPedido.Name = "lblNumeroPedido";
            this.lblNumeroPedido.Size = new System.Drawing.Size(100, 20);
            this.lblNumeroPedido.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Detalles del pedido:";
            // 
            // FrmVerDetallesPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 428);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumeroPedido);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvListadoDetallesPedido);
            this.Controls.Add(this.btnEliminarDetallePedido);
            this.Controls.Add(this.btnEditarDetallePedido);
            this.Controls.Add(this.btnNuevoDetallePedido);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmVerDetallesPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DETALLES PEDIDO";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDetallesPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarDetallePedido;
        private System.Windows.Forms.Button btnEditarDetallePedido;
        private System.Windows.Forms.Button btnNuevoDetallePedido;
        private System.Windows.Forms.DataGridView dgvListadoDetallesPedido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblNumeroPedido;
        private System.Windows.Forms.Label label1;
    }
}