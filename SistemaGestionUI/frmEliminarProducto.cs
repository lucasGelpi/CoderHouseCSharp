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
    public partial class frmEliminarProducto : Form
    {
        public frmEliminarProducto()
        {
            InitializeComponent();
        }
        private Producto producto;
        public frmEliminarProducto(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
        }
        private void frmEliminarProducto_Load(object sender, EventArgs e)
        {
            this.txtUsuario.Text = producto.IdUsuario.ToString();
            this.txtDescripciones.Text = producto.Descripciones;
            this.numCosto.Value = producto.Costo;
            this.numPrecio.Value = producto.PrecioVenta;
            this.numStock.Value = producto.Stock;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ProductoData.EliminarProducto(producto.Id);
            MessageBox.Show("Se grabo Correctamente");
        }
    }
}