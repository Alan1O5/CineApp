using System;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmRegistrarPelicula : Form
    {

        public FrmRegistrarPelicula()
        {
            InitializeComponent();
            CustomUI.LoadDefaultStyle(this);
        }

        private void FrmRegistrarPelicula_Load_1(object sender, EventArgs e)
        {
            if (Insert)
                btnguardar.Text = "Guardar";
            else if (Edit)
                btnguardar.Text = "Editar";
        }

        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string resp = "";

                if (Insert)
                {
                    resp = CNPeliculas.Guardar(
                        txtnombre.Text,
                        Convert.ToInt32(txtduracion.Text),
                        txtclasificacion.Text,
                        txtgenero.Text,
                        txtidioma.Text
                    );
                }
                else if (Edit)
                {
                    resp = CNPeliculas.Editar(
                        Convert.ToInt32(txtidpelicula.Text),
                        txtnombre.Text,
                        Convert.ToInt32(txtduracion.Text),
                        txtclasificacion.Text,
                        txtgenero.Text,
                        txtidioma.Text
                    );
                }

                if (resp == "OK")
                {
                    MessageBox.Show("Registro guardado correctamente",
                        "CineApp", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    new FrmListarPeliculas().Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(resp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncancelar_Click_1(object sender, EventArgs e)
        {
            new FrmListarPeliculas().Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtidpelicula_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtgenero_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtduracion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
