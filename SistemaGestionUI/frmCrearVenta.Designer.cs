namespace SistemaGestionUI
{
    partial class frmCrearVenta
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
            txtUsuario = new TextBox();
            lblIdUsuario = new Label();
            txtComentarios = new TextBox();
            lblComentarios = new Label();
            btnModificar = new Button();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(245, 363);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(312, 29);
            txtUsuario.TabIndex = 45;
            // 
            // lblIdUsuario
            // 
            lblIdUsuario.AutoSize = true;
            lblIdUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdUsuario.ForeColor = Color.White;
            lblIdUsuario.Location = new Point(245, 339);
            lblIdUsuario.Name = "lblIdUsuario";
            lblIdUsuario.Size = new Size(88, 21);
            lblIdUsuario.TabIndex = 44;
            lblIdUsuario.Text = "Id Usuario";
            // 
            // txtComentarios
            // 
            txtComentarios.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtComentarios.Location = new Point(245, 58);
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(312, 29);
            txtComentarios.TabIndex = 43;
            txtComentarios.TextChanged += txtComentarios_TextChanged;
            // 
            // lblComentarios
            // 
            lblComentarios.AutoSize = true;
            lblComentarios.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblComentarios.ForeColor = Color.White;
            lblComentarios.Location = new Point(245, 30);
            lblComentarios.Name = "lblComentarios";
            lblComentarios.Size = new Size(107, 21);
            lblComentarios.TabIndex = 38;
            lblComentarios.Text = "Comentarios";
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.White;
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(314, 398);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(134, 40);
            btnModificar.TabIndex = 37;
            btnModificar.Text = "GUARDAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // frmCrearVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(txtUsuario);
            Controls.Add(lblIdUsuario);
            Controls.Add(txtComentarios);
            Controls.Add(lblComentarios);
            Controls.Add(btnModificar);
            Name = "frmCrearVenta";
            Text = "Alta Venta";
            Load += frmAltaVenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numStock;
        private Label label1;
        private TextBox txtUsuario;
        private Label lblIdUsuario;
        private TextBox txtComentarios;
        private NumericUpDown numPrecio;
        private NumericUpDown numCosto;
        private Label label5;
        private Label label3;
        private Label lblComentarios;
        private Button btnModificar;
    }
}