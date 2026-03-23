namespace CapaPresentacion
{
    partial class FrmAlertaStock
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
            this.dgvalertas = new System.Windows.Forms.DataGridView();
            this.btncerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvalertas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvalertas
            // 
            this.dgvalertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvalertas.Location = new System.Drawing.Point(42, 18);
            this.dgvalertas.Name = "dgvalertas";
            this.dgvalertas.RowHeadersWidth = 51;
            this.dgvalertas.RowTemplate.Height = 24;
            this.dgvalertas.Size = new System.Drawing.Size(949, 230);
            this.dgvalertas.TabIndex = 0;
            this.dgvalertas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvalertas_CellContentClick);
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(464, 275);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(117, 39);
            this.btncerrar.TabIndex = 1;
            this.btncerrar.Text = "&Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // FrmAlertaStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 326);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.dgvalertas);
            this.Name = "FrmAlertaStock";
            this.Text = "FrmAlertaStock";
            this.Load += new System.EventHandler(this.FrmAlertaStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvalertas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvalertas;
        private System.Windows.Forms.Button btncerrar;
    }
}