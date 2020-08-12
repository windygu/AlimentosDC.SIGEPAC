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
using AlimentosDC.SIGEPAC.EN;
using AlimentosDC.SIGEPAC.BL;

namespace AlimentosDC.SIGEPAC.UI
{
    public partial class FrmCliente : MetroForm
    {
        FrmClientes objetoClientesActual;
        int? idClienteAEditar = null;
        //Contructor para un nuevo cliente
        public FrmCliente(ref FrmClientes objetoClientesActual)
        {
            InitializeComponent();
            this.objetoClientesActual = objetoClientesActual;
        }
        //Constructor para editar un cliente
        public FrmCliente(ref FrmClientes objetoClientesActual, int idClienteAEditar)
        {
            InitializeComponent();
            this.objetoClientesActual = objetoClientesActual;
            this.idClienteAEditar = idClienteAEditar;
            CargarDatosAlFormulario();
        }

        void CargarDatosAlFormulario()
        {
            Cliente clienteAEditar = ClienteBL.BuscarPorId((int)idClienteAEditar);
            txtPrimerNombre.Text = clienteAEditar.PrimerNombre;
            txtSegundoNombre.Text = clienteAEditar.SegundoNombre;
            txtPrimerApellido.Text = clienteAEditar.PrimerApellido;
            txtSegundoApellido.Text = clienteAEditar.SegundoApellido;
            txtDui.Text = clienteAEditar.DUI;
            txtDireccion.Text = clienteAEditar.Direccion;
            txtTelefono.Text = clienteAEditar.Telefono;
            txtCorreo.Text = clienteAEditar.Correo;
            txtPrimerNombre.Focus();
        }

        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente clienteARegistrar = new Cliente();
                clienteARegistrar.PrimerNombre = txtPrimerNombre.Text;
                clienteARegistrar.SegundoNombre = txtSegundoNombre.Text;
                clienteARegistrar.PrimerApellido = txtPrimerApellido.Text;
                clienteARegistrar.SegundoApellido = txtSegundoApellido.Text;
                clienteARegistrar.DUI = txtDui.Text;
                clienteARegistrar.Direccion = txtDireccion.Text;
                clienteARegistrar.Telefono = txtTelefono.Text;
                clienteARegistrar.Correo = txtCorreo.Text;
                if (idClienteAEditar == null)
                {
                    ClienteBL.Guardar(clienteARegistrar);
                    objetoClientesActual.CargarClientes();
                    MetroMessageBox.Show(this, "Cliente registrado exitosamente.", "¡Aviso!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    clienteARegistrar.Id = (int)idClienteAEditar;
                    ClienteBL.Modificar(clienteARegistrar);
                    objetoClientesActual.CargarClientes();
                    DialogResult resultado = MetroMessageBox.Show(this, "Cliente actualizado exitosamente.\n¿Desea cerrar el editor?", "¡Aviso!", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        Close();
                    }
                }
            }
            catch (Exception error)
            {
                MetroMessageBox.Show(this, $"¡Ha ocurrido un error!.\n{error.Message}", "¡Error!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        void Limpiar()
        {
            txtPrimerNombre.Clear();
            txtSegundoNombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            txtDui.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtPrimerNombre.Focus();
        }
    }
}
