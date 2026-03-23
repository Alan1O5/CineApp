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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class FrmInformes : Form
    {
        public FrmInformes()
        {
            InitializeComponent();
            CustomUI.LoadDefaultStyle(this);

        }

        private void FrmInformes_Load(object sender, EventArgs e)
        {
            dgvInformes.DataSource = CNUsuarios.MostrarInformeTiempo();

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            FrmMenu form = new FrmMenu();
            form.Show();
            this.Hide();
        }
    }
}
