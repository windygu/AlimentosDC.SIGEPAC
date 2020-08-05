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
    public partial class FrmProductos : MetroForm
    {
        List<Producto> listadoProductos = null;
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            FrmProducto mantenimientoProductos = new FrmProducto();
            mantenimientoProductos.Owner = this;
            mantenimientoProductos.ShowDialog();
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            FrmProducto mantenimientoProductos = new FrmProducto();
            mantenimientoProductos.Owner = this;
            mantenimientoProductos.ShowDialog();
        }

        void CargarProductos()
        {
            listadoProductos = ProductoBL.ObtenerTodos();
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
    }
}
