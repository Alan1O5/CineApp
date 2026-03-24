using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
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

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            label1.Text = Session.UsuarioActual; 
            DataTable dtAlertas = CNProveedor.GenerarAlertas(10); 

            if (dtAlertas.Rows.Count > 0)
            {
                System.Media.SystemSounds.Exclamation.Play();

                MessageBox.Show(
                    $"¡ATENCIÓN! Tienes {dtAlertas.Rows.Count} producto(s) a punto de agotarse.\n\nEl sistema abrirá la ventana de pedidos para que contactes a los proveedores.",
                    "Alerta de Inventario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                FrmAlertaStock frmAlertas = new FrmAlertaStock();
                frmAlertas.ShowDialog(); 
            }
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
    }
}

