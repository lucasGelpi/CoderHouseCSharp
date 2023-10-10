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
    public partial class frmAltaProducto : Form
    {
        public frmAltaProducto()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();

            producto.Descripciones = txtDescripciones.Text;
            producto.Costo = numCosto.Value;
            producto.PrecioVenta = numPrecio.Value;
            producto.Stock = (int)numStock.Value;
            producto.IdUsuario = int.Parse(txtUsuario.Text);

            ProductoData.CrearProducto(producto);
            MessageBox.Show("Se grabo Correctamente");

        }

        private void frmAltaProducto_Load(object sender, EventArgs e)
        {

        }

        private void numPrecio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numStock_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
