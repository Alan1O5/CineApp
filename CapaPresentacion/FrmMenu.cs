using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO;
using CapaDatos;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmMenu : Form
    {
        public string UsuarioActual { get; set; }

        public FrmMenu()
        {
            InitializeComponent();
            CustomUI.LoadDefaultStyle(this);
        }

        public FrmMenu(string usuario)
        {
            InitializeComponent();
            this.UsuarioActual = usuario;
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            label1.Text =  Session.UsuarioActual;

            DataTable dtAlertas = CNProveedor.GenerarAlertas(10);

            if (dtAlertas.Rows.Count > 0)
            {
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show(
                    $"¡ATENCIÓN! Tienes {dtAlertas.Rows.Count} producto(s) a punto de agotarse.",
                    "Alerta de Inventario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                FrmAlertaStock frmAlertas = new FrmAlertaStock();
                frmAlertas.ShowDialog();
            }

           
            if (Session.TipoAcceso == "Administrador")
            {
                btnRespaldos.Visible = true;
                btnpersonal.Visible = true;
                VerificarSistemaRespaldos();
            }
            else
            {
                btnRespaldos.Visible = false;
                btnpersonal.Visible = false;

                if (Session.TipoAcceso == "Dulceria")
                {
                }
            }
        }
        private void VerificarSistemaRespaldos()
        {
            try
            {
                int eliminados = 0;

                DataTable dt = CNBackup.ListarHistorial();

                foreach (DataRow row in dt.Rows)
                {
                    string ruta = row["Ruta del Archivo"].ToString().Trim();
                    int id = Convert.ToInt32(row["Folio"]);

                    if (string.IsNullOrEmpty(ruta) || !File.Exists(ruta))
                    {
                        CNBackup.EliminarRegistro(id);
                        eliminados++;
                    }
                }

                if (eliminados > 0)
                {
                    MessageBox.Show(
                        $"Se eliminaron {eliminados} respaldos inexistentes del sistema.",
                        "Limpieza automática",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    
                }
                
                if (!CNBackup.ExisteRespaldoEsteMes())
                {
                    MessageBox.Show(
                    $"¡ATENCIÓN!, no has realizado el respaldo de este mes, Continua al apartado de respaldos para generarlo", "CineApp",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                    /*string carpeta = @"C:\RespaldosCineapp";

                    if (!Directory.Exists(carpeta))
                        Directory.CreateDirectory(carpeta);

                    string ruta = $@"{carpeta}\Auto_{DateTime.Now:yyyy_MM}.bak";

                    string resp = CNBackup.GenerarBackup(ruta);

                    if (resp == "OK" && File.Exists(ruta))
                    {
                        CNBackup.RegistrarHistorial(ruta, "Sistema");

                        MessageBox.Show(
                            "Se generó automáticamente el respaldo mensual:\n" + ruta,
                            "Respaldo automático",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    else
                    {
                        MessageBox.Show(
                            "No se pudo generar el respaldo automático.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }*/
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en sistema de respaldos");
            }
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            FrmListarPeliculas form = new FrmListarPeliculas();
            form.Show();
            this.Hide();
        }

        private void btnbitacora_Click(object sender, EventArgs e)
        {
            FrmBitacora form = new FrmBitacora();
            form.Show();
            this.Hide();
        }

        private void btninforme_Click(object sender, EventArgs e)
        {
            FrmInformes form = new FrmInformes();
            form.Show();
            this.Hide();
        }

        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            CNUsuarios.RegistrarLogout(Session.LoginId);

            Session.UsuarioActual = null;
            Session.LoginId = 0;

            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmListarPeliculas frm = new FrmListarPeliculas();
            frm.Show();
            this.Hide();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(220, 130);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(200, 120);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmInformes form = new FrmInformes();
            form.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmBitacora form = new FrmBitacora();
            form.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmMenuDulceria form = new FrmMenuDulceria();
            form.Show();
            this.Hide();
        }

        private void btnventa_Click(object sender, EventArgs e)
        {
            FrmPuntoVenta form = new FrmPuntoVenta();
            form.Show();
            this.Hide();
        }

        private void btnRespaldos_Click(object sender, EventArgs e)
        {
            FrmBackups form = new FrmBackups();
            form.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnpersonal_Click(object sender, EventArgs e)
        {
            FrmListadoPersonal form = new FrmListadoPersonal();
            form.Show();
            this.Hide();
        }
    }
}