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
            this.dgvListadoClientes = new System.Windows.Forms.DataGridView();
            this.textBoxWaterMark1 = new AlimentosDC.SIGEPAC.UI.TextBoxWaterMark();
            this.dgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // dgvListadoClientes
            // 
            this.dgvListadoClientes.AllowUserToAddRows = false;
            this.dgvListadoClientes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvListadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvId,
            this.dgvNombres,
            this.dgvApellidos,
            this.dgvDui,
            this.dgvDireccion,
            this.dgvTelefono,
            this.dgvCorreo});
            this.dgvListadoClientes.Location = new System.Drawing.Point(13, 63);
            this.dgvListadoClientes.Name = "dgvListadoClientes";
            this.dgvListadoClientes.ReadOnly = true;
            this.dgvListadoClientes.Size = new System.Drawing.Size(924, 386);
            this.dgvListadoClientes.TabIndex = 13;
            // 
            // textBoxWaterMark1
            // 
            this.textBoxWaterMark1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWaterMark1.Location = new System.Drawing.Point(12, 15);
            this.textBoxWaterMark1.Name = "textBoxWaterMark1";
            this.textBoxWaterMark1.Size = new System.Drawing.Size(322, 27);
            this.textBoxWaterMark1.TabIndex = 14;
            this.textBoxWaterMark1.TextoMarcaAgua = "Buscar por nombre, apellido o ID";
            // 
            // dgvId
            // 
            this.dgvId.HeaderText = "ID";
            this.dgvId.Name = "dgvId";
            this.dgvId.ReadOnly = true;
            this.dgvId.Width = 50;
            // 
            // dgvNombres
            // 
            this.dgvNombres.HeaderText = "Nombres";
            this.dgvNombres.Name = "dgvNombres";
            this.dgvNombres.ReadOnly = true;
            this.dgvNombres.Width = 150;
            // 
            // dgvApellidos
            // 
            this.dgvApellidos.HeaderText = "Apellidos";
            this.dgvApellidos.Name = "dgvApellidos";
            this.dgvApellidos.ReadOnly = true;
            this.dgvApellidos.Width = 150;
            // 
            // dgvDui
            // 
            this.dgvDui.HeaderText = "DUI";
            this.dgvDui.Name = "dgvDui";
            this.dgvDui.ReadOnly = true;
            // 
            // dgvDireccion
            // 
            this.dgvDireccion.HeaderText = "Dirección";
            this.dgvDireccion.Name = "dgvDireccion";
            this.dgvDireccion.ReadOnly = true;
            this.dgvDireccion.Width = 150;
            // 
            // dgvTelefono
            // 
            this.dgvTelefono.HeaderText = "Teléfono";
            this.dgvTelefono.Name = "dgvTelefono";
            this.dgvTelefono.ReadOnly = true;
            this.dgvTelefono.Width = 130;
            // 
            // dgvCorreo
            // 
            this.dgvCorreo.HeaderText = "Correo";
            this.dgvCorreo.Name = "dgvCorreo";
            this.dgvCorreo.ReadOnly = true;
            this.dgvCorreo.Width = 150;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 461);
            this.Controls.Add(this.textBoxWaterMark1);
            this.Controls.Add(this.btnEliminarPedido);
            this.Controls.Add(this.btnEditarPedido);
            this.Controls.Add(this.btnNuevoPedido);
            this.Controls.Add(this.dgvListadoClientes);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENTES";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarPedido;
        private System.Windows.Forms.Button btnEditarPedido;
        private System.Windows.Forms.Button btnNuevoPedido;
        private System.Windows.Forms.DataGridView dgvListadoClientes;
        private TextBoxWaterMark textBoxWaterMark1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDui;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCorreo;
    }
}