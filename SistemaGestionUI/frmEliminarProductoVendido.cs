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
        private ProductoVendido productoVendido;

        public frmEliminarProductoVendido(ProductoVendido productoVendido)
        {
            InitializeComponent();
            this.productoVendido = productoVendido;
        }

        private void frmEliminarProductoVendido_Load(object sender, EventArgs e)
        {
            this.numIdProducto.Value = productoVendido.IdProducto;
            this.numCantidadVendida.Value = productoVendido.CantidadVendida;
            this.numIdVenta.Value = productoVendido.IdVenta;
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Se grabo Correctamente");
        }
    }
}