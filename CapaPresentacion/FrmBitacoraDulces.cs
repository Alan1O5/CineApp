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
    public partial class FrmBitacoraDulces : Form
    {
        public FrmBitacoraDulces()
        {
            InitializeComponent();
            CustomUI.LoadDefaultStyle(this);

            dgvmovimientos.DataBindingComplete += Dgvmovimientos_DataBindingComplete;
        }

        private void FrmBitacoraDulces_Load(object sender, EventArgs e)
        {
            if (cmbaccion.Items.Count == 0)
            {
                cmbaccion.Items.Add("TODOS");
                cmbaccion.Items.Add("ENTRADA");
                cmbaccion.Items.Add("SALIDA");
                cmbaccion.SelectedIndex = 0;
            }
            CargarBitacora();
        }

        private void CargarBitacora()
        {
            try
            {
                dgvmovimientos.DataSource = CNDulceria.ListarMovimientos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la bitácora: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbaccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvmovimientos.DataSource != null)
            {
                DataTable dt = (DataTable)dgvmovimientos.DataSource;
                string filtroSeleccionado = cmbaccion.SelectedItem.ToString();

                if (filtroSeleccionado == "TODOS")
                {
                    dt.DefaultView.RowFilter = ""; 
                }
                else
                {
                    dt.DefaultView.RowFilter = $"Movimiento = '{filtroSeleccionado}'";
                }
            }
        }

        private void Dgvmovimientos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvmovimientos.Rows)
            {
                if (row.Cells["Movimiento"].Value != null)
                {
                    string tipoMovimiento = row.Cells["Movimiento"].Value.ToString();

                    if (tipoMovimiento == "ENTRADA")
                    {
                        row.DefaultCellStyle.ForeColor = Color.MediumSeaGreen;
                    }
                    else if (tipoMovimiento == "SALIDA")
                    {
                        row.DefaultCellStyle.ForeColor = Color.IndianRed;
                    }
                }
            }
        }

        private void dgvmovimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            FrmMenuDulceria form = new FrmMenuDulceria();
            form.Show();
            this.Hide();
        }
    }
}