namespace CapaPresentacion
{
    partial class FrmRegistrarDulceria
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
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btngenerarqr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(197, 92);
            this.txtidproducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(100, 26);
            this.txtidproducto.TabIndex = 27;
            this.txtidproducto.Visible = false;
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.Location = new System.Drawing.Point(333, 481);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(93, 29);
            this.btncancelar.TabIndex = 26;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.Location = new System.Drawing.Point(197, 481);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(100, 29);
            this.btnguardar.TabIndex = 25;
            this.btnguardar.Text = "&Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(400, 291);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(148, 26);
            this.txtprecio.TabIndex = 24;
            // 
            // txttipo
            // 
            this.txttipo.Location = new System.Drawing.Point(400, 156);
            this.txttipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(148, 26);
            this.txttipo.TabIndex = 23;
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(64, 276);
            this.txtstock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(138, 26);
            this.txtstock.TabIndex = 21;
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtnombre.Location = new System.Drawing.Point(68, 158);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(134, 26);
            this.txtnombre.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Registro de Dulceria";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(400, 368);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 62);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cboProveedor
            // 
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(71, 386);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(148, 28);
            this.cboProveedor.TabIndex = 42;
            this.cboProveedor.SelectedIndexChanged += new System.EventHandler(this.cboProveedor_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Proveedor";
            // 
            // btngenerarqr
            // 
            this.btngenerarqr.Location = new System.Drawing.Point(282, 386);
            this.btngenerarqr.Name = "btngenerarqr";
            this.btngenerarqr.Size = new System.Drawing.Size(97, 44);
            this.btngenerarqr.TabIndex = 43;
            this.btngenerarqr.Text = "Generar";
            this.btngenerarqr.UseVisualStyleBackColor = true;
            this.btngenerarqr.Click += new System.EventHandler(this.btngenerarqr_Click);
            // 
            // FrmRegistrarDulceria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 624);
            this.Controls.Add(this.btngenerarqr);
            this.Controls.Add(this.cboProveedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtidproducto);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmRegistrarDulceria";
            this.Text = "FrmRegistrarDulceria";
            this.Load += new System.EventHandler(this.FrmRegistrarDulceria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtidproducto;
        public System.Windows.Forms.Button btncancelar;
        public System.Windows.Forms.Button btnguardar;
        public System.Windows.Forms.TextBox txtprecio;
        public System.Windows.Forms.TextBox txttipo;
        public System.Windows.Forms.TextBox txtstock;
        public System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btngenerarqr;
    }
}