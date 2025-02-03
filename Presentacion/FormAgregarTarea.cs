using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormAgregarTarea : Form
    {

        private List<Usuario> listaDeUsuario;

        public FormAgregarTarea()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void pictureBoxCerrarTarea_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMinFormTarea_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cargar()
        {
            UsuarioData usuarioList = new UsuarioData();

            try
            {
                listaDeUsuario = usuarioList.listarUsuarios();
                dataGridViewMostrarUsuarios.DataSource = null; // 🔹 Limpia antes de asignar datos
                dataGridViewMostrarUsuarios.AutoGenerateColumns = true; // 🔹 Asegura la creación automática de columnas
                dataGridViewMostrarUsuarios.DataSource = listaDeUsuario;

                // 🔹 Ocultar columnas solo si existen
                if (dataGridViewMostrarUsuarios.Columns.Count > 0)
                {
                    if (dataGridViewMostrarUsuarios.Columns.Contains("UsuarioID"))
                        dataGridViewMostrarUsuarios.Columns["UsuarioID"].Visible = false;

                    if (dataGridViewMostrarUsuarios.Columns.Contains("Contraseña"))
                        dataGridViewMostrarUsuarios.Columns["Contraseña"].Visible = false; // 🔹 Ocultar la contraseña

                    if (dataGridViewMostrarUsuarios.Columns.Contains("NombreUsuario"))
                    {
                        dataGridViewMostrarUsuarios.Columns["NombreUsuario"].DisplayIndex = 0;
                        dataGridViewMostrarUsuarios.Columns["NombreUsuario"].HeaderText = "Usuario"; // Renombrar columna
                    }

                    if (dataGridViewMostrarUsuarios.Columns.Contains("Email"))
                        dataGridViewMostrarUsuarios.Columns["Email"].DisplayIndex = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }




        private void ocultarColumnas()
        {
            dataGridViewMostrarUsuarios.Columns["UsuarioID"].Visible = false;
            dataGridViewMostrarUsuarios.Columns["Contra"].Visible = false;

        }

        private void FormAgregarTarea_Load(object sender, EventArgs e)
        {
            cargar();
            ocultarColumnas();
        }
    }
}
