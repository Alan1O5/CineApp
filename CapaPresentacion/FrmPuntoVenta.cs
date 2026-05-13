using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CapaNegocio;
using CapaDatos;


namespace CapaPresentacion
{
    public partial class FrmPuntoVenta : Form
    {
        private DataTable Carrito = new DataTable();
        private decimal TotalVenta = 0;
        CDVentas objCapaDatos = new CDVentas();

        public FrmPuntoVenta()
        {
            InitializeComponent();
            CustomUI.LoadDefaultStyle(this);
            CrearColumnasCarrito();
        }

        private void CrearColumnasCarrito()
        {
            Carrito.Columns.Add("IdProducto", typeof(int));
            Carrito.Columns.Add("Producto", typeof(string));
            Carrito.Columns.Add("Precio", typeof(decimal));
            Carrito.Columns.Add("Cantidad", typeof(int));
            Carrito.Columns.Add("Subtotal", typeof(decimal));

            dgvcarrito.DataSource = Carrito;

            dgvcarrito.Columns["IdProducto"].Visible = false;
        }

        private void txtcodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                string codigoBuscado = txtcodigo.Text.Trim();
                if (codigoBuscado == "") return;

                DataTable dtProducto = CNDulceria.BuscarPorCodigo(codigoBuscado);

                if (dtProducto.Rows.Count > 0)
                {
                    int id = Convert.ToInt32(dtProducto.Rows[0]["idproducto"]);
                    string nombre = dtProducto.Rows[0]["nombre"].ToString();
                    decimal precio = Convert.ToDecimal(dtProducto.Rows[0]["precio"]); // Ajustado a tu BD
                    int stockDisponible = Convert.ToInt32(dtProducto.Rows[0]["stock"]);

                    // ¡AQUÍ LLAMAMOS A LA MAGIA!
                    AgregarAlCarrito(id, nombre, precio, stockDisponible);

                    txtcodigo.Text = ""; // Limpiamos la caja para el siguiente dulce
                }
                else
                {
                    MessageBox.Show("Código no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcodigo.Text = ""; // Es buena práctica limpiar la caja también si se equivocó
                }
            }
        }
        private void CalcularTotal()
        {
            TotalVenta = 0;
            foreach (DataRow fila in Carrito.Rows)
            {
                TotalVenta += Convert.ToDecimal(fila["Subtotal"]);
            }
            lbltotal.Text = "$ " + TotalVenta.ToString("0.00");
        }

        private void btncobrar_Click(object sender, EventArgs e)
        {
            // Validar que haya algo que cobrar
            if (Carrito.Rows.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.", "Aviso");
                return;
            }

            // --- MEJORA: Confirmación de Cobro y Cálculo de Cambio ---
            // Usamos un InputBox (puedes crear un form pequeño para esto si prefieres algo más estético)
            string montoPagadoTexto = Microsoft.VisualBasic.Interaction.InputBox(
                "Total a pagar: " + TotalVenta.ToString("C") + "\n\nIngrese el efectivo recibido:",
                "Cobro de Venta",
                "0");

            if (string.IsNullOrEmpty(montoPagadoTexto)) return; // Si cancela, no hacemos nada

            decimal montoPagado = Convert.ToDecimal(montoPagadoTexto);

            if (montoPagado < TotalVenta)
            {
                MessageBox.Show("El monto ingresado es insuficiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal cambio = montoPagado - TotalVenta;

            // --- Lógica de Base de Datos ---
            string respuesta = CNVentas.RealizarVenta(TotalVenta, Session.IdEmpleado, Carrito);

            // Suponiendo que 'resultado' es lo que devuelve tu Capa de Negocio/Datos
            string resultado = objCapaDatos.ProcesarVenta(TotalVenta, Session.IdEmpleado, Carrito);

            // Intentamos ver si el resultado es el número de ID
            if (int.TryParse(resultado, out int idTicket))
            {
                FrmReporteFactura frm = new FrmReporteFactura();

                // Cálculos
                decimal valorIva = TotalVenta * 0.16m;
                decimal valorSubtotal = TotalVenta - valorIva;

                // Asignación completa
                frm.DatosTicket = Carrito.Copy();
                frm.Folio = idTicket.ToString(); 
                frm.TotalPagar = TotalVenta.ToString("0.00");
                frm.Subtotal = valorSubtotal.ToString("0.00");
                frm.Iva = valorIva.ToString("0.00");
                frm.Fecha = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                frm.Empleado = "Atendido por: " + Session.UsuarioActual;
                frm.PagoCon = montoPagado.ToString("0.00");
                frm.Cambio = cambio.ToString("0.00");

                // Abrir en el Dash
                FrmDash principal = this.MdiParent as FrmDash;
                if (principal != null) principal.AbrirForm(frm);

                Carrito.Clear();
                CalcularTotal();
            }
            else
            {
                // Si no es un número, es el mensaje de error del catch
                MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvcarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvcarrito.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                Carrito.Rows.RemoveAt(e.RowIndex);
                CalcularTotal();
            }
        }
        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {
        }
        private void FrmPuntoVenta_Load(object sender, EventArgs e)
        {
            CargarCatalogo();
        }
        private void CargarCatalogo()
        {
            dgvProductos.DataSource = CNDulceria.ListarProductosParaVenta();

            // Ocultamos el ID para que se vea limpio
            if (dgvProductos.Columns.Contains("idproducto"))
                dgvProductos.Columns["idproducto"].Visible = false;
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void AgregarAlCarrito(int id, string nombre, decimal precio, int stockDisponible)
        {
            if (stockDisponible <= 0)
            {
                MessageBox.Show("¡Ya no hay stock de " + nombre + "!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool existe = false;
            foreach (DataRow fila in Carrito.Rows)
            {
                if (Convert.ToInt32(fila["IdProducto"]) == id)
                {
                    int cantActual = Convert.ToInt32(fila["Cantidad"]);
                    if (cantActual + 1 > stockDisponible)
                    {
                        MessageBox.Show("No puedes vender más del stock disponible.", "Aviso");
                        return;
                    }

                    fila["Cantidad"] = cantActual + 1;
                    fila["Subtotal"] = (cantActual + 1) * precio;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                Carrito.Rows.Add(new object[] { id, nombre, precio, 1, precio });
            }

            CalcularTotal();
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

                int id = Convert.ToInt32(fila.Cells["idproducto"].Value);
                string nombre = fila.Cells["Producto"].Value.ToString();
                decimal precio = Convert.ToDecimal(fila.Cells["Precio"].Value);
                int stock = Convert.ToInt32(fila.Cells["Stock"].Value);

                // Llamamos al método maestro
                AgregarAlCarrito(id, nombre, precio, stock);
            }
        }
    }
}