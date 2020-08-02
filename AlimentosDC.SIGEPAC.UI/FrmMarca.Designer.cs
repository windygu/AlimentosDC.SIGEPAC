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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarca));
            this.txtNombreMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComentarioMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuardarMarca = new System.Windows.Forms.Button();
            this.btnCancelarMarca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreMarca
            // 
            this.txtNombreMarca.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMarca.Location = new System.Drawing.Point(12, 95);
            this.txtNombreMarca.Name = "txtNombreMarca";
            this.txtNombreMarca.Size = new System.Drawing.Size(200, 25);
            this.txtNombreMarca.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre marca";
            // 
            // txtComentarioMarca
            // 
            this.txtComentarioMarca.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentarioMarca.Location = new System.Drawing.Point(232, 95);
            this.txtComentarioMarca.Multiline = true;
            this.txtComentarioMarca.Name = "txtComentarioMarca";
            this.txtComentarioMarca.Size = new System.Drawing.Size(200, 50);
            this.txtComentarioMarca.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Comentario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(130, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 37);
            this.label8.TabIndex = 27;
            this.label8.Text = "Nueva marca";
            // 
            // btnGuardarMarca
            // 
            this.btnGuardarMarca.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarMarca.Location = new System.Drawing.Point(209, 175);
            this.btnGuardarMarca.Name = "btnGuardarMarca";
            this.btnGuardarMarca.Size = new System.Drawing.Size(100, 30);
            this.btnGuardarMarca.TabIndex = 29;
            this.btnGuardarMarca.Text = "Registrar";
            this.btnGuardarMarca.UseVisualStyleBackColor = true;
            // 
            // btnCancelarMarca
            // 
            this.btnCancelarMarca.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarMarca.Location = new System.Drawing.Point(333, 175);
            this.btnCancelarMarca.Name = "btnCancelarMarca";
            this.btnCancelarMarca.Size = new System.Drawing.Size(100, 30);
            this.btnCancelarMarca.TabIndex = 30;
            this.btnCancelarMarca.Text = "Cancelar";
            this.btnCancelarMarca.UseVisualStyleBackColor = true;
            // 
            // FrmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 217);
            this.Controls.Add(this.btnCancelarMarca);
            this.Controls.Add(this.btnGuardarMarca);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtComentarioMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreMarca);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMarca";
            this.Text = "Mantenimiento Marcas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtComentarioMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGuardarMarca;
        private System.Windows.Forms.Button btnCancelarMarca;
    }
}