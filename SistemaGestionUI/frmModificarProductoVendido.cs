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
        public frmModificarProductoVendido()
        {
            InitializeComponent();
        }

        private ProductoVendido _productoVendido;
        public frmModificarProductoVendido(ProductoVendido productoVendido)
        {
            InitializeComponent();
            _productoVendido = productoVendido;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            _productoVendido.IdProducto = (int)numIdProducto.Value;
            _productoVendido.CantidadVendida = (int)numCantidadVendida.Value;
            _productoVendido.IdVenta = (int)numIdVenta.Value;

            ProductoVendidoData.ModificarProductoVendido(_productoVendido);
            MessageBox.Show("Se grabo Correctamente");
        }

        private void frmModificarProductoVendido_Load(object sender, EventArgs e)
        {
            this.numIdProducto.Value = _productoVendido.IdProducto;
            this.numCantidadVendida.Value = _productoVendido.CantidadVendida;
            this.numIdVenta.Value = _productoVendido.IdVenta;
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
    }
}