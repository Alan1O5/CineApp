using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms; // Asegúrate de tener esta referencia

namespace CapaPresentacion
{
    public partial class FrmReporteEmpleados : Form
    {
        // Propiedad para recibir la tabla de datos desde el formulario de gestión
        public DataTable DatosPersonal { get; set; }
        public string Fecha { get; set; }

        public FrmReporteEmpleados()
        {
            InitializeComponent();
        }

        private void FrmReporteEmpleados_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Limpiar orígenes de datos previos
                reportViewer1.LocalReport.DataSources.Clear();

                // 2. Vincular el DataTable al DataSet del reporte (.rdlc)
                // IMPORTANTE: El nombre "DataSetPersonal" debe coincidir con el que crees en el diseño RDLC
                ReportDataSource rds = new ReportDataSource("DataSetPersonal", DatosPersonal);
                reportViewer1.LocalReport.DataSources.Add(rds);

                ReportParameter[] parametros = new ReportParameter[]
                {
                    new ReportParameter("pFecha", string.IsNullOrEmpty(this.Fecha) ? DateTime.Now.ToString("dd/MM/yyyy HH:mm") : this.Fecha)
                };

                // 3. Refrescar el visor
                reportViewer1.LocalReport.SetParameters(parametros);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte de personal: " + ex.Message);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            FrmDash principal = this.MdiParent as FrmDash;

            if (principal != null)
            {
                principal.AbrirForm(new FrmListadoPersonal());
            }
        }
    }
}