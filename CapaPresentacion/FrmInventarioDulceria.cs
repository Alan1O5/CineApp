using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmInventarioDulceria : Form
    {  
        Dictionary<int, decimal> preciosAnteriores = new Dictionary<int, decimal>();

        public FrmInventarioDulceria()
        {
            InitializeComponent();
            CustomUI.LoadDefaultStyle(this);

        }

    
           private void FrmInventarioDulceria_Load(object sender, EventArgs e)
        {

            dgvdulceria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvdulceria.MultiSelect = false;
            dgvdulceria.DataBindingComplete += dgvdulceria_DataBindingComplete;

            Listar();
            dgvdulceria.Columns.Add("CambioPrecio", "Cambio");
        }


        private void Listar()
        {
            DataTable tabla = CNDulceria.Listar();

            foreach (DataRow row in tabla.Rows)
            {
                int id = Convert.ToInt32(row["idproducto"]);
                decimal precio = Convert.ToDecimal(row["precio"]);

                if (!preciosAnteriores.ContainsKey(id))
                    preciosAnteriores.Add(id, precio);
            }

            dgvdulceria.DataSource = tabla;
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            FrmMenuDulceria form = new FrmMenuDulceria();
            form.Show();
            this.Hide();
        }

        private void cmbtipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            FrmRegistrarDulceria frm = new FrmRegistrarDulceria();
            frm.Insert = true;
            frm.Show();
            this.Hide();
        }

        private void bnteditar_Click(object sender, EventArgs e)
        {
            FrmRegistrarDulceria frm = new FrmRegistrarDulceria();
            frm.Edit = true;

            frm.txtidproducto.Text = dgvdulceria.CurrentRow.Cells["idproducto"].Value.ToString();
            frm.txtnombre.Text = dgvdulceria.CurrentRow.Cells["nombre"].Value.ToString();
            frm.txttipo.Text = dgvdulceria.CurrentRow.Cells["tipo"].Value.ToString();
            frm.txtprecio.Text = dgvdulceria.CurrentRow.Cells["precio"].Value.ToString();
            frm.txtstock.Text = dgvdulceria.CurrentRow.Cells["stock"].Value.ToString();

            frm.Show();
            this.Hide();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgvdulceria.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un producto");
                return;
            }

            int id = Convert.ToInt32(dgvdulceria.CurrentRow.Cells["idproducto"].Value);

            DialogResult op = MessageBox.Show(
                "¿Deseas eliminar el producto?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (op == DialogResult.Yes)
            {
                string r = CNDulceria.Eliminar(id);

                if (r == "OK")
                {
                    MessageBox.Show("Producto eliminado correctamente");
                    Listar();
                }
                else
                {
                    MessageBox.Show(r);
                }
            }
        }

        private void dgvdulceria_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
        
            if (dgvdulceria.CurrentRow == null)
                return;

            string codigo = "DUL" + dgvdulceria.CurrentRow.Cells["idproducto"].Value.ToString();

            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.CODE_128;

            Bitmap barcode = writer.Write(codigo);

            pictureBoxCodigo.Image = barcode;
       
    }

        private void btndescargar_Click(object sender, EventArgs e)
        {
         
            if (pictureBoxCodigo.Image == null)
                return;

            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "PNG|*.png";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                pictureBoxCodigo.Image.Save(guardar.FileName);
                MessageBox.Show("Código de barras guardado");
            }
        
    }
        private void dgvdulceria_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvdulceria.Rows)
            {
                int id = Convert.ToInt32(row.Cells["idproducto"].Value);
                decimal precioActual = Convert.ToDecimal(row.Cells["precio"].Value);

                if (preciosAnteriores.ContainsKey(id))
                {
                    decimal precioAnterior = preciosAnteriores[id];

                    if (precioActual > precioAnterior)
                    {
                        row.Cells["CambioPrecio"].Value = "↑";
                        row.Cells["CambioPrecio"].Style.ForeColor = Color.Green;
                    }
                    else if (precioActual < precioAnterior)
                    {
                        row.Cells["CambioPrecio"].Value = "↓";
                        row.Cells["CambioPrecio"].Style.ForeColor = Color.Red;
                    }
                }

                preciosAnteriores[id] = precioActual;
            }
        }
    }
}
