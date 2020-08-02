namespace AlimentosDC.SIGEPAC.UI
{
    partial class FrmPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidos));
            this.dgvListadoPedidos = new System.Windows.Forms.DataGridView();
            this.txtBuscarPedido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevoPedido = new System.Windows.Forms.Button();
            this.btnEditarPedido = new System.Windows.Forms.Button();
            this.btnEliminarPedido = new System.Windows.Forms.Button();
            this.btnVerDetallePedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoPedidos
            // 
            this.dgvListadoPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoPedidos.Location = new System.Drawing.Point(12, 48);
            this.dgvListadoPedidos.Name = "dgvListadoPedidos";
            this.dgvListadoPedidos.Size = new System.Drawing.Size(960, 461);
            this.dgvListadoPedidos.TabIndex = 0;
            // 
            // txtBuscarPedido
            // 
            this.txtBuscarPedido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPedido.Location = new System.Drawing.Point(12, 1);
            this.txtBuscarPedido.Name = "txtBuscarPedido";
            this.txtBuscarPedido.Size = new System.Drawing.Size(322, 27);
            this.txtBuscarPedido.TabIndex = 1;
            this.txtBuscarPedido.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(14, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar por número de pedido o ID";
            // 
            // btnNuevoPedido
            // 
            this.btnNuevoPedido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPedido.Location = new System.Drawing.Point(373, 0);
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Size = new System.Drawing.Size(100, 30);
            this.btnNuevoPedido.TabIndex = 3;
            this.btnNuevoPedido.Text = "Nuevo";
            this.btnNuevoPedido.UseVisualStyleBackColor = true;
            this.btnNuevoPedido.Click += new System.EventHandler(this.btnNuevoPedido_Click);
            // 
            // btnEditarPedido
            // 
            this.btnEditarPedido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPedido.Location = new System.Drawing.Point(620, 0);
            this.btnEditarPedido.Name = "btnEditarPedido";
            this.btnEditarPedido.Size = new System.Drawing.Size(100, 30);
            this.btnEditarPedido.TabIndex = 4;
            this.btnEditarPedido.Text = "Editar";
            this.btnEditarPedido.UseVisualStyleBackColor = true;
            this.btnEditarPedido.Click += new System.EventHandler(this.btnEditarPedido_Click);
            // 
            // btnEliminarPedido
            // 
            this.btnEliminarPedido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPedido.Location = new System.Drawing.Point(746, 0);
            this.btnEliminarPedido.Name = "btnEliminarPedido";
            this.btnEliminarPedido.Size = new System.Drawing.Size(100, 30);
            this.btnEliminarPedido.TabIndex = 5;
            this.btnEliminarPedido.Text = "Eliminar";
            this.btnEliminarPedido.UseVisualStyleBackColor = true;
            // 
            // btnVerDetallePedido
            // 
            this.btnVerDetallePedido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetallePedido.Location = new System.Drawing.Point(495, 0);
            this.btnVerDetallePedido.Name = "btnVerDetallePedido";
            this.btnVerDetallePedido.Size = new System.Drawing.Size(100, 30);
            this.btnVerDetallePedido.TabIndex = 6;
            this.btnVerDetallePedido.Text = "Ver detalle";
            this.btnVerDetallePedido.UseVisualStyleBackColor = true;
            this.btnVerDetallePedido.Click += new System.EventHandler(this.btnVerDetallePedido_Click);
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 521);
            this.Controls.Add(this.btnVerDetallePedido);
            this.Controls.Add(this.btnEliminarPedido);
            this.Controls.Add(this.btnEditarPedido);
            this.Controls.Add(this.btnNuevoPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarPedido);
            this.Controls.Add(this.dgvListadoPedidos);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "FrmPedidos";
            this.Tag = "";
            this.Text = "Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoPedidos;
        private System.Windows.Forms.TextBox txtBuscarPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevoPedido;
        private System.Windows.Forms.Button btnEditarPedido;
        private System.Windows.Forms.Button btnEliminarPedido;
        private System.Windows.Forms.Button btnVerDetallePedido;
    }
}