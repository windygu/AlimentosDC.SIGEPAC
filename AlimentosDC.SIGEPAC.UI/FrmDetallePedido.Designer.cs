﻿namespace AlimentosDC.SIGEPAC.UI
{
    partial class FrmDetallePedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetallePedido));
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCerrarDetallePedido = new System.Windows.Forms.Button();
            this.btnAgregarDetallePedido = new System.Windows.Forms.Button();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExistencias = new System.Windows.Forms.Label();
            this.cmbEstadoDetallePedido = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 19);
            this.label12.TabIndex = 20;
            this.label12.Text = "SubTotal:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(263, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 19);
            this.label11.TabIndex = 18;
            this.label11.Text = "Precio unitario:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.White;
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(16, 173);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(210, 25);
            this.txtCantidad.TabIndex = 17;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "Cantidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Producto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "Descripción:";
            // 
            // btnCerrarDetallePedido
            // 
            this.btnCerrarDetallePedido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarDetallePedido.Location = new System.Drawing.Point(375, 280);
            this.btnCerrarDetallePedido.Name = "btnCerrarDetallePedido";
            this.btnCerrarDetallePedido.Size = new System.Drawing.Size(100, 30);
            this.btnCerrarDetallePedido.TabIndex = 22;
            this.btnCerrarDetallePedido.Text = "Cerrar";
            this.btnCerrarDetallePedido.UseVisualStyleBackColor = true;
            this.btnCerrarDetallePedido.Click += new System.EventHandler(this.btnCerrarDetallePedido_Click);
            // 
            // btnAgregarDetallePedido
            // 
            this.btnAgregarDetallePedido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDetallePedido.Location = new System.Drawing.Point(263, 280);
            this.btnAgregarDetallePedido.Name = "btnAgregarDetallePedido";
            this.btnAgregarDetallePedido.Size = new System.Drawing.Size(100, 30);
            this.btnAgregarDetallePedido.TabIndex = 23;
            this.btnAgregarDetallePedido.Text = "Agregar";
            this.btnAgregarDetallePedido.UseVisualStyleBackColor = true;
            this.btnAgregarDetallePedido.Click += new System.EventHandler(this.btnAgregarDetallePedido_Click);
            // 
            // cmbProducto
            // 
            this.cmbProducto.DisplayMember = "Nombre";
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(16, 43);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(210, 25);
            this.cmbProducto.TabIndex = 25;
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectionChangeCommitted);
            this.cmbProducto.SelectionChangeCommitted += new System.EventHandler(this.cmbProducto_SelectionChangeCommitted);
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnitario.Location = new System.Drawing.Point(265, 44);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(210, 25);
            this.lblPrecioUnitario.TabIndex = 28;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(16, 107);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(210, 25);
            this.lblDescripcion.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Existencias:";
            // 
            // lblExistencias
            // 
            this.lblExistencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExistencias.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistencias.Location = new System.Drawing.Point(263, 107);
            this.lblExistencias.Name = "lblExistencias";
            this.lblExistencias.Size = new System.Drawing.Size(210, 25);
            this.lblExistencias.TabIndex = 31;
            // 
            // cmbEstadoDetallePedido
            // 
            this.cmbEstadoDetallePedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoDetallePedido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoDetallePedido.FormattingEnabled = true;
            this.cmbEstadoDetallePedido.Items.AddRange(new object[] {
            "No iniciado",
            "Iniciado",
            "Revisado",
            "Enviado",
            "Finalizado"});
            this.cmbEstadoDetallePedido.Location = new System.Drawing.Point(263, 173);
            this.cmbEstadoDetallePedido.Name = "cmbEstadoDetallePedido";
            this.cmbEstadoDetallePedido.Size = new System.Drawing.Size(210, 25);
            this.cmbEstadoDetallePedido.TabIndex = 33;
            this.cmbEstadoDetallePedido.SelectedIndexChanged += new System.EventHandler(this.cmbEstadoDetallePedido_SelectionChangeCommitted);
            this.cmbEstadoDetallePedido.SelectionChangeCommitted += new System.EventHandler(this.cmbEstadoDetallePedido_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(263, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = "Estado:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblSubTotal);
            this.panel1.Location = new System.Drawing.Point(79, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(91, 23);
            this.panel1.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 24);
            this.label2.TabIndex = 38;
            this.label2.Text = "$";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(20, -2);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(41, 24);
            this.lblSubTotal.TabIndex = 37;
            this.lblSubTotal.Text = "0.00";
            // 
            // FrmDetallePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 326);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbEstadoDetallePedido);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblExistencias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblPrecioUnitario);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.btnAgregarDetallePedido);
            this.Controls.Add(this.btnCerrarDetallePedido);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmDetallePedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Detalles Pedido";
            this.Load += new System.EventHandler(this.FrmDetallePedido_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCerrarDetallePedido;
        private System.Windows.Forms.Button btnAgregarDetallePedido;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExistencias;
        private System.Windows.Forms.ComboBox cmbEstadoDetallePedido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSubTotal;
    }
}