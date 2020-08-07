﻿using System;
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
    public partial class FrmPedido : MetroForm
    {
        FrmPedido objeto;
        Pedido pedido;
        List<Cliente> listadoClientes;
        List<Cliente> listadoNuevoClientes;
        int? idPedido = null;
        //Listado a usarse en un nuevo pedido
        public List<DetallePedido> listadoDetallesPedido = new List<DetallePedido>();
        //Listados a usarse en la modificación de un pedido
        public List<DetallePedido> listadoViejoDetallesPedido = new List<DetallePedido>();
        public List<int> detallesViejosAEliminarDeLaBD = new List<int>();

        //Constructor para un nuevo pedido
        public FrmPedido()
        {
            InitializeComponent();
            CargarClientesAlCombobox();
            lblNumeroPedido.Text = PedidoBL.GenerarNumeroPedido();
            objeto = this;
        }

        //Constructor para editar un pedido
        public FrmPedido(int idPedido)
        {
            InitializeComponent();
            CargarClientesAlCombobox();
            this.idPedido = idPedido;
            CargarDatosAlFormulario();
            objeto = this;
            lblTitulo.Text = "Editar pedido";
            btnNuevoPedido.Visible = false;
        }

        //Método para ir agregando cada detalle (anteriormente agregado a la lista) al datagrid
        public void CargarListadoDetalles()
        {
            int indiceFilaAgregada = dgvListadoDetallesPedido.Rows.Add();
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[0].Value = listadoDetallesPedido[indiceFilaAgregada].Id;
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[1].Value = listadoDetallesPedido[indiceFilaAgregada].Producto;
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[2].Value = listadoDetallesPedido[indiceFilaAgregada].Descripcion;
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[3].Value = listadoDetallesPedido[indiceFilaAgregada].Cantidad;
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[4].Value = listadoDetallesPedido[indiceFilaAgregada].PrecioUnitario;
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[5].Value = listadoDetallesPedido[indiceFilaAgregada].SubTotal;
            dgvListadoDetallesPedido.Rows[indiceFilaAgregada].Cells[6].Value = cmbEstadoPedido.SelectedItem.ToString();
        }
        
        void CargarDatosAlFormulario()
        {
            pedido = PedidoBL.BuscarPorId((int) idPedido);
            lblNumeroPedido.Text = pedido.NumeroPedido.ToString();
            List<Cliente> listadoClientes2 = ClienteBL.ObtenerTodos();
            Cliente cliente = ClienteBL.BuscarPorId(pedido.IdCliente);
            int indiceDelCliente = listadoClientes2.FindIndex(x => x.Id == cliente.Id);
            cmbListadoClientes.SelectedIndex = indiceDelCliente;
            
            dtpFechaCreacion.Value = pedido.FechaCreacion;
            cmbEstadoPedido.SelectedItem = pedido.Estado;
            dtpFechaEntrega.Value = pedido.FechaEntrega;
            txtDireccionEntregaPedido.Text = pedido.DireccionEntrega;
            listadoViejoDetallesPedido = DetallePedidoBL.ObtenerTodos((int)idPedido);
            if (listadoViejoDetallesPedido!=null)
            {
                for (int i = 0; i < listadoViejoDetallesPedido.Count; i++)
                {
                    dgvListadoDetallesPedido.Rows.Add();
                    dgvListadoDetallesPedido.Rows[i].Cells[0].Value = listadoViejoDetallesPedido[i].Id;
                    dgvListadoDetallesPedido.Rows[i].Cells[1].Value = listadoViejoDetallesPedido[i].Producto;
                    dgvListadoDetallesPedido.Rows[i].Cells[2].Value = listadoViejoDetallesPedido[i].Descripcion;
                    dgvListadoDetallesPedido.Rows[i].Cells[3].Value = listadoViejoDetallesPedido[i].Cantidad;
                    dgvListadoDetallesPedido.Rows[i].Cells[4].Value = listadoViejoDetallesPedido[i].PrecioUnitario;
                    dgvListadoDetallesPedido.Rows[i].Cells[5].Value = listadoViejoDetallesPedido[i].SubTotal;
                    dgvListadoDetallesPedido.Rows[i].Cells[6].Value = cmbEstadoPedido.SelectedItem.ToString();
                    listadoDetallesPedido.Add(listadoViejoDetallesPedido[i]);
                }
            }
        }

        private void btnNuevoDetallePedido_Click(object sender, EventArgs e)
        {
            FrmDetallePedido mantenimientoDetallesPedido = new FrmDetallePedido(ref objeto);
            mantenimientoDetallesPedido.Owner = this;
            mantenimientoDetallesPedido.ShowDialog();
        }

        private void btnEditarDetallePedido_Click(object sender, EventArgs e)
        {
            int idDetallePedidoAEditar = int.Parse(dgvListadoDetallesPedido.SelectedRows[0].Cells[0].Value.ToString());
            FrmDetallePedido mantenimientoDetallesPedido =
            new FrmDetallePedido(ref objeto, idDetallePedidoAEditar, 
            ref listadoDetallesPedido, ref listadoViejoDetallesPedido, (int) idPedido);
            mantenimientoDetallesPedido.Owner = this;
            mantenimientoDetallesPedido.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        void CargarClientesAlCombobox()
        {
            listadoNuevoClientes = new List<Cliente>();
            listadoClientes = ClienteBL.ObtenerTodos();
            for (int i = 0; i < listadoClientes.Count; i++)
            {
                Cliente cliente = new Cliente();
                cliente.Id = listadoClientes[i].Id;
                cliente.Nombres = string.Concat(listadoClientes[i].Nombres, " ", listadoClientes[i].Apellidos);
                cliente.DUI = listadoClientes[i].DUI;
                cliente.Direccion = listadoClientes[i].Direccion;
                cliente.Telefono = listadoClientes[i].Telefono;
                cliente.Correo = listadoClientes[i].Correo;
                listadoNuevoClientes.Add(cliente);
            }
            cmbListadoClientes.Items.AddRange(listadoNuevoClientes.ToArray());
            cmbListadoClientes.DisplayMember = "Nombres";
        }

        private void cmbListadoClientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbListadoClientes.SelectedItem!=null)
            {
                int id = int.Parse((cmbListadoClientes.SelectedItem as Cliente).Id.ToString());
                lblDui.Text = (ClienteBL.BuscarPorId(id)).DUI;
            }
            
        }

        void Limpiar()
        {
            lblNumeroPedido.Text = PedidoBL.GenerarNumeroPedido();
            dtpFechaCreacion.Value = DateTime.Now;
            dtpFechaEntrega.Value = DateTime.Now;
            cmbEstadoPedido.SelectedItem = null;
            cmbListadoClientes.SelectedItem = null;
            txtDireccionEntregaPedido.Text = "";
            dgvListadoDetallesPedido.Rows.Clear();
            listadoDetallesPedido.Clear();
            dtpFechaCreacion.Focus();
        }

        private void btnGuardarPedido_Click(object sender, EventArgs e)
        {
            if (idPedido==null)
            {
                int resultadoPedido = 0;
                int resultadoDetallePedido = 0;
                try
                {
                    Pedido pedidoARegistrar = new Pedido();
                    pedidoARegistrar.IdCliente = (cmbListadoClientes.SelectedItem as Cliente).Id;
                    pedidoARegistrar.NumeroPedido = int.Parse(lblNumeroPedido.Text);
                    pedidoARegistrar.FechaCreacion = dtpFechaCreacion.Value;
                    pedidoARegistrar.FechaEntrega = dtpFechaEntrega.Value;
                    pedidoARegistrar.DireccionEntrega = txtDireccionEntregaPedido.Text;
                    pedidoARegistrar.Estado = cmbEstadoPedido.SelectedItem.ToString();
                    resultadoPedido += PedidoBL.Guardar(pedidoARegistrar);
                    for (int i = 0; i < dgvListadoDetallesPedido.Rows.Count; i++)
                    {
                        
                        DetallePedido detallePedidoARegistrar = new DetallePedido();
                        detallePedidoARegistrar.IdPedido = (PedidoBL.BuscarPorNumeroPedido(int.Parse(lblNumeroPedido.Text))).Id;
                        detallePedidoARegistrar.IdProducto = listadoDetallesPedido[i].IdProducto;
                        detallePedidoARegistrar.Cantidad = listadoDetallesPedido[i].Cantidad;
                        detallePedidoARegistrar.PrecioUnitario = listadoDetallesPedido[i].PrecioUnitario;
                        detallePedidoARegistrar.SubTotal = listadoDetallesPedido[i].SubTotal;
                        detallePedidoARegistrar.Estado = cmbEstadoPedido.SelectedItem.ToString();
                        resultadoDetallePedido += DetallePedidoBL.Guardar(detallePedidoARegistrar);
                    }
                    MessageBoxEx.Show($"{resultadoPedido} pedido registrado.\n{resultadoDetallePedido} detalle(s) del pedido registrado(s).",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                catch (Exception exc)
                {
                    MessageBoxEx.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                int resultadoPedido = 0;
                int resultadoDetallePedido = 0;
                int resultadoEliminados = 0;
                try
                {
                    pedido.IdCliente = (cmbListadoClientes.SelectedItem as Cliente).Id;
                    pedido.FechaCreacion = dtpFechaCreacion.Value;
                    pedido.FechaEntrega = dtpFechaEntrega.Value;
                    pedido.DireccionEntrega = txtDireccionEntregaPedido.Text;
                    pedido.Estado = cmbEstadoPedido.SelectedItem.ToString();
                    resultadoPedido += PedidoBL.Modificar(pedido);
                    for (int i = 0; i < dgvListadoDetallesPedido.Rows.Count; i++)
                    {
                        DetallePedido detallePedidoARegistrar = new DetallePedido();
                        detallePedidoARegistrar.Id = listadoDetallesPedido[i].Id;
                        detallePedidoARegistrar.IdPedido = (int)idPedido;
                        detallePedidoARegistrar.IdProducto = listadoDetallesPedido[i].IdProducto;
                        detallePedidoARegistrar.Cantidad = listadoDetallesPedido[i].Cantidad;
                        detallePedidoARegistrar.PrecioUnitario = listadoDetallesPedido[i].PrecioUnitario;
                        detallePedidoARegistrar.SubTotal = listadoDetallesPedido[i].SubTotal;
                        detallePedidoARegistrar.Estado = cmbEstadoPedido.SelectedItem.ToString();
                        
                        if (listadoViejoDetallesPedido.Find(x=>x.Id==listadoDetallesPedido[i].Id)!=null)
                        {
                             resultadoDetallePedido += DetallePedidoBL.Modificar(detallePedidoARegistrar);
                        }
                        else
                        {
                             resultadoDetallePedido += DetallePedidoBL.Guardar(detallePedidoARegistrar);
                        }
                    }
                    if (detallesViejosAEliminarDeLaBD.Count>=1)
                    {
                         for (int i = 0; i < detallesViejosAEliminarDeLaBD.Count; i++)
                         {
                              resultadoEliminados += DetallePedidoBL.Eliminar(detallesViejosAEliminarDeLaBD[i]);
                         }
                    }
                    DialogResult resultadoDelDialgo = MessageBoxEx.Show
                    ($"{resultadoPedido} pedido actualizado.\n{resultadoDetallePedido} detalle(s) actualizado(s).\n"+
                    $"{resultadoEliminados} detalle(s) eliminado(s).\n¿Desea cerrar el editor?",
                        "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (resultadoDelDialgo==DialogResult.Yes)
                    {
                        Close();
                    }
                
                }
                catch (Exception exc)
                {
                    MessageBoxEx.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminarDetallePedido_Click(object sender, EventArgs e)
        {
            DialogResult resultadoDelCuadro = MessageBoxEx.Show("¿Desea eliminar el detalle del pedido?", "Aviso", 
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resultadoDelCuadro==DialogResult.Yes)
            {
                if (idPedido==null)
                {
                    int idDetallePedidoAEliminar = int.Parse(dgvListadoDetallesPedido.SelectedRows[0].Cells[0].Value.ToString());
                    dgvListadoDetallesPedido.Rows.RemoveAt(dgvListadoDetallesPedido.SelectedRows[0].Index);
                    listadoDetallesPedido.Remove(listadoDetallesPedido.Find(x => x.Id == idDetallePedidoAEliminar));
                    ActualizarDatagridView();
                }
                else
                {
                    int idDetallePedidoAEliminar = int.Parse(dgvListadoDetallesPedido.SelectedRows[0].Cells[0].Value.ToString());
                    dgvListadoDetallesPedido.Rows.RemoveAt(dgvListadoDetallesPedido.SelectedRows[0].Index);
                    DetallePedido detalleAEliminar = listadoDetallesPedido.Find(x => x.Id == idDetallePedidoAEliminar);
                    listadoDetallesPedido.Remove(detalleAEliminar);
                    ActualizarDatagridView();
                    if (listadoViejoDetallesPedido.Find(x=>x.Id==detalleAEliminar.Id)!=null)
                    {
                        for (int i = 0; i < listadoViejoDetallesPedido.Count; i++)
                        {
                            if (listadoViejoDetallesPedido[i].Id==detalleAEliminar.Id)
                            {
                                listadoViejoDetallesPedido.RemoveAt(i);
                            }
                        }
                        detallesViejosAEliminarDeLaBD.Add(detalleAEliminar.Id);
                    }
                }
            }
        }

        public void ActualizarDatagridView()
        {
            dgvListadoDetallesPedido.Rows.Clear();
            for (int i = 0; i < listadoDetallesPedido.Count; i++)
            {
                CargarListadoDetalles();
            }
        }

        private void dgvListadoDetallesPedido_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListadoDetallesPedido.SelectedRows.Count > 0)
            {
                btnEditarDetallePedido.Enabled = true;
                btnEliminarDetallePedido.Enabled = true;
            }
            else
            {
                btnEditarDetallePedido.Enabled = false;
                btnEliminarDetallePedido.Enabled = false;
            }
        }
    }
}
