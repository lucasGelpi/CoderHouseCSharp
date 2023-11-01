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
    public partial class frmEliminarVenta : Form
    {
        private Venta venta;

        public frmEliminarVenta(int IDVenta)
        {
            InitializeComponent();

            this.venta = new Venta();

            var db = new SistemaGestionContext();

            // Query
            this.venta = db.Venta.Where(x => x.Id.Equals(IDVenta)).SingleOrDefault();
            this.txtUsuario.Text = venta.IdUsuario.ToString();
            this.txtComentarios.Text = venta.Comentarios;
        }

        public frmEliminarVenta()
        {
            InitializeComponent();
        }

        private void frmEliminarVenta_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (var context = new SistemaGestionContext())
            {
                var venta = context.Venta.Where(x => x.Id.Equals(this.venta.Id)).Single();
                context.Remove(venta);
                context.SaveChanges();
            }
        }
    }
}