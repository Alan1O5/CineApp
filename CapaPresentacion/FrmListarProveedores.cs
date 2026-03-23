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
    public partial class FrmListarProveedores : Form
    {
        public FrmListarProveedores()
        {
            InitializeComponent();
            CustomUI.LoadDefaultStyle(this);
        }

        private void FrmListarProveedores_Load(object sender, EventArgs e)
        {
            MostrarProveedores();

            
            if (cmbfiltro1.Items.Count == 0)
            {
                cmbfiltro1.Items.Add("Nombre");
                cmbfiltro1.Items.Add("Tipo_Producto");
                cmbfiltro1.Items.Add("RFC");
                cmbfiltro1.SelectedIndex = 0; 
            }
        }

     
        private void MostrarProveedores()
        {
           
            dgvproveedores.DataSource = CNProveedor.Listar();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            FrmRegistrarProveedor frm = new FrmRegistrarProveedor();
            frm.Insert = true; 
            frm.Show();
            this.Hide();
        }

        private void btneditar1_Click(object sender, EventArgs e)
        {
            if (dgvproveedores.CurrentRow != null)
            {
                FrmRegistrarProveedor frm = new FrmRegistrarProveedor();
                frm.Edit = true; 

                frm.txtidproveedor.Text = dgvproveedores.CurrentRow.Cells["idproveedor"].Value.ToString();
                frm.txtnombre.Text = dgvproveedores.CurrentRow.Cells["nombre"].Value.ToString();
                frm.cmbtipoproducto.Text = dgvproveedores.CurrentRow.Cells["tipo_producto"].Value.ToString();
                frm.txttelefono.Text = dgvproveedores.CurrentRow.Cells["telefono"].Value.ToString();
                frm.txtrazonsocial.Text = dgvproveedores.CurrentRow.Cells["razonsocial"].Value.ToString();
                frm.txtrfc.Text = dgvproveedores.CurrentRow.Cells["rfc"].Value.ToString();

                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un proveedor de la lista para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btneliminar1_Click(object sender, EventArgs e)
        {
            if (dgvproveedores.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvproveedores.CurrentRow.Cells["idproveedor"].Value);
                string nombreProv = dgvproveedores.CurrentRow.Cells["nombre"].Value.ToString();

                DialogResult op = MessageBox.Show($"¿Estás seguro de que deseas eliminar al proveedor '{nombreProv}'?",
                                                  "Confirmar Eliminación",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

                if (op == DialogResult.Yes)
                {
                    string rpta = CNProveedor.Eliminar(id);

                    if (rpta == "OK")
                    {
                        MessageBox.Show("Proveedor eliminado correctamente.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarProveedores(); 
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar: " + rpta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un proveedor para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnbuscar1_Click(object sender, EventArgs e)
        {

            string filtro = cmbfiltro1.SelectedItem.ToString().ToLower(); 
            string valorBusqueda = txtbuscar1.Text.Trim();

            
            DataTable dt = (DataTable)dgvproveedores.DataSource;

            if (dt != null)
            {
                if (string.IsNullOrEmpty(valorBusqueda))
                {
            
                    dt.DefaultView.RowFilter = "";
                }
                else
                {
                    dt.DefaultView.RowFilter = $"{filtro} LIKE '%{valorBusqueda}%'";
                }
            }
        }

        private void btnsalir1_Click(object sender, EventArgs e)
        {
            
            FrmMenuDulceria menu = new FrmMenuDulceria();
            menu.Show();
            this.Close();
        }

        private void cmbfiltro1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Opcional: Limpiar la caja de búsqueda cuando cambian el filtro
            if (txtbuscar1 != null)
            {
                txtbuscar1.Text = "";
                btnbuscar1_Click(sender, e); // Ejecutamos la búsqueda para resetear la tabla
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}