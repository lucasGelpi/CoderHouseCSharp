using SistemaGestionData;
using SistemaGestionEntities;
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
    public partial class frmModificarUsuario : Form
    {
        public frmModificarUsuario()
        {
            InitializeComponent();
        }
        private Usuario usuario;

        public frmModificarUsuario(int IDUsuario)
        {
            InitializeComponent();

            this.usuario = new Usuario();

            var db = new SistemaGestionContext();

            // Query
            this.usuario = db.Usuario.Where(x => x.Id.Equals(IDUsuario)).SingleOrDefault();
            txtNombre.Text = usuario.Nombre;
            txtApellido.Text = usuario.Apellido;
            txtNombreUsuario.Text = usuario.NombreUsuario;
            txtContraseña.Text = usuario.Contraseña;
            txtMail.Text = usuario.Mail;
        }


        private void frmModificarUsuario_Load(object sender, EventArgs e)
        {

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            using (var context = new SistemaGestionContext())
            {

                var usuario = context.Usuario.Where(x => x.Id.Equals(this.usuario.Id)).Single();
                usuario.Nombre = txtNombre.Text;
                usuario.Apellido = txtApellido.Text;
                usuario.NombreUsuario = txtNombreUsuario.Text;
                usuario.Contraseña = txtContraseña.Text;
                usuario.Mail = txtMail.Text;

                context.SaveChanges();
            }
        }
    }
}