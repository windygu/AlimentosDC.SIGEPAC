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

namespace AlimentosDC.SIGEPAC.UI
{
    public partial class FrmPrincipal : MetroForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FrmPedidos fm = new FrmPedidos();
            fm.Owner = this;
            fm.ShowDialog();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult resultadoCuadro = MetroMessageBox.Show(this, "¿Desea cambiar su cambiar la foto de perfil?", "Aviso", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (resultadoCuadro == DialogResult.Yes)
            {
                string rutaImagen;
                DialogResult resultado = ofdEscogerFoto.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    MemoryStream secuenciaBytes = new MemoryStream();
                    rutaImagen = ofdEscogerFoto.FileName;
                    pcbFotoPerfil.ImageLocation = rutaImagen;
                    pcbFotoPerfil.Image.Save(secuenciaBytes, ImageFormat.Jpeg);
                }
            }
        }
    }
}
