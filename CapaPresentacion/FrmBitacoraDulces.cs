using CapaDatos;
using CapaNegocio; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmBitacoraDulces : Form
    {
        public FrmBitacoraDulces()
        {
            InitializeComponent();
            CustomUI.LoadDefaultStyle(this);

            dgvmovimientos.DataBindingComplete += Dgvmovimientos_DataBindingComplete;
        }

        private void FrmBitacoraDulces_Load(object sender, EventArgs e)
        {
            if (cmbaccion.Items.Count == 0)
            {
                cmbaccion.Items.Add("TODOS");
                cmbaccion.Items.Add("ENTRADA");
                cmbaccion.Items.Add("SALIDA");
                cmbaccion.SelectedIndex = 0;
            }
            CargarBitacora();
        }

        private void CargarBitacora()
        {
            try
            {
                dgvmovimientos.DataSource = CNDulceria.ListarMovimientos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la bitácora: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbaccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvmovimientos.DataSource != null)
            {
                DataTable dt = (DataTable)dgvmovimientos.DataSource;
                string filtroSeleccionado = cmbaccion.SelectedItem.ToString();

                if (filtroSeleccionado == "TODOS")
                {
                    dt.DefaultView.RowFilter = ""; 
                }
                else
                {
                    dt.DefaultView.RowFilter = $"Movimiento = '{filtroSeleccionado}'";
                }
            }
        }

        private void Dgvmovimientos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvmovimientos.Rows)
            {
                if (row.Cells["Movimiento"].Value != null)
                {
                    string tipoMovimiento = row.Cells["Movimiento"].Value.ToString();

                    if (tipoMovimiento == "ENTRADA")
                    {
                        row.DefaultCellStyle.ForeColor = Color.MediumSeaGreen;
                    }
                    else if (tipoMovimiento == "SALIDA")
                    {
                        row.DefaultCellStyle.ForeColor = Color.IndianRed;
                    }
                }
            }
        }

        private void dgvmovimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            //FrmMenuDulceria form = new FrmMenuDulceria();
            //form.Show();
            this.Hide();
        }

        private void btnverdetalles_Click(object sender, EventArgs e)
        {
            if (dgvmovimientos.CurrentRow == null) return;

            try
            {
                string tipo = dgvmovimientos.CurrentRow.Cells["Movimiento"].Value.ToString().Trim().ToUpper();
                string proveedorCol = dgvmovimientos.CurrentRow.Cells["Proveedor"].Value.ToString().Trim().ToUpper();
                string nombreProductoEnTabla = dgvmovimientos.CurrentRow.Cells["Producto"].Value.ToString(); // Recuperamos el nombre de la fila

                DataTable dtCabecera = null;
                DataTable dtDetalle = null;

                if (proveedorCol.Contains("TICKET #"))
                {
                    int idDocumento = int.Parse(proveedorCol.Replace("TICKET #", "").Trim());

                    if (tipo == "ENTRADA")
                    {
                        dtCabecera = CNDulceria.ObtenerCabeceraCompra(idDocumento);
                        dtDetalle = CNDulceria.ObtenerDetalleCompra(idDocumento);

                        // --- SOLUCIÓN AL ERROR DE LA image_1cc502.png ---
                        if (dtDetalle != null)
                        {
                            // Si la columna no existe, la creamos dinámicamente
                            if (!dtDetalle.Columns.Contains("Producto"))
                            {
                                dtDetalle.Columns.Add("Producto", typeof(string));
                            }

                            // Ahora que ya existe, le asignamos el nombre capturado de la tabla
                            if (dtDetalle.Rows.Count > 0)
                            {
                                dtDetalle.Rows[0]["Producto"] = nombreProductoEnTabla;
                            }
                        }
                    }
                    else if (tipo == "SALIDA")
                    {
                        dtCabecera = CNDulceria.ObtenerCabeceraVenta(idDocumento);
                        dtDetalle = CNDulceria.ObtenerDetalleVenta(idDocumento);
                    }

                    if (dtCabecera != null && dtCabecera.Rows.Count > 0)
                    {
                        DataRow row = dtCabecera.Rows[0];
                        FrmReporteFactura frm = new FrmReporteFactura();

                        frm.Folio = idDocumento.ToString();
                        frm.Fecha = Convert.ToDateTime(row["fechacompra"]).ToString("dd/MM/yyyy HH:mm");
                        frm.Empleado = "Atendido por: " + row["empleado"].ToString();
                        frm.Proveedor = (tipo == "SALIDA") ? "Público General" : row["proveedor"].ToString();

                        // --- LÓGICA DE PRECIOS EN CERO PARA ENTRADAS ---
                        if (tipo == "ENTRADA")
                        {
                            // Forzamos ceros para ingresos administrativos según tu solicitud
                            frm.TotalPagar = "0.00";
                            frm.Subtotal = "0.00";
                            frm.Iva = "0.00";
                        }
                        else
                        {
                            // Para ventas normales, mantenemos el cálculo de impuestos
                            decimal total = Convert.ToDecimal(row["total"]);
                            decimal subtotal = total / 1.16m;
                            decimal iva = total - subtotal;

                            frm.TotalPagar = total.ToString("0.00");
                            frm.Subtotal = subtotal.ToString("0.00");
                            frm.Iva = iva.ToString("0.00");
                        }

                        frm.DatosTicket = dtDetalle;
                        frm.PagoCon = "0.00";
                        frm.Cambio = "0.00";

                        FrmDash principal = this.MdiParent as FrmDash;
                        if (principal != null) principal.AbrirForm(frm);
                        else frm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Este movimiento no tiene un comprobante digital asociado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el ticket: " + ex.Message);
            }
        }
    }
}