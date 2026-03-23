using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class FrmListarPeliculas : Form
    {
        
        public FrmListarPeliculas()
        {
            InitializeComponent();
        }

        private void FrmListarPeliculas_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            cmbfiltro1.Items.Add("Nombre");
            cmbfiltro1.Items.Add("Genero");
            cmbfiltro1.Items.Add("Duracion");
            cmbfiltro1.Items.Add("Clasificacion");
            cmbfiltro1.Items.Add("Idioma");

            cmbfiltro1.SelectedIndex = 0;
            MessageBox.Show(CNPeliculas.Listar().Rows.Count.ToString());


            Mostrar();
        }


        public void Mostrar()
        {
            dlistado1.DataSource = CNPeliculas.Listar();
        }


        public void BuscarNombre()
        {
            dlistado1.DataSource = CNPeliculas.BuscarNombre(txtbuscar1.Text);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbfiltro1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbuscar1_TextChanged(object sender, EventArgs e)
        {
            btnbuscar1.PerformClick();

        }

        private void btnbuscar1_Click(object sender, EventArgs e)
        {
   string filtro = cmbfiltro1.SelectedItem.ToString();

            if (filtro == "Nombre")
            {
                BuscarNombre();
            }
            else
            {
                MessageBox.Show("Filtro aún no implementado",
                    "CineApp", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnsalir1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            FrmRegistrarPelicula form = new FrmRegistrarPelicula();

            form.Insert = true;

            form.Show();
            this.Hide();
        }

        private void btneditar1_Click(object sender, EventArgs e)
        {
            FrmRegistrarPelicula form = new FrmRegistrarPelicula();
            form.Edit = true;

            form.txtidpelicula.Text = dlistado1.CurrentRow.Cells["idpelicula"].Value.ToString();
            form.txtnombre.Text = dlistado1.CurrentRow.Cells["nombre"].Value.ToString();
            form.txtduracion.Text = dlistado1.CurrentRow.Cells["duracion"].Value.ToString();
            form.txtclasificacion.Text = dlistado1.CurrentRow.Cells["clasificacion"].Value.ToString();
            form.txtgenero.Text = dlistado1.CurrentRow.Cells["genero"].Value.ToString();
            form.txtidioma.Text = dlistado1.CurrentRow.Cells["idioma"].Value.ToString();

            form.Show();
            this.Hide();
        }

        private void btneliminar1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion = MessageBox.Show(
                    "¿Desea eliminar la película seleccionada?",
                    "CineApp",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (opcion == DialogResult.OK && dlistado1.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dlistado1.CurrentRow.Cells["idpelicula"].Value);
                    CNPeliculas.Eliminar(id);

                    MessageBox.Show("Película eliminada correctamente",
                        "CineApp", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
