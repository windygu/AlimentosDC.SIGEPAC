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
using System.Media;

namespace AlimentosDC.SIGEPAC.UI
{
    public partial class FrmProductos : MetroForm
    {
        public List<Producto> listadoProductos = null;
        FrmProductos objetoProductosActual;
        public FrmProductos()
        {
            InitializeComponent();
            objetoProductosActual = this;
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            FrmProducto mantenimientoProductos = new FrmProducto(ref objetoProductosActual);
            mantenimientoProductos.Owner = objetoProductosActual;
            mantenimientoProductos.ShowDialog();
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            int idProductoAEditar = int.Parse(dgvListadoProductos.SelectedRows[0].Cells[0].Value.ToString());
            FrmProducto mantenimientoProductos = new FrmProducto(ref objetoProductosActual, idProductoAEditar);
            mantenimientoProductos.Owner = objetoProductosActual;
            mantenimientoProductos.ShowDialog();
        }

        public void CargarProductos(string pCondicion = "%")
        {
            listadoProductos = ProductoBL.ObtenerTodos(pCondicion);
            dgvListadoProductos.Rows.Clear();
            for (int i = 0; i < listadoProductos.Count; i++)
            {
                dgvListadoProductos.Rows.Add();
                dgvListadoProductos.Rows[i].Cells[0].Value = listadoProductos[i].Id;
                dgvListadoProductos.Rows[i].Cells[1].Value = listadoProductos[i].Nombre;
                dgvListadoProductos.Rows[i].Cells[2].Value = listadoProductos[i].Descripcion;
                dgvListadoProductos.Rows[i].Cells[3].Value = listadoProductos[i].Marca;
                dgvListadoProductos.Rows[i].Cells[4].Value = listadoProductos[i].Precio;
                dgvListadoProductos.Rows[i].Cells[5].Value = listadoProductos[i].Stock;
            }
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            int idProductoAEliminar = int.Parse(dgvListadoProductos.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult resultado = MessageBox.Show("¿Desea eliminar este producto?", "¡Aviso!", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            SystemSounds.Question.Play();
            if (resultado == DialogResult.Yes)
            {
                ProductoBL.Eliminar(idProductoAEliminar);
                CargarProductos();
            }
        }

        private void txtBuscarProductos_TextChanged(object sender, EventArgs e)
        {
            CargarProductos(txtBuscarProductos.Text.Trim());
        }
    }
}
