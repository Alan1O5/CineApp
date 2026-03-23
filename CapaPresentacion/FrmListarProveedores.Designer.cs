namespace CapaPresentacion
{
    partial class FrmListarProveedores
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
            this.btneliminar1 = new System.Windows.Forms.Button();
            this.btneditar1 = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.dgvproveedores = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsalir1 = new System.Windows.Forms.Button();
            this.btnbuscar1 = new System.Windows.Forms.Button();
            this.txtbuscar1 = new System.Windows.Forms.TextBox();
            this.cmbfiltro1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproveedores)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btneliminar1
            // 
            this.btneliminar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar1.Location = new System.Drawing.Point(678, 430);
            this.btneliminar1.Name = "btneliminar1";
            this.btneliminar1.Size = new System.Drawing.Size(84, 33);
            this.btneliminar1.TabIndex = 10;
            this.btneliminar1.Text = "&Eliminar";
            this.btneliminar1.UseVisualStyleBackColor = true;
            this.btneliminar1.Click += new System.EventHandler(this.btneliminar1_Click);
            // 
            // btneditar1
            // 
            this.btneditar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneditar1.Location = new System.Drawing.Point(583, 430);
            this.btneditar1.Name = "btneditar1";
            this.btneditar1.Size = new System.Drawing.Size(75, 33);
            this.btneditar1.TabIndex = 9;
            this.btneditar1.Text = "&Editar";
            this.btneditar1.UseVisualStyleBackColor = true;
            this.btneditar1.Click += new System.EventHandler(this.btneditar1_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnuevo.Location = new System.Drawing.Point(489, 430);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 33);
            this.btnnuevo.TabIndex = 8;
            this.btnnuevo.Text = "&Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // dgvproveedores
            // 
            this.dgvproveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproveedores.Location = new System.Drawing.Point(11, 188);
            this.dgvproveedores.Name = "dgvproveedores";
            this.dgvproveedores.RowHeadersWidth = 51;
            this.dgvproveedores.RowTemplate.Height = 24;
            this.dgvproveedores.Size = new System.Drawing.Size(826, 219);
            this.dgvproveedores.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(8, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 192);
            this.panel2.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnsalir1);
            this.groupBox2.Controls.Add(this.btnbuscar1);
            this.groupBox2.Controls.Add(this.txtbuscar1);
            this.groupBox2.Controls.Add(this.cmbfiltro1);
            this.groupBox2.Location = new System.Drawing.Point(12, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(807, 146);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtro";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnsalir1
            // 
            this.btnsalir1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir1.Location = new System.Drawing.Point(696, 2);
            this.btnsalir1.Name = "btnsalir1";
            this.btnsalir1.Size = new System.Drawing.Size(75, 31);
            this.btnsalir1.TabIndex = 3;
            this.btnsalir1.Text = "&Salir";
            this.btnsalir1.UseVisualStyleBackColor = true;
            this.btnsalir1.Click += new System.EventHandler(this.btnsalir1_Click);
            // 
            // btnbuscar1
            // 
            this.btnbuscar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar1.Location = new System.Drawing.Point(615, 2);
            this.btnbuscar1.Name = "btnbuscar1";
            this.btnbuscar1.Size = new System.Drawing.Size(75, 31);
            this.btnbuscar1.TabIndex = 2;
            this.btnbuscar1.Text = "&Buscar";
            this.btnbuscar1.UseVisualStyleBackColor = true;
            this.btnbuscar1.Click += new System.EventHandler(this.btnbuscar1_Click);
            // 
            // txtbuscar1
            // 
            this.txtbuscar1.Location = new System.Drawing.Point(169, 2);
            this.txtbuscar1.Name = "txtbuscar1";
            this.txtbuscar1.Size = new System.Drawing.Size(440, 22);
            this.txtbuscar1.TabIndex = 1;
            // 
            // cmbfiltro1
            // 
            this.cmbfiltro1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbfiltro1.FormattingEnabled = true;
            this.cmbfiltro1.Location = new System.Drawing.Point(42, -3);
            this.cmbfiltro1.Name = "cmbfiltro1";
            this.cmbfiltro1.Size = new System.Drawing.Size(121, 24);
            this.cmbfiltro1.TabIndex = 0;
            this.cmbfiltro1.SelectedIndexChanged += new System.EventHandler(this.cmbfiltro1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Proveedores";
            // 
            // FrmListarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 493);
            this.Controls.Add(this.btneliminar1);
            this.Controls.Add(this.btneditar1);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.dgvproveedores);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Name = "FrmListarProveedores";
            this.Text = "FrmListarProveedores";
            this.Load += new System.EventHandler(this.FrmListarProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproveedores)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btneliminar1;
        private System.Windows.Forms.Button btneditar1;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.DataGridView dgvproveedores;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnsalir1;
        private System.Windows.Forms.Button btnbuscar1;
        private System.Windows.Forms.TextBox txtbuscar1;
        private System.Windows.Forms.ComboBox cmbfiltro1;
        private System.Windows.Forms.Label label2;
    }
}