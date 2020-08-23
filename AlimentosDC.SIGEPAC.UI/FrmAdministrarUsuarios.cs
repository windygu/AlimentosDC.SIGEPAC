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
    public partial class FrmAdministrarUsuarios : MetroForm
    {
        public FrmAdministrarUsuarios()
        {
            InitializeComponent();
        }

        private void FrmAdministrarUsuarios_Load(object sender, EventArgs e)
        {
            List<Usuario> listadoUsuarios = UsuarioBL.ObtenerTodos();
            for (int i = 0; i < listadoUsuarios.Count; i++)
            {
                dgvListadoUsuarios.Rows.Add();
                dgvListadoUsuarios.Rows[i].Cells[0].Value = listadoUsuarios[i].Id;
                dgvListadoUsuarios.Rows[i].Cells[1].Value = listadoUsuarios[i].Nombres;
                dgvListadoUsuarios.Rows[i].Cells[2].Value = listadoUsuarios[i].Apellidos;
                dgvListadoUsuarios.Rows[i].Cells[3].Value = listadoUsuarios[i].NombreUsuario;
                dgvListadoUsuarios.Rows[i].Cells[4].Value = listadoUsuarios[i].Clave;
                dgvListadoUsuarios.Rows[i].Cells[5].Value = listadoUsuarios[i].StatusAdmin;
                dgvListadoUsuarios.Rows[i].Cells[6].Value = listadoUsuarios[i].Imagen;
            }
            dgvListadoUsuarios.ClearSelection();
        }
    }
}
