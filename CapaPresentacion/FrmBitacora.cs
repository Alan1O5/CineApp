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

    public partial class FrmBitacora : Form
    {
        public FrmBitacora()
        {
            InitializeComponent();
            CustomUI.LoadDefaultStyle(this);

        }

        private void FrmBitacora_Load(object sender, EventArgs e)
        {
            cmbaccion.Items.Clear();
            cmbaccion.Items.Add("Todos");
            cmbaccion.Items.Add("Ediciones");
            cmbaccion.Items.Add("Eliminaciones");

            cmbaccion.SelectedIndex = 0; 

            dgvBitacora.DataSource = CNPeliculas.MostrarBitacora();
        }
      
          public void Filtrar()
        {
            string accion = cmbaccion.SelectedItem.ToString();

            if (accion == "Todos")
                dgvBitacora.DataSource = CNPeliculas.MostrarBitacora();
            else if (accion == "Ediciones")
                dgvBitacora.DataSource = CNPeliculas.MostrarEdiciones(string.Empty);
            else if (accion == "Eliminaciones")
                dgvBitacora.DataSource = CNPeliculas.MostrarEliminaciones(string.Empty);
        }

       
        private void cmbaccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            FrmMenu form = new FrmMenu();
            form.Show();
            this.Hide();
        }

      
    }
}
