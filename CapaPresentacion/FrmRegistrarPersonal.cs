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
    public partial class FrmRegistrarPersonal : Form
    {
        public bool Insert = false;
        public bool Edit = false;

        public FrmRegistrarPersonal()
        {
            InitializeComponent();
            CustomUI.LoadDefaultStyle(this);
        }

        private void FrmRegistrarPersonal_Load(object sender, EventArgs e)
        {
            txtidusuario.Visible = false;
            txtidempleado.Visible = false;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                string estado = rbactivo.Checked ? "ACTIVO" : "INACTIVO";

                if (txtnombre.Text == "" || txtapellidos.Text == "" || txtusuario.Text == "" || txtpassword.Text == "")
                {
                    MessageBox.Show("Faltan datos obligatorios", "CineApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (this.Insert)
                    {
                        rpta = CNPersonal.Guardar(
                            txtnombre.Text.Trim(),
                            txtapellidos.Text.Trim(),
                            txtdireccion.Text.Trim(),
                            txttelefono.Text.Trim(),
                            txtusuario.Text.Trim(),
                            txtpassword.Text.Trim(),
                            cboacceso.Text,
                            estado);
                    }
                    else if (this.Edit)
                    {
                        rpta = CNPersonal.Editar(
                            Convert.ToInt32(txtidusuario.Text),
                            Convert.ToInt32(txtidempleado.Text),
                            txtnombre.Text.Trim(),
                            txtapellidos.Text.Trim(),
                            txtdireccion.Text.Trim(),
                            txttelefono.Text.Trim(),
                            txtusuario.Text.Trim(),
                            txtpassword.Text.Trim(),
                            cboacceso.Text,
                            estado);
                    }

                    if (rpta == "OK")
                    {
                        MessageBox.Show("Operación realizada con éxito");
                        FrmListadoPersonal listado = new FrmListadoPersonal();
                        listado.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error: " + rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            FrmListadoPersonal listado = new FrmListadoPersonal();
            listado.Show();
            this.Hide();
        }
    }
}