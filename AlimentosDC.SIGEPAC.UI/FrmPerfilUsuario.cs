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
using AlimentosDC.SIGEPAC.BL;
using AlimentosDC.SIGEPAC.EN;
using System.IO;
using System.Drawing.Imaging;

namespace AlimentosDC.SIGEPAC.UI
{
    public partial class FrmPerfilUsuario : MetroForm
    {
        FrmPrincipal objetoActualPrincipal;
        public FrmPerfilUsuario(ref FrmPrincipal objetoActualPrincipal)
        {
            InitializeComponent();
            this.objetoActualPrincipal = objetoActualPrincipal;
        }

        private void FrmPerfilUsuario_Load(object sender, EventArgs e)
        {
            if (objetoActualPrincipal.usuarioActual.StatusAdmin)
            {
                btnUsuarios.Visible = true;
                Text = "Perfil Administrador";
            }
            if (objetoActualPrincipal.usuarioActual.Imagen != null)
            {
                MemoryStream secuenciaBytes = new MemoryStream(objetoActualPrincipal.usuarioActual.Imagen);
                pcbFotoPerfil.Image = Image.FromStream(secuenciaBytes);
            }
            lblNombres.Text = objetoActualPrincipal.usuarioActual.Nombres;
            lblApellidos.Text = objetoActualPrincipal.usuarioActual.Apellidos;
            lblNombreUsuario.Text = objetoActualPrincipal.usuarioActual.NombreUsuario;
        }

        private void btnCambiarFoto_Click(object sender, EventArgs e)
        {
            string rutaImagen;
            MemoryStream secuenciaBytes = new MemoryStream();
            DialogResult resultado = ofdEscogerFoto.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                rutaImagen = ofdEscogerFoto.FileName;
                pcbFotoPerfil.Image = Image.FromFile(rutaImagen);
                pcbFotoPerfil.Image.Save(secuenciaBytes, ImageFormat.Jpeg);
                objetoActualPrincipal.usuarioActual.Imagen = secuenciaBytes.GetBuffer();
                UsuarioBL.Modificar(objetoActualPrincipal.usuarioActual);
                secuenciaBytes = new MemoryStream(objetoActualPrincipal.usuarioActual.Imagen);
                objetoActualPrincipal.pcbFotoPerfil.Image = Image.FromStream(secuenciaBytes);
            }
        }

        private void btnCambiarClave_Click(object sender, EventArgs e)
        {
            FrmCambiarClave ventanaCambiarClave = new FrmCambiarClave(ref objetoActualPrincipal);
            ventanaCambiarClave.Owner = this;
            ventanaCambiarClave.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios listadoUsuarios = new FrmUsuarios();
            listadoUsuarios.Owner = this;
            listadoUsuarios.ShowDialog();
        }
    }
}
