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
using CapaDatos;

namespace CapaPresentacion
{
    public partial class FrmRegistrarPedido : Form
    {
        private int idProducto = 0;
        private int stockActual = 0;

        // 1. EL CONSTRUCTOR: Ahora solo pide 3 parámetros (quitamos el string proveedor)
        public FrmRegistrarPedido(int idProd, string nombreProd, int stockOriginal)
        {
            CustomUI.LoadDefaultStyle(this);
            InitializeComponent();

            idProducto = idProd;
            stockActual = stockOriginal;

            txtProducto.Text = nombreProd;
            txtstockactual.Text = stockActual.ToString();
        }

        private void FrmRegistrarPedido_Load(object sender, EventArgs e)
        {
            LlenarProveedores(); // Cargamos la lista al abrir
            txtcantidad.Focus();
        }

        private void LlenarProveedores()
        {
            try
            {
                DataTable dt = CNProveedor.Listar();
                cboProveedor.DataSource = dt;
                cboProveedor.DisplayMember = "nombre";
                cboProveedor.ValueMember = "idproveedor";
                cboProveedor.SelectedIndex = -1; // Para que aparezca vacío al inicio
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message);
            }
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                // VALIDACIONES
                if (cboProveedor.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, selecciona un proveedor.", "CineApp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtcantidad.Text) || !int.TryParse(txtcantidad.Text, out int cantidadPedida) || cantidadPedida <= 0)
                {
                    MessageBox.Show("Ingresa una cantidad válida mayor a cero.", "CineApp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // OBTENER DATOS
                string nombreProveedor = cboProveedor.Text; // Tomamos el nombre del ComboBox
                decimal precioUnitario = 0; // Aquí podrías usar un txtPrecio si lo agregas luego

                // PROCESAR
                string resp = CNDulceria.ProcesarEntradaMercancia(
                    idProducto,
                    txtProducto.Text,
                    cantidadPedida,
                    nombreProveedor,
                    Session.UsuarioActual,
                    precioUnitario
                );

                if (resp.StartsWith("OK"))
                {
                    string folio = resp.Split('|')[1];
                    MessageBox.Show(
                        $"Pedido registrado con el Folio #{folio}.\nProveedor: {nombreProveedor}\nProducto: {txtProducto.Text}",
                        "CineApp", MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error: " + resp, "CineApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // No es necesario código aquí por ahora
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}