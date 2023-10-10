using SistemaGestionData;
using SistemaGestionEntities;
using System.Data.SqlClient;

namespace SistemaGestionUI
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            List<Producto> lista = ProductoData.ListarProductos();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = lista;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmAltaProducto frmAltaProducto = new frmAltaProducto();
            frmAltaProducto.FormClosed += FrmAltaProducto_FormClosed;
            frmAltaProducto.ShowDialog();   
        }

        private void FrmAltaProducto_FormClosed(object? sender, FormClosedEventArgs e)
        {
            CargarProductos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            int Id = (int)this.dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
            Producto producto = ProductoData.ListarProductos().Where(x => x.Id == Id).FirstOrDefault();


            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                frmMdificarProducto modificar = new frmMdificarProducto(producto);
                modificar.FormClosed += FrmAltaProducto_FormClosed;
                modificar.ShowDialog();
            }
            else if (this.dataGridView1.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                frmEliminarProducto eliminar = new frmEliminarProducto(producto);
                eliminar.FormClosed += FrmAltaProducto_FormClosed;
                eliminar.ShowDialog();
            }
        }
    }
}