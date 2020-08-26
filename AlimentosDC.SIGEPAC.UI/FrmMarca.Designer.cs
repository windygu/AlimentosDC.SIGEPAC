namespace AlimentosDC.SIGEPAC.UI
{
    partial class FrmMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarca));
            this.txtNombreMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComentarioMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardarMarca = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.epValidarControles = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epValidarControles)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreMarca
            // 
            this.txtNombreMarca.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMarca.Location = new System.Drawing.Point(13, 94);
            this.txtNombreMarca.MaxLength = 75;
            this.txtNombreMarca.Name = "txtNombreMarca";
            this.txtNombreMarca.Size = new System.Drawing.Size(200, 25);
            this.txtNombreMarca.TabIndex = 6;
            this.txtNombreMarca.TextChanged += new System.EventHandler(this.txtNombreMarca_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre marca";
            // 
            // txtComentarioMarca
            // 
            this.txtComentarioMarca.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentarioMarca.Location = new System.Drawing.Point(233, 94);
            this.txtComentarioMarca.MaxLength = 500;
            this.txtComentarioMarca.Multiline = true;
            this.txtComentarioMarca.Name = "txtComentarioMarca";
            this.txtComentarioMarca.Size = new System.Drawing.Size(200, 50);
            this.txtComentarioMarca.TabIndex = 8;
            this.txtComentarioMarca.TextChanged += new System.EventHandler(this.txtComentarioMarca_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Comentario";
            // 
            // btnGuardarMarca
            // 
            this.btnGuardarMarca.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarMarca.Location = new System.Drawing.Point(219, 174);
            this.btnGuardarMarca.Name = "btnGuardarMarca";
            this.btnGuardarMarca.Size = new System.Drawing.Size(100, 30);
            this.btnGuardarMarca.TabIndex = 29;
            this.btnGuardarMarca.Text = "Guardar";
            this.btnGuardarMarca.UseVisualStyleBackColor = true;
            this.btnGuardarMarca.Click += new System.EventHandler(this.btnGuardarMarca_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(334, 174);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 30);
            this.btnCerrar.TabIndex = 30;
            this.btnCerrar.Text = "Cancelar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // epValidarControles
            // 
            this.epValidarControles.ContainerControl = this;
            // 
            // FrmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 217);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardarMarca);
            this.Controls.Add(this.txtComentarioMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreMarca);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMarca";
            this.Resizable = false;
            this.RightToLeftLayout = true;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Mantenimiento Marcas";
            ((System.ComponentModel.ISupportInitialize)(this.epValidarControles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtComentarioMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarMarca;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ErrorProvider epValidarControles;
    }
}