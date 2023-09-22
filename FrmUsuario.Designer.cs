namespace CapaPresentacion
{
    partial class FrmUsuario
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
            label2 = new Label();
            label3 = new Label();
            label9 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtDocumento = new TextBox();
            txtCorreo = new TextBox();
            txtNombreCompleto = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtClave = new TextBox();
            txtConfirmarClave = new TextBox();
            label10 = new Label();
            cboRol = new ComboBox();
            label11 = new Label();
            cboEstado = new ComboBox();
            btnEditarUsuario = new FontAwesome.Sharp.IconButton();
            btnEliminarUsuario = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(30, 49);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(30, 93);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(31, 9);
            label9.Name = "label9";
            label9.Size = new Size(0, 25);
            label9.TabIndex = 18;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Left;
            label1.Enabled = false;
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(239, 461);
            label1.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(12, 49);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 20;
            label4.Text = "No. Documento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(12, 93);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 21;
            label5.Text = "Nombre Completo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(12, 137);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 22;
            label6.Text = "Correo";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(12, 67);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(212, 23);
            txtDocumento.TabIndex = 23;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(12, 155);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(212, 23);
            txtCorreo.TabIndex = 24;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(12, 111);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(212, 23);
            txtNombreCompleto.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(12, 181);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 26;
            label7.Text = "Contraseña";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(12, 225);
            label8.Name = "label8";
            label8.Size = new Size(124, 15);
            label8.TabIndex = 27;
            label8.Text = "Confirmar Contraseña";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(12, 199);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(212, 23);
            txtClave.TabIndex = 28;
            // 
            // txtConfirmarClave
            // 
            txtConfirmarClave.Location = new Point(12, 243);
            txtConfirmarClave.Name = "txtConfirmarClave";
            txtConfirmarClave.Size = new Size(212, 23);
            txtConfirmarClave.TabIndex = 29;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Location = new Point(12, 269);
            label10.Name = "label10";
            label10.Size = new Size(24, 15);
            label10.TabIndex = 30;
            label10.Text = "Rol";
            // 
            // cboRol
            // 
            cboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRol.FormattingEnabled = true;
            cboRol.Location = new Point(12, 287);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(158, 23);
            cboRol.TabIndex = 31;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(12, 313);
            label11.Name = "label11";
            label11.Size = new Size(42, 15);
            label11.TabIndex = 32;
            label11.Text = "Estado";
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(12, 331);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(158, 23);
            cboEstado.TabIndex = 33;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.BackColor = Color.RoyalBlue;
            btnEditarUsuario.ForeColor = Color.White;
            btnEditarUsuario.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            btnEditarUsuario.IconColor = Color.White;
            btnEditarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditarUsuario.IconSize = 16;
            btnEditarUsuario.Location = new Point(12, 401);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(212, 23);
            btnEditarUsuario.TabIndex = 34;
            btnEditarUsuario.Text = "Editar";
            btnEditarUsuario.TextAlign = ContentAlignment.MiddleRight;
            btnEditarUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.BackColor = Color.Firebrick;
            btnEliminarUsuario.ForeColor = Color.White;
            btnEliminarUsuario.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnEliminarUsuario.IconColor = Color.White;
            btnEliminarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarUsuario.IconSize = 16;
            btnEliminarUsuario.Location = new Point(12, 430);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(212, 23);
            btnEliminarUsuario.TabIndex = 35;
            btnEliminarUsuario.Text = "Eliminar";
            btnEliminarUsuario.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.ForestGreen;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.File;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 16;
            btnGuardar.Location = new Point(12, 372);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(212, 23);
            btnGuardar.TabIndex = 36;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // FrmUsuario
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            BackColor = Color.Black;
            ClientSize = new Size(832, 461);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(btnEditarUsuario);
            Controls.Add(cboEstado);
            Controls.Add(label11);
            Controls.Add(cboRol);
            Controls.Add(label10);
            Controls.Add(txtConfirmarClave);
            Controls.Add(txtClave);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtNombreCompleto);
            Controls.Add(txtCorreo);
            Controls.Add(txtDocumento);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label2);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmUsuario";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmUsuario";
            Load += FrmUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label9;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtDocumento;
        private TextBox txtCorreo;
        private TextBox txtNombreCompleto;
        private Label label7;
        private Label label8;
        private TextBox txtClave;
        private TextBox txtConfirmarClave;
        private Label label10;
        private ComboBox cboRol;
        private Label label11;
        private ComboBox cboEstado;
        private FontAwesome.Sharp.IconButton btnEditarUsuario;
        private FontAwesome.Sharp.IconButton btnEliminarUsuario;
        private FontAwesome.Sharp.IconButton btnGuardar;
        public Label label1;
    }
}