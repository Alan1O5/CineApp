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
                // 1. Capturamos los datos básicos de la fila seleccionada
                string tipo = dgvmovimientos.CurrentRow.Cells["Movimiento"].Value.ToString().Trim().ToUpper();
                string proveedorCol = dgvmovimientos.CurrentRow.Cells["Proveedor"].Value.ToString().Trim().ToUpper();
                string nombreProductoEnTabla = dgvmovimientos.CurrentRow.Cells["Producto"].Value.ToString();

                // 2. Validamos que tenga un comprobante asociado
                if (proveedorCol.Contains("TICKET #"))
                {
                    int idDocumento = int.Parse(proveedorCol.Replace("TICKET #", "").Trim());
                    FrmDash principal = this.MdiParent as FrmDash;

                    // --- CASO A: ENTRADA DE ALMACÉN (Nuevo Reporte Administrativo) ---
                    if (tipo == "ENTRADA")
                    {
                        DataTable dtCab = CNDulceria.ObtenerCabeceraCompra(idDocumento);
                        DataTable dtDet = CNDulceria.ObtenerDetalleCompra(idDocumento);

                        // Aseguramos que la columna 'Producto' exista para el reporte (image_91abbf.png)
                        if (dtDet != null)
                        {
                            if (!dtDet.Columns.Contains("Producto"))
                            {
                                dtDet.Columns.Add("Producto", typeof(string));
                            }
                            if (dtDet.Rows.Count > 0)
                            {
                                dtDet.Rows[0]["Producto"] = nombreProductoEnTabla;
                            }
                        }

                        // Abrimos el nuevo formulario de entrada
                        FrmReporteEntrada frmE = new FrmReporteEntrada();
                        frmE.Folio = idDocumento.ToString();
                        frmE.Fecha = Convert.ToDateTime(dtCab.Rows[0]["fechacompra"]).ToString("dd/MM/yyyy HH:mm");
                        frmE.Responsable = dtCab.Rows[0]["empleado"].ToString();
                        frmE.Proveedor = dtCab.Rows[0]["proveedor"].ToString();
                        frmE.Datos = dtDet; // idproducto, Producto, cantidad

                        if (principal != null) principal.AbrirForm(frmE);
                        else frmE.ShowDialog();
                    }
                    // --- CASO B: SALIDA DE VENTA (Reporte de Factura Original) ---
                    else if (tipo == "SALIDA")
                    {
                        DataTable dtCab = CNDulceria.ObtenerCabeceraVenta(idDocumento);
                        DataTable dtDet = CNDulceria.ObtenerDetalleVenta(idDocumento);

                        if (dtCab != null && dtCab.Rows.Count > 0)
                        {
                            DataRow row = dtCab.Rows[0];
                            FrmReporteFactura frmV = new FrmReporteFactura();

                            frmV.Folio = idDocumento.ToString();
                            frmV.Fecha = Convert.ToDateTime(row["fechacompra"]).ToString("dd/MM/yyyy HH:mm");
                            frmV.Empleado = "Atendido por: " + row["empleado"].ToString();
                            frmV.Proveedor = "Público General";

                            // Cálculo de importes para la venta
                            decimal total = Convert.ToDecimal(row["total"]);
                            decimal subtotal = total / 1.16m;
                            decimal iva = total - subtotal;

                            frmV.TotalPagar = total.ToString("0.00");
                            frmV.Subtotal = subtotal.ToString("0.00");
                            frmV.Iva = iva.ToString("0.00");

                            frmV.DatosTicket = dtDet;
                            frmV.PagoCon = "0.00";
                            frmV.Cambio = "0.00";

                            if (principal != null) principal.AbrirForm(frmV);
                            else frmV.ShowDialog();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Este movimiento no tiene un comprobante digital asociado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el detalle: " + ex.Message);
            }
        }
    }
}