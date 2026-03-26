namespace CapaPresentacion
{
    partial class FrmBackups
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
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.btngenerar = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnrestaurar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(25, 55);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.RowHeadersWidth = 51;
            this.dgvHistorial.RowTemplate.Height = 24;
            this.dgvHistorial.Size = new System.Drawing.Size(752, 353);
            this.dgvHistorial.TabIndex = 0;
            // 
            // btngenerar
            // 
            this.btngenerar.Location = new System.Drawing.Point(401, 434);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(102, 28);
            this.btngenerar.TabIndex = 1;
            this.btngenerar.Text = "&Generar";
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(616, 434);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(124, 29);
            this.btn.TabIndex = 2;
            this.btn.Text = "&Salir";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnrestaurar
            // 
            this.btnrestaurar.Location = new System.Drawing.Point(508, 434);
            this.btnrestaurar.Name = "btnrestaurar";
            this.btnrestaurar.Size = new System.Drawing.Size(102, 28);
            this.btnrestaurar.TabIndex = 3;
            this.btnrestaurar.Text = "&Restaurar";
            this.btnrestaurar.UseVisualStyleBackColor = true;
            this.btnrestaurar.Click += new System.EventHandler(this.btnrestaurar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Historial de Respaldos";
            // 
            // FrmBackups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnrestaurar);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.dgvHistorial);
            this.Name = "FrmBackups";
            this.Text = "FrmBackups";
            this.Load += new System.EventHandler(this.FrmBackups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnrestaurar;
        private System.Windows.Forms.Label label1;
    }
}