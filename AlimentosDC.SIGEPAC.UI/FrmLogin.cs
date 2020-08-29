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
using MetroFramework.Controls;
using AlimentosDC.SIGEPAC.BL;
using AlimentosDC.SIGEPAC.EN;
using System.Data.SqlClient;

namespace AlimentosDC.SIGEPAC.UI
{
    public partial class FrmLogin : MetroForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                Usuario usuario = UsuarioBL.ObtenerUsuario(txtUsuario.Text, txtClave.Text);
                if (usuario.NombreUsuario == txtUsuario.Text && usuario.Clave == txtClave.Text)
                {
                    MetroMessageBox.Show(this, $"¡Bienvenido {usuario.Nombres} {usuario.Apellidos}!", 
                        "Sesión iniciada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmPrincipal menuPrincipal = new FrmPrincipal(usuario);
                    this.Hide();
                    menuPrincipal.Show();
                }
                else
                {
                    MetroMessageBox.Show(this, "Clave o usuario incorrectos.", "Datos incorrectos", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
            catch (SqlException error)
            {
                MetroMessageBox.Show(this, 
               $"La conexión con la base de datos ha fallado.\nMÁS INFORMACIÓN: {error.Message}", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception error)
            {
                MetroMessageBox.Show(this,
               $"¡Ha ocurrido un error!.\nMÁS INFORMACIÓN: {error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor = Cursors.Arrow;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            HabilitarBoton();
        }
        void HabilitarBoton()
        {
            if (!string.IsNullOrWhiteSpace(txtUsuario.Text) && !string.IsNullOrWhiteSpace(txtClave.Text))
            {
                btnIngresar.Enabled = true;
            }
            else btnIngresar.Enabled = false;
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            HabilitarBoton();
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (btnIngresar.Enabled==true)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    btnIngresar_Click(null, null);
                }
            } 
        }

        private void pbxShowPassword_Click(object sender, EventArgs e)
        {
            if (txtClave.PasswordChar == '●')
            {
                txtClave.PasswordChar = '\0';
                pbxShowPassword.Image = Properties.Resources.icons8_eye_30;
            }
            else
            {
                txtClave.PasswordChar = '●';
                pbxShowPassword.Image = Properties.Resources.icons8_hide_30;
            }
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            FrmSplashScreen.ObjetoSplashScreen.Hide();
        }
    }
}
