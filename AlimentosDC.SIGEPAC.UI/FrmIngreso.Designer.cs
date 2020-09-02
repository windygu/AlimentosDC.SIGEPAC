namespace AlimentosDC.SIGEPAC.UI
{
    partial class FrmIngreso
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvListadoDetallesIngreso = new System.Windows.Forms.DataGridView();
            this.dgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardarIngreso = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminarDetalleIngreso = new System.Windows.Forms.Button();
            this.btnEditarDetalleIngreso = new System.Windows.Forms.Button();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSubTotal = new AlimentosDC.SIGEPAC.UI.LableBordeInferior();
            this.label9 = new System.Windows.Forms.Label();
            this.lblStock = new AlimentosDC.SIGEPAC.UI.LableBordeInferior();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPrecioUnitario = new AlimentosDC.SIGEPAC.UI.LableBordeInferior();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDescripcion = new AlimentosDC.SIGEPAC.UI.LableBordeInferior();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNombreProducto = new AlimentosDC.SIGEPAC.UI.LableBordeInferior();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.btnElegirProducto = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.epValidadorControles = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnElegirMarca = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblComentarioMarca = new AlimentosDC.SIGEPAC.UI.LableBordeInferior();
            this.lblNombreMarca = new AlimentosDC.SIGEPAC.UI.LableBordeInferior();
            this.lblUsuario = new AlimentosDC.SIGEPAC.UI.LableBordeInferior();
            this.txtNumeroCCF = new AlimentosDC.SIGEPAC.UI.TextBoxBorderInferior();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDetallesIngreso)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epValidadorControles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(432, 692);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 30);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvListadoDetallesIngreso
            // 
            this.dgvListadoDetallesIngreso.AllowUserToAddRows = false;
            this.dgvListadoDetallesIngreso.AllowUserToDeleteRows = false;
            this.dgvListadoDetallesIngreso.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvListadoDetallesIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoDetallesIngreso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvId,
            this.dgvCantidad,
            this.dgvProducto,
            this.dgvDescripcion,
            this.dgvPrecioUnitario,
            this.dgvSubTotal});
            this.dgvListadoDetallesIngreso.Location = new System.Drawing.Point(25, 406);
            this.dgvListadoDetallesIngreso.MultiSelect = false;
            this.dgvListadoDetallesIngreso.Name = "dgvListadoDetallesIngreso";
            this.dgvListadoDetallesIngreso.ReadOnly = true;
            this.dgvListadoDetallesIngreso.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListadoDetallesIngreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoDetallesIngreso.Size = new System.Drawing.Size(785, 233);
            this.dgvListadoDetallesIngreso.TabIndex = 63;
            this.dgvListadoDetallesIngreso.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvListadoDetallesIngreso_RowsAdded);
            this.dgvListadoDetallesIngreso.SelectionChanged += new System.EventHandler(this.dgvListadoDetallesIngreso_SelectionChanged);
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
            // btnGuardarIngreso
            // 
            this.btnGuardarIngreso.Enabled = false;
            this.btnGuardarIngreso.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarIngreso.Location = new System.Drawing.Point(550, 692);
            this.btnGuardarIngreso.Name = "btnGuardarIngreso";
            this.btnGuardarIngreso.Size = new System.Drawing.Size(140, 30);
            this.btnGuardarIngreso.TabIndex = 8;
            this.btnGuardarIngreso.Text = "Registrar compra";
            this.btnGuardarIngreso.UseVisualStyleBackColor = true;
            this.btnGuardarIngreso.Click += new System.EventHandler(this.btnGuardarCompra_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(708, 692);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 30);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cancelar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEliminarDetalleIngreso
            // 
            this.btnEliminarDetalleIngreso.Enabled = false;
            this.btnEliminarDetalleIngreso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDetalleIngreso.Location = new System.Drawing.Point(168, 654);
            this.btnEliminarDetalleIngreso.Name = "btnEliminarDetalleIngreso";
            this.btnEliminarDetalleIngreso.Size = new System.Drawing.Size(125, 30);
            this.btnEliminarDetalleIngreso.TabIndex = 7;
            this.btnEliminarDetalleIngreso.Text = "Eliminar detalle";
            this.btnEliminarDetalleIngreso.UseVisualStyleBackColor = true;
            this.btnEliminarDetalleIngreso.Click += new System.EventHandler(this.btnEliminarDetalleIngreso_Click);
            // 
            // btnEditarDetalleIngreso
            // 
            this.btnEditarDetalleIngreso.Enabled = false;
            this.btnEditarDetalleIngreso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarDetalleIngreso.Location = new System.Drawing.Point(25, 654);
            this.btnEditarDetalleIngreso.Name = "btnEditarDetalleIngreso";
            this.btnEditarDetalleIngreso.Size = new System.Drawing.Size(120, 30);
            this.btnEditarDetalleIngreso.TabIndex = 6;
            this.btnEditarDetalleIngreso.Text = "Editar detalle";
            this.btnEditarDetalleIngreso.UseVisualStyleBackColor = true;
            this.btnEditarDetalleIngreso.Click += new System.EventHandler(this.btnEditarDetalleIngreso_Click);
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(341, 64);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(100, 25);
            this.dtpFechaIngreso.TabIndex = 1;
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
            this.groupBox2.Controls.Add(this.lblSubTotal);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblStock);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblPrecioUnitario);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblDescripcion);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblNombreProducto);
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
            // lblSubTotal
            // 
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(435, 126);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(176, 19);
            this.lblSubTotal.TabIndex = 55;
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
            // lblStock
            // 
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(561, 34);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(205, 19);
            this.lblStock.TabIndex = 53;
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
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnitario.Location = new System.Drawing.Point(116, 75);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(205, 19);
            this.lblPrecioUnitario.TabIndex = 51;
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
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(447, 74);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(319, 20);
            this.lblDescripcion.TabIndex = 49;
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
            // lblNombreProducto
            // 
            this.lblNombreProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(230, 34);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(245, 19);
            this.lblNombreProducto.TabIndex = 7;
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
            this.nudCantidad.TabIndex = 4;
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.Enabled = false;
            this.btnAgregarDetalle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDetalle.Location = new System.Drawing.Point(636, 122);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(130, 30);
            this.btnAgregarDetalle.TabIndex = 5;
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
            this.btnElegirProducto.TabIndex = 3;
            this.btnElegirProducto.Text = "Elegir producto";
            this.btnElegirProducto.UseVisualStyleBackColor = true;
            this.btnElegirProducto.Click += new System.EventHandler(this.btnElegirProducto_Click);
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
            // epValidadorControles
            // 
            this.epValidadorControles.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comentario:";
            // 
            // btnElegirMarca
            // 
            this.btnElegirMarca.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElegirMarca.Location = new System.Drawing.Point(13, 25);
            this.btnElegirMarca.Name = "btnElegirMarca";
            this.btnElegirMarca.Size = new System.Drawing.Size(130, 30);
            this.btnElegirMarca.TabIndex = 2;
            this.btnElegirMarca.Text = "Elegir marca";
            this.btnElegirMarca.UseVisualStyleBackColor = true;
            this.btnElegirMarca.Click += new System.EventHandler(this.btnElegirMarca_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblComentarioMarca);
            this.groupBox1.Controls.Add(this.lblNombreMarca);
            this.groupBox1.Controls.Add(this.btnElegirMarca);
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
            // lblComentarioMarca
            // 
            this.lblComentarioMarca.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentarioMarca.Location = new System.Drawing.Point(476, 28);
            this.lblComentarioMarca.Name = "lblComentarioMarca";
            this.lblComentarioMarca.Size = new System.Drawing.Size(288, 20);
            this.lblComentarioMarca.TabIndex = 6;
            // 
            // lblNombreMarca
            // 
            this.lblNombreMarca.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMarca.Location = new System.Drawing.Point(221, 27);
            this.lblNombreMarca.Name = "lblNombreMarca";
            this.lblNombreMarca.Size = new System.Drawing.Size(150, 20);
            this.lblNombreMarca.TabIndex = 5;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(531, 67);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(276, 19);
            this.lblUsuario.TabIndex = 76;
            // 
            // txtNumeroCCF
            // 
            this.txtNumeroCCF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroCCF.ColorBorde = System.Drawing.Color.Black;
            this.txtNumeroCCF.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCCF.Location = new System.Drawing.Point(113, 68);
            this.txtNumeroCCF.MaxLength = 7;
            this.txtNumeroCCF.Name = "txtNumeroCCF";
            this.txtNumeroCCF.Size = new System.Drawing.Size(80, 19);
            this.txtNumeroCCF.TabIndex = 0;
            this.txtNumeroCCF.TextChanged += new System.EventHandler(this.txtNumeroCCF_TextChanged);
            // 
            // FrmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 745);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumeroCCF);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvListadoDetallesIngreso);
            this.Controls.Add(this.btnGuardarIngreso);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminarDetalleIngreso);
            this.Controls.Add(this.btnEditarDetalleIngreso);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmIngreso";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Mantenimiento Ingresos";
            this.Load += new System.EventHandler(this.FrmCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDetallesIngreso)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epValidadorControles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvListadoDetallesIngreso;
        private System.Windows.Forms.Button btnGuardarIngreso;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminarDetalleIngreso;
        private System.Windows.Forms.Button btnEditarDetalleIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Label label3;
        private TextBoxBorderInferior txtNumeroCCF;
        private System.Windows.Forms.Label label4;
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
        private LableBordeInferior lblSubTotal;
        private System.Windows.Forms.Label label9;
        private LableBordeInferior lblStock;
        private System.Windows.Forms.Label label10;
        private LableBordeInferior lblPrecioUnitario;
        private System.Windows.Forms.Label label7;
        private LableBordeInferior lblDescripcion;
        private System.Windows.Forms.Label label6;
        private LableBordeInferior lblNombreProducto;
        private LableBordeInferior lblUsuario;
        private System.Windows.Forms.ErrorProvider epValidadorControles;
        private System.Windows.Forms.GroupBox groupBox1;
        private LableBordeInferior lblComentarioMarca;
        private LableBordeInferior lblNombreMarca;
        private System.Windows.Forms.Button btnElegirMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}