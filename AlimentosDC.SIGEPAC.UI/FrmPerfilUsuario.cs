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
        FrmPrincipal objetoPrincipal;
        public FrmPerfilUsuario(ref FrmPrincipal objetoPrincipal)
        {
            InitializeComponent();
            this.objetoPrincipal = objetoPrincipal;
        }

        private void FrmPerfilUsuario_Load(object sender, EventArgs e)
        {
            if (FrmPrincipal.usuarioActual.StatusAdmin)
            {
                btnUsuarios.Enabled = true;
                Text = "Perfil Administrador";
            }
            if (FrmPrincipal.usuarioActual.Imagen != null)
            {
                MemoryStream secuenciaBytes = new MemoryStream(FrmPrincipal.usuarioActual.Imagen);
                pcbFotoPerfil.Image = Image.FromStream(secuenciaBytes);
            }
            lblNombres.Text = FrmPrincipal.usuarioActual.Nombres;
            lblApellidos.Text = FrmPrincipal.usuarioActual.Apellidos;
            lblNombreUsuario.Text = FrmPrincipal.usuarioActual.NombreUsuario;
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
                FrmPrincipal.usuarioActual.Imagen = secuenciaBytes.GetBuffer();
                UsuarioBL.Modificar(FrmPrincipal.usuarioActual);
                secuenciaBytes = new MemoryStream(FrmPrincipal.usuarioActual.Imagen);
                objetoPrincipal.pcbFotoPerfil.Image = Image.FromStream(secuenciaBytes);
            }
        }

        private void btnCambiarClave_Click(object sender, EventArgs e)
        {
            FrmCambiarClave ventanaCambiarClave = new FrmCambiarClave();
            ventanaCambiarClave.Owner = this;
            ventanaCambiarClave.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmAdministrarUsuarios listadoUsuarios = new FrmAdministrarUsuarios();
            listadoUsuarios.Owner = this;
            listadoUsuarios.ShowDialog();
        }
    }
}
