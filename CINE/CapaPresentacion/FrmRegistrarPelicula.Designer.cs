namespace CapaPresentacion
{
    public partial class FrmRegistrarPelicula
    {
        public bool Insert = false;
        public bool Edit = false;
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtduracion = new System.Windows.Forms.TextBox();
            this.txtclasificacion = new System.Windows.Forms.TextBox();
            this.txtgenero = new System.Windows.Forms.TextBox();
            this.txtidioma = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtidpelicula = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Peliculas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duracion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Clasificación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Genero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Idioma";
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtnombre.Location = new System.Drawing.Point(74, 136);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(134, 26);
            this.txtnombre.TabIndex = 6;
            // 
            // txtduracion
            // 
            this.txtduracion.Location = new System.Drawing.Point(71, 255);
            this.txtduracion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtduracion.Name = "txtduracion";
            this.txtduracion.Size = new System.Drawing.Size(138, 26);
            this.txtduracion.TabIndex = 7;
            // 
            // txtclasificacion
            // 
            this.txtclasificacion.Location = new System.Drawing.Point(71, 402);
            this.txtclasificacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtclasificacion.Name = "txtclasificacion";
            this.txtclasificacion.Size = new System.Drawing.Size(138, 26);
            this.txtclasificacion.TabIndex = 8;
            // 
            // txtgenero
            // 
            this.txtgenero.Location = new System.Drawing.Point(370, 135);
            this.txtgenero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtgenero.Name = "txtgenero";
            this.txtgenero.Size = new System.Drawing.Size(148, 26);
            this.txtgenero.TabIndex = 9;
            // 
            // txtidioma
            // 
            this.txtidioma.Location = new System.Drawing.Point(370, 270);
            this.txtidioma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtidioma.Name = "txtidioma";
            this.txtidioma.Size = new System.Drawing.Size(148, 26);
            this.txtidioma.TabIndex = 10;
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.Location = new System.Drawing.Point(324, 475);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(100, 29);
            this.btnguardar.TabIndex = 11;
            this.btnguardar.Text = "&Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click_1);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.Location = new System.Drawing.Point(460, 475);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(93, 29);
            this.btncancelar.TabIndex = 12;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click_1);
            // 
            // txtidpelicula
            // 
            this.txtidpelicula.Location = new System.Drawing.Point(204, 71);
            this.txtidpelicula.Name = "txtidpelicula";
            this.txtidpelicula.Size = new System.Drawing.Size(100, 26);
            this.txtidpelicula.TabIndex = 13;
            this.txtidpelicula.Visible = false;
            // 
            // FrmRegistrarPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 562);
            this.Controls.Add(this.txtidpelicula);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtidioma);
            this.Controls.Add(this.txtgenero);
            this.Controls.Add(this.txtclasificacion);
            this.Controls.Add(this.txtduracion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmRegistrarPelicula";
            this.Text = "FrmRegistrarPelicula";
            this.Load += new System.EventHandler(this.FrmRegistrarPelicula_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtnombre;
        public System.Windows.Forms.TextBox txtduracion;
        public System.Windows.Forms.TextBox txtclasificacion;
        public System.Windows.Forms.TextBox txtgenero;
        public System.Windows.Forms.TextBox txtidioma;
        public System.Windows.Forms.Button btnguardar;
        public System.Windows.Forms.Button btncancelar;
        public System.Windows.Forms.TextBox txtidpelicula;
    }
}