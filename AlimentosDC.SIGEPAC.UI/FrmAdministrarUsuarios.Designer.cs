namespace AlimentosDC.SIGEPAC.UI
{
    partial class FrmUsuarios
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
            this.dgvListadoUsuarios = new System.Windows.Forms.DataGridView();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtBuscadorUsuarios = new AlimentosDC.SIGEPAC.UI.TextBoxWaterMark();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmClave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatusAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoUsuarios
            // 
            this.dgvListadoUsuarios.AllowUserToAddRows = false;
            this.dgvListadoUsuarios.AllowUserToDeleteRows = false;
            this.dgvListadoUsuarios.AllowUserToResizeRows = false;
            this.dgvListadoUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvListadoUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmNombres,
            this.clmApellidos,
            this.clmNombreUsuario,
            this.clmClave,
            this.clmStatusAdmin});
            this.dgvListadoUsuarios.Location = new System.Drawing.Point(23, 122);
            this.dgvListadoUsuarios.MultiSelect = false;
            this.dgvListadoUsuarios.Name = "dgvListadoUsuarios";
            this.dgvListadoUsuarios.ReadOnly = true;
            this.dgvListadoUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoUsuarios.Size = new System.Drawing.Size(771, 270);
            this.dgvListadoUsuarios.TabIndex = 0;
            this.dgvListadoUsuarios.SelectionChanged += new System.EventHandler(this.dgvListadoUsuarios_SelectionChanged);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.Location = new System.Drawing.Point(655, 69);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(100, 30);
            this.btnEliminarUsuario.TabIndex = 17;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.Enabled = false;
            this.btnEditarUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarUsuario.Location = new System.Drawing.Point(516, 69);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(100, 30);
            this.btnEditarUsuario.TabIndex = 16;
            this.btnEditarUsuario.Text = "Editar";
            this.btnEditarUsuario.UseVisualStyleBackColor = true;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoUsuario.Location = new System.Drawing.Point(380, 70);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(100, 30);
            this.btnNuevoUsuario.TabIndex = 15;
            this.btnNuevoUsuario.Text = "Nuevo";
            this.btnNuevoUsuario.UseVisualStyleBackColor = true;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(695, 410);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 30);
            this.btnCerrar.TabIndex = 19;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtBuscadorUsuarios
            // 
            this.txtBuscadorUsuarios.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscadorUsuarios.Location = new System.Drawing.Point(23, 72);
            this.txtBuscadorUsuarios.Name = "txtBuscadorUsuarios";
            this.txtBuscadorUsuarios.Size = new System.Drawing.Size(322, 27);
            this.txtBuscadorUsuarios.TabIndex = 18;
            this.txtBuscadorUsuarios.TextoMarcaAgua = "Buscar por nombre o nombre de usuario";
            this.txtBuscadorUsuarios.TextChanged += new System.EventHandler(this.txtBuscadorUsuarios_TextChanged);
            // 
            // clmId
            // 
            this.clmId.Frozen = true;
            this.clmId.HeaderText = "ID";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            this.clmId.Width = 50;
            // 
            // clmNombres
            // 
            this.clmNombres.Frozen = true;
            this.clmNombres.HeaderText = "NOMBRES";
            this.clmNombres.Name = "clmNombres";
            this.clmNombres.ReadOnly = true;
            this.clmNombres.Width = 160;
            // 
            // clmApellidos
            // 
            this.clmApellidos.Frozen = true;
            this.clmApellidos.HeaderText = "APELLIDOS";
            this.clmApellidos.Name = "clmApellidos";
            this.clmApellidos.ReadOnly = true;
            this.clmApellidos.Width = 160;
            // 
            // clmNombreUsuario
            // 
            this.clmNombreUsuario.Frozen = true;
            this.clmNombreUsuario.HeaderText = "NOMBRE USUARIO";
            this.clmNombreUsuario.Name = "clmNombreUsuario";
            this.clmNombreUsuario.ReadOnly = true;
            this.clmNombreUsuario.Width = 140;
            // 
            // clmClave
            // 
            this.clmClave.Frozen = true;
            this.clmClave.HeaderText = "CLAVE";
            this.clmClave.Name = "clmClave";
            this.clmClave.ReadOnly = true;
            this.clmClave.Width = 120;
            // 
            // clmStatusAdmin
            // 
            this.clmStatusAdmin.Frozen = true;
            this.clmStatusAdmin.HeaderText = "STATUS ADMIN";
            this.clmStatusAdmin.Name = "clmStatusAdmin";
            this.clmStatusAdmin.ReadOnly = true;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 458);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtBuscadorUsuarios);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.btnNuevoUsuario);
            this.Controls.Add(this.dgvListadoUsuarios);
            this.Name = "FrmUsuarios";
            this.Text = "Administrar Usuarios";
            this.Load += new System.EventHandler(this.FrmAdministrarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoUsuarios;
        private TextBoxWaterMark txtBuscadorUsuarios;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClave;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatusAdmin;
    }
}