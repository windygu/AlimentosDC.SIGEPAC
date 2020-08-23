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
        public FrmCambiarClave()
        {
            InitializeComponent();
            btnActualizarClave.Enabled = false;
        }

        private void txtClaveActual_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtClaveActual.Text))
            {
                if (FrmPrincipal.usuarioActual.Clave != txtClaveActual.Text)
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
            if (txtClaveActual.Text == FrmPrincipal.usuarioActual.Clave &&
                !string.IsNullOrWhiteSpace(txtNuevaClave.Text))
            {
                btnActualizarClave.Enabled = true;
            }
            else btnActualizarClave.Enabled = false;
        }

        private void btnActualizarClave_Click(object sender, EventArgs e)
        {
            FrmPrincipal.usuarioActual.Clave = txtNuevaClave.Text;
            UsuarioBL.Modificar(FrmPrincipal.usuarioActual);
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

        //ME QUEDE AQUI CREANDO EL FORMULARIO DE LISTADO DE USUARIOS Y ENCONTRAR EL 
        //ERROR QUE AL CERRAR LA VENTANA DE CAMBIAR CLAVE SE ME CIERRA AUTOMATICAMENTE
        //LA VENTANA DE PERFIL DE USUARIO
    }
}
