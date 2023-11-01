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
    public partial class frmModificarVenta : Form
    {
        public frmModificarVenta()
        {
            InitializeComponent();
        }
        private Venta venta;

        public frmModificarVenta(int IdVenta)
        {
            InitializeComponent();
            this.venta = new Venta();

            var db = new SistemaGestionContext();

            // Query
            this.venta = db.Venta.Where(x => x.Id.Equals(IdVenta)).SingleOrDefault();
            txtUsuario.Text = venta.IdUsuario.ToString();
            txtComentarios.Text = venta.Comentarios;
        }

        private void frmModificarVenta_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (var context = new SistemaGestionContext())
            {

                var venta = context.Venta.Where(x => x.Id.Equals(this.venta.Id)).Single();
                venta.IdUsuario = txtUsuario.Text;
                venta.Comentarios = txtComentarios.Text;

                context.SaveChanges();
            }
        }
    }
}