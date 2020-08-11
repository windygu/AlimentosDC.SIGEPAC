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
            this.lblMarcaAguaMarca = new System.Windows.Forms.Label();
            this.txtBuscarMarca = new System.Windows.Forms.TextBox();
            this.dgvListadoMarcas = new System.Windows.Forms.DataGridView();
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
            // lblMarcaAguaMarca
            // 
            this.lblMarcaAguaMarca.AutoSize = true;
            this.lblMarcaAguaMarca.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaAguaMarca.ForeColor = System.Drawing.Color.Gray;
            this.lblMarcaAguaMarca.Location = new System.Drawing.Point(12, 66);
            this.lblMarcaAguaMarca.Name = "lblMarcaAguaMarca";
            this.lblMarcaAguaMarca.Size = new System.Drawing.Size(214, 19);
            this.lblMarcaAguaMarca.TabIndex = 27;
            this.lblMarcaAguaMarca.Text = "Buscar por nombre o comentario";
            // 
            // txtBuscarMarca
            // 
            this.txtBuscarMarca.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarMarca.Location = new System.Drawing.Point(10, 62);
            this.txtBuscarMarca.Name = "txtBuscarMarca";
            this.txtBuscarMarca.Size = new System.Drawing.Size(322, 27);
            this.txtBuscarMarca.TabIndex = 26;
            this.txtBuscarMarca.WordWrap = false;
            // 
            // dgvListadoMarcas
            // 
            this.dgvListadoMarcas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvListadoMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoMarcas.Location = new System.Drawing.Point(10, 109);
            this.dgvListadoMarcas.Name = "dgvListadoMarcas";
            this.dgvListadoMarcas.Size = new System.Drawing.Size(715, 275);
            this.dgvListadoMarcas.TabIndex = 25;
            // 
            // FrmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 400);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.btnEditarMarca);
            this.Controls.Add(this.btnNuevaMarca);
            this.Controls.Add(this.lblMarcaAguaMarca);
            this.Controls.Add(this.txtBuscarMarca);
            this.Controls.Add(this.dgvListadoMarcas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMarcas";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "MARCAS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnEditarMarca;
        private System.Windows.Forms.Button btnNuevaMarca;
        private System.Windows.Forms.Label lblMarcaAguaMarca;
        private System.Windows.Forms.TextBox txtBuscarMarca;
        private System.Windows.Forms.DataGridView dgvListadoMarcas;
    }
}