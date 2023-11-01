namespace SistemaGestionUI
{
    partial class frmModificarProductoVendido
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
            lblIdProducto = new Label();
            lblCantidadVendida = new Label();
            lblIdVenta = new Label();
            numIdProducto = new NumericUpDown();
            numCantidadVendida = new NumericUpDown();
            numIdVenta = new NumericUpDown();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)numIdProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidadVendida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIdVenta).BeginInit();
            SuspendLayout();
            // 
            // lblIdProducto
            // 
            lblIdProducto.AutoSize = true;
            lblIdProducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdProducto.ForeColor = Color.White;
            lblIdProducto.Location = new Point(281, 67);
            lblIdProducto.Name = "lblIdProducto";
            lblIdProducto.Size = new Size(95, 21);
            lblIdProducto.TabIndex = 28;
            lblIdProducto.Text = "IdProducto";
            lblIdProducto.Click += lblComentarios_Click;
            // 
            // lblCantidadVendida
            // 
            lblCantidadVendida.AutoSize = true;
            lblCantidadVendida.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantidadVendida.ForeColor = Color.White;
            lblCantidadVendida.Location = new Point(281, 153);
            lblCantidadVendida.Name = "lblCantidadVendida";
            lblCantidadVendida.Size = new Size(146, 21);
            lblCantidadVendida.TabIndex = 34;
            lblCantidadVendida.Text = "Cantidad Vendida";
            // 
            // lblIdVenta
            // 
            lblIdVenta.AutoSize = true;
            lblIdVenta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdVenta.ForeColor = Color.White;
            lblIdVenta.Location = new Point(281, 246);
            lblIdVenta.Name = "lblIdVenta";
            lblIdVenta.Size = new Size(146, 21);
            lblIdVenta.TabIndex = 38;
            lblIdVenta.Text = "Cantidad Vendida";
            // 
            // numIdProducto
            // 
            numIdProducto.Location = new Point(281, 91);
            numIdProducto.Name = "numIdProducto";
            numIdProducto.Size = new Size(312, 23);
            numIdProducto.TabIndex = 39;
            // 
            // numCantidadVendida
            // 
            numCantidadVendida.Location = new Point(281, 177);
            numCantidadVendida.Name = "numCantidadVendida";
            numCantidadVendida.Size = new Size(312, 23);
            numCantidadVendida.TabIndex = 40;
            // 
            // numIdVenta
            // 
            numIdVenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numIdVenta.Location = new Point(281, 270);
            numIdVenta.Name = "numIdVenta";
            numIdVenta.Size = new Size(312, 29);
            numIdVenta.TabIndex = 37;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.White;
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(345, 314);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(134, 40);
            btnModificar.TabIndex = 36;
            btnModificar.Text = "GUARDAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // frmModificarProductoVendido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(lblIdProducto);
            Controls.Add(lblCantidadVendida);
            Controls.Add(lblIdVenta);
            Controls.Add(numIdProducto);
            Controls.Add(numCantidadVendida);
            Controls.Add(numIdVenta);
            Controls.Add(btnModificar);
            Name = "frmModificarProductoVendido";
            Text = "frmModificarProductoVendido";
            Load += frmModificarProductoVendido_Load;
            ((System.ComponentModel.ISupportInitialize)numIdProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantidadVendida).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIdVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdProducto;
        private Label lblCantidadVendida;
        private Label lblIdVenta;
        private NumericUpDown numIdProducto;
        private NumericUpDown numCantidadVendida;
        private NumericUpDown numIdVenta;
        private Button btnModificar;
    }
}