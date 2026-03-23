namespace CapaPresentacion
{
    partial class FrmMenuDulceria
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btninventario = new System.Windows.Forms.Button();
            this.btnbitacoradulces = new System.Windows.Forms.Button();
            this.btnproveedores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(157, 284);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(109, 39);
            this.btncerrar.TabIndex = 0;
            this.btncerrar.Text = "&Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu Dulceria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selecciona una opcion";
            // 
            // btninventario
            // 
            this.btninventario.Location = new System.Drawing.Point(67, 126);
            this.btninventario.Name = "btninventario";
            this.btninventario.Size = new System.Drawing.Size(115, 47);
            this.btninventario.TabIndex = 3;
            this.btninventario.Text = "&Inventario";
            this.btninventario.UseVisualStyleBackColor = true;
            this.btninventario.Click += new System.EventHandler(this.btninventario_Click);
            // 
            // btnbitacoradulces
            // 
            this.btnbitacoradulces.Location = new System.Drawing.Point(215, 126);
            this.btnbitacoradulces.Name = "btnbitacoradulces";
            this.btnbitacoradulces.Size = new System.Drawing.Size(136, 47);
            this.btnbitacoradulces.TabIndex = 4;
            this.btnbitacoradulces.Text = "&Movimientos";
            this.btnbitacoradulces.UseVisualStyleBackColor = true;
            this.btnbitacoradulces.Click += new System.EventHandler(this.btnbitacoradulces_Click);
            // 
            // btnproveedores
            // 
            this.btnproveedores.Location = new System.Drawing.Point(121, 191);
            this.btnproveedores.Name = "btnproveedores";
            this.btnproveedores.Size = new System.Drawing.Size(170, 42);
            this.btnproveedores.TabIndex = 5;
            this.btnproveedores.Text = "&Proveedores";
            this.btnproveedores.UseVisualStyleBackColor = true;
            this.btnproveedores.Click += new System.EventHandler(this.btnproveedores_Click);
            // 
            // FrmMenuDulceria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 357);
            this.Controls.Add(this.btnproveedores);
            this.Controls.Add(this.btnbitacoradulces);
            this.Controls.Add(this.btninventario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncerrar);
            this.Name = "FrmMenuDulceria";
            this.Text = "FrmMenuDulceria";
            this.Load += new System.EventHandler(this.FrmMenuDulceria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btninventario;
        private System.Windows.Forms.Button btnbitacoradulces;
        private System.Windows.Forms.Button btnproveedores;
    }
}