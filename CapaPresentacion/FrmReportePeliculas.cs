using CapaNegocio;
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
    public partial class FrmReportePeliculas : Form
    {
        public FrmReportePeliculas()
        {
            InitializeComponent();
        }

        private void FrmReportePeliculas_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Obtenemos los datos desde tu CapaNegocio (CNPeliculas)
                DataTable datos = CNPeliculas.Listar();

                // 2. Limpiamos reportes previos
                this.reportViewer1.LocalReport.DataSources.Clear();

                // 3. Añadimos el origen de datos (El nombre "DataSet1" debe coincidir con el de tu archivo .rdlc)
                ReportDataSource rds = new ReportDataSource("DataSetPeliculas", datos);
                this.reportViewer1.LocalReport.DataSources.Add(rds);

                // 4. Refrescamos el visor
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar reporte: " + ex.Message);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            FrmDash principal = this.MdiParent as FrmDash;

            if (principal != null)
            {
                principal.AbrirForm(new FrmListarPeliculas());
            }
        }
    }
}
