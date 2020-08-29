namespace AlimentosDC.SIGEPAC.UI
{
    partial class FrmPedido
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedido));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnElegirCliente = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblDui = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDireccionEntregaPedido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.btnEditarDetallePedido = new System.Windows.Forms.Button();
            this.btnEliminarDetallePedido = new System.Windows.Forms.Button();
            this.btnGuardarPedido = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvListadoDetallesPedido = new System.Windows.Forms.DataGridView();
            this.dgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNumeroPedido = new System.Windows.Forms.Label();
            this.epValidadorControles = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.btnElegirProducto = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbEstadoDetallePedido = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblStockProducto = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblDescripcionProducto = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCCF = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbEstadoPedido = new System.Windows.Forms.ComboBox();
            this.txtPagaCon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDetallesPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epValidadorControles)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(603, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "DUI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sr. (a):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnElegirCliente);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.lblDui);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 76);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // btnElegirCliente
            // 
            this.btnElegirCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElegirCliente.Location = new System.Drawing.Point(13, 25);
            this.btnElegirCliente.Name = "btnElegirCliente";
            this.btnElegirCliente.Size = new System.Drawing.Size(130, 30);
            this.btnElegirCliente.TabIndex = 4;
            this.btnElegirCliente.Text = "Elegir cliente";
            this.btnElegirCliente.UseVisualStyleBackColor = true;
            this.btnElegirCliente.Click += new System.EventHandler(this.btnElegirCliente_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCliente.Location = new System.Drawing.Point(246, 30);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(311, 25);
            this.lblCliente.TabIndex = 7;
            // 
            // lblDui
            // 
            this.lblDui.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDui.Location = new System.Drawing.Point(644, 32);
            this.lblDui.Name = "lblDui";
            this.lblDui.Size = new System.Drawing.Size(181, 25);
            this.lblDui.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "No. Pedido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de creación:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(446, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha de entrega:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(297, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dirección de entrega:";
            // 
            // txtDireccionEntregaPedido
            // 
            this.txtDireccionEntregaPedido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionEntregaPedido.Location = new System.Drawing.Point(440, 128);
            this.txtDireccionEntregaPedido.MaxLength = 200;
            this.txtDireccionEntregaPedido.Multiline = true;
            this.txtDireccionEntregaPedido.Name = "txtDireccionEntregaPedido";
            this.txtDireccionEntregaPedido.Size = new System.Drawing.Size(229, 50);
            this.txtDireccionEntregaPedido.TabIndex = 3;
            this.txtDireccionEntregaPedido.TextChanged += new System.EventHandler(this.txtDireccionEntregaPedido_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Estado:";
            // 
            // dtpFechaCreacion
            // 
            this.dtpFechaCreacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCreacion.Location = new System.Drawing.Point(289, 72);
            this.dtpFechaCreacion.Name = "dtpFechaCreacion";
            this.dtpFechaCreacion.Size = new System.Drawing.Size(100, 25);
            this.dtpFechaCreacion.TabIndex = 0;
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(569, 74);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(100, 25);
            this.dtpFechaEntrega.TabIndex = 1;
            // 
            // btnEditarDetallePedido
            // 
            this.btnEditarDetallePedido.Enabled = false;
            this.btnEditarDetallePedido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarDetallePedido.Location = new System.Drawing.Point(23, 693);
            this.btnEditarDetallePedido.Name = "btnEditarDetallePedido";
            this.btnEditarDetallePedido.Size = new System.Drawing.Size(120, 30);
            this.btnEditarDetallePedido.TabIndex = 9;
            this.btnEditarDetallePedido.Text = "Editar detalle";
            this.btnEditarDetallePedido.UseVisualStyleBackColor = true;
            this.btnEditarDetallePedido.Click += new System.EventHandler(this.btnEditarDetallePedido_Click);
            // 
            // btnEliminarDetallePedido
            // 
            this.btnEliminarDetallePedido.Enabled = false;
            this.btnEliminarDetallePedido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDetallePedido.Location = new System.Drawing.Point(169, 693);
            this.btnEliminarDetallePedido.Name = "btnEliminarDetallePedido";
            this.btnEliminarDetallePedido.Size = new System.Drawing.Size(125, 30);
            this.btnEliminarDetallePedido.TabIndex = 10;
            this.btnEliminarDetallePedido.Text = "Eliminar detalle";
            this.btnEliminarDetallePedido.UseVisualStyleBackColor = true;
            this.btnEliminarDetallePedido.Click += new System.EventHandler(this.btnEliminarDetallePedido_Click);
            // 
            // btnGuardarPedido
            // 
            this.btnGuardarPedido.Enabled = false;
            this.btnGuardarPedido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPedido.Location = new System.Drawing.Point(631, 747);
            this.btnGuardarPedido.Name = "btnGuardarPedido";
            this.btnGuardarPedido.Size = new System.Drawing.Size(128, 30);
            this.btnGuardarPedido.TabIndex = 12;
            this.btnGuardarPedido.Text = "Registrar pedido";
            this.btnGuardarPedido.UseVisualStyleBackColor = true;
            this.btnGuardarPedido.Click += new System.EventHandler(this.btnGuardarPedido_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(777, 747);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 30);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cancelar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvListadoDetallesPedido
            // 
            this.dgvListadoDetallesPedido.AllowUserToAddRows = false;
            this.dgvListadoDetallesPedido.AllowUserToDeleteRows = false;
            this.dgvListadoDetallesPedido.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvListadoDetallesPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoDetallesPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvId,
            this.dgvCantidad,
            this.dgvProducto,
            this.dgvDescripcion,
            this.dgvEstado,
            this.dgvPrecioUnitario,
            this.dgvSubTotal});
            this.dgvListadoDetallesPedido.Location = new System.Drawing.Point(23, 445);
            this.dgvListadoDetallesPedido.MultiSelect = false;
            this.dgvListadoDetallesPedido.Name = "dgvListadoDetallesPedido";
            this.dgvListadoDetallesPedido.ReadOnly = true;
            this.dgvListadoDetallesPedido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListadoDetallesPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoDetallesPedido.Size = new System.Drawing.Size(849, 233);
            this.dgvListadoDetallesPedido.TabIndex = 29;
            this.dgvListadoDetallesPedido.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvListadoDetallesPedido_RowsAdded);
            this.dgvListadoDetallesPedido.SelectionChanged += new System.EventHandler(this.dgvListadoDetallesPedido_SelectionChanged);
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
            this.dgvProducto.Width = 140;
            // 
            // dgvDescripcion
            // 
            this.dgvDescripcion.HeaderText = "DESCRIPCIÓN";
            this.dgvDescripcion.Name = "dgvDescripcion";
            this.dgvDescripcion.ReadOnly = true;
            this.dgvDescripcion.Width = 195;
            // 
            // dgvEstado
            // 
            this.dgvEstado.HeaderText = "ESTADO";
            this.dgvEstado.Name = "dgvEstado";
            this.dgvEstado.ReadOnly = true;
            this.dgvEstado.Width = 120;
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
            this.dgvSubTotal.Width = 110;
            // 
            // lblNumeroPedido
            // 
            this.lblNumeroPedido.AutoSize = true;
            this.lblNumeroPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumeroPedido.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPedido.Location = new System.Drawing.Point(103, 75);
            this.lblNumeroPedido.Name = "lblNumeroPedido";
            this.lblNumeroPedido.Size = new System.Drawing.Size(21, 23);
            this.lblNumeroPedido.TabIndex = 30;
            this.lblNumeroPedido.Text = "0";
            // 
            // epValidadorControles
            // 
            this.epValidadorControles.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudCantidad);
            this.groupBox2.Controls.Add(this.lblSubTotal);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnAgregarDetalle);
            this.groupBox2.Controls.Add(this.btnElegirProducto);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.cmbEstadoDetallePedido);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.lblPrecioUnitario);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.lblStockProducto);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.lblNombreProducto);
            this.groupBox2.Controls.Add(this.lblDescripcionProducto);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(849, 162);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle Pedido";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(101, 124);
            this.nudCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(232, 25);
            this.nudCantidad.TabIndex = 8;
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubTotal.Location = new System.Drawing.Point(430, 126);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(220, 25);
            this.lblSubTotal.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(355, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 46;
            this.label9.Text = "Sub-total:";
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.Enabled = false;
            this.btnAgregarDetalle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDetalle.Location = new System.Drawing.Point(695, 119);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(130, 30);
            this.btnAgregarDetalle.TabIndex = 8;
            this.btnAgregarDetalle.Text = "Agregar detalle";
            this.btnAgregarDetalle.UseVisualStyleBackColor = true;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // btnElegirProducto
            // 
            this.btnElegirProducto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElegirProducto.Location = new System.Drawing.Point(13, 28);
            this.btnElegirProducto.Name = "btnElegirProducto";
            this.btnElegirProducto.Size = new System.Drawing.Size(130, 30);
            this.btnElegirProducto.TabIndex = 5;
            this.btnElegirProducto.Text = "Elegir producto";
            this.btnElegirProducto.UseVisualStyleBackColor = true;
            this.btnElegirProducto.Click += new System.EventHandler(this.btnElegirProducto_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(9, 127);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 19);
            this.label19.TabIndex = 43;
            this.label19.Text = "Cantidad:";
            // 
            // cmbEstadoDetallePedido
            // 
            this.cmbEstadoDetallePedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoDetallePedido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoDetallePedido.FormattingEnabled = true;
            this.cmbEstadoDetallePedido.Items.AddRange(new object[] {
            "- Seleccione -",
            "No iniciado",
            "Iniciado",
            "Revisado",
            "Enviado",
            "Finalizado"});
            this.cmbEstadoDetallePedido.Location = new System.Drawing.Point(644, 30);
            this.cmbEstadoDetallePedido.Name = "cmbEstadoDetallePedido";
            this.cmbEstadoDetallePedido.Size = new System.Drawing.Size(181, 25);
            this.cmbEstadoDetallePedido.TabIndex = 6;
            this.cmbEstadoDetallePedido.SelectionChangeCommitted += new System.EventHandler(this.cmbEstadoDetallePedido_SelectionChangeCommitted);
            this.cmbEstadoDetallePedido.DropDownClosed += new System.EventHandler(this.cmbEstadoDetallePedido_DropDownClosed);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(582, 34);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 17);
            this.label20.TabIndex = 41;
            this.label20.Text = "Estado:";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(466, 76);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(184, 25);
            this.lblPrecioUnitario.TabIndex = 40;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(357, 77);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(103, 17);
            this.label18.TabIndex = 39;
            this.label18.Text = "Precio unitario:";
            // 
            // lblStockProducto
            // 
            this.lblStockProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStockProducto.Location = new System.Drawing.Point(725, 76);
            this.lblStockProducto.Name = "lblStockProducto";
            this.lblStockProducto.Size = new System.Drawing.Size(100, 25);
            this.lblStockProducto.TabIndex = 38;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(665, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 17);
            this.label16.TabIndex = 37;
            this.label16.Text = "Stock:";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombreProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(229, 32);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(301, 25);
            this.lblNombreProducto.TabIndex = 36;
            // 
            // lblDescripcionProducto
            // 
            this.lblDescripcionProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescripcionProducto.Location = new System.Drawing.Point(101, 77);
            this.lblDescripcionProducto.Name = "lblDescripcionProducto";
            this.lblDescripcionProducto.Size = new System.Drawing.Size(232, 25);
            this.lblDescripcionProducto.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Descripción:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(161, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Producto:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblCCF);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(698, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 92);
            this.panel1.TabIndex = 36;
            // 
            // lblCCF
            // 
            this.lblCCF.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCF.ForeColor = System.Drawing.Color.Red;
            this.lblCCF.Location = new System.Drawing.Point(14, 31);
            this.lblCCF.Name = "lblCCF";
            this.lblCCF.Size = new System.Drawing.Size(143, 42);
            this.lblCCF.TabIndex = 37;
            this.lblCCF.Text = "000003";
            this.lblCCF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(-1, -1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 25);
            this.label13.TabIndex = 45;
            this.label13.Text = "CCF";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbEstadoPedido
            // 
            this.cmbEstadoPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoPedido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoPedido.FormattingEnabled = true;
            this.cmbEstadoPedido.Items.AddRange(new object[] {
            "- Seleccione -",
            "No iniciado",
            "Iniciado",
            "Revisado",
            "Enviado",
            "Finalizado"});
            this.cmbEstadoPedido.Location = new System.Drawing.Point(76, 128);
            this.cmbEstadoPedido.Name = "cmbEstadoPedido";
            this.cmbEstadoPedido.Size = new System.Drawing.Size(204, 25);
            this.cmbEstadoPedido.TabIndex = 2;
            this.cmbEstadoPedido.SelectionChangeCommitted += new System.EventHandler(this.cmbEstadoPedido_SelectionChangeCommitted_1);
            this.cmbEstadoPedido.DropDownClosed += new System.EventHandler(this.cmbEstadoPedido_DropDownClosed_1);
            // 
            // txtPagaCon
            // 
            this.txtPagaCon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagaCon.Location = new System.Drawing.Point(393, 694);
            this.txtPagaCon.MaxLength = 200;
            this.txtPagaCon.Multiline = true;
            this.txtPagaCon.Name = "txtPagaCon";
            this.txtPagaCon.Size = new System.Drawing.Size(157, 25);
            this.txtPagaCon.TabIndex = 11;
            this.txtPagaCon.TextChanged += new System.EventHandler(this.txtPagaCon_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(319, 698);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 19);
            this.label8.TabIndex = 46;
            this.label8.Text = "Paga con:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(586, 697);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 19);
            this.label11.TabIndex = 48;
            this.label11.Text = "Cambio:";
            // 
            // lblCambio
            // 
            this.lblCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Location = new System.Drawing.Point(657, 694);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(192, 25);
            this.lblCambio.TabIndex = 48;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(513, 747);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 30);
            this.btnSalir.TabIndex = 49;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 795);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPagaCon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbEstadoPedido);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblNumeroPedido);
            this.Controls.Add(this.dgvListadoDetallesPedido);
            this.Controls.Add(this.btnGuardarPedido);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminarDetallePedido);
            this.Controls.Add(this.btnEditarDetallePedido);
            this.Controls.Add(this.dtpFechaEntrega);
            this.Controls.Add(this.dtpFechaCreacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDireccionEntregaPedido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPedido";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Tag = "";
            this.Text = "Mantenimiento Pedidos";
            this.Load += new System.EventHandler(this.FrmPedido_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDetallesPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epValidadorControles)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDireccionEntregaPedido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaCreacion;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.Button btnEditarDetallePedido;
        private System.Windows.Forms.Button btnEliminarDetallePedido;
        private System.Windows.Forms.Button btnGuardarPedido;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvListadoDetallesPedido;
        private System.Windows.Forms.Label lblNumeroPedido;
        private System.Windows.Forms.Label lblDui;
        private System.Windows.Forms.ErrorProvider epValidadorControles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblDescripcionProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblStockProducto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbEstadoDetallePedido;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCCF;
        private System.Windows.Forms.Button btnElegirCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbEstadoPedido;
        private System.Windows.Forms.Button btnElegirProducto;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubTotal;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPagaCon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnSalir;
    }
}