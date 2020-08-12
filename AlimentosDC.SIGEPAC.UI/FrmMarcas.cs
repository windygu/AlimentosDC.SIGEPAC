﻿using System;
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

namespace AlimentosDC.SIGEPAC.UI
{
    public partial class FrmMarcas : MetroForm
    {
        FrmMarcas objetoMarcasActual;
        List<Marca> listadoMarcas;
        //Constructor para una nueva marca
        public FrmMarcas()
        {
            InitializeComponent();
            objetoMarcasActual = this;
            CargarMarcas();
        }

        public void CargarMarcas(string pCondicion = "%")
        {
            listadoMarcas = MarcaBL.ObtenerTodos(pCondicion);
            dgvListadoMarcas.Rows.Clear();
            for (int i = 0; i < listadoMarcas.Count; i++)
            {
                dgvListadoMarcas.Rows.Add();
                dgvListadoMarcas.Rows[i].Cells[0].Value = listadoMarcas[i].Id;
                dgvListadoMarcas.Rows[i].Cells[1].Value = listadoMarcas[i].Nombre;
                dgvListadoMarcas.Rows[i].Cells[2].Value = listadoMarcas[i].Comentario;
            }
        }

        private void btnNuevaMarca_Click(object sender, EventArgs e)
        {
            FrmMarca mantenimientoMarcas = new FrmMarca(objetoMarcasActual);
            mantenimientoMarcas.Owner = objetoMarcasActual;
            mantenimientoMarcas.ShowDialog();
        }

        private void btnEditarMarca_Click(object sender, EventArgs e)
        {
            int idMarcaAEditar = int.Parse(dgvListadoMarcas.SelectedRows[0].Cells[0].Value.ToString());
            FrmMarca mantenimientoMarcas = new FrmMarca(objetoMarcasActual, idMarcaAEditar);
            mantenimientoMarcas.Owner = objetoMarcasActual;
            mantenimientoMarcas.ShowDialog();
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            int idMarcaAEliminar = int.Parse(dgvListadoMarcas.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult resultado = MetroMessageBox.Show(this, "¿Desea eliminar esta marca?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            try
            {
                if (resultado == DialogResult.Yes)
                {
                    if (ProductoBL.ObtenerTodos(idMarca: idMarcaAEliminar).Count>=1)
                    {
                        MetroMessageBox.Show(this, string.Concat("No puede eliminar esta marca por que existen productos registrados con dicha marca, ", 
                            "para poder eliminarla, debe remover primero sus productos."), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MarcaBL.Eliminar(idMarcaAEliminar);
                        objetoMarcasActual.CargarMarcas();
                    }
                }
            }
            catch (DeletedRowInaccessibleException err)
            {
                MetroMessageBox.Show(this, $"Esta marca ya fue eliminada.\nMÁS INFORMACIÓN: {err.Message}", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                objetoMarcasActual.CargarMarcas();
            }
            catch (Exception err)
            {
                MetroMessageBox.Show(this, $"¡Ha ocurrido un error!\nMÁS INFORMACIÓN: {err.Message}", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
 
        }
        
        private void textBoxWaterMark1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarMarcas(txtBuscarMarcas.Text);
            }
            catch (Exception err)
            {
                MetroMessageBox.Show(this, $"¡Ha ocurrido un error!\nMÁS INFORMACIÓN: {err.Message}", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                CargarMarcas();
            }
        }
    }
}
