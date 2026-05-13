using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    partial class FrmListarPeliculas
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsalir1 = new System.Windows.Forms.Button();
            this.btnbuscar1 = new System.Windows.Forms.Button();
            this.txtbuscar1 = new System.Windows.Forms.TextBox();
            this.cmbfiltro1 = new System.Windows.Forms.ComboBox();
            this.dlistado1 = new System.Windows.Forms.DataGridView();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btneditar1 = new System.Windows.Forms.Button();
            this.btneliminar1 = new System.Windows.Forms.Button();
            this.btnreporte = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlistado1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Peliculas";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(19, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(903, 194);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnreporte);
            this.groupBox2.Controls.Add(this.btnsalir1);
            this.groupBox2.Controls.Add(this.btnbuscar1);
            this.groupBox2.Controls.Add(this.txtbuscar1);
            this.groupBox2.Controls.Add(this.cmbfiltro1);
            this.groupBox2.Location = new System.Drawing.Point(12, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(891, 149);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtro";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnsalir1
            // 
            this.btnsalir1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnsalir1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir1.Location = new System.Drawing.Point(772, 3);
            this.btnsalir1.Name = "btnsalir1";
            this.btnsalir1.Size = new System.Drawing.Size(113, 33);
            this.btnsalir1.TabIndex = 3;
            this.btnsalir1.Text = "&Salir";
            this.btnsalir1.UseVisualStyleBackColor = true;
            this.btnsalir1.Click += new System.EventHandler(this.btnsalir1_Click);
            // 
            // btnbuscar1
            // 
            this.btnbuscar1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnbuscar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar1.Location = new System.Drawing.Point(508, 0);
            this.btnbuscar1.Name = "btnbuscar1";
            this.btnbuscar1.Size = new System.Drawing.Size(121, 33);
            this.btnbuscar1.TabIndex = 2;
            this.btnbuscar1.Text = "&Buscar";
            this.btnbuscar1.UseVisualStyleBackColor = true;
            this.btnbuscar1.Click += new System.EventHandler(this.btnbuscar1_Click);
            // 
            // txtbuscar1
            // 
            this.txtbuscar1.Location = new System.Drawing.Point(198, 2);
            this.txtbuscar1.Name = "txtbuscar1";
            this.txtbuscar1.Size = new System.Drawing.Size(284, 26);
            this.txtbuscar1.TabIndex = 1;
            this.txtbuscar1.TextChanged += new System.EventHandler(this.txtbuscar1_TextChanged);
            // 
            // cmbfiltro1
            // 
            this.cmbfiltro1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbfiltro1.FormattingEnabled = true;
            this.cmbfiltro1.Location = new System.Drawing.Point(60, 0);
            this.cmbfiltro1.Name = "cmbfiltro1";
            this.cmbfiltro1.Size = new System.Drawing.Size(121, 28);
            this.cmbfiltro1.TabIndex = 0;
            this.cmbfiltro1.SelectedIndexChanged += new System.EventHandler(this.cmbfiltro1_SelectedIndexChanged);
            // 
            // dlistado1
            // 
            this.dlistado1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dlistado1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dlistado1.Location = new System.Drawing.Point(22, 198);
            this.dlistado1.Name = "dlistado1";
            this.dlistado1.RowHeadersWidth = 51;
            this.dlistado1.RowTemplate.Height = 24;
            this.dlistado1.Size = new System.Drawing.Size(900, 219);
            this.dlistado1.TabIndex = 1;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnuevo.Location = new System.Drawing.Point(464, 450);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(107, 28);
            this.btnnuevo.TabIndex = 2;
            this.btnnuevo.Text = "&Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btneditar1
            // 
            this.btneditar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btneditar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneditar1.Location = new System.Drawing.Point(594, 450);
            this.btneditar1.Name = "btneditar1";
            this.btneditar1.Size = new System.Drawing.Size(113, 28);
            this.btneditar1.TabIndex = 3;
            this.btneditar1.Text = "&Editar";
            this.btneditar1.UseVisualStyleBackColor = true;
            this.btneditar1.Click += new System.EventHandler(this.btneditar1_Click);
            // 
            // btneliminar1
            // 
            this.btneliminar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btneliminar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar1.Location = new System.Drawing.Point(713, 450);
            this.btneliminar1.Name = "btneliminar1";
            this.btneliminar1.Size = new System.Drawing.Size(114, 28);
            this.btneliminar1.TabIndex = 4;
            this.btneliminar1.Text = "&Eliminar";
            this.btneliminar1.UseVisualStyleBackColor = true;
            this.btneliminar1.Click += new System.EventHandler(this.btneliminar1_Click);
            // 
            // btnreporte
            // 
            this.btnreporte.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnreporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreporte.Location = new System.Drawing.Point(641, 1);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(121, 33);
            this.btnreporte.TabIndex = 4;
            this.btnreporte.Text = "&Reporte";
            this.btnreporte.UseVisualStyleBackColor = true;
            this.btnreporte.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmListarPeliculas
            // 
            this.ClientSize = new System.Drawing.Size(1001, 507);
            this.Controls.Add(this.btneliminar1);
            this.Controls.Add(this.btneditar1);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.dlistado1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Name = "FrmListarPeliculas";
            this.Load += new System.EventHandler(this.FrmListarPeliculas_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlistado1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /*private void dlistado1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }*/

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbfiltro1;
        private System.Windows.Forms.Button btnsalir1;
        private System.Windows.Forms.Button btnbuscar1;
        private System.Windows.Forms.TextBox txtbuscar1;
        private System.Windows.Forms.DataGridView dlistado1;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btneditar1;
        private System.Windows.Forms.Button btneliminar1;
        private Button btnreporte;
    }
}