using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmRegistrarPedido : Form
    {
        private int idProducto = 0;
        private int stockActual = 0;

        public FrmRegistrarPedido(int idProd, string nombreProd, int stockOriginal, string proveedor)
        {
            CustomUI.LoadDefaultStyle(this); 
            InitializeComponent();

            idProducto = idProd;
            stockActual = stockOriginal;

            txtProducto.Text = nombreProd;
            txtProveedor.Text = proveedor;
            txtstockactual.Text = stockActual.ToString();
        }

        private void FrmRegistrarPedido_Load(object sender, EventArgs e)
        {
            txtcantidad.Focus();
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";

                if (string.IsNullOrWhiteSpace(txtcantidad.Text))
                {
                    MessageBox.Show("Por favor, ingresa la cantidad que deseas pedir al proveedor.", "CineApp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtcantidad.Focus();
                    return;
                }

                int cantidadPedida = Convert.ToInt32(txtcantidad.Text);

                if (cantidadPedida <= 0)
                {
                    MessageBox.Show("La cantidad del pedido debe ser mayor a cero.", "CineApp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtcantidad.Focus();
                    return;
                }

                int stockNuevo = stockActual + cantidadPedida;

                resp = CNDulceria.ActualizarStock(idProducto, stockNuevo);

                if (resp == "OK")
                {
                    MessageBox.Show(
                        $"Pedido registrado correctamente con el proveedor {txtProveedor.Text}.\n\nEl stock de '{txtProducto.Text}' se actualizó de {stockActual} a {stockNuevo}.",
                        "CineApp",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al registrar el pedido: " + resp, "CineApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor ingresa un número válido. Detalle: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}