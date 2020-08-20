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
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdPedido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDireccionEntregaPedido = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblDuiCliente = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvListadoDetallesPedido = new System.Windows.Forms.DataGridView();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.lblEstadoPedido = new System.Windows.Forms.Label();
            this.lblDireccionEntrega = new System.Windows.Forms.Label();
            this.dgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDetallesPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(254, 71);
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
            this.btnCerrar.TabIndex = 28;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblNumeroPedido
            // 
            this.lblNumeroPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumeroPedido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPedido.Location = new System.Drawing.Point(337, 69);
            this.lblNumeroPedido.Name = "lblNumeroPedido";
            this.lblNumeroPedido.Size = new System.Drawing.Size(85, 20);
            this.lblNumeroPedido.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Detalles del pedido:";
            // 
            // lblIdPedido
            // 
            this.lblIdPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIdPedido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPedido.Location = new System.Drawing.Point(92, 70);
            this.lblIdPedido.Name = "lblIdPedido";
            this.lblIdPedido.Size = new System.Drawing.Size(85, 20);
            this.lblIdPedido.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "ID Pedido:";
            // 
            // lblProductos
            // 
            this.lblProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(132, 556);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(85, 20);
            this.lblProductos.TabIndex = 34;
            this.lblProductos.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 557);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Suma Productos:";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(316, 556);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 20);
            this.lblTotal.TabIndex = 36;
            this.lblTotal.Text = "$ 0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(278, 558);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 38;
            this.label5.Text = "Fecha de entrega:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(508, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Fecha de creación:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(575, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 19);
            this.label7.TabIndex = 41;
            this.label7.Text = "Estado:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDireccionEntregaPedido);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.lblDuiCliente);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 64);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // txtDireccionEntregaPedido
            // 
            this.txtDireccionEntregaPedido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionEntregaPedido.Location = new System.Drawing.Point(583, 16);
            this.txtDireccionEntregaPedido.Multiline = true;
            this.txtDireccionEntregaPedido.Name = "txtDireccionEntregaPedido";
            this.txtDireccionEntregaPedido.Size = new System.Drawing.Size(240, 50);
            this.txtDireccionEntregaPedido.TabIndex = 47;
            // 
            // lblCliente
            // 
            this.lblCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(68, 28);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(215, 20);
            this.lblCliente.TabIndex = 46;
            // 
            // lblDuiCliente
            // 
            this.lblDuiCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDuiCliente.Location = new System.Drawing.Point(355, 25);
            this.lblDuiCliente.Name = "lblDuiCliente";
            this.lblDuiCliente.Size = new System.Drawing.Size(150, 25);
            this.lblDuiCliente.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(314, 28);
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
            this.label14.Location = new System.Drawing.Point(276, 208);
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
            this.dgvProducto,
            this.dgvDescripcion,
            this.dgvCantidad,
            this.dgvPrecioUnitario,
            this.dgvSubTotal,
            this.dgvEstado});
            this.dgvListadoDetallesPedido.Location = new System.Drawing.Point(23, 288);
            this.dgvListadoDetallesPedido.Name = "dgvListadoDetallesPedido";
            this.dgvListadoDetallesPedido.ReadOnly = true;
            this.dgvListadoDetallesPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoDetallesPedido.Size = new System.Drawing.Size(813, 263);
            this.dgvListadoDetallesPedido.TabIndex = 48;
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFechaEntrega.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEntrega.Location = new System.Drawing.Point(145, 209);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(100, 20);
            this.lblFechaEntrega.TabIndex = 49;
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFechaCreacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCreacion.Location = new System.Drawing.Point(634, 67);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(100, 20);
            this.lblFechaCreacion.TabIndex = 50;
            // 
            // lblEstadoPedido
            // 
            this.lblEstadoPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEstadoPedido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoPedido.Location = new System.Drawing.Point(634, 140);
            this.lblEstadoPedido.Name = "lblEstadoPedido";
            this.lblEstadoPedido.Size = new System.Drawing.Size(100, 20);
            this.lblEstadoPedido.TabIndex = 51;
            // 
            // lblDireccionEntrega
            // 
            this.lblDireccionEntrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDireccionEntrega.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionEntrega.Location = new System.Drawing.Point(420, 209);
            this.lblDireccionEntrega.Name = "lblDireccionEntrega";
            this.lblDireccionEntrega.Size = new System.Drawing.Size(314, 50);
            this.lblDireccionEntrega.TabIndex = 52;
            // 
            // dgvId
            // 
            this.dgvId.HeaderText = "ID";
            this.dgvId.Name = "dgvId";
            this.dgvId.ReadOnly = true;
            this.dgvId.Width = 50;
            // 
            // dgvProducto
            // 
            this.dgvProducto.HeaderText = "Producto";
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            this.dgvProducto.Width = 140;
            // 
            // dgvDescripcion
            // 
            this.dgvDescripcion.HeaderText = "Descripción";
            this.dgvDescripcion.Name = "dgvDescripcion";
            this.dgvDescripcion.ReadOnly = true;
            this.dgvDescripcion.Width = 160;
            // 
            // dgvCantidad
            // 
            this.dgvCantidad.HeaderText = "Cantidad";
            this.dgvCantidad.Name = "dgvCantidad";
            this.dgvCantidad.ReadOnly = true;
            // 
            // dgvPrecioUnitario
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "$ #.##";
            dataGridViewCellStyle1.NullValue = null;
            this.dgvPrecioUnitario.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrecioUnitario.HeaderText = "Precio Unitario";
            this.dgvPrecioUnitario.Name = "dgvPrecioUnitario";
            this.dgvPrecioUnitario.ReadOnly = true;
            // 
            // dgvSubTotal
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.dgvSubTotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSubTotal.HeaderText = "Sub Total";
            this.dgvSubTotal.Name = "dgvSubTotal";
            this.dgvSubTotal.ReadOnly = true;
            // 
            // dgvEstado
            // 
            this.dgvEstado.HeaderText = "Estado";
            this.dgvEstado.Name = "dgvEstado";
            this.dgvEstado.ReadOnly = true;
            this.dgvEstado.Width = 120;
            // 
            // FrmVerDetallesPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 640);
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
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblIdPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProductos;
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
        private System.Windows.Forms.TextBox txtDireccionEntregaPedido;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvListadoDetallesPedido;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.Label lblEstadoPedido;
        private System.Windows.Forms.Label lblDireccionEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEstado;
    }
}