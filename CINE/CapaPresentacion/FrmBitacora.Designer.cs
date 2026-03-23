using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    partial class FrmBitacora
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
            this.cmbaccion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBitacora = new System.Windows.Forms.DataGridView();
            this.btncerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbaccion
            // 
            this.cmbaccion.BackColor = System.Drawing.Color.White;
            this.cmbaccion.FormattingEnabled = true;
            this.cmbaccion.Items.AddRange(new object[] {
            "Todos",
            "Ediciones",
            "Eliminados"});
            this.cmbaccion.Location = new System.Drawing.Point(105, 12);
            this.cmbaccion.Name = "cmbaccion";
            this.cmbaccion.Size = new System.Drawing.Size(121, 24);
            this.cmbaccion.TabIndex = 0;
            this.cmbaccion.SelectedIndexChanged += new System.EventHandler(this.cmbaccion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Acción";
            // 
            // dgvBitacora
            // 
            this.dgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBitacora.Location = new System.Drawing.Point(36, 84);
            this.dgvBitacora.Name = "dgvBitacora";
            this.dgvBitacora.RowHeadersWidth = 51;
            this.dgvBitacora.RowTemplate.Height = 24;
            this.dgvBitacora.Size = new System.Drawing.Size(934, 237);
            this.dgvBitacora.TabIndex = 2;
            this.dgvBitacora.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBitacora_CellContentClick);
            // 
            // btncerrar
            // 
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Location = new System.Drawing.Point(492, 402);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(75, 23);
            this.btncerrar.TabIndex = 3;
            this.btncerrar.Text = "&Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // FrmBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 450);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.dgvBitacora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbaccion);
            this.Name = "FrmBitacora";
            this.Text = "FrmBitacora";
            this.Load += new System.EventHandler(this.FrmBitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dgvBitacora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbaccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBitacora;
        private System.Windows.Forms.Button btncerrar;
    }
}