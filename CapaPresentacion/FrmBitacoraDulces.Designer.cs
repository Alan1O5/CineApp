namespace CapaPresentacion
{
    partial class FrmBitacoraDulces
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
            this.btncerrar = new System.Windows.Forms.Button();
            this.dgvmovimientos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbaccion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnverdetalles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Location = new System.Drawing.Point(551, 494);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(92, 41);
            this.btncerrar.TabIndex = 7;
            this.btncerrar.Text = "&Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // dgvmovimientos
            // 
            this.dgvmovimientos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvmovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmovimientos.Location = new System.Drawing.Point(38, 109);
            this.dgvmovimientos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvmovimientos.Name = "dgvmovimientos";
            this.dgvmovimientos.RowHeadersWidth = 51;
            this.dgvmovimientos.RowTemplate.Height = 24;
            this.dgvmovimientos.Size = new System.Drawing.Size(1051, 346);
            this.dgvmovimientos.TabIndex = 6;
            this.dgvmovimientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmovimientos_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-76, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Acción";
            // 
            // cmbaccion
            // 
            this.cmbaccion.BackColor = System.Drawing.Color.White;
            this.cmbaccion.FormattingEnabled = true;
            this.cmbaccion.Location = new System.Drawing.Point(141, 19);
            this.cmbaccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbaccion.Name = "cmbaccion";
            this.cmbaccion.Size = new System.Drawing.Size(136, 28);
            this.cmbaccion.TabIndex = 4;
            this.cmbaccion.SelectedIndexChanged += new System.EventHandler(this.cmbaccion_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Acción";
            // 
            // btnverdetalles
            // 
            this.btnverdetalles.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnverdetalles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnverdetalles.Location = new System.Drawing.Point(681, 494);
            this.btnverdetalles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnverdetalles.Name = "btnverdetalles";
            this.btnverdetalles.Size = new System.Drawing.Size(208, 41);
            this.btnverdetalles.TabIndex = 9;
            this.btnverdetalles.Text = "&Ver detalle";
            this.btnverdetalles.UseVisualStyleBackColor = true;
            this.btnverdetalles.Click += new System.EventHandler(this.btnverdetalles_Click);
            // 
            // FrmBitacoraDulces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 562);
            this.Controls.Add(this.btnverdetalles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.dgvmovimientos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbaccion);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmBitacoraDulces";
            this.Text = "FrmBitacoraDulces";
            this.Load += new System.EventHandler(this.FrmBitacoraDulces_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmovimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.DataGridView dgvmovimientos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbaccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnverdetalles;
    }
}