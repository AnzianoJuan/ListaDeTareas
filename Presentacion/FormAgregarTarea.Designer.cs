namespace Presentacion
{
    partial class FormAgregarTarea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarTarea));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxMinFormTarea = new System.Windows.Forms.PictureBox();
            this.pictureBoxCerrarTarea = new System.Windows.Forms.PictureBox();
            this.dataGridViewMostrarUsuarios = new System.Windows.Forms.DataGridView();
            this.textBoxBuscarUsuario = new System.Windows.Forms.TextBox();
            this.pictureBoxBuscar = new System.Windows.Forms.PictureBox();
            this.textBoxTituloTarea = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.comboBoxPrioridad = new System.Windows.Forms.ComboBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinFormTarea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrarTarea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrarUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pictureBoxCerrarTarea);
            this.panel1.Controls.Add(this.pictureBoxMinFormTarea);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 66);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBoxMinFormTarea
            // 
            this.pictureBoxMinFormTarea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinFormTarea.BackgroundImage")));
            this.pictureBoxMinFormTarea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinFormTarea.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinFormTarea.Image")));
            this.pictureBoxMinFormTarea.Location = new System.Drawing.Point(791, 12);
            this.pictureBoxMinFormTarea.Name = "pictureBoxMinFormTarea";
            this.pictureBoxMinFormTarea.Size = new System.Drawing.Size(52, 48);
            this.pictureBoxMinFormTarea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinFormTarea.TabIndex = 4;
            this.pictureBoxMinFormTarea.TabStop = false;
            this.pictureBoxMinFormTarea.Click += new System.EventHandler(this.pictureBoxMinFormTarea_Click);
            // 
            // pictureBoxCerrarTarea
            // 
            this.pictureBoxCerrarTarea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCerrarTarea.BackgroundImage")));
            this.pictureBoxCerrarTarea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCerrarTarea.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCerrarTarea.Image")));
            this.pictureBoxCerrarTarea.Location = new System.Drawing.Point(861, 12);
            this.pictureBoxCerrarTarea.Name = "pictureBoxCerrarTarea";
            this.pictureBoxCerrarTarea.Size = new System.Drawing.Size(52, 48);
            this.pictureBoxCerrarTarea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCerrarTarea.TabIndex = 6;
            this.pictureBoxCerrarTarea.TabStop = false;
            this.pictureBoxCerrarTarea.Click += new System.EventHandler(this.pictureBoxCerrarTarea_Click);
            // 
            // dataGridViewMostrarUsuarios
            // 
            this.dataGridViewMostrarUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMostrarUsuarios.Location = new System.Drawing.Point(387, 131);
            this.dataGridViewMostrarUsuarios.Name = "dataGridViewMostrarUsuarios";
            this.dataGridViewMostrarUsuarios.RowHeadersWidth = 51;
            this.dataGridViewMostrarUsuarios.RowTemplate.Height = 24;
            this.dataGridViewMostrarUsuarios.Size = new System.Drawing.Size(522, 532);
            this.dataGridViewMostrarUsuarios.TabIndex = 1;
            // 
            // textBoxBuscarUsuario
            // 
            this.textBoxBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscarUsuario.Location = new System.Drawing.Point(530, 84);
            this.textBoxBuscarUsuario.Name = "textBoxBuscarUsuario";
            this.textBoxBuscarUsuario.Size = new System.Drawing.Size(246, 28);
            this.textBoxBuscarUsuario.TabIndex = 2;
            // 
            // pictureBoxBuscar
            // 
            this.pictureBoxBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBuscar.Image")));
            this.pictureBoxBuscar.Location = new System.Drawing.Point(492, 84);
            this.pictureBoxBuscar.Name = "pictureBoxBuscar";
            this.pictureBoxBuscar.Size = new System.Drawing.Size(32, 28);
            this.pictureBoxBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBuscar.TabIndex = 3;
            this.pictureBoxBuscar.TabStop = false;
            // 
            // textBoxTituloTarea
            // 
            this.textBoxTituloTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTituloTarea.Location = new System.Drawing.Point(141, 173);
            this.textBoxTituloTarea.Name = "textBoxTituloTarea";
            this.textBoxTituloTarea.Size = new System.Drawing.Size(209, 28);
            this.textBoxTituloTarea.TabIndex = 4;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescripcion.Location = new System.Drawing.Point(141, 245);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(209, 28);
            this.textBoxDescripcion.TabIndex = 5;
            // 
            // comboBoxPrioridad
            // 
            this.comboBoxPrioridad.FormattingEnabled = true;
            this.comboBoxPrioridad.Location = new System.Drawing.Point(141, 324);
            this.comboBoxPrioridad.Name = "comboBoxPrioridad";
            this.comboBoxPrioridad.Size = new System.Drawing.Size(209, 24);
            this.comboBoxPrioridad.TabIndex = 6;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(141, 393);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(209, 24);
            this.comboBoxEstado.TabIndex = 7;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(66, 176);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(60, 25);
            this.labelTitulo.TabIndex = 8;
            this.labelTitulo.Text = "Titulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Prioridad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Usuario";
            // 
            // FormAgregarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(921, 669);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.comboBoxPrioridad);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxTituloTarea);
            this.Controls.Add(this.pictureBoxBuscar);
            this.Controls.Add(this.textBoxBuscarUsuario);
            this.Controls.Add(this.dataGridViewMostrarUsuarios);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(921, 669);
            this.MinimumSize = new System.Drawing.Size(921, 669);
            this.Name = "FormAgregarTarea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAgregarTarea";
            this.Load += new System.EventHandler(this.FormAgregarTarea_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinFormTarea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrarTarea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrarUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxMinFormTarea;
        private System.Windows.Forms.PictureBox pictureBoxCerrarTarea;
        private System.Windows.Forms.DataGridView dataGridViewMostrarUsuarios;
        private System.Windows.Forms.TextBox textBoxBuscarUsuario;
        private System.Windows.Forms.PictureBox pictureBoxBuscar;
        private System.Windows.Forms.TextBox textBoxTituloTarea;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.ComboBox comboBoxPrioridad;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}