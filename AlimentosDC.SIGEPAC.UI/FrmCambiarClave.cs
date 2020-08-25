using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using AlimentosDC.SIGEPAC.BL;
using AlimentosDC.SIGEPAC.EN;


namespace AlimentosDC.SIGEPAC.UI
{
    public partial class FrmCambiarClave : MetroForm
    {
        FrmPrincipal objetoActualPrincipal;
        public FrmCambiarClave(ref FrmPrincipal objetoActualPrincipal)
        {
            InitializeComponent();
            this.objetoActualPrincipal = objetoActualPrincipal;
        }

        private void txtClaveActual_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtClaveActual.Text))
            {
                if (objetoActualPrincipal.usuarioActual.Clave != txtClaveActual.Text)
                {
                    epComprobadorClave.SetError(txtClaveActual, "La clave ingresada no coincide con su clave actual");
                }
                else epComprobadorClave.SetError(txtClaveActual, "");
            }
            else
            {
                epComprobadorClave.SetError(txtClaveActual, "");
                
            }
            HabilitarBotonActualizarClave();
        }

        void HabilitarBotonActualizarClave()
        {
            if (txtClaveActual.Text == objetoActualPrincipal.usuarioActual.Clave &&
                !string.IsNullOrWhiteSpace(txtNuevaClave.Text))
            {
                btnActualizarClave.Enabled = true;
            }
            else btnActualizarClave.Enabled = false;
        }

        private void btnActualizarClave_Click(object sender, EventArgs e)
        {
            objetoActualPrincipal.usuarioActual.Clave = txtNuevaClave.Text;
            UsuarioBL.Modificar(objetoActualPrincipal.usuarioActual);
            MetroMessageBox.Show(this, "Clave actualizada.", "Cambiar clave", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNuevaClave_TextChanged(object sender, EventArgs e)
        {
            HabilitarBotonActualizarClave();
        }
    }
}
