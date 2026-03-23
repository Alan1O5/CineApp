namespace CapaPresentacion
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(114, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "CINEAPP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "User";
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.LightGray;
            this.txtuser.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtuser.Location = new System.Drawing.Point(31, 133);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(312, 31);
            this.txtuser.TabIndex = 2;
            this.txtuser.TextChanged += new System.EventHandler(this.txtuser_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Clave";
            // 
            // txtclave
            // 
            this.txtclave.BackColor = System.Drawing.Color.LightGray;
            this.txtclave.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclave.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtclave.Location = new System.Drawing.Point(31, 221);
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '*';
            this.txtclave.Size = new System.Drawing.Size(312, 31);
            this.txtclave.TabIndex = 4;
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.BackColor = System.Drawing.Color.DarkRed;
            this.btnsiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsiguiente.FlatAppearance.BorderSize = 0;
            this.btnsiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsiguiente.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsiguiente.ForeColor = System.Drawing.Color.White;
            this.btnsiguiente.Location = new System.Drawing.Point(144, 361);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(105, 29);
            this.btnsiguiente.TabIndex = 5;
            this.btnsiguiente.Text = "&Siguiente";
            this.btnsiguiente.UseVisualStyleBackColor = false;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click_1);
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnsalir.Location = new System.Drawing.Point(268, 365);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 6;
            this.btnsalir.Text = "&Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click_1);
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.DarkGray;
            this.panelLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogin.BackgroundImage")));
            this.panelLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogin.Controls.Add(this.label4);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.btnsalir);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.btnsiguiente);
            this.panelLogin.Controls.Add(this.txtuser);
            this.panelLogin.Controls.Add(this.txtclave);
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Location = new System.Drawing.Point(12, 12);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(375, 405);
            this.panelLogin.TabIndex = 7;
            this.panelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogin_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Login";
            // 
            // FrmLogin
            // 
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(399, 444);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

     
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label label4;
    }
}