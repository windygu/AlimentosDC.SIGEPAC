namespace AlimentosDC.SIGEPAC.UI
{
    partial class FrmMarcas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarcas));
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnEditarMarca = new System.Windows.Forms.Button();
            this.btnNuevaMarca = new System.Windows.Forms.Button();
            this.dgvListadoMarcas = new System.Windows.Forms.DataGridView();
            this.txtBuscarMarcas = new AlimentosDC.SIGEPAC.UI.TextBoxWaterMark();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dgvIdMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombreMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvComentarioMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Enabled = false;
            this.btnEliminarMarca.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMarca.Location = new System.Drawing.Point(620, 61);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(100, 30);
            this.btnEliminarMarca.TabIndex = 3;
            this.btnEliminarMarca.Text = "Eliminar";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // btnEditarMarca
            // 
            this.btnEditarMarca.Enabled = false;
            this.btnEditarMarca.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarMarca.Location = new System.Drawing.Point(502, 61);
            this.btnEditarMarca.Name = "btnEditarMarca";
            this.btnEditarMarca.Size = new System.Drawing.Size(100, 30);
            this.btnEditarMarca.TabIndex = 2;
            this.btnEditarMarca.Text = "Editar";
            this.btnEditarMarca.UseVisualStyleBackColor = true;
            this.btnEditarMarca.Click += new System.EventHandler(this.btnEditarMarca_Click);
            // 
            // btnNuevaMarca
            // 
            this.btnNuevaMarca.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaMarca.Location = new System.Drawing.Point(384, 61);
            this.btnNuevaMarca.Name = "btnNuevaMarca";
            this.btnNuevaMarca.Size = new System.Drawing.Size(100, 30);
            this.btnNuevaMarca.TabIndex = 1;
            this.btnNuevaMarca.Text = "Nuevo";
            this.btnNuevaMarca.UseVisualStyleBackColor = true;
            this.btnNuevaMarca.Click += new System.EventHandler(this.btnNuevaMarca_Click);
            // 
            // dgvListadoMarcas
            // 
            this.dgvListadoMarcas.AllowUserToAddRows = false;
            this.dgvListadoMarcas.AllowUserToDeleteRows = false;
            this.dgvListadoMarcas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvListadoMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIdMarca,
            this.dgvNombreMarca,
            this.dgvComentarioMarca});
            this.dgvListadoMarcas.Location = new System.Drawing.Point(26, 105);
            this.dgvListadoMarcas.MultiSelect = false;
            this.dgvListadoMarcas.Name = "dgvListadoMarcas";
            this.dgvListadoMarcas.ReadOnly = true;
            this.dgvListadoMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoMarcas.Size = new System.Drawing.Size(716, 298);
            this.dgvListadoMarcas.TabIndex = 25;
            this.dgvListadoMarcas.SelectionChanged += new System.EventHandler(this.dgvListadoMarcas_SelectionChanged);
            // 
            // txtBuscarMarcas
            // 
            this.txtBuscarMarcas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarMarcas.Location = new System.Drawing.Point(26, 63);
            this.txtBuscarMarcas.Name = "txtBuscarMarcas";
            this.txtBuscarMarcas.Size = new System.Drawing.Size(340, 27);
            this.txtBuscarMarcas.TabIndex = 0;
            this.txtBuscarMarcas.TextoMarcaAgua = "Buscar por nombre o comentario";
            this.txtBuscarMarcas.TextChanged += new System.EventHandler(this.textBoxWaterMark1_TextChanged);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(642, 413);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 30);
            this.btnCerrar.TabIndex = 26;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(524, 413);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 30);
            this.btnSalir.TabIndex = 27;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(524, 413);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(100, 30);
            this.btnSeleccionar.TabIndex = 28;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Visible = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // dgvIdMarca
            // 
            this.dgvIdMarca.HeaderText = "ID";
            this.dgvIdMarca.Name = "dgvIdMarca";
            this.dgvIdMarca.ReadOnly = true;
            this.dgvIdMarca.Width = 60;
            // 
            // dgvNombreMarca
            // 
            this.dgvNombreMarca.HeaderText = "NOMBRE";
            this.dgvNombreMarca.Name = "dgvNombreMarca";
            this.dgvNombreMarca.ReadOnly = true;
            this.dgvNombreMarca.Width = 210;
            // 
            // dgvComentarioMarca
            // 
            this.dgvComentarioMarca.HeaderText = "COMENTARIO";
            this.dgvComentarioMarca.Name = "dgvComentarioMarca";
            this.dgvComentarioMarca.ReadOnly = true;
            this.dgvComentarioMarca.Width = 385;
            // 
            // FrmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 458);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtBuscarMarcas);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.btnEditarMarca);
            this.Controls.Add(this.btnNuevaMarca);
            this.Controls.Add(this.dgvListadoMarcas);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMarcas";
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "MARCAS";
            this.Load += new System.EventHandler(this.FrmMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnEditarMarca;
        private System.Windows.Forms.Button btnNuevaMarca;
        private System.Windows.Forms.DataGridView dgvListadoMarcas;
        private TextBoxWaterMark txtBuscarMarcas;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombreMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvComentarioMarca;
    }
}