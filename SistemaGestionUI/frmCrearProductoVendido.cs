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
    public partial class frmCrearProductoVendido : Form
    {
        public frmCrearProductoVendido()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (var context = new SistemaGestionContext())
            {

                var productoVendido = new ProductoVendido
                {
                    IdProducto = (int)numIdProducto.Value,
                    CantidadVendida = (int)numCantidadVendida.Value,
                    IdVenta = (int)numIdVenta.Value,
                };

                context.ProductoVendido.Add(productoVendido);
                context.SaveChanges();
                MessageBox.Show("Se grabo Correctamente");
            }
        }

        private void numIdProducto_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numIdVenta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numPrecio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmCrearProductoVendido_Load(object sender, EventArgs e)
        {

        }
    }
}