using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace SistemaGestionUI
{
    partial class frmUsuarios
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
            dgUsuarios = new DataGridView();
            btnEditar = new DataGridViewButtonColumn();
            btnEliminar = new DataGridViewButtonColumn();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgUsuarios
            // 
            dgUsuarios.AllowUserToAddRows = false;
            dgUsuarios.AllowUserToDeleteRows = false;
            dgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUsuarios.Columns.AddRange(new DataGridViewColumn[] { btnEditar, btnEliminar });
            dgUsuarios.Location = new Point(12, 68);
            dgUsuarios.Name = "dgUsuarios";
            dgUsuarios.ReadOnly = true;
            dgUsuarios.RowTemplate.Height = 25;
            dgUsuarios.Size = new Size(1039, 374);
            dgUsuarios.TabIndex = 0;
            dgUsuarios.CellContentClick += dgUsuarios_CellContentClick;
            // 
            // btnEditar
            // 
            btnEditar.HeaderText = "Editar";
            btnEditar.Name = "btnEditar";
            btnEditar.ReadOnly = true;
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
            // btnAgregar
            // 
            btnAgregar.Location = new Point(435, 24);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(116, 38);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(1063, 454);
            Controls.Add(btnAgregar);
            Controls.Add(dgUsuarios);
            Name = "frmUsuarios";
            Text = "Usuarios";
            Load += frmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgUsuarios;
        private Button btnAgregar;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewButtonColumn btnEliminar;
    }
}