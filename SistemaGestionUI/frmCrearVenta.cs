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
    public partial class frmCrearVenta : Form
    {
        public frmCrearVenta()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (var context = new SistemaGestionContext())
            {

                var venta = new Venta
                {
                    Comentarios = txtComentarios.Text,
                    IdUsuario = txtUsuario.Text,
                };

                context.Venta.Add(venta);
                context.SaveChanges();
                MessageBox.Show("Se grabo Correctamente");
            }
        }

        private void frmAltaVenta_Load(object sender, EventArgs e)
        {

        }

        private void txtComentarios_TextChanged(object sender, EventArgs e)
        {

        }
    }
}