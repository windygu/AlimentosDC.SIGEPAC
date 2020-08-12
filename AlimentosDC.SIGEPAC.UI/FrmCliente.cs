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
using System.Text.RegularExpressions;

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
            btnGuardarCliente.Enabled = false;
            txtPrimerNombre.Focus();
        }
        //Constructor para editar un cliente
        public FrmCliente(ref FrmClientes objetoClientesActual, int idClienteAEditar)
        {
            InitializeComponent();
            this.objetoClientesActual = objetoClientesActual;
            this.idClienteAEditar = idClienteAEditar;
            CargarDatosAlFormulario();
            txtPrimerNombre.Focus();
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

        private void txtPrimerNombre_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrimerNombre.Text))
            {
                epValidarControles.SetError(txtPrimerNombre, "Este campo es obligatorio.");
                HabilitarBoton();
            }
            else
            {
                epValidarControles.SetError(txtPrimerNombre, "");
                HabilitarBoton();
            }
        }

        void HabilitarBoton()
        {
            if (!string.IsNullOrWhiteSpace(txtPrimerNombre.Text) && !string.IsNullOrWhiteSpace(txtPrimerApellido.Text) 
                && !string.IsNullOrWhiteSpace(txtSegundoApellido.Text) && (!string.IsNullOrWhiteSpace(txtDui.Text) && ValidarDui(txtDui.Text) == 1) 
                && !string.IsNullOrWhiteSpace(txtTelefono.Text) && !string.IsNullOrWhiteSpace(txtDireccion.Text) 
                && (!string.IsNullOrWhiteSpace(txtCorreo.Text) && ValidarCorreo(txtCorreo.Text) == 1))
            {
                btnGuardarCliente.Enabled = true;
            }
            else btnGuardarCliente.Enabled = false;
        }

        int ValidarDui(string pTextoDui)
        {
            string patronDuiValido = @"\d{8}[-]\d";
            Regex objetoValidador = new Regex(patronDuiValido);
            return objetoValidador.IsMatch(pTextoDui) ? 1 : 0;
        }
        int ValidarCorreo(string pTextoCorreo)
        {
            string patronCorreoValido = @"^\w+([.]\w+)*[@]\w+([.]\w+)*[.]\w+$";
            Regex objetoValidador = new Regex(patronCorreoValido);
            return objetoValidador.IsMatch(pTextoCorreo) ? 1 : 0;
        }

        private void txtPrimerApellido_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrimerApellido.Text))
            {
                epValidarControles.SetError(txtPrimerApellido, "Este campo es obligatorio.");
                HabilitarBoton();
            }
            else
            {
                epValidarControles.SetError(txtPrimerApellido, "");
                HabilitarBoton();
            }
        }

        private void txtSegundoApellido_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSegundoApellido.Text))
            {
                epValidarControles.SetError(txtSegundoApellido, "Este campo es obligatorio.");
                HabilitarBoton();
            }
            else
            {
                epValidarControles.SetError(txtSegundoApellido, "");
                HabilitarBoton();
            }
        }

        private void txtDui_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDui.Text))
            {
                epValidarControles.SetError(txtDui, "Este campo es obligatorio.");
                HabilitarBoton();
            }
            else if(ValidarDui(txtDui.Text)==0)
            {
                epValidarControles.SetError(txtDui, "DUI no válido.");
                HabilitarBoton();
            }
            else
            {
                epValidarControles.SetError(txtDui, "");
                HabilitarBoton();
            }
        }
        

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                epValidarControles.SetError(txtTelefono, "Este campo es obligatorio.");
                HabilitarBoton();
            }
            else
            {
                epValidarControles.SetError(txtTelefono, "");
                HabilitarBoton();
            }
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                epValidarControles.SetError(txtDireccion, "Este campo es obligatorio.");
                HabilitarBoton();
            }
            else
            {
                epValidarControles.SetError(txtDireccion, "");
                HabilitarBoton();
            }
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                epValidarControles.SetError(txtCorreo, "Este campo es obligatorio.");
                HabilitarBoton();
            }
            else if (ValidarCorreo(txtCorreo.Text) == 0)
            {
                epValidarControles.SetError(txtCorreo, "Correo no válido.");
                HabilitarBoton();
            }
            else
            {
                epValidarControles.SetError(txtCorreo, "");
                HabilitarBoton();
            }
        }

        private void txtDui_KeyUp(object sender, KeyEventArgs e)
        {
            int indiceUltimoCaracter = txtDui.Text.Length;
            if (indiceUltimoCaracter == 8)
            {
                if (e.KeyCode != Keys.Back)
                {
                    txtDui.Text = string.Concat(txtDui.Text, "-");
                    txtDui.Select(txtDui.Text.Length, 0);
                }
            }
        }
        
    }
}
