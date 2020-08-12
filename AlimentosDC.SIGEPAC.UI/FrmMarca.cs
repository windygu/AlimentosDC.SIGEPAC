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
    public partial class FrmMarca : MetroForm
    {
        FrmMarcas objetoMarcasActual;
        int? idMarcaAEditar = null;
        //Constructor para una nueva marca
        public FrmMarca(FrmMarcas objetoMarcasActual)
        {
            InitializeComponent();
            btnGuardarMarca.Enabled = false;
            this.objetoMarcasActual = objetoMarcasActual;
        }
        //Constructor para editar una marca
        public FrmMarca(FrmMarcas objetoMarcasActual, int idMarcaAEditar)
        {
            InitializeComponent();
            btnGuardarMarca.Text = "Actualizar";
            this.objetoMarcasActual = objetoMarcasActual;
            this.idMarcaAEditar = idMarcaAEditar;
            CargarDatosAlFormulario();
        }

        void CargarDatosAlFormulario()
        {
            Marca marcaAEditar = MarcaBL.BuscarPorId((int)idMarcaAEditar);
            txtNombreMarca.Text = marcaAEditar.Nombre;
            txtComentarioMarca.Text = marcaAEditar.Comentario;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardarMarca_Click(object sender, EventArgs e)
        {
            Marca marcaARegistrar = new Marca();
            marcaARegistrar.Nombre = txtNombreMarca.Text;
            marcaARegistrar.Comentario = txtComentarioMarca.Text;
            try
            {
                if (idMarcaAEditar == null)
                {
                    MarcaBL.Guardar(marcaARegistrar);
                    objetoMarcasActual.CargarMarcas();
                    MetroMessageBox.Show(this, "Marca registrada exitosamente.", "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    marcaARegistrar.Id = (int)idMarcaAEditar;
                    MarcaBL.Modificar(marcaARegistrar);
                    objetoMarcasActual.CargarMarcas();
                    DialogResult resultado = MetroMessageBox.Show(this, "Marca actualizada exitosamente.\n¿Desea cerrar el editor?", "Aviso",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        Close();
                    }
                }
            }
            catch (Exception err)
            {
                MetroMessageBox.Show(this, $"¡Ha ocurrido un error!\nINFORMACIÓN: {err.Message}", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
        void Limpiar()
        {
            txtNombreMarca.Clear();
            txtComentarioMarca.Clear();
            txtNombreMarca.Focus();
        }

        private void txtNombreMarca_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreMarca.Text))
            {
                epValidarControles.SetError(txtNombreMarca, "Este campo es obligatorio.");
                HabilitarBoton();
            }
            else
            {
                epValidarControles.SetError(txtNombreMarca, "");
                HabilitarBoton();
            }

        }
        void HabilitarBoton()
        {
            if (!string.IsNullOrWhiteSpace(txtNombreMarca.Text) &&
                !string.IsNullOrWhiteSpace(txtComentarioMarca.Text))
            {
                btnGuardarMarca.Enabled = true;
            }
            else btnGuardarMarca.Enabled = false;
        }

        private void txtComentarioMarca_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtComentarioMarca.Text))
            {
                epValidarControles.SetError(txtComentarioMarca, "Este campo es obligatorio.");
                HabilitarBoton();
            }
            else
            {
                epValidarControles.SetError(txtComentarioMarca, "");
                HabilitarBoton();
            }
        }
    }
}
