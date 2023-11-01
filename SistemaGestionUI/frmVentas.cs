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
            var db = new SistemaGestionContext();

            // Query
            var ventas = db.Venta
                .OrderBy(b => b.Id)
                .ToList();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = ventas;
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
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int codigo = (int)this.dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;

                frmModificarVenta frmModificarVenta = new frmModificarVenta(codigo);
                frmModificarVenta.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FrmCrearVenta_FormClosed);

                frmModificarVenta.ShowDialog();
            }

            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int codigo = (int)this.dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;

                frmEliminarVenta frmEliminarVenta = new frmEliminarVenta(codigo);
                frmEliminarVenta.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FrmCrearVenta_FormClosed);

                frmEliminarVenta.ShowDialog();
            }
        }
    }
}