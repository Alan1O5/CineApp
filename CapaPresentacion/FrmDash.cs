using CapaDatos;
using System;
using System.Drawing;
using System.Windows.Forms;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class FrmDash : Form
    {
        string opcion = "";
        bool expanderdulceria = false;
        public string UsuarioActual { get; set; }

        public FrmDash()
        {
            InitializeComponent();
            

        }

        public FrmDash(string usuario)
        {
            InitializeComponent();
            this.UsuarioActual = usuario;
        }

        private void FrmDash_Load(object sender, EventArgs e)
        {
            lblNombre.Text = Session.UsuarioActual;

            // 🔽 Altura inicial (solo botón)
            mnudulceria.Height = 85;
            ConfigurarBoton(btnlistarpelicula, Properties.Resources.sticker_ticket_bullet_journal_line_art_free_png);       
        
        }
        private void ConfigurarBoton(Button btn, Image icono)
        {
            btn.Image = new Bitmap(icono, new Size(32, 32));
            btn.ImageAlign = ContentAlignment.MiddleLeft;
            btn.TextAlign = ContentAlignment.MiddleRight;
            btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn.Padding = new Padding(10, 0, 10, 0);
        }
        // 🔥 MÉTODO MDI
        private void AbrirForm(Form formHijo)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            formHijo.MdiParent = this;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            formHijo.Show();
        }

        // 🎬 PELÍCULAS
        private void btnlistarpelicula_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmListarPeliculas());
        }

        // 📊 INFORMES
        private void btninformeusuarios_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmInformes());
        }

        // 📋 BITÁCORA
        private void btnbitacoramovimientos_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmBitacora());
        }

        // 🍿 BOTÓN DULCERÍA
        private void btndulceria_Click(object sender, EventArgs e)
        {
            opcion = "mnudulceria";
            timerdulceria.Start();
        }

        // 🔥 TIMER (EXPANDIR / CONTRAER)
        private void timerdulceria_Tick(object sender, EventArgs e)
        {
            int velocidad = 10;

            if (opcion == "mnudulceria")
            {
                if (expanderdulceria)
                {
                    // 🔽 CONTRAER
                    if (mnudulceria.Height > 85)
                    {
                        mnudulceria.Height -= velocidad;

                        // 🔥 SUBIR BOTONES
                        mnupuntoventa.Top -= velocidad;
                        mnurespaldo.Top -= velocidad;
                        mnupersonal.Top -= velocidad;
                    }
                    else
                    {
                        mnudulceria.Height = 85;
                        expanderdulceria = false;
                        timerdulceria.Stop();
                    }
                }
                else
                {
                    // 🔼 EXPANDIR
                    if (mnudulceria.Height < 232)
                    {
                        mnudulceria.Height += velocidad;

                        // 🔥 BAJAR BOTONES
                        mnupuntoventa.Top += velocidad;
                        mnurespaldo.Top += velocidad;
                        mnupersonal.Top += velocidad;
                    }
                    else
                    {
                        mnudulceria.Height = 232;
                        expanderdulceria = true;
                        timerdulceria.Stop();
                    }
                }
            }
        }
        // 🍫 INVENTARIO
        private void btninventario_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmInventarioDulceria());
        }

        // 📦 MOVIMIENTOS
        private void btnmovimientos_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmBitacoraDulces());
        }

        // 🚚 PROVEEDORES
        private void btnproveedores_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmListarProveedores());
        }

        // 💰 VENTA
        private void btnpuntoventa_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmPuntoVenta());
        }

        // 💾 RESPALDO
        private void btnrespaldo_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmBackups());
        }

        // 👤 PERSONAL
        private void btnpersonal_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmListadoPersonal());
        }
        private void mnudulceria_Paint(object sender, PaintEventArgs e)
        {
            // vacío
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
        "¿Desea cerrar sesión?",
        "Cerrar Sesión",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (resultado == DialogResult.Yes)
            {
                Session.UsuarioActual = "";

                FrmLogin login = new FrmLogin();
                login.Show();

                this.Close();
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnmaximizar.Visible = true;
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible = false;
            btnrestaurar.Visible = true;
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

    }
}