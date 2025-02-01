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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxCerrarFormUser = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinFormUser = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrarFormUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinFormUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label1);
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
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 623);
            this.panel2.TabIndex = 1;
            // 
            // pictureBoxCerrarFormUser
            // 
            this.pictureBoxCerrarFormUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCerrarFormUser.BackgroundImage")));
            this.pictureBoxCerrarFormUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCerrarFormUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCerrarFormUser.Image")));
            this.pictureBoxCerrarFormUser.Location = new System.Drawing.Point(526, 12);
            this.pictureBoxCerrarFormUser.Name = "pictureBoxCerrarFormUser";
            this.pictureBoxCerrarFormUser.Size = new System.Drawing.Size(52, 48);
            this.pictureBoxCerrarFormUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCerrarFormUser.TabIndex = 2;
            this.pictureBoxCerrarFormUser.TabStop = false;
            this.pictureBoxCerrarFormUser.Click += new System.EventHandler(this.pictureBoxCerrarFormUser_Click);
            // 
            // pictureBoxMinFormUser
            // 
            this.pictureBoxMinFormUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinFormUser.BackgroundImage")));
            this.pictureBoxMinFormUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinFormUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinFormUser.Image")));
            this.pictureBoxMinFormUser.Location = new System.Drawing.Point(468, 12);
            this.pictureBoxMinFormUser.Name = "pictureBoxMinFormUser";
            this.pictureBoxMinFormUser.Size = new System.Drawing.Size(52, 48);
            this.pictureBoxMinFormUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinFormUser.TabIndex = 3;
            this.pictureBoxMinFormUser.TabStop = false;
            this.pictureBoxMinFormUser.Click += new System.EventHandler(this.pictureBoxMinFormUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Agregar Usuario";
            // 
            // FormAgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(589, 708);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(589, 708);
            this.MinimumSize = new System.Drawing.Size(589, 708);
            this.Name = "FormAgregarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAgregarUsuario";
            this.Load += new System.EventHandler(this.FormAgregarUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrarFormUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinFormUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxCerrarFormUser;
        private System.Windows.Forms.PictureBox pictureBoxMinFormUser;
        private System.Windows.Forms.Label label1;
    }
}