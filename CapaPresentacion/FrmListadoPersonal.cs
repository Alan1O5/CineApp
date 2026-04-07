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
    public partial class FrmListadoPersonal : Form
    {
        public FrmListadoPersonal()
        {
            InitializeComponent();
            CustomUI.LoadDefaultStyle(this);
        }

        private void FrmListadoPersonal_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        public void Mostrar()
        {
            this.dlistado.DataSource = CNPersonal.Listar();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (rbtnnombre.Checked)
            {
                this.dlistado.DataSource = CNPersonal.BuscarNombre(txtbuscar.Text);
            }
            else if (rbtnusuario.Checked)
            {
                this.dlistado.DataSource = CNPersonal.BuscarUsuario(txtbuscar.Text);
            }
            else
            {
                MessageBox.Show("Seleccione un criterio de búsqueda", "CineApp", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            FrmRegistrarPersonal frm = new FrmRegistrarPersonal();
            frm.Insert = true;
            frm.Edit = false;
            frm.Show();
            this.Hide();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dlistado.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro para editar", "CineApp");
                return;
            }

            FrmRegistrarPersonal frm = new FrmRegistrarPersonal();
            frm.Insert = false;
            frm.Edit = true;

            // Mapeo de datos de la tabla al formulario de registro
            frm.txtidusuario.Text = Convert.ToString(this.dlistado.CurrentRow.Cells["idusuario"].Value);
            frm.txtidempleado.Text = Convert.ToString(this.dlistado.CurrentRow.Cells["idempleado"].Value);
            frm.txtnombre.Text = Convert.ToString(this.dlistado.CurrentRow.Cells["nombre"].Value);
            frm.txtapellidos.Text = Convert.ToString(this.dlistado.CurrentRow.Cells["apellidos"].Value);
            frm.txtdireccion.Text = Convert.ToString(this.dlistado.CurrentRow.Cells["direccion"].Value);
            frm.txttelefono.Text = Convert.ToString(this.dlistado.CurrentRow.Cells["telefono"].Value);
            frm.txtusuario.Text = Convert.ToString(this.dlistado.CurrentRow.Cells["usuario"].Value);
            frm.txtpassword.Text = Convert.ToString(this.dlistado.CurrentRow.Cells["pass"].Value);
            frm.cboacceso.Text = Convert.ToString(this.dlistado.CurrentRow.Cells["acceso"].Value);

            string estado = Convert.ToString(this.dlistado.CurrentRow.Cells["estado"].Value);
            if (estado == "ACTIVO") frm.rbactivo.Checked = true;
            else frm.rbinactivo.Checked = true;

            frm.Show();
            this.Hide();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dlistado.CurrentRow == null) return;

                DialogResult opcion = MessageBox.Show("¿Realmente desea eliminar este registro?", "CineApp", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int idusu = Convert.ToInt32(dlistado.CurrentRow.Cells["idusuario"].Value);
                    int idemp = Convert.ToInt32(dlistado.CurrentRow.Cells["idempleado"].Value);

                    string rpta = CNPersonal.Eliminar(idusu, idemp);
                    if (rpta == "OK")
                    {
                        MessageBox.Show("Registro eliminado correctamente");
                        this.Mostrar();
                    }
                    else MessageBox.Show(rpta);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            FrmMenu form = new FrmMenu();
            form.Show();
            this.Close();
        }

        private void dlistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}