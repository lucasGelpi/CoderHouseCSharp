namespace SistemaGestionUI
{
    partial class frmProductoVendido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            productoVendidoBindingSource = new BindingSource(components);
            btnCrear = new Button();
            btnEditar = new DataGridViewButtonColumn();
            btnEliminar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            IdProducto = new DataGridViewTextBoxColumn();
            CantidadVendida = new DataGridViewTextBoxColumn();
            IdVenta = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoVendidoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { btnEditar, btnEliminar, Id, IdProducto, CantidadVendida, IdVenta });
            dataGridView1.Location = new Point(12, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 357);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // productoVendidoBindingSource
            // 
            productoVendidoBindingSource.DataSource = typeof(SistemaGestionEntities.ProductoVendido);
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(713, 28);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 2;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click_1;
            // 
            // btnEditar
            // 
            btnEditar.HeaderText = "Editar";
            btnEditar.Name = "btnEditar";
            btnEditar.ReadOnly = true;
            btnEditar.Resizable = DataGridViewTriState.True;
            btnEditar.SortMode = DataGridViewColumnSortMode.Automatic;
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            // 
            // btnEliminar
            // 
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Name = "btnEliminar";
            btnEliminar.ReadOnly = true;
            btnEliminar.Resizable = DataGridViewTriState.True;
            btnEliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // IdProducto
            // 
            IdProducto.DataPropertyName = "IdProducto";
            IdProducto.HeaderText = "IdProducto";
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            // 
            // CantidadVendida
            // 
            CantidadVendida.DataPropertyName = "CantidadVendida";
            CantidadVendida.HeaderText = "CantidadVendida";
            CantidadVendida.Name = "CantidadVendida";
            CantidadVendida.ReadOnly = true;
            // 
            // IdVenta
            // 
            IdVenta.DataPropertyName = "IdVenta";
            IdVenta.HeaderText = "IdVenta";
            IdVenta.Name = "IdVenta";
            IdVenta.ReadOnly = true;
            // 
            // frmProductoVendido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCrear);
            Controls.Add(dataGridView1);
            Name = "frmProductoVendido";
            Text = "frmProductoVendido";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoVendidoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnCrear;
        private BindingSource productoVendidoBindingSource;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewButtonColumn btnEliminar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn CantidadVendida;
        private DataGridViewTextBoxColumn IdVenta;
    }
}