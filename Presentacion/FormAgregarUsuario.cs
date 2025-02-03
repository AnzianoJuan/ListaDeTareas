using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormAgregarUsuario : Form
    {

        private Usuario usuarioN = null;
        private OpenFileDialog archivo = null;


        public FormAgregarUsuario()
        {
            InitializeComponent();
        }

        public FormAgregarUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioN = usuario;

        }

        private void pictureBoxCerrarFormUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pictureBoxMinFormUser_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormAgregarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxAgregarUser_Click(object sender, EventArgs e)
        {
            ListaData data = new ListaData();
     

            try
            {
                if (usuarioN == null)
                    usuarioN = new Usuario();

                if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
                {
                    MessageBox.Show("debe tener Nombre");
                    return;
                }


                if (string.IsNullOrWhiteSpace(textBoxContraseña.Text))
                {
                    MessageBox.Show("debe tener Contraseña");
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
                {
                    MessageBox.Show("debe tener Email");
                    return;
                }

                usuarioN.NombreUsuario = textBoxNombre.Text;
                usuarioN.Contra = textBoxContraseña.Text;
                usuarioN.Email = textBoxEmail.Text;

                //if (contactoN.Id != 0)
                //{
                //    data.modificar(contactoN);
                //    MessageBox.Show("modificado exitosamente");
                //}

                if (usuarioN.UsuarioID == 0)
                {
                    data.AgregarUsuario(usuarioN);
                    MessageBox.Show("creado exitosamente");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
