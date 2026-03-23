namespace CapaPresentacion
{
    partial class FrmRegistrarPedido
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
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtstockactual = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.Location = new System.Drawing.Point(310, 385);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(83, 23);
            this.btncancelar.TabIndex = 39;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnconfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconfirmar.Location = new System.Drawing.Point(189, 385);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(89, 23);
            this.btnconfirmar.TabIndex = 38;
            this.btnconfirmar.Text = "&Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = false;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(337, 233);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(132, 22);
            this.txtcantidad.TabIndex = 37;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(337, 125);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(132, 22);
            this.txtProveedor.TabIndex = 36;
            // 
            // txtstockactual
            // 
            this.txtstockactual.Location = new System.Drawing.Point(71, 221);
            this.txtstockactual.Name = "txtstockactual";
            this.txtstockactual.ReadOnly = true;
            this.txtstockactual.Size = new System.Drawing.Size(123, 22);
            this.txtstockactual.TabIndex = 35;
            // 
            // txtProducto
            // 
            this.txtProducto.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtProducto.Location = new System.Drawing.Point(74, 126);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(120, 22);
            this.txtProducto.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Cantidad a pedir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Stock Actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Registro de Pedido Dulceria";
            // 
            // FrmRegistrarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.txtstockactual);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistrarPedido";
            this.Text = "FrmRegistrarPedido";
            this.Load += new System.EventHandler(this.FrmRegistrarPedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btncancelar;
        public System.Windows.Forms.Button btnconfirmar;
        public System.Windows.Forms.TextBox txtcantidad;
        public System.Windows.Forms.TextBox txtProveedor;
        public System.Windows.Forms.TextBox txtstockactual;
        public System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
    }
}