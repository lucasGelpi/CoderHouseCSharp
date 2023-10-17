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
    public partial class frmModificarProducto : Form
    {
        public frmModificarProducto(int codigo)
        {
            InitializeComponent();
        }

        private Producto _producto;
        public frmModificarProducto(Producto producto)
        {
            InitializeComponent();
            _producto = producto;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            _producto.Descripciones = txtDescripciones.Text;
            _producto.Costo = numCosto.Value;
            _producto.PrecioVenta = numPrecio.Value;
            _producto.Stock = (int)numStock.Value;
            _producto.IdUsuario = txtUsuario.Text;

            ProductoData.ModificarProducto(_producto);
            MessageBox.Show("Se grabo Correctamente");
        }

        private void frmMdificarProducto_Load(object sender, EventArgs e)
        {
            this.txtUsuario.Text = _producto.IdUsuario.ToString();
            this.txtDescripciones.Text = _producto.Descripciones;
            this.numCosto.Value = _producto.Costo;
            this.numPrecio.Value = _producto.PrecioVenta;
            this.numStock.Value = _producto.Stock;
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