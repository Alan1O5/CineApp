namespace CapaPresentacion
{
    partial class FrmInformes
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
            this.dgvInformes = new System.Windows.Forms.DataGridView();
            this.btncerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInformes
            // 
            this.dgvInformes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInformes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformes.Location = new System.Drawing.Point(30, 45);
            this.dgvInformes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvInformes.Name = "dgvInformes";
            this.dgvInformes.RowHeadersWidth = 51;
            this.dgvInformes.RowTemplate.Height = 24;
            this.dgvInformes.Size = new System.Drawing.Size(959, 435);
            this.dgvInformes.TabIndex = 0;
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Location = new System.Drawing.Point(429, 488);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(153, 42);
            this.btncerrar.TabIndex = 1;
            this.btncerrar.Text = "&Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // FrmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 562);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.dgvInformes);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmInformes";
            this.Text = "FrmInformes";
            this.Load += new System.EventHandler(this.FrmInformes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInformes;
        private System.Windows.Forms.Button btncerrar;
    }
}