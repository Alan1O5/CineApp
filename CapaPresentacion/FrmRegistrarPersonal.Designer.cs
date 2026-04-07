namespace CapaPresentacion
{
    partial class FrmRegistrarPersonal
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
            this.txtidusuario = new System.Windows.Forms.TextBox();
            this.cboacceso = new System.Windows.Forms.ComboBox();
            this.txtidempleado = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.rbinactivo = new System.Windows.Forms.RadioButton();
            this.rbactivo = new System.Windows.Forms.RadioButton();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtidusuario
            // 
            this.txtidusuario.Location = new System.Drawing.Point(212, 51);
            this.txtidusuario.Name = "txtidusuario";
            this.txtidusuario.Size = new System.Drawing.Size(101, 22);
            this.txtidusuario.TabIndex = 55;
            this.txtidusuario.Visible = false;
            // 
            // cboacceso
            // 
            this.cboacceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboacceso.FormattingEnabled = true;
            this.cboacceso.Items.AddRange(new object[] {
            "Administrador",
            "Taquilla",
            "Dulceria"});
            this.cboacceso.Location = new System.Drawing.Point(302, 278);
            this.cboacceso.Name = "cboacceso";
            this.cboacceso.Size = new System.Drawing.Size(193, 24);
            this.cboacceso.TabIndex = 53;
            // 
            // txtidempleado
            // 
            this.txtidempleado.Location = new System.Drawing.Point(96, 51);
            this.txtidempleado.Name = "txtidempleado";
            this.txtidempleado.Size = new System.Drawing.Size(101, 22);
            this.txtidempleado.TabIndex = 52;
            this.txtidempleado.Visible = false;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(274, 481);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 51;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(180, 481);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 50;
            this.btnguardar.Text = "&Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // rbinactivo
            // 
            this.rbinactivo.AutoSize = true;
            this.rbinactivo.Location = new System.Drawing.Point(386, 370);
            this.rbinactivo.Name = "rbinactivo";
            this.rbinactivo.Size = new System.Drawing.Size(74, 20);
            this.rbinactivo.TabIndex = 49;
            this.rbinactivo.Text = "Inactivo";
            this.rbinactivo.UseVisualStyleBackColor = true;
            // 
            // rbactivo
            // 
            this.rbactivo.AutoSize = true;
            this.rbactivo.Checked = true;
            this.rbactivo.Location = new System.Drawing.Point(306, 370);
            this.rbactivo.Name = "rbactivo";
            this.rbactivo.Size = new System.Drawing.Size(65, 20);
            this.rbactivo.TabIndex = 48;
            this.rbactivo.TabStop = true;
            this.rbactivo.Text = "Activo";
            this.rbactivo.UseVisualStyleBackColor = true;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(305, 202);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(190, 22);
            this.txtpassword.TabIndex = 47;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(302, 121);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(161, 22);
            this.txtusuario.TabIndex = 46;
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(36, 197);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(161, 22);
            this.txtapellidos.TabIndex = 45;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(36, 121);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(161, 22);
            this.txtnombre.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 43;
            this.label7.Text = "Tipo de Acceso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Seleccione Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Ingrese Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Ingrese Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Registrar Nuevo Personal";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(39, 367);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(190, 22);
            this.txttelefono.TabIndex = 61;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(39, 278);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(190, 22);
            this.txtdireccion.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 59;
            this.label9.Text = "Telefono";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 58;
            this.label10.Text = "Direccion";
            // 
            // FrmRegistrarPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 571);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtidusuario);
            this.Controls.Add(this.cboacceso);
            this.Controls.Add(this.txtidempleado);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.rbinactivo);
            this.Controls.Add(this.rbactivo);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.txtapellidos);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistrarPersonal";
            this.Text = "FrmRegistrarPersonal";
            this.Load += new System.EventHandler(this.FrmRegistrarPersonal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtidusuario;
        public System.Windows.Forms.ComboBox cboacceso;
        public System.Windows.Forms.TextBox txtidempleado;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardar;
        public System.Windows.Forms.RadioButton rbinactivo;
        public System.Windows.Forms.RadioButton rbactivo;
        public System.Windows.Forms.TextBox txtpassword;
        public System.Windows.Forms.TextBox txtusuario;
        public System.Windows.Forms.TextBox txtapellidos;
        public System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txttelefono;
        public System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}