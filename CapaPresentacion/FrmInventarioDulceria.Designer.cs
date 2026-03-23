namespace CapaPresentacion
{
    partial class FrmInventarioDulceria
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
            this.dgvdulceria = new System.Windows.Forms.DataGridView();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.bnteditar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.cmbtipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.pictureBoxCodigo = new System.Windows.Forms.PictureBox();
            this.btndescargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdulceria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdulceria
            // 
            this.dgvdulceria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdulceria.Location = new System.Drawing.Point(21, 91);
            this.dgvdulceria.Name = "dgvdulceria";
            this.dgvdulceria.RowHeadersWidth = 51;
            this.dgvdulceria.RowTemplate.Height = 24;
            this.dgvdulceria.Size = new System.Drawing.Size(993, 257);
            this.dgvdulceria.TabIndex = 0;
            this.dgvdulceria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdulceria_SelectionChanged);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(428, 472);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(85, 29);
            this.btnnuevo.TabIndex = 1;
            this.btnnuevo.Text = "&Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(646, 472);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(90, 29);
            this.btneliminar.TabIndex = 2;
            this.btneliminar.Text = "&Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // bnteditar
            // 
            this.bnteditar.Location = new System.Drawing.Point(536, 472);
            this.bnteditar.Name = "bnteditar";
            this.bnteditar.Size = new System.Drawing.Size(88, 29);
            this.bnteditar.TabIndex = 3;
            this.bnteditar.Text = "&Editar";
            this.bnteditar.UseVisualStyleBackColor = true;
            this.bnteditar.Click += new System.EventHandler(this.bnteditar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(681, 12);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(88, 46);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "&Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // cmbtipo
            // 
            this.cmbtipo.FormattingEnabled = true;
            this.cmbtipo.Location = new System.Drawing.Point(86, 32);
            this.cmbtipo.Name = "cmbtipo";
            this.cmbtipo.Size = new System.Drawing.Size(121, 24);
            this.cmbtipo.TabIndex = 6;
            this.cmbtipo.SelectedIndexChanged += new System.EventHandler(this.cmbtipo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tipo";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(225, 34);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(450, 22);
            this.txtbuscar.TabIndex = 8;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // pictureBoxCodigo
            // 
            this.pictureBoxCodigo.Location = new System.Drawing.Point(38, 369);
            this.pictureBoxCodigo.Name = "pictureBoxCodigo";
            this.pictureBoxCodigo.Size = new System.Drawing.Size(169, 50);
            this.pictureBoxCodigo.TabIndex = 9;
            this.pictureBoxCodigo.TabStop = false;
            // 
            // btndescargar
            // 
            this.btndescargar.Location = new System.Drawing.Point(38, 426);
            this.btndescargar.Name = "btndescargar";
            this.btndescargar.Size = new System.Drawing.Size(120, 32);
            this.btndescargar.TabIndex = 10;
            this.btndescargar.Text = "&Descargar";
            this.btndescargar.UseVisualStyleBackColor = true;
            this.btndescargar.Click += new System.EventHandler(this.btndescargar_Click);
            // 
            // FrmInventarioDulceria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 527);
            this.Controls.Add(this.btndescargar);
            this.Controls.Add(this.pictureBoxCodigo);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbtipo);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.bnteditar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.dgvdulceria);
            this.Name = "FrmInventarioDulceria";
            this.Text = "FrmInventarioDulceria";
            this.Load += new System.EventHandler(this.FrmInventarioDulceria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdulceria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCodigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdulceria;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button bnteditar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.ComboBox cmbtipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.PictureBox pictureBoxCodigo;
        private System.Windows.Forms.Button btndescargar;
    }
}