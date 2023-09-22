namespace CapaPresentacion
{
    partial class Inicio
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
            menu = new MenuStrip();
            menuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            menuMantenedor = new FontAwesome.Sharp.IconMenuItem();
            subMenuCategoria = new FontAwesome.Sharp.IconMenuItem();
            subMenuProducto = new FontAwesome.Sharp.IconMenuItem();
            menuVentas = new FontAwesome.Sharp.IconMenuItem();
            subMenuRegistrarVenta = new FontAwesome.Sharp.IconMenuItem();
            subMenuVerDetalleVentas = new FontAwesome.Sharp.IconMenuItem();
            menuCompras = new FontAwesome.Sharp.IconMenuItem();
            subMenuRegistrarCompra = new FontAwesome.Sharp.IconMenuItem();
            subMenuVerDetalleCompra = new FontAwesome.Sharp.IconMenuItem();
            menuClientes = new FontAwesome.Sharp.IconMenuItem();
            menuProveedores = new FontAwesome.Sharp.IconMenuItem();
            menuReportes = new FontAwesome.Sharp.IconMenuItem();
            menuAcercade = new FontAwesome.Sharp.IconMenuItem();
            menuTitulo = new MenuStrip();
            contenedor = new Panel();
            label1 = new Label();
            label3 = new Label();
            lblUsuario = new Label();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.BackColor = Color.White;
            menu.Items.AddRange(new ToolStripItem[] { menuUsuarios, menuMantenedor, menuVentas, menuCompras, menuClientes, menuProveedores, menuReportes, menuAcercade });
            menu.Location = new Point(0, 82);
            menu.Name = "menu";
            menu.Size = new Size(845, 73);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            menu.ItemClicked += menuStrip1_ItemClicked;
            // 
            // menuUsuarios
            // 
            menuUsuarios.AutoSize = false;
            menuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            menuUsuarios.IconColor = Color.Black;
            menuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuUsuarios.IconSize = 50;
            menuUsuarios.ImageScaling = ToolStripItemImageScaling.None;
            menuUsuarios.Name = "menuUsuarios";
            menuUsuarios.Size = new Size(80, 69);
            menuUsuarios.Text = "Usuarios";
            menuUsuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            menuUsuarios.Click += menuUsuarios_Click;
            // 
            // menuMantenedor
            // 
            menuMantenedor.AutoSize = false;
            menuMantenedor.DropDownItems.AddRange(new ToolStripItem[] { subMenuCategoria, subMenuProducto });
            menuMantenedor.IconChar = FontAwesome.Sharp.IconChar.Tools;
            menuMantenedor.IconColor = Color.Black;
            menuMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuMantenedor.IconSize = 50;
            menuMantenedor.ImageScaling = ToolStripItemImageScaling.None;
            menuMantenedor.Name = "menuMantenedor";
            menuMantenedor.Size = new Size(80, 69);
            menuMantenedor.Text = "Mantenedor";
            menuMantenedor.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // subMenuCategoria
            // 
            subMenuCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuCategoria.IconColor = Color.Black;
            subMenuCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuCategoria.Name = "subMenuCategoria";
            subMenuCategoria.Size = new Size(125, 22);
            subMenuCategoria.Text = "Categoria";
            subMenuCategoria.Click += subMenuCategoria_Click;
            // 
            // subMenuProducto
            // 
            subMenuProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuProducto.IconColor = Color.Black;
            subMenuProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuProducto.Name = "subMenuProducto";
            subMenuProducto.Size = new Size(125, 22);
            subMenuProducto.Text = "Producto";
            subMenuProducto.Click += subMenuProducto_Click;
            // 
            // menuVentas
            // 
            menuVentas.AutoSize = false;
            menuVentas.DropDownItems.AddRange(new ToolStripItem[] { subMenuRegistrarVenta, subMenuVerDetalleVentas });
            menuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            menuVentas.IconColor = Color.Black;
            menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuVentas.IconSize = 50;
            menuVentas.ImageScaling = ToolStripItemImageScaling.None;
            menuVentas.Name = "menuVentas";
            menuVentas.Size = new Size(80, 69);
            menuVentas.Text = "Ventas";
            menuVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // subMenuRegistrarVenta
            // 
            subMenuRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuRegistrarVenta.IconColor = Color.Black;
            subMenuRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuRegistrarVenta.Name = "subMenuRegistrarVenta";
            subMenuRegistrarVenta.Size = new Size(129, 22);
            subMenuRegistrarVenta.Text = "Registrar";
            subMenuRegistrarVenta.Click += subMenuRegistrarVenta_Click;
            // 
            // subMenuVerDetalleVentas
            // 
            subMenuVerDetalleVentas.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuVerDetalleVentas.IconColor = Color.Black;
            subMenuVerDetalleVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuVerDetalleVentas.Name = "subMenuVerDetalleVentas";
            subMenuVerDetalleVentas.Size = new Size(129, 22);
            subMenuVerDetalleVentas.Text = "Ver Detalle";
            subMenuVerDetalleVentas.Click += subMenuVerDetalleVentas_Click;
            // 
            // menuCompras
            // 
            menuCompras.AutoSize = false;
            menuCompras.DropDownItems.AddRange(new ToolStripItem[] { subMenuRegistrarCompra, subMenuVerDetalleCompra });
            menuCompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            menuCompras.IconColor = Color.Black;
            menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuCompras.IconSize = 50;
            menuCompras.ImageScaling = ToolStripItemImageScaling.None;
            menuCompras.Name = "menuCompras";
            menuCompras.Size = new Size(80, 69);
            menuCompras.Text = "Compras";
            menuCompras.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // subMenuRegistrarCompra
            // 
            subMenuRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuRegistrarCompra.IconColor = Color.Black;
            subMenuRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuRegistrarCompra.Name = "subMenuRegistrarCompra";
            subMenuRegistrarCompra.Size = new Size(129, 22);
            subMenuRegistrarCompra.Text = "Registrar";
            subMenuRegistrarCompra.Click += subMenuRegistrarCompra_Click;
            // 
            // subMenuVerDetalleCompra
            // 
            subMenuVerDetalleCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuVerDetalleCompra.IconColor = Color.Black;
            subMenuVerDetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuVerDetalleCompra.Name = "subMenuVerDetalleCompra";
            subMenuVerDetalleCompra.Size = new Size(129, 22);
            subMenuVerDetalleCompra.Text = "Ver Detalle";
            subMenuVerDetalleCompra.Click += subMenuVerDetalleCompra_Click;
            // 
            // menuClientes
            // 
            menuClientes.AutoSize = false;
            menuClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            menuClientes.IconColor = Color.Black;
            menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuClientes.IconSize = 50;
            menuClientes.ImageScaling = ToolStripItemImageScaling.None;
            menuClientes.Name = "menuClientes";
            menuClientes.Size = new Size(80, 69);
            menuClientes.Text = "Clientes";
            menuClientes.TextImageRelation = TextImageRelation.ImageAboveText;
            menuClientes.Click += menuClientes_Click;
            // 
            // menuProveedores
            // 
            menuProveedores.AutoSize = false;
            menuProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            menuProveedores.IconColor = Color.Black;
            menuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuProveedores.IconSize = 50;
            menuProveedores.ImageScaling = ToolStripItemImageScaling.None;
            menuProveedores.Name = "menuProveedores";
            menuProveedores.Size = new Size(80, 69);
            menuProveedores.Text = "Proveedores";
            menuProveedores.TextImageRelation = TextImageRelation.ImageAboveText;
            menuProveedores.Click += menuProveedores_Click;
            // 
            // menuReportes
            // 
            menuReportes.AutoSize = false;
            menuReportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            menuReportes.IconColor = Color.Black;
            menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuReportes.IconSize = 50;
            menuReportes.ImageScaling = ToolStripItemImageScaling.None;
            menuReportes.Name = "menuReportes";
            menuReportes.Size = new Size(80, 69);
            menuReportes.Text = "Reportes";
            menuReportes.TextImageRelation = TextImageRelation.ImageAboveText;
            menuReportes.Click += menuReportes_Click;
            // 
            // menuAcercade
            // 
            menuAcercade.AutoSize = false;
            menuAcercade.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            menuAcercade.IconColor = Color.Black;
            menuAcercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuAcercade.IconSize = 50;
            menuAcercade.ImageScaling = ToolStripItemImageScaling.None;
            menuAcercade.Name = "menuAcercade";
            menuAcercade.Size = new Size(80, 69);
            menuAcercade.Text = "Acerca de";
            menuAcercade.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuTitulo
            // 
            menuTitulo.AutoSize = false;
            menuTitulo.BackColor = Color.SteelBlue;
            menuTitulo.GripStyle = ToolStripGripStyle.Visible;
            menuTitulo.ImeMode = ImeMode.On;
            menuTitulo.Location = new Point(0, 0);
            menuTitulo.Name = "menuTitulo";
            menuTitulo.RightToLeft = RightToLeft.Yes;
            menuTitulo.Size = new Size(845, 82);
            menuTitulo.Stretch = false;
            menuTitulo.TabIndex = 1;
            menuTitulo.TabStop = true;
            menuTitulo.Text = "menuStrip2";
            menuTitulo.ItemClicked += menuTitulo_ItemClicked;
            // 
            // contenedor
            // 
            contenedor.AutoSize = true;
            contenedor.Location = new Point(0, 158);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(848, 481);
            contenedor.TabIndex = 3;
            contenedor.Paint += contenedor_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(50, 25);
            label1.Name = "label1";
            label1.Size = new Size(249, 37);
            label1.TabIndex = 2;
            label1.Text = "Sistema de Ventas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SteelBlue;
            label3.ForeColor = Color.White;
            label3.Location = new Point(686, 47);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 0;
            label3.Text = "Usuario";
            label3.Click += label3_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.SteelBlue;
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(750, 47);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 15);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "lblusuario";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 631);
            Controls.Add(lblUsuario);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(menu);
            Controls.Add(menuTitulo);
            Controls.Add(contenedor);
            MainMenuStrip = menu;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Inicio_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem menuUsuarios;
        private FontAwesome.Sharp.IconMenuItem menuMantenedor;
        private FontAwesome.Sharp.IconMenuItem menuVentas;
        private FontAwesome.Sharp.IconMenuItem menuCompras;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
        private FontAwesome.Sharp.IconMenuItem menuProveedores;
        private FontAwesome.Sharp.IconMenuItem menuReportes;
        private FontAwesome.Sharp.IconMenuItem menuAcercade;
        private Panel contenedor;
        private Label label1;
        private Label label3;
        private MenuStrip menuTitulo;
        private Label lblUsuario;
        private FontAwesome.Sharp.IconMenuItem subMenuCategoria;
        private FontAwesome.Sharp.IconMenuItem subMenuProducto;
        private FontAwesome.Sharp.IconMenuItem subMenuRegistrarVenta;
        private FontAwesome.Sharp.IconMenuItem subMenuVerDetalleVentas;
        private FontAwesome.Sharp.IconMenuItem subMenuRegistrarCompra;
        private FontAwesome.Sharp.IconMenuItem subMenuVerDetalleCompra;
    }
}