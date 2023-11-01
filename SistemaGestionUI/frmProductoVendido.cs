using SistemaGestionData;
using SistemaGestionEntities;
using SistemaGestionUI;
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
    public partial class frmProductoVendido : Form
    {
        public frmProductoVendido()
        {
            InitializeComponent();
        }

        private void frmProductosVendidos_Load(object sender, EventArgs e)
        {
            CargarProductosVendidos();
        }

        private void CargarProductosVendidos()
        {
            List<ProductoVendido> lista = ProductoVendidoData.ListarProductosVendidos();
            dgProductosVendidos.AutoGenerateColumns = false;
            dgProductosVendidos.DataSource = lista;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmCrearProductoVendido productoVendido = new frmCrearProductoVendido();
            productoVendido.FormClosed += ProductoVendido_FormClosed;
            productoVendido.ShowDialog();
        }

        private void ProductoVendido_FormClosed(object? sender, FormClosedEventArgs e)
        {
            CargarProductosVendidos();
        }

        private void dgProductosVendidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;
            int Id = (int)this.dgProductosVendidos.Rows[e.RowIndex].Cells["Id"].Value;
            ProductoVendido productovendido = ProductoVendidoData.ListarProductosVendidos().Where(x => x.Id == Id).FirstOrDefault();


            if (this.dgProductosVendidos.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                frmModificarProductoVendido modificar = new frmModificarProductoVendido(productovendido);
                modificar.FormClosed += ProductoVendido_FormClosed;
                modificar.ShowDialog();
            }
            else if (this.dgProductosVendidos.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                frmEliminarProductoVendido eliminar = new frmEliminarProductoVendido(productovendido);
                eliminar.FormClosed += ProductoVendido_FormClosed;
                eliminar.ShowDialog();
            }
        }
    }
}