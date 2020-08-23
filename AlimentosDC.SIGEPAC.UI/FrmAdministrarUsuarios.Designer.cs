namespace AlimentosDC.SIGEPAC.UI
{
    partial class FrmAdministrarUsuarios
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
            this.txtBuscarUsuarios = new AlimentosDC.SIGEPAC.UI.TextBoxWaterMark();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmClave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatusAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmImagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.clmStatusAdmin,
            this.clmImagen});
            this.dgvListadoUsuarios.Location = new System.Drawing.Point(23, 122);
            this.dgvListadoUsuarios.MultiSelect = false;
            this.dgvListadoUsuarios.Name = "dgvListadoUsuarios";
            this.dgvListadoUsuarios.ReadOnly = true;
            this.dgvListadoUsuarios.Size = new System.Drawing.Size(782, 270);
            this.dgvListadoUsuarios.TabIndex = 0;
            // 
            // txtBuscarUsuarios
            // 
            this.txtBuscarUsuarios.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarUsuarios.Location = new System.Drawing.Point(23, 72);
            this.txtBuscarUsuarios.Name = "txtBuscarUsuarios";
            this.txtBuscarUsuarios.Size = new System.Drawing.Size(322, 27);
            this.txtBuscarUsuarios.TabIndex = 18;
            this.txtBuscarUsuarios.TextoMarcaAgua = "Buscar por nombre o apellido";
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
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarUsuario.Location = new System.Drawing.Point(516, 69);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(100, 30);
            this.btnEditarUsuario.TabIndex = 16;
            this.btnEditarUsuario.Text = "Editar";
            this.btnEditarUsuario.UseVisualStyleBackColor = true;
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
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(702, 411);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 30);
            this.btnCerrar.TabIndex = 19;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
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
            this.clmNombres.Width = 130;
            // 
            // clmApellidos
            // 
            this.clmApellidos.Frozen = true;
            this.clmApellidos.HeaderText = "APELLIDOS";
            this.clmApellidos.Name = "clmApellidos";
            this.clmApellidos.ReadOnly = true;
            this.clmApellidos.Width = 130;
            // 
            // clmNombreUsuario
            // 
            this.clmNombreUsuario.Frozen = true;
            this.clmNombreUsuario.HeaderText = "NOMBRE USUARIO";
            this.clmNombreUsuario.Name = "clmNombreUsuario";
            this.clmNombreUsuario.ReadOnly = true;
            // 
            // clmClave
            // 
            this.clmClave.Frozen = true;
            this.clmClave.HeaderText = "CLAVE";
            this.clmClave.Name = "clmClave";
            this.clmClave.ReadOnly = true;
            // 
            // clmStatusAdmin
            // 
            this.clmStatusAdmin.Frozen = true;
            this.clmStatusAdmin.HeaderText = "STATUS ADMIN";
            this.clmStatusAdmin.Name = "clmStatusAdmin";
            this.clmStatusAdmin.ReadOnly = true;
            // 
            // clmImagen
            // 
            this.clmImagen.Frozen = true;
            this.clmImagen.HeaderText = "BINARIOS IMAGEN";
            this.clmImagen.Name = "clmImagen";
            this.clmImagen.ReadOnly = true;
            this.clmImagen.Width = 130;
            // 
            // FrmAdministrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 455);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtBuscarUsuarios);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.btnNuevoUsuario);
            this.Controls.Add(this.dgvListadoUsuarios);
            this.Name = "FrmAdministrarUsuarios";
            this.Text = "Administrar Usuarios";
            this.Load += new System.EventHandler(this.FrmAdministrarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoUsuarios;
        private TextBoxWaterMark txtBuscarUsuarios;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClave;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatusAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmImagen;
        private System.Windows.Forms.Button btnCerrar;
    }
}