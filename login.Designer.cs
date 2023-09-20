namespace CapaPresentacion
{
    partial class login
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
            label1 = new Label();
            label2 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            txtClave = new TextBox();
            txtDocumento = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnIngresar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.SteelBlue;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(272, 302);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(56, 234);
            label2.Name = "label2";
            label2.Size = new Size(161, 28);
            label2.TabIndex = 1;
            label2.Text = "Sistema de Venta";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.SteelBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Store;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 101;
            iconPictureBox1.Location = new Point(87, 113);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(101, 106);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // txtClave
            // 
            txtClave.BorderStyle = BorderStyle.FixedSingle;
            txtClave.Location = new Point(291, 170);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(271, 23);
            txtClave.TabIndex = 3;
            // 
            // txtDocumento
            // 
            txtDocumento.BorderStyle = BorderStyle.FixedSingle;
            txtDocumento.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDocumento.Location = new Point(293, 84);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(269, 23);
            txtDocumento.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(293, 56);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 5;
            label3.Text = "Num Documento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(296, 143);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 6;
            label4.Text = "Contraseña";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.RoyalBlue;
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatAppearance.BorderColor = Color.Black;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnIngresar.IconColor = Color.White;
            btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIngresar.IconSize = 21;
            btnIngresar.Location = new Point(296, 250);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(115, 25);
            btnIngresar.TabIndex = 7;
            btnIngresar.Text = "Ingresar";
            btnIngresar.TextAlign = ContentAlignment.MiddleRight;
            btnIngresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Firebrick;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = Color.Black;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            btnCancelar.IconColor = Color.White;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 21;
            btnCancelar.Location = new Point(439, 250);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(123, 25);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += iconButton2_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(607, 302);
            Controls.Add(btnCancelar);
            Controls.Add(btnIngresar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtDocumento);
            Controls.Add(txtClave);
            Controls.Add(iconPictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox txtClave;
        private TextBox txtDocumento;
        private Label label3;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private FontAwesome.Sharp.IconButton btnCancelar;
    }
}