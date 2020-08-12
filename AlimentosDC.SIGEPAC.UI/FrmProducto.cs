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
            cultura.NumberFormat.NumberDecimalSeparator = ".";
            //Establecemos el hilo de ejecucion actual por la copia que hicimos anteriormente
            Thread.CurrentThread.CurrentCulture = cultura;
            this.objetoProductosActual = objetoProductosActual;
            CargarMarcasAlCombobox();
        }

        //Constructor para editar un producto
        public FrmProducto(ref FrmProductos objetoProductosActual, int idProductoAEditar)
        {
            InitializeComponent();
            cultura.NumberFormat.NumberDecimalSeparator = ".";
            //Establecemos el hilo de ejecucion actual por la copia que hicimos anteriormente
            Thread.CurrentThread.CurrentCulture = cultura;
            this.objetoProductosActual = objetoProductosActual;
            this.idProductoAEditar = idProductoAEditar;
            CargarMarcasAlCombobox();
            productoAEditar = ProductoBL.BuscarPorId(idProductoAEditar);
            CargarDatosAlFormulario();
            btnGuardarProducto.Text = "Actualizar";
        }

        void CargarDatosAlFormulario()
        {
            List<Marca> listadoMarcas = MarcaBL.ObtenerTodos();
            int indiceMarca = listadoMarcas.FindIndex(x => x.Id == productoAEditar.IdMarca);
            cmbMarcas.SelectedIndex = indiceMarca;
            txtNombreProducto.Text = productoAEditar.Nombre;
            txtPrecioProducto.Text = productoAEditar.Precio.ToString();
            txtDescripcionProducto.Text = productoAEditar.Descripcion;
            txtStock.Text = productoAEditar.Stock.ToString();
        }

        void CargarMarcasAlCombobox()
        {
            List<Marca> listadoMarcas = MarcaBL.ObtenerTodos();
            cmbMarcas.Items.AddRange(listadoMarcas.ToArray());
            cmbMarcas.DisplayMember = "Nombre";
        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbMarcas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbMarcas.SelectedItem!=null)
            {
                lblComentario.Text = MarcaBL.BuscarPorId((cmbMarcas.SelectedItem as Marca).Id).Comentario;
                epValidarControles.SetError(cmbMarcas, "");
                txtNombreProducto.Focus();
            }
            if (cmbMarcas.SelectedItem != null && !string.IsNullOrWhiteSpace(txtNombreProducto.Text) &&
                !string.IsNullOrWhiteSpace(txtDescripcionProducto.Text) && (!string.IsNullOrWhiteSpace(txtPrecioProducto.Text) && ValidarPrecio(txtPrecioProducto.Text)==0) &&
                !string.IsNullOrWhiteSpace(txtStock.Text))
            {
                btnGuardarProducto.Enabled = true;
            }
            else btnGuardarProducto.Enabled = false;
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            Producto productoAAgregar = new Producto();
            productoAAgregar.IdMarca = (cmbMarcas.SelectedItem as Marca).Id;
            productoAAgregar.Nombre = txtNombreProducto.Text;
            productoAAgregar.Descripcion = txtDescripcionProducto.Text;
            productoAAgregar.Precio = float.Parse(txtPrecioProducto.Text);
            productoAAgregar.Stock = int.Parse(txtStock.Text);
            if (idProductoAEditar==null)
            {
                try
                {
                    ProductoBL.Guardar(productoAAgregar);
                    objetoProductosActual.CargarProductos();
                    MetroMessageBox.Show(this, "Producto registrado exitosamente.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                catch (Exception exc)
                {
                    MetroMessageBox.Show(this, $"¡Ha ocurrido un error!\n{exc.Message}", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                productoAAgregar.Id = (int) idProductoAEditar;
                try
                {
                    ProductoBL.Modificar(productoAAgregar);
                    objetoProductosActual.CargarProductos();
                    DialogResult resultado = MetroMessageBox.Show(this, "Producto actualizado exitosamente.\n¿Desea cerrar el editor?", "¡Aviso!", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes) Close();
                }
                catch (Exception exc)
                {
                    MetroMessageBox.Show(this, $"¡Ha ocurrido un error!\n{exc.Message}", "¡Error!", MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
            }
            
            
        }
        void Limpiar()
        {
            cmbMarcas.SelectedItem = null;
            lblComentario.Text = "";
            txtNombreProducto.Clear();
            txtDescripcionProducto.Clear();
            txtStock.Clear();
            txtPrecioProducto.Clear();
        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                epValidarControles.SetError(txtNombreProducto, "Este campo es obligatorio.");
            }
            else epValidarControles.SetError(txtNombreProducto, "");
            if (cmbMarcas.SelectedItem != null && !string.IsNullOrWhiteSpace(txtNombreProducto.Text) &&
                !string.IsNullOrWhiteSpace(txtDescripcionProducto.Text) && (!string.IsNullOrWhiteSpace(txtPrecioProducto.Text) 
                && ValidarPrecio(txtPrecioProducto.Text) == 0) &&
                !string.IsNullOrWhiteSpace(txtStock.Text))
            {
                btnGuardarProducto.Enabled = true;
            }
            else btnGuardarProducto.Enabled = false;
        }

        private void txtPrecioProducto_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrecioProducto.Text))
            {
                epValidarControles.SetError(txtPrecioProducto, "Este campo es obligatorio.");
            }
            else
            {
                switch (ValidarPrecio(txtPrecioProducto.Text))
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
            }
            if (cmbMarcas.SelectedItem != null && !string.IsNullOrWhiteSpace(txtNombreProducto.Text) &&
                !string.IsNullOrWhiteSpace(txtDescripcionProducto.Text) && (!string.IsNullOrWhiteSpace(txtPrecioProducto.Text)
                && ValidarPrecio(txtPrecioProducto.Text) == 0) &&
                !string.IsNullOrWhiteSpace(txtStock.Text))
            {
                btnGuardarProducto.Enabled = true;
            }
            else btnGuardarProducto.Enabled = false;
        }

        byte ValidarPrecio(string textoDelPrecio)
        {
            string patronTresDecimales = @"\d+[.]\d{3}";
            Regex objetoValidador = new Regex(patronTresDecimales);
            byte valorDeRetorno;
            float c;
            if (float.TryParse(textoDelPrecio.Trim(), out c) && (objetoValidador.IsMatch(textoDelPrecio.Trim())))
            {
                valorDeRetorno = 1;
            }
            else if (float.TryParse(textoDelPrecio.Trim(), out c)==false)
            {
                valorDeRetorno = 2;
            }
            else
            {
                if (txtPrecioProducto.Text.Trim().Substring(txtPrecioProducto.Text.Trim().Length-1,1)==".")
                {
                    valorDeRetorno = 2;
                }
                else valorDeRetorno = 0;

            }
            return valorDeRetorno;
        }

        private void txtDescripcionProducto_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcionProducto.Text))
            {
                epValidarControles.SetError(txtDescripcionProducto, "Este campo es obligatorio.");
            }
            else epValidarControles.SetError(txtDescripcionProducto, "");
            if (cmbMarcas.SelectedItem != null && !string.IsNullOrWhiteSpace(txtNombreProducto.Text) &&
                !string.IsNullOrWhiteSpace(txtDescripcionProducto.Text) && (!string.IsNullOrWhiteSpace(txtPrecioProducto.Text) 
                && ValidarPrecio(txtPrecioProducto.Text) == 0) &&
                !string.IsNullOrWhiteSpace(txtStock.Text))
            {
                btnGuardarProducto.Enabled = true;
            }
            else btnGuardarProducto.Enabled = false;
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStock.Text))
            {
                epValidarControles.SetError(txtStock, "Este campo es obligatorio.");
            }
            else epValidarControles.SetError(txtStock, "");
            if (cmbMarcas.SelectedItem != null && !string.IsNullOrWhiteSpace(txtNombreProducto.Text) &&
                !string.IsNullOrWhiteSpace(txtDescripcionProducto.Text) && (!string.IsNullOrWhiteSpace(txtPrecioProducto.Text) 
                && ValidarPrecio(txtPrecioProducto.Text) == 0) &&
                !string.IsNullOrWhiteSpace(txtStock.Text))
            {
                btnGuardarProducto.Enabled = true;
            }
            else btnGuardarProducto.Enabled = false;
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }

        private void cmbMarcas_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbMarcas.SelectedItem==null)
            {
                epValidarControles.SetError(cmbMarcas, "Debe seleccionar una marca.");
            }
        }
    }
}
