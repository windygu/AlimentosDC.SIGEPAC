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
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDetallesPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarDetallePedido
            // 
            this.btnEliminarDetallePedido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDetallePedido.Location = new System.Drawing.Point(441, 387);
            this.btnEliminarDetallePedido.Name = "btnEliminarDetallePedido";
            this.btnEliminarDetallePedido.Size = new System.Drawing.Size(100, 30);
            this.btnEliminarDetallePedido.TabIndex = 25;
            this.btnEliminarDetallePedido.Text = "Eliminar";
            this.btnEliminarDetallePedido.UseVisualStyleBackColor = true;
            // 
            // btnEditarDetallePedido
            // 
            this.btnEditarDetallePedido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarDetallePedido.Location = new System.Drawing.Point(300, 387);
            this.btnEditarDetallePedido.Name = "btnEditarDetallePedido";
            this.btnEditarDetallePedido.Size = new System.Drawing.Size(100, 30);
            this.btnEditarDetallePedido.TabIndex = 24;
            this.btnEditarDetallePedido.Text = "Editar";
            this.btnEditarDetallePedido.UseVisualStyleBackColor = true;
            // 
            // btnNuevoDetallePedido
            // 
            this.btnNuevoDetallePedido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoDetallePedido.Location = new System.Drawing.Point(163, 387);
            this.btnNuevoDetallePedido.Name = "btnNuevoDetallePedido";
            this.btnNuevoDetallePedido.Size = new System.Drawing.Size(100, 30);
            this.btnNuevoDetallePedido.TabIndex = 21;
            this.btnNuevoDetallePedido.Text = "Nuevo";
            this.btnNuevoDetallePedido.UseVisualStyleBackColor = true;
            // 
            // dgvListadoDetallesPedido
            // 
            this.dgvListadoDetallesPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoDetallesPedido.Location = new System.Drawing.Point(12, 59);
            this.dgvListadoDetallesPedido.Name = "dgvListadoDetallesPedido";
            this.dgvListadoDetallesPedido.Size = new System.Drawing.Size(668, 293);
            this.dgvListadoDetallesPedido.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(201, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(266, 37);
            this.label8.TabIndex = 27;
            this.label8.Text = "Detalles del pedido";
            // 
            // FrmVerDetallesPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 428);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvListadoDetallesPedido);
            this.Controls.Add(this.btnEliminarDetallePedido);
            this.Controls.Add(this.btnEditarDetallePedido);
            this.Controls.Add(this.btnNuevoDetallePedido);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVerDetallesPedido";
            this.Text = "Detalles Pedido";
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
    }
}