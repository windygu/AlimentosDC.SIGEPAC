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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerDetallesPedido));
            this.label8 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblNumeroPedido = new System.Windows.Forms.Label();
            this.lblSumas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblDuiCliente = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvListadoDetallesPedido = new System.Windows.Forms.DataGridView();
            this.dgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.lblEstadoPedido = new System.Windows.Forms.Label();
            this.lblDireccionEntrega = new System.Windows.Forms.Label();
            this.lblNumeroCCF = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDetallesPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 19);
            this.label8.TabIndex = 27;
            this.label8.Text = "No. Pedido:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(732, 595);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 30);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblNumeroPedido
            // 
            this.lblNumeroPedido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPedido.Location = new System.Drawing.Point(103, 70);
            this.lblNumeroPedido.Name = "lblNumeroPedido";
            this.lblNumeroPedido.Size = new System.Drawing.Size(90, 20);
            this.lblNumeroPedido.TabIndex = 29;
            this.lblNumeroPedido.Paint += new System.Windows.Forms.PaintEventHandler(this.lblNumeroPedido_Paint);
            // 
            // lblSumas
            // 
            this.lblSumas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumas.Location = new System.Drawing.Point(263, 533);
            this.lblSumas.Name = "lblSumas";
            this.lblSumas.Size = new System.Drawing.Size(85, 20);
            this.lblSumas.TabIndex = 34;
            this.lblSumas.Text = "0";
            this.lblSumas.Paint += new System.Windows.Forms.PaintEventHandler(this.lblNumeroPedido_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(208, 533);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Sumas:";
            // 
            // lblTotal
            // 
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(562, 533);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 20);
            this.lblTotal.TabIndex = 36;
            this.lblTotal.Text = "$ 0.00";
            this.lblTotal.Paint += new System.Windows.Forms.PaintEventHandler(this.lblNumeroPedido_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(517, 533);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(638, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 38;
            this.label5.Text = "F. Entrega:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(404, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "F. Creación:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(658, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 19);
            this.label7.TabIndex = 41;
            this.label7.Text = "Estado:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.lblDuiCliente);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 64);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // lblCliente
            // 
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(62, 28);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(289, 20);
            this.lblCliente.TabIndex = 46;
            this.lblCliente.Paint += new System.Windows.Forms.PaintEventHandler(this.lblNumeroPedido_Paint);
            // 
            // lblDuiCliente
            // 
            this.lblDuiCliente.Location = new System.Drawing.Point(434, 27);
            this.lblDuiCliente.Name = "lblDuiCliente";
            this.lblDuiCliente.Size = new System.Drawing.Size(150, 20);
            this.lblDuiCliente.TabIndex = 6;
            this.lblDuiCliente.Paint += new System.Windows.Forms.PaintEventHandler(this.lblNumeroPedido_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(392, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "DUI:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 19);
            this.label12.TabIndex = 1;
            this.label12.Text = "Sr. (a):";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 198);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 19);
            this.label14.TabIndex = 46;
            this.label14.Text = "Dirección de entrega:";
            // 
            // dgvListadoDetallesPedido
            // 
            this.dgvListadoDetallesPedido.AllowUserToAddRows = false;
            this.dgvListadoDetallesPedido.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvListadoDetallesPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoDetallesPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvId,
            this.dgvEstado,
            this.dgvProducto,
            this.dgvDescripcion,
            this.dgvCantidad,
            this.dgvPrecioUnitario,
            this.dgvSubTotal});
            this.dgvListadoDetallesPedido.Location = new System.Drawing.Point(22, 237);
            this.dgvListadoDetallesPedido.Name = "dgvListadoDetallesPedido";
            this.dgvListadoDetallesPedido.ReadOnly = true;
            this.dgvListadoDetallesPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoDetallesPedido.Size = new System.Drawing.Size(813, 281);
            this.dgvListadoDetallesPedido.TabIndex = 48;
            // 
            // dgvId
            // 
            this.dgvId.HeaderText = "ID";
            this.dgvId.Name = "dgvId";
            this.dgvId.ReadOnly = true;
            this.dgvId.Width = 50;
            // 
            // dgvEstado
            // 
            this.dgvEstado.HeaderText = "ESTADO";
            this.dgvEstado.Name = "dgvEstado";
            this.dgvEstado.ReadOnly = true;
            this.dgvEstado.Width = 120;
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
            this.dgvDescripcion.Width = 160;
            // 
            // dgvCantidad
            // 
            this.dgvCantidad.HeaderText = "CANTIDAD";
            this.dgvCantidad.Name = "dgvCantidad";
            this.dgvCantidad.ReadOnly = true;
            // 
            // dgvPrecioUnitario
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "$ #.##";
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
            this.dgvSubTotal.HeaderText = "SUB-TOTAL";
            this.dgvSubTotal.Name = "dgvSubTotal";
            this.dgvSubTotal.ReadOnly = true;
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEntrega.Location = new System.Drawing.Point(717, 68);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(118, 20);
            this.lblFechaEntrega.TabIndex = 49;
            this.lblFechaEntrega.Paint += new System.Windows.Forms.PaintEventHandler(this.lblNumeroPedido_Paint);
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCreacion.Location = new System.Drawing.Point(489, 68);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(118, 20);
            this.lblFechaCreacion.TabIndex = 50;
            this.lblFechaCreacion.Paint += new System.Windows.Forms.PaintEventHandler(this.lblNumeroPedido_Paint);
            // 
            // lblEstadoPedido
            // 
            this.lblEstadoPedido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoPedido.Location = new System.Drawing.Point(715, 138);
            this.lblEstadoPedido.Name = "lblEstadoPedido";
            this.lblEstadoPedido.Size = new System.Drawing.Size(120, 20);
            this.lblEstadoPedido.TabIndex = 51;
            this.lblEstadoPedido.Paint += new System.Windows.Forms.PaintEventHandler(this.lblNumeroPedido_Paint);
            // 
            // lblDireccionEntrega
            // 
            this.lblDireccionEntrega.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionEntrega.Location = new System.Drawing.Point(163, 198);
            this.lblDireccionEntrega.Name = "lblDireccionEntrega";
            this.lblDireccionEntrega.Size = new System.Drawing.Size(672, 20);
            this.lblDireccionEntrega.TabIndex = 52;
            this.lblDireccionEntrega.Paint += new System.Windows.Forms.PaintEventHandler(this.lblNumeroPedido_Paint);
            // 
            // lblNumeroCCF
            // 
            this.lblNumeroCCF.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCCF.Location = new System.Drawing.Point(281, 68);
            this.lblNumeroCCF.Name = "lblNumeroCCF";
            this.lblNumeroCCF.Size = new System.Drawing.Size(93, 20);
            this.lblNumeroCCF.TabIndex = 54;
            this.lblNumeroCCF.Paint += new System.Windows.Forms.PaintEventHandler(this.lblNumeroPedido_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(213, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 19);
            this.label10.TabIndex = 53;
            this.label10.Text = "No. CCF:";
            // 
            // lblIva
            // 
            this.lblIva.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.Location = new System.Drawing.Point(409, 533);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(85, 20);
            this.lblIva.TabIndex = 56;
            this.lblIva.Text = "0";
            this.lblIva.Paint += new System.Windows.Forms.PaintEventHandler(this.lblNumeroPedido_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 533);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 55;
            this.label3.Text = "IVA:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(74, 577);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(170, 20);
            this.lblUsuario.TabIndex = 58;
            this.lblUsuario.Paint += new System.Windows.Forms.PaintEventHandler(this.lblNumeroPedido_Paint);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(18, 577);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 19);
            this.label15.TabIndex = 57;
            this.label15.Text = "Usuario:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(350, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 20);
            this.label9.TabIndex = 54;
            this.label9.Paint += new System.Windows.Forms.PaintEventHandler(this.lblNumeroPedido_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "0";
            this.label1.Paint += new System.Windows.Forms.PaintEventHandler(this.lblNumeroPedido_Paint);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(74, 577);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(170, 20);
            this.label13.TabIndex = 58;
            this.label13.Paint += new System.Windows.Forms.PaintEventHandler(this.lblNumeroPedido_Paint);
            // 
            // FrmVerDetallesPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 640);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblIva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNumeroCCF);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblDireccionEntrega);
            this.Controls.Add(this.lblEstadoPedido);
            this.Controls.Add(this.lblFechaCreacion);
            this.Controls.Add(this.lblFechaEntrega);
            this.Controls.Add(this.dgvListadoDetallesPedido);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSumas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNumeroPedido);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmVerDetallesPedido";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "DETALLES PEDIDO";
            this.Load += new System.EventHandler(this.FrmVerDetallesPedido_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDetallesPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblNumeroPedido;
        private System.Windows.Forms.Label lblSumas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblDuiCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvListadoDetallesPedido;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.Label lblEstadoPedido;
        private System.Windows.Forms.Label lblDireccionEntrega;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubTotal;
        private System.Windows.Forms.Label lblNumeroCCF;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblUsuario;
    }
}