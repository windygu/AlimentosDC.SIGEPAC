namespace AlimentosDC.SIGEPAC.UI
{
    partial class FrmCompra
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvListadoDetallesPedido = new System.Windows.Forms.DataGridView();
            this.btnGuardarPedido = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminarDetallePedido = new System.Windows.Forms.Button();
            this.btnEditarDetallePedido = new System.Windows.Forms.Button();
            this.dtpFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lableBordeInferior2 = new AlimentosDC.SIGEPAC.UI.LableBordeInferior();
            this.lableBordeInferior1 = new AlimentosDC.SIGEPAC.UI.LableBordeInferior();
            this.btnElegirCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBorderInferior1 = new AlimentosDC.SIGEPAC.UI.TextBoxBorderInferior();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBorderInferior2 = new AlimentosDC.SIGEPAC.UI.TextBoxBorderInferior();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.btnElegirProducto = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lableBordeInferior3 = new AlimentosDC.SIGEPAC.UI.LableBordeInferior();
            this.lableBordeInferior4 = new AlimentosDC.SIGEPAC.UI.LableBordeInferior();
            this.label6 = new System.Windows.Forms.Label();
            this.lableBordeInferior5 = new AlimentosDC.SIGEPAC.UI.LableBordeInferior();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lableBordeInferior7 = new AlimentosDC.SIGEPAC.UI.LableBordeInferior();
            this.label9 = new System.Windows.Forms.Label();
            this.lableBordeInferior6 = new AlimentosDC.SIGEPAC.UI.LableBordeInferior();
            this.dgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDetallesPedido)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(432, 692);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 30);
            this.btnSalir.TabIndex = 70;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
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
            this.dgvPrecioUnitario,
            this.dgvSubTotal});
            this.dgvListadoDetallesPedido.Location = new System.Drawing.Point(25, 406);
            this.dgvListadoDetallesPedido.MultiSelect = false;
            this.dgvListadoDetallesPedido.Name = "dgvListadoDetallesPedido";
            this.dgvListadoDetallesPedido.ReadOnly = true;
            this.dgvListadoDetallesPedido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListadoDetallesPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoDetallesPedido.Size = new System.Drawing.Size(785, 233);
            this.dgvListadoDetallesPedido.TabIndex = 63;
            // 
            // btnGuardarPedido
            // 
            this.btnGuardarPedido.Enabled = false;
            this.btnGuardarPedido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPedido.Location = new System.Drawing.Point(550, 692);
            this.btnGuardarPedido.Name = "btnGuardarPedido";
            this.btnGuardarPedido.Size = new System.Drawing.Size(140, 30);
            this.btnGuardarPedido.TabIndex = 61;
            this.btnGuardarPedido.Text = "Registrar compra";
            this.btnGuardarPedido.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(708, 692);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 30);
            this.btnCerrar.TabIndex = 62;
            this.btnCerrar.Text = "Cancelar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnEliminarDetallePedido
            // 
            this.btnEliminarDetallePedido.Enabled = false;
            this.btnEliminarDetallePedido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDetallePedido.Location = new System.Drawing.Point(168, 654);
            this.btnEliminarDetallePedido.Name = "btnEliminarDetallePedido";
            this.btnEliminarDetallePedido.Size = new System.Drawing.Size(125, 30);
            this.btnEliminarDetallePedido.TabIndex = 58;
            this.btnEliminarDetallePedido.Text = "Eliminar detalle";
            this.btnEliminarDetallePedido.UseVisualStyleBackColor = true;
            // 
            // btnEditarDetallePedido
            // 
            this.btnEditarDetallePedido.Enabled = false;
            this.btnEditarDetallePedido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarDetallePedido.Location = new System.Drawing.Point(25, 654);
            this.btnEditarDetallePedido.Name = "btnEditarDetallePedido";
            this.btnEditarDetallePedido.Size = new System.Drawing.Size(120, 30);
            this.btnEditarDetallePedido.TabIndex = 56;
            this.btnEditarDetallePedido.Text = "Editar detalle";
            this.btnEditarDetallePedido.UseVisualStyleBackColor = true;
            // 
            // dtpFechaCreacion
            // 
            this.dtpFechaCreacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCreacion.Location = new System.Drawing.Point(341, 63);
            this.dtpFechaCreacion.Name = "dtpFechaCreacion";
            this.dtpFechaCreacion.Size = new System.Drawing.Size(100, 25);
            this.dtpFechaCreacion.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 55;
            this.label3.Text = "Numero CCF:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lableBordeInferior2);
            this.groupBox1.Controls.Add(this.lableBordeInferior1);
            this.groupBox1.Controls.Add(this.btnElegirCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 76);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marca";
            // 
            // lableBordeInferior2
            // 
            this.lableBordeInferior2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableBordeInferior2.Location = new System.Drawing.Point(509, 25);
            this.lableBordeInferior2.Name = "lableBordeInferior2";
            this.lableBordeInferior2.Size = new System.Drawing.Size(255, 20);
            this.lableBordeInferior2.TabIndex = 6;
            // 
            // lableBordeInferior1
            // 
            this.lableBordeInferior1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableBordeInferior1.Location = new System.Drawing.Point(238, 27);
            this.lableBordeInferior1.Name = "lableBordeInferior1";
            this.lableBordeInferior1.Size = new System.Drawing.Size(150, 20);
            this.lableBordeInferior1.TabIndex = 5;
            // 
            // btnElegirCliente
            // 
            this.btnElegirCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElegirCliente.Location = new System.Drawing.Point(13, 25);
            this.btnElegirCliente.Name = "btnElegirCliente";
            this.btnElegirCliente.Size = new System.Drawing.Size(130, 30);
            this.btnElegirCliente.TabIndex = 4;
            this.btnElegirCliente.Text = "Elegir marca";
            this.btnElegirCliente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comentario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // textBoxBorderInferior1
            // 
            this.textBoxBorderInferior1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBorderInferior1.ColorBorde = System.Drawing.Color.Black;
            this.textBoxBorderInferior1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBorderInferior1.Location = new System.Drawing.Point(113, 67);
            this.textBoxBorderInferior1.Name = "textBoxBorderInferior1";
            this.textBoxBorderInferior1.Size = new System.Drawing.Size(80, 19);
            this.textBoxBorderInferior1.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 19);
            this.label4.TabIndex = 72;
            this.label4.Text = "Fecha de ingreso:";
            // 
            // textBoxBorderInferior2
            // 
            this.textBoxBorderInferior2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBorderInferior2.ColorBorde = System.Drawing.Color.Black;
            this.textBoxBorderInferior2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBorderInferior2.Location = new System.Drawing.Point(531, 67);
            this.textBoxBorderInferior2.Name = "textBoxBorderInferior2";
            this.textBoxBorderInferior2.Size = new System.Drawing.Size(277, 19);
            this.textBoxBorderInferior2.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(470, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 73;
            this.label5.Text = "Usuario:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lableBordeInferior7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lableBordeInferior6);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lableBordeInferior5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lableBordeInferior4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lableBordeInferior3);
            this.groupBox2.Controls.Add(this.nudCantidad);
            this.groupBox2.Controls.Add(this.btnAgregarDetalle);
            this.groupBox2.Controls.Add(this.btnElegirProducto);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(787, 168);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle Compra";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(81, 123);
            this.nudCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(240, 25);
            this.nudCantidad.TabIndex = 8;
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.Enabled = false;
            this.btnAgregarDetalle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDetalle.Location = new System.Drawing.Point(636, 122);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(130, 30);
            this.btnAgregarDetalle.TabIndex = 8;
            this.btnAgregarDetalle.Text = "Agregar detalle";
            this.btnAgregarDetalle.UseVisualStyleBackColor = true;
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
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(12, 126);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 19);
            this.label19.TabIndex = 43;
            this.label19.Text = "Cantidad:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(161, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 19);
            this.label12.TabIndex = 1;
            this.label12.Text = "Producto:";
            // 
            // lableBordeInferior3
            // 
            this.lableBordeInferior3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableBordeInferior3.Location = new System.Drawing.Point(230, 34);
            this.lableBordeInferior3.Name = "lableBordeInferior3";
            this.lableBordeInferior3.Size = new System.Drawing.Size(245, 19);
            this.lableBordeInferior3.TabIndex = 7;
            // 
            // lableBordeInferior4
            // 
            this.lableBordeInferior4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableBordeInferior4.Location = new System.Drawing.Point(447, 74);
            this.lableBordeInferior4.Name = "lableBordeInferior4";
            this.lableBordeInferior4.Size = new System.Drawing.Size(319, 20);
            this.lableBordeInferior4.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 48;
            this.label6.Text = "Descripción:";
            // 
            // lableBordeInferior5
            // 
            this.lableBordeInferior5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableBordeInferior5.Location = new System.Drawing.Point(116, 75);
            this.lableBordeInferior5.Name = "lableBordeInferior5";
            this.lableBordeInferior5.Size = new System.Drawing.Size(205, 19);
            this.lableBordeInferior5.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 19);
            this.label7.TabIndex = 50;
            this.label7.Text = "Precio unitario:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(513, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 19);
            this.label10.TabIndex = 52;
            this.label10.Text = "Stock:";
            // 
            // lableBordeInferior7
            // 
            this.lableBordeInferior7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableBordeInferior7.Location = new System.Drawing.Point(435, 126);
            this.lableBordeInferior7.Name = "lableBordeInferior7";
            this.lableBordeInferior7.Size = new System.Drawing.Size(176, 19);
            this.lableBordeInferior7.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(359, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 19);
            this.label9.TabIndex = 54;
            this.label9.Text = "Sub-Total:";
            // 
            // lableBordeInferior6
            // 
            this.lableBordeInferior6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableBordeInferior6.Location = new System.Drawing.Point(561, 34);
            this.lableBordeInferior6.Name = "lableBordeInferior6";
            this.lableBordeInferior6.Size = new System.Drawing.Size(205, 19);
            this.lableBordeInferior6.TabIndex = 53;
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
            this.dgvProducto.Width = 160;
            // 
            // dgvDescripcion
            // 
            this.dgvDescripcion.HeaderText = "DESCRIPCIÓN";
            this.dgvDescripcion.Name = "dgvDescripcion";
            this.dgvDescripcion.ReadOnly = true;
            this.dgvDescripcion.Width = 210;
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
            this.dgvPrecioUnitario.Width = 110;
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
            this.dgvSubTotal.Width = 120;
            // 
            // FrmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 745);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxBorderInferior2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxBorderInferior1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvListadoDetallesPedido);
            this.Controls.Add(this.btnGuardarPedido);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminarDetallePedido);
            this.Controls.Add(this.btnEditarDetallePedido);
            this.Controls.Add(this.dtpFechaCreacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCompra";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Mantenimiento Compras";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDetallesPedido)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvListadoDetallesPedido;
        private System.Windows.Forms.Button btnGuardarPedido;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminarDetallePedido;
        private System.Windows.Forms.Button btnEditarDetallePedido;
        private System.Windows.Forms.DateTimePicker dtpFechaCreacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private LableBordeInferior lableBordeInferior2;
        private LableBordeInferior lableBordeInferior1;
        private System.Windows.Forms.Button btnElegirCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private TextBoxBorderInferior textBoxBorderInferior1;
        private System.Windows.Forms.Label label4;
        private TextBoxBorderInferior textBoxBorderInferior2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.Button btnElegirProducto;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubTotal;
        private LableBordeInferior lableBordeInferior7;
        private System.Windows.Forms.Label label9;
        private LableBordeInferior lableBordeInferior6;
        private System.Windows.Forms.Label label10;
        private LableBordeInferior lableBordeInferior5;
        private System.Windows.Forms.Label label7;
        private LableBordeInferior lableBordeInferior4;
        private System.Windows.Forms.Label label6;
        private LableBordeInferior lableBordeInferior3;
    }
}