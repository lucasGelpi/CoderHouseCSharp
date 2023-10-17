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
        public frmEliminarVenta()
        {
            InitializeComponent();
        }
        private Venta _venta;
        public frmEliminarVenta(Venta venta)
        {
            InitializeComponent();
            _venta = venta;
        }
        private void frmEliminarVenta_Load(object sender, EventArgs e)
        {
            this.txtUsuario.Text = _venta.IdUsuario.ToString();
            this.txtComentarios.Text = _venta.Comentarios;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            VentaData.EliminarVenta(_venta);
            MessageBox.Show("Se grabo Correctamente");
        }
    }
}