namespace CapaPresentacion
{
    partial class FrmReporteFactura
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
            this.btnsalir = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsalir.Location = new System.Drawing.Point(1185, 561);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(142, 42);
            this.btnsalir.TabIndex = 2;
            this.btnsalir.Text = "&Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.RptFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1333, 553);
            this.reportViewer1.TabIndex = 3;
            //this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // FrmReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 615);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnsalir);
            this.Name = "FrmReporteFactura";
            this.Text = "FrmReporteFactura";
            this.Load += new System.EventHandler(this.FrmReporteFactura_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsalir;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}