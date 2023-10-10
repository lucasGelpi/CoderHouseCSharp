using SistemaGestionData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUI
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            var db = new SistemaGestionContext();

            // Query
            var usuarios = db.Usuarios
                .OrderBy(b => b.Id)
                .ToList();

            dgUsuarios.AutoGenerateColumns = true;
            dgUsuarios.DataSource = usuarios;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmCrearUsuario usuarios = new frmCrearUsuario();
            usuarios.FormClosed += Usuario_FormClosed;
            usuarios.ShowDialog();
        }

        private void Usuario_FormClosed(object? sender, FormClosedEventArgs e)
        {
            var db = new SistemaGestionContext();

            // Query
            var usuarios = db.Usuarios
                .OrderBy(b => b.Id)
                .ToList();

            dgUsuarios.AutoGenerateColumns = true;
            dgUsuarios.DataSource = usuarios;
        }

        private void dgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;
            if (this.dgUsuarios.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int codigo = (int)this.dgUsuarios.Rows[e.RowIndex].Cells["Id"].Value;

                frmModificarUsuario frmModificarUsuario = new frmModificarUsuario(codigo);
                frmModificarUsuario.FormClosed += new System.Windows.Forms.FormClosedEventHandler(Usuario_FormClosed);

                frmModificarUsuario.ShowDialog();
            }

            if (this.dgUsuarios.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int codigo = (int)this.dgUsuarios.Rows[e.RowIndex].Cells["Id"].Value;

                frmEliminarUsuario frmEliminarUsuario = new frmEliminarUsuario(codigo);
                frmEliminarUsuario.FormClosed += new System.Windows.Forms.FormClosedEventHandler(Usuario_FormClosed);

                frmEliminarUsuario.ShowDialog();
            }
        }


    }
}
