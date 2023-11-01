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
            dgProductosVendidos = new DataGridView();
            btnEditar = new DataGridViewButtonColumn();
            btnEliminar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            IdProducto = new DataGridViewTextBoxColumn();
            CantidadVendida = new DataGridViewTextBoxColumn();
            IdVenta = new DataGridViewTextBoxColumn();
            productoVendidoBindingSource = new BindingSource(components);
            btnCrear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgProductosVendidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoVendidoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgProductosVendidos
            // 
            dgProductosVendidos.AllowUserToAddRows = false;
            dgProductosVendidos.AllowUserToDeleteRows = false;
            dgProductosVendidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductosVendidos.Columns.AddRange(new DataGridViewColumn[] { btnEditar, btnEliminar, Id, IdProducto, CantidadVendida, IdVenta });
            dgProductosVendidos.Location = new Point(12, 81);
            dgProductosVendidos.Name = "dgProductosVendidos";
            dgProductosVendidos.ReadOnly = true;
            dgProductosVendidos.RowTemplate.Height = 25;
            dgProductosVendidos.Size = new Size(776, 357);
            dgProductosVendidos.TabIndex = 1;
            dgProductosVendidos.CellContentClick += dgProductosVendidos_CellContentClick;
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
            btnCrear.Click += btnCrear_Click;
            // 
            // frmProductoVendido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCrear);
            Controls.Add(dgProductosVendidos);
            Name = "frmProductoVendido";
            Text = "frmProductoVendido";
            ((System.ComponentModel.ISupportInitialize)dgProductosVendidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoVendidoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgProductosVendidos;
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