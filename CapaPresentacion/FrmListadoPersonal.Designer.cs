namespace CapaPresentacion
{
    partial class FrmListadoPersonal
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
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.dlistado = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnusuario = new System.Windows.Forms.RadioButton();
            this.rbtnnombre = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnreporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dlistado)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnnuevo
            // 
            this.btnnuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnuevo.Location = new System.Drawing.Point(528, 494);
            this.btnnuevo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(86, 32);
            this.btnnuevo.TabIndex = 17;
            this.btnnuevo.Text = "&Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btneliminar.Location = new System.Drawing.Point(712, 494);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(86, 32);
            this.btneliminar.TabIndex = 16;
            this.btneliminar.Text = "&Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btneditar.Location = new System.Drawing.Point(620, 494);
            this.btneditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(86, 32);
            this.btneditar.TabIndex = 15;
            this.btneditar.Text = "&Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // dlistado
            // 
            this.dlistado.AllowUserToAddRows = false;
            this.dlistado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dlistado.Location = new System.Drawing.Point(46, 198);
            this.dlistado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dlistado.Name = "dlistado";
            this.dlistado.RowHeadersWidth = 51;
            this.dlistado.RowTemplate.Height = 24;
            this.dlistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dlistado.Size = new System.Drawing.Size(890, 270);
            this.dlistado.TabIndex = 14;
            this.dlistado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dlistado_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnreporte);
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.btnbuscar);
            this.panel1.Controls.Add(this.txtbuscar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(30, 72);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 101);
            this.panel1.TabIndex = 13;
            // 
            // btnsalir
            // 
            this.btnsalir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnsalir.Location = new System.Drawing.Point(723, 48);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(86, 32);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "&Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnbuscar.Location = new System.Drawing.Point(608, 48);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(86, 32);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.Text = "&Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(262, 48);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(338, 26);
            this.txtbuscar.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnusuario);
            this.groupBox1.Controls.Add(this.rbtnnombre);
            this.groupBox1.Location = new System.Drawing.Point(3, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(252, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterio de busqueda";
            // 
            // rbtnusuario
            // 
            this.rbtnusuario.AutoSize = true;
            this.rbtnusuario.Location = new System.Drawing.Point(124, 44);
            this.rbtnusuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnusuario.Name = "rbtnusuario";
            this.rbtnusuario.Size = new System.Drawing.Size(89, 24);
            this.rbtnusuario.TabIndex = 3;
            this.rbtnusuario.Text = "Usuario";
            this.rbtnusuario.UseVisualStyleBackColor = true;
            // 
            // rbtnnombre
            // 
            this.rbtnnombre.AutoSize = true;
            this.rbtnnombre.Checked = true;
            this.rbtnnombre.Location = new System.Drawing.Point(7, 44);
            this.rbtnnombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnnombre.Name = "rbtnnombre";
            this.rbtnnombre.Size = new System.Drawing.Size(90, 24);
            this.rbtnnombre.TabIndex = 1;
            this.rbtnnombre.TabStop = true;
            this.rbtnnombre.Text = "Nombre";
            this.rbtnnombre.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Personal";
            // 
            // btnreporte
            // 
            this.btnreporte.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnreporte.Location = new System.Drawing.Point(832, 48);
            this.btnreporte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(95, 32);
            this.btnreporte.TabIndex = 4;
            this.btnreporte.Text = "&Reporte";
            this.btnreporte.UseVisualStyleBackColor = true;
            this.btnreporte.Click += new System.EventHandler(this.btnreporte_Click);
            // 
            // FrmListadoPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 564);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.dlistado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmListadoPersonal";
            this.Text = "FrmListadoPersonal";
            this.Load += new System.EventHandler(this.FrmListadoPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dlistado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.DataGridView dlistado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnusuario;
        private System.Windows.Forms.RadioButton rbtnnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnreporte;
    }
}