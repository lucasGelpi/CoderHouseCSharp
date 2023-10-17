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
    public partial class frmCrearProducto : Form
    {
        public frmCrearProducto()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (var context = new SistemaGestionContext())
            {

                var producto = new Producto
                {
                    Descripciones = txtDescripciones.Text,
                    Costo = numCosto.Value,
                    PrecioVenta = numPrecio.Value,
                    Stock = (int)numStock.Value,
                    IdUsuario = txtUsuario.Text,
            };

                context.Producto.Add(producto);
                context.SaveChanges();
                MessageBox.Show("Se grabo Correctamente");
            }

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