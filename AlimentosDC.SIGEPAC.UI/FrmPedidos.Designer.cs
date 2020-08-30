﻿namespace AlimentosDC.SIGEPAC.UI
{
    partial class FrmHistoriales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistoriales));
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtBuscadorPedidos = new AlimentosDC.SIGEPAC.UI.TextBoxWaterMark();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpPedidos = new System.Windows.Forms.TabPage();
            this.tbpIngresos = new System.Windows.Forms.TabPage();
            this.txtBuscadorCompras = new AlimentosDC.SIGEPAC.UI.TextBoxWaterMark();
            this.btnEditarIngreso = new System.Windows.Forms.Button();
            this.btnEliminarIngreso = new System.Windows.Forms.Button();
            this.dgvListadoIngresos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerDetalleIngreso = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPedidos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tbpPedidos.SuspendLayout();
            this.tbpIngresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoIngresos)).BeginInit();
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
            this.dgvListadoPedidos.Location = new System.Drawing.Point(6, 49);
            this.dgvListadoPedidos.MultiSelect = false;
            this.dgvListadoPedidos.Name = "dgvListadoPedidos";
            this.dgvListadoPedidos.ReadOnly = true;
            this.dgvListadoPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoPedidos.Size = new System.Drawing.Size(1178, 363);
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
            this.dgvNumeroCCF.Width = 80;
            // 
            // dgvFechaCreacion
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dgvFechaCreacion.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFechaCreacion.HeaderText = "F. CREACIÓN";
            this.dgvFechaCreacion.Name = "dgvFechaCreacion";
            this.dgvFechaCreacion.ReadOnly = true;
            this.dgvFechaCreacion.Width = 80;
            // 
            // dgvFechaEntrega
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dgvFechaEntrega.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.btnEditarPedido.Location = new System.Drawing.Point(712, 3);
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
            this.btnEliminarPedido.Location = new System.Drawing.Point(832, 3);
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
            this.btnVerDetallePedido.Location = new System.Drawing.Point(587, 3);
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
            this.cmbMostrando.Location = new System.Drawing.Point(362, 5);
            this.cmbMostrando.Name = "cmbMostrando";
            this.cmbMostrando.Size = new System.Drawing.Size(200, 29);
            this.cmbMostrando.TabIndex = 1;
            this.cmbMostrando.UseSelectable = true;
            this.cmbMostrando.SelectionChangeCommitted += new System.EventHandler(this.cmbMostrando_SelectionChangeCommitted);
            this.cmbMostrando.SelectedValueChanged += new System.EventHandler(this.cmbMostrando_SelectionChangeCommitted);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(1083, 418);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 30);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(965, 418);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 30);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtBuscadorPedidos
            // 
            this.txtBuscadorPedidos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscadorPedidos.Location = new System.Drawing.Point(6, 6);
            this.txtBuscadorPedidos.Name = "txtBuscadorPedidos";
            this.txtBuscadorPedidos.Size = new System.Drawing.Size(335, 27);
            this.txtBuscadorPedidos.TabIndex = 0;
            this.txtBuscadorPedidos.TextoMarcaAgua = "Buscar por número de pedido o cliente";
            this.txtBuscadorPedidos.TextChanged += new System.EventHandler(this.txtBuscadorPedidos_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpPedidos);
            this.tabControl1.Controls.Add(this.tbpIngresos);
            this.tabControl1.Location = new System.Drawing.Point(24, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1197, 447);
            this.tabControl1.TabIndex = 7;
            // 
            // tbpPedidos
            // 
            this.tbpPedidos.Controls.Add(this.txtBuscadorPedidos);
            this.tbpPedidos.Controls.Add(this.btnSalir);
            this.tbpPedidos.Controls.Add(this.btnEditarPedido);
            this.tbpPedidos.Controls.Add(this.btnCerrar);
            this.tbpPedidos.Controls.Add(this.btnEliminarPedido);
            this.tbpPedidos.Controls.Add(this.dgvListadoPedidos);
            this.tbpPedidos.Controls.Add(this.btnVerDetallePedido);
            this.tbpPedidos.Controls.Add(this.cmbMostrando);
            this.tbpPedidos.Location = new System.Drawing.Point(4, 22);
            this.tbpPedidos.Name = "tbpPedidos";
            this.tbpPedidos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPedidos.Size = new System.Drawing.Size(1189, 421);
            this.tbpPedidos.TabIndex = 0;
            this.tbpPedidos.Text = "PEDIDOS";
            this.tbpPedidos.UseVisualStyleBackColor = true;
            // 
            // tbpIngresos
            // 
            this.tbpIngresos.Controls.Add(this.txtBuscadorCompras);
            this.tbpIngresos.Controls.Add(this.btnEditarIngreso);
            this.tbpIngresos.Controls.Add(this.btnEliminarIngreso);
            this.tbpIngresos.Controls.Add(this.dgvListadoIngresos);
            this.tbpIngresos.Controls.Add(this.btnVerDetalleIngreso);
            this.tbpIngresos.Location = new System.Drawing.Point(4, 22);
            this.tbpIngresos.Name = "tbpIngresos";
            this.tbpIngresos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpIngresos.Size = new System.Drawing.Size(1189, 421);
            this.tbpIngresos.TabIndex = 1;
            this.tbpIngresos.Text = "COMPRAS";
            this.tbpIngresos.UseVisualStyleBackColor = true;
            // 
            // txtBuscadorCompras
            // 
            this.txtBuscadorCompras.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscadorCompras.Location = new System.Drawing.Point(5, 8);
            this.txtBuscadorCompras.Name = "txtBuscadorCompras";
            this.txtBuscadorCompras.Size = new System.Drawing.Size(335, 27);
            this.txtBuscadorCompras.TabIndex = 7;
            this.txtBuscadorCompras.TextoMarcaAgua = "Buscar por marca, mes, año o usuario";
            this.txtBuscadorCompras.TextChanged += new System.EventHandler(this.txtBuscadorCompras_TextChanged);
            // 
            // btnEditarIngreso
            // 
            this.btnEditarIngreso.Enabled = false;
            this.btnEditarIngreso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarIngreso.Location = new System.Drawing.Point(485, 6);
            this.btnEditarIngreso.Name = "btnEditarIngreso";
            this.btnEditarIngreso.Size = new System.Drawing.Size(100, 30);
            this.btnEditarIngreso.TabIndex = 11;
            this.btnEditarIngreso.Text = "Editar";
            this.btnEditarIngreso.UseVisualStyleBackColor = true;
            this.btnEditarIngreso.Click += new System.EventHandler(this.btnEditarIngreso_Click);
            // 
            // btnEliminarIngreso
            // 
            this.btnEliminarIngreso.Enabled = false;
            this.btnEliminarIngreso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarIngreso.Location = new System.Drawing.Point(605, 6);
            this.btnEliminarIngreso.Name = "btnEliminarIngreso";
            this.btnEliminarIngreso.Size = new System.Drawing.Size(100, 30);
            this.btnEliminarIngreso.TabIndex = 12;
            this.btnEliminarIngreso.Text = "Eliminar";
            this.btnEliminarIngreso.UseVisualStyleBackColor = true;
            this.btnEliminarIngreso.Click += new System.EventHandler(this.btnEliminarIngreso_Click);
            // 
            // dgvListadoIngresos
            // 
            this.dgvListadoIngresos.AllowUserToAddRows = false;
            this.dgvListadoIngresos.AllowUserToDeleteRows = false;
            this.dgvListadoIngresos.AllowUserToResizeRows = false;
            this.dgvListadoIngresos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvListadoIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoIngresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvListadoIngresos.Location = new System.Drawing.Point(5, 51);
            this.dgvListadoIngresos.MultiSelect = false;
            this.dgvListadoIngresos.Name = "dgvListadoIngresos";
            this.dgvListadoIngresos.ReadOnly = true;
            this.dgvListadoIngresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoIngresos.Size = new System.Drawing.Size(1178, 363);
            this.dgvListadoIngresos.TabIndex = 8;
            this.dgvListadoIngresos.SelectionChanged += new System.EventHandler(this.dgvListadoIngresos_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "NO. CCF";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "MARCA";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 270;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "FECHA INGRESO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.Frozen = true;
            this.dataGridViewTextBoxColumn5.HeaderText = "SUMAS";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.Frozen = true;
            this.dataGridViewTextBoxColumn6.HeaderText = "IVA";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn7.HeaderText = "TOTAL";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 120;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn8.HeaderText = "USUARIO";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 250;
            // 
            // btnVerDetalleIngreso
            // 
            this.btnVerDetalleIngreso.Enabled = false;
            this.btnVerDetalleIngreso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalleIngreso.Location = new System.Drawing.Point(360, 6);
            this.btnVerDetalleIngreso.Name = "btnVerDetalleIngreso";
            this.btnVerDetalleIngreso.Size = new System.Drawing.Size(100, 30);
            this.btnVerDetalleIngreso.TabIndex = 10;
            this.btnVerDetalleIngreso.Text = "Ver detalle";
            this.btnVerDetalleIngreso.UseVisualStyleBackColor = true;
            this.btnVerDetalleIngreso.Click += new System.EventHandler(this.btnVerDetalleIngreso_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1003, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1121, 516);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 30);
            this.button3.TabIndex = 13;
            this.button3.Text = "Cerrar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FrmHistoriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 566);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximizeBox = false;
            this.Name = "FrmHistoriales";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Tag = "";
            this.Text = "HISTORIALES";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            this.Click += new System.EventHandler(this.FrmPedidos_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPedidos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tbpPedidos.ResumeLayout(false);
            this.tbpPedidos.PerformLayout();
            this.tbpIngresos.ResumeLayout(false);
            this.tbpIngresos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoIngresos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoPedidos;
        private System.Windows.Forms.Button btnEditarPedido;
        private System.Windows.Forms.Button btnEliminarPedido;
        private System.Windows.Forms.Button btnVerDetallePedido;
        private MetroFramework.Controls.MetroComboBox cmbMostrando;
        private TextBoxWaterMark txtBuscadorPedidos;
        private System.Windows.Forms.Button btnCerrar;
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
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpPedidos;
        private System.Windows.Forms.TabPage tbpIngresos;
        private TextBoxWaterMark txtBuscadorCompras;
        private System.Windows.Forms.Button btnEditarIngreso;
        private System.Windows.Forms.Button btnEliminarIngreso;
        private System.Windows.Forms.DataGridView dgvListadoIngresos;
        private System.Windows.Forms.Button btnVerDetalleIngreso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}