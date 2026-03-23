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
    public partial class FrmAlertaStock : Form
    {
        public FrmAlertaStock()
        {
            InitializeComponent();
            CustomUI.LoadDefaultStyle(this);

        }

        private void dgvalertas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvalertas.Columns[e.ColumnIndex].Name == "btnPedido")
            {
                int idProd = Convert.ToInt32(dgvalertas.Rows[e.RowIndex].Cells["idproducto"].Value);
                string nombreProd = dgvalertas.Rows[e.RowIndex].Cells["Producto"].Value.ToString();
                int stockActual = Convert.ToInt32(dgvalertas.Rows[e.RowIndex].Cells["StockActual"].Value);
                string proveedor = dgvalertas.Rows[e.RowIndex].Cells["NombreComercial"].Value.ToString();

                FrmRegistrarPedido frmPedido = new FrmRegistrarPedido(idProd, nombreProd, stockActual, proveedor);
                frmPedido.ShowDialog();

                CargarAlertas();
            }
        }

        private void FrmAlertaStock_Load(object sender, EventArgs e)
        {
            DataTable dtAlertas = CNProveedor.GenerarAlertas(10);
            CargarAlertas();
            dgvalertas.DataSource = dtAlertas;

            foreach (DataGridViewRow row in dgvalertas.Rows)
            {
                row.DefaultCellStyle.BackColor = System.Drawing.Color.MistyRose;
                row.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkRed;
            }
        }

        private void CargarAlertas()
        {
            dgvalertas.DataSource = CNProveedor.GenerarAlertas(10); 
            if (!dgvalertas.Columns.Contains("btnPedido"))
            {
                DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                btnCol.Name = "btnPedido";
                btnCol.HeaderText = "Acción";
                btnCol.Text = "Realizar Pedido";
                btnCol.UseColumnTextForButtonValue = true; 
                dgvalertas.Columns.Add(btnCol);
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



    
      
   
