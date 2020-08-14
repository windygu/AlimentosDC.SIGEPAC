using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlimentosDC.SIGEPAC.BL;
using AlimentosDC.SIGEPAC.EN;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace AlimentosDC.SIGEPAC.UI
{
    public partial class FrmClientes : MetroForm
    {
        List<Cliente> listadoClientes;
        FrmClientes objetoClientesActual;
        public FrmClientes()
        {
            InitializeComponent();
            objetoClientesActual = this;
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            FrmCliente mantenimientoClientes = new FrmCliente(ref objetoClientesActual);
            mantenimientoClientes.Owner = objetoClientesActual;
            mantenimientoClientes.ShowDialog();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            int idClienteAEditar = int.Parse(dgvListadoClientes.SelectedRows[0].Cells[0].Value.ToString());
            FrmCliente mantenimientoClientes = new FrmCliente(ref objetoClientesActual, idClienteAEditar);
            mantenimientoClientes.Owner = objetoClientesActual;
            mantenimientoClientes.ShowDialog();
        }

        public void CargarClientes(string pCondicion = "%")
        {
            listadoClientes = ClienteBL.ObtenerTodos(pCondicion);
            dgvListadoClientes.Rows.Clear();
            for (int i = 0; i < listadoClientes.Count; i++)
            {
                dgvListadoClientes.Rows.Add();
                dgvListadoClientes.Rows[i].Cells[0].Value = listadoClientes[i].Id;
                dgvListadoClientes.Rows[i].Cells[1].Value = listadoClientes[i].Nombres;
                dgvListadoClientes.Rows[i].Cells[2].Value = listadoClientes[i].Apellidos;
                dgvListadoClientes.Rows[i].Cells[3].Value = listadoClientes[i].DUI;
                dgvListadoClientes.Rows[i].Cells[4].Value = listadoClientes[i].Direccion;
                dgvListadoClientes.Rows[i].Cells[5].Value = listadoClientes[i].Telefono;
                dgvListadoClientes.Rows[i].Cells[6].Value = listadoClientes[i].Correo;
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                int idClienteAEliminar = int.Parse(dgvListadoClientes.SelectedRows[0].Cells[0].Value.ToString());
                DialogResult resultado = MetroMessageBox.Show(this, "¿Desea eliminar el cliente?", "Aviso", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resultado == DialogResult.Yes)
                {
                    if (PedidoBL.ObtenerTodos(idCliente: idClienteAEliminar).Count >= 1)
                    {
                        MetroMessageBox.Show(this, string.Concat("No puede eliminar este cliente por que tiene pedidos, para poder eliminarlo primer debe remover ",
                            "sus pedidos."), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ClienteBL.Eliminar(idClienteAEliminar);
                        objetoClientesActual.CargarClientes();
                    }
                }
            }
            catch (DeletedRowInaccessibleException error)
            {
                MetroMessageBox.Show(this, $"Este cliente ya fue eliminado.\nMÁS INFORMACIÓN: {error.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                objetoClientesActual.CargarClientes();
            }
            catch (Exception err)
            {
                MetroMessageBox.Show(this, $"¡Ha ocurrido un error!\nMÁS INFORMACIÓN: {err.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
        }

        private void txtBuscarClientes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarClientes(txtBuscarClientes.Text);
            }
            catch (Exception error)
            {
                MetroMessageBox.Show(this, $"¡Ha ocurrido un error!.\n{error.Message}", "¡Error!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void dgvListadoClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListadoClientes.SelectedRows.Count>=1)
            {
                btnEditarCliente.Enabled = true;
                btnEliminarCliente.Enabled = true;
            }
            else
            {
                btnEliminarCliente.Enabled = false;
                btnEditarCliente.Enabled = false;
            }
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }
    }
}
