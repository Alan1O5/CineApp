using System;
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
            label1.Text = Session.UsuarioActual; // Mostrar usuario
        }

        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            // Registrar logout
            CNUsuarios.RegistrarLogout(Session.LoginId);

            // Limpiar sesión
            Session.UsuarioActual = null;
            Session.LoginId = 0;

            // Volver a login
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
    }
    }

