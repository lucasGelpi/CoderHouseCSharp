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
    public partial class frmProductoVendido : Form
    {
        public frmProductoVendido()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarProductoVendido();
        }

        private void CargarProductoVendido()
        {
            List<ProductoVendido> lista = ProductoVendidoData.ListarProductosVendidos();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = lista;
        }

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            frmCrearProductoVendido frmAltaProductoVendido = new frmCrearProductoVendido();
            frmAltaProductoVendido.FormClosed += frmCrearProductoVendido_FormClosed;
            frmAltaProductoVendido.ShowDialog();
        }

        private void frmCrearProductoVendido_FormClosed(object? sender, FormClosedEventArgs e)
        {
            CargarProductoVendido();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            int Id = (int)this.dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
            ProductoVendido productoVendido = ProductoVendidoData.ListarProductosVendidos().Where(x => x.Id == Id).FirstOrDefault();


            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                frmModificarProductoVendido modificar = new frmModificarProductoVendido(productoVendido);
                modificar.FormClosed += frmCrearProductoVendido_FormClosed;
                modificar.ShowDialog();
            }
            else if (this.dataGridView1.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                frmEliminarProductoVendido eliminar = new frmEliminarProductoVendido(productoVendido);
                eliminar.FormClosed += frmCrearProductoVendido_FormClosed;
                eliminar.ShowDialog();
            }
        }
    }
}