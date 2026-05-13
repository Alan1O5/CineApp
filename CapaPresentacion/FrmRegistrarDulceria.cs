using CapaDatos;
using CapaNegocio;
using System;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace CapaPresentacion
{
    public partial class FrmRegistrarDulceria : Form
    {
        public int Idproducto = 0;
        public bool Insert = true;
        public bool Edit = false;
        int stockOriginal;

        public FrmRegistrarDulceria()
        {
            CustomUI.LoadDefaultStyle(this);
            InitializeComponent();
        }

        private void FrmRegistrarDulceria_Load(object sender, EventArgs e)
        {
            // 1. Cargar proveedores al iniciar
            CargarProveedores();

            if (Insert)
                btnguardar.Text = "Guardar";
            else if (Edit)
            {
                btnguardar.Text = "Editar";
                stockOriginal = Convert.ToInt32(txtstock.Text);
                // Bloqueamos proveedor en edición si es ajuste manual
                cboProveedor.Enabled = false;
            }
        }

        private void CargarProveedores()
        {
            try
            {
                DataTable dt = CNDulceria.ListarProveedores();
                if (dt != null && dt.Rows.Count > 0)
                {
                    cboProveedor.DataSource = dt;
                    cboProveedor.DisplayMember = "nombre"; // Cambiado a 'nombre' según image_8f4ac3.png
                    cboProveedor.ValueMember = "idproveedor";
                }
                cboProveedor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message);
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validaciones de la Interfaz
                if (string.IsNullOrWhiteSpace(txtnombre.Text) || pictureBox1.Tag == null)
                {
                    MessageBox.Show("Faltan datos o generar el código."); return;
                }

                // 2. Preparación de datos comunes
                decimal precioCompra = decimal.Parse(txtprecio.Text);
                decimal precioVenta = Math.Round(precioCompra * 1.10m, 2);
                int cantidad = string.IsNullOrEmpty(txtstock.Text) ? 0 : Convert.ToInt32(txtstock.Text);
                string textoCodigo = pictureBox1.Tag.ToString();
                string user = string.IsNullOrEmpty(Session.UsuarioActual) ? "Admin" : Session.UsuarioActual;

                string resp = "";

                // 3. Validación de operación: ¿Nuevo o Editar?
                if (Insert)
                {
                    // 1. REGISTRO BASE: Enviamos la 'cantidad' real del formulario para que el stock NO sea cero
                    int idNuevo = CNDulceria.RegistrarBaseYObtenerID(
                        txtnombre.Text.Trim(),
                        txttipo.Text.Trim(),
                        precioVenta,
                        cantidad, // <--- Aquí pasamos la cantidad real que escribiste
                        textoCodigo
                    );

                    if (idNuevo > 0)
                    {
                        // 2. REGISTRO DE MOVIMIENTO: Mandamos 0 en el precio para que la contabilidad sea administrativa
                        resp = CNDulceria.InsertarCompraCompleta(
                            idNuevo,
                            txtnombre.Text.Trim(),
                            cantidad,
                            cboProveedor.Text,
                            user,
                            0m // <--- Forzamos precio 0 para el historial
                        );

                        if (resp.StartsWith("OK"))
                        {
                            // ¡IMPORTANTE! Aquí ya NO llamamos a FrmReporteFactura.
                            // Solo avisamos que se guardó.
                            MessageBox.Show("Producto registrado y stock actualizado.", "Sistema");
                            VolverAlInventario();
                        }
                    }
                }
                else if (Edit)
                {
                    // Para editar, necesitamos el ID que seguramente tienes en un campo oculto o variable
                    int idProd = Convert.ToInt32(txtidproducto.Text);

                    resp = CNDulceria.Editar(
                        idProd,
                        txtnombre.Text.Trim(),
                        txttipo.Text.Trim(),
                        precioVenta,
                        cantidad,
                        textoCodigo
                    );

                    // Opcional: Si el stock cambió durante la edición, podrías registrar un movimiento de ajuste
                    if (resp == "OK" && cantidad != stockOriginal)
                    {
                        string tipoMov = cantidad > stockOriginal ? "ENTRADA" : "SALIDA";
                        CNDulceria.RegistrarMovimiento(txtnombre.Text, tipoMov, Math.Abs(cantidad - stockOriginal), user, "Ajuste por Edición");
                    }
                }

                // 4. Manejo de Respuesta unificado
                if (resp.StartsWith("OK"))
                {
                    // Eliminamos la llamada al reporte (frm.ShowDialog) 
                    // para que solo guarde y se cierre.
                    MessageBox.Show("¡Producto y movimiento registrados correctamente!", "CineApp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VolverAlInventario();
                }
                else
                {
                    string errorReal = string.IsNullOrEmpty(resp) ? "Error de comunicación entre capas." : resp;
                    MessageBox.Show("Error: " + errorReal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el formulario: " + ex.Message);
            }
        }
        private void VolverAlInventario()
        {
            FrmDash principal = this.MdiParent as FrmDash;
            if (principal != null) principal.AbrirForm(new FrmInventarioDulceria());
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e) => VolverAlInventario();

        private void cboProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btngenerarqr_Click(object sender, EventArgs e)
        {
            // Validamos que el nombre no esté vacío
            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                MessageBox.Show("Primero debe ingresar el nombre del producto para generar su código.",
                                "CineApp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnombre.Focus();
                return;
            }

            try
            {
                // Limpiamos el nombre para crear un código válido (sin espacios)
                string textoParaCodigo = txtnombre.Text.Trim().Replace(" ", "_").ToUpper();

                // Generamos la imagen en el PictureBox
                pictureBox1.Image = GeneradorCodigoBarras.Generar(textoParaCodigo);

                // Guardamos el texto generado en el Tag del PictureBox para usarlo al guardar
                pictureBox1.Tag = textoParaCodigo;

                MessageBox.Show("Código de barras generado a partir del nombre.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el código: " + ex.Message);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void GenerarTicketEntrada(string operacion)
        {
            try
            {
                // Creamos carpeta si no existe
                string rutaCarpeta = Path.Combine(Application.StartupPath, "Tickets_Entradas");
                if (!Directory.Exists(rutaCarpeta)) Directory.CreateDirectory(rutaCarpeta);

                string nombreArchivo = $"Ticket_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
                string rutaCompleta = Path.Combine(rutaCarpeta, nombreArchivo);

                using (StreamWriter ticket = new StreamWriter(rutaCompleta))
                {
                    ticket.WriteLine("      CINEAPP - DULCERÍA      ");
                    ticket.WriteLine("================================");
                    ticket.WriteLine($"OPERACIÓN: {operacion}");
                    ticket.WriteLine($"FECHA: {DateTime.Now:dd/MM/yyyy HH:mm}");
                    ticket.WriteLine($"USUARIO: {Session.UsuarioActual ?? "Admin"}");
                    ticket.WriteLine("--------------------------------");
                    ticket.WriteLine($"PRODUCTO: {txtnombre.Text}");
                    ticket.WriteLine($"CANTIDAD: {txtstock.Text}");
                    ticket.WriteLine($"P. COMPRA: {decimal.Parse(txtprecio.Text):C}");
                    ticket.WriteLine("--------------------------------");
                    ticket.WriteLine($"CÓDIGO: {pictureBox1.Tag}");
                    ticket.WriteLine("================================");
                    ticket.WriteLine("\n\n\n");
                }

                // Abre el bloc de notas con el ticket
                System.Diagnostics.Process.Start(rutaCompleta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar ticket: " + ex.Message);
            }
        }
    }
}