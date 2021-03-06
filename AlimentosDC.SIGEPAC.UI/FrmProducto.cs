﻿using System;
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
using System.Text.RegularExpressions;
using System.Threading;
using System.Globalization;

namespace AlimentosDC.SIGEPAC.UI
{
    public partial class FrmProducto : MetroForm
    {
        FrmProductos objetoProductosActual;
        int? idProductoAEditar = null;
        Producto productoAEditar;
        CultureInfo cultura = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
        public FrmProducto(ref FrmProductos objetoProductosActual)
        {
            InitializeComponent();
            this.objetoProductosActual = objetoProductosActual;
        }

        //Constructor para editar un producto
        public FrmProducto(ref FrmProductos objetoProductosActual, int idProductoAEditar)
        {
            InitializeComponent();
            this.objetoProductosActual = objetoProductosActual;
            this.idProductoAEditar = idProductoAEditar;
        }
        private void FrmProducto_Load(object sender, EventArgs e)
        {
            try
            {
                cultura.NumberFormat.NumberDecimalSeparator = ".";
                Thread.CurrentThread.CurrentCulture = cultura;
                btnGuardarProducto.Enabled = false;
                CargarMarcasAlCombobox();
                epValidarControles.Clear();
                if (idProductoAEditar != null)
                {
                    productoAEditar = ProductoBL.BuscarPorId((int)idProductoAEditar);
                    CargarDatosAlFormulario();
                    btnGuardarProducto.Text = "Actualizar";
                }
                //nudStock.TextChanged += NudStock_TextChanged;
            }
            catch (Exception error)
            {
                MetroMessageBox.Show(this, $"¡Ha ocurrido un error!\nMÁS INFORMACIÓN: {error.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Close();
            }

        }

        void CargarDatosAlFormulario()
        {
            cmbMarcas.SelectedValue = productoAEditar.IdMarca;
            txtNombreProducto.Text = productoAEditar.Nombre;
            txtPrecioProducto.Text = productoAEditar.PrecioVenta.ToString();
            txtDescripcionProducto.Text = productoAEditar.Descripcion;
            //nudStock.Value = productoAEditar.Stock;
        }

        void CargarMarcasAlCombobox()
        {
            List<Marca> listadoMarcas = MarcaBL.ObtenerTodos();
            listadoMarcas.Insert(0, new Marca() { Id = 0, Nombre = "- Seleccione -" });
            cmbMarcas.DataSource = listadoMarcas;
        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbMarcas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if ((int)cmbMarcas.SelectedValue>0)
            {
                epValidarControles.SetError(cmbMarcas, "");
                lblComentario.Text = MarcaBL.BuscarPorId((int)cmbMarcas.SelectedValue).Comentario;
                txtNombreProducto.Focus();
                HabilitarBotonGuardar();
            }
            else
            {
                lblComentario.Text = "";
                epValidarControles.SetError(cmbMarcas, "Debe seleccionar una marca");
                HabilitarBotonGuardar();
            }

        }
        void HabilitarBotonGuardar()
        {
            if ((int)cmbMarcas.SelectedValue > 0 && !string.IsNullOrWhiteSpace(txtNombreProducto.Text) &&
                !string.IsNullOrWhiteSpace(txtDescripcionProducto.Text) && ((!string.IsNullOrWhiteSpace(txtPrecioProducto.Text)) 
                && Validaciones.ValidarPrecio(txtPrecioProducto.Text) == 0)/* && nudStock.Value>=0*/)
            {
                btnGuardarProducto.Enabled = true;
            }
            else btnGuardarProducto.Enabled = false;
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            GuardarProducto();
        }

        void GuardarProducto()
        {
            try
            {
                Producto productoAAgregar = new Producto();
                productoAAgregar.IdMarca = int.Parse(cmbMarcas.SelectedValue.ToString());
                productoAAgregar.Nombre = txtNombreProducto.Text;
                productoAAgregar.Descripcion = txtDescripcionProducto.Text;
                productoAAgregar.PrecioVenta = float.Parse(txtPrecioProducto.Text);
                productoAAgregar.Stock = 0 /*(int)nudStock.Value*/;
                if (idProductoAEditar == null)
                {

                    ProductoBL.Guardar(productoAAgregar);
                    objetoProductosActual.CargarProductos();
                    MetroMessageBox.Show(this, "Producto registrado exitosamente.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    productoAAgregar.Id = (int)idProductoAEditar;
                    ProductoBL.Modificar(productoAAgregar);
                    objetoProductosActual.CargarProductos();
                    DialogResult resultado = MetroMessageBox.Show(this, "Producto actualizado exitosamente.\n¿Desea cerrar el editor?", "¡Aviso!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes) Close();
                }
            }
            catch (Exception error)
            {
                MetroMessageBox.Show(this, $"¡Ha ocurrido un error!\nMÁS INFORMACIÓN: {error.Message}", "¡Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        void Limpiar()
        {
            cmbMarcas.SelectedValue = 0;
            lblComentario.Text = "";
            txtNombreProducto.Clear();
            txtDescripcionProducto.Clear();
            //nudStock.Value = 0;
            txtPrecioProducto.Clear();
            epValidarControles.Clear();
        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                epValidarControles.SetError(txtNombreProducto, "Este campo es obligatorio");
                HabilitarBotonGuardar();
            }
            else
            {
                epValidarControles.SetError(txtNombreProducto, "");
                if ((int)cmbMarcas.SelectedValue == 0) epValidarControles.SetError(cmbMarcas, "Debe elegir una marca");
                HabilitarBotonGuardar();
            }
        }

        private void txtPrecioProducto_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrecioProducto.Text))
            {
                epValidarControles.SetError(txtPrecioProducto, "Este campo es obligatorio.");
                HabilitarBotonGuardar();
            }
            else
            {
                switch (Validaciones.ValidarPrecio(txtPrecioProducto.Text))
                {
                    case 1: epValidarControles.SetError(txtPrecioProducto, "Se permite hasta dos decimales.");
                        break;
                    case 2:
                        epValidarControles.SetError(txtPrecioProducto, "Precio no válido.");
                        break;
                    case 0:
                        epValidarControles.SetError(txtPrecioProducto, "");
                        break;
                }
                HabilitarBotonGuardar();
            }
        }
        private void txtDescripcionProducto_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcionProducto.Text))
            {
                epValidarControles.SetError(txtDescripcionProducto, "Este campo es obligatorio");
                HabilitarBotonGuardar();
            }
            else
            {
                epValidarControles.SetError(txtDescripcionProducto, "");
                if ((int)cmbMarcas.SelectedValue == 0) epValidarControles.SetError(cmbMarcas, "Debe elegir una marca");
                HabilitarBotonGuardar();
            }
        }

        /*
        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }
        */

        private void cmbMarcas_DropDownClosed(object sender, EventArgs e)
        {
            if ((int)cmbMarcas.SelectedValue==0)
            {
                epValidarControles.SetError(cmbMarcas, "Debe seleccionar una marca");
            }
        }
        
        /*
        private void nudStock_ValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nudStock.Text) || nudStock.Value == 0)
            {
                epValidarControles.SetError(nudStock, "Este campo es obligatorio");
                HabilitarBotonGuardar();
            }
            else
            {
                epValidarControles.SetError(nudStock, "");
                if ((int)cmbMarcas.SelectedValue == 0) epValidarControles.SetError(cmbMarcas, "Debe elegir una marca");
                HabilitarBotonGuardar();
            }
        }
        */
        /*
        private void NudStock_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nudStock.Text))
            {
                nudStock.Value = 0;
            }
            HabilitarBotonGuardar();
        }
        */
    }
}
