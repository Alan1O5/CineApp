using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CapaDatos;

namespace CineApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion conn = new Conexion();

                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM peliculas",
                    conn.AbrirConexion()
                );

                DataTable dt = new DataTable();
                da.Fill(dt);


                conn.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CapaPresentacion.FrmListarPeliculas frm = new CapaPresentacion.FrmListarPeliculas();
            frm.Show();
        }
    }
}
