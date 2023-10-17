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

        private Venta _venta;
        public frmModificarVenta(Venta venta)
        {
            InitializeComponent();
            _venta = venta;
        }

        private void txtComentarios_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmModificarVenta_Load(object sender, EventArgs e)
        {
            this.txtUsuario.Text = _venta.IdUsuario.ToString();
            this.txtComentarios.Text = _venta.Comentarios;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            _venta.Comentarios = txtComentarios.Text;
            _venta.IdUsuario = txtUsuario.Text;

            VentaData.ModificarVenta(_venta);
            MessageBox.Show("Se grabo Correctamente");
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}