namespace SistemaGestionUI
{
    partial class frmEliminarProductoVendido
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
            IdProducto = new Label();
            numIdProducto = new NumericUpDown();
            CantidadVendida = new Label();
            numCantidadVendida = new NumericUpDown();
            IdVenta = new Label();
            numIdVenta = new NumericUpDown();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)numIdProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidadVendida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIdVenta).BeginInit();
            SuspendLayout();
            // 
            // IdProducto
            // 
            IdProducto.AutoSize = true;
            IdProducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            IdProducto.ForeColor = Color.White;
            IdProducto.Location = new Point(238, 60);
            IdProducto.Name = "IdProducto";
            IdProducto.Size = new Size(95, 21);
            IdProducto.TabIndex = 40;
            IdProducto.Text = "IdProducto";
            // 
            // numIdProducto
            // 
            numIdProducto.DecimalPlaces = 2;
            numIdProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numIdProducto.Location = new Point(238, 84);
            numIdProducto.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numIdProducto.Name = "numIdProducto";
            numIdProducto.Size = new Size(151, 29);
            numIdProducto.TabIndex = 42;
            // 
            // CantidadVendida
            // 
            CantidadVendida.AutoSize = true;
            CantidadVendida.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CantidadVendida.ForeColor = Color.White;
            CantidadVendida.Location = new Point(238, 149);
            CantidadVendida.Name = "CantidadVendida";
            CantidadVendida.Size = new Size(142, 21);
            CantidadVendida.TabIndex = 43;
            CantidadVendida.Text = "CantidadVendida";
            // 
            // numCantidadVendida
            // 
            numCantidadVendida.DecimalPlaces = 2;
            numCantidadVendida.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numCantidadVendida.Location = new Point(238, 173);
            numCantidadVendida.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numCantidadVendida.Name = "numCantidadVendida";
            numCantidadVendida.Size = new Size(151, 29);
            numCantidadVendida.TabIndex = 44;
            // 
            // IdVenta
            // 
            IdVenta.AutoSize = true;
            IdVenta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            IdVenta.ForeColor = Color.White;
            IdVenta.Location = new Point(238, 239);
            IdVenta.Name = "IdVenta";
            IdVenta.Size = new Size(69, 21);
            IdVenta.TabIndex = 47;
            IdVenta.Text = "IdVenta";
            // 
            // numIdVenta
            // 
            numIdVenta.DecimalPlaces = 2;
            numIdVenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numIdVenta.Location = new Point(238, 263);
            numIdVenta.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numIdVenta.Name = "numIdVenta";
            numIdVenta.Size = new Size(151, 29);
            numIdVenta.TabIndex = 48;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.White;
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(238, 348);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(134, 40);
            btnModificar.TabIndex = 49;
            btnModificar.Text = "GUARDAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // frmCrearProductoVendido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModificar);
            Controls.Add(numIdVenta);
            Controls.Add(IdVenta);
            Controls.Add(numCantidadVendida);
            Controls.Add(CantidadVendida);
            Controls.Add(numIdProducto);
            Controls.Add(IdProducto);
            Name = "frmCrearProductoVendido";
            Text = "frmCrearProductoVendido";
            Load += frmEliminarProductoVendido_Load;
            ((System.ComponentModel.ISupportInitialize)numIdProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantidadVendida).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIdVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IdProducto;
        private NumericUpDown numIdProducto;
        private Label CantidadVendida;
        private NumericUpDown numCantidadVendida;
        private Label IdVenta;
        private NumericUpDown numIdVenta;
        private Button btnModificar;
    }
}