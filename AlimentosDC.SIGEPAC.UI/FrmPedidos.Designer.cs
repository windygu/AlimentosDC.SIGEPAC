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
            this.dgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNumeroPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNumeroCCF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDireccionEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditarPedido = new System.Windows.Forms.Button();
            this.btnEliminarPedido = new System.Windows.Forms.Button();
            this.btnVerDetallePedido = new System.Windows.Forms.Button();
            this.cmbMostrando = new MetroFramework.Controls.MetroComboBox();
            this.txtBuscadorPedidos = new AlimentosDC.SIGEPAC.UI.TextBoxWaterMark();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoPedidos
            // 
            this.dgvListadoPedidos.AllowUserToAddRows = false;
            this.dgvListadoPedidos.AllowUserToDeleteRows = false;
            this.dgvListadoPedidos.AllowUserToResizeRows = false;
            this.dgvListadoPedidos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvListadoPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvId,
            this.dgvCliente,
            this.dgvUsuario,
            this.dgvDui,
            this.dgvNumeroPedido,
            this.dgvNumeroCCF,
            this.dgvFechaCreacion,
            this.dgvFechaEntrega,
            this.dgvDireccionEntrega,
            this.dgvEstado});
            this.dgvListadoPedidos.Location = new System.Drawing.Point(12, 113);
            this.dgvListadoPedidos.MultiSelect = false;
            this.dgvListadoPedidos.Name = "dgvListadoPedidos";
            this.dgvListadoPedidos.ReadOnly = true;
            this.dgvListadoPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoPedidos.Size = new System.Drawing.Size(1178, 396);
            this.dgvListadoPedidos.TabIndex = 0;
            this.dgvListadoPedidos.SelectionChanged += new System.EventHandler(this.dgvListadoPedidos_SelectionChanged);
            // 
            // dgvId
            // 
            this.dgvId.Frozen = true;
            this.dgvId.HeaderText = "ID";
            this.dgvId.Name = "dgvId";
            this.dgvId.ReadOnly = true;
            this.dgvId.Width = 50;
            // 
            // dgvCliente
            // 
            this.dgvCliente.Frozen = true;
            this.dgvCliente.HeaderText = "CLIENTE";
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.Width = 145;
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.Frozen = true;
            this.dgvUsuario.HeaderText = "USUARIO";
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            this.dgvUsuario.Width = 180;
            // 
            // dgvDui
            // 
            this.dgvDui.Frozen = true;
            this.dgvDui.HeaderText = "DUI";
            this.dgvDui.Name = "dgvDui";
            this.dgvDui.ReadOnly = true;
            // 
            // dgvNumeroPedido
            // 
            this.dgvNumeroPedido.Frozen = true;
            this.dgvNumeroPedido.HeaderText = "NO. PEDIDO";
            this.dgvNumeroPedido.Name = "dgvNumeroPedido";
            this.dgvNumeroPedido.ReadOnly = true;
            this.dgvNumeroPedido.Width = 70;
            // 
            // dgvNumeroCCF
            // 
            this.dgvNumeroCCF.Frozen = true;
            this.dgvNumeroCCF.HeaderText = "NO. CCF";
            this.dgvNumeroCCF.Name = "dgvNumeroCCF";
            this.dgvNumeroCCF.ReadOnly = true;
            // 
            // dgvFechaCreacion
            // 
            this.dgvFechaCreacion.HeaderText = "F. CREACIÓN";
            this.dgvFechaCreacion.Name = "dgvFechaCreacion";
            this.dgvFechaCreacion.ReadOnly = true;
            this.dgvFechaCreacion.Width = 80;
            // 
            // dgvFechaEntrega
            // 
            this.dgvFechaEntrega.HeaderText = "F. ENTREGA";
            this.dgvFechaEntrega.Name = "dgvFechaEntrega";
            this.dgvFechaEntrega.ReadOnly = true;
            this.dgvFechaEntrega.Width = 80;
            // 
            // dgvDireccionEntrega
            // 
            this.dgvDireccionEntrega.HeaderText = "DIR.  ENTREGA";
            this.dgvDireccionEntrega.Name = "dgvDireccionEntrega";
            this.dgvDireccionEntrega.ReadOnly = true;
            this.dgvDireccionEntrega.Width = 190;
            // 
            // dgvEstado
            // 
            this.dgvEstado.HeaderText = "ESTADO";
            this.dgvEstado.Name = "dgvEstado";
            this.dgvEstado.ReadOnly = true;
            this.dgvEstado.Width = 140;
            // 
            // btnEditarPedido
            // 
            this.btnEditarPedido.Enabled = false;
            this.btnEditarPedido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPedido.Location = new System.Drawing.Point(683, 60);
            this.btnEditarPedido.Name = "btnEditarPedido";
            this.btnEditarPedido.Size = new System.Drawing.Size(100, 30);
            this.btnEditarPedido.TabIndex = 3;
            this.btnEditarPedido.Text = "Editar";
            this.btnEditarPedido.UseVisualStyleBackColor = true;
            this.btnEditarPedido.Click += new System.EventHandler(this.btnEditarPedido_Click);
            // 
            // btnEliminarPedido
            // 
            this.btnEliminarPedido.Enabled = false;
            this.btnEliminarPedido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPedido.Location = new System.Drawing.Point(803, 60);
            this.btnEliminarPedido.Name = "btnEliminarPedido";
            this.btnEliminarPedido.Size = new System.Drawing.Size(100, 30);
            this.btnEliminarPedido.TabIndex = 4;
            this.btnEliminarPedido.Text = "Eliminar";
            this.btnEliminarPedido.UseVisualStyleBackColor = true;
            this.btnEliminarPedido.Click += new System.EventHandler(this.btnEliminarPedido_Click);
            // 
            // btnVerDetallePedido
            // 
            this.btnVerDetallePedido.Enabled = false;
            this.btnVerDetallePedido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetallePedido.Location = new System.Drawing.Point(558, 60);
            this.btnVerDetallePedido.Name = "btnVerDetallePedido";
            this.btnVerDetallePedido.Size = new System.Drawing.Size(100, 30);
            this.btnVerDetallePedido.TabIndex = 2;
            this.btnVerDetallePedido.Text = "Ver detalle";
            this.btnVerDetallePedido.UseVisualStyleBackColor = true;
            this.btnVerDetallePedido.Click += new System.EventHandler(this.btnVerDetallePedido_Click);
            // 
            // cmbMostrando
            // 
            this.cmbMostrando.FormattingEnabled = true;
            this.cmbMostrando.ItemHeight = 23;
            this.cmbMostrando.Items.AddRange(new object[] {
            "Todos",
            "No iniciados",
            "Iniciados",
            "Revisados",
            "Enviados",
            "Finalizados"});
            this.cmbMostrando.Location = new System.Drawing.Point(333, 62);
            this.cmbMostrando.Name = "cmbMostrando";
            this.cmbMostrando.Size = new System.Drawing.Size(200, 29);
            this.cmbMostrando.TabIndex = 1;
            this.cmbMostrando.UseSelectable = true;
            this.cmbMostrando.SelectionChangeCommitted += new System.EventHandler(this.cmbMostrando_SelectionChangeCommitted);
            this.cmbMostrando.SelectedValueChanged += new System.EventHandler(this.cmbMostrando_SelectionChangeCommitted);
            // 
            // txtBuscadorPedidos
            // 
            this.txtBuscadorPedidos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscadorPedidos.Location = new System.Drawing.Point(23, 62);
            this.txtBuscadorPedidos.Name = "txtBuscadorPedidos";
            this.txtBuscadorPedidos.Size = new System.Drawing.Size(288, 27);
            this.txtBuscadorPedidos.TabIndex = 0;
            this.txtBuscadorPedidos.TextoMarcaAgua = "Buscar por número de pedido o cliente";
            this.txtBuscadorPedidos.TextChanged += new System.EventHandler(this.txtBuscadorPedidos_TextChanged);
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 521);
            this.Controls.Add(this.txtBuscadorPedidos);
            this.Controls.Add(this.cmbMostrando);
            this.Controls.Add(this.btnVerDetallePedido);
            this.Controls.Add(this.btnEliminarPedido);
            this.Controls.Add(this.btnEditarPedido);
            this.Controls.Add(this.dgvListadoPedidos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximizeBox = false;
            this.Name = "FrmPedidos";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Tag = "";
            this.Text = "HISTORIAL PEDIDOS";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            this.Click += new System.EventHandler(this.FrmPedidos_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoPedidos;
        private System.Windows.Forms.Button btnEditarPedido;
        private System.Windows.Forms.Button btnEliminarPedido;
        private System.Windows.Forms.Button btnVerDetallePedido;
        private MetroFramework.Controls.MetroComboBox cmbMostrando;
        private TextBoxWaterMark txtBuscadorPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDui;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNumeroPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNumeroCCF;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDireccionEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEstado;
    }
}