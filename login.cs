using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            List<Usuario> TEST = new Cn_Usuario().Listar();

            Usuario ousuario = new Cn_Usuario().Listar().FirstOrDefault(u => u.Documento == txtDocumento.Text && u.Clave == txtClave.Text);

            if(ousuario != null )
            {
                Inicio form = new Inicio(ousuario);

                form.Show();
                this.Hide();

                form.FormClosing += frm_cerrando;
            }
            else
            {
                MessageBox.Show("No se encontro al Usuario", "Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }

        private void frm_cerrando(object sender, FormClosingEventArgs e)
        {

            txtDocumento.Text = "";
            txtClave.Text = "";

            this.Show();
        }
    }
}
