using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlimentosDC.SIGEPAC.EN;
using AlimentosDC.SIGEPAC.BL;
using MetroFramework;
using MetroFramework.Forms;

namespace AlimentosDC.SIGEPAC.UI
{
    public partial class FrmIngreso : MetroForm
    {
        Marca marca;
        Producto producto;
        int? idDetalleIngresoAEditar = null;
        int? idIngreso;
        Ingreso ingresoEditando;
        List<DetalleIngreso> listadoDetallesIngreso = new List<DetalleIngreso>();
        List<DetalleIngreso> listadoViejoDetallesIngreso = new List<DetalleIngreso>();
        List<int> detallesViejosAEliminarDeLaBD = new List<int>();
        FrmHistoriales objetoIngresosActual;
        FrmIngreso objetoIngresoActual;
        public FrmIngreso()
        {
            InitializeComponent();
            objetoIngresoActual = this;

        }

        //Constructor para editar un ingreso
        public FrmIngreso(FrmHistoriales objetoIngresosActual, int idIngreso)
        {
            InitializeComponent();
            this.objetoIngresosActual = objetoIngresosActual;
            objetoIngresoActual = this;
            this.idIngreso = idIngreso;
        }

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            try
            {
                if (idIngreso!=null)
                {
                    CargarDatosAlFormulario();
                    btnGuardarIngreso.Text = "Actualizar ingreso";
                    txtNumeroCCF.Focus();
                }
                nudCantidad.TextChanged += NudCantidad_TextChanged;
            }
            catch (Exception error)
            {
                MetroMessageBox.Show(this, $"¡Ha ocurrido un error!\nMÁS INFORMACIÓN: {error.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Close();
            }
        }

        private void NudCantidad_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nudCantidad.Text))
            {
                nudCantidad.Value = 0;
            }
            HabilitarBotonAgregarDetalle();
        }

        void HabilitarBotonAgregarDetalle()
        {
            if (producto != null && nudCantidad.Value > 0)
            {
                btnAgregarDetalle.Enabled = true;
            }
            else btnAgregarDetalle.Enabled = false;
        }

        void CargarDatosAlFormulario()
        {
            ingresoEditando = IngresoBL.BuscarPorId((int)idIngreso);
            txtNumeroCCF.Text = ingresoEditando.NumeroCCF;
            dtpFechaIngreso.Value = ingresoEditando.FechaIngreso;
            lblUsuario.Text = ingresoEditando.Usuario;
            marca = MarcaBL.BuscarPorId(ingresoEditando.IdMarca);
            lblNombreMarca.Text = marca.Nombre;
            lblComentarioMarca.Text = marca.Comentario;
            listadoViejoDetallesIngreso = DetalleIngresoBL.ObtenerTodos(ingresoEditando.Id);
            if (listadoViejoDetallesIngreso != null)
            {
                for (int i = 0; i < listadoViejoDetallesIngreso.Count; i++)
                {
                    dgvListadoDetallesIngreso.Rows.Add();
                    dgvListadoDetallesIngreso.Rows[i].Cells[0].Value = listadoViejoDetallesIngreso[i].Id;
                    dgvListadoDetallesIngreso.Rows[i].Cells[1].Value = listadoViejoDetallesIngreso[i].Cantidad;
                    dgvListadoDetallesIngreso.Rows[i].Cells[2].Value = listadoViejoDetallesIngreso[i].Producto;
                    dgvListadoDetallesIngreso.Rows[i].Cells[3].Value = listadoViejoDetallesIngreso[i].Descripcion;
                    dgvListadoDetallesIngreso.Rows[i].Cells[4].Value = listadoViejoDetallesIngreso[i].PrecioUnitario;
                    dgvListadoDetallesIngreso.Rows[i].Cells[5].Value = listadoViejoDetallesIngreso[i].SubTotal;
                    listadoDetallesIngreso.Add(listadoViejoDetallesIngreso[i]);
                }
                CalcularTotales();
            }
        }

        private void btnGuardarCompra_Click(object sender, EventArgs e)
        {
            GuardarCompra();
        }

        void GuardarCompra()
        {

            Cursor = Cursors.WaitCursor;
            try
            {
                if (dgvListadoDetallesIngreso.Rows.Count < 1)
                {
                    epValidadorControles.SetError(dgvListadoDetallesIngreso, "Debe agregar al menos un detalle.");
                }
                else
                {
                    if (idIngreso == null)
                    {
                        int resultIngreso = 0;
                        int resultDetalleIngreso = 0;
                        Ingreso ingresoARegistrar = new Ingreso();
                        ingresoARegistrar.IdUsuario = FrmPrincipal.usuarioActual.Id;
                        ingresoARegistrar.IdMarca = marca.Id;
                        ingresoARegistrar.FechaIngreso = dtpFechaIngreso.Value;
                        ingresoARegistrar.NumeroCCF = txtNumeroCCF.Text.Trim();
                        resultIngreso += IngresoBL.Guardar(ingresoARegistrar);
                        for (int i = 0; i < listadoDetallesIngreso.Count; i++)
                        {
                            DetalleIngreso detalleIngresoARegistrar = new DetalleIngreso();
                            detalleIngresoARegistrar.Id = IngresoBL.BuscarPorNumeroCCF(int.Parse(txtNumeroCCF.Text.Trim())).Id;
                            detalleIngresoARegistrar.IdProducto = producto.Id;
                            detalleIngresoARegistrar.Cantidad = (int)nudCantidad.Value;
                            detalleIngresoARegistrar.PrecioUnitario = producto.PrecioVenta;
                            resultDetalleIngreso += DetalleIngresoBL.Guardar(detalleIngresoARegistrar);
                        }
                        MetroMessageBox.Show(this, $"{resultIngreso} pedido registrado.\n{resultDetalleIngreso} detalle(s) del pedido registrado(s).",
                                    "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                    {
                        int resultIngreso = 0;
                        int resultDetallesModificados = 0;
                        int resultDetallesAñadidos = 0;
                        int resultadoEliminados = 0;

                        ingresoEditando.IdUsuario = FrmPrincipal.usuarioActual.Id;
                        ingresoEditando.IdMarca = marca.Id;
                        ingresoEditando.FechaIngreso = dtpFechaIngreso.Value;
                        ingresoEditando.NumeroCCF = txtNumeroCCF.Text.Trim();
                        resultIngreso += IngresoBL.Modificar(ingresoEditando);
                        for (int i = 0; i < listadoDetallesIngreso.Count; i++)
                        {
                            DetalleIngreso detalleIngresoARegistrar = new DetalleIngreso();
                            detalleIngresoARegistrar.Id = IngresoBL.BuscarPorNumeroCCF(int.Parse(txtNumeroCCF.Text.Trim())).Id;
                            detalleIngresoARegistrar.IdProducto = producto.Id;
                            detalleIngresoARegistrar.Cantidad = (int)nudCantidad.Value;
                            detalleIngresoARegistrar.PrecioUnitario = producto.PrecioVenta;
                            if (listadoViejoDetallesIngreso.Find(x => x.Id == listadoViejoDetallesIngreso[i].Id) != null)
                            {
                                resultDetallesModificados += DetalleIngresoBL.Modificar(detalleIngresoARegistrar);
                            }
                            else
                            {
                                resultDetallesAñadidos += DetalleIngresoBL.Guardar(detalleIngresoARegistrar);
                            }
                        }
                        if (detallesViejosAEliminarDeLaBD.Count >= 1)
                        {
                            for (int i = 0; i < detallesViejosAEliminarDeLaBD.Count; i++)
                            {
                                resultadoEliminados += DetalleIngresoBL.Eliminar(detallesViejosAEliminarDeLaBD[i]);
                            }
                        }
                        /*
                        objetoPedidosActual.CargarPedidos();
                        DialogResult resultadoDelDialgo = MetroMessageBox.Show
                        (this, $"{resultadoPedido} pedido actualizado.\n{resultDetallesModificados} detalle(s) actualizado(s).\n" +
                        $"{resultDetallesAñadidos} detalle(s) registrado(s).\n{resultadoEliminados} detalle(s) eliminado(s).\n¿Desea cerrar el editor?",
                            "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (resultadoDelDialgo == DialogResult.Yes)
                        {
                            Close();
                        }*/
                    }
                }
            }
            catch (Exception error)
            {
                MetroMessageBox.Show(this, $"¡Ha ocurrido un error!\nMÁS INFORMACIÓN: {error.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            Cursor = Cursors.Arrow;
        }

        void Limpiar()
        {
            txtNumeroCCF.Clear();
            dtpFechaIngreso.Value = DateTime.Now;
            marca = null;
            lblNombreMarca.Text = "";
            lblComentarioMarca.Text = "";
            producto = null;
            lblNombreProducto.Text = "";
            lblStock.Text = "";
            lblPrecioUnitario.Text = "";
            lblDescripcion.Text = "";
            nudCantidad.Value = 0;
            lblSubTotal.Text = "";
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {

        }

        void AgregarDetalle()
        {
            if (idDetalleIngresoAEditar != null)
            {
                foreach (DetalleIngreso detalle in listadoDetallesIngreso.Where(x => x.Id == idDetalleIngresoAEditar))
                {
                    detalle.IdProducto = producto.Id;
                    detalle.Producto = producto.Nombre;
                    detalle.Descripcion = producto.Descripcion;
                    detalle.Cantidad = (int)nudCantidad.Value;
                    detalle.PrecioUnitario = producto.PrecioVenta;
                    detalle.SubTotal = (int)nudCantidad.Value * producto.PrecioVenta;
                }
                ActualizarDatagridView();
                LimpiarDetalles();
                btnAgregarDetalle.Text = "Agregar detalle";
            }

            else
            {
                DetalleIngreso detalleIngresoAAgregar = new DetalleIngreso();
                detalleIngresoAAgregar.IdProducto = producto.Id;
                detalleIngresoAAgregar.Producto = producto.Nombre;
                detalleIngresoAAgregar.Descripcion = producto.Descripcion;
                detalleIngresoAAgregar.Cantidad = (int)nudCantidad.Value;
                detalleIngresoAAgregar.PrecioUnitario = producto.PrecioVenta;
                detalleIngresoAAgregar.SubTotal = (int)nudCantidad.Value * producto.PrecioVenta;
                int idUltimoDetalle;
                if (listadoDetallesIngreso.Count >= 1)
                {
                    idUltimoDetalle = listadoDetallesIngreso[listadoDetallesIngreso.Count - 1].Id;
                }
                else idUltimoDetalle = 0;
                detalleIngresoAAgregar.Id = idUltimoDetalle + 1;
                if (listadoDetallesIngreso.Exists(x => x.IdProducto == detalleIngresoAAgregar.IdProducto))
                {
                    MetroMessageBox.Show(this, "Ya agregó este producto a la lista.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);
                    nudCantidad.ResetText();
                    nudCantidad.Focus();
                }
                else
                {
                    listadoDetallesIngreso.Add(detalleIngresoAAgregar);
                    CargarListadoDetalles();
                    LimpiarDetalles();
                }
            }

            
        }

        private void ActualizarDatagridView()
        {
            throw new NotImplementedException();
        }

        void CargarListadoDetalles()
        {
            //Eliminamos los totales para poder colocar los nuevos
            if (dgvListadoDetallesIngreso.RowCount >= 1)
            {
                int indiceSumas = 0, indiceIva = 0, indiceTotal = 0;
                for (int i = 0; i < dgvListadoDetallesIngreso.Rows.Count; i++)
                {
                    switch (dgvListadoDetallesIngreso.Rows[i].Cells[5].Value.ToString())
                    {
                        case "TOTAL":
                            indiceTotal = i;
                            break;
                        case "IVA (13%)":
                            indiceIva = i;
                            break;
                        case "SUMAS":
                            indiceSumas = i;
                            break;
                    }
                }
                dgvListadoDetallesIngreso.Rows.RemoveAt(indiceTotal);
                dgvListadoDetallesIngreso.Rows.RemoveAt(indiceIva);
                dgvListadoDetallesIngreso.Rows.RemoveAt(indiceSumas);
            }
            //Agregamos un a fila al datagrid y obtenemos su indice
            int indiceFilaAgregada = dgvListadoDetallesIngreso.Rows.Add();
            //Trasladamos los datos del detalle agregado la 'listadoDetallesPedido' a la fila agregada al datagrid
            //Sus indices coinciden perfectamente
            dgvListadoDetallesIngreso.Rows[indiceFilaAgregada].Cells[0].Value = listadoDetallesIngreso[indiceFilaAgregada].Id;
            dgvListadoDetallesIngreso.Rows[indiceFilaAgregada].Cells[1].Value = listadoDetallesIngreso[indiceFilaAgregada].Cantidad;
            dgvListadoDetallesIngreso.Rows[indiceFilaAgregada].Cells[2].Value = listadoDetallesIngreso[indiceFilaAgregada].Producto;
            dgvListadoDetallesIngreso.Rows[indiceFilaAgregada].Cells[3].Value = listadoDetallesIngreso[indiceFilaAgregada].Descripcion;
            dgvListadoDetallesIngreso.Rows[indiceFilaAgregada].Cells[4].Value = listadoDetallesIngreso[indiceFilaAgregada].PrecioUnitario;
            dgvListadoDetallesIngreso.Rows[indiceFilaAgregada].Cells[5].Value = listadoDetallesIngreso[indiceFilaAgregada].SubTotal;
            CalcularTotales();
        }

        void CalcularTotales()
        {
            double sumas = 0.00f, iva = 0.00f, total = 0.00f;
            if (listadoDetallesIngreso.Count >= 1)
            {
                foreach (var item in listadoDetallesIngreso)
                {
                    sumas += item.SubTotal;
                }
                iva = sumas * 0.13;
                total = sumas + iva;
            }
            int indiceFilaSumasAgregada = dgvListadoDetallesIngreso.Rows.Add();
            int indiceFilaIvaAgregada = dgvListadoDetallesIngreso.Rows.Add();
            int indiceFilaTotalAgregada = dgvListadoDetallesIngreso.Rows.Add();
            dgvListadoDetallesIngreso.Rows[indiceFilaSumasAgregada].Cells[5].Value = "SUMAS";
            dgvListadoDetallesIngreso.Rows[indiceFilaSumasAgregada].Cells[6].Value = sumas;
            dgvListadoDetallesIngreso.Rows[indiceFilaIvaAgregada].Cells[5].Value = "IVA (13%)";
            dgvListadoDetallesIngreso.Rows[indiceFilaIvaAgregada].Cells[6].Value = iva;
            dgvListadoDetallesIngreso.Rows[indiceFilaTotalAgregada].Cells[5].Value = "TOTAL";
            dgvListadoDetallesIngreso.Rows[indiceFilaTotalAgregada].Cells[6].Value = total;
        }

        void LimpiarDetalles()
        {
            nudCantidad.Value = 0;
            lblNombreProducto.Text = "";
            lblDescripcion.Text = "";
            lblPrecioUnitario.Text = "";
            lblStock.Text = "";
            lblSubTotal.Text = "";
            producto = null;
            idDetalleIngresoAEditar = null;
            epValidadorControles.SetError(nudCantidad, "");
        }

        void CargarDetallesAEditar()
        {
            DetalleIngreso detalleAEditar = listadoDetallesIngreso.Find(x => x.Id == idDetalleIngresoAEditar);
            producto = ProductoBL.BuscarPorId(detalleAEditar.IdProducto);
            lblNombreProducto.Text = producto.Nombre;
            lblPrecioUnitario.Text = string.Concat("$ ", producto.PrecioVenta.ToString("N"));
            lblDescripcion.Text = producto.Descripcion;
            lblStock.Text = producto.Stock.ToString();
            nudCantidad.Text = detalleAEditar.Cantidad.ToString();
            lblSubTotal.Text = string.Concat("$ ", detalleAEditar.SubTotal.ToString("N"));
            HabilitarBotonAgregarDetalle();
        }

        private void btnEditarDetalleIngreso_Click(object sender, EventArgs e)
        {
            idDetalleIngresoAEditar = (int)dgvListadoDetallesIngreso.SelectedRows[0].Cells[0].Value;
            CargarDetallesAEditar();
            btnAgregarDetalle.Text = "Actualizar";
        }

        private void btnEliminarDetalleIngreso_Click(object sender, EventArgs e)
        {
            DialogResult resultadoDelCuadro = MetroMessageBox.Show(this, "¿Desea eliminar el detalle del ingreso?", "Aviso",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resultadoDelCuadro == DialogResult.Yes)
            {
                if (idIngreso == null)
                {
                    int idDetalleIngresoAEliminar = int.Parse(dgvListadoDetallesIngreso.SelectedRows[0].Cells[0].Value.ToString());
                    dgvListadoDetallesIngreso.Rows.RemoveAt(dgvListadoDetallesIngreso.SelectedRows[0].Index);
                    listadoDetallesIngreso.Remove(listadoDetallesIngreso.Find(x => x.Id == idDetalleIngresoAEliminar));
                    ActualizarDatagridView();
                }
                else
                {
                    int idDetalleIngresoAEliminar = int.Parse(dgvListadoDetallesIngreso.SelectedRows[0].Cells[0].Value.ToString());
                    dgvListadoDetallesIngreso.Rows.RemoveAt(dgvListadoDetallesIngreso.SelectedRows[0].Index);
                    DetalleIngreso detalleAEliminar = listadoDetallesIngreso.Find(x => x.Id == idDetalleIngresoAEliminar);
                    if (listadoDetallesIngreso.Remove(detalleAEliminar) == false)
                    {
                        throw new Exception
                        ("No se ha podido encontrar el detalle que se quiere eliminar de la lista 'listadoDetallesIngreso'");
                    }
                    ActualizarDatagridView();
                    if (listadoViejoDetallesIngreso.Find(x => x.Id == detalleAEliminar.Id) != null)
                    {
                        detallesViejosAEliminarDeLaBD.Add(detalleAEliminar.Id);
                    }
                }
                if (dgvListadoDetallesIngreso.Rows.Count < 1) epValidadorControles.SetError(dgvListadoDetallesIngreso, "Debe agregar al menos un detalle");
                HabilitarBotonGuardarPedido();
            }
        }

        void HabilitarBotonGuardarPedido()
        {
            if (!string.IsNullOrWhiteSpace(txtNumeroCCF.Text.Trim()) && marca != null && dgvListadoDetallesIngreso.RowCount > 0)
            {
                btnGuardarIngreso.Enabled = true;
            }
            else btnGuardarIngreso.Enabled = false;
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (nudCantidad.Value > 0 && lblPrecioUnitario.Text.Length > 0)
            {
                epValidadorControles.SetError(nudCantidad, "");
                lblSubTotal.Text = string.Concat("$ ", (producto.PrecioVenta * (float)nudCantidad.Value).ToString("N"));
                lblStock.Text = (producto.Stock + nudCantidad.Value).ToString();
                HabilitarBotonAgregarDetalle();
            }
            else if (nudCantidad.Value > 0)
            {
                epValidadorControles.SetError(nudCantidad, "");
                epValidadorControles.SetError(btnElegirProducto, "Debe seleccionar un producto");
            }
            else
            {
                lblSubTotal.Text = "$ 0.00";
                if (producto != null)
                {
                    lblStock.Text = producto.Stock.ToString();
                }
                epValidadorControles.SetError(nudCantidad, "Este campo es obligatorio");
                HabilitarBotonAgregarDetalle();
            }
        }

        private void txtNumeroCCF_TextChanged(object sender, EventArgs e)
        {
            HabilitarBotonAgregarDetalle();
            HabilitarBotonGuardarPedido();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmPrincipal.delegadoCerrarSesion.Invoke(null, null);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
