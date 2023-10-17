using SistemaGestionData;
using SistemaGestionEntities;
using SistemaGestionUI;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaGestionUI
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarVentas();
        }

        private void CargarVentas()
        {
            List<Venta> lista = VentaData.ListarVentas();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = lista;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmCrearVenta frmAltaVenta = new frmCrearVenta();
            frmAltaVenta.FormClosed += FrmCrearVenta_FormClosed;
            frmAltaVenta.ShowDialog();
        }

        private void FrmCrearVenta_FormClosed(object? sender, FormClosedEventArgs e)
        {
            CargarVentas();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            int Id = (int)this.dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
            Venta venta = VentaData.ListarVentas().Where(x => x.Id == Id).FirstOrDefault();


            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                frmModificarVenta modificar = new frmModificarVenta(venta);
                modificar.FormClosed += FrmCrearVenta_FormClosed;
                modificar.ShowDialog();
            }
            else if (this.dataGridView1.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                frmEliminarVenta eliminar = new frmEliminarVenta(venta);
                eliminar.FormClosed += FrmCrearVenta_FormClosed;
                eliminar.ShowDialog();
            }
        }
    }
}