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
using AlimentosDC.SIGEPAC.BL;
using AlimentosDC.SIGEPAC.EN;

namespace AlimentosDC.SIGEPAC.UI
{
    public partial class FrmUsuarios : MetroForm
    {
        FrmUsuarios objetoActualUsuarios;
        public FrmUsuarios()
        {
            InitializeComponent();
            objetoActualUsuarios = this;
        }

        private void FrmAdministrarUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        public void CargarUsuarios(string pCondicion = "%")
        {
            dgvListadoUsuarios.Rows.Clear();
            List<Usuario> listadoUsuarios = UsuarioBL.ObtenerTodos(pCondicion);
            for (int i = 0; i < listadoUsuarios.Count; i++)
            {
                dgvListadoUsuarios.Rows.Add();
                dgvListadoUsuarios.Rows[i].Cells[0].Value = listadoUsuarios[i].Id;
                dgvListadoUsuarios.Rows[i].Cells[1].Value = listadoUsuarios[i].Nombres;
                dgvListadoUsuarios.Rows[i].Cells[2].Value = listadoUsuarios[i].Apellidos;
                dgvListadoUsuarios.Rows[i].Cells[3].Value = listadoUsuarios[i].NombreUsuario;
                dgvListadoUsuarios.Rows[i].Cells[4].Value = listadoUsuarios[i].Clave;
                dgvListadoUsuarios.Rows[i].Cells[5].Value = listadoUsuarios[i].StatusAdmin;
            }
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario ventanaUsuario = new FrmUsuario(ref objetoActualUsuarios);
            ventanaUsuario.Owner = this;
            ventanaUsuario.ShowDialog();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            int idUsuarioAEditar = int.Parse(dgvListadoUsuarios.CurrentRow.Cells[0].Value.ToString());
            FrmUsuario ventanaUsuario = new FrmUsuario(ref objetoActualUsuarios, idUsuarioAEditar);
            ventanaUsuario.Owner = this;
            ventanaUsuario.ShowDialog();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "¿Desea eliminar el usuario?", "Eliminación de usuarios", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)== DialogResult.Yes)
            {
                if (UsuarioBL.Eliminar(int.Parse(dgvListadoUsuarios.SelectedRows[0].Cells[0].Value.ToString())) != 1)
                {
                    MetroMessageBox.Show(this, "El usuario no se eliminó.", "Eliminación de usuarios", MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
                }
                CargarUsuarios();
            } 
        }

        private void txtBuscadorUsuarios_TextChanged(object sender, EventArgs e)
        {
            CargarUsuarios(txtBuscadorUsuarios.Text);
        }

        private void dgvListadoUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListadoUsuarios.SelectedRows.Count>0)
            {
                btnEditarUsuario.Enabled = true;
                btnEliminarUsuario.Enabled = true;
            }
            else
            {
                btnEditarUsuario.Enabled = false;
                btnEliminarUsuario.Enabled = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
