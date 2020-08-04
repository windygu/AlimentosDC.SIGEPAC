using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar;
using AlimentosDC.SIGEPAC.BL;
using AlimentosDC.SIGEPAC.EN;

namespace AlimentosDC.SIGEPAC.UI
{
    public partial class FrmClientes : MetroForm
    {
        List<Cliente> listadoClientes;
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            FrmCliente mantenimientoClientes = new FrmCliente();
            mantenimientoClientes.Owner = this;
            mantenimientoClientes.ShowDialog();
        }

        private void btnEditarPedido_Click(object sender, EventArgs e)
        {
            FrmCliente mantenimientoClientes = new FrmCliente();
            mantenimientoClientes.Owner = this;
            mantenimientoClientes.ShowDialog();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        void CargarClientes()
        {
            listadoClientes = ClienteBL.ObtenerTodos();
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
    }
}
