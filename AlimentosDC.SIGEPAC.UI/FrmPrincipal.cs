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
using System.IO;
using AlimentosDC.SIGEPAC.BL;
using AlimentosDC.SIGEPAC.EN;
using System.Drawing.Imaging;
using System.Globalization;

namespace AlimentosDC.SIGEPAC.UI
{
    public partial class FrmPrincipal : MetroForm
    {
        Usuario usuarioActual;
        public FrmPrincipal(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            CultureInfo cultura = new CultureInfo("es-SV");
            CultureInfo copia = (CultureInfo)cultura.Clone();
            CultureInfo.DefaultThreadCurrentCulture = copia;
            CultureInfo.DefaultThreadCurrentUICulture = copia;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = string.Concat(usuarioActual.Nombres, " ", usuarioActual.Apellidos);
            if (usuarioActual.Imagen != null)
            {
                MemoryStream secuenciaBytes = new MemoryStream(usuarioActual.Imagen);
                pcbFotoPerfil.Image = Image.FromStream(secuenciaBytes);
            }
            
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FrmPedido nuevoPedido = new FrmPedido(usuarioActual);
            nuevoPedido.Owner = this;
            nuevoPedido.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos listadoProductos = new FrmProductos();
            listadoProductos.Owner = this;
            listadoProductos.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes listadoClientes = new FrmClientes();
            listadoClientes.Owner = this;
            listadoClientes.ShowDialog();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            FrmMarcas listadoMarcas = new FrmMarcas();
            listadoMarcas.Owner = this;
            listadoMarcas.ShowDialog();
        }

        private void btnCerraSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MetroMessageBox.Show(this, "¿Desea cerrar la sesión?", "Aviso", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        private void pcbFotoPerfil_Click(object sender, EventArgs e)
        {
            DialogResult resultadoCuadro = MetroMessageBox.Show(this, "¿Desea cambiar su foto de perfil?", "Cambiar foto de perfil", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (resultadoCuadro == DialogResult.Yes)
            {
                string rutaImagen;
                DialogResult resultado = ofdEscogerFoto.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    rutaImagen = ofdEscogerFoto.FileName;
                    pcbFotoPerfil.Image = Image.FromFile(rutaImagen);
                    MemoryStream secuenciaBytes = new MemoryStream();
                    pcbFotoPerfil.Image.Save(secuenciaBytes, ImageFormat.Jpeg);
                    usuarioActual.Imagen = secuenciaBytes.GetBuffer();
                    UsuarioBL.Modificar(usuarioActual);
                }
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmReporte informe = new FrmReporte();
            informe.Owner = this;
            informe.ShowDialog();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FrmPedidos historialPedidos = new FrmPedidos();
            historialPedidos.Owner = this;
            historialPedidos.ShowDialog();
        }
    }
}
// CONTINUAR EN CREAR LA VENTANA DE PERFIL DE USUARIO Y MEJORAR LA VENTANA DE VERDETALLEPEDIDO
