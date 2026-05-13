namespace CapaPresentacion
{
    partial class FrmPuntoVenta
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
            this.dgvcarrito = new System.Windows.Forms.DataGridView();
            this.btncobrar = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcarrito
            // 
            this.dgvcarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvcarrito.Location = new System.Drawing.Point(20, 36);
            this.dgvcarrito.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvcarrito.Name = "dgvcarrito";
            this.dgvcarrito.RowHeadersWidth = 51;
            this.dgvcarrito.RowTemplate.Height = 24;
            this.dgvcarrito.Size = new System.Drawing.Size(574, 549);
            this.dgvcarrito.TabIndex = 0;
            this.dgvcarrito.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcarrito_CellContentClick);
            // 
            // btncobrar
            // 
            this.btncobrar.Location = new System.Drawing.Point(622, 664);
            this.btncobrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncobrar.Name = "btncobrar";
            this.btncobrar.Size = new System.Drawing.Size(127, 45);
            this.btncobrar.TabIndex = 1;
            this.btncobrar.Text = "&Cobrar";
            this.btncobrar.UseVisualStyleBackColor = true;
            this.btncobrar.Click += new System.EventHandler(this.btncobrar_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(394, 592);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(0, 20);
            this.lbltotal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 592);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "TOTAL";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(29, 596);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(156, 26);
            this.txtcodigo.TabIndex = 4;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            this.txtcodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodigo_KeyDown);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(444, 664);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(127, 45);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "&Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvProductos.Location = new System.Drawing.Point(645, 41);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(522, 542);
            this.dgvProductos.TabIndex = 6;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellDoubleClick);
            // 
            // FrmPuntoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 724);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.btncobrar);
            this.Controls.Add(this.dgvcarrito);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPuntoVenta";
            this.Text = "FrmPuntoVenta";
            this.Load += new System.EventHandler(this.FrmPuntoVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcarrito;
        private System.Windows.Forms.Button btncobrar;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.DataGridView dgvProductos;
    }
}