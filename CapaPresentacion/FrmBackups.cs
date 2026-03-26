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
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Archivos de Respaldo SQL (*.bak)|*.bak";
            save.Title = "Guardar Respaldo Mensual";

            string mesActual = DateTime.Now.ToString("MM");
            string anioActual = DateTime.Now.ToString("yyyy");
            save.FileName = $"Respaldo_Cine_Mes_{mesActual}_{anioActual}.bak";
            save.InitialDirectory = @"C:\RespaldosCineapp";
            if (save.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                string resp = CNBackup.GenerarBackup(save.FileName);
                Cursor.Current = Cursors.Default;

                if (resp == "OK")
                {
                    CNBackup.RegistrarHistorial(save.FileName, Session.UsuarioActual);

                    MessageBox.Show("¡Respaldo mensual generado exitosamente en:\n" + save.FileName, "CineApp", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarHistorial();
                }
                else
                {
                    MessageBox.Show(resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Cursor.Current = Cursors.WaitCursor;

                    string resp = CNBackup.RestaurarBackup(open.FileName);

                    Cursor.Current = Cursors.Default;

                    if (resp == "OK")
                    {
                        MessageBox.Show("¡Base de datos restaurada con éxito! El sistema se reiniciará por seguridad.", "CineApp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Restart(); 
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
                dgvHistorial.DataSource = CNBackup.ListarHistorial();

                if (dgvHistorial.Columns.Contains("Folio"))
                    dgvHistorial.Columns["Folio"].Visible = false;

                dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
