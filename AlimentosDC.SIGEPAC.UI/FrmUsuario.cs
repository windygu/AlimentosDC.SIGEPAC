using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using AlimentosDC.SIGEPAC.BL;
using AlimentosDC.SIGEPAC.EN;
using System.Data.SqlClient;

namespace AlimentosDC.SIGEPAC.UI
{
    public partial class FrmUsuario : MetroForm
    {
        int? idUsuarioAEditar = null;
        FrmUsuarios objetoActualUsuarios;
        Usuario usuarioAEditar;
        public FrmUsuario(ref FrmUsuarios objetoActualUsuarios)
        {
            InitializeComponent();
            this.objetoActualUsuarios = objetoActualUsuarios;
        }
        public FrmUsuario(ref FrmUsuarios objetoActualUsuarios, int idUsuarioAEditar)
        {
            InitializeComponent();
            this.objetoActualUsuarios = objetoActualUsuarios;
            this.idUsuarioAEditar = idUsuarioAEditar;
            usuarioAEditar = UsuarioBL.BuscarPorId(idUsuarioAEditar);
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            txtNombres.Focus();
            if (idUsuarioAEditar!=null)
            {
                CargarDatosAlFormulario();
                btnGuardar.Text = "Actualizar";
            }
        }

        void CargarDatosAlFormulario()
        { 
            txtNombres.Text = usuarioAEditar.Nombres;
            txtApellidos.Text = usuarioAEditar.Apellidos;
            txtNombreUsuario.Text = usuarioAEditar.NombreUsuario;
            txtClave.Text = usuarioAEditar.Clave;
            chkAdministrador.Checked = usuarioAEditar.StatusAdmin;
        }

        void Guardar()
        {
            int resultRegistrados = 0, resultModificados = 0;
            if (idUsuarioAEditar==null)
            {
                Usuario usuarioARegistrar = new Usuario();
                usuarioARegistrar.Nombres = txtNombres.Text.Trim();
                usuarioARegistrar.Apellidos = txtApellidos.Text.Trim();
                usuarioARegistrar.NombreUsuario = txtNombreUsuario.Text.Trim();
                usuarioARegistrar.Clave = txtClave.Text.Trim();
                usuarioARegistrar.StatusAdmin = chkAdministrador.Checked;
                usuarioARegistrar.Imagen = null;
                resultRegistrados += UsuarioBL.Guardar(usuarioARegistrar);
                objetoActualUsuarios.CargarUsuarios();
                if (resultRegistrados > 0)
                {
                    MetroMessageBox.Show(this, "Usuario registrado exitosamente.", "Registro de usuarios",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else MetroMessageBox.Show(this, "El usuario no se registró.", "Registro de usuarios",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                usuarioAEditar.Nombres = txtNombres.Text.Trim();
                usuarioAEditar.Apellidos = txtApellidos.Text.Trim();
                usuarioAEditar.NombreUsuario = txtNombreUsuario.Text.Trim();
                usuarioAEditar.Clave = txtClave.Text.Trim();
                usuarioAEditar.StatusAdmin = chkAdministrador.Checked;
                resultModificados += UsuarioBL.Modificar(usuarioAEditar);
                objetoActualUsuarios.CargarUsuarios();
                if (resultModificados > 0)
                {
                    if (MetroMessageBox.Show(this, "Datos del usuario actualizados exitosamente.\n¿Desea cerrar el editor?", 
                        "Registro de usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        Close();
                }
                else MetroMessageBox.Show(this, "Los datos del usuario no se pudieron actualizar.", "Actualización de datos de usuarios",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void HabilitarBotonGuardar()
        {
            if (!string.IsNullOrWhiteSpace(txtNombres.Text) && !string.IsNullOrWhiteSpace(txtApellidos.Text) &&
                !string.IsNullOrWhiteSpace(txtNombreUsuario.Text) && !string.IsNullOrWhiteSpace(txtClave.Text))
            {
                btnGuardar.Enabled = true;
            }
            else btnGuardar.Enabled = false;
        }

        void Limpiar()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtNombreUsuario.Clear();
            txtClave.Clear();
            chkAdministrador.Checked = false;
            txtNombres.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar();
            }
            catch (SqlException error)
            {
                MetroMessageBox.Show(this, $"¡Ha ocurrido un error con la conexón a la base de datos.\nMÁS INFORMACIÓN: {error.Message}!", 
                    "Error en la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception error)
            {
                MetroMessageBox.Show(this, $"¡Ha ocurrido un error!\nMÁS INFORMACIÓN: {error.Message}!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombres.Text))
            {
                epValidadorFormulario.SetError(txtNombres, "Este campo es obligatorio.");
            }
            else epValidadorFormulario.SetError(txtNombres, "");
            HabilitarBotonGuardar();
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                epValidadorFormulario.SetError(txtApellidos, "Este campo es obligatorio.");
            }
            else epValidadorFormulario.SetError(txtApellidos, "");
            HabilitarBotonGuardar();
        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
            {
                epValidadorFormulario.SetError(txtNombreUsuario, "Este campo es obligatorio.");
            }
            else epValidadorFormulario.SetError(txtNombreUsuario, "");
            HabilitarBotonGuardar();
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                epValidadorFormulario.SetError(txtClave, "Este campo es obligatorio.");
            }
            else epValidadorFormulario.SetError(txtClave, "");
            HabilitarBotonGuardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
