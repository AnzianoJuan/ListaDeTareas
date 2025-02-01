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
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class FormDefault : Form
    {

        private List<Tarea> listaDeTareas;

        public FormDefault()
        {
            InitializeComponent();
        }


        private void pictureBoxCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {

                if (item.GetType() == typeof(FormAgregarUsuario))
                {
                    MessageBox.Show("ya esta una ventana abierta");
                    return;
                }
            }

            FormAgregarUsuario windowViewProfile = new FormAgregarUsuario();
            windowViewProfile.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void cargar()
        {
            ListaData dataList = new ListaData();

            try
            {
                listaDeTareas = dataList.listarTareas();
                dataGridViewListaTareas.DataSource = listaDeTareas;
                dataGridViewListaTareas.Columns["Titulo"].DisplayIndex = 0;
                dataGridViewListaTareas.Columns["Descripcion"].DisplayIndex = 1;
                dataGridViewListaTareas.Columns["Prioridad"].DisplayIndex = 2;
                dataGridViewListaTareas.Columns["Estado"].DisplayIndex = 3;
                dataGridViewListaTareas.Columns["NombreUsuario"].DisplayIndex = 4;
                dataGridViewListaTareas.Columns["FechaCreacion"].DisplayIndex = 5;
                dataGridViewListaTareas.Columns["FechaCompletada"].DisplayIndex = 6;
                dataGridViewListaTareas.Columns["TareaID"].Visible = false; // Ocultar ID si no es necesario

                dataGridViewListaTareas.Columns["Usuario"].Visible = false; // Oculta la columna del objeto Usuario
                dataGridViewListaTareas.Columns["NombreUsuario"].HeaderText = "Usuario"; // Renombra la columna
                ocultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dataGridViewListaTareas.Columns["TareaID"].Visible = false;
            dataGridViewListaTareas.Columns["FechaCreacion"].Visible = false;

        }

        private void FormDefault_Load(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
