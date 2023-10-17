namespace SistemaGestionUI
{
    partial class frmVentas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Comentarios = new DataGridViewTextBoxColumn();
            IdUsuario = new DataGridViewTextBoxColumn();
            btnEditar = new DataGridViewButtonColumn();
            btnEliminar = new DataGridViewButtonColumn();
            ventaBindingSource = new BindingSource(components);
            btnCrear = new Button();
            ventaBindingSource1 = new BindingSource(components);
            ventaBindingSource2 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ventaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ventaBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ventaBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Comentarios, IdUsuario, btnEditar, btnEliminar });
            dataGridView1.Location = new Point(12, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 357);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Comentarios
            // 
            Comentarios.DataPropertyName = "Comentarios";
            Comentarios.HeaderText = "Comentarios";
            Comentarios.Name = "Comentarios";
            Comentarios.ReadOnly = true;
            // 
            // IdUsuario
            // 
            IdUsuario.DataPropertyName = "IdUsuario";
            IdUsuario.HeaderText = "IdUsuario";
            IdUsuario.Name = "IdUsuario";
            IdUsuario.ReadOnly = true;
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
            // ventaBindingSource
            // 
            ventaBindingSource.DataSource = typeof(SistemaGestionEntities.Venta);
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(694, 23);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 1;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // ventaBindingSource1
            // 
            ventaBindingSource1.DataSource = typeof(SistemaGestionEntities.Venta);
            // 
            // ventaBindingSource2
            // 
            ventaBindingSource2.DataSource = typeof(SistemaGestionEntities.Venta);
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCrear);
            Controls.Add(dataGridView1);
            Name = "frmVentas";
            Text = "Ventas";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ventaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ventaBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ventaBindingSource2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnCrear;
        private BindingSource ventaBindingSource;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Comentarios;
        private DataGridViewTextBoxColumn IdUsuario;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewButtonColumn btnEliminar;
        private BindingSource ventaBindingSource1;
        private BindingSource ventaBindingSource2;
    }
}