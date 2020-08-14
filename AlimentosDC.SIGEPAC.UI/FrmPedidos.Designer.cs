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
            this.dgvDui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNumeroPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDireccionEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevoPedido = new System.Windows.Forms.Button();
            this.btnEditarPedido = new System.Windows.Forms.Button();
            this.btnEliminarPedido = new System.Windows.Forms.Button();
            this.btnVerDetallePedido = new System.Windows.Forms.Button();
            this.txtBuscadorPedidos = new MetroFramework.Controls.MetroTextBox();
            this.cmbMostrando = new MetroFramework.Controls.MetroComboBox();
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
            this.dgvDui,
            this.dgvNumeroPedido,
            this.dgvFechaCreacion,
            this.dgvFechaEntrega,
            this.dgvDireccionEntrega,
            this.dgvEstado});
            this.dgvListadoPedidos.Location = new System.Drawing.Point(12, 113);
            this.dgvListadoPedidos.MultiSelect = false;
            this.dgvListadoPedidos.Name = "dgvListadoPedidos";
            this.dgvListadoPedidos.ReadOnly = true;
            this.dgvListadoPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoPedidos.Size = new System.Drawing.Size(1050, 396);
            this.dgvListadoPedidos.TabIndex = 0;
            this.dgvListadoPedidos.SelectionChanged += new System.EventHandler(this.dgvListadoPedidos_SelectionChanged);
            // 
            // dgvId
            // 
            this.dgvId.HeaderText = "Id";
            this.dgvId.Name = "dgvId";
            this.dgvId.ReadOnly = true;
            this.dgvId.Width = 50;
            // 
            // dgvCliente
            // 
            this.dgvCliente.HeaderText = "Cliente";
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.Width = 135;
            // 
            // dgvDui
            // 
            this.dgvDui.HeaderText = "DUI";
            this.dgvDui.Name = "dgvDui";
            this.dgvDui.ReadOnly = true;
            // 
            // dgvNumeroPedido
            // 
            this.dgvNumeroPedido.HeaderText = "No. Pedido";
            this.dgvNumeroPedido.Name = "dgvNumeroPedido";
            this.dgvNumeroPedido.ReadOnly = true;
            this.dgvNumeroPedido.Width = 130;
            // 
            // dgvFechaCreacion
            // 
            this.dgvFechaCreacion.HeaderText = "Fecha Creación";
            this.dgvFechaCreacion.Name = "dgvFechaCreacion";
            this.dgvFechaCreacion.ReadOnly = true;
            this.dgvFechaCreacion.Width = 120;
            // 
            // dgvFechaEntrega
            // 
            this.dgvFechaEntrega.HeaderText = "Fecha Entrega";
            this.dgvFechaEntrega.Name = "dgvFechaEntrega";
            this.dgvFechaEntrega.ReadOnly = true;
            this.dgvFechaEntrega.Width = 120;
            // 
            // dgvDireccionEntrega
            // 
            this.dgvDireccionEntrega.HeaderText = "Dirección Entrega";
            this.dgvDireccionEntrega.Name = "dgvDireccionEntrega";
            this.dgvDireccionEntrega.ReadOnly = true;
            this.dgvDireccionEntrega.Width = 190;
            // 
            // dgvEstado
            // 
            this.dgvEstado.HeaderText = "Estado";
            this.dgvEstado.Name = "dgvEstado";
            this.dgvEstado.ReadOnly = true;
            this.dgvEstado.Width = 161;
            // 
            // btnNuevoPedido
            // 
            this.btnNuevoPedido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPedido.Location = new System.Drawing.Point(335, 62);
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Size = new System.Drawing.Size(100, 30);
            this.btnNuevoPedido.TabIndex = 3;
            this.btnNuevoPedido.Text = "Nuevo";
            this.btnNuevoPedido.UseVisualStyleBackColor = true;
            this.btnNuevoPedido.Click += new System.EventHandler(this.btnNuevoPedido_Click);
            // 
            // btnEditarPedido
            // 
            this.btnEditarPedido.Enabled = false;
            this.btnEditarPedido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPedido.Location = new System.Drawing.Point(582, 62);
            this.btnEditarPedido.Name = "btnEditarPedido";
            this.btnEditarPedido.Size = new System.Drawing.Size(100, 30);
            this.btnEditarPedido.TabIndex = 4;
            this.btnEditarPedido.Text = "Editar";
            this.btnEditarPedido.UseVisualStyleBackColor = true;
            this.btnEditarPedido.Click += new System.EventHandler(this.btnEditarPedido_Click);
            // 
            // btnEliminarPedido
            // 
            this.btnEliminarPedido.Enabled = false;
            this.btnEliminarPedido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPedido.Location = new System.Drawing.Point(702, 62);
            this.btnEliminarPedido.Name = "btnEliminarPedido";
            this.btnEliminarPedido.Size = new System.Drawing.Size(100, 30);
            this.btnEliminarPedido.TabIndex = 5;
            this.btnEliminarPedido.Text = "Eliminar";
            this.btnEliminarPedido.UseVisualStyleBackColor = true;
            this.btnEliminarPedido.Click += new System.EventHandler(this.btnEliminarPedido_Click);
            // 
            // btnVerDetallePedido
            // 
            this.btnVerDetallePedido.Enabled = false;
            this.btnVerDetallePedido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetallePedido.Location = new System.Drawing.Point(457, 62);
            this.btnVerDetallePedido.Name = "btnVerDetallePedido";
            this.btnVerDetallePedido.Size = new System.Drawing.Size(100, 30);
            this.btnVerDetallePedido.TabIndex = 6;
            this.btnVerDetallePedido.Text = "Ver detalle";
            this.btnVerDetallePedido.UseVisualStyleBackColor = true;
            this.btnVerDetallePedido.Click += new System.EventHandler(this.btnVerDetallePedido_Click);
            // 
            // txtBuscadorPedidos
            // 
            // 
            // 
            // 
            this.txtBuscadorPedidos.CustomButton.Image = null;
            this.txtBuscadorPedidos.CustomButton.Location = new System.Drawing.Point(242, 2);
            this.txtBuscadorPedidos.CustomButton.Name = "";
            this.txtBuscadorPedidos.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtBuscadorPedidos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBuscadorPedidos.CustomButton.TabIndex = 1;
            this.txtBuscadorPedidos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBuscadorPedidos.CustomButton.UseSelectable = true;
            this.txtBuscadorPedidos.CustomButton.Visible = false;
            this.txtBuscadorPedidos.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtBuscadorPedidos.Lines = new string[0];
            this.txtBuscadorPedidos.Location = new System.Drawing.Point(23, 61);
            this.txtBuscadorPedidos.MaxLength = 32767;
            this.txtBuscadorPedidos.Name = "txtBuscadorPedidos";
            this.txtBuscadorPedidos.PasswordChar = '\0';
            this.txtBuscadorPedidos.PromptText = "Buscar por número de pedido o cliente";
            this.txtBuscadorPedidos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscadorPedidos.SelectedText = "";
            this.txtBuscadorPedidos.SelectionLength = 0;
            this.txtBuscadorPedidos.SelectionStart = 0;
            this.txtBuscadorPedidos.ShortcutsEnabled = true;
            this.txtBuscadorPedidos.Size = new System.Drawing.Size(270, 30);
            this.txtBuscadorPedidos.TabIndex = 8;
            this.txtBuscadorPedidos.UseSelectable = true;
            this.txtBuscadorPedidos.WaterMark = "Buscar por número de pedido o cliente";
            this.txtBuscadorPedidos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBuscadorPedidos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscadorPedidos.TextChanged += new System.EventHandler(this.txtBuscadorPedidos_TextChanged);
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
            this.cmbMostrando.Location = new System.Drawing.Point(854, 63);
            this.cmbMostrando.Name = "cmbMostrando";
            this.cmbMostrando.Size = new System.Drawing.Size(200, 29);
            this.cmbMostrando.TabIndex = 9;
            this.cmbMostrando.UseSelectable = true;
            this.cmbMostrando.SelectionChangeCommitted += new System.EventHandler(this.cmbMostrando_SelectionChangeCommitted);
            this.cmbMostrando.SelectedValueChanged += new System.EventHandler(this.cmbMostrando_SelectionChangeCommitted);
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 521);
            this.Controls.Add(this.cmbMostrando);
            this.Controls.Add(this.txtBuscadorPedidos);
            this.Controls.Add(this.btnVerDetallePedido);
            this.Controls.Add(this.btnEliminarPedido);
            this.Controls.Add(this.btnEditarPedido);
            this.Controls.Add(this.btnNuevoPedido);
            this.Controls.Add(this.dgvListadoPedidos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximizeBox = false;
            this.Name = "FrmPedidos";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Tag = "";
            this.Text = "PEDIDOS";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            this.Click += new System.EventHandler(this.FrmPedidos_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoPedidos;
        private System.Windows.Forms.Button btnEditarPedido;
        private System.Windows.Forms.Button btnEliminarPedido;
        private System.Windows.Forms.Button btnVerDetallePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDui;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNumeroPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDireccionEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEstado;
        private MetroFramework.Controls.MetroTextBox txtBuscadorPedidos;
        private MetroFramework.Controls.MetroComboBox cmbMostrando;
        private System.Windows.Forms.Button btnNuevoPedido;
    }
}