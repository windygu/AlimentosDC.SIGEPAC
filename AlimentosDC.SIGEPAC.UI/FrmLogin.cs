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
            Usuario usuario = UsuarioBL.ObtenerUsuario(txtUsuario.Text, txtClave.Text);
            if (usuario.Usuario1 == txtUsuario.Text && usuario.Clave == txtClave.Text)
            {
                MetroMessageBox.Show(this, "¡Bienvenido!", "Sesión iniciada", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }
    }
}
