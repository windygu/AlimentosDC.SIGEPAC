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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedido));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDuiClientePedido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroPedido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDireccionEntregaPedido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.cmbEstadoPedido = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnNuevoDetallePedido = new System.Windows.Forms.Button();
            this.btnEditarDetallePedido = new System.Windows.Forms.Button();
            this.btnEliminarDetallePedido = new System.Windows.Forms.Button();
            this.btnGuardarPedido = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvListadoDetallesPedido = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnNuevoPedido = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDetallesPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "DUI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sr. (a):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtDuiClientePedido);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 64);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // txtDuiClientePedido
            // 
            this.txtDuiClientePedido.BackColor = System.Drawing.Color.White;
            this.txtDuiClientePedido.Location = new System.Drawing.Point(388, 25);
            this.txtDuiClientePedido.Name = "txtDuiClientePedido";
            this.txtDuiClientePedido.Size = new System.Drawing.Size(163, 23);
            this.txtDuiClientePedido.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "No. Pedido:";
            // 
            // txtNumeroPedido
            // 
            this.txtNumeroPedido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroPedido.Location = new System.Drawing.Point(90, 139);
            this.txtNumeroPedido.Name = "txtNumeroPedido";
            this.txtNumeroPedido.Size = new System.Drawing.Size(136, 25);
            this.txtNumeroPedido.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(245, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de creación:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha de entrega:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(265, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dirección de entrega:";
            // 
            // txtDireccionEntregaPedido
            // 
            this.txtDireccionEntregaPedido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionEntregaPedido.Location = new System.Drawing.Point(409, 187);
            this.txtDireccionEntregaPedido.Multiline = true;
            this.txtDireccionEntregaPedido.Name = "txtDireccionEntregaPedido";
            this.txtDireccionEntregaPedido.Size = new System.Drawing.Size(299, 50);
            this.txtDireccionEntregaPedido.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(510, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Estado:";
            // 
            // dtpFechaCreacion
            // 
            this.dtpFechaCreacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCreacion.Location = new System.Drawing.Point(380, 135);
            this.dtpFechaCreacion.Name = "dtpFechaCreacion";
            this.dtpFechaCreacion.Size = new System.Drawing.Size(100, 25);
            this.dtpFechaCreacion.TabIndex = 14;
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(132, 187);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(100, 25);
            this.dtpFechaEntrega.TabIndex = 15;
            // 
            // cmbEstadoPedido
            // 
            this.cmbEstadoPedido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoPedido.FormattingEnabled = true;
            this.cmbEstadoPedido.Items.AddRange(new object[] {
            "No iniciado",
            "Iniciado",
            "Revisado",
            "Enviado",
            "Finalizado"});
            this.cmbEstadoPedido.Location = new System.Drawing.Point(572, 135);
            this.cmbEstadoPedido.Name = "cmbEstadoPedido";
            this.cmbEstadoPedido.Size = new System.Drawing.Size(136, 25);
            this.cmbEstadoPedido.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 237);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 19);
            this.label13.TabIndex = 18;
            this.label13.Text = "Detalles del pedido:";
            // 
            // btnNuevoDetallePedido
            // 
            this.btnNuevoDetallePedido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoDetallePedido.Location = new System.Drawing.Point(669, 283);
            this.btnNuevoDetallePedido.Name = "btnNuevoDetallePedido";
            this.btnNuevoDetallePedido.Size = new System.Drawing.Size(100, 30);
            this.btnNuevoDetallePedido.TabIndex = 11;
            this.btnNuevoDetallePedido.Text = "Nuevo";
            this.btnNuevoDetallePedido.UseVisualStyleBackColor = true;
            this.btnNuevoDetallePedido.Click += new System.EventHandler(this.btnNuevoDetallePedido_Click);
            // 
            // btnEditarDetallePedido
            // 
            this.btnEditarDetallePedido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarDetallePedido.Location = new System.Drawing.Point(669, 340);
            this.btnEditarDetallePedido.Name = "btnEditarDetallePedido";
            this.btnEditarDetallePedido.Size = new System.Drawing.Size(100, 30);
            this.btnEditarDetallePedido.TabIndex = 19;
            this.btnEditarDetallePedido.Text = "Editar";
            this.btnEditarDetallePedido.UseVisualStyleBackColor = true;
            this.btnEditarDetallePedido.Click += new System.EventHandler(this.btnEditarDetallePedido_Click);
            // 
            // btnEliminarDetallePedido
            // 
            this.btnEliminarDetallePedido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDetallePedido.Location = new System.Drawing.Point(669, 398);
            this.btnEliminarDetallePedido.Name = "btnEliminarDetallePedido";
            this.btnEliminarDetallePedido.Size = new System.Drawing.Size(100, 30);
            this.btnEliminarDetallePedido.TabIndex = 20;
            this.btnEliminarDetallePedido.Text = "Eliminar";
            this.btnEliminarDetallePedido.UseVisualStyleBackColor = true;
            // 
            // btnGuardarPedido
            // 
            this.btnGuardarPedido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPedido.Location = new System.Drawing.Point(549, 474);
            this.btnGuardarPedido.Name = "btnGuardarPedido";
            this.btnGuardarPedido.Size = new System.Drawing.Size(100, 30);
            this.btnGuardarPedido.TabIndex = 25;
            this.btnGuardarPedido.Text = "Guardar";
            this.btnGuardarPedido.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(669, 474);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 30);
            this.btnCerrar.TabIndex = 24;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(241, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 37);
            this.label8.TabIndex = 26;
            this.label8.Text = "Nuevo pedido";
            // 
            // dgvListadoDetallesPedido
            // 
            this.dgvListadoDetallesPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoDetallesPedido.Location = new System.Drawing.Point(14, 267);
            this.dgvListadoDetallesPedido.Name = "dgvListadoDetallesPedido";
            this.dgvListadoDetallesPedido.Size = new System.Drawing.Size(635, 175);
            this.dgvListadoDetallesPedido.TabIndex = 27;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(78, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 25);
            this.comboBox1.TabIndex = 5;
            // 
            // btnNuevoPedido
            // 
            this.btnNuevoPedido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPedido.Location = new System.Drawing.Point(431, 474);
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Size = new System.Drawing.Size(100, 30);
            this.btnNuevoPedido.TabIndex = 28;
            this.btnNuevoPedido.Text = "Nuevo";
            this.btnNuevoPedido.UseVisualStyleBackColor = true;
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 516);
            this.Controls.Add(this.btnNuevoPedido);
            this.Controls.Add(this.dgvListadoDetallesPedido);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGuardarPedido);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminarDetallePedido);
            this.Controls.Add(this.btnEditarDetallePedido);
            this.Controls.Add(this.btnNuevoDetallePedido);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbEstadoPedido);
            this.Controls.Add(this.dtpFechaEntrega);
            this.Controls.Add(this.dtpFechaCreacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDireccionEntregaPedido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumeroPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Pedidos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDetallesPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDuiClientePedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumeroPedido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDireccionEntregaPedido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaCreacion;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.ComboBox cmbEstadoPedido;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnNuevoDetallePedido;
        private System.Windows.Forms.Button btnEditarDetallePedido;
        private System.Windows.Forms.Button btnEliminarDetallePedido;
        private System.Windows.Forms.Button btnGuardarPedido;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvListadoDetallesPedido;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnNuevoPedido;
    }
}