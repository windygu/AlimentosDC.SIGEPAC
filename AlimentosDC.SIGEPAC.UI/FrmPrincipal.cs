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
        public static Usuario usuarioActual { get; set; }
        FrmPrincipal objetoActualPrincipal;
        public static cerrarSesion delegadoCerrarSesion;
        public delegate void cerrarSesion(object sender, EventArgs e);
        public FrmPrincipal(Usuario usuario)
        {
            InitializeComponent();
            delegadoCerrarSesion = new cerrarSesion(btnCerraSesion_Click);
            usuarioActual = usuario;
            CultureInfo cultura = new CultureInfo("es-SV");
            CultureInfo copia = (CultureInfo)cultura.Clone();
            CultureInfo.DefaultThreadCurrentCulture = copia;
            CultureInfo.DefaultThreadCurrentUICulture = copia;
            objetoActualPrincipal = this;
        }
        

        public void FrmPrincipal_Load(object sender, EventArgs e)
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
            Cursor = Cursors.WaitCursor;
            FrmPedido nuevoPedido = new FrmPedido(usuarioActual);
            nuevoPedido.Owner = this;
            nuevoPedido.ShowDialog();
            Cursor = Cursors.Arrow;
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FrmProductos listadoProductos = new FrmProductos();
            listadoProductos.Owner = this;
            listadoProductos.ShowDialog();
            Cursor = Cursors.Arrow;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FrmClientes listadoClientes = new FrmClientes();
            listadoClientes.Owner = this;
            listadoClientes.ShowDialog();
            Cursor = Cursors.Arrow;
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FrmMarcas listadoMarcas = new FrmMarcas();
            listadoMarcas.Owner = this;
            listadoMarcas.ShowDialog();
            Cursor = Cursors.Arrow;
        }

        public void btnCerraSesion_Click(object sender, EventArgs e)
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
            FrmPerfilUsuario ventanaPerfil = new FrmPerfilUsuario(ref objetoActualPrincipal);
            ventanaPerfil.Owner = this;
            ventanaPerfil.ShowDialog();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FrmReporte informe = new FrmReporte();
            informe.Owner = this;
            informe.ShowDialog();
            Cursor = Cursors.Arrow;
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FrmHistoriales historialPedidos = new FrmHistoriales();
            historialPedidos.ShowDialog(this);
            Cursor = Cursors.Arrow;
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FrmIngreso ventanaIngresos = new FrmIngreso();
            ventanaIngresos.ShowDialog(this);
            Cursor = Cursors.Arrow;
        }
    }
}

// CONTINUAR EN AGREGAR UNA FUNCIÓN DE EXPORTAR A EXCEL LOS LISTADOS DE PEDIDOS E INGRESOS