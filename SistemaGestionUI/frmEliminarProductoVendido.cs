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
    public partial class frmEliminarProductoVendido : Form
    {
        public frmEliminarProductoVendido()
        {
            InitializeComponent();
        }

        private ProductoVendido _productoVendido;
        public frmEliminarProductoVendido(ProductoVendido productoVendido)
        {
            InitializeComponent();
            _productoVendido = productoVendido;
        }
        private void frmEliminarProductoVendido_Load(object sender, EventArgs e)
        {
            this.numIdProducto.Value = _productoVendido.IdProducto;
            this.numCantidadVendida.Value = _productoVendido.CantidadVendida;
            this.numIdVenta.Value = _productoVendido.IdVenta;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            ProductoVendidoData.EliminarProductoVendido(_productoVendido);
            MessageBox.Show("Se grabo Correctamente");
        }
    }
}