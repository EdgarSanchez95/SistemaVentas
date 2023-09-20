using CapaEntidad;
using CapaNegocio;
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem menuActivo = null;
        private static Form formularioActivo = null;

        public Inicio(Usuario objusuario)
        {
            usuarioActual = objusuario;
            InitializeComponent();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuTitulo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> listaPermisos = new Cn_Permiso().Listar(usuarioActual.IdUsuario);

            foreach (IconMenuItem iconmenu in menu.Items)
            {
                bool encontrado = listaPermisos.Any(m => m.NombreMenu == iconmenu.Name);

                if(encontrado == false)
                {
                    iconmenu.Visible = false;
                }
            }



            lblUsuario.Text = usuarioActual.NombreCompleto;
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.White;

            }
            menu.BackColor = Color.Silver;
            menuActivo = menu;

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;
            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmUsuario());
        }

        private void subMenuCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuMantenedor, new FrmCategoria());
        }

        private void subMenuProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuMantenedor, new FrmProducto());
        }

        private void subMenuRegistrarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuVentas, new FrmVentas());
        }

        private void subMenuVerDetalleVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuVentas, new FrmDetalleVenta());
        }

        private void subMenuRegistrarCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuCompras, new FrmCompras());
        }

        private void subMenuVerDetalleCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuCompras, new FrmDetalleCompra());
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmClientes());
        }

        private void menuProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmProveedores());
        }

        private void menuReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmReportes());
        }
    }
}