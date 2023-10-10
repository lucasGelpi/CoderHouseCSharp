namespace SistemaGestionUI
{
    partial class frmEliminarUsuario
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
            btnGuardar = new Button();
            labelNombre = new Label();
            labelApellido = new Label();
            labelNombreUsuario = new Label();
            labelContraseña = new Label();
            labelMail = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtNombreUsuario = new TextBox();
            txtContraseña = new TextBox();
            txtMail = new TextBox();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(160, 385);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(42, 26);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(51, 15);
            labelNombre.TabIndex = 9;
            labelNombre.Text = "Nombre";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(42, 85);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(51, 15);
            labelApellido.TabIndex = 10;
            labelApellido.Text = "Apellido";
            // 
            // labelNombreUsuario
            // 
            labelNombreUsuario.AutoSize = true;
            labelNombreUsuario.Location = new Point(42, 142);
            labelNombreUsuario.Name = "labelNombreUsuario";
            labelNombreUsuario.Size = new Size(110, 15);
            labelNombreUsuario.TabIndex = 11;
            labelNombreUsuario.Text = "Nombre de Usuario";
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.Location = new Point(42, 199);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(67, 15);
            labelContraseña.TabIndex = 12;
            labelContraseña.Text = "Contraseña";
            // 
            // labelMail
            // 
            labelMail.AutoSize = true;
            labelMail.Location = new Point(42, 260);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(30, 15);
            labelMail.TabIndex = 13;
            labelMail.Text = "Mail";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(42, 44);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(299, 23);
            txtNombre.TabIndex = 9;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(42, 103);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(299, 23);
            txtApellido.TabIndex = 10;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(42, 160);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(299, 23);
            txtNombreUsuario.TabIndex = 11;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(42, 217);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(299, 23);
            txtContraseña.TabIndex = 12;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(42, 278);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(299, 23);
            txtMail.TabIndex = 13;
            // 
            // frmEliminarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(387, 449);
            Controls.Add(btnGuardar);
            Controls.Add(labelNombre);
            Controls.Add(labelApellido);
            Controls.Add(labelNombreUsuario);
            Controls.Add(labelContraseña);
            Controls.Add(labelMail);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtContraseña);
            Controls.Add(txtMail);
            Name = "frmEliminarUsuario";
            Text = "Eliminar Usuario";
            Load += frmEliminarUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Label labelNombre;
        private Label labelApellido;
        private Label labelNombreUsuario;
        private Label labelContraseña;
        private Label labelMail;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtNombreUsuario;
        private TextBox txtContraseña;
        private TextBox txtMail;
    }
}