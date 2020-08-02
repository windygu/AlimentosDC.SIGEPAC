namespace AlimentosDC.SIGEPAC.UI
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.btnEliminarPedido = new System.Windows.Forms.Button();
            this.btnEditarPedido = new System.Windows.Forms.Button();
            this.btnNuevoPedido = new System.Windows.Forms.Button();
            this.lblMarcaAguaCliente = new System.Windows.Forms.Label();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.dgvListadoClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarPedido
            // 
            this.btnEliminarPedido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPedido.Location = new System.Drawing.Point(688, 13);
            this.btnEliminarPedido.Name = "btnEliminarPedido";
            this.btnEliminarPedido.Size = new System.Drawing.Size(100, 30);
            this.btnEliminarPedido.TabIndex = 2;
            this.btnEliminarPedido.Text = "Eliminar";
            this.btnEliminarPedido.UseVisualStyleBackColor = true;
            // 
            // btnEditarPedido
            // 
            this.btnEditarPedido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPedido.Location = new System.Drawing.Point(549, 13);
            this.btnEditarPedido.Name = "btnEditarPedido";
            this.btnEditarPedido.Size = new System.Drawing.Size(100, 30);
            this.btnEditarPedido.TabIndex = 1;
            this.btnEditarPedido.Text = "Editar";
            this.btnEditarPedido.UseVisualStyleBackColor = true;
            this.btnEditarPedido.Click += new System.EventHandler(this.btnEditarPedido_Click);
            // 
            // btnNuevoPedido
            // 
            this.btnNuevoPedido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPedido.Location = new System.Drawing.Point(413, 14);
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Size = new System.Drawing.Size(100, 30);
            this.btnNuevoPedido.TabIndex = 0;
            this.btnNuevoPedido.Text = "Nuevo";
            this.btnNuevoPedido.UseVisualStyleBackColor = true;
            this.btnNuevoPedido.Click += new System.EventHandler(this.btnNuevoPedido_Click);
            // 
            // lblMarcaAguaCliente
            // 
            this.lblMarcaAguaCliente.AutoSize = true;
            this.lblMarcaAguaCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaAguaCliente.ForeColor = System.Drawing.Color.Gray;
            this.lblMarcaAguaCliente.Location = new System.Drawing.Point(15, 20);
            this.lblMarcaAguaCliente.Name = "lblMarcaAguaCliente";
            this.lblMarcaAguaCliente.Size = new System.Drawing.Size(215, 19);
            this.lblMarcaAguaCliente.TabIndex = 15;
            this.lblMarcaAguaCliente.Text = "Buscar por nombre, apellido o ID";
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCliente.Location = new System.Drawing.Point(13, 16);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(322, 27);
            this.txtBuscarCliente.TabIndex = 3;
            this.txtBuscarCliente.WordWrap = false;
            // 
            // dgvListadoClientes
            // 
            this.dgvListadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoClientes.Location = new System.Drawing.Point(13, 63);
            this.dgvListadoClientes.Name = "dgvListadoClientes";
            this.dgvListadoClientes.Size = new System.Drawing.Size(859, 386);
            this.dgvListadoClientes.TabIndex = 13;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btnEliminarPedido);
            this.Controls.Add(this.btnEditarPedido);
            this.Controls.Add(this.btnNuevoPedido);
            this.Controls.Add(this.lblMarcaAguaCliente);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.dgvListadoClientes);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENTES";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarPedido;
        private System.Windows.Forms.Button btnEditarPedido;
        private System.Windows.Forms.Button btnNuevoPedido;
        private System.Windows.Forms.Label lblMarcaAguaCliente;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.DataGridView dgvListadoClientes;
    }
}