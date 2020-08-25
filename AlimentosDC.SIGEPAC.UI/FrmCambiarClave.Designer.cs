namespace AlimentosDC.SIGEPAC.UI
{
    partial class FrmCambiarClave
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnActualizarClave = new System.Windows.Forms.Button();
            this.epComprobadorClave = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtNuevaClave = new AlimentosDC.SIGEPAC.UI.TextBoxBorderInferior();
            this.txtClaveActual = new AlimentosDC.SIGEPAC.UI.TextBoxBorderInferior();
            ((System.ComponentModel.ISupportInitialize)(this.epComprobadorClave)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clave actual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nueva clave:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(347, 212);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 30);
            this.btnCerrar.TabIndex = 16;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnActualizarClave
            // 
            this.btnActualizarClave.Enabled = false;
            this.btnActualizarClave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarClave.Location = new System.Drawing.Point(186, 212);
            this.btnActualizarClave.Name = "btnActualizarClave";
            this.btnActualizarClave.Size = new System.Drawing.Size(128, 30);
            this.btnActualizarClave.TabIndex = 17;
            this.btnActualizarClave.Text = "Actualizar clave";
            this.btnActualizarClave.UseVisualStyleBackColor = true;
            this.btnActualizarClave.Click += new System.EventHandler(this.btnActualizarClave_Click);
            // 
            // epComprobadorClave
            // 
            this.epComprobadorClave.ContainerControl = this;
            // 
            // txtNuevaClave
            // 
            this.txtNuevaClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNuevaClave.ColorBorde = System.Drawing.Color.Black;
            this.txtNuevaClave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaClave.Location = new System.Drawing.Point(124, 147);
            this.txtNuevaClave.MaxLength = 20;
            this.txtNuevaClave.Name = "txtNuevaClave";
            this.txtNuevaClave.PasswordChar = '●';
            this.txtNuevaClave.Size = new System.Drawing.Size(270, 20);
            this.txtNuevaClave.TabIndex = 2;
            this.txtNuevaClave.TextChanged += new System.EventHandler(this.txtNuevaClave_TextChanged);
            // 
            // txtClaveActual
            // 
            this.txtClaveActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClaveActual.ColorBorde = System.Drawing.Color.Black;
            this.txtClaveActual.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveActual.Location = new System.Drawing.Point(124, 99);
            this.txtClaveActual.MaxLength = 20;
            this.txtClaveActual.Name = "txtClaveActual";
            this.txtClaveActual.PasswordChar = '●';
            this.txtClaveActual.Size = new System.Drawing.Size(270, 20);
            this.txtClaveActual.TabIndex = 0;
            this.txtClaveActual.TextChanged += new System.EventHandler(this.txtClaveActual_TextChanged);
            // 
            // FrmCambiarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 265);
            this.Controls.Add(this.btnActualizarClave);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNuevaClave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClaveActual);
            this.MaximizeBox = false;
            this.Name = "FrmCambiarClave";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Cambiar clave";
            ((System.ComponentModel.ISupportInitialize)(this.epComprobadorClave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBoxBorderInferior txtClaveActual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private TextBoxBorderInferior txtNuevaClave;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnActualizarClave;
        private System.Windows.Forms.ErrorProvider epComprobadorClave;
    }
}