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
    public partial class frmCrearUsuario : Form
    {
        public frmCrearUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (var context = new SistemaGestionContext())
            {

                var usuario = new Usuario
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    NombreUsuario = txtNombreUsuario.Text,
                    Contraseña = txtContraseña.Text,
                    Mail = txtMail.Text
                };

                context.Usuarios.Add(usuario);
                context.SaveChanges();
            }
        }

        private void frmCrearUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}