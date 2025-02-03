namespace Presentacion
{
    partial class FormAgregarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxMinFormUser = new System.Windows.Forms.PictureBox();
            this.pictureBoxCerrarFormUser = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.pictureBoxAgregarUser = new System.Windows.Forms.PictureBox();
            this.pictureBoxCerrarForm = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinFormUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrarFormUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAgregarUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrarForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pictureBoxMinFormUser);
            this.panel1.Controls.Add(this.pictureBoxCerrarFormUser);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 76);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBoxMinFormUser
            // 
            this.pictureBoxMinFormUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinFormUser.BackgroundImage")));
            this.pictureBoxMinFormUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinFormUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinFormUser.Image")));
            this.pictureBoxMinFormUser.Location = new System.Drawing.Point(362, 12);
            this.pictureBoxMinFormUser.Name = "pictureBoxMinFormUser";
            this.pictureBoxMinFormUser.Size = new System.Drawing.Size(52, 48);
            this.pictureBoxMinFormUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinFormUser.TabIndex = 3;
            this.pictureBoxMinFormUser.TabStop = false;
            this.pictureBoxMinFormUser.Click += new System.EventHandler(this.pictureBoxMinFormUser_Click);
            // 
            // pictureBoxCerrarFormUser
            // 
            this.pictureBoxCerrarFormUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCerrarFormUser.BackgroundImage")));
            this.pictureBoxCerrarFormUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCerrarFormUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCerrarFormUser.Image")));
            this.pictureBoxCerrarFormUser.Location = new System.Drawing.Point(436, 12);
            this.pictureBoxCerrarFormUser.Name = "pictureBoxCerrarFormUser";
            this.pictureBoxCerrarFormUser.Size = new System.Drawing.Size(52, 48);
            this.pictureBoxCerrarFormUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCerrarFormUser.TabIndex = 2;
            this.pictureBoxCerrarFormUser.TabStop = false;
            this.pictureBoxCerrarFormUser.Click += new System.EventHandler(this.pictureBoxCerrarFormUser_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 623);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(66, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre ";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(218, 144);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(240, 38);
            this.textBoxNombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(83, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(218, 240);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(240, 38);
            this.textBoxEmail.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(26, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contraseña";
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseña.Location = new System.Drawing.Point(218, 328);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(240, 38);
            this.textBoxContraseña.TabIndex = 6;
            // 
            // pictureBoxAgregarUser
            // 
            this.pictureBoxAgregarUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAgregarUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAgregarUser.Image")));
            this.pictureBoxAgregarUser.Location = new System.Drawing.Point(277, 427);
            this.pictureBoxAgregarUser.Name = "pictureBoxAgregarUser";
            this.pictureBoxAgregarUser.Size = new System.Drawing.Size(93, 85);
            this.pictureBoxAgregarUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAgregarUser.TabIndex = 7;
            this.pictureBoxAgregarUser.TabStop = false;
            this.pictureBoxAgregarUser.Click += new System.EventHandler(this.pictureBoxAgregarUser_Click);
            // 
            // pictureBoxCerrarForm
            // 
            this.pictureBoxCerrarForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCerrarForm.BackgroundImage")));
            this.pictureBoxCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCerrarForm.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCerrarForm.Image")));
            this.pictureBoxCerrarForm.Location = new System.Drawing.Point(115, 427);
            this.pictureBoxCerrarForm.Name = "pictureBoxCerrarForm";
            this.pictureBoxCerrarForm.Size = new System.Drawing.Size(79, 85);
            this.pictureBoxCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCerrarForm.TabIndex = 4;
            this.pictureBoxCerrarForm.TabStop = false;
            this.pictureBoxCerrarForm.Click += new System.EventHandler(this.pictureBoxCerrarForm_Click);
            // 
            // FormAgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(499, 639);
            this.Controls.Add(this.pictureBoxCerrarForm);
            this.Controls.Add(this.pictureBoxAgregarUser);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(499, 639);
            this.MinimumSize = new System.Drawing.Size(499, 639);
            this.Name = "FormAgregarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAgregarUsuario";
            this.Load += new System.EventHandler(this.FormAgregarUsuario_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinFormUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrarFormUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAgregarUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrarForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxCerrarFormUser;
        private System.Windows.Forms.PictureBox pictureBoxMinFormUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.PictureBox pictureBoxAgregarUser;
        private System.Windows.Forms.PictureBox pictureBoxCerrarForm;
    }
}