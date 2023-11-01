namespace SistemaGestionUI
{
    partial class frmModificarVenta
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
            lblComentarios = new Label();
            txtComentarios = new TextBox();
            label6 = new Label();
            txtUsuario = new TextBox();
            btnModificar = new Button();
            SuspendLayout();
            // 
            // lblComentarios
            // 
            lblComentarios.AutoSize = true;
            lblComentarios.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblComentarios.ForeColor = Color.White;
            lblComentarios.Location = new Point(281, 67);
            lblComentarios.Name = "lblComentarios";
            lblComentarios.Size = new Size(107, 21);
            lblComentarios.TabIndex = 28;
            lblComentarios.Text = "Comentarios";
            // 
            // txtComentarios
            // 
            txtComentarios.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtComentarios.Location = new Point(281, 91);
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(312, 29);
            txtComentarios.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(281, 153);
            label6.Name = "label6";
            label6.Size = new Size(88, 21);
            label6.TabIndex = 34;
            label6.Text = "Id Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(281, 177);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(312, 29);
            txtUsuario.TabIndex = 35;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.White;
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(365, 259);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(134, 40);
            btnModificar.TabIndex = 36;
            btnModificar.Text = "GUARDAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // frmModificarVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModificar);
            Controls.Add(txtUsuario);
            Controls.Add(label6);
            Controls.Add(txtComentarios);
            Controls.Add(lblComentarios);
            Name = "frmModificarVenta";
            Text = "frmModificarVenta";
            Load += frmModificarVenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblComentarios;
        private TextBox txtComentarios;
        private Label label6;
        private TextBox txtUsuario;
        private Button btnModificar;
    }
}