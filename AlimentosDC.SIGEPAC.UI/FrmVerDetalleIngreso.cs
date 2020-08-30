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
using AlimentosDC.SIGEPAC.EN;
using AlimentosDC.SIGEPAC.BL;

namespace AlimentosDC.SIGEPAC.UI
{
    public partial class FrmVerDetalleIngreso : MetroForm
    {
        int idIngreso;
        public FrmVerDetalleIngreso(int idIngreso)
        {
            InitializeComponent();
            this.idIngreso = idIngreso;
        }

        private void FrmVerDetalleIngreso_Load(object sender, EventArgs e)
        {
            Ingreso ingreso = IngresoBL.BuscarPorId(idIngreso);
            lblNumeroCCF.Text = ingreso.NumeroCCF;
            lblFechaIngreso.Text = ingreso.FechaIngreso.ToString("d");
            lblMarca.Text = ingreso.Marca;
            List<DetalleIngreso> listadoDetalleIngreso = DetalleIngresoBL.ObtenerTodos(idIngreso);
            if (listadoDetalleIngreso.Count>0)
            {
                for (int i = 0; i < listadoDetalleIngreso.Count; i++)
                {
                    dgvListadoDetallesIngreso.Rows.Add();
                    dgvListadoDetallesIngreso.Rows[i].Cells[0].Value = listadoDetalleIngreso[i].Id;
                    dgvListadoDetallesIngreso.Rows[i].Cells[1].Value = listadoDetalleIngreso[i].Cantidad;
                    dgvListadoDetallesIngreso.Rows[i].Cells[2].Value = listadoDetalleIngreso[i].Producto;
                    dgvListadoDetallesIngreso.Rows[i].Cells[3].Value = listadoDetalleIngreso[i].Descripcion;
                    dgvListadoDetallesIngreso.Rows[i].Cells[4].Value = listadoDetalleIngreso[i].PrecioUnitario;
                    dgvListadoDetallesIngreso.Rows[i].Cells[5].Value = listadoDetalleIngreso[i].SubTotal;
                }
            }
            lblUsuario.Text = ingreso.Usuario;
        }
    }
}
