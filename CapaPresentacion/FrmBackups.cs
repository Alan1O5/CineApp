using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;
using System.IO;

namespace CapaPresentacion
{
    public partial class FrmBackups : Form
    {
        public FrmBackups()
        {
            InitializeComponent();
            CustomUI.LoadDefaultStyle(this);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            FrmMenu form = new FrmMenu();
            form.Show();
            this.Hide();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            string carpeta = @"C:\RespaldosCineapp";

            
            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Archivos de Respaldo SQL (.bak)|.bak";
            save.Title = "Guardar Respaldo Mensual";

            string mesActual = DateTime.Now.ToString("MM");
            string anioActual = DateTime.Now.ToString("yyyy");

            save.FileName = $"Respaldo_Cine_Mes_{mesActual}_{anioActual}.bak";
            save.InitialDirectory = carpeta;

            if (save.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;

                
                CNBackup.RegistrarHistorial(save.FileName, Session.UsuarioActual);

                
                string resp = CNBackup.GenerarBackup(save.FileName);

                Cursor.Current = Cursors.Default;

                if (resp == "OK" && System.IO.File.Exists(save.FileName))
                {

                    MessageBox.Show("¡Respaldo mensual generado exitosamente en:\n" + save.FileName,
                                    "CineApp",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    CargarHistorial();
                }
                else
                {
               
                    MessageBox.Show("El respaldo no se creó correctamente o el archivo no existe.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            DialogResult advertencia = MessageBox.Show(
                "¡PELIGRO! Restaurar un respaldo sobreescribirá toda la base de datos actual con la información del archivo.\n\n¿Estás completamente seguro de continuar?",
                "Advertencia Crítica", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (advertencia == DialogResult.Yes)
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Archivos de Respaldo SQL (*.bak)|*.bak";
                open.Title = "Seleccionar Respaldo a Restaurar";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    // ✅ Verificar que el archivo exista antes de restaurar
                    if (!File.Exists(open.FileName))
                    {
                        MessageBox.Show("El archivo seleccionado no existe.",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return;
                    }

                    Cursor.Current = Cursors.WaitCursor;

                    string resp = CNBackup.RestaurarBackup(open.FileName);

                    Cursor.Current = Cursors.Default;

                    if (resp == "OK")
                    {
                        MessageBox.Show("¡Base de datos restaurada con éxito! El sistema se reiniciará por seguridad.",
                                        "CineApp",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        System.Diagnostics.Process.Start(Application.ExecutablePath);

                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show(resp, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void FrmBackups_Load(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        private void CargarHistorial()
        {
            try
            {
                DataTable dt = CNBackup.ListarHistorial();
                DataTable dtFiltrado = dt.Clone();

                int eliminados = 0;

                foreach (DataRow row in dt.Rows)
                {
                    string ruta = row["Ruta del Archivo"].ToString().Trim();
                    int id = Convert.ToInt32(row["Folio"]); 

                    if (!string.IsNullOrEmpty(ruta) && File.Exists(ruta))
                    {
                        dtFiltrado.ImportRow(row);
                    }
                    else
                    {
                        // ❌ eliminar de BD
                        CNBackup.EliminarRegistro(id);
                        eliminados++;
                    }
                }

                dgvHistorial.DataSource = dtFiltrado;

                if (dgvHistorial.Columns.Contains("Folio"))
                    dgvHistorial.Columns["Folio"].Visible = false;

                dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // 🔔 Notificación
                if (eliminados > 0)
                {
                    MessageBox.Show($"Se eliminaron {eliminados} respaldos inexistentes del historial.",
                                    "Limpieza automática",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}