using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace CapaPresentacion
{
    public partial class FrmReporteFactura : Form
    {
        // Propiedades públicas para recibir los datos
        public DataTable DatosTicket { get; set; }
        public string TotalPagar { get; set; }
        public string Fecha { get; set; }
        public string Empleado { get; set; }
        public string PagoCon { get; set; }
        public string Cambio { get; set; }
        public string Iva { get; set; }
        public string Subtotal { get; set; }
        public string Folio { get; set; }
        public string Proveedor { get; set; } // Propiedad que usaremos ahora

        public FrmReporteFactura()
        {
            InitializeComponent();
        }

        private void FrmReporteFactura_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Limpiar y configurar el origen de datos (DataTable)
                reportViewer1.LocalReport.DataSources.Clear();
                // Asegúrate que en tu archivo .rdlc el DataSet se llame "dsDetalle"
                ReportDataSource rds = new ReportDataSource("dsDetalle", DatosTicket);
                reportViewer1.LocalReport.DataSources.Add(rds);

                // 2. Definir los parámetros (Agregamos pProveedor)
                // NOTA: Debes crear el parámetro "pProveedor" dentro de tu archivo .rdlc
                ReportParameter[] parametros = new ReportParameter[]
                {
                    new ReportParameter("pFecha", Fecha ?? ""),
                    new ReportParameter("pTotal", TotalPagar ?? "0.00"),
                    new ReportParameter("pEmpleado", Empleado ?? "N/A"),
                    new ReportParameter("pPago", PagoCon ?? "0.00"),
                    new ReportParameter("pCambio", Cambio ?? "0.00"),
                    new ReportParameter("pIva", Iva ?? "0.00"),
                    new ReportParameter("pSubtotal", Subtotal ?? "0.00"),
                    new ReportParameter("pFolio", Folio ?? "0"),
                    new ReportParameter("pProveedor", Proveedor ?? "N/A") // <--- Nueva línea
                };

                // 3. Pasar parámetros y refrescar
                reportViewer1.LocalReport.SetParameters(parametros);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            FrmDash principal = this.MdiParent as FrmDash;

            if (principal != null)
            {
                principal.AbrirForm(new FrmInventarioDulceria());
            }
        }
    }
}