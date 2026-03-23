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
            ((System.ComponentModel.ISupportInitialize)(this.dgvmovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // btncerrar
            // 
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Location = new System.Drawing.Point(490, 395);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(82, 33);
            this.btncerrar.TabIndex = 7;
            this.btncerrar.Text = "&Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // dgvmovimientos
            // 
            this.dgvmovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmovimientos.Location = new System.Drawing.Point(34, 87);
            this.dgvmovimientos.Name = "dgvmovimientos";
            this.dgvmovimientos.RowHeadersWidth = 51;
            this.dgvmovimientos.RowTemplate.Height = 24;
            this.dgvmovimientos.Size = new System.Drawing.Size(934, 237);
            this.dgvmovimientos.TabIndex = 6;
            this.dgvmovimientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmovimientos_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-68, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Acción";
            // 
            // cmbaccion
            // 
            this.cmbaccion.BackColor = System.Drawing.Color.White;
            this.cmbaccion.FormattingEnabled = true;
            this.cmbaccion.Location = new System.Drawing.Point(125, 15);
            this.cmbaccion.Name = "cmbaccion";
            this.cmbaccion.Size = new System.Drawing.Size(121, 24);
            this.cmbaccion.TabIndex = 4;
            this.cmbaccion.SelectedIndexChanged += new System.EventHandler(this.cmbaccion_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Acción";
            // 
            // FrmBitacoraDulces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.dgvmovimientos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbaccion);
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
    }
}