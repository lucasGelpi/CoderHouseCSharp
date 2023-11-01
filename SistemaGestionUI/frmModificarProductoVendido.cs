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
    public partial class frmModificarProductoVendido : Form
    {
        public frmModificarProductoVendido(ProductoVendido productoVendido)
        {
            InitializeComponent();
        }
        private ProductoVendido productoVendido;

        public frmModificarProductoVendido(int IdProductoVendido)
        {
            InitializeComponent();

            this.productoVendido = new ProductoVendido();

            var db = new SistemaGestionContext();

            // Query
            this.productoVendido = db.ProductoVendido.Where(x => x.Id.Equals(IdProductoVendido)).SingleOrDefault();
            this.numIdProducto.Value = productoVendido.IdProducto;
            this.numCantidadVendida.Value = productoVendido.CantidadVendida;
            this.numIdVenta.Value = productoVendido.IdVenta;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            productoVendido.IdProducto = (int)numIdProducto.Value;
            productoVendido.CantidadVendida = (int)numCantidadVendida.Value;
            productoVendido.IdVenta = (int)numIdVenta.Value;

            MessageBox.Show("Se grabo Correctamente");
        }

        private void frmModificarProductoVendido_Load(object sender, EventArgs e)
        {
            this.numIdProducto.Value = productoVendido.IdProducto;
            this.numCantidadVendida.Value = productoVendido.CantidadVendida;
            this.numIdVenta.Value = productoVendido.IdVenta;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblComentarios_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}