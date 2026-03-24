using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmMenuDulceria : Form
    {
        public FrmMenuDulceria()
        {
            InitializeComponent();
            CustomUI.LoadDefaultStyle(this);
        }

        private void FrmMenuDulceria_Load(object sender, EventArgs e)
        {
            
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            FrmMenu form = new FrmMenu();
            form.Show();
            this.Hide();
        }

        private void btninventario_Click(object sender, EventArgs e)
        {
            FrmInventarioDulceria form = new FrmInventarioDulceria();
            form.Show();
            this.Hide();
        }

        private void btnbitacoradulces_Click(object sender, EventArgs e)
        {
            FrmBitacoraDulces form = new FrmBitacoraDulces();
            form.Show();
            this.Hide();
        }

        private void btnproveedores_Click(object sender, EventArgs e)
        {
            FrmListarProveedores form = new FrmListarProveedores();
            form.Show();
            this.Hide();
        }
    }
}
