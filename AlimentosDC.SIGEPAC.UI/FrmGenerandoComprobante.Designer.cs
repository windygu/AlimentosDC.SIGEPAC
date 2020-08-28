namespace AlimentosDC.SIGEPAC.UI
{
    partial class FrmCargando
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
            this.pbGenerando = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // pbGenerando
            // 
            this.pbGenerando.Location = new System.Drawing.Point(23, 81);
            this.pbGenerando.Name = "pbGenerando";
            this.pbGenerando.Size = new System.Drawing.Size(514, 20);
            this.pbGenerando.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbGenerando.TabIndex = 0;
            // 
            // FrmCargando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 125);
            this.Controls.Add(this.pbGenerando);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCargando";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Preparando Comprobante";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbGenerando;
    }
}