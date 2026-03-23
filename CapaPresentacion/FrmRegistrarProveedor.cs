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
    public partial class FrmRegistrarProveedor : Form
    {
        public bool Insert = false;
        public bool Edit = false;
        public FrmRegistrarProveedor()
        {
            InitializeComponent();
            CustomUI.LoadDefaultStyle(this);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";

                if (Insert)
                {
                    resp = CNProveedor.Guardar(
                        txtnombre.Text,
                        cmbtipoproducto.Text, 
                        txttelefono.Text,
                        txtrazonsocial.Text,
                        txtrfc.Text
                    );
                }
                else if (Edit)
                {
                    resp = CNProveedor.Editar(
                        Convert.ToInt32(txtidproveedor.Text),
                        txtnombre.Text,
                        cmbtipoproducto.Text,
                        txttelefono.Text,
                        txtrazonsocial.Text,
                        txtrfc.Text
                    );
                }

                if (resp == "OK")
                {
                    MessageBox.Show("Proveedor guardado correctamente", "CineApp", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            FrmListarProveedores form = new FrmListarProveedores();
            form.Show();
            this.Hide();

        }
    


        private void btncancelar_Click(object sender, EventArgs e)
        {
         FrmListarProveedores form = new FrmListarProveedores();
                    form.Show();
                    this.Hide();
        }

        private void FrmRegistrarProveedor_Load(object sender, EventArgs e)
        {
           
        }
    }
}
