using Microsoft.Reporting.WinForms;
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
    public partial class FrmReporteEntrada : Form
    {
        public DataTable Datos { get; set; }
        public string Folio { get; set; }
        public string Fecha { get; set; }
        public string Responsable { get; set; }
        public string Proveedor { get; set; }

        public FrmReporteEntrada() { InitializeComponent(); }

        private void FrmReporteEntrada_Load(object sender, EventArgs e)
        {
            try
            {
                string rutaReporte = "RptEntradaAlmacen.rdlc"; // O "Reportes/RptEntradaAlmacen.rdlc"

                // Verificación de seguridad
                if (!System.IO.File.Exists(rutaReporte))
                {
                    MessageBox.Show("¡El archivo no existe en la ruta!: " + System.IO.Path.GetFullPath(rutaReporte));
                    return;
                }
                // 1. ESTA ES LA LÍNEA QUE FALTA (Solución a image_87ba3b.png):
                // Asegúrate de que el nombre del archivo sea idéntico al que creaste
                reportViewer1.LocalReport.ReportPath = "RptEntradaAlmacen.rdlc";

                // 2. Limpiar y configurar los datos (basado en image_91abbf.png)
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource rds = new ReportDataSource("dsDetalle", Datos);
                reportViewer1.LocalReport.DataSources.Add(rds);

                // 3. Pasar los parámetros
                ReportParameter[] parametros = new ReportParameter[]
                {
            new ReportParameter("pFolio", this.Folio),
            new ReportParameter("pFecha", this.Fecha),
            new ReportParameter("pResponsable", this.Responsable),
            new ReportParameter("pProveedor", this.Proveedor)
                };

                reportViewer1.LocalReport.SetParameters(parametros);

                // 4. Procesar y mostrar
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                // Esto te dirá el error real (ej: "El parámetro 'pFecha' es requerido pero no se proporcionó")
                string mensajeDetallado = ex.Message;
                if (ex.InnerException != null)
                    mensajeDetallado += " -> " + ex.InnerException.Message;

                MessageBox.Show("Error real: " + mensajeDetallado);
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            FrmDash principal = this.MdiParent as FrmDash;

            if (principal != null)
            {
                principal.AbrirForm(new FrmBitacoraDulces());
            }
        }
    }
}
