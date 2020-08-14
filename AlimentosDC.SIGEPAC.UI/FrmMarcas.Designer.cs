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
            this.dgvIdMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombreMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvComentarioMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarMarcas = new AlimentosDC.SIGEPAC.UI.TextBoxWaterMark();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMarca.Location = new System.Drawing.Point(605, 61);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(100, 30);
            this.btnEliminarMarca.TabIndex = 30;
            this.btnEliminarMarca.Text = "Eliminar";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // btnEditarMarca
            // 
            this.btnEditarMarca.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarMarca.Location = new System.Drawing.Point(489, 62);
            this.btnEditarMarca.Name = "btnEditarMarca";
            this.btnEditarMarca.Size = new System.Drawing.Size(100, 30);
            this.btnEditarMarca.TabIndex = 29;
            this.btnEditarMarca.Text = "Editar";
            this.btnEditarMarca.UseVisualStyleBackColor = true;
            this.btnEditarMarca.Click += new System.EventHandler(this.btnEditarMarca_Click);
            // 
            // btnNuevaMarca
            // 
            this.btnNuevaMarca.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaMarca.Location = new System.Drawing.Point(371, 61);
            this.btnNuevaMarca.Name = "btnNuevaMarca";
            this.btnNuevaMarca.Size = new System.Drawing.Size(100, 30);
            this.btnNuevaMarca.TabIndex = 28;
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
            this.dgvListadoMarcas.Location = new System.Drawing.Point(10, 109);
            this.dgvListadoMarcas.MultiSelect = false;
            this.dgvListadoMarcas.Name = "dgvListadoMarcas";
            this.dgvListadoMarcas.ReadOnly = true;
            this.dgvListadoMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoMarcas.Size = new System.Drawing.Size(715, 275);
            this.dgvListadoMarcas.TabIndex = 25;
            this.dgvListadoMarcas.SelectionChanged += new System.EventHandler(this.dgvListadoMarcas_SelectionChanged);
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
            this.dgvNombreMarca.HeaderText = "Nombre";
            this.dgvNombreMarca.Name = "dgvNombreMarca";
            this.dgvNombreMarca.ReadOnly = true;
            this.dgvNombreMarca.Width = 210;
            // 
            // dgvComentarioMarca
            // 
            this.dgvComentarioMarca.HeaderText = "Comentario";
            this.dgvComentarioMarca.Name = "dgvComentarioMarca";
            this.dgvComentarioMarca.ReadOnly = true;
            this.dgvComentarioMarca.Width = 400;
            // 
            // txtBuscarMarcas
            // 
            this.txtBuscarMarcas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarMarcas.Location = new System.Drawing.Point(10, 61);
            this.txtBuscarMarcas.Name = "txtBuscarMarcas";
            this.txtBuscarMarcas.Size = new System.Drawing.Size(290, 27);
            this.txtBuscarMarcas.TabIndex = 31;
            this.txtBuscarMarcas.TextoMarcaAgua = "Buscar por nombre o comentario";
            this.txtBuscarMarcas.TextChanged += new System.EventHandler(this.textBoxWaterMark1_TextChanged);
            // 
            // FrmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 400);
            this.Controls.Add(this.txtBuscarMarcas);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.btnEditarMarca);
            this.Controls.Add(this.btnNuevaMarca);
            this.Controls.Add(this.dgvListadoMarcas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMarcas";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombreMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvComentarioMarca;
        private TextBoxWaterMark txtBuscarMarcas;
    }
}